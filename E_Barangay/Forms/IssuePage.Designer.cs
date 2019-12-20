namespace E_Barangay.Forms
{
    partial class IssuePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IssuePage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Purpose = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Age = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.TextBox();
            this.middleName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.TextBox();
            this.CStatusOption = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.TextBox();
            this.IssuedOn = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ORIssueDate = new System.Windows.Forms.DateTimePicker();
            this.OrValidityDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.OrNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PrintBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.PrintPreviewBtn = new System.Windows.Forms.Button();
            this.printPreviewControl1 = new System.Windows.Forms.PrintPreviewControl();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 477);
            this.panel1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.Purpose);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.Age);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.lastName);
            this.groupBox3.Controls.Add(this.middleName);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.firstName);
            this.groupBox3.Controls.Add(this.CStatusOption);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.Address);
            this.groupBox3.Controls.Add(this.IssuedOn);
            this.groupBox3.Location = new System.Drawing.Point(13, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(176, 234);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DETAILS";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(6, 120);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 20);
            this.label12.TabIndex = 28;
            this.label12.Text = "Purpose:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Purpose
            // 
            this.Purpose.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Purpose.Location = new System.Drawing.Point(83, 121);
            this.Purpose.Name = "Purpose";
            this.Purpose.Size = new System.Drawing.Size(87, 20);
            this.Purpose.TabIndex = 27;
            this.Purpose.Text = "EMPLOYMENT";
            this.Purpose.TextChanged += new System.EventHandler(this.MadeChangesCallback);
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(6, 94);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 20);
            this.label11.TabIndex = 26;
            this.label11.Text = "Age:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Age
            // 
            this.Age.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Age.Location = new System.Drawing.Point(83, 95);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(87, 20);
            this.Age.TabIndex = 4;
            this.Age.Text = "21";
            this.Age.TextChanged += new System.EventHandler(this.MadeChangesCallback);
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(6, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 20);
            this.label10.TabIndex = 24;
            this.label10.Text = "Last Name:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(6, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 20);
            this.label9.TabIndex = 23;
            this.label9.Text = "Middle Initial:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lastName
            // 
            this.lastName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.lastName.Location = new System.Drawing.Point(83, 69);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(87, 20);
            this.lastName.TabIndex = 3;
            this.lastName.Text = "VILLONES";
            this.lastName.TextChanged += new System.EventHandler(this.MadeChangesCallback);
            // 
            // middleName
            // 
            this.middleName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.middleName.Location = new System.Drawing.Point(83, 43);
            this.middleName.MaxLength = 1;
            this.middleName.Name = "middleName";
            this.middleName.Size = new System.Drawing.Size(87, 20);
            this.middleName.TabIndex = 2;
            this.middleName.Text = "P";
            this.middleName.TextChanged += new System.EventHandler(this.MadeChangesCallback);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "First Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Civil Status";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // firstName
            // 
            this.firstName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.firstName.Location = new System.Drawing.Point(83, 17);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(87, 20);
            this.firstName.TabIndex = 1;
            this.firstName.Text = "JAMIL";
            this.firstName.TextChanged += new System.EventHandler(this.MadeChangesCallback);
            // 
            // CStatusOption
            // 
            this.CStatusOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CStatusOption.FormattingEnabled = true;
            this.CStatusOption.Items.AddRange(new object[] {
            "Single",
            "Married"});
            this.CStatusOption.Location = new System.Drawing.Point(72, 207);
            this.CStatusOption.Name = "CStatusOption";
            this.CStatusOption.Size = new System.Drawing.Size(98, 21);
            this.CStatusOption.TabIndex = 7;
            this.CStatusOption.SelectedIndexChanged += new System.EventHandler(this.MadeChangesCallback);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Issued On:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Address";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Address
            // 
            this.Address.Location = new System.Drawing.Point(72, 180);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(98, 20);
            this.Address.TabIndex = 6;
            this.Address.Text = "Torralba, Banga, Aklan";
            this.Address.TextChanged += new System.EventHandler(this.MadeChangesCallback);
            // 
            // IssuedOn
            // 
            this.IssuedOn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.IssuedOn.Location = new System.Drawing.Point(72, 153);
            this.IssuedOn.Name = "IssuedOn";
            this.IssuedOn.Size = new System.Drawing.Size(98, 20);
            this.IssuedOn.TabIndex = 5;
            this.IssuedOn.ValueChanged += new System.EventHandler(this.MadeChangesCallback);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ORIssueDate);
            this.groupBox1.Controls.Add(this.OrValidityDate);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.OrNo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(13, 256);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(176, 124);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "OR";
            // 
            // ORIssueDate
            // 
            this.ORIssueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ORIssueDate.Location = new System.Drawing.Point(72, 43);
            this.ORIssueDate.Name = "ORIssueDate";
            this.ORIssueDate.Size = new System.Drawing.Size(98, 20);
            this.ORIssueDate.TabIndex = 2;
            this.ORIssueDate.ValueChanged += new System.EventHandler(this.MadeChangesCallback);
            // 
            // OrValidityDate
            // 
            this.OrValidityDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.OrValidityDate.Location = new System.Drawing.Point(72, 69);
            this.OrValidityDate.Name = "OrValidityDate";
            this.OrValidityDate.Size = new System.Drawing.Size(98, 20);
            this.OrValidityDate.TabIndex = 3;
            this.OrValidityDate.ValueChanged += new System.EventHandler(this.MadeChangesCallback);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(6, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "VALIDITY:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(6, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Issued On:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OrNo
            // 
            this.OrNo.Location = new System.Drawing.Point(72, 17);
            this.OrNo.MaxLength = 20;
            this.OrNo.Name = "OrNo";
            this.OrNo.Size = new System.Drawing.Size(98, 20);
            this.OrNo.TabIndex = 1;
            this.OrNo.Text = "0001";
            this.OrNo.TextChanged += new System.EventHandler(this.MadeChangesCallback);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "ORNO:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.PrintBtn);
            this.panel2.Controls.Add(this.UpdateBtn);
            this.panel2.Controls.Add(this.PrintPreviewBtn);
            this.panel2.Controls.Add(this.printPreviewControl1);
            this.panel2.Location = new System.Drawing.Point(216, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(423, 447);
            this.panel2.TabIndex = 1;
            // 
            // PrintBtn
            // 
            this.PrintBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PrintBtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.PrintBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrintBtn.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintBtn.Image = ((System.Drawing.Image)(resources.GetObject("PrintBtn.Image")));
            this.PrintBtn.Location = new System.Drawing.Point(385, 8);
            this.PrintBtn.Name = "PrintBtn";
            this.PrintBtn.Size = new System.Drawing.Size(35, 30);
            this.PrintBtn.TabIndex = 4;
            this.PrintBtn.UseVisualStyleBackColor = false;
            this.PrintBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.UpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateBtn.Image = ((System.Drawing.Image)(resources.GetObject("UpdateBtn.Image")));
            this.UpdateBtn.Location = new System.Drawing.Point(3, 8);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(35, 30);
            this.UpdateBtn.TabIndex = 3;
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // PrintPreviewBtn
            // 
            this.PrintPreviewBtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.PrintPreviewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrintPreviewBtn.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintPreviewBtn.Image = ((System.Drawing.Image)(resources.GetObject("PrintPreviewBtn.Image")));
            this.PrintPreviewBtn.Location = new System.Drawing.Point(44, 8);
            this.PrintPreviewBtn.Name = "PrintPreviewBtn";
            this.PrintPreviewBtn.Size = new System.Drawing.Size(35, 30);
            this.PrintPreviewBtn.TabIndex = 1;
            this.PrintPreviewBtn.UseVisualStyleBackColor = false;
            this.PrintPreviewBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // printPreviewControl1
            // 
            this.printPreviewControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.printPreviewControl1.AutoZoom = false;
            this.printPreviewControl1.Location = new System.Drawing.Point(3, 44);
            this.printPreviewControl1.Name = "printPreviewControl1";
            this.printPreviewControl1.Size = new System.Drawing.Size(417, 403);
            this.printPreviewControl1.TabIndex = 0;
            this.printPreviewControl1.Zoom = 0.36272727272727273D;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // IssuePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "IssuePage";
            this.Size = new System.Drawing.Size(655, 477);
            this.Load += new System.EventHandler(this.IssuePage_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PrintPreviewControl printPreviewControl1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button PrintPreviewBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.DateTimePicker IssuedOn;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker OrValidityDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox OrNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CStatusOption;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.TextBox middleName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Age;
        private System.Windows.Forms.TextBox Purpose;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker ORIssueDate;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button PrintBtn;
        private System.Windows.Forms.PrintDialog printDialog1;
    }
}
