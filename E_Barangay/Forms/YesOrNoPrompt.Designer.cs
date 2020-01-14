namespace E_Barangay.Forms
{
    partial class YesOrNoPrompt
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
            this.MessageTxt = new System.Windows.Forms.Label();
            this.YesBtn = new System.Windows.Forms.Button();
            this.NoBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MessageTxt
            // 
            this.MessageTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MessageTxt.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageTxt.Location = new System.Drawing.Point(11, 9);
            this.MessageTxt.Name = "MessageTxt";
            this.MessageTxt.Size = new System.Drawing.Size(381, 89);
            this.MessageTxt.TabIndex = 0;
            this.MessageTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // YesBtn
            // 
            this.YesBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.YesBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.YesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.YesBtn.Font = new System.Drawing.Font("Bebas Neue Regular", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YesBtn.Location = new System.Drawing.Point(123, 113);
            this.YesBtn.Name = "YesBtn";
            this.YesBtn.Size = new System.Drawing.Size(75, 23);
            this.YesBtn.TabIndex = 1;
            this.YesBtn.Text = "Yes";
            this.YesBtn.UseVisualStyleBackColor = false;
            this.YesBtn.Click += new System.EventHandler(this.YesBtn_Click);
            // 
            // NoBtn
            // 
            this.NoBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.NoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NoBtn.Font = new System.Drawing.Font("Bebas Neue Regular", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoBtn.Location = new System.Drawing.Point(204, 113);
            this.NoBtn.Name = "NoBtn";
            this.NoBtn.Size = new System.Drawing.Size(75, 23);
            this.NoBtn.TabIndex = 2;
            this.NoBtn.Text = "Cancel";
            this.NoBtn.UseVisualStyleBackColor = true;
            this.NoBtn.Click += new System.EventHandler(this.NoBtn_Click);
            // 
            // YesOrNoPrompt
            // 
            this.AcceptButton = this.YesBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.NoBtn;
            this.ClientSize = new System.Drawing.Size(402, 151);
            this.Controls.Add(this.NoBtn);
            this.Controls.Add(this.YesBtn);
            this.Controls.Add(this.MessageTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "YesOrNoPrompt";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.YesOrNoPrompt_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label MessageTxt;
        private System.Windows.Forms.Button YesBtn;
        private System.Windows.Forms.Button NoBtn;
    }
}