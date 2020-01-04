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
            this.button1 = new System.Windows.Forms.Button();
            this.SelectionPanel = new System.Windows.Forms.Panel();
            this.DashBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.QueryBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.MaximizeBtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.UserWelcomeTxt = new System.Windows.Forms.Label();
            this.DashControl = new E_Barangay.Forms.Dashboard();
            this.QueryPage = new E_Barangay.Forms.QueryControl();
            this.RegisterPage = new E_Barangay.Forms.RegisterControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.SelectionPanel);
            this.panel1.Controls.Add(this.DashBtn);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.RegisterBtn);
            this.panel1.Controls.Add(this.QueryBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(168, 597);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bebas Neue Regular", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(3, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 34);
            this.button1.TabIndex = 4;
            this.button1.TabStop = false;
            this.button1.Text = "Issue Document";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
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
            this.DashBtn.Text = "statistics";
            this.DashBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DashBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DashBtn.UseVisualStyleBackColor = true;
            this.DashBtn.Click += new System.EventHandler(this.DashBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RegisterBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.RegisterBtn.FlatAppearance.BorderSize = 0;
            this.RegisterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterBtn.Font = new System.Drawing.Font("Bebas Neue Regular", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterBtn.ForeColor = System.Drawing.Color.White;
            this.RegisterBtn.Image = ((System.Drawing.Image)(resources.GetObject("RegisterBtn.Image")));
            this.RegisterBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RegisterBtn.Location = new System.Drawing.Point(3, 263);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(165, 34);
            this.RegisterBtn.TabIndex = 2;
            this.RegisterBtn.TabStop = false;
            this.RegisterBtn.Text = "REGISTER";
            this.RegisterBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RegisterBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.RegisterBtn.UseVisualStyleBackColor = true;
            this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
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
            this.QueryBtn.Text = "QUERY";
            this.QueryBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.QueryBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.QueryBtn.UseVisualStyleBackColor = true;
            this.QueryBtn.Click += new System.EventHandler(this.QueryBtn_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.DashControl);
            this.panel3.Controls.Add(this.QueryPage);
            this.panel3.Controls.Add(this.RegisterPage);
            this.panel3.Location = new System.Drawing.Point(168, 37);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(813, 548);
            this.panel3.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.UserWelcomeTxt);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.MaximizeBtn);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.ExitBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(168, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(825, 38);
            this.panel2.TabIndex = 4;
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
            // MaximizeBtn
            // 
            this.MaximizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaximizeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MaximizeBtn.FlatAppearance.BorderSize = 0;
            this.MaximizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaximizeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBtn.ForeColor = System.Drawing.Color.White;
            this.MaximizeBtn.Image = ((System.Drawing.Image)(resources.GetObject("MaximizeBtn.Image")));
            this.MaximizeBtn.Location = new System.Drawing.Point(760, 3);
            this.MaximizeBtn.Name = "MaximizeBtn";
            this.MaximizeBtn.Size = new System.Drawing.Size(28, 28);
            this.MaximizeBtn.TabIndex = 1;
            this.MaximizeBtn.TabStop = false;
            this.MaximizeBtn.UseVisualStyleBackColor = false;
            this.MaximizeBtn.Click += new System.EventHandler(this.MaximizeBtn_Click);
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
            // ExitBtn
            // 
            this.ExitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ExitBtn.FlatAppearance.BorderSize = 0;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.ForeColor = System.Drawing.Color.White;
            this.ExitBtn.Image = ((System.Drawing.Image)(resources.GetObject("ExitBtn.Image")));
            this.ExitBtn.Location = new System.Drawing.Point(794, 3);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(28, 28);
            this.ExitBtn.TabIndex = 0;
            this.ExitBtn.TabStop = false;
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserWelcomeTxt
            // 
            this.UserWelcomeTxt.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserWelcomeTxt.ForeColor = System.Drawing.Color.White;
            this.UserWelcomeTxt.Location = new System.Drawing.Point(235, 8);
            this.UserWelcomeTxt.Name = "UserWelcomeTxt";
            this.UserWelcomeTxt.Size = new System.Drawing.Size(355, 23);
            this.UserWelcomeTxt.TabIndex = 2;
            this.UserWelcomeTxt.Text = "Welcome:";
            this.UserWelcomeTxt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DashControl
            // 
            this.DashControl.BackColor = System.Drawing.SystemColors.ControlLight;
            this.DashControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DashControl.Location = new System.Drawing.Point(0, 0);
            this.DashControl.Name = "DashControl";
            this.DashControl.Size = new System.Drawing.Size(813, 548);
            this.DashControl.TabIndex = 3;
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
            // RegisterPage
            // 
            this.RegisterPage.BackColor = System.Drawing.Color.Silver;
            this.RegisterPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RegisterPage.Enabled = false;
            this.RegisterPage.Location = new System.Drawing.Point(0, 0);
            this.RegisterPage.Name = "RegisterPage";
            this.RegisterPage.Size = new System.Drawing.Size(813, 548);
            this.RegisterPage.TabIndex = 1;
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(900, 536);
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "E Barangay";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button RegisterBtn;
        private System.Windows.Forms.Button QueryBtn;
        private System.Windows.Forms.Panel panel3;
        private QueryControl QueryPage;
        private RegisterControl RegisterPage;
        private System.Windows.Forms.Panel SelectionPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button MaximizeBtn;
        private Dashboard DashControl;
        private System.Windows.Forms.Button DashBtn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label UserWelcomeTxt;
    }
}