namespace Core.Entities.Controls
{
    partial class ActionControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblUserFio = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbActionType = new System.Windows.Forms.ComboBox();
            this.actionTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.cmbActionCategory = new System.Windows.Forms.ComboBox();
            this.actionCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.dtpActionDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.rtbComment = new System.Windows.Forms.RichTextBox();
            this.txtSumm = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.actionTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionCategoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUserFio
            // 
            this.lblUserFio.AutoSize = true;
            this.lblUserFio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUserFio.Location = new System.Drawing.Point(4, 4);
            this.lblUserFio.Name = "lblUserFio";
            this.lblUserFio.Size = new System.Drawing.Size(52, 16);
            this.lblUserFio.TabIndex = 0;
            this.lblUserFio.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Тип";
            // 
            // cmbActionType
            // 
            this.cmbActionType.DataSource = this.actionTypeBindingSource;
            this.cmbActionType.DisplayMember = "Name";
            this.cmbActionType.FormattingEnabled = true;
            this.cmbActionType.Location = new System.Drawing.Point(36, 26);
            this.cmbActionType.Name = "cmbActionType";
            this.cmbActionType.Size = new System.Drawing.Size(251, 21);
            this.cmbActionType.TabIndex = 2;
            this.cmbActionType.ValueMember = "ActionTypeId";
            // 
            // actionTypeBindingSource
            // 
            this.actionTypeBindingSource.DataSource = typeof(Core.Entities.ActionType);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Категория";
            // 
            // cmbActionCategory
            // 
            this.cmbActionCategory.DataSource = this.actionCategoryBindingSource;
            this.cmbActionCategory.DisplayMember = "Name";
            this.cmbActionCategory.FormattingEnabled = true;
            this.cmbActionCategory.Location = new System.Drawing.Point(70, 53);
            this.cmbActionCategory.Name = "cmbActionCategory";
            this.cmbActionCategory.Size = new System.Drawing.Size(217, 21);
            this.cmbActionCategory.TabIndex = 4;
            this.cmbActionCategory.ValueMember = "ActionCategoryId";
            // 
            // actionCategoryBindingSource
            // 
            this.actionCategoryBindingSource.DataSource = typeof(Core.Entities.ActionCategory);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Дата";
            // 
            // dtpActionDate
            // 
            this.dtpActionDate.Location = new System.Drawing.Point(43, 80);
            this.dtpActionDate.Name = "dtpActionDate";
            this.dtpActionDate.Size = new System.Drawing.Size(244, 20);
            this.dtpActionDate.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Комментарий";
            // 
            // rtbComment
            // 
            this.rtbComment.Location = new System.Drawing.Point(7, 119);
            this.rtbComment.Name = "rtbComment";
            this.rtbComment.Size = new System.Drawing.Size(280, 104);
            this.rtbComment.TabIndex = 8;
            this.rtbComment.Text = "";
            // 
            // txtSumm
            // 
            this.txtSumm.Location = new System.Drawing.Point(51, 229);
            this.txtSumm.Name = "txtSumm";
            this.txtSumm.Size = new System.Drawing.Size(236, 20);
            this.txtSumm.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Сумма";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(7, 255);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(93, 32);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(194, 255);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(93, 32);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // ActionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSumm);
            this.Controls.Add(this.rtbComment);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpActionDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbActionCategory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbActionType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblUserFio);
            this.Name = "ActionControl";
            this.Size = new System.Drawing.Size(290, 290);
            ((System.ComponentModel.ISupportInitialize)(this.actionTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionCategoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserFio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbActionType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbActionCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpActionDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtbComment;
        private System.Windows.Forms.TextBox txtSumm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.BindingSource actionTypeBindingSource;
        private System.Windows.Forms.BindingSource actionCategoryBindingSource;
    }
}
