﻿namespace E_Barangay.Forms
{
    partial class CertificateOfIndigency
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.IssuedOn = new System.Windows.Forms.DateTimePicker();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.IdGroup = new System.Windows.Forms.GroupBox();
            this.AssignBtn = new System.Windows.Forms.Button();
            this.IDField = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ageField = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.civilStatusOption = new System.Windows.Forms.ComboBox();
            this.SexOption = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fullNameField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addressField = new System.Windows.Forms.TextBox();
            this.printing = new E_Barangay.Forms.Printing();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.IdGroup.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.ResetBtn);
            this.panel1.Controls.Add(this.IdGroup);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 690);
            this.panel1.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.IssuedOn);
            this.groupBox2.Location = new System.Drawing.Point(12, 256);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(328, 47);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "MISC";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Issued On:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // IssuedOn
            // 
            this.IssuedOn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IssuedOn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.IssuedOn.Location = new System.Drawing.Point(92, 14);
            this.IssuedOn.Name = "IssuedOn";
            this.IssuedOn.Size = new System.Drawing.Size(230, 20);
            this.IssuedOn.TabIndex = 2;
            // 
            // ResetBtn
            // 
            this.ResetBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ResetBtn.Location = new System.Drawing.Point(126, 653);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(100, 25);
            this.ResetBtn.TabIndex = 6;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = true;
            // 
            // IdGroup
            // 
            this.IdGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IdGroup.Controls.Add(this.AssignBtn);
            this.IdGroup.Controls.Add(this.IDField);
            this.IdGroup.Location = new System.Drawing.Point(12, 12);
            this.IdGroup.Name = "IdGroup";
            this.IdGroup.Size = new System.Drawing.Size(328, 77);
            this.IdGroup.TabIndex = 1;
            this.IdGroup.TabStop = false;
            this.IdGroup.Text = "User ID";
            // 
            // AssignBtn
            // 
            this.AssignBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AssignBtn.Location = new System.Drawing.Point(127, 45);
            this.AssignBtn.Name = "AssignBtn";
            this.AssignBtn.Size = new System.Drawing.Size(75, 23);
            this.AssignBtn.TabIndex = 4;
            this.AssignBtn.Text = "Assign";
            this.AssignBtn.UseVisualStyleBackColor = true;
            this.AssignBtn.Click += new System.EventHandler(this.AssignBtn_Click);
            // 
            // IDField
            // 
            this.IDField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IDField.Location = new System.Drawing.Point(6, 19);
            this.IDField.MaxLength = 10;
            this.IDField.Name = "IDField";
            this.IDField.Size = new System.Drawing.Size(316, 20);
            this.IDField.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.ageField);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.civilStatusOption);
            this.groupBox3.Controls.Add(this.SexOption);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.fullNameField);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.addressField);
            this.groupBox3.Location = new System.Drawing.Point(12, 95);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(328, 155);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DETAILS";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(15, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 36;
            this.label6.Text = "Age\r\n:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ageField
            // 
            this.ageField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ageField.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ageField.Location = new System.Drawing.Point(92, 43);
            this.ageField.Name = "ageField";
            this.ageField.Size = new System.Drawing.Size(230, 20);
            this.ageField.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(15, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 34;
            this.label5.Text = "Civil Status:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // civilStatusOption
            // 
            this.civilStatusOption.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.civilStatusOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.civilStatusOption.FormattingEnabled = true;
            this.civilStatusOption.Items.AddRange(new object[] {
            "Single",
            "Married",
            "Widowed"});
            this.civilStatusOption.Location = new System.Drawing.Point(92, 122);
            this.civilStatusOption.Name = "civilStatusOption";
            this.civilStatusOption.Size = new System.Drawing.Size(230, 21);
            this.civilStatusOption.TabIndex = 33;
            // 
            // SexOption
            // 
            this.SexOption.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SexOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SexOption.FormattingEnabled = true;
            this.SexOption.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.SexOption.Location = new System.Drawing.Point(92, 95);
            this.SexOption.Name = "SexOption";
            this.SexOption.Size = new System.Drawing.Size(230, 21);
            this.SexOption.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(15, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 20);
            this.label9.TabIndex = 30;
            this.label9.Text = "Sex:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(15, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Full Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fullNameField
            // 
            this.fullNameField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fullNameField.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.fullNameField.Location = new System.Drawing.Point(92, 17);
            this.fullNameField.Name = "fullNameField";
            this.fullNameField.Size = new System.Drawing.Size(230, 20);
            this.fullNameField.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(15, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Address:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // addressField
            // 
            this.addressField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addressField.Location = new System.Drawing.Point(92, 69);
            this.addressField.Name = "addressField";
            this.addressField.Size = new System.Drawing.Size(230, 20);
            this.addressField.TabIndex = 6;
            // 
            // printing
            // 
            this.printing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.printing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.printing.Dock = System.Windows.Forms.DockStyle.Right;
            this.printing.Location = new System.Drawing.Point(352, 0);
            this.printing.Name = "printing";
            this.printing.Size = new System.Drawing.Size(562, 690);
            this.printing.TabIndex = 0;
            // 
            // CertificateOfIndigency
            // 
            this.AcceptButton = this.AssignBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 690);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.printing);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CertificateOfIndigency";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Certificate of Indigency";
            this.Load += new System.EventHandler(this.DeathCertificate_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DeathCertificate_KeyDown);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.IdGroup.ResumeLayout(false);
            this.IdGroup.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker IssuedOn;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.GroupBox IdGroup;
        private System.Windows.Forms.Button AssignBtn;
        private System.Windows.Forms.TextBox IDField;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fullNameField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addressField;
        private Printing printing;
        private System.Windows.Forms.ComboBox SexOption;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox civilStatusOption;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ageField;
    }
}