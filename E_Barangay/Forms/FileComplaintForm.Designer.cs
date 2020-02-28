namespace E_Barangay.Forms
{
    partial class FileComplaintForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.complainantPanel = new System.Windows.Forms.Panel();
            this.dgvComplainants = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.complainantLabel = new System.Windows.Forms.Label();
            this.dtPanel = new System.Windows.Forms.Panel();
            this.dtIncident = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.settlePanel = new System.Windows.Forms.Panel();
            this.dtSettlement = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.locationPanel = new System.Windows.Forms.Panel();
            this.locationField = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Divider2 = new System.Windows.Forms.Panel();
            this.Divider1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvRespondents = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.controlNoPanel = new System.Windows.Forms.Panel();
            this.controlNumberField = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Divider3 = new System.Windows.Forms.Panel();
            this.narrativeField = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.wordCounter = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.complainantPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComplainants)).BeginInit();
            this.dtPanel.SuspendLayout();
            this.settlePanel.SuspendLayout();
            this.locationPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRespondents)).BeginInit();
            this.controlNoPanel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // complainantPanel
            // 
            this.complainantPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.complainantPanel.Controls.Add(this.dgvComplainants);
            this.complainantPanel.Controls.Add(this.complainantLabel);
            this.complainantPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.complainantPanel.Location = new System.Drawing.Point(3, 3);
            this.complainantPanel.Name = "complainantPanel";
            this.complainantPanel.Size = new System.Drawing.Size(527, 168);
            this.complainantPanel.TabIndex = 1;
            // 
            // dgvComplainants
            // 
            this.dgvComplainants.AllowUserToOrderColumns = true;
            this.dgvComplainants.AllowUserToResizeColumns = false;
            this.dgvComplainants.AllowUserToResizeRows = false;
            this.dgvComplainants.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvComplainants.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvComplainants.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvComplainants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComplainants.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvComplainants.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvComplainants.EnableHeadersVisualStyles = false;
            this.dgvComplainants.Location = new System.Drawing.Point(0, 27);
            this.dgvComplainants.Name = "dgvComplainants";
            this.dgvComplainants.RowHeadersVisible = false;
            this.dgvComplainants.Size = new System.Drawing.Size(527, 141);
            this.dgvComplainants.StandardTab = true;
            this.dgvComplainants.TabIndex = 2;
            this.dgvComplainants.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellDoubleClick);
            this.dgvComplainants.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellEndEdit);
            this.dgvComplainants.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgv_EditingControlShowing);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Name";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.HeaderText = "Registered";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 64;
            // 
            // complainantLabel
            // 
            this.complainantLabel.AutoSize = true;
            this.complainantLabel.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.complainantLabel.Location = new System.Drawing.Point(9, 8);
            this.complainantLabel.Name = "complainantLabel";
            this.complainantLabel.Size = new System.Drawing.Size(74, 14);
            this.complainantLabel.TabIndex = 1;
            this.complainantLabel.Text = "Complainant/s";
            // 
            // dtPanel
            // 
            this.dtPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.dtPanel.Controls.Add(this.dtIncident);
            this.dtPanel.Controls.Add(this.label2);
            this.dtPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtPanel.Location = new System.Drawing.Point(3, 3);
            this.dtPanel.Name = "dtPanel";
            this.dtPanel.Size = new System.Drawing.Size(528, 26);
            this.dtPanel.TabIndex = 2;
            // 
            // dtIncident
            // 
            this.dtIncident.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtIncident.CustomFormat = "MMMM dd, yyyy hh:mm tt";
            this.dtIncident.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtIncident.Location = new System.Drawing.Point(145, 3);
            this.dtIncident.Name = "dtIncident";
            this.dtIncident.Size = new System.Drawing.Size(380, 20);
            this.dtIncident.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date/Time of Incident\r\n";
            // 
            // settlePanel
            // 
            this.settlePanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.settlePanel.Controls.Add(this.dtSettlement);
            this.settlePanel.Controls.Add(this.label3);
            this.settlePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settlePanel.Location = new System.Drawing.Point(3, 35);
            this.settlePanel.Name = "settlePanel";
            this.settlePanel.Size = new System.Drawing.Size(528, 27);
            this.settlePanel.TabIndex = 3;
            // 
            // dtSettlement
            // 
            this.dtSettlement.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtSettlement.CustomFormat = "MMMM dd, yyyy hh:mm tt";
            this.dtSettlement.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtSettlement.Location = new System.Drawing.Point(145, 3);
            this.dtSettlement.Name = "dtSettlement";
            this.dtSettlement.Size = new System.Drawing.Size(380, 20);
            this.dtSettlement.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Settlement Schedule";
            // 
            // locationPanel
            // 
            this.locationPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.locationPanel.Controls.Add(this.locationField);
            this.locationPanel.Controls.Add(this.label5);
            this.locationPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.locationPanel.Location = new System.Drawing.Point(537, 3);
            this.locationPanel.Name = "locationPanel";
            this.locationPanel.Size = new System.Drawing.Size(529, 26);
            this.locationPanel.TabIndex = 4;
            // 
            // locationField
            // 
            this.locationField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.locationField.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationField.Location = new System.Drawing.Point(99, 3);
            this.locationField.MaxLength = 50;
            this.locationField.Name = "locationField";
            this.locationField.Size = new System.Drawing.Size(427, 20);
            this.locationField.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 14);
            this.label5.TabIndex = 2;
            this.label5.Text = "Incident Location";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 14);
            this.label6.TabIndex = 6;
            this.label6.Text = "Narrative";
            // 
            // Divider2
            // 
            this.Divider2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Divider2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Divider2.Location = new System.Drawing.Point(12, 135);
            this.Divider2.Name = "Divider2";
            this.Divider2.Size = new System.Drawing.Size(1067, 1);
            this.Divider2.TabIndex = 7;
            // 
            // Divider1
            // 
            this.Divider1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Divider1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Divider1.Location = new System.Drawing.Point(12, 52);
            this.Divider1.Name = "Divider1";
            this.Divider1.Size = new System.Drawing.Size(1067, 1);
            this.Divider1.TabIndex = 8;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.complainantPanel, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 142);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1067, 174);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.dgvRespondents);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(536, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(528, 168);
            this.panel1.TabIndex = 3;
            // 
            // dgvRespondents
            // 
            this.dgvRespondents.AllowUserToOrderColumns = true;
            this.dgvRespondents.AllowUserToResizeColumns = false;
            this.dgvRespondents.AllowUserToResizeRows = false;
            this.dgvRespondents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRespondents.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRespondents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRespondents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRespondents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewCheckBoxColumn1});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRespondents.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvRespondents.EnableHeadersVisualStyles = false;
            this.dgvRespondents.Location = new System.Drawing.Point(0, 27);
            this.dgvRespondents.Name = "dgvRespondents";
            this.dgvRespondents.RowHeadersVisible = false;
            this.dgvRespondents.Size = new System.Drawing.Size(528, 141);
            this.dgvRespondents.StandardTab = true;
            this.dgvRespondents.TabIndex = 2;
            this.dgvRespondents.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellDoubleClick);
            this.dgvRespondents.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellEndEdit);
            this.dgvRespondents.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgv_EditingControlShowing);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewCheckBoxColumn1.HeaderText = "Registered";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Width = 64;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 14);
            this.label4.TabIndex = 1;
            this.label4.Text = "Respondent/s";
            // 
            // controlNoPanel
            // 
            this.controlNoPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.controlNoPanel.Controls.Add(this.controlNumberField);
            this.controlNoPanel.Controls.Add(this.label7);
            this.controlNoPanel.Location = new System.Drawing.Point(15, 12);
            this.controlNoPanel.Name = "controlNoPanel";
            this.controlNoPanel.Size = new System.Drawing.Size(527, 26);
            this.controlNoPanel.TabIndex = 1;
            // 
            // controlNumberField
            // 
            this.controlNumberField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.controlNumberField.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlNumberField.Location = new System.Drawing.Point(88, 3);
            this.controlNumberField.MaxLength = 10;
            this.controlNumberField.Name = "controlNumberField";
            this.controlNumberField.Size = new System.Drawing.Size(436, 20);
            this.controlNumberField.TabIndex = 3;
            this.controlNumberField.TextChanged += new System.EventHandler(this.controlNumberField_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 14);
            this.label7.TabIndex = 2;
            this.label7.Text = "Control Number:";
            // 
            // Divider3
            // 
            this.Divider3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Divider3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Divider3.Location = new System.Drawing.Point(13, 322);
            this.Divider3.Name = "Divider3";
            this.Divider3.Size = new System.Drawing.Size(1067, 1);
            this.Divider3.TabIndex = 10;
            // 
            // narrativeField
            // 
            this.narrativeField.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.narrativeField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.narrativeField.Location = new System.Drawing.Point(0, 26);
            this.narrativeField.MaxLength = 3000;
            this.narrativeField.Multiline = true;
            this.narrativeField.Name = "narrativeField";
            this.narrativeField.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.narrativeField.Size = new System.Drawing.Size(1062, 224);
            this.narrativeField.TabIndex = 4;
            this.narrativeField.TextChanged += new System.EventHandler(this.narrativeField_TextChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.dtPanel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.settlePanel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.locationPanel, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(11, 62);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1069, 65);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.wordCounter);
            this.panel2.Controls.Add(this.narrativeField);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(14, 329);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1062, 250);
            this.panel2.TabIndex = 11;
            // 
            // wordCounter
            // 
            this.wordCounter.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.wordCounter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.wordCounter.Location = new System.Drawing.Point(854, 7);
            this.wordCounter.Name = "wordCounter";
            this.wordCounter.ReadOnly = true;
            this.wordCounter.Size = new System.Drawing.Size(100, 13);
            this.wordCounter.TabIndex = 7;
            this.wordCounter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Location = new System.Drawing.Point(484, 593);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(124, 23);
            this.saveBtn.TabIndex = 12;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // FileComplaintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 628);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.Divider3);
            this.Controls.Add(this.controlNoPanel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.Divider1);
            this.Controls.Add(this.Divider2);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(704, 481);
            this.Name = "FileComplaintForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Complaint";
            this.Load += new System.EventHandler(this.FileComplaintForm_Load);
            this.complainantPanel.ResumeLayout(false);
            this.complainantPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComplainants)).EndInit();
            this.dtPanel.ResumeLayout(false);
            this.dtPanel.PerformLayout();
            this.settlePanel.ResumeLayout(false);
            this.settlePanel.PerformLayout();
            this.locationPanel.ResumeLayout(false);
            this.locationPanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRespondents)).EndInit();
            this.controlNoPanel.ResumeLayout(false);
            this.controlNoPanel.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel complainantPanel;
        private System.Windows.Forms.Label complainantLabel;
        private System.Windows.Forms.Panel dtPanel;
        private System.Windows.Forms.DateTimePicker dtIncident;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel settlePanel;
        private System.Windows.Forms.DateTimePicker dtSettlement;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel locationPanel;
        private System.Windows.Forms.TextBox locationField;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel Divider2;
        private System.Windows.Forms.Panel Divider1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel controlNoPanel;
        private System.Windows.Forms.TextBox controlNumberField;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel Divider3;
        private System.Windows.Forms.TextBox narrativeField;
        private System.Windows.Forms.DataGridView dgvComplainants;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvRespondents;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.TextBox wordCounter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column2;

        //private System.Windows.Forms.Panel panel10;
        //private System.Windows.Forms.Panel panel11;
        //private System.Windows.Forms.Panel panel13;
    }
}