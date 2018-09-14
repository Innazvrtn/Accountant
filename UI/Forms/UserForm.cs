using Core.DB;
using Core.Entities;
using Core.Repository;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace UI.Forms
{
    public partial class UserForm : Form
    {
        Core.Entities.User CurrentUser;

        public UserForm(Core.Entities.User user)
        {
            InitializeComponent();

            CurrentUser = user;

            Init();
        }

        private void Init()
        {
            Text = CurrentUser.FIO;

            if (CurrentUser.UserAvatar != null)
                using (var imageStream = new MemoryStream(CurrentUser.UserAvatar))
                {
                    Icon = Icon.FromHandle((new Bitmap(imageStream)).GetHicon());
                    pbUserAvatar.Image = Image.FromStream(imageStream);
                }

            txtFIO.Text = CurrentUser.FIO;
            txtLogin.Text = CurrentUser.Login;
            txtPassword.Text = CurrentUser.Password;
            txtGroup.Text = CurrentUser.Group == null ? UserStrings.NoGroup : CurrentUser.Group.Name;
            txtGroupPermission.Text = CurrentUser.GroupPermission == null ? UserStrings.NoGroup : CurrentUser.GroupPermission.Name;
                
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            CurrentUser.FIO = txtFIO.Text;
            CurrentUser.Login = txtLogin.Text;
            CurrentUser.Password = txtPassword.Text;

            using (var imageStream = new MemoryStream())
            {
                pbUserAvatar.Image.Save(imageStream, pbUserAvatar.Image.RawFormat);
                CurrentUser.UserAvatar = imageStream.ToArray();
            }

            using (IRepository<Core.Entities.User> userRep = new UserRepository())
            {
                userRep.Update(CurrentUser);
            }

            Init();
        }

        private void btnShowPassword_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.PasswordChar = '\0';
        }

        private void btnShowPassword_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }

        private void btnChangeAvatar_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();

            fileDialog.InitialDirectory = "c:\\";
            fileDialog.Filter = "png files (*.png)|*.png";
            fileDialog.FilterIndex = 2;
            fileDialog.RestoreDirectory = true;


            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileStream fileStream;
                    if ((fileStream = new FileStream(fileDialog.FileName, FileMode.Open, FileAccess.Read)) != null)
                    {
                        using (fileStream)
                        {
                            byte[] file;

                            var reader = new BinaryReader(fileStream);

                            file = reader.ReadBytes((int)fileStream.Length);

                            using (var imageStream = new MemoryStream(file))
                            {
                                var avatar = Image.FromStream(imageStream);

                                if (avatar.Size.Height != avatar.Size.Width)
                                {
                                    MessageBox.Show(UserStrings.IncorrectImage, MessageBoxStrings.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    pbUserAvatar.Image = avatar;
                                }
                            }
                        }

                    }
                }
                catch
                { }
            }
        }
    }
}
