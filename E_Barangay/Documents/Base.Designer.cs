namespace E_Barangay.Documents
{
    partial class Base
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
            this.FieldsPanel = new System.Windows.Forms.Panel();
            this.printing = new E_Barangay.Forms.Printing();
            this.SuspendLayout();
            // 
            // FieldsPanel
            // 
            this.FieldsPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.FieldsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FieldsPanel.Location = new System.Drawing.Point(0, 0);
            this.FieldsPanel.Name = "FieldsPanel";
            this.FieldsPanel.Size = new System.Drawing.Size(356, 694);
            this.FieldsPanel.TabIndex = 0;
            // 
            // printing
            // 
            this.printing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.printing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.printing.Dock = System.Windows.Forms.DockStyle.Right;
            this.printing.Location = new System.Drawing.Point(356, 0);
            this.printing.Name = "printing";
            this.printing.Size = new System.Drawing.Size(562, 694);
            this.printing.TabIndex = 0;
            this.printing.TabStop = false;
            // 
            // Base
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 694);
            this.Controls.Add(this.FieldsPanel);
            this.Controls.Add(this.printing);
            this.KeyPreview = true;
            this.Name = "Base";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Base";
            this.Load += new System.EventHandler(this.goLoad);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keydown_Callback);
            this.ResumeLayout(false);

        }

        #endregion
        private Forms.Printing printing;
        public System.Windows.Forms.Panel FieldsPanel;
    }
}