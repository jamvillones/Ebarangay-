namespace E_Barangay.Forms
{
    partial class CreateLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UsernameTxt = new System.Windows.Forms.TextBox();
            this.PasswordTxt = new System.Windows.Forms.TextBox();
            this.CanEdit = new System.Windows.Forms.CheckBox();
            this.CanDelete = new System.Windows.Forms.CheckBox();
            this.CanReg = new System.Windows.Forms.CheckBox();
            this.CanAddUser = new System.Windows.Forms.CheckBox();
            this.ConfirmBtn = new System.Windows.Forms.Button();
            this.ConfirmPassTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.checkImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // UsernameTxt
            // 
            this.UsernameTxt.Location = new System.Drawing.Point(79, 13);
            this.UsernameTxt.Name = "UsernameTxt";
            this.UsernameTxt.Size = new System.Drawing.Size(168, 20);
            this.UsernameTxt.TabIndex = 1;
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.Location = new System.Drawing.Point(124, 39);
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.PasswordChar = '*';
            this.PasswordTxt.Size = new System.Drawing.Size(122, 20);
            this.PasswordTxt.TabIndex = 2;
            this.PasswordTxt.TextChanged += new System.EventHandler(this.PasswordTxt_TextChanged);
            // 
            // CanEdit
            // 
            this.CanEdit.AutoSize = true;
            this.CanEdit.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CanEdit.Location = new System.Drawing.Point(17, 103);
            this.CanEdit.Name = "CanEdit";
            this.CanEdit.Size = new System.Drawing.Size(66, 18);
            this.CanEdit.TabIndex = 4;
            this.CanEdit.Text = "Can Edit";
            this.CanEdit.UseVisualStyleBackColor = true;
            // 
            // CanDelete
            // 
            this.CanDelete.AutoSize = true;
            this.CanDelete.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CanDelete.Location = new System.Drawing.Point(17, 127);
            this.CanDelete.Name = "CanDelete";
            this.CanDelete.Size = new System.Drawing.Size(77, 18);
            this.CanDelete.TabIndex = 5;
            this.CanDelete.Text = "Can Delete";
            this.CanDelete.UseVisualStyleBackColor = true;
            // 
            // CanReg
            // 
            this.CanReg.AutoSize = true;
            this.CanReg.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CanReg.Location = new System.Drawing.Point(17, 151);
            this.CanReg.Name = "CanReg";
            this.CanReg.Size = new System.Drawing.Size(84, 18);
            this.CanReg.TabIndex = 6;
            this.CanReg.Text = "Can Register";
            this.CanReg.UseVisualStyleBackColor = true;
            // 
            // CanAddUser
            // 
            this.CanAddUser.AutoSize = true;
            this.CanAddUser.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CanAddUser.Location = new System.Drawing.Point(17, 175);
            this.CanAddUser.Name = "CanAddUser";
            this.CanAddUser.Size = new System.Drawing.Size(117, 18);
            this.CanAddUser.TabIndex = 7;
            this.CanAddUser.Text = "Can Add New Login";
            this.CanAddUser.UseVisualStyleBackColor = true;
            // 
            // ConfirmBtn
            // 
            this.ConfirmBtn.Font = new System.Drawing.Font("Bebas Neue Regular", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmBtn.Location = new System.Drawing.Point(101, 210);
            this.ConfirmBtn.Name = "ConfirmBtn";
            this.ConfirmBtn.Size = new System.Drawing.Size(75, 23);
            this.ConfirmBtn.TabIndex = 8;
            this.ConfirmBtn.Text = "Confirm";
            this.ConfirmBtn.UseVisualStyleBackColor = true;
            this.ConfirmBtn.Click += new System.EventHandler(this.ConfirmBtn_Click);
            // 
            // ConfirmPassTxt
            // 
            this.ConfirmPassTxt.Location = new System.Drawing.Point(124, 65);
            this.ConfirmPassTxt.Name = "ConfirmPassTxt";
            this.ConfirmPassTxt.PasswordChar = '*';
            this.ConfirmPassTxt.Size = new System.Drawing.Size(122, 20);
            this.ConfirmPassTxt.TabIndex = 3;
            this.ConfirmPassTxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Confirm Password";
            // 
            // checkImage
            // 
            this.checkImage.Image = ((System.Drawing.Image)(resources.GetObject("checkImage.Image")));
            this.checkImage.Location = new System.Drawing.Point(253, 65);
            this.checkImage.Name = "checkImage";
            this.checkImage.Size = new System.Drawing.Size(20, 20);
            this.checkImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.checkImage.TabIndex = 11;
            this.checkImage.TabStop = false;
            this.checkImage.Visible = false;
            // 
            // CreateLogin
            // 
            this.AcceptButton = this.ConfirmBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 245);
            this.Controls.Add(this.checkImage);
            this.Controls.Add(this.ConfirmPassTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ConfirmBtn);
            this.Controls.Add(this.CanAddUser);
            this.Controls.Add(this.CanReg);
            this.Controls.Add(this.CanDelete);
            this.Controls.Add(this.CanEdit);
            this.Controls.Add(this.PasswordTxt);
            this.Controls.Add(this.UsernameTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateLogin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Login";
            ((System.ComponentModel.ISupportInitialize)(this.checkImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UsernameTxt;
        private System.Windows.Forms.TextBox PasswordTxt;
        private System.Windows.Forms.CheckBox CanEdit;
        private System.Windows.Forms.CheckBox CanDelete;
        private System.Windows.Forms.CheckBox CanReg;
        private System.Windows.Forms.CheckBox CanAddUser;
        private System.Windows.Forms.Button ConfirmBtn;
        private System.Windows.Forms.TextBox ConfirmPassTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox checkImage;
    }
}