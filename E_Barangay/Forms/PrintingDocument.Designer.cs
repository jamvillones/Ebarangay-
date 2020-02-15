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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.BClearanceBtn = new System.Windows.Forms.Button();
            this.BussClearanceBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.deathCertBtn = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.flowLayoutPanel1.Controls.Add(this.BClearanceBtn);
            this.flowLayoutPanel1.Controls.Add(this.BussClearanceBtn);
            this.flowLayoutPanel1.Controls.Add(this.deathCertBtn);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 35);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(743, 348);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // BClearanceBtn
            // 
            this.BClearanceBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BClearanceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BClearanceBtn.Font = new System.Drawing.Font("Bebas Neue Regular", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BClearanceBtn.ForeColor = System.Drawing.Color.White;
            this.BClearanceBtn.Location = new System.Drawing.Point(3, 3);
            this.BClearanceBtn.Name = "BClearanceBtn";
            this.BClearanceBtn.Size = new System.Drawing.Size(143, 41);
            this.BClearanceBtn.TabIndex = 0;
            this.BClearanceBtn.TabStop = false;
            this.BClearanceBtn.Text = "Barangay Clearance";
            this.BClearanceBtn.UseVisualStyleBackColor = false;
            this.BClearanceBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // BussClearanceBtn
            // 
            this.BussClearanceBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BussClearanceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BussClearanceBtn.Font = new System.Drawing.Font("Bebas Neue Regular", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BussClearanceBtn.ForeColor = System.Drawing.Color.White;
            this.BussClearanceBtn.Location = new System.Drawing.Point(152, 3);
            this.BussClearanceBtn.Name = "BussClearanceBtn";
            this.BussClearanceBtn.Size = new System.Drawing.Size(143, 41);
            this.BussClearanceBtn.TabIndex = 1;
            this.BussClearanceBtn.TabStop = false;
            this.BussClearanceBtn.Text = "Bussiness Clearance";
            this.BussClearanceBtn.UseVisualStyleBackColor = false;
            this.BussClearanceBtn.Click += new System.EventHandler(this.BussClearanceBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bebas Neue Regular", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please choose a Document";
            // 
            // deathCertBtn
            // 
            this.deathCertBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.deathCertBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deathCertBtn.Font = new System.Drawing.Font("Bebas Neue Regular", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deathCertBtn.ForeColor = System.Drawing.Color.White;
            this.deathCertBtn.Location = new System.Drawing.Point(301, 3);
            this.deathCertBtn.Name = "deathCertBtn";
            this.deathCertBtn.Size = new System.Drawing.Size(143, 41);
            this.deathCertBtn.TabIndex = 2;
            this.deathCertBtn.TabStop = false;
            this.deathCertBtn.Text = "Death Certificate";
            this.deathCertBtn.UseVisualStyleBackColor = false;
            this.deathCertBtn.Click += new System.EventHandler(this.deathCertBtn_Click);
            // 
            // PrintingDocument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Name = "PrintingDocument";
            this.Size = new System.Drawing.Size(749, 386);
            this.Load += new System.EventHandler(this.PrintingDocument_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button BClearanceBtn;
        private System.Windows.Forms.Button BussClearanceBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deathCertBtn;
    }
}
