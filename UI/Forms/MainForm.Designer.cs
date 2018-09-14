namespace UI.Forms
{
    partial class MainForm
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
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.miUser = new System.Windows.Forms.ToolStripMenuItem();
            this.miSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.miLogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.miGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.miCreateGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.miOpenGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.miInviteInGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.miRequestGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.miGroupSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.miLeaveGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.miDeleteGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.miAction = new System.Windows.Forms.ToolStripMenuItem();
            this.miAddAction = new System.Windows.Forms.ToolStripMenuItem();
            this.miHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.mainDataGrid = new System.Windows.Forms.DataGridView();
            this.dtpTimeFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTimeTo = new System.Windows.Forms.DateTimePicker();
            this.btnReloadData = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainMenu.AutoSize = false;
            this.mainMenu.Dock = System.Windows.Forms.DockStyle.None;
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miUser,
            this.miGroup,
            this.miAction,
            this.miHistory});
            this.mainMenu.Location = new System.Drawing.Point(1, 2);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.mainMenu.Size = new System.Drawing.Size(1004, 32);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            // 
            // miUser
            // 
            this.miUser.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.miUser.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miSettings,
            this.toolStripSeparator1,
            this.miLogOut});
            this.miUser.Name = "miUser";
            this.miUser.Size = new System.Drawing.Size(48, 28);
            this.miUser.Text = "user";
            // 
            // miSettings
            // 
            this.miSettings.Image = global::UI.Properties.Resources.settings;
            this.miSettings.Name = "miSettings";
            this.miSettings.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.S)));
            this.miSettings.Size = new System.Drawing.Size(238, 26);
            this.miSettings.Text = "Настройки";
            this.miSettings.Click += new System.EventHandler(this.miSettings_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(235, 6);
            // 
            // miLogOut
            // 
            this.miLogOut.Image = global::UI.Properties.Resources.exit;
            this.miLogOut.Name = "miLogOut";
            this.miLogOut.Size = new System.Drawing.Size(238, 26);
            this.miLogOut.Text = "Выйти";
            // 
            // miGroup
            // 
            this.miGroup.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.miGroup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miCreateGroup,
            this.miOpenGroup,
            this.miInviteInGroup,
            this.miRequestGroup,
            this.miGroupSeparator,
            this.miLeaveGroup,
            this.miDeleteGroup});
            this.miGroup.Name = "miGroup";
            this.miGroup.Size = new System.Drawing.Size(70, 28);
            this.miGroup.Text = "Группа";
            // 
            // miCreateGroup
            // 
            this.miCreateGroup.Name = "miCreateGroup";
            this.miCreateGroup.Size = new System.Drawing.Size(165, 26);
            this.miCreateGroup.Text = "Создать";
            this.miCreateGroup.Click += new System.EventHandler(this.miCreateGroup_Click);
            // 
            // miOpenGroup
            // 
            this.miOpenGroup.Name = "miOpenGroup";
            this.miOpenGroup.Size = new System.Drawing.Size(165, 26);
            this.miOpenGroup.Text = "Открыть";
            this.miOpenGroup.Click += new System.EventHandler(this.miOpenGroup_Click);
            // 
            // miInviteInGroup
            // 
            this.miInviteInGroup.Name = "miInviteInGroup";
            this.miInviteInGroup.Size = new System.Drawing.Size(165, 26);
            this.miInviteInGroup.Text = "Пригласить";
            this.miInviteInGroup.Click += new System.EventHandler(this.miInviteInGroup_Click);
            // 
            // miRequestGroup
            // 
            this.miRequestGroup.Name = "miRequestGroup";
            this.miRequestGroup.Size = new System.Drawing.Size(165, 26);
            this.miRequestGroup.Text = "Запросить";
            // 
            // miGroupSeparator
            // 
            this.miGroupSeparator.Name = "miGroupSeparator";
            this.miGroupSeparator.Size = new System.Drawing.Size(162, 6);
            // 
            // miLeaveGroup
            // 
            this.miLeaveGroup.Name = "miLeaveGroup";
            this.miLeaveGroup.Size = new System.Drawing.Size(165, 26);
            this.miLeaveGroup.Text = "Покинуть";
            // 
            // miDeleteGroup
            // 
            this.miDeleteGroup.Name = "miDeleteGroup";
            this.miDeleteGroup.Size = new System.Drawing.Size(165, 26);
            this.miDeleteGroup.Text = "Удалить";
            // 
            // miAction
            // 
            this.miAction.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAddAction});
            this.miAction.Name = "miAction";
            this.miAction.Size = new System.Drawing.Size(86, 28);
            this.miAction.Text = "Действие";
            // 
            // miAddAction
            // 
            this.miAddAction.Name = "miAddAction";
            this.miAddAction.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.miAddAction.Size = new System.Drawing.Size(204, 26);
            this.miAddAction.Text = "Добавить";
            this.miAddAction.Click += new System.EventHandler(this.miAddAction_Click);
            // 
            // miHistory
            // 
            this.miHistory.Name = "miHistory";
            this.miHistory.Size = new System.Drawing.Size(80, 28);
            this.miHistory.Text = "История";
            this.miHistory.Click += new System.EventHandler(this.miHistory_Click);
            // 
            // mainDataGrid
            // 
            this.mainDataGrid.AllowUserToAddRows = false;
            this.mainDataGrid.AllowUserToDeleteRows = false;
            this.mainDataGrid.AllowUserToResizeColumns = false;
            this.mainDataGrid.AllowUserToResizeRows = false;
            this.mainDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainDataGrid.ColumnHeadersHeight = 30;
            this.mainDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.mainDataGrid.Location = new System.Drawing.Point(12, 37);
            this.mainDataGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainDataGrid.Name = "mainDataGrid";
            this.mainDataGrid.RowHeadersWidth = 100;
            this.mainDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mainDataGrid.RowTemplate.Height = 24;
            this.mainDataGrid.Size = new System.Drawing.Size(981, 514);
            this.mainDataGrid.TabIndex = 1;
            this.mainDataGrid.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.mainDataGrid_CellPainting);
            // 
            // dtpTimeFrom
            // 
            this.dtpTimeFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpTimeFrom.Location = new System.Drawing.Point(12, 558);
            this.dtpTimeFrom.Margin = new System.Windows.Forms.Padding(4);
            this.dtpTimeFrom.Name = "dtpTimeFrom";
            this.dtpTimeFrom.Size = new System.Drawing.Size(265, 22);
            this.dtpTimeFrom.TabIndex = 2;
            // 
            // dtpTimeTo
            // 
            this.dtpTimeTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpTimeTo.Location = new System.Drawing.Point(287, 558);
            this.dtpTimeTo.Margin = new System.Windows.Forms.Padding(4);
            this.dtpTimeTo.Name = "dtpTimeTo";
            this.dtpTimeTo.Size = new System.Drawing.Size(265, 22);
            this.dtpTimeTo.TabIndex = 3;
            // 
            // btnReloadData
            // 
            this.btnReloadData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReloadData.Location = new System.Drawing.Point(561, 556);
            this.btnReloadData.Margin = new System.Windows.Forms.Padding(4);
            this.btnReloadData.Name = "btnReloadData";
            this.btnReloadData.Size = new System.Drawing.Size(137, 28);
            this.btnReloadData.TabIndex = 4;
            this.btnReloadData.Text = "Перезагрузить";
            this.btnReloadData.UseVisualStyleBackColor = true;
            this.btnReloadData.Click += new System.EventHandler(this.btnReloadData_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 652);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Остаток";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 689);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Витрачено";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 652);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(99, 689);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "label5";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReloadData);
            this.Controls.Add(this.dtpTimeTo);
            this.Controls.Add(this.dtpTimeFrom);
            this.Controls.Add(this.mainDataGrid);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1023, 766);
            this.Name = "MainForm";
            this.Text = "Домашний бухгалтер";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.DataGridView mainDataGrid;
        private System.Windows.Forms.ToolStripMenuItem miUser;
        private System.Windows.Forms.ToolStripMenuItem miSettings;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem miLogOut;
        private System.Windows.Forms.ToolStripMenuItem miGroup;
        private System.Windows.Forms.ToolStripMenuItem miCreateGroup;
        private System.Windows.Forms.ToolStripMenuItem miInviteInGroup;
        private System.Windows.Forms.ToolStripMenuItem miRequestGroup;
        private System.Windows.Forms.ToolStripSeparator miGroupSeparator;
        private System.Windows.Forms.ToolStripMenuItem miLeaveGroup;
        private System.Windows.Forms.ToolStripMenuItem miDeleteGroup;
        private System.Windows.Forms.ToolStripMenuItem miOpenGroup;
        private System.Windows.Forms.ToolStripMenuItem miAction;
        private System.Windows.Forms.ToolStripMenuItem miAddAction;
        private System.Windows.Forms.DateTimePicker dtpTimeFrom;
        private System.Windows.Forms.DateTimePicker dtpTimeTo;
        private System.Windows.Forms.Button btnReloadData;
        private System.Windows.Forms.ToolStripMenuItem miHistory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}