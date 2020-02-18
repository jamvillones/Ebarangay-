namespace E_Barangay.Forms
{
    partial class BuildingPermit
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.specField = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.IssuedOn = new System.Windows.Forms.DateTimePicker();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.IdGroup = new System.Windows.Forms.GroupBox();
            this.AssignBtn = new System.Windows.Forms.Button();
            this.IDField = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tdNoField = new System.Windows.Forms.TextBox();
            this.SexOption = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fullNameField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.TextBox();
            this.printing = new E_Barangay.Forms.Printing();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.IdGroup.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.groupBox4);
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
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.specField);
            this.groupBox4.Location = new System.Drawing.Point(12, 228);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(328, 55);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Building";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 33;
            this.label4.Text = "Specification";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // specField
            // 
            this.specField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.specField.Location = new System.Drawing.Point(92, 19);
            this.specField.Name = "specField";
            this.specField.Size = new System.Drawing.Size(230, 20);
            this.specField.TabIndex = 33;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.IssuedOn);
            this.groupBox2.Location = new System.Drawing.Point(12, 289);
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
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.tdNoField);
            this.groupBox3.Controls.Add(this.SexOption);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.fullNameField);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.Address);
            this.groupBox3.Location = new System.Drawing.Point(12, 95);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(328, 127);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DETAILS";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(6, 96);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 20);
            this.label11.TabIndex = 31;
            this.label11.Text = "TD No.:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tdNoField
            // 
            this.tdNoField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tdNoField.Location = new System.Drawing.Point(92, 96);
            this.tdNoField.Name = "tdNoField";
            this.tdNoField.Size = new System.Drawing.Size(230, 20);
            this.tdNoField.TabIndex = 32;
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
            this.SexOption.Location = new System.Drawing.Point(92, 69);
            this.SexOption.Name = "SexOption";
            this.SexOption.Size = new System.Drawing.Size(230, 21);
            this.SexOption.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(8, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 20);
            this.label9.TabIndex = 30;
            this.label9.Text = "Sex";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 17);
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
            this.label3.Location = new System.Drawing.Point(6, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Address";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Address
            // 
            this.Address.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Address.Location = new System.Drawing.Point(92, 43);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(230, 20);
            this.Address.TabIndex = 6;
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
            // BuildingPermit
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
            this.Name = "BuildingPermit";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Building Permit";
            this.Load += new System.EventHandler(this.DeathCertificate_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DeathCertificate_KeyDown);
            this.panel1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
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
        private System.Windows.Forms.TextBox Address;
        private Printing printing;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox SexOption;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tdNoField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox specField;
    }
}