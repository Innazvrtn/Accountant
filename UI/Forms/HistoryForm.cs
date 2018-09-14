using Core.Entities;
using Core.Entities.Controls;
using Core.Repository;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Forms
{
    public partial class HistoryForm : Form
    {
        User CurrentUser;

        private object mainPanelLocker = new object();

        public HistoryForm(User user)
        {
            InitializeComponent();

            CurrentUser = user;
        }

        private void HistoryForm_Load(object sender, EventArgs e)
        {
            if (CurrentUser.UserAvatar != null)
                using (var imageStream = new MemoryStream(CurrentUser.UserAvatar))
                {
                    Icon = Icon.FromHandle((new Bitmap(imageStream)).GetHicon());
                }

            Text = "История действий : " + CurrentUser.FIO;

            using (IRepository<Core.Entities.Action> actionRep = new ActionRepository())
            {
                var userActions = actionRep.GetList().Where(a => a.UserAction.UserId == CurrentUser.UserId).ToList();

                foreach (var action in userActions)
                {
                    //var actionIndex = userActions.IndexOf(action);

                    //new Thread(() =>
                    //{
                    //    ActionControl ac = new ActionControl(action);

                    //    ac.Size = new System.Drawing.Size(290, 290);
                    //    ac.Location = new System.Drawing.Point(4, actionIndex * ac.Size.Height + (actionIndex + 1) * 4);
                    //    ac.Name = "actionControl" + actionIndex;

                    //    Invoke(new System.Action(() =>
                    //    {
                    //        lock (mainPanelLocker)
                    //            mainPanel.Controls.Add(ac);
                    //    }));

                    //}).Start();

                    ActionControl ac = new ActionControl(action);

                    var actionIndex = userActions.IndexOf(action);

                    ac.Size = new System.Drawing.Size(290, 290);
                    ac.Location = new System.Drawing.Point(4, actionIndex * ac.Size.Height + (actionIndex + 1) * 4);
                    ac.Name = "actionControl" + actionIndex;

                    mainPanel.Controls.Add(ac);
                }
            }
        }

        //private async Task<ActionControl> InitActionControl(Action action, int actionIndex)
        //{
        //    var result = new Task<ActionControl>(() =>
        //        {
        //            ActionControl ac = new ActionControl(action);

        //            ac.Size = new System.Drawing.Size(290, 290);
        //            ac.Location = new System.Drawing.Point(4, actionIndex * ac.Size.Height + (actionIndex + 1) * 4);
        //            ac.Name = "actionControl" + actionIndex;

        //            return ac;
        //        });

        //    result.Start();

        //    return result.Result;
        //}
    }
}
