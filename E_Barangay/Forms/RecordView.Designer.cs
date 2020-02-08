namespace E_Barangay.Forms
{
    partial class RecordView
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.locationTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DetailsField = new System.Windows.Forms.TextBox();
            this.TitleField = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Person = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.TextBox();
            this.DoneBtn = new System.Windows.Forms.Button();
            this.During = new System.Windows.Forms.TextBox();
            this.RecordedOn = new System.Windows.Forms.TextBox();
            this.settleSched = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(420, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 14);
            this.label6.TabIndex = 25;
            this.label6.Text = "Settlement Schedule:\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(429, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 14);
            this.label5.TabIndex = 24;
            this.label5.Text = "Incident Location:\r\n";
            // 
            // locationTxt
            // 
            this.locationTxt.BackColor = System.Drawing.SystemColors.Control;
            this.locationTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.locationTxt.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationTxt.Location = new System.Drawing.Point(525, 41);
            this.locationTxt.MaxLength = 50;
            this.locationTxt.Name = "locationTxt";
            this.locationTxt.ReadOnly = true;
            this.locationTxt.Size = new System.Drawing.Size(248, 15);
            this.locationTxt.TabIndex = 15;
            this.locationTxt.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 14);
            this.label4.TabIndex = 23;
            this.label4.Text = "Recorded On:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 14);
            this.label3.TabIndex = 22;
            this.label3.Text = "Narrative:\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 14);
            this.label2.TabIndex = 20;
            this.label2.Text = "Title:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 14);
            this.label1.TabIndex = 17;
            this.label1.Text = "Happened During:";
            // 
            // DetailsField
            // 
            this.DetailsField.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DetailsField.BackColor = System.Drawing.SystemColors.Control;
            this.DetailsField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DetailsField.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetailsField.Location = new System.Drawing.Point(15, 154);
            this.DetailsField.MaxLength = 500;
            this.DetailsField.Multiline = true;
            this.DetailsField.Name = "DetailsField";
            this.DetailsField.ReadOnly = true;
            this.DetailsField.Size = new System.Drawing.Size(758, 263);
            this.DetailsField.TabIndex = 21;
            this.DetailsField.TabStop = false;
            // 
            // TitleField
            // 
            this.TitleField.BackColor = System.Drawing.SystemColors.Control;
            this.TitleField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TitleField.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleField.Location = new System.Drawing.Point(108, 41);
            this.TitleField.MaxLength = 50;
            this.TitleField.Name = "TitleField";
            this.TitleField.ReadOnly = true;
            this.TitleField.Size = new System.Drawing.Size(263, 15);
            this.TitleField.TabIndex = 14;
            this.TitleField.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 14);
            this.label7.TabIndex = 27;
            this.label7.Text = "Person Involved:\r\n";
            // 
            // Person
            // 
            this.Person.BackColor = System.Drawing.SystemColors.Control;
            this.Person.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Person.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Person.Location = new System.Drawing.Point(108, 15);
            this.Person.MaxLength = 50;
            this.Person.Name = "Person";
            this.Person.ReadOnly = true;
            this.Person.Size = new System.Drawing.Size(263, 15);
            this.Person.TabIndex = 26;
            this.Person.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(485, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 14);
            this.label8.TabIndex = 29;
            this.label8.Text = "Status:";
            // 
            // Status
            // 
            this.Status.BackColor = System.Drawing.SystemColors.Control;
            this.Status.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Status.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status.Location = new System.Drawing.Point(525, 15);
            this.Status.MaxLength = 50;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Size = new System.Drawing.Size(248, 15);
            this.Status.TabIndex = 28;
            this.Status.TabStop = false;
            // 
            // DoneBtn
            // 
            this.DoneBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.DoneBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DoneBtn.Location = new System.Drawing.Point(336, 436);
            this.DoneBtn.Name = "DoneBtn";
            this.DoneBtn.Size = new System.Drawing.Size(112, 23);
            this.DoneBtn.TabIndex = 30;
            this.DoneBtn.Text = "Mark as Done";
            this.DoneBtn.UseVisualStyleBackColor = false;
            this.DoneBtn.Click += new System.EventHandler(this.DoneBtn_Click);
            // 
            // During
            // 
            this.During.BackColor = System.Drawing.SystemColors.Control;
            this.During.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.During.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.During.Location = new System.Drawing.Point(108, 69);
            this.During.MaxLength = 50;
            this.During.Name = "During";
            this.During.ReadOnly = true;
            this.During.Size = new System.Drawing.Size(263, 15);
            this.During.TabIndex = 31;
            this.During.TabStop = false;
            // 
            // RecordedOn
            // 
            this.RecordedOn.BackColor = System.Drawing.SystemColors.Control;
            this.RecordedOn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RecordedOn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecordedOn.Location = new System.Drawing.Point(108, 95);
            this.RecordedOn.MaxLength = 50;
            this.RecordedOn.Name = "RecordedOn";
            this.RecordedOn.ReadOnly = true;
            this.RecordedOn.Size = new System.Drawing.Size(263, 15);
            this.RecordedOn.TabIndex = 32;
            this.RecordedOn.TabStop = false;
            // 
            // settleSched
            // 
            this.settleSched.BackColor = System.Drawing.SystemColors.Control;
            this.settleSched.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.settleSched.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settleSched.Location = new System.Drawing.Point(525, 69);
            this.settleSched.MaxLength = 50;
            this.settleSched.Name = "settleSched";
            this.settleSched.ReadOnly = true;
            this.settleSched.Size = new System.Drawing.Size(248, 15);
            this.settleSched.TabIndex = 33;
            this.settleSched.TabStop = false;
            // 
            // RecordView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 481);
            this.Controls.Add(this.settleSched);
            this.Controls.Add(this.RecordedOn);
            this.Controls.Add(this.During);
            this.Controls.Add(this.DoneBtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Person);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.locationTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DetailsField);
            this.Controls.Add(this.TitleField);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RecordView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blotter Report";
            this.Load += new System.EventHandler(this.RecordView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox locationTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DetailsField;
        private System.Windows.Forms.TextBox TitleField;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Person;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Status;
        private System.Windows.Forms.Button DoneBtn;
        private System.Windows.Forms.TextBox During;
        private System.Windows.Forms.TextBox RecordedOn;
        private System.Windows.Forms.TextBox settleSched;
    }
}