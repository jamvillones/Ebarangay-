namespace E_Barangay.Forms
{
    partial class CertIndigentMedicalAssistance
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
            this.label11 = new System.Windows.Forms.Label();
            this.Age = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.officerOption = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.SexOption = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Relation = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.By = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DeathPlace = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.IssuedOn = new System.Windows.Forms.DateTimePicker();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.IdGroup = new System.Windows.Forms.GroupBox();
            this.AssignBtn = new System.Windows.Forms.Button();
            this.IDField = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ext = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.middleName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.TextBox();
            this.printing = new E_Barangay.Forms.Printing();
            this.panel1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.IdGroup.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(6, 121);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 20);
            this.label11.TabIndex = 26;
            this.label11.Text = "Age:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Age
            // 
            this.Age.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Age.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Age.Location = new System.Drawing.Point(92, 121);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(230, 20);
            this.Age.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.groupBox5);
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
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.officerOption);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Location = new System.Drawing.Point(12, 465);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(328, 55);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Signature";
            // 
            // officerOption
            // 
            this.officerOption.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.officerOption.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.officerOption.FormattingEnabled = true;
            this.officerOption.Location = new System.Drawing.Point(107, 19);
            this.officerOption.Name = "officerOption";
            this.officerOption.Size = new System.Drawing.Size(215, 21);
            this.officerOption.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(6, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "Officer of the Day:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.SexOption);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.Relation);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.By);
            this.groupBox4.Location = new System.Drawing.Point(12, 279);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(328, 100);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Request";
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
            this.SexOption.Location = new System.Drawing.Point(92, 42);
            this.SexOption.Name = "SexOption";
            this.SexOption.Size = new System.Drawing.Size(230, 21);
            this.SexOption.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(6, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 20);
            this.label8.TabIndex = 32;
            this.label8.Text = "Relationship";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Relation
            // 
            this.Relation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Relation.Location = new System.Drawing.Point(92, 69);
            this.Relation.Name = "Relation";
            this.Relation.Size = new System.Drawing.Size(230, 20);
            this.Relation.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(6, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 30;
            this.label6.Text = "Gender";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "By:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // By
            // 
            this.By.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.By.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.By.Location = new System.Drawing.Point(92, 17);
            this.By.Name = "By";
            this.By.Size = new System.Drawing.Size(230, 20);
            this.By.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(6, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "Requested from:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DeathPlace
            // 
            this.DeathPlace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeathPlace.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.DeathPlace.Location = new System.Drawing.Point(106, 19);
            this.DeathPlace.Name = "DeathPlace";
            this.DeathPlace.Size = new System.Drawing.Size(216, 20);
            this.DeathPlace.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.DeathPlace);
            this.groupBox2.Controls.Add(this.IssuedOn);
            this.groupBox2.Location = new System.Drawing.Point(12, 385);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(328, 74);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "MISC";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 47);
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
            this.IssuedOn.CustomFormat = "MMMM dd, yyyy";
            this.IssuedOn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.IssuedOn.Location = new System.Drawing.Point(107, 45);
            this.IssuedOn.Name = "IssuedOn";
            this.IssuedOn.Size = new System.Drawing.Size(215, 20);
            this.IssuedOn.TabIndex = 2;
            // 
            // ResetBtn
            // 
            this.ResetBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ResetBtn.Location = new System.Drawing.Point(126, 653);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(100, 25);
            this.ResetBtn.TabIndex = 7;
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
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.ext);
            this.groupBox3.Controls.Add(this.lastName);
            this.groupBox3.Controls.Add(this.middleName);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.Age);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.firstName);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.Address);
            this.groupBox3.Location = new System.Drawing.Point(12, 95);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(328, 178);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DETAILS";
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(6, 95);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 20);
            this.label13.TabIndex = 29;
            this.label13.Text = "Extension:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(6, 69);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 20);
            this.label12.TabIndex = 28;
            this.label12.Text = "Last Name:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(6, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 20);
            this.label10.TabIndex = 27;
            this.label10.Text = "Middle Name:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ext
            // 
            this.ext.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ext.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ext.Location = new System.Drawing.Point(92, 95);
            this.ext.Name = "ext";
            this.ext.Size = new System.Drawing.Size(230, 20);
            this.ext.TabIndex = 4;
            // 
            // lastName
            // 
            this.lastName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lastName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.lastName.Location = new System.Drawing.Point(92, 69);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(230, 20);
            this.lastName.TabIndex = 3;
            // 
            // middleName
            // 
            this.middleName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.middleName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.middleName.Location = new System.Drawing.Point(92, 43);
            this.middleName.Name = "middleName";
            this.middleName.Size = new System.Drawing.Size(230, 20);
            this.middleName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "First Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // firstName
            // 
            this.firstName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.firstName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.firstName.Location = new System.Drawing.Point(92, 17);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(230, 20);
            this.firstName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 147);
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
            this.Address.Location = new System.Drawing.Point(92, 147);
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
            // CertIndigentMedicalAssistance
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
            this.Name = "CertIndigentMedicalAssistance";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CertIndigent - Medical Assistance";
            this.Load += new System.EventHandler(this.DeathCertificate_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DeathCertificate_KeyDown);
            this.panel1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.IdGroup.ResumeLayout(false);
            this.IdGroup.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Age;
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
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Address;
        private Printing printing;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DeathPlace;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Relation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox By;
        private System.Windows.Forms.ComboBox SexOption;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox officerOption;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ext;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.TextBox middleName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
    }
}