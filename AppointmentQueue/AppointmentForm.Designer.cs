namespace AppointmentQueue
{
    partial class AppointmentForm
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
            this.saveBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.reqGroupBox = new System.Windows.Forms.GroupBox();
            this.calendarBtn = new System.Windows.Forms.Button();
            this.kidCheckBox = new System.Windows.Forms.CheckBox();
            this.drTxt = new System.Windows.Forms.TextBox();
            this.Doctor = new System.Windows.Forms.Label();
            this.detail_text = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.todayDatePicker = new System.Windows.Forms.DateTimePicker();
            this.reqCob = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.HNtxt = new System.Windows.Forms.TextBox();
            this.paidCob = new System.Windows.Forms.ComboBox();
            this.reqGroupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(6, 358);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(116, 30);
            this.saveBtn.TabIndex = 21;
            this.saveBtn.Text = "Update";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(210, 358);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(123, 30);
            this.deleteBtn.TabIndex = 4;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            // 
            // reqGroupBox
            // 
            this.reqGroupBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.reqGroupBox.Controls.Add(this.paidCob);
            this.reqGroupBox.Controls.Add(this.calendarBtn);
            this.reqGroupBox.Controls.Add(this.kidCheckBox);
            this.reqGroupBox.Controls.Add(this.drTxt);
            this.reqGroupBox.Controls.Add(this.Doctor);
            this.reqGroupBox.Controls.Add(this.detail_text);
            this.reqGroupBox.Controls.Add(this.label7);
            this.reqGroupBox.Controls.Add(this.label6);
            this.reqGroupBox.Controls.Add(this.todayDatePicker);
            this.reqGroupBox.Controls.Add(this.reqCob);
            this.reqGroupBox.Controls.Add(this.label3);
            this.reqGroupBox.Controls.Add(this.label5);
            this.reqGroupBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reqGroupBox.Location = new System.Drawing.Point(6, 80);
            this.reqGroupBox.Name = "reqGroupBox";
            this.reqGroupBox.Size = new System.Drawing.Size(327, 272);
            this.reqGroupBox.TabIndex = 34;
            this.reqGroupBox.TabStop = false;
            this.reqGroupBox.Text = "Request Information";
            // 
            // calendarBtn
            // 
            this.calendarBtn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calendarBtn.Location = new System.Drawing.Point(220, 13);
            this.calendarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.calendarBtn.Name = "calendarBtn";
            this.calendarBtn.Size = new System.Drawing.Size(90, 41);
            this.calendarBtn.TabIndex = 75;
            this.calendarBtn.Text = "Calendar ";
            this.calendarBtn.UseVisualStyleBackColor = true;
            this.calendarBtn.Click += new System.EventHandler(this.calendarBtn_Click);
            // 
            // kidCheckBox
            // 
            this.kidCheckBox.AutoSize = true;
            this.kidCheckBox.Enabled = false;
            this.kidCheckBox.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kidCheckBox.Location = new System.Drawing.Point(79, 86);
            this.kidCheckBox.Name = "kidCheckBox";
            this.kidCheckBox.Size = new System.Drawing.Size(143, 20);
            this.kidCheckBox.TabIndex = 74;
            this.kidCheckBox.Text = "Pediatric Patients";
            this.kidCheckBox.UseVisualStyleBackColor = true;
            // 
            // drTxt
            // 
            this.drTxt.Enabled = false;
            this.drTxt.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drTxt.Location = new System.Drawing.Point(79, 59);
            this.drTxt.Name = "drTxt";
            this.drTxt.Size = new System.Drawing.Size(231, 23);
            this.drTxt.TabIndex = 26;
            // 
            // Doctor
            // 
            this.Doctor.AutoSize = true;
            this.Doctor.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Doctor.Location = new System.Drawing.Point(9, 62);
            this.Doctor.Name = "Doctor";
            this.Doctor.Size = new System.Drawing.Size(66, 16);
            this.Doctor.TabIndex = 25;
            this.Doctor.Text = "DoctorID";
            // 
            // detail_text
            // 
            this.detail_text.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detail_text.Location = new System.Drawing.Point(78, 172);
            this.detail_text.Multiline = true;
            this.detail_text.Name = "detail_text";
            this.detail_text.Size = new System.Drawing.Size(231, 52);
            this.detail_text.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "Detail";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Date";
            // 
            // todayDatePicker
            // 
            this.todayDatePicker.CalendarFont = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todayDatePicker.Enabled = false;
            this.todayDatePicker.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todayDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.todayDatePicker.Location = new System.Drawing.Point(79, 26);
            this.todayDatePicker.MaxDate = new System.DateTime(2019, 12, 31, 0, 0, 0, 0);
            this.todayDatePicker.MinDate = new System.DateTime(1909, 11, 24, 0, 0, 0, 0);
            this.todayDatePicker.Name = "todayDatePicker";
            this.todayDatePicker.Size = new System.Drawing.Size(134, 23);
            this.todayDatePicker.TabIndex = 18;
            this.todayDatePicker.Value = new System.DateTime(2018, 5, 22, 0, 0, 0, 0);
            // 
            // reqCob
            // 
            this.reqCob.Enabled = false;
            this.reqCob.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reqCob.FormattingEnabled = true;
            this.reqCob.Location = new System.Drawing.Point(78, 112);
            this.reqCob.Name = "reqCob";
            this.reqCob.Size = new System.Drawing.Size(231, 24);
            this.reqCob.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Request";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Period";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.HNtxt);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(6, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(327, 62);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Patient Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "HN";
            // 
            // HNtxt
            // 
            this.HNtxt.Enabled = false;
            this.HNtxt.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HNtxt.Location = new System.Drawing.Point(78, 27);
            this.HNtxt.Name = "HNtxt";
            this.HNtxt.Size = new System.Drawing.Size(231, 23);
            this.HNtxt.TabIndex = 5;
            // 
            // paidCob
            // 
            this.paidCob.Enabled = false;
            this.paidCob.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paidCob.FormattingEnabled = true;
            this.paidCob.Items.AddRange(new object[] {
            "Morning",
            "Afternoon",
            "Evening"});
            this.paidCob.Location = new System.Drawing.Point(79, 142);
            this.paidCob.Name = "paidCob";
            this.paidCob.Size = new System.Drawing.Size(231, 24);
            this.paidCob.TabIndex = 76;
            // 
            // AppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 396);
            this.Controls.Add(this.reqGroupBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.deleteBtn);
            this.Name = "AppointmentForm";
            this.Text = "AppointmentForm";
            this.reqGroupBox.ResumeLayout(false);
            this.reqGroupBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.GroupBox reqGroupBox;
        private System.Windows.Forms.CheckBox kidCheckBox;
        private System.Windows.Forms.TextBox drTxt;
        private System.Windows.Forms.Label Doctor;
        private System.Windows.Forms.TextBox detail_text;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker todayDatePicker;
        private System.Windows.Forms.ComboBox reqCob;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox HNtxt;
        private System.Windows.Forms.Button calendarBtn;
        private System.Windows.Forms.ComboBox paidCob;
    }
}