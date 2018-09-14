using Core.Repository;
using System;
using System.Linq;
using System.Windows.Forms;
using Core.Entities;

namespace UI.Forms
{
    public partial class ActionForm : Form
    {
        User CurrentUser;

        public ActionForm(User user)
        {
            InitializeComponent();

            CurrentUser = user;
        }

        private void ActionForm_Load(object sender, EventArgs e)
        {
            using (var actiontyperep = new ActionTypeRepository())
            {
                cmbActionType.DataSource = actiontyperep.GetList().ToList();
            }

            using (var actioncategoryrep = new ActionCategoryRepository())
            {
                cmbActionCategory.DataSource = actioncategoryrep.GetList().ToList();
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var newAction = new Core.Entities.Action()
            {
                ActionId = Guid.NewGuid(), ActionType = new ActionType() { ActionTypeId = (Guid)cmbActionType.SelectedValue}, ActionDate = (ckbCurrentDate.Checked ? DateTime.Now : dtpActionDate.Value), ActionCategory = new ActionCategory() { ActionCategoryId = (Guid)cmbActionCategory.SelectedValue}, ActionComment = rtbComment.Text, ActionSumm = Convert.ToDecimal(txtSumm.Text), UserAction = CurrentUser
            };

            using (var actionRep = new ActionRepository())
            {
                actionRep.Create(newAction);

                MessageBox.Show(ActionStrings.ActionCreted, MessageBoxStrings.Success, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ckbCurrentDate_CheckedChanged(object sender, EventArgs e)
        {
            dtpActionDate.Enabled = !ckbCurrentDate.Checked;
        }
    }
}
