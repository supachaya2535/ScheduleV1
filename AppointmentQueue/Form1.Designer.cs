namespace AppointmentQueue
{
    partial class Form1
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
            this.label23 = new System.Windows.Forms.Label();
            this.kidCheckBox = new System.Windows.Forms.CheckBox();
            this.reqCob = new System.Windows.Forms.ComboBox();
            this.paidCob = new System.Windows.Forms.ComboBox();
            this.appDataGridView = new System.Windows.Forms.DataGridView();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.betweenCheckBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.manDayOff = new System.Windows.Forms.Button();
            this.manReq = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.calendarBtn = new System.Windows.Forms.Button();
            this.manDrWorkBtn = new System.Windows.Forms.Button();
            this.manDrBtn = new System.Windows.Forms.Button();
            this.waitCheckBox = new System.Windows.Forms.CheckBox();
            this.req_checkBox = new System.Windows.Forms.CheckBox();
            this.ped_checkBox = new System.Windows.Forms.CheckBox();
            this.reqDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.appDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reqDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(188, 12);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(236, 25);
            this.label23.TabIndex = 36;
            this.label23.Text = "List of Doctor Working";
            // 
            // kidCheckBox
            // 
            this.kidCheckBox.AutoSize = true;
            this.kidCheckBox.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kidCheckBox.Location = new System.Drawing.Point(193, 125);
            this.kidCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.kidCheckBox.Name = "kidCheckBox";
            this.kidCheckBox.Size = new System.Drawing.Size(396, 24);
            this.kidCheckBox.TabIndex = 74;
            this.kidCheckBox.Text = "Show only \"Request for Pediatric Patients\"";
            this.kidCheckBox.UseVisualStyleBackColor = true;
            this.kidCheckBox.CheckedChanged += new System.EventHandler(this.kidCheckBox_CheckedChanged);
            // 
            // reqCob
            // 
            this.reqCob.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reqCob.FormattingEnabled = true;
            this.reqCob.Location = new System.Drawing.Point(906, 84);
            this.reqCob.Margin = new System.Windows.Forms.Padding(4);
            this.reqCob.Name = "reqCob";
            this.reqCob.Size = new System.Drawing.Size(307, 26);
            this.reqCob.TabIndex = 8;
            this.reqCob.SelectedIndexChanged += new System.EventHandler(this.reqCob_SelectedIndexChanged);
            // 
            // paidCob
            // 
            this.paidCob.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paidCob.FormattingEnabled = true;
            this.paidCob.Items.AddRange(new object[] {
            "Morning",
            "Afternoon",
            "Evening"});
            this.paidCob.Location = new System.Drawing.Point(400, 90);
            this.paidCob.Margin = new System.Windows.Forms.Padding(4);
            this.paidCob.Name = "paidCob";
            this.paidCob.Size = new System.Drawing.Size(197, 26);
            this.paidCob.TabIndex = 12;
            // 
            // appDataGridView
            // 
            this.appDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.appDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appDataGridView.Location = new System.Drawing.Point(193, 168);
            this.appDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.appDataGridView.Name = "appDataGridView";
            this.appDataGridView.Size = new System.Drawing.Size(1058, 575);
            this.appDataGridView.TabIndex = 34;
            this.appDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.appDataGridView_CellContentClick);
            this.appDataGridView.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.appDataGridView_RowHeaderMouseDoubleClick);
            // 
            // startDate
            // 
            this.startDate.CalendarFont = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDate.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startDate.Location = new System.Drawing.Point(783, 122);
            this.startDate.Margin = new System.Windows.Forms.Padding(4);
            this.startDate.MaxDate = new System.DateTime(2019, 12, 31, 0, 0, 0, 0);
            this.startDate.MinDate = new System.DateTime(1909, 11, 24, 0, 0, 0, 0);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(185, 27);
            this.startDate.TabIndex = 42;
            this.startDate.Value = new System.DateTime(2018, 5, 22, 0, 0, 0, 0);
            this.startDate.ValueChanged += new System.EventHandler(this.startDate_ValueChanged);
            // 
            // betweenCheckBox
            // 
            this.betweenCheckBox.AutoSize = true;
            this.betweenCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betweenCheckBox.Location = new System.Drawing.Point(665, 124);
            this.betweenCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.betweenCheckBox.Name = "betweenCheckBox";
            this.betweenCheckBox.Size = new System.Drawing.Size(96, 24);
            this.betweenCheckBox.TabIndex = 44;
            this.betweenCheckBox.Text = "Between";
            this.betweenCheckBox.UseVisualStyleBackColor = true;
            this.betweenCheckBox.CheckedChanged += new System.EventHandler(this.betweenCheckBox_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(977, 124);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 45;
            this.label4.Text = "and";
            // 
            // manDayOff
            // 
            this.manDayOff.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manDayOff.Location = new System.Drawing.Point(13, 280);
            this.manDayOff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.manDayOff.Name = "manDayOff";
            this.manDayOff.Size = new System.Drawing.Size(144, 63);
            this.manDayOff.TabIndex = 56;
            this.manDayOff.Text = "Manage Day Off";
            this.manDayOff.UseVisualStyleBackColor = true;
            this.manDayOff.Click += new System.EventHandler(this.manDayOff_Click);
            // 
            // manReq
            // 
            this.manReq.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manReq.Location = new System.Drawing.Point(14, 414);
            this.manReq.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.manReq.Name = "manReq";
            this.manReq.Size = new System.Drawing.Size(144, 63);
            this.manReq.TabIndex = 55;
            this.manReq.Text = "Manage Doctor Request";
            this.manReq.UseVisualStyleBackColor = true;
            this.manReq.Click += new System.EventHandler(this.manReq_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 146);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 63);
            this.button1.TabIndex = 57;
            this.button1.Text = "Manage Request";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(13, 213);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 63);
            this.button2.TabIndex = 58;
            this.button2.Text = "Manage Scanner";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // endDate
            // 
            this.endDate.CalendarFont = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDate.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endDate.Location = new System.Drawing.Point(1028, 121);
            this.endDate.Margin = new System.Windows.Forms.Padding(4);
            this.endDate.MaxDate = new System.DateTime(2029, 12, 31, 0, 0, 0, 0);
            this.endDate.MinDate = new System.DateTime(2018, 6, 1, 0, 0, 0, 0);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(185, 27);
            this.endDate.TabIndex = 59;
            this.endDate.Value = new System.DateTime(2018, 6, 1, 0, 0, 0, 0);
            this.endDate.ValueChanged += new System.EventHandler(this.endDate_ValueChanged);
            // 
            // calendarBtn
            // 
            this.calendarBtn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calendarBtn.Location = new System.Drawing.Point(12, 12);
            this.calendarBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.calendarBtn.Name = "calendarBtn";
            this.calendarBtn.Size = new System.Drawing.Size(144, 63);
            this.calendarBtn.TabIndex = 60;
            this.calendarBtn.Text = "Calendar ";
            this.calendarBtn.UseVisualStyleBackColor = true;
            this.calendarBtn.Click += new System.EventHandler(this.show_calendar_btn_Click);
            // 
            // manDrWorkBtn
            // 
            this.manDrWorkBtn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manDrWorkBtn.Location = new System.Drawing.Point(12, 79);
            this.manDrWorkBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.manDrWorkBtn.Name = "manDrWorkBtn";
            this.manDrWorkBtn.Size = new System.Drawing.Size(144, 63);
            this.manDrWorkBtn.TabIndex = 61;
            this.manDrWorkBtn.Text = "Manage Doctor Working";
            this.manDrWorkBtn.UseVisualStyleBackColor = true;
            this.manDrWorkBtn.Click += new System.EventHandler(this.manDrWorkBtn_Click);
            // 
            // manDrBtn
            // 
            this.manDrBtn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manDrBtn.Location = new System.Drawing.Point(14, 347);
            this.manDrBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.manDrBtn.Name = "manDrBtn";
            this.manDrBtn.Size = new System.Drawing.Size(144, 63);
            this.manDrBtn.TabIndex = 62;
            this.manDrBtn.Text = "Manage Doctor";
            this.manDrBtn.UseVisualStyleBackColor = true;
            this.manDrBtn.Click += new System.EventHandler(this.manDrBtn_Click);
            // 
            // waitCheckBox
            // 
            this.waitCheckBox.AutoSize = true;
            this.waitCheckBox.Checked = true;
            this.waitCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.waitCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.waitCheckBox.Location = new System.Drawing.Point(192, 54);
            this.waitCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.waitCheckBox.Name = "waitCheckBox";
            this.waitCheckBox.Size = new System.Drawing.Size(305, 24);
            this.waitCheckBox.TabIndex = 63;
            this.waitCheckBox.Text = "Show only \"Availabel\" doctor working";
            this.waitCheckBox.UseVisualStyleBackColor = true;
            this.waitCheckBox.CheckedChanged += new System.EventHandler(this.waitCheckBox_CheckedChanged);
            // 
            // req_checkBox
            // 
            this.req_checkBox.AutoSize = true;
            this.req_checkBox.Checked = true;
            this.req_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.req_checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.req_checkBox.Location = new System.Drawing.Point(665, 86);
            this.req_checkBox.Margin = new System.Windows.Forms.Padding(4);
            this.req_checkBox.Name = "req_checkBox";
            this.req_checkBox.Size = new System.Drawing.Size(186, 24);
            this.req_checkBox.TabIndex = 77;
            this.req_checkBox.Text = "Show only \"Request\"";
            this.req_checkBox.UseVisualStyleBackColor = true;
            this.req_checkBox.CheckedChanged += new System.EventHandler(this.req_checkBox_CheckedChanged);
            // 
            // ped_checkBox
            // 
            this.ped_checkBox.AutoSize = true;
            this.ped_checkBox.Checked = true;
            this.ped_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ped_checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ped_checkBox.Location = new System.Drawing.Point(192, 92);
            this.ped_checkBox.Margin = new System.Windows.Forms.Padding(4);
            this.ped_checkBox.Name = "ped_checkBox";
            this.ped_checkBox.Size = new System.Drawing.Size(172, 24);
            this.ped_checkBox.TabIndex = 78;
            this.ped_checkBox.Text = "Show only \"Period\"";
            this.ped_checkBox.UseVisualStyleBackColor = true;
            // 
            // reqDataGridView
            // 
            this.reqDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.reqDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reqDataGridView.Location = new System.Drawing.Point(1259, 168);
            this.reqDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.reqDataGridView.Name = "reqDataGridView";
            this.reqDataGridView.Size = new System.Drawing.Size(409, 575);
            this.reqDataGridView.TabIndex = 79;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1286, 139);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 25);
            this.label1.TabIndex = 80;
            this.label1.Text = "List of reqests on selected day";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1727, 756);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reqDataGridView);
            this.Controls.Add(this.ped_checkBox);
            this.Controls.Add(this.kidCheckBox);
            this.Controls.Add(this.req_checkBox);
            this.Controls.Add(this.waitCheckBox);
            this.Controls.Add(this.paidCob);
            this.Controls.Add(this.manDrBtn);
            this.Controls.Add(this.reqCob);
            this.Controls.Add(this.manDrWorkBtn);
            this.Controls.Add(this.calendarBtn);
            this.Controls.Add(this.endDate);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.manDayOff);
            this.Controls.Add(this.manReq);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.betweenCheckBox);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.appDataGridView);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Information Scheduling Form";
            ((System.ComponentModel.ISupportInitialize)(this.appDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reqDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn apageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appiorityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apduraTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appatientstatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox reqCob;
        private System.Windows.Forms.ComboBox paidCob;
        private System.Windows.Forms.DataGridView appDataGridView;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.CheckBox betweenCheckBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button manDayOff;
        private System.Windows.Forms.Button manReq;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.DateTimePicker endDate;
        private System.Windows.Forms.Button calendarBtn;
        private System.Windows.Forms.Button manDrWorkBtn;
        private System.Windows.Forms.Button manDrBtn;
        private System.Windows.Forms.CheckBox kidCheckBox;
        private System.Windows.Forms.CheckBox waitCheckBox;
        private System.Windows.Forms.CheckBox req_checkBox;
        private System.Windows.Forms.CheckBox ped_checkBox;
        private System.Windows.Forms.DataGridView reqDataGridView;
        private System.Windows.Forms.Label label1;
    }
}

