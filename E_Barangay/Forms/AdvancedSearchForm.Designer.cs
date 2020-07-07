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
            this.isStudent = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.isPwd = new System.Windows.Forms.CheckBox();
            this.isSeniorCitizen = new System.Windows.Forms.CheckBox();
            this.isIndigent = new System.Windows.Forms.CheckBox();
            this.areaOptions = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sexOption = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.civilStatusOption = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.DataTable.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.DataTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DataTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
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
            this.DataTable.Location = new System.Drawing.Point(12, 118);
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
            this.DataTable.Size = new System.Drawing.Size(776, 320);
            this.DataTable.StandardTab = true;
            this.DataTable.TabIndex = 3;
            // 
            // isStudent
            // 
            this.isStudent.AutoSize = true;
            this.isStudent.Location = new System.Drawing.Point(3, 3);
            this.isStudent.Name = "isStudent";
            this.isStudent.Size = new System.Drawing.Size(63, 17);
            this.isStudent.TabIndex = 4;
            this.isStudent.Text = "Student";
            this.isStudent.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.isIndigent);
            this.panel1.Controls.Add(this.isSeniorCitizen);
            this.panel1.Controls.Add(this.isPwd);
            this.panel1.Controls.Add(this.isStudent);
            this.panel1.Location = new System.Drawing.Point(219, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(95, 100);
            this.panel1.TabIndex = 5;
            // 
            // isPwd
            // 
            this.isPwd.AutoSize = true;
            this.isPwd.Location = new System.Drawing.Point(3, 26);
            this.isPwd.Name = "isPwd";
            this.isPwd.Size = new System.Drawing.Size(52, 17);
            this.isPwd.TabIndex = 5;
            this.isPwd.Text = "PWD";
            this.isPwd.UseVisualStyleBackColor = true;
            // 
            // isSeniorCitizen
            // 
            this.isSeniorCitizen.AutoSize = true;
            this.isSeniorCitizen.Location = new System.Drawing.Point(3, 49);
            this.isSeniorCitizen.Name = "isSeniorCitizen";
            this.isSeniorCitizen.Size = new System.Drawing.Size(90, 17);
            this.isSeniorCitizen.TabIndex = 6;
            this.isSeniorCitizen.Text = "Senior Citizen";
            this.isSeniorCitizen.UseVisualStyleBackColor = true;
            // 
            // isIndigent
            // 
            this.isIndigent.AutoSize = true;
            this.isIndigent.Location = new System.Drawing.Point(3, 72);
            this.isIndigent.Name = "isIndigent";
            this.isIndigent.Size = new System.Drawing.Size(64, 17);
            this.isIndigent.TabIndex = 7;
            this.isIndigent.Text = "Indigent";
            this.isIndigent.UseVisualStyleBackColor = true;
            // 
            // areaOptions
            // 
            this.areaOptions.FormattingEnabled = true;
            this.areaOptions.Location = new System.Drawing.Point(72, 10);
            this.areaOptions.Name = "areaOptions";
            this.areaOptions.Size = new System.Drawing.Size(121, 21);
            this.areaOptions.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Area";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Sex";
            // 
            // sexOption
            // 
            this.sexOption.FormattingEnabled = true;
            this.sexOption.Location = new System.Drawing.Point(72, 37);
            this.sexOption.Name = "sexOption";
            this.sexOption.Size = new System.Drawing.Size(121, 21);
            this.sexOption.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Civil Status";
            // 
            // civilStatusOption
            // 
            this.civilStatusOption.FormattingEnabled = true;
            this.civilStatusOption.Location = new System.Drawing.Point(72, 64);
            this.civilStatusOption.Name = "civilStatusOption";
            this.civilStatusOption.Size = new System.Drawing.Size(121, 21);
            this.civilStatusOption.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.civilStatusOption);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.areaOptions);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.sexOption);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(201, 100);
            this.panel2.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Location = new System.Drawing.Point(320, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(226, 31);
            this.button1.TabIndex = 13;
            this.button1.Text = "Create Comma Separated Value(CSV)";
            this.button1.UseVisualStyleBackColor = true;
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
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2.Location = new System.Drawing.Point(320, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(226, 31);
            this.button2.TabIndex = 14;
            this.button2.Text = "Go";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // AdvancedSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DataTable);
            this.Name = "AdvancedSearchForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Advanced Search";
            this.Load += new System.EventHandler(this.AdvancedSearchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Class.CustomDataGridView DataTable;
        private System.Windows.Forms.CheckBox isStudent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox isIndigent;
        private System.Windows.Forms.CheckBox isSeniorCitizen;
        private System.Windows.Forms.CheckBox isPwd;
        private System.Windows.Forms.ComboBox areaOptions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox sexOption;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox civilStatusOption;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button button2;
    }
}