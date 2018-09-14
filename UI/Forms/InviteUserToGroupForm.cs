using Core.Entities;
using Core.Repository;
using System;
using System.Windows.Forms;
using System.Linq;

namespace UI.Forms
{
    public partial class InviteUserToGroupForm : Form
    {
        User CurrentUser;

        public InviteUserToGroupForm(User user)
        {
            InitializeComponent();

            CurrentUser = user;

            Init();
        }

        private void Init()
        {
            using (IRepository<User> userRep = new UserRepository())
            {
                cmbUsers.DataSource = userRep.GetList().Where(u => u.Group == null).ToList();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(IRepository<User> userRep = new UserRepository())
            {
                var updatedUser = userRep.Get((Guid)cmbUsers.SelectedValue);
                updatedUser.Group = CurrentUser.Group;
                updatedUser.GroupPermission = CurrentUser.GroupPermission;

                userRep.Update(updatedUser);

                MessageBox.Show(GroupStrings.SuccessfullUserAdded, MessageBoxStrings.Success, MessageBoxButtons.OK, MessageBoxIcon.Information);

                Init();
            }
        }
    }
}
