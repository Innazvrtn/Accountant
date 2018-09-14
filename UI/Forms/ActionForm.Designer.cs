namespace UI.Forms
{
    partial class ActionForm
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
            this.cmbActionType = new System.Windows.Forms.ComboBox();
            this.actionTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.cmbActionCategory = new System.Windows.Forms.ComboBox();
            this.actionCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.rtbComment = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSumm = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpActionDate = new System.Windows.Forms.DateTimePicker();
            this.ckbCurrentDate = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.actionTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionCategoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Тип";
            // 
            // cmbActionType
            // 
            this.cmbActionType.DataSource = this.actionTypeBindingSource;
            this.cmbActionType.DisplayMember = "Name";
            this.cmbActionType.FormattingEnabled = true;
            this.cmbActionType.Location = new System.Drawing.Point(38, 5);
            this.cmbActionType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbActionType.Name = "cmbActionType";
            this.cmbActionType.Size = new System.Drawing.Size(230, 21);
            this.cmbActionType.TabIndex = 1;
            this.cmbActionType.ValueMember = "ActionTypeId";
            // 
            // actionTypeBindingSource
            // 
            this.actionTypeBindingSource.DataSource = typeof(Core.Entities.ActionType);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Категория";
            // 
            // cmbActionCategory
            // 
            this.cmbActionCategory.DataSource = this.actionCategoryBindingSource;
            this.cmbActionCategory.DisplayMember = "Name";
            this.cmbActionCategory.FormattingEnabled = true;
            this.cmbActionCategory.Location = new System.Drawing.Point(71, 29);
            this.cmbActionCategory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbActionCategory.Name = "cmbActionCategory";
            this.cmbActionCategory.Size = new System.Drawing.Size(197, 21);
            this.cmbActionCategory.TabIndex = 3;
            this.cmbActionCategory.ValueMember = "ActionCategoryId";
            // 
            // actionCategoryBindingSource
            // 
            this.actionCategoryBindingSource.DataSource = typeof(Core.Entities.ActionCategory);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Комментарий";
            // 
            // rtbComment
            // 
            this.rtbComment.Location = new System.Drawing.Point(8, 117);
            this.rtbComment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rtbComment.Name = "rtbComment";
            this.rtbComment.Size = new System.Drawing.Size(260, 105);
            this.rtbComment.TabIndex = 5;
            this.rtbComment.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 229);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Сумма";
            // 
            // txtSumm
            // 
            this.txtSumm.Location = new System.Drawing.Point(53, 226);
            this.txtSumm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSumm.Name = "txtSumm";
            this.txtSumm.Size = new System.Drawing.Size(214, 20);
            this.txtSumm.TabIndex = 7;
            this.txtSumm.Text = "0";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(8, 250);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(259, 24);
            this.btnCreate.TabIndex = 8;
            this.btnCreate.Text = "Создать";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Дата";
            // 
            // dtpActionDate
            // 
            this.dtpActionDate.Location = new System.Drawing.Point(48, 79);
            this.dtpActionDate.Name = "dtpActionDate";
            this.dtpActionDate.Size = new System.Drawing.Size(220, 20);
            this.dtpActionDate.TabIndex = 10;
            // 
            // ckbCurrentDate
            // 
            this.ckbCurrentDate.AutoSize = true;
            this.ckbCurrentDate.Location = new System.Drawing.Point(12, 55);
            this.ckbCurrentDate.Name = "ckbCurrentDate";
            this.ckbCurrentDate.Size = new System.Drawing.Size(97, 17);
            this.ckbCurrentDate.TabIndex = 11;
            this.ckbCurrentDate.Text = "Текущая дата";
            this.ckbCurrentDate.UseVisualStyleBackColor = true;
            this.ckbCurrentDate.CheckedChanged += new System.EventHandler(this.ckbCurrentDate_CheckedChanged);
            // 
            // ActionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 287);
            this.Controls.Add(this.ckbCurrentDate);
            this.Controls.Add(this.dtpActionDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtSumm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rtbComment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbActionCategory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbActionType);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ActionForm";
            this.Text = "Действие";
            this.Load += new System.EventHandler(this.ActionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.actionTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionCategoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbActionType;
        private System.Windows.Forms.BindingSource actionTypeBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbActionCategory;
        private System.Windows.Forms.BindingSource actionCategoryBindingSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtbComment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSumm;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpActionDate;
        private System.Windows.Forms.CheckBox ckbCurrentDate;
    }
}