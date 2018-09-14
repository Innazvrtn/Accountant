using Core.Configs;
using Core.DB;
using Core.Entities;
using Core.Repository;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UI.Forms
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void bntRegisterUser_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show(UserStrings.PasswordsNotMatch, MessageBoxStrings.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var db = DBManager.GetInstance();
                //using (var db = DBManager.GetInstance())
                //{
                    var parameters = new List<Tuple<string, object>>()
                    {
                        new Tuple<string, object>(UserStrings.FIO, txtFIO.Text),
                        new Tuple<string, object>(UserStrings.Login, txtLogin.Text),
                        new Tuple<string, object>(UserStrings.Password, txtPassword.Text)
                    };

                    var registrationResult = db.ExecuteProcedure(UserStrings.RegisterUser, parameters.ToArray());

                    if (registrationResult.Tables[0].Rows[0][0].ToString() == ProcedureResultStrings.Error101)
                    {
                        MessageBox.Show(UserStrings.ExistingUser, MessageBoxStrings.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show(UserStrings.SuccessfulRegistration, MessageBoxStrings.Success, MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Core.Entities.User user = new Core.Entities.User();

                        using (IRepository<Core.Entities.User> userrep = new UserRepository())
                        {
                            user = userrep.Get((System.Guid)registrationResult.Tables[1].Rows[0][0]);
                        }

                        Configs.GetInstance().Add(UserStrings.Login, txtLogin.Text);
                        Configs.GetInstance().Add(UserStrings.RememberMe, ckbRememberMe.Checked.ToString());

                        if (ckbRememberMe.Checked)
                            Configs.GetInstance().Add(UserStrings.Password, txtPassword.Text);

                        Configs.GetInstance().SaveChanges();

                        MainForm mf = new MainForm(user);
                        mf.Show();

                        DialogResult = DialogResult.OK;

                        Hide();
                    }
                //}
            }
        }
    }
}
