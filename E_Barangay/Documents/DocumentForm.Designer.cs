namespace E_Barangay.Documents
{
    partial class DocumentForm
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
            this.ResetBtn = new System.Windows.Forms.Button();
            this.IDGroup = new System.Windows.Forms.GroupBox();
            this.assignBtn = new System.Windows.Forms.Button();
            this.idField = new System.Windows.Forms.TextBox();
            this.FieldsPanel.SuspendLayout();
            this.IDGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // FieldsPanel
            // 
            this.FieldsPanel.Controls.Add(this.IDGroup);
            this.FieldsPanel.Controls.Add(this.ResetBtn);
            this.FieldsPanel.Size = new System.Drawing.Size(352, 690);
            // 
            // ResetBtn
            // 
            this.ResetBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ResetBtn.Location = new System.Drawing.Point(124, 652);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(100, 25);
            this.ResetBtn.TabIndex = 0;
            this.ResetBtn.TabStop = false;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // IDGroup
            // 
            this.IDGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IDGroup.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.IDGroup.Controls.Add(this.assignBtn);
            this.IDGroup.Controls.Add(this.idField);
            this.IDGroup.Location = new System.Drawing.Point(14, 12);
            this.IDGroup.Name = "IDGroup";
            this.IDGroup.Size = new System.Drawing.Size(321, 77);
            this.IDGroup.TabIndex = 2;
            this.IDGroup.TabStop = false;
            this.IDGroup.Text = "User ID";
            // 
            // assignBtn
            // 
            this.assignBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.assignBtn.Location = new System.Drawing.Point(123, 45);
            this.assignBtn.Name = "assignBtn";
            this.assignBtn.Size = new System.Drawing.Size(75, 23);
            this.assignBtn.TabIndex = 4;
            this.assignBtn.Text = "Assign";
            this.assignBtn.UseVisualStyleBackColor = true;
            // 
            // idField
            // 
            this.idField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.idField.Location = new System.Drawing.Point(6, 19);
            this.idField.MaxLength = 10;
            this.idField.Name = "idField";
            this.idField.Size = new System.Drawing.Size(309, 20);
            this.idField.TabIndex = 3;
            // 
            // DocumentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(914, 690);
            this.Name = "DocumentForm";
            this.FieldsPanel.ResumeLayout(false);
            this.IDGroup.ResumeLayout(false);
            this.IDGroup.PerformLayout();
            this.ResumeLayout(false);

        }
        public System.Windows.Forms.Button ResetBtn;
        protected System.Windows.Forms.GroupBox IDGroup;
        private System.Windows.Forms.Button assignBtn;
        private System.Windows.Forms.TextBox idField;

        //protected System.Windows.Forms.GroupBox IdGroup;
        //private System.Windows.Forms.Button AssignBtn;
        //private System.Windows.Forms.TextBox IDField;
        //protected System.Windows.Forms.Button ResetBtn;

        #endregion
        //private E_Barangay.Forms.Printing printing;
        //public System.Windows.Forms.Panel FieldsPanel;
    }
}