namespace E_Barangay.Forms
{
    partial class Preview
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
            this.OkayBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ImageBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Group = new System.Windows.Forms.GroupBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.CivilStatusOption = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.FatherTxt = new System.Windows.Forms.TextBox();
            this.EditBtn = new System.Windows.Forms.Button();
            this.SpouseTxt = new System.Windows.Forms.TextBox();
            this.RecordsTable = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddressTxt = new System.Windows.Forms.TextBox();
            this.MotherTxt = new System.Windows.Forms.TextBox();
            this.ContactTxt = new System.Windows.Forms.TextBox();
            this.AgeTxt = new System.Windows.Forms.TextBox();
            this.BdayTxt = new System.Windows.Forms.TextBox();
            this.SexTxt = new System.Windows.Forms.TextBox();
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.IsStudent = new System.Windows.Forms.CheckBox();
            this.IsSenior = new System.Windows.Forms.CheckBox();
            this.IsPwd = new System.Windows.Forms.CheckBox();
            this.IsIndigent = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).BeginInit();
            this.Group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RecordsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // OkayBtn
            // 
            this.OkayBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.OkayBtn.BackColor = System.Drawing.Color.SpringGreen;
            this.OkayBtn.FlatAppearance.BorderSize = 2;
            this.OkayBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OkayBtn.Location = new System.Drawing.Point(323, 404);
            this.OkayBtn.Name = "OkayBtn";
            this.OkayBtn.Size = new System.Drawing.Size(130, 28);
            this.OkayBtn.TabIndex = 0;
            this.OkayBtn.Text = "Done";
            this.OkayBtn.UseVisualStyleBackColor = false;
            this.OkayBtn.Click += new System.EventHandler(this.OkayBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.ImageBox);
            this.panel1.Location = new System.Drawing.Point(5, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(110, 110);
            this.panel1.TabIndex = 1;
            // 
            // ImageBox
            // 
            this.ImageBox.Location = new System.Drawing.Point(-30, -2);
            this.ImageBox.Name = "ImageBox";
            this.ImageBox.Size = new System.Drawing.Size(166, 110);
            this.ImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImageBox.TabIndex = 0;
            this.ImageBox.TabStop = false;
            this.ImageBox.Click += new System.EventHandler(this.ImageBox_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(423, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(120, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Birthday";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(143, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Age";
            // 
            // Group
            // 
            this.Group.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Group.Controls.Add(this.SaveBtn);
            this.Group.Controls.Add(this.CivilStatusOption);
            this.Group.Controls.Add(this.label9);
            this.Group.Controls.Add(this.FatherTxt);
            this.Group.Controls.Add(this.EditBtn);
            this.Group.Controls.Add(this.SpouseTxt);
            this.Group.Controls.Add(this.RecordsTable);
            this.Group.Controls.Add(this.AddressTxt);
            this.Group.Controls.Add(this.MotherTxt);
            this.Group.Controls.Add(this.ContactTxt);
            this.Group.Controls.Add(this.AgeTxt);
            this.Group.Controls.Add(this.BdayTxt);
            this.Group.Controls.Add(this.SexTxt);
            this.Group.Controls.Add(this.NameTxt);
            this.Group.Controls.Add(this.IsStudent);
            this.Group.Controls.Add(this.IsSenior);
            this.Group.Controls.Add(this.IsPwd);
            this.Group.Controls.Add(this.IsIndigent);
            this.Group.Controls.Add(this.label8);
            this.Group.Controls.Add(this.label7);
            this.Group.Controls.Add(this.label6);
            this.Group.Controls.Add(this.label11);
            this.Group.Controls.Add(this.label10);
            this.Group.Controls.Add(this.panel1);
            this.Group.Controls.Add(this.label5);
            this.Group.Controls.Add(this.label4);
            this.Group.Controls.Add(this.label3);
            this.Group.Controls.Add(this.label2);
            this.Group.Controls.Add(this.label1);
            this.Group.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Group.Location = new System.Drawing.Point(12, 5);
            this.Group.Name = "Group";
            this.Group.Size = new System.Drawing.Size(750, 393);
            this.Group.TabIndex = 18;
            this.Group.TabStop = false;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SaveBtn.BackColor = System.Drawing.SystemColors.Control;
            this.SaveBtn.Enabled = false;
            this.SaveBtn.FlatAppearance.BorderSize = 0;
            this.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBtn.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.Location = new System.Drawing.Point(6, 364);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(74, 23);
            this.SaveBtn.TabIndex = 54;
            this.SaveBtn.Text = "Save Info";
            this.SaveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // CivilStatusOption
            // 
            this.CivilStatusOption.AutoCompleteCustomSource.AddRange(new string[] {
            "Single",
            "Married"});
            this.CivilStatusOption.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.CivilStatusOption.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CivilStatusOption.BackColor = System.Drawing.Color.Silver;
            this.CivilStatusOption.Enabled = false;
            this.CivilStatusOption.FormattingEnabled = true;
            this.CivilStatusOption.Items.AddRange(new object[] {
            "Single",
            "Married"});
            this.CivilStatusOption.Location = new System.Drawing.Point(481, 81);
            this.CivilStatusOption.Name = "CivilStatusOption";
            this.CivilStatusOption.Size = new System.Drawing.Size(256, 25);
            this.CivilStatusOption.TabIndex = 53;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(121, 205);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 15);
            this.label9.TabIndex = 52;
            this.label9.Text = "Records";
            // 
            // FatherTxt
            // 
            this.FatherTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FatherTxt.BackColor = System.Drawing.Color.Silver;
            this.FatherTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FatherTxt.Location = new System.Drawing.Point(482, 144);
            this.FatherTxt.Name = "FatherTxt";
            this.FatherTxt.ReadOnly = true;
            this.FatherTxt.Size = new System.Drawing.Size(256, 25);
            this.FatherTxt.TabIndex = 51;
            // 
            // EditBtn
            // 
            this.EditBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EditBtn.BackColor = System.Drawing.SystemColors.Control;
            this.EditBtn.FlatAppearance.BorderSize = 0;
            this.EditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditBtn.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditBtn.Location = new System.Drawing.Point(5, 335);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(74, 23);
            this.EditBtn.TabIndex = 27;
            this.EditBtn.Text = "Edit Info";
            this.EditBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EditBtn.UseVisualStyleBackColor = false;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // SpouseTxt
            // 
            this.SpouseTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SpouseTxt.BackColor = System.Drawing.Color.Silver;
            this.SpouseTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SpouseTxt.Location = new System.Drawing.Point(482, 175);
            this.SpouseTxt.Name = "SpouseTxt";
            this.SpouseTxt.ReadOnly = true;
            this.SpouseTxt.Size = new System.Drawing.Size(256, 25);
            this.SpouseTxt.TabIndex = 50;
            // 
            // RecordsTable
            // 
            this.RecordsTable.AllowUserToAddRows = false;
            this.RecordsTable.AllowUserToDeleteRows = false;
            this.RecordsTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RecordsTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.RecordsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RecordsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.RecordsTable.EnableHeadersVisualStyles = false;
            this.RecordsTable.Location = new System.Drawing.Point(179, 205);
            this.RecordsTable.Name = "RecordsTable";
            this.RecordsTable.ReadOnly = true;
            this.RecordsTable.RowHeadersVisible = false;
            this.RecordsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RecordsTable.Size = new System.Drawing.Size(559, 182);
            this.RecordsTable.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Date";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Title";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Details";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // AddressTxt
            // 
            this.AddressTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddressTxt.BackColor = System.Drawing.Color.Silver;
            this.AddressTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddressTxt.Location = new System.Drawing.Point(482, 51);
            this.AddressTxt.Name = "AddressTxt";
            this.AddressTxt.ReadOnly = true;
            this.AddressTxt.Size = new System.Drawing.Size(256, 25);
            this.AddressTxt.TabIndex = 48;
            // 
            // MotherTxt
            // 
            this.MotherTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MotherTxt.BackColor = System.Drawing.Color.Silver;
            this.MotherTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MotherTxt.Location = new System.Drawing.Point(482, 113);
            this.MotherTxt.Name = "MotherTxt";
            this.MotherTxt.ReadOnly = true;
            this.MotherTxt.Size = new System.Drawing.Size(256, 25);
            this.MotherTxt.TabIndex = 47;
            // 
            // ContactTxt
            // 
            this.ContactTxt.BackColor = System.Drawing.Color.Silver;
            this.ContactTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ContactTxt.Location = new System.Drawing.Point(179, 174);
            this.ContactTxt.Name = "ContactTxt";
            this.ContactTxt.ReadOnly = true;
            this.ContactTxt.Size = new System.Drawing.Size(186, 25);
            this.ContactTxt.TabIndex = 46;
            // 
            // AgeTxt
            // 
            this.AgeTxt.BackColor = System.Drawing.Color.Silver;
            this.AgeTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AgeTxt.Location = new System.Drawing.Point(179, 112);
            this.AgeTxt.Name = "AgeTxt";
            this.AgeTxt.ReadOnly = true;
            this.AgeTxt.Size = new System.Drawing.Size(186, 25);
            this.AgeTxt.TabIndex = 45;
            // 
            // BdayTxt
            // 
            this.BdayTxt.BackColor = System.Drawing.Color.Silver;
            this.BdayTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BdayTxt.Location = new System.Drawing.Point(179, 81);
            this.BdayTxt.Name = "BdayTxt";
            this.BdayTxt.ReadOnly = true;
            this.BdayTxt.Size = new System.Drawing.Size(186, 25);
            this.BdayTxt.TabIndex = 44;
            // 
            // SexTxt
            // 
            this.SexTxt.BackColor = System.Drawing.Color.Silver;
            this.SexTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SexTxt.Location = new System.Drawing.Point(179, 143);
            this.SexTxt.Name = "SexTxt";
            this.SexTxt.ReadOnly = true;
            this.SexTxt.Size = new System.Drawing.Size(186, 25);
            this.SexTxt.TabIndex = 43;
            // 
            // NameTxt
            // 
            this.NameTxt.BackColor = System.Drawing.Color.Silver;
            this.NameTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameTxt.Location = new System.Drawing.Point(179, 50);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.ReadOnly = true;
            this.NameTxt.Size = new System.Drawing.Size(186, 25);
            this.NameTxt.TabIndex = 20;
            // 
            // IsStudent
            // 
            this.IsStudent.AutoCheck = false;
            this.IsStudent.AutoSize = true;
            this.IsStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IsStudent.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsStudent.Location = new System.Drawing.Point(6, 255);
            this.IsStudent.Name = "IsStudent";
            this.IsStudent.Size = new System.Drawing.Size(74, 21);
            this.IsStudent.TabIndex = 31;
            this.IsStudent.Text = "Student";
            this.IsStudent.UseVisualStyleBackColor = true;
            // 
            // IsSenior
            // 
            this.IsSenior.AutoCheck = false;
            this.IsSenior.AutoSize = true;
            this.IsSenior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IsSenior.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsSenior.Location = new System.Drawing.Point(6, 228);
            this.IsSenior.Name = "IsSenior";
            this.IsSenior.Size = new System.Drawing.Size(116, 21);
            this.IsSenior.TabIndex = 30;
            this.IsSenior.Text = "Senior Citizen";
            this.IsSenior.UseVisualStyleBackColor = true;
            // 
            // IsPwd
            // 
            this.IsPwd.AutoCheck = false;
            this.IsPwd.AutoSize = true;
            this.IsPwd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IsPwd.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsPwd.Location = new System.Drawing.Point(6, 201);
            this.IsPwd.Name = "IsPwd";
            this.IsPwd.Size = new System.Drawing.Size(58, 21);
            this.IsPwd.TabIndex = 29;
            this.IsPwd.Text = "PWD";
            this.IsPwd.UseVisualStyleBackColor = true;
            // 
            // IsIndigent
            // 
            this.IsIndigent.AutoCheck = false;
            this.IsIndigent.AutoSize = true;
            this.IsIndigent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IsIndigent.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsIndigent.Location = new System.Drawing.Point(6, 174);
            this.IsIndigent.Name = "IsIndigent";
            this.IsIndigent.Size = new System.Drawing.Size(79, 21);
            this.IsIndigent.TabIndex = 28;
            this.IsIndigent.Text = "Indigent";
            this.IsIndigent.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(148, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 15);
            this.label8.TabIndex = 25;
            this.label8.Text = "Sex";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(382, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 15);
            this.label7.TabIndex = 23;
            this.label7.Text = "Name of Spouse";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(404, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 15);
            this.label6.TabIndex = 21;
            this.label6.Text = "Civil Status";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(432, 147);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 15);
            this.label11.TabIndex = 18;
            this.label11.Text = "Father";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(428, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 15);
            this.label10.TabIndex = 17;
            this.label10.Text = "Mother";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(121, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Contact ";
            // 
            // Preview
            // 
            this.AcceptButton = this.OkayBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(776, 444);
            this.Controls.Add(this.Group);
            this.Controls.Add(this.OkayBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Preview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Preview";
            this.Load += new System.EventHandler(this.Preview_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).EndInit();
            this.Group.ResumeLayout(false);
            this.Group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RecordsTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OkayBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox Group;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView RecordsTable;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox IsIndigent;
        private System.Windows.Forms.CheckBox IsStudent;
        private System.Windows.Forms.CheckBox IsSenior;
        private System.Windows.Forms.CheckBox IsPwd;
        //private System.Windows.Forms.Label CivilText;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.PictureBox ImageBox;
        private System.Windows.Forms.TextBox FatherTxt;
        private System.Windows.Forms.TextBox SpouseTxt;
        private System.Windows.Forms.TextBox AddressTxt;
        private System.Windows.Forms.TextBox MotherTxt;
        private System.Windows.Forms.TextBox ContactTxt;
        private System.Windows.Forms.TextBox AgeTxt;
        private System.Windows.Forms.TextBox BdayTxt;
        private System.Windows.Forms.TextBox SexTxt;
        private System.Windows.Forms.TextBox NameTxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CivilStatusOption;
        private System.Windows.Forms.Button SaveBtn;
    }
}