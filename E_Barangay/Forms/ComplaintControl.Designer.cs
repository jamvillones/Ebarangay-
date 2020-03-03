using E_Barangay.Class;

namespace E_Barangay.Forms
{
    partial class ComplaintControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pendingBtn = new System.Windows.Forms.Button();
            this.forTodayBtn = new System.Windows.Forms.Button();
            this.overdueBtn = new System.Windows.Forms.Button();
            this.settledBtn = new System.Windows.Forms.Button();
            this.addComplaintBtn = new System.Windows.Forms.Button();
            this.Marker = new System.Windows.Forms.Panel();
            this.dgvRecords = new E_Barangay.Class.CustomDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecords)).BeginInit();
            this.SuspendLayout();
            // 
            // pendingBtn
            // 
            this.pendingBtn.BackColor = System.Drawing.Color.LightGray;
            this.pendingBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.pendingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pendingBtn.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pendingBtn.ForeColor = System.Drawing.Color.Black;
            this.pendingBtn.Location = new System.Drawing.Point(206, 8);
            this.pendingBtn.Name = "pendingBtn";
            this.pendingBtn.Size = new System.Drawing.Size(66, 30);
            this.pendingBtn.TabIndex = 5;
            this.pendingBtn.Text = "Pending";
            this.pendingBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.pendingBtn.UseVisualStyleBackColor = false;
            this.pendingBtn.Click += new System.EventHandler(this.pendingBtn_Click);
            // 
            // forTodayBtn
            // 
            this.forTodayBtn.BackColor = System.Drawing.Color.LightGray;
            this.forTodayBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.forTodayBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.forTodayBtn.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forTodayBtn.ForeColor = System.Drawing.Color.Black;
            this.forTodayBtn.Location = new System.Drawing.Point(74, 8);
            this.forTodayBtn.Name = "forTodayBtn";
            this.forTodayBtn.Size = new System.Drawing.Size(66, 30);
            this.forTodayBtn.TabIndex = 3;
            this.forTodayBtn.Text = "For Today";
            this.forTodayBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.forTodayBtn.UseVisualStyleBackColor = false;
            this.forTodayBtn.Click += new System.EventHandler(this.forTodayBtn_Click);
            // 
            // overdueBtn
            // 
            this.overdueBtn.BackColor = System.Drawing.Color.LightGray;
            this.overdueBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.overdueBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.overdueBtn.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overdueBtn.ForeColor = System.Drawing.Color.Black;
            this.overdueBtn.Location = new System.Drawing.Point(140, 8);
            this.overdueBtn.Name = "overdueBtn";
            this.overdueBtn.Size = new System.Drawing.Size(66, 30);
            this.overdueBtn.TabIndex = 4;
            this.overdueBtn.Text = "Overdue";
            this.overdueBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.overdueBtn.UseVisualStyleBackColor = false;
            this.overdueBtn.Click += new System.EventHandler(this.overdueBtn_Click);
            // 
            // settledBtn
            // 
            this.settledBtn.BackColor = System.Drawing.Color.LightGray;
            this.settledBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.settledBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settledBtn.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settledBtn.ForeColor = System.Drawing.Color.Black;
            this.settledBtn.Location = new System.Drawing.Point(272, 8);
            this.settledBtn.Name = "settledBtn";
            this.settledBtn.Size = new System.Drawing.Size(66, 30);
            this.settledBtn.TabIndex = 6;
            this.settledBtn.Text = "Settled";
            this.settledBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.settledBtn.UseVisualStyleBackColor = false;
            this.settledBtn.Click += new System.EventHandler(this.settledBtn_Click);
            // 
            // addComplaintBtn
            // 
            this.addComplaintBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addComplaintBtn.BackColor = System.Drawing.Color.LightGray;
            this.addComplaintBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.addComplaintBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addComplaintBtn.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addComplaintBtn.ForeColor = System.Drawing.Color.Black;
            this.addComplaintBtn.Location = new System.Drawing.Point(708, 8);
            this.addComplaintBtn.Name = "addComplaintBtn";
            this.addComplaintBtn.Size = new System.Drawing.Size(120, 30);
            this.addComplaintBtn.TabIndex = 7;
            this.addComplaintBtn.Text = "Add Complaint";
            this.addComplaintBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addComplaintBtn.UseVisualStyleBackColor = false;
            this.addComplaintBtn.Click += new System.EventHandler(this.addComplaintBtn_Click);
            // 
            // Marker
            // 
            this.Marker.BackColor = System.Drawing.Color.Black;
            this.Marker.Location = new System.Drawing.Point(8, 33);
            this.Marker.Name = "Marker";
            this.Marker.Size = new System.Drawing.Size(66, 5);
            this.Marker.TabIndex = 8;
            // 
            // dgvRecords
            // 
            this.dgvRecords.AllowUserToAddRows = false;
            this.dgvRecords.AllowUserToDeleteRows = false;
            this.dgvRecords.AllowUserToResizeColumns = false;
            this.dgvRecords.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvRecords.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvRecords.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRecords.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dgvRecords.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRecords.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvRecords.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRecords.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column4,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRecords.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvRecords.EnableHeadersVisualStyles = false;
            this.dgvRecords.GridColor = System.Drawing.Color.White;
            this.dgvRecords.Location = new System.Drawing.Point(8, 49);
            this.dgvRecords.MultiSelect = false;
            this.dgvRecords.Name = "dgvRecords";
            this.dgvRecords.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRecords.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvRecords.RowHeadersVisible = false;
            this.dgvRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecords.Size = new System.Drawing.Size(820, 445);
            this.dgvRecords.StandardTab = true;
            this.dgvRecords.TabIndex = 2;
            this.dgvRecords.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRecords_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "Control Number";
            this.Column1.MinimumWidth = 200;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.Width = 200;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column4.HeaderText = "Status";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.HeaderText = "Settlement Date";
            this.Column2.MinimumWidth = 200;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Date Happened";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // allBtn
            // 
            this.allBtn.BackColor = System.Drawing.Color.LightGray;
            this.allBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.allBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.allBtn.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allBtn.ForeColor = System.Drawing.Color.Black;
            this.allBtn.Location = new System.Drawing.Point(8, 8);
            this.allBtn.Name = "allBtn";
            this.allBtn.Size = new System.Drawing.Size(66, 30);
            this.allBtn.TabIndex = 9;
            this.allBtn.Text = "All";
            this.allBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.allBtn.UseVisualStyleBackColor = false;
            this.allBtn.Click += new System.EventHandler(this.allBtn_Click);
            // 
            // ComplaintControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Controls.Add(this.Marker);
            this.Controls.Add(this.allBtn);
            this.Controls.Add(this.addComplaintBtn);
            this.Controls.Add(this.settledBtn);
            this.Controls.Add(this.pendingBtn);
            this.Controls.Add(this.forTodayBtn);
            this.Controls.Add(this.dgvRecords);
            this.Controls.Add(this.overdueBtn);
            this.Name = "ComplaintControl";
            this.Size = new System.Drawing.Size(840, 497);
            this.Load += new System.EventHandler(this.ComplaintControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecords)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button overdueBtn;
        CustomDataGridView dgvRecords;
        //private System.Windows.Forms.DataGridView DataTable;
        private System.Windows.Forms.Button forTodayBtn;
        private System.Windows.Forms.Button pendingBtn;
        private System.Windows.Forms.Button settledBtn;
        private System.Windows.Forms.Button addComplaintBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Panel Marker;
        private System.Windows.Forms.Button allBtn;
    }
}
