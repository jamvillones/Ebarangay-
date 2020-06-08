namespace E_Barangay.Forms
{
    partial class Test
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Test));
            this.sourceImage = new System.Windows.Forms.PictureBox();
            this.resImage = new System.Windows.Forms.PictureBox();
            this.cropBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sourceImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resImage)).BeginInit();
            this.SuspendLayout();
            // 
            // sourceImage
            // 
            this.sourceImage.Image = ((System.Drawing.Image)(resources.GetObject("sourceImage.Image")));
            this.sourceImage.Location = new System.Drawing.Point(12, 120);
            this.sourceImage.Name = "sourceImage";
            this.sourceImage.Size = new System.Drawing.Size(387, 389);
            this.sourceImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sourceImage.TabIndex = 0;
            this.sourceImage.TabStop = false;
            // 
            // resImage
            // 
            this.resImage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.resImage.Location = new System.Drawing.Point(405, 120);
            this.resImage.Name = "resImage";
            this.resImage.Size = new System.Drawing.Size(383, 389);
            this.resImage.TabIndex = 1;
            this.resImage.TabStop = false;
            // 
            // cropBtn
            // 
            this.cropBtn.Location = new System.Drawing.Point(75, 30);
            this.cropBtn.Name = "cropBtn";
            this.cropBtn.Size = new System.Drawing.Size(200, 23);
            this.cropBtn.TabIndex = 2;
            this.cropBtn.Text = "Crop";
            this.cropBtn.UseVisualStyleBackColor = true;
            this.cropBtn.Click += new System.EventHandler(this.cropBtn_Click);
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 521);
            this.Controls.Add(this.cropBtn);
            this.Controls.Add(this.resImage);
            this.Controls.Add(this.sourceImage);
            this.Name = "Test";
            this.Text = "Test";
            ((System.ComponentModel.ISupportInitialize)(this.sourceImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox sourceImage;
        private System.Windows.Forms.PictureBox resImage;
        private System.Windows.Forms.Button cropBtn;
    }
}