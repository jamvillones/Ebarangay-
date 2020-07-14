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
            this.FieldsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FieldsPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.FieldsPanel.Location = new System.Drawing.Point(0, 0);
            this.FieldsPanel.Name = "FieldsPanel";
            this.FieldsPanel.Size = new System.Drawing.Size(352, 690);
            this.FieldsPanel.TabIndex = 0;
            // 
            // printing
            // 
            this.printing.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.printing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.printing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.printing.Location = new System.Drawing.Point(352, 0);
            this.printing.Name = "printing";
            this.printing.Size = new System.Drawing.Size(562, 690);
            this.printing.TabIndex = 0;
            this.printing.TabStop = false;
            // 
            // Base
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 690);
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
        protected System.Windows.Forms.Panel FieldsPanel;
        private Forms.Printing printing;
    }
}