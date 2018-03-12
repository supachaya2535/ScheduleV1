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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.apIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appiorityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apstartTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apduraTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appatientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aprequestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appatientstatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ap_insu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ap_scan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ap_scannum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointmentsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new AppointmentQueue.Database1DataSet();
            this.reqCob = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.scan_CoBox = new System.Windows.Forms.ComboBox();
            this.Scanner = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Search_request_info_btn = new System.Windows.Forms.Button();
            this.todayDatePicker = new System.Windows.Forms.DateTimePicker();
            this.insuCob = new System.Windows.Forms.ComboBox();
            this.InsuranceCob = new System.Windows.Forms.Label();
            this.paidCob = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.statusCob = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.birthDatePicker = new System.Windows.Forms.DateTimePicker();
            this.seachPaBtn = new System.Windows.Forms.Button();
            this.HNtxt = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.todayAppointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.editBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lnameTxt = new System.Windows.Forms.TextBox();
            this.ageTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.appointmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appointmentsTableAdapter = new AppointmentQueue.Database1DataSetTableAdapters.AppointmentsTableAdapter();
            this.todayAppointmentTableAdapter = new AppointmentQueue.Database1DataSetTableAdapters.TodayAppointmentTableAdapter();
            this.edit_cond_req_btn = new System.Windows.Forms.Button();
            this.edit_requests_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.todayAppointmentBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.apIdDataGridViewTextBoxColumn,
            this.appiorityDataGridViewTextBoxColumn,
            this.apstartTDataGridViewTextBoxColumn,
            this.apduraTDataGridViewTextBoxColumn,
            this.appatientDataGridViewTextBoxColumn,
            this.aprequestDataGridViewTextBoxColumn,
            this.appaidDataGridViewTextBoxColumn,
            this.appatientstatusDataGridViewTextBoxColumn,
            this.ap_insu,
            this.ap_scan,
            this.ap_scannum});
            this.dataGridView1.DataSource = this.appointmentsBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(0, 484);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1525, 251);
            this.dataGridView1.TabIndex = 0;
            // 
            // apIdDataGridViewTextBoxColumn
            // 
            this.apIdDataGridViewTextBoxColumn.DataPropertyName = "ap_Id";
            this.apIdDataGridViewTextBoxColumn.HeaderText = "ap_Id";
            this.apIdDataGridViewTextBoxColumn.Name = "apIdDataGridViewTextBoxColumn";
            // 
            // appiorityDataGridViewTextBoxColumn
            // 
            this.appiorityDataGridViewTextBoxColumn.DataPropertyName = "ap_piority";
            this.appiorityDataGridViewTextBoxColumn.HeaderText = "ap_piority";
            this.appiorityDataGridViewTextBoxColumn.Name = "appiorityDataGridViewTextBoxColumn";
            // 
            // apstartTDataGridViewTextBoxColumn
            // 
            this.apstartTDataGridViewTextBoxColumn.DataPropertyName = "ap_startT";
            this.apstartTDataGridViewTextBoxColumn.HeaderText = "ap_startT";
            this.apstartTDataGridViewTextBoxColumn.Name = "apstartTDataGridViewTextBoxColumn";
            // 
            // apduraTDataGridViewTextBoxColumn
            // 
            this.apduraTDataGridViewTextBoxColumn.DataPropertyName = "ap_duraT";
            this.apduraTDataGridViewTextBoxColumn.HeaderText = "ap_duraT";
            this.apduraTDataGridViewTextBoxColumn.Name = "apduraTDataGridViewTextBoxColumn";
            // 
            // appatientDataGridViewTextBoxColumn
            // 
            this.appatientDataGridViewTextBoxColumn.DataPropertyName = "ap_patient";
            this.appatientDataGridViewTextBoxColumn.HeaderText = "ap_patient";
            this.appatientDataGridViewTextBoxColumn.Name = "appatientDataGridViewTextBoxColumn";
            // 
            // aprequestDataGridViewTextBoxColumn
            // 
            this.aprequestDataGridViewTextBoxColumn.DataPropertyName = "ap_request";
            this.aprequestDataGridViewTextBoxColumn.HeaderText = "ap_request";
            this.aprequestDataGridViewTextBoxColumn.Name = "aprequestDataGridViewTextBoxColumn";
            // 
            // appaidDataGridViewTextBoxColumn
            // 
            this.appaidDataGridViewTextBoxColumn.DataPropertyName = "ap_paid";
            this.appaidDataGridViewTextBoxColumn.HeaderText = "ap_paid";
            this.appaidDataGridViewTextBoxColumn.Name = "appaidDataGridViewTextBoxColumn";
            // 
            // appatientstatusDataGridViewTextBoxColumn
            // 
            this.appatientstatusDataGridViewTextBoxColumn.DataPropertyName = "ap_patientstatus";
            this.appatientstatusDataGridViewTextBoxColumn.HeaderText = "ap_patientstatus";
            this.appatientstatusDataGridViewTextBoxColumn.Name = "appatientstatusDataGridViewTextBoxColumn";
            // 
            // ap_insu
            // 
            this.ap_insu.DataPropertyName = "ap_insu";
            this.ap_insu.HeaderText = "ap_insu";
            this.ap_insu.Name = "ap_insu";
            // 
            // ap_scan
            // 
            this.ap_scan.DataPropertyName = "ap_scan";
            this.ap_scan.HeaderText = "ap_scan";
            this.ap_scan.Name = "ap_scan";
            // 
            // ap_scannum
            // 
            this.ap_scannum.DataPropertyName = "ap_scannum";
            this.ap_scannum.HeaderText = "ap_scannum";
            this.ap_scannum.Name = "ap_scannum";
            // 
            // appointmentsBindingSource1
            // 
            this.appointmentsBindingSource1.DataMember = "Appointments";
            this.appointmentsBindingSource1.DataSource = this.database1DataSetBindingSource;
            // 
            // database1DataSetBindingSource
            // 
            this.database1DataSetBindingSource.DataSource = this.database1DataSet;
            this.database1DataSetBindingSource.Position = 0;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reqCob
            // 
            this.reqCob.Enabled = false;
            this.reqCob.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reqCob.FormattingEnabled = true;
            this.reqCob.Location = new System.Drawing.Point(104, 127);
            this.reqCob.Margin = new System.Windows.Forms.Padding(4);
            this.reqCob.Name = "reqCob";
            this.reqCob.Size = new System.Drawing.Size(241, 26);
            this.reqCob.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 130);
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
            this.scan_CoBox.Location = new System.Drawing.Point(104, 80);
            this.scan_CoBox.Margin = new System.Windows.Forms.Padding(4);
            this.scan_CoBox.Name = "scan_CoBox";
            this.scan_CoBox.Size = new System.Drawing.Size(241, 26);
            this.scan_CoBox.TabIndex = 1;
            this.scan_CoBox.SelectedIndexChanged += new System.EventHandler(this.scan_CoBox_SelectedIndexChanged);
            // 
            // Scanner
            // 
            this.Scanner.AutoSize = true;
            this.Scanner.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scanner.Location = new System.Drawing.Point(13, 84);
            this.Scanner.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Scanner.Name = "Scanner";
            this.Scanner.Size = new System.Drawing.Size(79, 20);
            this.Scanner.TabIndex = 0;
            this.Scanner.Text = "Scanner";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "HN";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.Search_request_info_btn);
            this.groupBox1.Controls.Add(this.todayDatePicker);
            this.groupBox1.Controls.Add(this.reqCob);
            this.groupBox1.Controls.Add(this.insuCob);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.InsuranceCob);
            this.groupBox1.Controls.Add(this.scan_CoBox);
            this.groupBox1.Controls.Add(this.paidCob);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Scanner);
            this.groupBox1.Controls.Add(this.statusCob);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(499, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(681, 199);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Request Information";
            // 
            // Search_request_info_btn
            // 
            this.Search_request_info_btn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_request_info_btn.Location = new System.Drawing.Point(9, 31);
            this.Search_request_info_btn.Name = "Search_request_info_btn";
            this.Search_request_info_btn.Size = new System.Drawing.Size(83, 37);
            this.Search_request_info_btn.TabIndex = 19;
            this.Search_request_info_btn.Text = "Search";
            this.Search_request_info_btn.UseVisualStyleBackColor = true;
            this.Search_request_info_btn.Click += new System.EventHandler(this.Search_request_info_btn_Click);
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
            this.todayDatePicker.Size = new System.Drawing.Size(241, 27);
            this.todayDatePicker.TabIndex = 18;
            this.todayDatePicker.Value = new System.DateTime(2018, 1, 5, 0, 0, 0, 0);
            this.todayDatePicker.ValueChanged += new System.EventHandler(this.todayDatePicker_ValueChanged);
            // 
            // insuCob
            // 
            this.insuCob.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insuCob.FormattingEnabled = true;
            this.insuCob.Items.AddRange(new object[] {
            "yes",
            "no"});
            this.insuCob.Location = new System.Drawing.Point(461, 128);
            this.insuCob.Margin = new System.Windows.Forms.Padding(4);
            this.insuCob.Name = "insuCob";
            this.insuCob.Size = new System.Drawing.Size(184, 26);
            this.insuCob.TabIndex = 14;
            // 
            // InsuranceCob
            // 
            this.InsuranceCob.AutoSize = true;
            this.InsuranceCob.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsuranceCob.Location = new System.Drawing.Point(356, 132);
            this.InsuranceCob.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.InsuranceCob.Name = "InsuranceCob";
            this.InsuranceCob.Size = new System.Drawing.Size(95, 20);
            this.InsuranceCob.TabIndex = 13;
            this.InsuranceCob.Text = "Insurance";
            // 
            // paidCob
            // 
            this.paidCob.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paidCob.FormattingEnabled = true;
            this.paidCob.Items.AddRange(new object[] {
            "VIP",
            "Seepat",
            "GMC",
            "Elective"});
            this.paidCob.Location = new System.Drawing.Point(461, 32);
            this.paidCob.Margin = new System.Windows.Forms.Padding(4);
            this.paidCob.Name = "paidCob";
            this.paidCob.Size = new System.Drawing.Size(184, 26);
            this.paidCob.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(407, 36);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Paid";
            // 
            // statusCob
            // 
            this.statusCob.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusCob.FormattingEnabled = true;
            this.statusCob.Items.AddRange(new object[] {
            "Emergency",
            "RPD",
            "OPD"});
            this.statusCob.Location = new System.Drawing.Point(461, 79);
            this.statusCob.Margin = new System.Windows.Forms.Padding(4);
            this.statusCob.Name = "statusCob";
            this.statusCob.Size = new System.Drawing.Size(184, 26);
            this.statusCob.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(384, 82);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Status";
            // 
            // birthDatePicker
            // 
            this.birthDatePicker.CalendarFont = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthDatePicker.Enabled = false;
            this.birthDatePicker.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birthDatePicker.Location = new System.Drawing.Point(75, 119);
            this.birthDatePicker.Margin = new System.Windows.Forms.Padding(4);
            this.birthDatePicker.MaxDate = new System.DateTime(2019, 12, 31, 0, 0, 0, 0);
            this.birthDatePicker.MinDate = new System.DateTime(1900, 12, 31, 0, 0, 0, 0);
            this.birthDatePicker.Name = "birthDatePicker";
            this.birthDatePicker.Size = new System.Drawing.Size(243, 27);
            this.birthDatePicker.TabIndex = 21;
            this.birthDatePicker.Value = new System.DateTime(2018, 1, 5, 0, 0, 0, 0);
            // 
            // seachPaBtn
            // 
            this.seachPaBtn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seachPaBtn.Location = new System.Drawing.Point(391, 28);
            this.seachPaBtn.Margin = new System.Windows.Forms.Padding(4);
            this.seachPaBtn.Name = "seachPaBtn";
            this.seachPaBtn.Size = new System.Drawing.Size(84, 37);
            this.seachPaBtn.TabIndex = 20;
            this.seachPaBtn.Text = "Seach";
            this.seachPaBtn.UseVisualStyleBackColor = true;
            this.seachPaBtn.Click += new System.EventHandler(this.seachPaBtn_Click);
            // 
            // HNtxt
            // 
            this.HNtxt.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HNtxt.Location = new System.Drawing.Point(75, 33);
            this.HNtxt.Margin = new System.Windows.Forms.Padding(4);
            this.HNtxt.Name = "HNtxt";
            this.HNtxt.Size = new System.Drawing.Size(307, 27);
            this.HNtxt.TabIndex = 5;
            // 
            // addBtn
            // 
            this.addBtn.Enabled = false;
            this.addBtn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(1188, 31);
            this.addBtn.Margin = new System.Windows.Forms.Padding(4);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(137, 37);
            this.addBtn.TabIndex = 3;
            this.addBtn.Text = "Add ";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(1188, 153);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(4);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(137, 37);
            this.deleteBtn.TabIndex = 4;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 235);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1525, 241);
            this.dataGridView2.TabIndex = 20;
            this.dataGridView2.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView2_RowHeaderMouseDoubleClick);
            // 
            // todayAppointmentBindingSource
            // 
            this.todayAppointmentBindingSource.DataMember = "TodayAppointment";
            this.todayAppointmentBindingSource.DataSource = this.database1DataSetBindingSource;
            // 
            // editBtn
            // 
            this.editBtn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBtn.Location = new System.Drawing.Point(1188, 91);
            this.editBtn.Margin = new System.Windows.Forms.Padding(4);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(137, 37);
            this.editBtn.TabIndex = 21;
            this.editBtn.Text = "Update";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
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
            this.groupBox2.Location = new System.Drawing.Point(8, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(483, 199);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Patient Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Birth";
            // 
            // lnameTxt
            // 
            this.lnameTxt.Enabled = false;
            this.lnameTxt.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnameTxt.Location = new System.Drawing.Point(271, 75);
            this.lnameTxt.Margin = new System.Windows.Forms.Padding(4);
            this.lnameTxt.Name = "lnameTxt";
            this.lnameTxt.Size = new System.Drawing.Size(203, 27);
            this.lnameTxt.TabIndex = 17;
            // 
            // ageTxt
            // 
            this.ageTxt.Enabled = false;
            this.ageTxt.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageTxt.Location = new System.Drawing.Point(75, 155);
            this.ageTxt.Margin = new System.Windows.Forms.Padding(4);
            this.ageTxt.Name = "ageTxt";
            this.ageTxt.Size = new System.Drawing.Size(243, 27);
            this.ageTxt.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 164);
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
            this.nameTxt.Location = new System.Drawing.Point(75, 75);
            this.nameTxt.Margin = new System.Windows.Forms.Padding(4);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(187, 27);
            this.nameTxt.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(8, 79);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 20);
            this.label12.TabIndex = 2;
            this.label12.Text = "Name";
            // 
            // appointmentsBindingSource
            // 
            this.appointmentsBindingSource.DataMember = "Appointments";
            this.appointmentsBindingSource.DataSource = this.database1DataSet;
            // 
            // appointmentsTableAdapter
            // 
            this.appointmentsTableAdapter.ClearBeforeFill = true;
            // 
            // todayAppointmentTableAdapter
            // 
            this.todayAppointmentTableAdapter.ClearBeforeFill = true;
            // 
            // edit_cond_req_btn
            // 
            this.edit_cond_req_btn.Location = new System.Drawing.Point(1368, 31);
            this.edit_cond_req_btn.Name = "edit_cond_req_btn";
            this.edit_cond_req_btn.Size = new System.Drawing.Size(132, 54);
            this.edit_cond_req_btn.TabIndex = 22;
            this.edit_cond_req_btn.Text = "Edit Condition Request";
            this.edit_cond_req_btn.UseVisualStyleBackColor = true;
            this.edit_cond_req_btn.Click += new System.EventHandler(this.edit_cond_req_btn_Click);
            // 
            // edit_requests_btn
            // 
            this.edit_requests_btn.Location = new System.Drawing.Point(1368, 134);
            this.edit_requests_btn.Name = "edit_requests_btn";
            this.edit_requests_btn.Size = new System.Drawing.Size(132, 51);
            this.edit_requests_btn.TabIndex = 23;
            this.edit_requests_btn.Text = "Edit Requests";
            this.edit_requests_btn.UseVisualStyleBackColor = true;
            this.edit_requests_btn.Click += new System.EventHandler(this.edit_requests_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1528, 750);
            this.Controls.Add(this.edit_requests_btn);
            this.Controls.Add(this.edit_cond_req_btn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.todayAppointmentBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox reqCob;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox scan_CoBox;
        private System.Windows.Forms.Label Scanner;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox insuCob;
        private System.Windows.Forms.Label InsuranceCob;
        private System.Windows.Forms.ComboBox paidCob;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox statusCob;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox HNtxt;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button deleteBtn;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource appointmentsBindingSource;
        private Database1DataSetTableAdapters.AppointmentsTableAdapter appointmentsTableAdapter;
        private System.Windows.Forms.BindingSource database1DataSetBindingSource;
        private System.Windows.Forms.DateTimePicker todayDatePicker;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource todayAppointmentBindingSource;
        private Database1DataSetTableAdapters.TodayAppointmentTableAdapter todayAppointmentTableAdapter;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apageDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource appointmentsBindingSource1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox ageTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox lnameTxt;
        private System.Windows.Forms.Button seachPaBtn;
        private System.Windows.Forms.DateTimePicker birthDatePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn apIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appiorityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apstartTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apduraTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appatientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aprequestDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appatientstatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ap_insu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ap_scan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ap_scannum;
        private System.Windows.Forms.Button Search_request_info_btn;
        private System.Windows.Forms.Button edit_cond_req_btn;
        private System.Windows.Forms.Button edit_requests_btn;
    }
}

