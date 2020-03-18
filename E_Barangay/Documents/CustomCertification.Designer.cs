namespace E_Barangay.Documents
{
    partial class CustomCertification
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
            this.wordNum = new System.Windows.Forms.Label();
            this.body = new System.Windows.Forms.TextBox();
            this.officerInfo = new System.Windows.Forms.ComboBox();
            this.specimen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.FieldsPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FieldsPanel
            // 
            this.FieldsPanel.Controls.Add(this.panel1);
            this.FieldsPanel.Controls.Add(this.label2);
            this.FieldsPanel.Controls.Add(this.label1);
            this.FieldsPanel.Controls.Add(this.specimen);
            this.FieldsPanel.Controls.Add(this.officerInfo);
            this.FieldsPanel.Size = new System.Drawing.Size(498, 690);
            // 
            // wordNum
            // 
            this.wordNum.AutoSize = true;
            this.wordNum.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordNum.Location = new System.Drawing.Point(96, 5);
            this.wordNum.Name = "wordNum";
            this.wordNum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.wordNum.Size = new System.Drawing.Size(13, 14);
            this.wordNum.TabIndex = 5;
            this.wordNum.Text = "0";
            // 
            // body
            // 
            this.body.AcceptsReturn = true;
            this.body.AcceptsTab = true;
            this.body.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.body.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.body.Location = new System.Drawing.Point(0, 21);
            this.body.MaxLength = 1950;
            this.body.Multiline = true;
            this.body.Name = "body";
            this.body.Size = new System.Drawing.Size(473, 566);
            this.body.TabIndex = 1;
            this.body.Text = "To whom it may concern:\r\n\r\n[body here]";
            this.body.TextChanged += new System.EventHandler(this.body_TextChanged);
            // 
            // officerInfo
            // 
            this.officerInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.officerInfo.FormattingEnabled = true;
            this.officerInfo.Location = new System.Drawing.Point(108, 631);
            this.officerInfo.Name = "officerInfo";
            this.officerInfo.Size = new System.Drawing.Size(377, 21);
            this.officerInfo.TabIndex = 3;
            // 
            // specimen
            // 
            this.specimen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.specimen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.specimen.Location = new System.Drawing.Point(108, 605);
            this.specimen.Name = "specimen";
            this.specimen.Size = new System.Drawing.Size(377, 20);
            this.specimen.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 608);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Specimen Name:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 634);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Officer of the Day:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.wordNum);
            this.panel1.Controls.Add(this.body);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(473, 587);
            this.panel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 14);
            this.label3.TabIndex = 6;
            this.label3.Text = "Character Count:";
            // 
            // CustomCertification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1060, 690);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomCertification";
            this.Text = "CustomCertification";
            this.FieldsPanel.ResumeLayout(false);
            this.FieldsPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label wordNum;
        private System.Windows.Forms.TextBox body;
        private System.Windows.Forms.TextBox specimen;
        private System.Windows.Forms.ComboBox officerInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
    }
}