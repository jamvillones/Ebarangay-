using System.Drawing;

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
            this.StatBtn = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SelectionPanel = new System.Windows.Forms.Panel();
            this.DashBtn = new System.Windows.Forms.Button();
            this.QueryBtn = new System.Windows.Forms.Button();
            this.IssueBtn = new System.Windows.Forms.Button();
            this.complaintsBtn = new System.Windows.Forms.Button();
            this.ContentHolder = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.UserWelcomeTxt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.stripPanel = new System.Windows.Forms.Panel();
            this.OptionStrip = new System.Windows.Forms.MenuStrip();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.officialsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DashControl = new E_Barangay.Forms.Dashboard();
            this.QueryPage = new E_Barangay.Forms.QueryControl();
            this.printingFiles = new E_Barangay.Forms.PrintingDocument();
            this.complaintPage = new E_Barangay.Forms.ComplaintControl();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ContentHolder.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.stripPanel.SuspendLayout();
            this.OptionStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.panel1.Controls.Add(this.StatBtn);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.SelectionPanel);
            this.panel1.Controls.Add(this.DashBtn);
            this.panel1.Controls.Add(this.QueryBtn);
            this.panel1.Controls.Add(this.IssueBtn);
            this.panel1.Controls.Add(this.complaintsBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(168, 613);
            this.panel1.TabIndex = 0;
            // 
            // StatBtn
            // 
            this.StatBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.StatBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.StatBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.StatBtn.FlatAppearance.BorderSize = 0;
            this.StatBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StatBtn.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatBtn.ForeColor = System.Drawing.Color.White;
            this.StatBtn.Image = ((System.Drawing.Image)(resources.GetObject("StatBtn.Image")));
            this.StatBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StatBtn.Location = new System.Drawing.Point(9, 557);
            this.StatBtn.Name = "StatBtn";
            this.StatBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StatBtn.Size = new System.Drawing.Size(150, 25);
            this.StatBtn.TabIndex = 8;
            this.StatBtn.TabStop = false;
            this.StatBtn.Text = "STATISTICS [F2]";
            this.StatBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StatBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.StatBtn.UseVisualStyleBackColor = true;
            this.StatBtn.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel6.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel6.Location = new System.Drawing.Point(9, 549);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(150, 3);
            this.panel6.TabIndex = 7;
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
            this.SelectionPanel.Location = new System.Drawing.Point(0, 113);
            this.SelectionPanel.Name = "SelectionPanel";
            this.SelectionPanel.Size = new System.Drawing.Size(5, 34);
            this.SelectionPanel.TabIndex = 2;
            // 
            // DashBtn
            // 
            this.DashBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DashBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.DashBtn.FlatAppearance.BorderSize = 0;
            this.DashBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DashBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashBtn.ForeColor = System.Drawing.Color.White;
            this.DashBtn.Image = ((System.Drawing.Image)(resources.GetObject("DashBtn.Image")));
            this.DashBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DashBtn.Location = new System.Drawing.Point(3, 113);
            this.DashBtn.Name = "DashBtn";
            this.DashBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DashBtn.Size = new System.Drawing.Size(165, 34);
            this.DashBtn.TabIndex = 3;
            this.DashBtn.TabStop = false;
            this.DashBtn.Text = "Home";
            this.DashBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DashBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DashBtn.UseCompatibleTextRendering = true;
            this.DashBtn.UseVisualStyleBackColor = true;
            this.DashBtn.Click += new System.EventHandler(this.DashBtn_Click);
            // 
            // QueryBtn
            // 
            this.QueryBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.QueryBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.QueryBtn.FlatAppearance.BorderSize = 0;
            this.QueryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QueryBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QueryBtn.ForeColor = System.Drawing.Color.White;
            this.QueryBtn.Image = ((System.Drawing.Image)(resources.GetObject("QueryBtn.Image")));
            this.QueryBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.QueryBtn.Location = new System.Drawing.Point(3, 147);
            this.QueryBtn.Name = "QueryBtn";
            this.QueryBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.QueryBtn.Size = new System.Drawing.Size(165, 34);
            this.QueryBtn.TabIndex = 1;
            this.QueryBtn.TabStop = false;
            this.QueryBtn.Text = "Records";
            this.QueryBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.QueryBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.QueryBtn.UseCompatibleTextRendering = true;
            this.QueryBtn.UseVisualStyleBackColor = true;
            this.QueryBtn.Click += new System.EventHandler(this.QueryBtn_Click);
            // 
            // IssueBtn
            // 
            this.IssueBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.IssueBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.IssueBtn.FlatAppearance.BorderSize = 0;
            this.IssueBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IssueBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IssueBtn.ForeColor = System.Drawing.Color.White;
            this.IssueBtn.Image = ((System.Drawing.Image)(resources.GetObject("IssueBtn.Image")));
            this.IssueBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IssueBtn.Location = new System.Drawing.Point(3, 215);
            this.IssueBtn.Name = "IssueBtn";
            this.IssueBtn.Size = new System.Drawing.Size(165, 34);
            this.IssueBtn.TabIndex = 4;
            this.IssueBtn.TabStop = false;
            this.IssueBtn.Text = "Issue Document";
            this.IssueBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IssueBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IssueBtn.UseCompatibleTextRendering = true;
            this.IssueBtn.UseVisualStyleBackColor = true;
            this.IssueBtn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // complaintsBtn
            // 
            this.complaintsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.complaintsBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.complaintsBtn.FlatAppearance.BorderSize = 0;
            this.complaintsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.complaintsBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.complaintsBtn.ForeColor = System.Drawing.Color.White;
            this.complaintsBtn.Image = ((System.Drawing.Image)(resources.GetObject("complaintsBtn.Image")));
            this.complaintsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.complaintsBtn.Location = new System.Drawing.Point(3, 181);
            this.complaintsBtn.Name = "complaintsBtn";
            this.complaintsBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.complaintsBtn.Size = new System.Drawing.Size(165, 34);
            this.complaintsBtn.TabIndex = 10;
            this.complaintsBtn.TabStop = false;
            this.complaintsBtn.Text = "Complaints";
            this.complaintsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.complaintsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.complaintsBtn.UseCompatibleTextRendering = true;
            this.complaintsBtn.UseVisualStyleBackColor = true;
            this.complaintsBtn.Click += new System.EventHandler(this.complaintsBtn_Click);
            // 
            // ContentHolder
            // 
            this.ContentHolder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContentHolder.Controls.Add(this.DashControl);
            this.ContentHolder.Controls.Add(this.QueryPage);
            this.ContentHolder.Controls.Add(this.printingFiles);
            this.ContentHolder.Controls.Add(this.complaintPage);
            this.ContentHolder.Location = new System.Drawing.Point(174, 70);
            this.ContentHolder.Name = "ContentHolder";
            this.ContentHolder.Size = new System.Drawing.Size(995, 538);
            this.ContentHolder.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Controls.Add(this.UserWelcomeTxt);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(168, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1008, 38);
            this.panel2.TabIndex = 4;
            // 
            // UserWelcomeTxt
            // 
            this.UserWelcomeTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UserWelcomeTxt.BackColor = System.Drawing.Color.DarkSlateGray;
            this.UserWelcomeTxt.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserWelcomeTxt.ForeColor = System.Drawing.Color.White;
            this.UserWelcomeTxt.Location = new System.Drawing.Point(781, 7);
            this.UserWelcomeTxt.Name = "UserWelcomeTxt";
            this.UserWelcomeTxt.Size = new System.Drawing.Size(215, 23);
            this.UserWelcomeTxt.TabIndex = 2;
            this.UserWelcomeTxt.Text = "Lerum Ipsum";
            this.UserWelcomeTxt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(43, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "E Barangay";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.UseCompatibleTextRendering = true;
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
            // stripPanel
            // 
            this.stripPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stripPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.stripPanel.Controls.Add(this.OptionStrip);
            this.stripPanel.Location = new System.Drawing.Point(168, 38);
            this.stripPanel.Name = "stripPanel";
            this.stripPanel.Size = new System.Drawing.Size(1008, 26);
            this.stripPanel.TabIndex = 5;
            // 
            // OptionStrip
            // 
            this.OptionStrip.BackColor = System.Drawing.Color.Teal;
            this.OptionStrip.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptionStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripMenuItem,
            this.editToolStripMenuItem});
            this.OptionStrip.Location = new System.Drawing.Point(0, 0);
            this.OptionStrip.Name = "OptionStrip";
            this.OptionStrip.Size = new System.Drawing.Size(1008, 24);
            this.OptionStrip.TabIndex = 0;
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUserToolStripMenuItem,
            this.changePasswordToolStripMenuItem});
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.userToolStripMenuItem.Text = "User";
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.addUserToolStripMenuItem.Text = "Add New Login";
            this.addUserToolStripMenuItem.Click += new System.EventHandler(this.addUserToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.officialsToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // officialsToolStripMenuItem
            // 
            this.officialsToolStripMenuItem.Name = "officialsToolStripMenuItem";
            this.officialsToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.officialsToolStripMenuItem.Text = "Officials";
            this.officialsToolStripMenuItem.Click += new System.EventHandler(this.officialsToolStripMenuItem_Click);
            // 
            // DashControl
            // 
            this.DashControl.BackColor = System.Drawing.Color.Silver;
            this.DashControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DashControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashControl.Location = new System.Drawing.Point(0, 0);
            this.DashControl.Name = "DashControl";
            this.DashControl.Size = new System.Drawing.Size(995, 538);
            this.DashControl.TabIndex = 3;
            // 
            // QueryPage
            // 
            this.QueryPage.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.QueryPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QueryPage.Location = new System.Drawing.Point(0, 0);
            this.QueryPage.Name = "QueryPage";
            this.QueryPage.Size = new System.Drawing.Size(995, 538);
            this.QueryPage.TabIndex = 5;
            // 
            // printingFiles
            // 
            this.printingFiles.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.printingFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.printingFiles.Location = new System.Drawing.Point(0, 0);
            this.printingFiles.Name = "printingFiles";
            this.printingFiles.Size = new System.Drawing.Size(995, 538);
            this.printingFiles.TabIndex = 4;
            this.printingFiles.TabStop = false;
            // 
            // complaintPage
            // 
            this.complaintPage.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.complaintPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.complaintPage.Location = new System.Drawing.Point(0, 0);
            this.complaintPage.Name = "complaintPage";
            this.complaintPage.Size = new System.Drawing.Size(995, 538);
            this.complaintPage.TabIndex = 6;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1176, 613);
            this.Controls.Add(this.stripPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ContentHolder);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(1050, 536);
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "E Barangay";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainPage_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ContentHolder.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.stripPanel.ResumeLayout(false);
            this.stripPanel.PerformLayout();
            this.OptionStrip.ResumeLayout(false);
            this.OptionStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button QueryBtn;
        private System.Windows.Forms.Panel ContentHolder;
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
        private System.Windows.Forms.Panel panel5;
        private PrintingDocument printingFiles;
        private QueryControl QueryPage;
        private System.Windows.Forms.Button StatBtn;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button complaintsBtn;
        private ComplaintControl complaintPage;
        private System.Windows.Forms.Panel stripPanel;
        private System.Windows.Forms.MenuStrip OptionStrip;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem officialsToolStripMenuItem;
    }
}