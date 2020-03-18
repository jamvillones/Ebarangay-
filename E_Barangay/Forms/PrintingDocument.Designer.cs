namespace E_Barangay.Forms
{
    partial class PrintingDocument
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.DocumentList = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.docName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createCustBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DocumentList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bebas Neue Regular", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please choose a Document";
            // 
            // DocumentList
            // 
            this.DocumentList.AllowUserToAddRows = false;
            this.DocumentList.AllowUserToDeleteRows = false;
            this.DocumentList.AllowUserToOrderColumns = true;
            this.DocumentList.AllowUserToResizeColumns = false;
            this.DocumentList.AllowUserToResizeRows = false;
            this.DocumentList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DocumentList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Bebas Neue Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DocumentList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DocumentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DocumentList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.docName});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DocumentList.DefaultCellStyle = dataGridViewCellStyle9;
            this.DocumentList.EnableHeadersVisualStyles = false;
            this.DocumentList.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.DocumentList.Location = new System.Drawing.Point(15, 48);
            this.DocumentList.MultiSelect = false;
            this.DocumentList.Name = "DocumentList";
            this.DocumentList.ReadOnly = true;
            this.DocumentList.RowHeadersVisible = false;
            this.DocumentList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DocumentList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DocumentList.Size = new System.Drawing.Size(722, 323);
            this.DocumentList.StandardTab = true;
            this.DocumentList.TabIndex = 2;
            this.DocumentList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DocumentList_CellContentClick);
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.DividerWidth = 1;
            this.Column2.HeaderText = "Actions";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 55;
            // 
            // docName
            // 
            this.docName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            this.docName.DefaultCellStyle = dataGridViewCellStyle8;
            this.docName.HeaderText = "Document Name";
            this.docName.Name = "docName";
            this.docName.ReadOnly = true;
            // 
            // createCustBtn
            // 
            this.createCustBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.createCustBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.createCustBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.createCustBtn.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createCustBtn.Location = new System.Drawing.Point(578, 19);
            this.createCustBtn.Name = "createCustBtn";
            this.createCustBtn.Size = new System.Drawing.Size(159, 23);
            this.createCustBtn.TabIndex = 3;
            this.createCustBtn.Text = "Create Custom Document";
            this.createCustBtn.UseVisualStyleBackColor = false;
            this.createCustBtn.Click += new System.EventHandler(this.createCustBtn_Click);
            // 
            // PrintingDocument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Controls.Add(this.createCustBtn);
            this.Controls.Add(this.DocumentList);
            this.Controls.Add(this.label1);
            this.Name = "PrintingDocument";
            this.Size = new System.Drawing.Size(749, 386);
            this.Load += new System.EventHandler(this.PrintingDocument_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DocumentList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DocumentList;
        private System.Windows.Forms.DataGridViewButtonColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn docName;
        private System.Windows.Forms.Button createCustBtn;
    }
}
