namespace E_Barangay.Forms
{
    partial class ComplaintViewForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.narrativeField = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.controlNumberField = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.TextBox();
            this.DoneBtn = new System.Windows.Forms.Button();
            this.During = new System.Windows.Forms.TextBox();
            this.RecordedOn = new System.Windows.Forms.TextBox();
            this.settleSched = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.lvRespondents = new System.Windows.Forms.ListView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lvComplainants = new System.Windows.Forms.ListView();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(417, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 14);
            this.label6.TabIndex = 25;
            this.label6.Text = "Settlement Schedule:\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 30);
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
            this.locationTxt.Location = new System.Drawing.Point(108, 29);
            this.locationTxt.MaxLength = 50;
            this.locationTxt.Name = "locationTxt";
            this.locationTxt.ReadOnly = true;
            this.locationTxt.Size = new System.Drawing.Size(263, 15);
            this.locationTxt.TabIndex = 15;
            this.locationTxt.TabStop = false;
            this.locationTxt.TextChanged += new System.EventHandler(this.locationTxt_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 14);
            this.label4.TabIndex = 23;
            this.label4.Text = "Recorded On:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 14);
            this.label3.TabIndex = 22;
            this.label3.Text = "Narrative:\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 14);
            this.label1.TabIndex = 17;
            this.label1.Text = "Happened During:";
            // 
            // narrativeField
            // 
            this.narrativeField.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.narrativeField.BackColor = System.Drawing.SystemColors.Control;
            this.narrativeField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.narrativeField.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.narrativeField.Location = new System.Drawing.Point(15, 294);
            this.narrativeField.MaxLength = 3000;
            this.narrativeField.Multiline = true;
            this.narrativeField.Name = "narrativeField";
            this.narrativeField.ReadOnly = true;
            this.narrativeField.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.narrativeField.Size = new System.Drawing.Size(758, 146);
            this.narrativeField.TabIndex = 21;
            this.narrativeField.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 14);
            this.label7.TabIndex = 27;
            this.label7.Text = "Control Number:";
            // 
            // controlNumberField
            // 
            this.controlNumberField.BackColor = System.Drawing.SystemColors.Control;
            this.controlNumberField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.controlNumberField.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlNumberField.Location = new System.Drawing.Point(108, 8);
            this.controlNumberField.MaxLength = 50;
            this.controlNumberField.Name = "controlNumberField";
            this.controlNumberField.ReadOnly = true;
            this.controlNumberField.Size = new System.Drawing.Size(263, 15);
            this.controlNumberField.TabIndex = 26;
            this.controlNumberField.TabStop = false;
            this.controlNumberField.TextChanged += new System.EventHandler(this.controlNumberField_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(482, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 14);
            this.label8.TabIndex = 29;
            this.label8.Text = "Status:";
            // 
            // Status
            // 
            this.Status.BackColor = System.Drawing.SystemColors.Control;
            this.Status.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Status.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Status.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status.Location = new System.Drawing.Point(525, 8);
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
            this.DoneBtn.Location = new System.Drawing.Point(336, 446);
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
            this.During.Location = new System.Drawing.Point(108, 77);
            this.During.MaxLength = 50;
            this.During.Name = "During";
            this.During.ReadOnly = true;
            this.During.Size = new System.Drawing.Size(263, 15);
            this.During.TabIndex = 31;
            this.During.TabStop = false;
            this.During.TextChanged += new System.EventHandler(this.During_TextChanged);
            // 
            // RecordedOn
            // 
            this.RecordedOn.BackColor = System.Drawing.SystemColors.Control;
            this.RecordedOn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RecordedOn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecordedOn.Location = new System.Drawing.Point(108, 98);
            this.RecordedOn.MaxLength = 50;
            this.RecordedOn.Name = "RecordedOn";
            this.RecordedOn.ReadOnly = true;
            this.RecordedOn.Size = new System.Drawing.Size(263, 15);
            this.RecordedOn.TabIndex = 32;
            this.RecordedOn.TabStop = false;
            this.RecordedOn.TextChanged += new System.EventHandler(this.RecordedOn_TextChanged);
            // 
            // settleSched
            // 
            this.settleSched.BackColor = System.Drawing.SystemColors.Control;
            this.settleSched.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.settleSched.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settleSched.Location = new System.Drawing.Point(525, 77);
            this.settleSched.MaxLength = 50;
            this.settleSched.Name = "settleSched";
            this.settleSched.ReadOnly = true;
            this.settleSched.Size = new System.Drawing.Size(248, 15);
            this.settleSched.TabIndex = 33;
            this.settleSched.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(12, 129);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(761, 1);
            this.panel1.TabIndex = 34;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(12, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(761, 1);
            this.panel2.TabIndex = 35;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(12, 268);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(761, 1);
            this.panel3.TabIndex = 35;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel5, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 137);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(761, 118);
            this.tableLayoutPanel1.TabIndex = 36;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.lvRespondents);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(383, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(375, 112);
            this.panel5.TabIndex = 38;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 14);
            this.label9.TabIndex = 37;
            this.label9.Text = "Respondent/s";
            // 
            // lvRespondents
            // 
            this.lvRespondents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvRespondents.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvRespondents.HideSelection = false;
            this.lvRespondents.Location = new System.Drawing.Point(0, 28);
            this.lvRespondents.Name = "lvRespondents";
            this.lvRespondents.Size = new System.Drawing.Size(375, 84);
            this.lvRespondents.TabIndex = 0;
            this.lvRespondents.UseCompatibleStateImageBehavior = false;
            this.lvRespondents.View = System.Windows.Forms.View.List;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.lvComplainants);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(374, 112);
            this.panel4.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 14);
            this.label2.TabIndex = 37;
            this.label2.Text = "Complainant/s";
            // 
            // lvComplainants
            // 
            this.lvComplainants.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvComplainants.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvComplainants.HideSelection = false;
            this.lvComplainants.Location = new System.Drawing.Point(0, 28);
            this.lvComplainants.Name = "lvComplainants";
            this.lvComplainants.Size = new System.Drawing.Size(374, 84);
            this.lvComplainants.TabIndex = 0;
            this.lvComplainants.UseCompatibleStateImageBehavior = false;
            this.lvComplainants.View = System.Windows.Forms.View.List;
            // 
            // RecordView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 481);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.settleSched);
            this.Controls.Add(this.RecordedOn);
            this.Controls.Add(this.During);
            this.Controls.Add(this.DoneBtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.controlNumberField);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.locationTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.narrativeField);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RecordView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Complaint Preview";
            this.Load += new System.EventHandler(this.RecordView_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox locationTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox narrativeField;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox controlNumberField;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Status;
        private System.Windows.Forms.Button DoneBtn;
        private System.Windows.Forms.TextBox During;
        private System.Windows.Forms.TextBox RecordedOn;
        private System.Windows.Forms.TextBox settleSched;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ListView lvComplainants;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListView lvRespondents;
    }
}