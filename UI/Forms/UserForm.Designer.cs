namespace UI.Forms
{
    partial class UserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbUserAvatar = new System.Windows.Forms.PictureBox();
            this.btnChangeAvatar = new System.Windows.Forms.Button();
            this.txtFIO = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtGroup = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.txtGroupPermission = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnShowPassword = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // pbUserAvatar
            // 
            this.pbUserAvatar.Image = global::UI.Properties.Resources.user;
            this.pbUserAvatar.InitialImage = null;
            this.pbUserAvatar.Location = new System.Drawing.Point(12, 12);
            this.pbUserAvatar.Name = "pbUserAvatar";
            this.pbUserAvatar.Size = new System.Drawing.Size(128, 128);
            this.pbUserAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUserAvatar.TabIndex = 0;
            this.pbUserAvatar.TabStop = false;
            // 
            // btnChangeAvatar
            // 
            this.btnChangeAvatar.Location = new System.Drawing.Point(12, 146);
            this.btnChangeAvatar.Name = "btnChangeAvatar";
            this.btnChangeAvatar.Size = new System.Drawing.Size(128, 53);
            this.btnChangeAvatar.TabIndex = 1;
            this.btnChangeAvatar.Text = "Загрузить аватар";
            this.btnChangeAvatar.UseVisualStyleBackColor = true;
            this.btnChangeAvatar.Click += new System.EventHandler(this.btnChangeAvatar_Click);
            // 
            // txtFIO
            // 
            this.txtFIO.Location = new System.Drawing.Point(146, 12);
            this.txtFIO.Name = "txtFIO";
            this.txtFIO.Size = new System.Drawing.Size(262, 22);
            this.txtFIO.TabIndex = 2;
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(146, 40);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(262, 22);
            this.txtLogin.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(146, 68);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(216, 22);
            this.txtPassword.TabIndex = 4;
            // 
            // txtGroup
            // 
            this.txtGroup.Location = new System.Drawing.Point(207, 96);
            this.txtGroup.Name = "txtGroup";
            this.txtGroup.ReadOnly = true;
            this.txtGroup.Size = new System.Drawing.Size(201, 22);
            this.txtGroup.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Группа";
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(280, 152);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(128, 53);
            this.btnSaveChanges.TabIndex = 7;
            this.btnSaveChanges.Text = "Сохранить изменения";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // txtGroupPermission
            // 
            this.txtGroupPermission.Location = new System.Drawing.Point(207, 124);
            this.txtGroupPermission.Name = "txtGroupPermission";
            this.txtGroupPermission.ReadOnly = true;
            this.txtGroupPermission.Size = new System.Drawing.Size(201, 22);
            this.txtGroupPermission.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Роль";
            // 
            // btnShowPassword
            // 
            this.btnShowPassword.Image = global::UI.Properties.Resources.eye;
            this.btnShowPassword.Location = new System.Drawing.Point(368, 64);
            this.btnShowPassword.Name = "btnShowPassword";
            this.btnShowPassword.Size = new System.Drawing.Size(40, 32);
            this.btnShowPassword.TabIndex = 10;
            this.btnShowPassword.UseVisualStyleBackColor = true;
            this.btnShowPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnShowPassword_MouseDown);
            this.btnShowPassword.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnShowPassword_MouseUp);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 214);
            this.Controls.Add(this.btnShowPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtGroupPermission);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGroup);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.txtFIO);
            this.Controls.Add(this.btnChangeAvatar);
            this.Controls.Add(this.pbUserAvatar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserForm";
            this.Text = "UserForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbUserAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbUserAvatar;
        private System.Windows.Forms.Button btnChangeAvatar;
        private System.Windows.Forms.TextBox txtFIO;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.TextBox txtGroupPermission;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnShowPassword;
    }
}