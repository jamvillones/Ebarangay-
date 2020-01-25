namespace E_Barangay.Forms
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SelectionPanel = new System.Windows.Forms.Panel();
            this.DashBtn = new System.Windows.Forms.Button();
            this.QueryBtn = new System.Windows.Forms.Button();
            this.IssueBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DashControl = new E_Barangay.Forms.Dashboard();
            this.QueryPage = new E_Barangay.Forms.QueryControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AddNewLoginBtn = new System.Windows.Forms.Button();
            this.UserWelcomeTxt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.printingFiles = new E_Barangay.Forms.PrintingDocument();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.SelectionPanel);
            this.panel1.Controls.Add(this.DashBtn);
            this.panel1.Controls.Add(this.QueryBtn);
            this.panel1.Controls.Add(this.IssueBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(168, 597);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel5.Location = new System.Drawing.Point(9, 104);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(150, 3);
            this.panel5.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(168, 97);
            this.panel4.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(40, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // SelectionPanel
            // 
            this.SelectionPanel.BackColor = System.Drawing.Color.White;
            this.SelectionPanel.Location = new System.Drawing.Point(0, 195);
            this.SelectionPanel.Name = "SelectionPanel";
            this.SelectionPanel.Size = new System.Drawing.Size(5, 34);
            this.SelectionPanel.TabIndex = 2;
            this.SelectionPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.SelectionPanel_Paint);
            // 
            // DashBtn
            // 
            this.DashBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DashBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.DashBtn.FlatAppearance.BorderSize = 0;
            this.DashBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DashBtn.Font = new System.Drawing.Font("Bebas Neue Regular", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashBtn.ForeColor = System.Drawing.Color.White;
            this.DashBtn.Image = ((System.Drawing.Image)(resources.GetObject("DashBtn.Image")));
            this.DashBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DashBtn.Location = new System.Drawing.Point(3, 195);
            this.DashBtn.Name = "DashBtn";
            this.DashBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DashBtn.Size = new System.Drawing.Size(165, 34);
            this.DashBtn.TabIndex = 3;
            this.DashBtn.TabStop = false;
            this.DashBtn.Text = "Home";
            this.DashBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DashBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DashBtn.UseVisualStyleBackColor = true;
            this.DashBtn.Click += new System.EventHandler(this.DashBtn_Click);
            // 
            // QueryBtn
            // 
            this.QueryBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.QueryBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.QueryBtn.FlatAppearance.BorderSize = 0;
            this.QueryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QueryBtn.Font = new System.Drawing.Font("Bebas Neue Regular", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QueryBtn.ForeColor = System.Drawing.Color.White;
            this.QueryBtn.Image = ((System.Drawing.Image)(resources.GetObject("QueryBtn.Image")));
            this.QueryBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.QueryBtn.Location = new System.Drawing.Point(3, 229);
            this.QueryBtn.Name = "QueryBtn";
            this.QueryBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.QueryBtn.Size = new System.Drawing.Size(165, 34);
            this.QueryBtn.TabIndex = 1;
            this.QueryBtn.TabStop = false;
            this.QueryBtn.Text = "Records";
            this.QueryBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.QueryBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.QueryBtn.UseVisualStyleBackColor = true;
            this.QueryBtn.Click += new System.EventHandler(this.QueryBtn_Click);
            // 
            // IssueBtn
            // 
            this.IssueBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.IssueBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.IssueBtn.FlatAppearance.BorderSize = 0;
            this.IssueBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IssueBtn.Font = new System.Drawing.Font("Bebas Neue Regular", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IssueBtn.ForeColor = System.Drawing.Color.White;
            this.IssueBtn.Image = ((System.Drawing.Image)(resources.GetObject("IssueBtn.Image")));
            this.IssueBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IssueBtn.Location = new System.Drawing.Point(3, 263);
            this.IssueBtn.Name = "IssueBtn";
            this.IssueBtn.Size = new System.Drawing.Size(165, 34);
            this.IssueBtn.TabIndex = 4;
            this.IssueBtn.TabStop = false;
            this.IssueBtn.Text = "Issue Document";
            this.IssueBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IssueBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IssueBtn.UseVisualStyleBackColor = true;
            this.IssueBtn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.DashControl);
            this.panel3.Controls.Add(this.QueryPage);
            this.panel3.Controls.Add(this.printingFiles);
            this.panel3.Location = new System.Drawing.Point(168, 37);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(813, 548);
            this.panel3.TabIndex = 3;
            // 
            // DashControl
            // 
            this.DashControl.BackColor = System.Drawing.Color.Silver;
            this.DashControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DashControl.Location = new System.Drawing.Point(0, 0);
            this.DashControl.Name = "DashControl";
            this.DashControl.Size = new System.Drawing.Size(813, 548);
            this.DashControl.TabIndex = 3;
            this.DashControl.TabStop = false;
            // 
            // QueryPage
            // 
            this.QueryPage.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.QueryPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QueryPage.Location = new System.Drawing.Point(0, 0);
            this.QueryPage.Name = "QueryPage";
            this.QueryPage.Size = new System.Drawing.Size(813, 548);
            this.QueryPage.TabIndex = 0;
            this.QueryPage.Load += new System.EventHandler(this.QueryPage_Load);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Controls.Add(this.AddNewLoginBtn);
            this.panel2.Controls.Add(this.UserWelcomeTxt);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(168, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(825, 38);
            this.panel2.TabIndex = 4;
            // 
            // AddNewLoginBtn
            // 
            this.AddNewLoginBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddNewLoginBtn.FlatAppearance.BorderSize = 0;
            this.AddNewLoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNewLoginBtn.Font = new System.Drawing.Font("Bebas Neue Regular", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewLoginBtn.ForeColor = System.Drawing.Color.White;
            this.AddNewLoginBtn.Image = ((System.Drawing.Image)(resources.GetObject("AddNewLoginBtn.Image")));
            this.AddNewLoginBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddNewLoginBtn.Location = new System.Drawing.Point(733, 8);
            this.AddNewLoginBtn.Name = "AddNewLoginBtn";
            this.AddNewLoginBtn.Size = new System.Drawing.Size(80, 23);
            this.AddNewLoginBtn.TabIndex = 3;
            this.AddNewLoginBtn.Text = "ADD NEW LOGIN";
            this.AddNewLoginBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddNewLoginBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddNewLoginBtn.UseVisualStyleBackColor = true;
            this.AddNewLoginBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // UserWelcomeTxt
            // 
            this.UserWelcomeTxt.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserWelcomeTxt.ForeColor = System.Drawing.Color.White;
            this.UserWelcomeTxt.Location = new System.Drawing.Point(235, 8);
            this.UserWelcomeTxt.Name = "UserWelcomeTxt";
            this.UserWelcomeTxt.Size = new System.Drawing.Size(215, 23);
            this.UserWelcomeTxt.TabIndex = 2;
            this.UserWelcomeTxt.Text = "Welcome:";
            this.UserWelcomeTxt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Bebas Neue Regular", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(43, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "E Barangay";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(6, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // printingFiles
            // 
            this.printingFiles.BackColor = System.Drawing.Color.DarkCyan;
            this.printingFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.printingFiles.Location = new System.Drawing.Point(0, 0);
            this.printingFiles.Name = "printingFiles";
            this.printingFiles.Size = new System.Drawing.Size(813, 548);
            this.printingFiles.TabIndex = 4;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(993, 597);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(900, 536);
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "E Barangay";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button QueryBtn;
        private System.Windows.Forms.Panel panel3;
        private QueryControl QueryPage;
        private System.Windows.Forms.Panel SelectionPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private Dashboard DashControl;
        private System.Windows.Forms.Button DashBtn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button IssueBtn;
        private System.Windows.Forms.Label UserWelcomeTxt;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button AddNewLoginBtn;
        private System.Windows.Forms.Panel panel5;
        private PrintingDocument printingFiles;
    }
}