using Core.DB;
using Core.Entities;
using Core.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using UI.Properties;

namespace UI.Forms
{
    public partial class MainForm : Form
    {
        internal User CurrentUser;

        internal List<MainDataSource> mainData;
        internal List<SummarySource> summarySources;

        public MainForm(User user)
        {
            InitializeComponent();

            CurrentUser = user;
            Icon = Resources.MainIcon;
            mainData = new List<MainDataSource>();
            summarySources = new List<SummarySource>();

            var firstMonthDay = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpTimeFrom.Value = firstMonthDay;
            dtpTimeTo.Value = new DateTime(firstMonthDay.Year, firstMonthDay.Month, firstMonthDay.AddMonths(1).AddDays(-1).Day);

            Init();
        }

        private void Init()
        {
            miUser.Text = CurrentUser.FIO;

            if (CurrentUser.UserAvatar != null)
                using (var imageStream = new MemoryStream(CurrentUser.UserAvatar))
                {
                    miUser.Image = Image.FromStream(imageStream);
                }

            if (CurrentUser.Group == null)
            {
                miCreateGroup.Visible = true;
                miRequestGroup.Visible = true;
                miInviteInGroup.Visible = false;
                miGroupSeparator.Visible = false;
                miDeleteGroup.Visible = false;
                miLeaveGroup.Visible = false;
                miOpenGroup.Visible = false;
            }
            else
            {
                miCreateGroup.Visible = false;
                miRequestGroup.Visible = false;
                miInviteInGroup.Visible = true;
                miGroupSeparator.Visible = true;
                miDeleteGroup.Visible = true;
                miLeaveGroup.Visible = true;
                miOpenGroup.Visible = true;
                miGroup.Text = CurrentUser.Group.Name;
            }

            #region Clear Data

            mainDataGrid.Rows.Clear();
            mainDataGrid.Columns.Clear();

            mainData.Clear();
            summarySources.Clear();

            #endregion

            #region Main Data
            DBManager db = DBManager.GetInstance();

            var parameters = new List<Tuple<string, object>>()
                {
                    new Tuple<string, object>("DateStart", dtpTimeFrom.Value),
                    new Tuple<string, object>("DateEnd", dtpTimeTo.Value),
                    new Tuple<string, object>("UserId", CurrentUser.UserId),
                    new Tuple<string, object>("GroupId", (CurrentUser.Group == null ? Guid.Empty : CurrentUser.Group.GroupId))
                };

            var mainDataSet = db.ExecuteProcedure("spGetMainDataSource", parameters.ToArray());

            foreach (DataRow row in mainDataSet.Tables[0].Rows)
            {
                mainData.Add(new MainDataSource() { ActionDate = (DateTime)row[0], ActionTypeName = row[1].ToString(), ActionCategoryName = row[2].ToString(), UserName = row[3].ToString(), Summ = (decimal)row[4] });
             
            }

            foreach (DataRow row in mainDataSet.Tables[1].Rows)
            {
                label4.Text = row[4].ToString();
                label5.Text = row[3].ToString();
            }

            #endregion

            #region Main Data Grid

            mainDataGrid.ColumnHeadersHeight = 60;

            mainDataGrid.TopLeftHeaderCell.Value = "Дата";
            mainDataGrid.TopLeftHeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            mainDataGrid.RowHeadersWidth = 100;

            DataGridViewTextBoxColumn incomeColumn = new DataGridViewTextBoxColumn();
            incomeColumn.HeaderText = "Суммарный приход";
            incomeColumn.Width = 100;

            DataGridViewTextBoxColumn outcomeColumn = new DataGridViewTextBoxColumn();
            outcomeColumn.HeaderText = "Суммарный расход";
            outcomeColumn.Width = 100;

            mainDataGrid.Columns.AddRange(incomeColumn, outcomeColumn);

            var users = mainData.Select(md => md.UserName).Distinct().ToList();

            foreach (var user in users)
            {
                var column = new DataGridViewTextBoxColumn();
                column.HeaderText = "Приход\n" + user;
                column.Width = 100;

                mainDataGrid.Columns.Add(column);
            }

            foreach (var user in users)
            {
                var column = new DataGridViewTextBoxColumn();
                column.HeaderText = "Расход\n" + user;
                column.Width = 100;

                mainDataGrid.Columns.Add(column);
            }

            using (IRepository<ActionCategory> actionCategoryRep = new ActionCategoryRepository())
            {
                var actionCategories = actionCategoryRep.GetList().OrderBy(ac => ac.Priority).ToList();

                foreach (var category in actionCategoryRep.GetList().OrderBy(ac => ac.Priority).ToList())
                {
                    foreach (var user in users)
                    {
                        var column = new DataGridViewTextBoxColumn();
                        column.HeaderText = category.Name + "\n" + user;
                        column.Width = 80;

                        mainDataGrid.Columns.Add(column);
                    }
                }

                foreach (DataGridViewColumn column in mainDataGrid.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                    column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }

                foreach (DataGridViewRow row in mainDataGrid.Rows)
                {
                    row.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }

                var days = mainData.Select(md => md.ActionDate).Distinct().ToList();

                foreach (var day in days)
                {
                    var row = new DataGridViewRow();
                    row.HeaderCell.Value = day.ToString("dd-MM-yyyy");

                    mainDataGrid.Rows.Add(row);

                    foreach (var category in actionCategories)
                    {
                        foreach (var user in users)
                        {
                            var ds = mainData.FirstOrDefault(md => md.ActionDate == day && md.ActionCategoryName == category.Name && md.UserName == user);

                            switch ((ActionTypes)Enum.Parse(typeof(ActionTypes), ds.ActionTypeName))
                            {
                                case ActionTypes.Приход:
                                    if (!Constants.Debts.Contains(actionCategories.FirstOrDefault(ac => ac.Name == ds.ActionCategoryName).Priority))
                                    {
                                        if (!summarySources.Select(ss => new { ss.Day, ss.UserName }).Contains(new { Day = day, UserName = user }))
                                            summarySources.Add(new SummarySource() { Day = day, UserName = user, SummaryIncome = ds.Summ, SummaryConsumption = 0 });
                                        else
                                            summarySources.First(ss => ss.Day == day && ss.UserName == user).SummaryIncome += ds.Summ;
                                    }

                                    if (ds.Summ != 0)
                                        InsertCellValue(ds.Summ, day, 2 + 2 * users.Count + category.Priority * users.Count + users.IndexOf(user));
                                    break;
                                case ActionTypes.Расход:
                                    if (!Constants.Debts.Contains(actionCategories.FirstOrDefault(ac => ac.Name == ds.ActionCategoryName).Priority))
                                    {
                                        if (!summarySources.Select(ss => new { ss.Day, ss.UserName }).Contains(new { Day = day, UserName = user }))
                                            summarySources.Add(new SummarySource() { Day = day, UserName = user, SummaryIncome = 0, SummaryConsumption = ds.Summ });
                                        else
                                            summarySources.First(ss => ss.Day == day && ss.UserName == user).SummaryConsumption += ds.Summ;
                                    }

                                    if (ds.Summ != 0)
                                        InsertCellValue(ds.Summ, day, 2 + 2 * users.Count + category.Priority * users.Count + users.IndexOf(user));
                                    break;
                                default:
                                    break;
                            }
                        }
                    }

                    foreach (var user in users)
                    {
                        var summIncome = summarySources.Where(ss => ss.UserName == user && ss.Day == day).FirstOrDefault().SummaryIncome;
                        var summConsumption = summarySources.Where(ss => ss.UserName == user && ss.Day == day).FirstOrDefault().SummaryConsumption;

                        if (summIncome != 0)
                            InsertCellValue(summIncome, day, 2 + users.IndexOf(user));
                        if (summConsumption != 0)
                            InsertCellValue(summConsumption, day, 2 + users.Count + users.IndexOf(user));
                    }

                    var totalIncome = summarySources.Where(ss => ss.Day == day).Select(ss => ss.SummaryIncome).Sum();
                    var totalConsumption = summarySources.Where(ss => ss.Day == day).Select(ss => ss.SummaryConsumption).Sum();

                    if (totalIncome != 0)
                        InsertCellValue(totalIncome, day, 0);
                    if (totalConsumption != 0)
                        InsertCellValue(totalConsumption, day, 1);
                }
            }

            #endregion



        }

        private void InsertCellValue(decimal value, DateTime day, int cellIndex)
        {
            for (int i = 0; i < mainDataGrid.Rows.Count; i++)
            {
                if (Convert.ToDateTime(mainDataGrid.Rows[i].HeaderCell.Value).Date == day.Date)
                {
                    mainDataGrid.Rows[i].Cells[cellIndex].Value = Math.Round(value);
                    break;
                }
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void miSettings_Click(object sender, System.EventArgs e)
        {
            UserForm us = new UserForm(CurrentUser);
            us.ShowDialog();

            Init();
        }

        private void miCreateGroup_Click(object sender, System.EventArgs e)
        {
            GroupForm gf = new GroupForm(CurrentUser, FormState.New);
            gf.ShowDialog();
        }

        private void miOpenGroup_Click(object sender, System.EventArgs e)
        {
            GroupForm gf;

            switch (CurrentUser.GroupPermission.Name)
            {
                case "Owner":
                case "ReaderWriter":
                    gf = new GroupForm(CurrentUser, FormState.Edit);
                    gf.ShowDialog();
                    break;
                case "Reader":
                    gf = new GroupForm(CurrentUser, FormState.Preview);
                    gf.ShowDialog();
                    break;
                default:
                    break;
            }
        }

        private void miAddAction_Click(object sender, System.EventArgs e)
        {
            ActionForm af = new ActionForm(CurrentUser);
            af.FormClosing += actionFormClosing;
            af.ShowDialog();
        }

        private void actionFormClosing(object sender, FormClosingEventArgs e)
        {
            Init();
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {

        }

        private void btnReloadData_Click(object sender, EventArgs e)
        {
            Init();
        }

        private void miInviteInGroup_Click(object sender, EventArgs e)
        {
            InviteUserToGroupForm iu = new InviteUserToGroupForm(CurrentUser);
            iu.ShowDialog();
        }

        private void mainDataGrid_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 1:
                    try
                    {
                        var summ = (decimal)e.Value;

                        if (summ <= 200)
                            e.CellStyle.BackColor = Color.Green;
                        else
                        {
                            if (summ > 200 && summ < 500)
                                e.CellStyle.BackColor = Color.LightGreen;
                            else
                                e.CellStyle.BackColor = Color.Red;
                        }
                    }
                    catch
                    {
                        if (e.RowIndex != -1)
                        e.CellStyle.BackColor = Color.Green;
                    }
                    break;
                case 4:
                case 5:
                    try
                    {
                        var summ = (decimal)e.Value;

                        if (summ <= 100)
                            e.CellStyle.BackColor = Color.Green;
                        else
                        {
                            if (summ > 100 && summ < 250)
                                e.CellStyle.BackColor = Color.LightGreen;
                            else
                                e.CellStyle.BackColor = Color.Red;
                        }
                    }
                    catch
                    {
                        if (e.RowIndex != -1)
                            e.CellStyle.BackColor = Color.Green;
                    }
                    break;
                default:
                    break;
            }
        }

        private void miHistory_Click(object sender, EventArgs e)
        {
            HistoryForm hf = new HistoryForm(CurrentUser);
            hf.Show();
        }
    }
}