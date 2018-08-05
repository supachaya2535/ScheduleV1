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
            this.todayDay = new System.Windows.Forms.DateTimePicker();
            this.label23 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.detail_text = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.seachDateForReq = new System.Windows.Forms.Button();
            this.todayDatePicker = new System.Windows.Forms.DateTimePicker();
            this.reqCob = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.scan_CoBox = new System.Windows.Forms.ComboBox();
            this.paidCob = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Scanner = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.seachPaBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.birthDatePicker = new System.Windows.Forms.DateTimePicker();
            this.lnameTxt = new System.Windows.Forms.TextBox();
            this.ageTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.HNtxt = new System.Windows.Forms.TextBox();
            this.appDataGridView = new System.Windows.Forms.DataGridView();
            this.addBtn = new System.Windows.Forms.Button();
            this.todayCheckBox = new System.Windows.Forms.CheckBox();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.betweenCheckBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.manDayOff = new System.Windows.Forms.Button();
            this.manReq = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.show_calendar_btn = new System.Windows.Forms.Button();
            this.manDrWorkBtn = new System.Windows.Forms.Button();
            this.manDrBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // todayDay
            // 
            this.todayDay.CalendarFont = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todayDay.CustomFormat = "dd-MMM-yy  HH:MM";
            this.todayDay.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todayDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.todayDay.Location = new System.Drawing.Point(549, 44);
            this.todayDay.Margin = new System.Windows.Forms.Padding(4);
            this.todayDay.MaxDate = new System.DateTime(2019, 12, 31, 0, 0, 0, 0);
            this.todayDay.MinDate = new System.DateTime(1909, 11, 24, 0, 0, 0, 0);
            this.todayDay.Name = "todayDay";
            this.todayDay.Size = new System.Drawing.Size(211, 27);
            this.todayDay.TabIndex = 38;
            this.todayDay.Value = new System.DateTime(2018, 5, 22, 0, 0, 0, 0);
            this.todayDay.ValueChanged += new System.EventHandler(this.todayDay_ValueChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(839, 6);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(219, 25);
            this.label23.TabIndex = 36;
            this.label23.Text = "List of Appointments";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.detail_text);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.seachDateForReq);
            this.groupBox1.Controls.Add(this.todayDatePicker);
            this.groupBox1.Controls.Add(this.reqCob);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.scan_CoBox);
            this.groupBox1.Controls.Add(this.paidCob);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Scanner);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(4, 279);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(436, 308);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Request Information";
            // 
            // detail_text
            // 
            this.detail_text.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detail_text.Location = new System.Drawing.Point(104, 182);
            this.detail_text.Margin = new System.Windows.Forms.Padding(4);
            this.detail_text.Multiline = true;
            this.detail_text.Name = "detail_text";
            this.detail_text.Size = new System.Drawing.Size(307, 63);
            this.detail_text.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 182);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Detail";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 37);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Date";
            // 
            // seachDateForReq
            // 
            this.seachDateForReq.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seachDateForReq.Location = new System.Drawing.Point(329, 28);
            this.seachDateForReq.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.seachDateForReq.Name = "seachDateForReq";
            this.seachDateForReq.Size = new System.Drawing.Size(83, 37);
            this.seachDateForReq.TabIndex = 19;
            this.seachDateForReq.Text = "Search";
            this.seachDateForReq.UseVisualStyleBackColor = true;
            this.seachDateForReq.Click += new System.EventHandler(this.seachDateForReq_Click);
            // 
            // todayDatePicker
            // 
            this.todayDatePicker.CalendarFont = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todayDatePicker.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todayDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.todayDatePicker.Location = new System.Drawing.Point(104, 34);
            this.todayDatePicker.Margin = new System.Windows.Forms.Padding(4);
            this.todayDatePicker.MaxDate = new System.DateTime(2019, 12, 31, 0, 0, 0, 0);
            this.todayDatePicker.MinDate = new System.DateTime(1909, 11, 24, 0, 0, 0, 0);
            this.todayDatePicker.Name = "todayDatePicker";
            this.todayDatePicker.Size = new System.Drawing.Size(216, 27);
            this.todayDatePicker.TabIndex = 18;
            this.todayDatePicker.Value = new System.DateTime(2018, 5, 22, 0, 0, 0, 0);
            this.todayDatePicker.ValueChanged += new System.EventHandler(this.todayDatePicker_ValueChanged);
            // 
            // reqCob
            // 
            this.reqCob.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reqCob.FormattingEnabled = true;
            this.reqCob.Location = new System.Drawing.Point(104, 132);
            this.reqCob.Margin = new System.Windows.Forms.Padding(4);
            this.reqCob.Name = "reqCob";
            this.reqCob.Size = new System.Drawing.Size(307, 26);
            this.reqCob.TabIndex = 8;
            this.reqCob.SelectedIndexChanged += new System.EventHandler(this.reqCob_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 135);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Request";
            // 
            // scan_CoBox
            // 
            this.scan_CoBox.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scan_CoBox.FormattingEnabled = true;
            this.scan_CoBox.Location = new System.Drawing.Point(104, 82);
            this.scan_CoBox.Margin = new System.Windows.Forms.Padding(4);
            this.scan_CoBox.Name = "scan_CoBox";
            this.scan_CoBox.Size = new System.Drawing.Size(307, 26);
            this.scan_CoBox.TabIndex = 1;
            // 
            // paidCob
            // 
            this.paidCob.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paidCob.FormattingEnabled = true;
            this.paidCob.Items.AddRange(new object[] {
            "Morning",
            "Afternoon",
            "Evening"});
            this.paidCob.Location = new System.Drawing.Point(104, 263);
            this.paidCob.Margin = new System.Windows.Forms.Padding(4);
            this.paidCob.Name = "paidCob";
            this.paidCob.Size = new System.Drawing.Size(307, 26);
            this.paidCob.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 263);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Period";
            // 
            // Scanner
            // 
            this.Scanner.AutoSize = true;
            this.Scanner.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scanner.Location = new System.Drawing.Point(13, 86);
            this.Scanner.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Scanner.Name = "Scanner";
            this.Scanner.Size = new System.Drawing.Size(79, 20);
            this.Scanner.TabIndex = 0;
            this.Scanner.Text = "Scanner";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.seachPaBtn);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.birthDatePicker);
            this.groupBox2.Controls.Add(this.lnameTxt);
            this.groupBox2.Controls.Add(this.ageTxt);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.nameTxt);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.HNtxt);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(4, 6);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(436, 266);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Patient Information";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(8, 134);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(94, 20);
            this.label18.TabIndex = 23;
            this.label18.Text = "LastName";
            // 
            // seachPaBtn
            // 
            this.seachPaBtn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seachPaBtn.Location = new System.Drawing.Point(328, 28);
            this.seachPaBtn.Margin = new System.Windows.Forms.Padding(4);
            this.seachPaBtn.Name = "seachPaBtn";
            this.seachPaBtn.Size = new System.Drawing.Size(84, 37);
            this.seachPaBtn.TabIndex = 20;
            this.seachPaBtn.Text = "Seach";
            this.seachPaBtn.UseVisualStyleBackColor = true;
            this.seachPaBtn.Click += new System.EventHandler(this.seachPaBtn_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 178);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Birth";
            // 
            // birthDatePicker
            // 
            this.birthDatePicker.CalendarFont = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthDatePicker.Enabled = false;
            this.birthDatePicker.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birthDatePicker.Location = new System.Drawing.Point(104, 178);
            this.birthDatePicker.Margin = new System.Windows.Forms.Padding(4);
            this.birthDatePicker.MaxDate = new System.DateTime(2019, 12, 31, 0, 0, 0, 0);
            this.birthDatePicker.MinDate = new System.DateTime(1900, 12, 31, 0, 0, 0, 0);
            this.birthDatePicker.Name = "birthDatePicker";
            this.birthDatePicker.Size = new System.Drawing.Size(307, 27);
            this.birthDatePicker.TabIndex = 21;
            this.birthDatePicker.Value = new System.DateTime(2018, 1, 5, 0, 0, 0, 0);
            // 
            // lnameTxt
            // 
            this.lnameTxt.Enabled = false;
            this.lnameTxt.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnameTxt.Location = new System.Drawing.Point(104, 130);
            this.lnameTxt.Margin = new System.Windows.Forms.Padding(4);
            this.lnameTxt.Name = "lnameTxt";
            this.lnameTxt.Size = new System.Drawing.Size(307, 27);
            this.lnameTxt.TabIndex = 17;
            // 
            // ageTxt
            // 
            this.ageTxt.Enabled = false;
            this.ageTxt.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageTxt.Location = new System.Drawing.Point(104, 225);
            this.ageTxt.Margin = new System.Windows.Forms.Padding(4);
            this.ageTxt.Name = "ageTxt";
            this.ageTxt.Size = new System.Drawing.Size(307, 27);
            this.ageTxt.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 225);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Age";
            // 
            // nameTxt
            // 
            this.nameTxt.Enabled = false;
            this.nameTxt.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTxt.Location = new System.Drawing.Point(104, 82);
            this.nameTxt.Margin = new System.Windows.Forms.Padding(4);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(307, 27);
            this.nameTxt.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(8, 86);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 20);
            this.label12.TabIndex = 2;
            this.label12.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "HN";
            // 
            // HNtxt
            // 
            this.HNtxt.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HNtxt.Location = new System.Drawing.Point(104, 33);
            this.HNtxt.Margin = new System.Windows.Forms.Padding(4);
            this.HNtxt.Name = "HNtxt";
            this.HNtxt.Size = new System.Drawing.Size(216, 27);
            this.HNtxt.TabIndex = 5;
            this.HNtxt.TextChanged += new System.EventHandler(this.HNtxt_TextChanged);
            // 
            // appDataGridView
            // 
            this.appDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.appDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appDataGridView.Location = new System.Drawing.Point(444, 79);
            this.appDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.appDataGridView.Name = "appDataGridView";
            this.appDataGridView.Size = new System.Drawing.Size(968, 508);
            this.appDataGridView.TabIndex = 34;
            this.appDataGridView.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.appDataGridView_RowHeaderMouseDoubleClick);
            // 
            // addBtn
            // 
            this.addBtn.Enabled = false;
            this.addBtn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(16, 594);
            this.addBtn.Margin = new System.Windows.Forms.Padding(4);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(136, 63);
            this.addBtn.TabIndex = 32;
            this.addBtn.Text = "Add New Appointment";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // todayCheckBox
            // 
            this.todayCheckBox.AutoSize = true;
            this.todayCheckBox.Checked = true;
            this.todayCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.todayCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todayCheckBox.Location = new System.Drawing.Point(452, 47);
            this.todayCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.todayCheckBox.Name = "todayCheckBox";
            this.todayCheckBox.Size = new System.Drawing.Size(76, 24);
            this.todayCheckBox.TabIndex = 41;
            this.todayCheckBox.Text = "Today";
            this.todayCheckBox.UseVisualStyleBackColor = true;
            this.todayCheckBox.CheckedChanged += new System.EventHandler(this.todayCheckBox_CheckedChanged);
            // 
            // startDate
            // 
            this.startDate.CalendarFont = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDate.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startDate.Location = new System.Drawing.Point(956, 43);
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
            this.betweenCheckBox.Location = new System.Drawing.Point(839, 44);
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
            this.label4.Location = new System.Drawing.Point(1151, 44);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 45;
            this.label4.Text = "and";
            // 
            // manDayOff
            // 
            this.manDayOff.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manDayOff.Location = new System.Drawing.Point(887, 594);
            this.manDayOff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.manDayOff.Name = "manDayOff";
            this.manDayOff.Size = new System.Drawing.Size(139, 63);
            this.manDayOff.TabIndex = 56;
            this.manDayOff.Text = "Manage Day-Off";
            this.manDayOff.UseVisualStyleBackColor = true;
            this.manDayOff.Click += new System.EventHandler(this.manDayOff_Click);
            // 
            // manReq
            // 
            this.manReq.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manReq.Location = new System.Drawing.Point(593, 594);
            this.manReq.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.manReq.Name = "manReq";
            this.manReq.Size = new System.Drawing.Size(144, 63);
            this.manReq.TabIndex = 55;
            this.manReq.Text = "Manage DoctorRequest";
            this.manReq.UseVisualStyleBackColor = true;
            this.manReq.Click += new System.EventHandler(this.manReq_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(743, 594);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 63);
            this.button1.TabIndex = 57;
            this.button1.Text = "Manage Request";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1031, 594);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 63);
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
            this.endDate.Location = new System.Drawing.Point(1201, 42);
            this.endDate.Margin = new System.Windows.Forms.Padding(4);
            this.endDate.MaxDate = new System.DateTime(2029, 12, 31, 0, 0, 0, 0);
            this.endDate.MinDate = new System.DateTime(2018, 6, 1, 0, 0, 0, 0);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(185, 27);
            this.endDate.TabIndex = 59;
            this.endDate.Value = new System.DateTime(2018, 6, 1, 0, 0, 0, 0);
            this.endDate.ValueChanged += new System.EventHandler(this.endDate_ValueChanged);
            // 
            // show_calendar_btn
            // 
            this.show_calendar_btn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_calendar_btn.Location = new System.Drawing.Point(159, 594);
            this.show_calendar_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.show_calendar_btn.Name = "show_calendar_btn";
            this.show_calendar_btn.Size = new System.Drawing.Size(117, 63);
            this.show_calendar_btn.TabIndex = 60;
            this.show_calendar_btn.Text = "Show Calendar ";
            this.show_calendar_btn.UseVisualStyleBackColor = true;
            this.show_calendar_btn.Click += new System.EventHandler(this.show_calendar_btn_Click);
            // 
            // manDrWorkBtn
            // 
            this.manDrWorkBtn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manDrWorkBtn.Location = new System.Drawing.Point(444, 594);
            this.manDrWorkBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.manDrWorkBtn.Name = "manDrWorkBtn";
            this.manDrWorkBtn.Size = new System.Drawing.Size(144, 63);
            this.manDrWorkBtn.TabIndex = 61;
            this.manDrWorkBtn.Text = "Manage DoctorWork";
            this.manDrWorkBtn.UseVisualStyleBackColor = true;
            this.manDrWorkBtn.Click += new System.EventHandler(this.manDrWorkBtn_Click);
            // 
            // manDrBtn
            // 
            this.manDrBtn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manDrBtn.Location = new System.Drawing.Point(1175, 594);
            this.manDrBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.manDrBtn.Name = "manDrBtn";
            this.manDrBtn.Size = new System.Drawing.Size(139, 63);
            this.manDrBtn.TabIndex = 62;
            this.manDrBtn.Text = "Manage Doctor";
            this.manDrBtn.UseVisualStyleBackColor = true;
            this.manDrBtn.Click += new System.EventHandler(this.manDrBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1427, 665);
            this.Controls.Add(this.manDrBtn);
            this.Controls.Add(this.manDrWorkBtn);
            this.Controls.Add(this.show_calendar_btn);
            this.Controls.Add(this.endDate);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.manDayOff);
            this.Controls.Add(this.manReq);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.betweenCheckBox);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.todayCheckBox);
            this.Controls.Add(this.todayDay);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.appDataGridView);
            this.Controls.Add(this.addBtn);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn apageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appiorityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apduraTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appatientstatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DateTimePicker todayDay;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button seachDateForReq;
        private System.Windows.Forms.DateTimePicker todayDatePicker;
        private System.Windows.Forms.ComboBox reqCob;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox scan_CoBox;
        private System.Windows.Forms.ComboBox paidCob;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Scanner;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button seachPaBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker birthDatePicker;
        private System.Windows.Forms.TextBox lnameTxt;
        private System.Windows.Forms.TextBox ageTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox HNtxt;
        private System.Windows.Forms.DataGridView appDataGridView;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.CheckBox todayCheckBox;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.CheckBox betweenCheckBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button manDayOff;
        private System.Windows.Forms.Button manReq;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.DateTimePicker endDate;
        private System.Windows.Forms.TextBox detail_text;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button show_calendar_btn;
        private System.Windows.Forms.Button manDrWorkBtn;
        private System.Windows.Forms.Button manDrBtn;
    }
}

