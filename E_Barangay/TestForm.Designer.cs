namespace E_Barangay
{
    partial class TestForm
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
            E_Barangay.Forms.IssuePage issuePage1;
            issuePage1 = new E_Barangay.Forms.IssuePage();
            this.SuspendLayout();
            // 
            // issuePage1
            // 
            issuePage1.BackColor = System.Drawing.Color.White;
            issuePage1.Dock = System.Windows.Forms.DockStyle.Fill;
            issuePage1.Location = new System.Drawing.Point(0, 0);
            issuePage1.Name = "issuePage1";
            issuePage1.Size = new System.Drawing.Size(784, 505);
            issuePage1.TabIndex = 0;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 505);
            this.Controls.Add(issuePage1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TestForm";
            this.ResumeLayout(false);

        }

        #endregion
    }
}