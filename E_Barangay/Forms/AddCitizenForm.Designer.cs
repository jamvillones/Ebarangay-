namespace E_Barangay.Forms
{
    partial class AddCitizenForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCitizenForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.takePhotoBtn = new System.Windows.Forms.Button();
            this.imagePanel = new System.Windows.Forms.Panel();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.firstName = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.middleName = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.extensionName = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.address = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.area = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.age = new System.Windows.Forms.TextBox();
            this.birthdate = new System.Windows.Forms.DateTimePicker();
            this.contactgroup = new System.Windows.Forms.GroupBox();
            this.contact = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.sex = new System.Windows.Forms.ComboBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.civilStatus = new System.Windows.Forms.ComboBox();
            this.spouseGrp = new System.Windows.Forms.GroupBox();
            this.spouseName = new System.Windows.Forms.TextBox();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.fathersName = new System.Windows.Forms.TextBox();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.mothersName = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.indigent = new System.Windows.Forms.CheckBox();
            this.student = new System.Windows.Forms.CheckBox();
            this.pwd = new System.Windows.Forms.CheckBox();
            this.senior = new System.Windows.Forms.CheckBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.sss = new System.Windows.Forms.TextBox();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.philhealth = new System.Windows.Forms.TextBox();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.pagibig = new System.Windows.Forms.TextBox();
            this.groupBox18 = new System.Windows.Forms.GroupBox();
            this.votersId = new System.Windows.Forms.TextBox();
            this.groupBox19 = new System.Windows.Forms.GroupBox();
            this.precinctNumber = new System.Windows.Forms.TextBox();
            this.registerBtn = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.Id = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.imagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.contactgroup.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.spouseGrp.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.groupBox15.SuspendLayout();
            this.groupBox16.SuspendLayout();
            this.groupBox17.SuspendLayout();
            this.groupBox18.SuspendLayout();
            this.groupBox19.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.takePhotoBtn);
            this.groupBox1.Controls.Add(this.imagePanel);
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(150, 150);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Picture";
            // 
            // takePhotoBtn
            // 
            this.takePhotoBtn.Image = ((System.Drawing.Image)(resources.GetObject("takePhotoBtn.Image")));
            this.takePhotoBtn.Location = new System.Drawing.Point(25, 120);
            this.takePhotoBtn.Name = "takePhotoBtn";
            this.takePhotoBtn.Size = new System.Drawing.Size(100, 23);
            this.takePhotoBtn.TabIndex = 100;
            this.takePhotoBtn.TabStop = false;
            this.takePhotoBtn.Text = "Take photo";
            this.takePhotoBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.takePhotoBtn.UseVisualStyleBackColor = true;
            this.takePhotoBtn.Click += new System.EventHandler(this.takePhotoBtn_Click);
            // 
            // imagePanel
            // 
            this.imagePanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.imagePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imagePanel.Controls.Add(this.picBox);
            this.imagePanel.Location = new System.Drawing.Point(25, 14);
            this.imagePanel.Name = "imagePanel";
            this.imagePanel.Size = new System.Drawing.Size(100, 100);
            this.imagePanel.TabIndex = 0;
            // 
            // picBox
            // 
            this.picBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picBox.Location = new System.Drawing.Point(-59, -1);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(217, 101);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox.TabIndex = 0;
            this.picBox.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.firstName);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(168, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(160, 40);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "First name";
            // 
            // firstName
            // 
            this.firstName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.firstName.BackColor = System.Drawing.SystemColors.Control;
            this.firstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.firstName.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstName.Location = new System.Drawing.Point(5, 19);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(149, 15);
            this.firstName.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.middleName);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(334, 52);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(160, 40);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Middle name";
            // 
            // middleName
            // 
            this.middleName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.middleName.BackColor = System.Drawing.SystemColors.Control;
            this.middleName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.middleName.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.middleName.Location = new System.Drawing.Point(5, 19);
            this.middleName.Name = "middleName";
            this.middleName.Size = new System.Drawing.Size(149, 15);
            this.middleName.TabIndex = 3;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lastName);
            this.groupBox4.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(500, 52);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(160, 40);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Last name";
            // 
            // lastName
            // 
            this.lastName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lastName.BackColor = System.Drawing.SystemColors.Control;
            this.lastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lastName.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastName.Location = new System.Drawing.Point(5, 19);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(149, 15);
            this.lastName.TabIndex = 4;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.extensionName);
            this.groupBox5.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(666, 52);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(92, 40);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Extension name";
            // 
            // extensionName
            // 
            this.extensionName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.extensionName.BackColor = System.Drawing.SystemColors.Control;
            this.extensionName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.extensionName.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extensionName.Location = new System.Drawing.Point(5, 19);
            this.extensionName.Name = "extensionName";
            this.extensionName.Size = new System.Drawing.Size(81, 15);
            this.extensionName.TabIndex = 5;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.address);
            this.groupBox6.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(168, 107);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(492, 40);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Address";
            // 
            // address
            // 
            this.address.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.address.BackColor = System.Drawing.SystemColors.Control;
            this.address.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.address.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address.Location = new System.Drawing.Point(5, 19);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(481, 15);
            this.address.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(168, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(590, 1);
            this.panel1.TabIndex = 5;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.area);
            this.groupBox7.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(666, 107);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(92, 40);
            this.groupBox7.TabIndex = 7;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Area";
            // 
            // area
            // 
            this.area.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.area.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.area.BackColor = System.Drawing.SystemColors.Control;
            this.area.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.area.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.area.FormattingEnabled = true;
            this.area.Location = new System.Drawing.Point(5, 14);
            this.area.Name = "area";
            this.area.Size = new System.Drawing.Size(81, 22);
            this.area.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(168, 153);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(590, 1);
            this.panel2.TabIndex = 6;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.age);
            this.groupBox8.Controls.Add(this.birthdate);
            this.groupBox8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox8.Location = new System.Drawing.Point(12, 162);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(316, 40);
            this.groupBox8.TabIndex = 8;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Birth Date";
            // 
            // age
            // 
            this.age.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.age.BackColor = System.Drawing.SystemColors.Control;
            this.age.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.age.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.age.Location = new System.Drawing.Point(236, 17);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(74, 15);
            this.age.TabIndex = 1;
            this.age.TabStop = false;
            // 
            // birthdate
            // 
            this.birthdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.birthdate.CustomFormat = "MMMM, dd yyyy";
            this.birthdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.birthdate.Location = new System.Drawing.Point(7, 14);
            this.birthdate.Name = "birthdate";
            this.birthdate.Size = new System.Drawing.Size(223, 20);
            this.birthdate.TabIndex = 8;
            this.birthdate.ValueChanged += new System.EventHandler(this.birthdate_ValueChanged);
            // 
            // contactgroup
            // 
            this.contactgroup.Controls.Add(this.contact);
            this.contactgroup.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactgroup.Location = new System.Drawing.Point(500, 162);
            this.contactgroup.Name = "contactgroup";
            this.contactgroup.Size = new System.Drawing.Size(258, 40);
            this.contactgroup.TabIndex = 10;
            this.contactgroup.TabStop = false;
            this.contactgroup.Text = "Contact Details";
            // 
            // contact
            // 
            this.contact.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contact.BackColor = System.Drawing.SystemColors.Control;
            this.contact.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.contact.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contact.Location = new System.Drawing.Point(5, 19);
            this.contact.MaxLength = 4;
            this.contact.Name = "contact";
            this.contact.Size = new System.Drawing.Size(247, 15);
            this.contact.TabIndex = 0;
            this.contact.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(12, 208);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(746, 1);
            this.panel3.TabIndex = 7;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.sex);
            this.groupBox10.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox10.Location = new System.Drawing.Point(334, 162);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(160, 40);
            this.groupBox10.TabIndex = 9;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Sex";
            // 
            // sex
            // 
            this.sex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sex.AutoCompleteCustomSource.AddRange(new string[] {
            "Male",
            "Female"});
            this.sex.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.sex.BackColor = System.Drawing.SystemColors.Control;
            this.sex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sex.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sex.FormattingEnabled = true;
            this.sex.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.sex.Location = new System.Drawing.Point(5, 14);
            this.sex.Name = "sex";
            this.sex.Size = new System.Drawing.Size(149, 22);
            this.sex.TabIndex = 9;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.civilStatus);
            this.groupBox11.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox11.Location = new System.Drawing.Point(12, 215);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(160, 40);
            this.groupBox11.TabIndex = 11;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Civil Status";
            // 
            // civilStatus
            // 
            this.civilStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.civilStatus.AutoCompleteCustomSource.AddRange(new string[] {
            "Single",
            "Married",
            "Widow"});
            this.civilStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.civilStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.civilStatus.BackColor = System.Drawing.SystemColors.Control;
            this.civilStatus.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.civilStatus.FormattingEnabled = true;
            this.civilStatus.Items.AddRange(new object[] {
            "Single",
            "Married",
            "Widow"});
            this.civilStatus.Location = new System.Drawing.Point(5, 14);
            this.civilStatus.Name = "civilStatus";
            this.civilStatus.Size = new System.Drawing.Size(149, 22);
            this.civilStatus.TabIndex = 6;
            this.civilStatus.SelectedIndexChanged += new System.EventHandler(this.civilStatCb_SelectedIndexChanged);
            // 
            // spouseGrp
            // 
            this.spouseGrp.Controls.Add(this.spouseName);
            this.spouseGrp.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spouseGrp.Location = new System.Drawing.Point(178, 215);
            this.spouseGrp.Name = "spouseGrp";
            this.spouseGrp.Size = new System.Drawing.Size(414, 40);
            this.spouseGrp.TabIndex = 12;
            this.spouseGrp.TabStop = false;
            this.spouseGrp.Text = "Spouse Name";
            this.spouseGrp.Visible = false;
            // 
            // spouseName
            // 
            this.spouseName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spouseName.BackColor = System.Drawing.SystemColors.Control;
            this.spouseName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.spouseName.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spouseName.Location = new System.Drawing.Point(5, 19);
            this.spouseName.Name = "spouseName";
            this.spouseName.Size = new System.Drawing.Size(403, 15);
            this.spouseName.TabIndex = 0;
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.fathersName);
            this.groupBox13.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox13.Location = new System.Drawing.Point(12, 261);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(580, 40);
            this.groupBox13.TabIndex = 13;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Father\'s Name";
            // 
            // fathersName
            // 
            this.fathersName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fathersName.BackColor = System.Drawing.SystemColors.Control;
            this.fathersName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fathersName.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fathersName.Location = new System.Drawing.Point(5, 19);
            this.fathersName.Name = "fathersName";
            this.fathersName.Size = new System.Drawing.Size(569, 15);
            this.fathersName.TabIndex = 0;
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.mothersName);
            this.groupBox14.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox14.Location = new System.Drawing.Point(12, 307);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(580, 40);
            this.groupBox14.TabIndex = 14;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Mother\'s Name";
            // 
            // mothersName
            // 
            this.mothersName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mothersName.BackColor = System.Drawing.SystemColors.Control;
            this.mothersName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mothersName.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mothersName.Location = new System.Drawing.Point(5, 19);
            this.mothersName.Name = "mothersName";
            this.mothersName.Size = new System.Drawing.Size(569, 15);
            this.mothersName.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(598, 215);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1, 132);
            this.panel4.TabIndex = 9;
            // 
            // indigent
            // 
            this.indigent.AutoSize = true;
            this.indigent.Location = new System.Drawing.Point(605, 215);
            this.indigent.Name = "indigent";
            this.indigent.Size = new System.Drawing.Size(64, 17);
            this.indigent.TabIndex = 15;
            this.indigent.Text = "Indigent";
            this.indigent.UseVisualStyleBackColor = true;
            // 
            // student
            // 
            this.student.AutoSize = true;
            this.student.Location = new System.Drawing.Point(606, 253);
            this.student.Name = "student";
            this.student.Size = new System.Drawing.Size(63, 17);
            this.student.TabIndex = 16;
            this.student.Text = "Student";
            this.student.UseVisualStyleBackColor = true;
            // 
            // pwd
            // 
            this.pwd.AutoSize = true;
            this.pwd.Location = new System.Drawing.Point(606, 291);
            this.pwd.Name = "pwd";
            this.pwd.Size = new System.Drawing.Size(123, 17);
            this.pwd.TabIndex = 17;
            this.pwd.Text = "Person with disability";
            this.pwd.UseVisualStyleBackColor = true;
            // 
            // senior
            // 
            this.senior.AutoSize = true;
            this.senior.Location = new System.Drawing.Point(606, 329);
            this.senior.Name = "senior";
            this.senior.Size = new System.Drawing.Size(90, 17);
            this.senior.TabIndex = 18;
            this.senior.Text = "Senior Citizen";
            this.senior.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel5.Location = new System.Drawing.Point(12, 353);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(746, 1);
            this.panel5.TabIndex = 8;
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.sss);
            this.groupBox15.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox15.Location = new System.Drawing.Point(12, 360);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(371, 40);
            this.groupBox15.TabIndex = 19;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "SSS Number";
            // 
            // sss
            // 
            this.sss.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sss.BackColor = System.Drawing.SystemColors.Control;
            this.sss.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sss.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sss.Location = new System.Drawing.Point(5, 19);
            this.sss.Name = "sss";
            this.sss.Size = new System.Drawing.Size(360, 15);
            this.sss.TabIndex = 0;
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.philhealth);
            this.groupBox16.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox16.Location = new System.Drawing.Point(12, 406);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(371, 40);
            this.groupBox16.TabIndex = 20;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "Philhealth Number";
            // 
            // philhealth
            // 
            this.philhealth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.philhealth.BackColor = System.Drawing.SystemColors.Control;
            this.philhealth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.philhealth.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.philhealth.Location = new System.Drawing.Point(5, 19);
            this.philhealth.Name = "philhealth";
            this.philhealth.Size = new System.Drawing.Size(360, 15);
            this.philhealth.TabIndex = 0;
            // 
            // groupBox17
            // 
            this.groupBox17.Controls.Add(this.pagibig);
            this.groupBox17.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox17.Location = new System.Drawing.Point(12, 452);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Size = new System.Drawing.Size(371, 40);
            this.groupBox17.TabIndex = 21;
            this.groupBox17.TabStop = false;
            this.groupBox17.Text = "Pag ibig Number";
            // 
            // pagibig
            // 
            this.pagibig.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pagibig.BackColor = System.Drawing.SystemColors.Control;
            this.pagibig.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pagibig.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pagibig.Location = new System.Drawing.Point(5, 19);
            this.pagibig.Name = "pagibig";
            this.pagibig.Size = new System.Drawing.Size(360, 15);
            this.pagibig.TabIndex = 0;
            // 
            // groupBox18
            // 
            this.groupBox18.Controls.Add(this.votersId);
            this.groupBox18.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox18.Location = new System.Drawing.Point(389, 360);
            this.groupBox18.Name = "groupBox18";
            this.groupBox18.Size = new System.Drawing.Size(370, 40);
            this.groupBox18.TabIndex = 22;
            this.groupBox18.TabStop = false;
            this.groupBox18.Text = "Voter\'s Id";
            // 
            // votersId
            // 
            this.votersId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.votersId.BackColor = System.Drawing.SystemColors.Control;
            this.votersId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.votersId.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.votersId.Location = new System.Drawing.Point(5, 19);
            this.votersId.Name = "votersId";
            this.votersId.Size = new System.Drawing.Size(359, 15);
            this.votersId.TabIndex = 0;
            // 
            // groupBox19
            // 
            this.groupBox19.Controls.Add(this.precinctNumber);
            this.groupBox19.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox19.Location = new System.Drawing.Point(389, 406);
            this.groupBox19.Name = "groupBox19";
            this.groupBox19.Size = new System.Drawing.Size(370, 40);
            this.groupBox19.TabIndex = 23;
            this.groupBox19.TabStop = false;
            this.groupBox19.Text = "Precinct Number";
            // 
            // precinctNumber
            // 
            this.precinctNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.precinctNumber.BackColor = System.Drawing.SystemColors.Control;
            this.precinctNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.precinctNumber.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precinctNumber.Location = new System.Drawing.Point(5, 19);
            this.precinctNumber.Name = "precinctNumber";
            this.precinctNumber.Size = new System.Drawing.Size(359, 15);
            this.precinctNumber.TabIndex = 0;
            // 
            // registerBtn
            // 
            this.registerBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.registerBtn.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerBtn.Location = new System.Drawing.Point(329, 508);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(113, 34);
            this.registerBtn.TabIndex = 0;
            this.registerBtn.TabStop = false;
            this.registerBtn.Text = "Register";
            this.registerBtn.UseVisualStyleBackColor = true;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel7.Location = new System.Drawing.Point(12, 498);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(746, 1);
            this.panel7.TabIndex = 10;
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.Id);
            this.groupBox12.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox12.Location = new System.Drawing.Point(168, 6);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(590, 40);
            this.groupBox12.TabIndex = 1;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Citizen Id";
            // 
            // Id
            // 
            this.Id.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Id.BackColor = System.Drawing.SystemColors.Control;
            this.Id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Id.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id.Location = new System.Drawing.Point(5, 19);
            this.Id.MaxLength = 50;
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(579, 15);
            this.Id.TabIndex = 1;
            this.Id.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Id_KeyDown);
            this.Id.Leave += new System.EventHandler(this.Id_Leave);
            // 
            // AddCitizenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 554);
            this.Controls.Add(this.groupBox12);
            this.Controls.Add(this.contactgroup);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.groupBox19);
            this.Controls.Add(this.groupBox18);
            this.Controls.Add(this.groupBox17);
            this.Controls.Add(this.groupBox16);
            this.Controls.Add(this.groupBox15);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.senior);
            this.Controls.Add(this.pwd);
            this.Controls.Add(this.student);
            this.Controls.Add(this.indigent);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.groupBox14);
            this.Controls.Add(this.groupBox13);
            this.Controls.Add(this.spouseGrp);
            this.Controls.Add(this.groupBox11);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddCitizenForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Citizen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddCitizenForm_FormClosing);
            this.Load += new System.EventHandler(this.AddCitizenForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.imagePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.contactgroup.ResumeLayout(false);
            this.contactgroup.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.spouseGrp.ResumeLayout(false);
            this.spouseGrp.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.groupBox15.ResumeLayout(false);
            this.groupBox15.PerformLayout();
            this.groupBox16.ResumeLayout(false);
            this.groupBox16.PerformLayout();
            this.groupBox17.ResumeLayout(false);
            this.groupBox17.PerformLayout();
            this.groupBox18.ResumeLayout(false);
            this.groupBox18.PerformLayout();
            this.groupBox19.ResumeLayout(false);
            this.groupBox19.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox middleName;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox extensionName;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ComboBox area;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.DateTimePicker birthdate;
        private System.Windows.Forms.TextBox age;
        private System.Windows.Forms.GroupBox contactgroup;
        private System.Windows.Forms.TextBox contact;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.ComboBox sex;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.ComboBox civilStatus;
        private System.Windows.Forms.GroupBox spouseGrp;
        private System.Windows.Forms.TextBox spouseName;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.TextBox fathersName;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.TextBox mothersName;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.CheckBox indigent;
        private System.Windows.Forms.CheckBox student;
        private System.Windows.Forms.CheckBox pwd;
        private System.Windows.Forms.CheckBox senior;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.TextBox sss;
        private System.Windows.Forms.GroupBox groupBox16;
        private System.Windows.Forms.TextBox philhealth;
        private System.Windows.Forms.GroupBox groupBox17;
        private System.Windows.Forms.TextBox pagibig;
        private System.Windows.Forms.GroupBox groupBox18;
        private System.Windows.Forms.TextBox votersId;
        private System.Windows.Forms.GroupBox groupBox19;
        private System.Windows.Forms.TextBox precinctNumber;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Panel imagePanel;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.TextBox Id;
        private System.Windows.Forms.Button takePhotoBtn;
    }
}