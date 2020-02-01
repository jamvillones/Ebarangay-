namespace E_Barangay.Forms
{
    partial class RecordForm
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
            this.TitleField = new System.Windows.Forms.TextBox();
            this.DetailsField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.happenedDuring = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.recordedOn = new System.Windows.Forms.DateTimePicker();
            this.locationTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TitleField
            // 
            this.TitleField.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TitleField.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleField.Location = new System.Drawing.Point(109, 12);
            this.TitleField.MaxLength = 50;
            this.TitleField.Name = "TitleField";
            this.TitleField.Size = new System.Drawing.Size(263, 20);
            this.TitleField.TabIndex = 0;
            this.TitleField.TextChanged += new System.EventHandler(this.TitleField_TextChanged);
            // 
            // DetailsField
            // 
            this.DetailsField.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DetailsField.BackColor = System.Drawing.SystemColors.Control;
            this.DetailsField.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetailsField.Location = new System.Drawing.Point(16, 142);
            this.DetailsField.MaxLength = 500;
            this.DetailsField.Multiline = true;
            this.DetailsField.Name = "DetailsField";
            this.DetailsField.Size = new System.Drawing.Size(751, 302);
            this.DetailsField.TabIndex = 14;
            this.DetailsField.TextChanged += new System.EventHandler(this.DetailsField_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "Happened During:";
            // 
            // happenedDuring
            // 
            this.happenedDuring.CalendarFont = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.happenedDuring.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            this.happenedDuring.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.happenedDuring.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.happenedDuring.Location = new System.Drawing.Point(109, 38);
            this.happenedDuring.Name = "happenedDuring";
            this.happenedDuring.Size = new System.Drawing.Size(262, 20);
            this.happenedDuring.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "Title";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SaveBtn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBtn.Location = new System.Drawing.Point(14, 450);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 5;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CancelBtn.BackColor = System.Drawing.Color.Gray;
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelBtn.ForeColor = System.Drawing.Color.Black;
            this.CancelBtn.Location = new System.Drawing.Point(95, 450);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 6;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 14);
            this.label3.TabIndex = 7;
            this.label3.Text = "Narrative";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 14);
            this.label4.TabIndex = 8;
            this.label4.Text = "Recorded On:";
            // 
            // recordedOn
            // 
            this.recordedOn.CalendarFont = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recordedOn.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            this.recordedOn.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recordedOn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.recordedOn.Location = new System.Drawing.Point(109, 64);
            this.recordedOn.Name = "recordedOn";
            this.recordedOn.Size = new System.Drawing.Size(262, 20);
            this.recordedOn.TabIndex = 2;
            // 
            // locationTxt
            // 
            this.locationTxt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.locationTxt.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationTxt.Location = new System.Drawing.Point(109, 90);
            this.locationTxt.MaxLength = 50;
            this.locationTxt.Name = "locationTxt";
            this.locationTxt.Size = new System.Drawing.Size(262, 20);
            this.locationTxt.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 14);
            this.label5.TabIndex = 11;
            this.label5.Text = "Incident Location";
            // 
            // RecordForm
            // 
            this.AcceptButton = this.SaveBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CancelButton = this.CancelBtn;
            this.ClientSize = new System.Drawing.Size(781, 485);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.locationTxt);
            this.Controls.Add(this.recordedOn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.happenedDuring);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DetailsField);
            this.Controls.Add(this.TitleField);
            this.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RecordForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Record";
            this.Load += new System.EventHandler(this.RecordForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TitleField;
        private System.Windows.Forms.TextBox DetailsField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker happenedDuring;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker recordedOn;
        private System.Windows.Forms.TextBox locationTxt;
        private System.Windows.Forms.Label label5;
    }
}