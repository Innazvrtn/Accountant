using Core.DB;
using Core.Entities;
using Core.Repository;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace UI.Forms
{
    public partial class GroupForm : Form
    {
        FormState formState;
        Core.Entities.User CurrentUser;

        public GroupForm(Core.Entities.User user, FormState state)
        {
            InitializeComponent();

            formState = state;
            CurrentUser = user;

            Init();
        }

        private void Init()
        {
            switch (formState)
            {
                case FormState.New:
                    Text = "";
                    Size = new Size(408, 175);
                    gbCreateGroup.Location = new Point(12, 12);
                    gbCreateGroup.Visible = true;
                    gbGroupInfo.Visible = false;
                    break;
                case FormState.Preview:
                    break;
                case FormState.Edit:
                    Text = CurrentUser.Group.Name + " (" + CurrentUser.GroupPermission.Name + ")";
                    txtEditGroupname.Text = CurrentUser.Group.Name;
                    gbCreateGroup.Visible = false;
                    gbGroupInfo.Visible = true;
                    Size = new Size(550, 550);
                    gbGroupInfo.Location = new Point(12, 12);

                    using (GroupRepository groupRep = new GroupRepository())
                    {
                        dgvGroupMembers.DataSource = groupRep.GetUsers(CurrentUser.Group.GroupId).ToList();
                    }

                    foreach (var user in dgvGroupMembers.DataSource as List<User>)
                    {
                        for (int i =0; i< dgvGroupMembers.Rows.Count; i++)
                        {
                            if ((Guid)dgvGroupMembers.Rows[i].Cells["UserId"].Value == user.UserId)
                            {
                                dgvGroupMembers.Rows[i].Cells["roleSelectorColumn"].Value = user.GroupPermission.Name;
                                break;
                            }
                        }
                    }
                    break;
                default:
                    break;
            }
        }

        private void GroupName_TextChanged(object sender, EventArgs e)
        {
            switch (formState)
            {
                case FormState.New:
                    Text = txtGroupName.Text;
                    break;
                case FormState.Preview:
                    break;
                case FormState.Edit:
                    Text = txtEditGroupname.Text + " (" + CurrentUser.GroupPermission.Name + ")";
                    break;
                default:
                    break;
            }
        }

        private void btnCreateGroup_Click(object sender, EventArgs e)
        {
            var db = DBManager.GetInstance();
            //using (var db = DBManager.GetInstance())
            //{
                var parameters = new List<Tuple<string, object>>()
                {
                    new Tuple<string, object>(GroupStrings.Name, txtGroupName.Text),
                    new Tuple<string, object>(UserStrings.UserId, CurrentUser.UserId)
                };

                var result = db.ExecuteProcedure(GroupStrings.CreateGroup, parameters.ToArray());

                if (result.Tables[0].Rows[0][0].ToString() == ProcedureResultStrings.Error101)
                {
                    MessageBox.Show(GroupStrings.IncorrectName, MessageBoxStrings.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (result.Tables[0].Rows[0][0].ToString() == ProcedureResultStrings.Success200)
                    {
                        using (IRepository<Group> groupRep = new GroupRepository())
                        {
                            CurrentUser.Group = groupRep.Get((System.Guid)result.Tables[1].Rows[0][0]);
                        }

                        using (IRepository<GroupPermission> groupPermissionRep = new GroupPermissionRepository())
                        {
                            CurrentUser.GroupPermission = groupPermissionRep.Get((System.Guid)result.Tables[1].Rows[0][1]);
                        }

                        MessageBox.Show(GroupStrings.SuccessfullCreation, MessageBoxStrings.Success, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            //}

            formState = FormState.Edit;
            Init();
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            using (GroupRepository groupRep = new GroupRepository())
            {
                CurrentUser.Group.Name = txtEditGroupname.Text;

                groupRep.Update(CurrentUser.Group);
            }
        }
    }
}
