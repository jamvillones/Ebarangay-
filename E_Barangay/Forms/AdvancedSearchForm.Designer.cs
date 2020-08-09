namespace E_Barangay.Forms
{
    partial class AdvancedSearchForm
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
            this.DataTable = new E_Barangay.Class.CustomDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isStudent = new System.Windows.Forms.CheckBox();
            this.isIndigent = new System.Windows.Forms.CheckBox();
            this.isSeniorCitizen = new System.Windows.Forms.CheckBox();
            this.isPwd = new System.Windows.Forms.CheckBox();
            this.areaOptions = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sexOption = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.civilStatusOption = new System.Windows.Forms.ComboBox();
            this.createCSVBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.isVoter = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataTable
            // 
            this.DataTable.AllowUserToAddRows = false;
            this.DataTable.AllowUserToDeleteRows = false;
            this.DataTable.AllowUserToResizeColumns = false;
            this.DataTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DataTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DataTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataTable.EnableHeadersVisualStyles = false;
            this.DataTable.GridColor = System.Drawing.Color.White;
            this.DataTable.Location = new System.Drawing.Point(12, 117);
            this.DataTable.MultiSelect = false;
            this.DataTable.Name = "DataTable";
            this.DataTable.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DataTable.RowHeadersVisible = false;
            this.DataTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataTable.Size = new System.Drawing.Size(776, 345);
            this.DataTable.StandardTab = true;
            this.DataTable.TabIndex = 3;
            this.DataTable.TabStop = false;
            this.DataTable.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataTable_CellMouseDoubleClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 200;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Name";
            this.Column2.MinimumWidth = 200;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // isStudent
            // 
            this.isStudent.AutoSize = true;
            this.isStudent.Location = new System.Drawing.Point(204, 15);
            this.isStudent.Name = "isStudent";
            this.isStudent.Size = new System.Drawing.Size(63, 17);
            this.isStudent.TabIndex = 4;
            this.isStudent.Text = "Student";
            this.isStudent.UseVisualStyleBackColor = true;
            // 
            // isIndigent
            // 
            this.isIndigent.AutoSize = true;
            this.isIndigent.Location = new System.Drawing.Point(308, 15);
            this.isIndigent.Name = "isIndigent";
            this.isIndigent.Size = new System.Drawing.Size(64, 17);
            this.isIndigent.TabIndex = 7;
            this.isIndigent.Text = "Indigent";
            this.isIndigent.UseVisualStyleBackColor = true;
            // 
            // isSeniorCitizen
            // 
            this.isSeniorCitizen.AutoSize = true;
            this.isSeniorCitizen.Location = new System.Drawing.Point(204, 69);
            this.isSeniorCitizen.Name = "isSeniorCitizen";
            this.isSeniorCitizen.Size = new System.Drawing.Size(90, 17);
            this.isSeniorCitizen.TabIndex = 6;
            this.isSeniorCitizen.Text = "Senior Citizen";
            this.isSeniorCitizen.UseVisualStyleBackColor = true;
            // 
            // isPwd
            // 
            this.isPwd.AutoSize = true;
            this.isPwd.Location = new System.Drawing.Point(204, 42);
            this.isPwd.Name = "isPwd";
            this.isPwd.Size = new System.Drawing.Size(52, 17);
            this.isPwd.TabIndex = 5;
            this.isPwd.Text = "PWD";
            this.isPwd.UseVisualStyleBackColor = true;
            // 
            // areaOptions
            // 
            this.areaOptions.FormattingEnabled = true;
            this.areaOptions.Location = new System.Drawing.Point(77, 13);
            this.areaOptions.Name = "areaOptions";
            this.areaOptions.Size = new System.Drawing.Size(121, 21);
            this.areaOptions.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Area";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Sex";
            // 
            // sexOption
            // 
            this.sexOption.FormattingEnabled = true;
            this.sexOption.Location = new System.Drawing.Point(77, 40);
            this.sexOption.Name = "sexOption";
            this.sexOption.Size = new System.Drawing.Size(121, 21);
            this.sexOption.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Civil Status";
            // 
            // civilStatusOption
            // 
            this.civilStatusOption.FormattingEnabled = true;
            this.civilStatusOption.Location = new System.Drawing.Point(77, 67);
            this.civilStatusOption.Name = "civilStatusOption";
            this.civilStatusOption.Size = new System.Drawing.Size(121, 21);
            this.civilStatusOption.TabIndex = 3;
            // 
            // createCSVBtn
            // 
            this.createCSVBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.createCSVBtn.Location = new System.Drawing.Point(588, 49);
            this.createCSVBtn.Name = "createCSVBtn";
            this.createCSVBtn.Size = new System.Drawing.Size(199, 31);
            this.createCSVBtn.TabIndex = 13;
            this.createCSVBtn.TabStop = false;
            this.createCSVBtn.Text = "Create Comma Separated Value(CSV)";
            this.createCSVBtn.UseVisualStyleBackColor = true;
            this.createCSVBtn.Visible = false;
            // 
            // searchBtn
            // 
            this.searchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBtn.Location = new System.Drawing.Point(588, 12);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(199, 31);
            this.searchBtn.TabIndex = 14;
            this.searchBtn.TabStop = false;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.isVoter);
            this.groupBox1.Controls.Add(this.isIndigent);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.civilStatusOption);
            this.groupBox1.Controls.Add(this.sexOption);
            this.groupBox1.Controls.Add(this.isSeniorCitizen);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.isStudent);
            this.groupBox1.Controls.Add(this.isPwd);
            this.groupBox1.Controls.Add(this.areaOptions);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(570, 99);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // isVoter
            // 
            this.isVoter.AutoSize = true;
            this.isVoter.Location = new System.Drawing.Point(308, 42);
            this.isVoter.Name = "isVoter";
            this.isVoter.Size = new System.Drawing.Size(56, 17);
            this.isVoter.TabIndex = 8;
            this.isVoter.Text = "Voters";
            this.isVoter.UseVisualStyleBackColor = true;
            // 
            // AdvancedSearchForm
            // 
            this.AcceptButton = this.searchBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 474);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.createCSVBtn);
            this.Controls.Add(this.DataTable);
            this.Name = "AdvancedSearchForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Advanced Search";
            this.Load += new System.EventHandler(this.AdvancedSearchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Class.CustomDataGridView DataTable;
        private System.Windows.Forms.CheckBox isStudent;
        private System.Windows.Forms.CheckBox isIndigent;
        private System.Windows.Forms.CheckBox isSeniorCitizen;
        private System.Windows.Forms.CheckBox isPwd;
        private System.Windows.Forms.ComboBox areaOptions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox sexOption;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox civilStatusOption;
        private System.Windows.Forms.Button createCSVBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox isVoter;
    }
}