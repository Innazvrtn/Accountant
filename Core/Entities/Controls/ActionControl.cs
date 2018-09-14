using Core.Repository;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Core.Entities.Controls
{
    public partial class ActionControl : UserControl
    {
        Action CurrentAction;

        public ActionControl(Action action)
        {
            InitializeComponent();

            CurrentAction = action;

            using (var actionTypeRep = new ActionTypeRepository())
                cmbActionType.DataSource = actionTypeRep.GetList().ToList();
            using (var actionCategoryRep = new ActionCategoryRepository())
                cmbActionCategory.DataSource = actionCategoryRep.GetList().ToList();

            Init();
        }

        private void Init()
        {
            lblUserFio.Text = CurrentAction.UserAction.FIO;
            cmbActionType.SelectedValue = CurrentAction.ActionType.ActionTypeId;
            cmbActionCategory.SelectedValue = CurrentAction.ActionCategory.ActionCategoryId;
            dtpActionDate.Value = CurrentAction.ActionDate;
            rtbComment.Text = CurrentAction.ActionComment;
            txtSumm.Text = Math.Round(CurrentAction.ActionSumm).ToString();
        }
    }
}
