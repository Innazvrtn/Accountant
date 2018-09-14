using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Core.Configs;
using Core.DB;
using Core.Entities;
using Core.Repository;
using UI.Properties;

namespace UI.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            Init();
        }

        private void Init()
        {

        }

        private void LoadingForm_Load(object sender, EventArgs e)
        {
            try
            {
                var login = Configs.GetInstance()[UserStrings.Login];
                txtLogin.Text = login.Value;

                var rememberMe = bool.Parse(Configs.GetInstance()[UserStrings.RememberMe].Value);
                ckbRememberMe.Checked = rememberMe;

                if (rememberMe)
                {
                    var password = Configs.GetInstance()[UserStrings.Password];
                    txtPassword.Text = password.Value;
                }

                if (txtLogin.Text == "" || txtLogin.Text == null)
                    txtLogin.Focus();
                else
                    if (txtPassword.Text == "" || txtPassword.Text == null)
                        txtPassword.Focus();
                    else
                        btnLogin.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, MessageBoxStrings.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                var db = DBManager.GetInstance();

                var parameters = new List<Tuple<string, object>>()
                {
                    new Tuple<string, object>(UserStrings.Login, txtLogin.Text),
                    new Tuple<string, object>(UserStrings.Password, txtPassword.Text)
                };

                var authorizatonresult = db.ExecuteProcedure(UserStrings.UserAuthorization, parameters.ToArray());

                if ((bool)authorizatonresult.Tables[0].Rows[0][0])
                {
                    User user = new User();

                    using (IRepository<User> userrep = new UserRepository())
                    {
                        user = userrep.Get((System.Guid)authorizatonresult.Tables[1].Rows[0][0]);
                    }

                    Configs.GetInstance().Add(UserStrings.Login, txtLogin.Text);
                    Configs.GetInstance().Add(UserStrings.RememberMe, ckbRememberMe.Checked.ToString());

                    if (ckbRememberMe.Checked)
                        Configs.GetInstance().Add(UserStrings.Password, txtPassword.Text);

                    Configs.GetInstance().SaveChanges();

                    MainForm mf = new MainForm(user);
                    mf.Show();

                    Hide();
                }
                else
                {
                    MessageBox.Show(UserStrings.IncorrectLoginPass, MessageBoxStrings.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, MessageBoxStrings.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void llblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                RegisterForm registerForm = new RegisterForm();

                registerForm.FormClosing += registerFrom_FromClosing;

                registerForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, MessageBoxStrings.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void registerFrom_FromClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                var rf = (RegisterForm)sender;

                if (rf.DialogResult == DialogResult.OK)
                {
                    Dispose(true);
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, MessageBoxStrings.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
