namespace UI.Forms
{
    partial class GroupForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGroupName = new System.Windows.Forms.TextBox();
            this.btnCreateGroup = new System.Windows.Forms.Button();
            this.gbCreateGroup = new System.Windows.Forms.GroupBox();
            this.dgvGroupMembers = new System.Windows.Forms.DataGridView();
            this.UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registerDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastLoginDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupPermissionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleSelectorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userAvatarDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.gbGroupInfo = new System.Windows.Forms.GroupBox();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.txtEditGroupname = new System.Windows.Forms.TextBox();
            this.gbCreateGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroupMembers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.gbGroupInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название";
            // 
            // txtGroupName
            // 
            this.txtGroupName.Location = new System.Drawing.Point(63, 15);
            this.txtGroupName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.Size = new System.Drawing.Size(208, 20);
            this.txtGroupName.TabIndex = 1;
            this.txtGroupName.TextChanged += new System.EventHandler(this.GroupName_TextChanged);
            // 
            // btnCreateGroup
            // 
            this.btnCreateGroup.Location = new System.Drawing.Point(4, 44);
            this.btnCreateGroup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCreateGroup.Name = "btnCreateGroup";
            this.btnCreateGroup.Size = new System.Drawing.Size(266, 25);
            this.btnCreateGroup.TabIndex = 2;
            this.btnCreateGroup.Text = "Создать";
            this.btnCreateGroup.UseVisualStyleBackColor = true;
            this.btnCreateGroup.Click += new System.EventHandler(this.btnCreateGroup_Click);
            // 
            // gbCreateGroup
            // 
            this.gbCreateGroup.Controls.Add(this.btnCreateGroup);
            this.gbCreateGroup.Controls.Add(this.label1);
            this.gbCreateGroup.Controls.Add(this.txtGroupName);
            this.gbCreateGroup.Location = new System.Drawing.Point(388, 119);
            this.gbCreateGroup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbCreateGroup.Name = "gbCreateGroup";
            this.gbCreateGroup.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbCreateGroup.Size = new System.Drawing.Size(276, 84);
            this.gbCreateGroup.TabIndex = 3;
            this.gbCreateGroup.TabStop = false;
            // 
            // dgvGroupMembers
            // 
            this.dgvGroupMembers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGroupMembers.AutoGenerateColumns = false;
            this.dgvGroupMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGroupMembers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserId,
            this.fIODataGridViewTextBoxColumn,
            this.loginDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.registerDateDataGridViewTextBoxColumn,
            this.lastLoginDateDataGridViewTextBoxColumn,
            this.groupDataGridViewTextBoxColumn,
            this.groupPermissionDataGridViewTextBoxColumn,
            this.roleSelectorColumn,
            this.userAvatarDataGridViewImageColumn});
            this.dgvGroupMembers.DataSource = this.userBindingSource;
            this.dgvGroupMembers.Location = new System.Drawing.Point(7, 35);
            this.dgvGroupMembers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvGroupMembers.Name = "dgvGroupMembers";
            this.dgvGroupMembers.ReadOnly = true;
            this.dgvGroupMembers.RowTemplate.Height = 24;
            this.dgvGroupMembers.Size = new System.Drawing.Size(463, 318);
            this.dgvGroupMembers.TabIndex = 4;
            // 
            // UserId
            // 
            this.UserId.DataPropertyName = "UserId";
            this.UserId.HeaderText = "UserId";
            this.UserId.Name = "UserId";
            this.UserId.ReadOnly = true;
            this.UserId.Visible = false;
            // 
            // fIODataGridViewTextBoxColumn
            // 
            this.fIODataGridViewTextBoxColumn.DataPropertyName = "FIO";
            this.fIODataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.fIODataGridViewTextBoxColumn.Name = "fIODataGridViewTextBoxColumn";
            this.fIODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // loginDataGridViewTextBoxColumn
            // 
            this.loginDataGridViewTextBoxColumn.DataPropertyName = "Login";
            this.loginDataGridViewTextBoxColumn.HeaderText = "Логин";
            this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            this.loginDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            this.passwordDataGridViewTextBoxColumn.Visible = false;
            // 
            // registerDateDataGridViewTextBoxColumn
            // 
            this.registerDateDataGridViewTextBoxColumn.DataPropertyName = "RegisterDate";
            this.registerDateDataGridViewTextBoxColumn.HeaderText = "RegisterDate";
            this.registerDateDataGridViewTextBoxColumn.Name = "registerDateDataGridViewTextBoxColumn";
            this.registerDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.registerDateDataGridViewTextBoxColumn.Visible = false;
            // 
            // lastLoginDateDataGridViewTextBoxColumn
            // 
            this.lastLoginDateDataGridViewTextBoxColumn.DataPropertyName = "LastLoginDate";
            this.lastLoginDateDataGridViewTextBoxColumn.HeaderText = "Последний вход";
            this.lastLoginDateDataGridViewTextBoxColumn.Name = "lastLoginDateDataGridViewTextBoxColumn";
            this.lastLoginDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // groupDataGridViewTextBoxColumn
            // 
            this.groupDataGridViewTextBoxColumn.DataPropertyName = "Group";
            this.groupDataGridViewTextBoxColumn.HeaderText = "Group";
            this.groupDataGridViewTextBoxColumn.Name = "groupDataGridViewTextBoxColumn";
            this.groupDataGridViewTextBoxColumn.ReadOnly = true;
            this.groupDataGridViewTextBoxColumn.Visible = false;
            // 
            // groupPermissionDataGridViewTextBoxColumn
            // 
            this.groupPermissionDataGridViewTextBoxColumn.DataPropertyName = "GroupPermission";
            this.groupPermissionDataGridViewTextBoxColumn.HeaderText = "GroupPermission";
            this.groupPermissionDataGridViewTextBoxColumn.Name = "groupPermissionDataGridViewTextBoxColumn";
            this.groupPermissionDataGridViewTextBoxColumn.ReadOnly = true;
            this.groupPermissionDataGridViewTextBoxColumn.Visible = false;
            // 
            // roleSelectorColumn
            // 
            this.roleSelectorColumn.HeaderText = "Роль";
            this.roleSelectorColumn.Name = "roleSelectorColumn";
            this.roleSelectorColumn.ReadOnly = true;
            this.roleSelectorColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.roleSelectorColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // userAvatarDataGridViewImageColumn
            // 
            this.userAvatarDataGridViewImageColumn.DataPropertyName = "UserAvatar";
            this.userAvatarDataGridViewImageColumn.HeaderText = "UserAvatar";
            this.userAvatarDataGridViewImageColumn.Name = "userAvatarDataGridViewImageColumn";
            this.userAvatarDataGridViewImageColumn.ReadOnly = true;
            this.userAvatarDataGridViewImageColumn.Visible = false;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(Core.Entities.User);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Название";
            // 
            // gbGroupInfo
            // 
            this.gbGroupInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbGroupInfo.Controls.Add(this.btnSaveChanges);
            this.gbGroupInfo.Controls.Add(this.txtEditGroupname);
            this.gbGroupInfo.Controls.Add(this.dgvGroupMembers);
            this.gbGroupInfo.Controls.Add(this.label2);
            this.gbGroupInfo.Location = new System.Drawing.Point(9, 10);
            this.gbGroupInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbGroupInfo.Name = "gbGroupInfo";
            this.gbGroupInfo.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbGroupInfo.Size = new System.Drawing.Size(474, 389);
            this.gbGroupInfo.TabIndex = 6;
            this.gbGroupInfo.TabStop = false;
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveChanges.Location = new System.Drawing.Point(4, 358);
            this.btnSaveChanges.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(465, 26);
            this.btnSaveChanges.TabIndex = 7;
            this.btnSaveChanges.Text = "Сохранить изменения";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // txtEditGroupname
            // 
            this.txtEditGroupname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEditGroupname.Location = new System.Drawing.Point(63, 12);
            this.txtEditGroupname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEditGroupname.Name = "txtEditGroupname";
            this.txtEditGroupname.Size = new System.Drawing.Size(407, 20);
            this.txtEditGroupname.TabIndex = 6;
            this.txtEditGroupname.TextChanged += new System.EventHandler(this.GroupName_TextChanged);
            // 
            // GroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 409);
            this.Controls.Add(this.gbGroupInfo);
            this.Controls.Add(this.gbCreateGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GroupForm";
            this.Text = "GroupForm";
            this.gbCreateGroup.ResumeLayout(false);
            this.gbCreateGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroupMembers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.gbGroupInfo.ResumeLayout(false);
            this.gbGroupInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGroupName;
        private System.Windows.Forms.Button btnCreateGroup;
        private System.Windows.Forms.GroupBox gbCreateGroup;
        private System.Windows.Forms.DataGridView dgvGroupMembers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbGroupInfo;
        private System.Windows.Forms.TextBox txtEditGroupname;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registerDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastLoginDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupPermissionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleSelectorColumn;
        private System.Windows.Forms.DataGridViewImageColumn userAvatarDataGridViewImageColumn;
    }
}