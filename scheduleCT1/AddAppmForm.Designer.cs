namespace scheduleCT1
{
    partial class AddAppmForm
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
            this.ApmSaveBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPatient = new System.Windows.Forms.TextBox();
            this.ptSearchBtn = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateApm = new System.Windows.Forms.DateTimePicker();
            this.txtDoctor = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtOrgan = new System.Windows.Forms.TextBox();
            this.txtScan = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.dateTimePicker5 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker6 = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.dateTimePicker9 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker10 = new System.Windows.Forms.DateTimePicker();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.helpSeachBtn = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.appointmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appointmentDatabaseDataSet = new scheduleCT1.AppointmentDatabaseDataSet();
            this.appointmentsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.appointmentsTableAdapter = new scheduleCT1.AppointmentDatabaseDataSetTableAdapters.AppointmentsTableAdapter();
            this.apmIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apmdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apmscannerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apmpatientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apmorganDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apmdoctorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // ApmSaveBtn
            // 
            this.ApmSaveBtn.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApmSaveBtn.Location = new System.Drawing.Point(108, 249);
            this.ApmSaveBtn.Name = "ApmSaveBtn";
            this.ApmSaveBtn.Size = new System.Drawing.Size(61, 26);
            this.ApmSaveBtn.TabIndex = 0;
            this.ApmSaveBtn.Text = "บันทึก";
            this.ApmSaveBtn.UseVisualStyleBackColor = true;
            this.ApmSaveBtn.Click += new System.EventHandler(this.ApmSaveBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "HN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPatient
            // 
            this.txtPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatient.Location = new System.Drawing.Point(90, 25);
            this.txtPatient.Name = "txtPatient";
            this.txtPatient.Size = new System.Drawing.Size(153, 24);
            this.txtPatient.TabIndex = 2;
            // 
            // ptSearchBtn
            // 
            this.ptSearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ptSearchBtn.Location = new System.Drawing.Point(249, 25);
            this.ptSearchBtn.Name = "ptSearchBtn";
            this.ptSearchBtn.Size = new System.Drawing.Size(28, 25);
            this.ptSearchBtn.TabIndex = 3;
            this.ptSearchBtn.Text = "....";
            this.ptSearchBtn.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(90, 56);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(384, 24);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "  ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(321, 26);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(153, 24);
            this.textBox3.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(295, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "ID";
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(90, 86);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(384, 24);
            this.textBox4.TabIndex = 9;
            this.textBox4.Text = "  ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Eng Name";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Status";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox6
            // 
            this.textBox6.Enabled = false;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(321, 116);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(153, 24);
            this.textBox6.TabIndex = 13;
            this.textBox6.Text = "             ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(266, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "Phone";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.textBox14);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textBox11);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ptSearchBtn);
            this.groupBox1.Controls.Add(this.txtPatient);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(726, 160);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ข้อมูลผู้ป่วย";
            // 
            // comboBox3
            // 
            this.comboBox3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(90, 116);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(153, 26);
            this.comboBox3.TabIndex = 23;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(558, 84);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(153, 26);
            this.comboBox2.TabIndex = 22;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(558, 23);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(153, 26);
            this.comboBox1.TabIndex = 16;
            // 
            // textBox14
            // 
            this.textBox14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox14.Location = new System.Drawing.Point(558, 116);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(153, 24);
            this.textBox14.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(510, 119);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 18);
            this.label11.TabIndex = 20;
            this.label11.Text = "LMP";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(495, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 18);
            this.label10.TabIndex = 18;
            this.label10.Text = "Gender";
            // 
            // textBox11
            // 
            this.textBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox11.Location = new System.Drawing.Point(558, 55);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(153, 24);
            this.textBox11.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(519, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 18);
            this.label9.TabIndex = 16;
            this.label9.Text = "Age";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(480, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "Insurance";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.dateTimePicker2);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.dateApm);
            this.groupBox2.Controls.Add(this.txtDoctor);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.txtOrgan);
            this.groupBox2.Controls.Add(this.txtScan);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.ApmSaveBtn);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(744, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 282);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "รายการนัดหมายที่เลือก";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Enabled = false;
            this.dateTimePicker2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Location = new System.Drawing.Point(55, 142);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(154, 22);
            this.dateTimePicker2.TabIndex = 33;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(55, 114);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(154, 22);
            this.dateTimePicker1.TabIndex = 32;
            // 
            // dateApm
            // 
            this.dateApm.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateApm.Location = new System.Drawing.Point(55, 87);
            this.dateApm.Name = "dateApm";
            this.dateApm.Size = new System.Drawing.Size(156, 21);
            this.dateApm.TabIndex = 31;
            // 
            // txtDoctor
            // 
            this.txtDoctor.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtDoctor.Enabled = false;
            this.txtDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoctor.Location = new System.Drawing.Point(16, 205);
            this.txtDoctor.Name = "txtDoctor";
            this.txtDoctor.Size = new System.Drawing.Size(153, 24);
            this.txtDoctor.TabIndex = 27;
            this.txtDoctor.Text = "             ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(13, 184);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(108, 18);
            this.label17.TabIndex = 26;
            this.label17.Text = "แพทย์ผู้ออกใบนัด";
            // 
            // txtOrgan
            // 
            this.txtOrgan.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtOrgan.Enabled = false;
            this.txtOrgan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrgan.Location = new System.Drawing.Point(55, 57);
            this.txtOrgan.Name = "txtOrgan";
            this.txtOrgan.Size = new System.Drawing.Size(178, 24);
            this.txtOrgan.TabIndex = 25;
            this.txtOrgan.Text = "             ";
            // 
            // txtScan
            // 
            this.txtScan.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtScan.Enabled = false;
            this.txtScan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScan.Location = new System.Drawing.Point(55, 27);
            this.txtScan.Name = "txtScan";
            this.txtScan.Size = new System.Drawing.Size(178, 24);
            this.txtScan.TabIndex = 24;
            this.txtScan.Text = "             ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(19, 150);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(22, 18);
            this.label15.TabIndex = 20;
            this.label15.Text = "ถึง";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(10, 120);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 18);
            this.label12.TabIndex = 19;
            this.label12.Text = "ตั้งแต่";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(10, 60);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(32, 18);
            this.label19.TabIndex = 19;
            this.label19.Text = "ส่วน";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 18);
            this.label8.TabIndex = 1;
            this.label8.Text = "วันที่";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(8, 30);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(41, 18);
            this.label20.TabIndex = 17;
            this.label20.Text = "เครื่อง";
            // 
            // dateTimePicker5
            // 
            this.dateTimePicker5.Enabled = false;
            this.dateTimePicker5.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker5.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker5.Location = new System.Drawing.Point(413, 12);
            this.dateTimePicker5.Name = "dateTimePicker5";
            this.dateTimePicker5.Size = new System.Drawing.Size(154, 26);
            this.dateTimePicker5.TabIndex = 20;
            // 
            // dateTimePicker6
            // 
            this.dateTimePicker6.CalendarFont = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker6.CalendarTitleBackColor = System.Drawing.SystemColors.ButtonFace;
            this.dateTimePicker6.Enabled = false;
            this.dateTimePicker6.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker6.Location = new System.Drawing.Point(97, 12);
            this.dateTimePicker6.Name = "dateTimePicker6";
            this.dateTimePicker6.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker6.TabIndex = 19;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(14, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 18);
            this.label13.TabIndex = 24;
            this.label13.Text = "วันออกใบนัด";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Enabled = false;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(14, 45);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 18);
            this.label14.TabIndex = 24;
            this.label14.Text = "ผู้ออกใบนัด";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox5
            // 
            this.textBox5.Enabled = false;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(97, 45);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(317, 26);
            this.textBox5.TabIndex = 25;
            this.textBox5.Text = "  ";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.groupBox3.Controls.Add(this.comboBox5);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.comboBox4);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.panel1);
            this.groupBox3.Controls.Add(this.dateTimePicker9);
            this.groupBox3.Controls.Add(this.dateTimePicker10);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.helpSeachBtn);
            this.groupBox3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 265);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(517, 121);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ระบบข่วยค้นหาวันนัดหมาย";
            // 
            // comboBox5
            // 
            this.comboBox5.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(55, 58);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(113, 26);
            this.comboBox5.TabIndex = 31;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(9, 61);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(32, 18);
            this.label23.TabIndex = 28;
            this.label23.Text = "ส่วน";
            // 
            // comboBox4
            // 
            this.comboBox4.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(55, 28);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(113, 26);
            this.comboBox4.TabIndex = 24;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(8, 31);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(41, 18);
            this.label18.TabIndex = 30;
            this.label18.Text = "เครื่อง";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Location = new System.Drawing.Point(424, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(80, 84);
            this.panel1.TabIndex = 29;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(3, 59);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(74, 22);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "นัดพิเศษ";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(3, 31);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(66, 22);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "นัดบ่าย";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(3, 3);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(64, 22);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "นัดเช้า";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker9
            // 
            this.dateTimePicker9.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker9.Location = new System.Drawing.Point(258, 61);
            this.dateTimePicker9.Name = "dateTimePicker9";
            this.dateTimePicker9.Size = new System.Drawing.Size(156, 21);
            this.dateTimePicker9.TabIndex = 28;
            // 
            // dateTimePicker10
            // 
            this.dateTimePicker10.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker10.Location = new System.Drawing.Point(258, 29);
            this.dateTimePicker10.Name = "dateTimePicker10";
            this.dateTimePicker10.Size = new System.Drawing.Size(156, 21);
            this.dateTimePicker10.TabIndex = 26;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(181, 32);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(76, 18);
            this.label21.TabIndex = 24;
            this.label21.Text = "Start Time";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Enabled = false;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(181, 64);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(71, 18);
            this.label22.TabIndex = 25;
            this.label22.Text = "End Time";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // helpSeachBtn
            // 
            this.helpSeachBtn.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpSeachBtn.Location = new System.Drawing.Point(238, 89);
            this.helpSeachBtn.Name = "helpSeachBtn";
            this.helpSeachBtn.Size = new System.Drawing.Size(55, 26);
            this.helpSeachBtn.TabIndex = 23;
            this.helpSeachBtn.Text = "ค้นหา";
            this.helpSeachBtn.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(320, 12);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(87, 18);
            this.label16.TabIndex = 27;
            this.label16.Text = "เวลาออกใบนัด";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.apmIdDataGridViewTextBoxColumn,
            this.apmdateDataGridViewTextBoxColumn,
            this.apmscannerDataGridViewTextBoxColumn,
            this.apmpatientDataGridViewTextBoxColumn,
            this.apmorganDataGridViewTextBoxColumn,
            this.apmdoctorDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.appointmentsBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 401);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(653, 145);
            this.dataGridView1.TabIndex = 28;
            // 
            // appointmentsBindingSource
            // 
            this.appointmentsBindingSource.DataMember = "Appointments";
            this.appointmentsBindingSource.DataSource = this.appointmentDatabaseDataSet;
            // 
            // appointmentDatabaseDataSet
            // 
            this.appointmentDatabaseDataSet.DataSetName = "AppointmentDatabaseDataSet";
            this.appointmentDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // appointmentsBindingSource1
            // 
            this.appointmentsBindingSource1.DataMember = "Appointments";
            this.appointmentsBindingSource1.DataSource = this.appointmentDatabaseDataSet;
            // 
            // appointmentsTableAdapter
            // 
            this.appointmentsTableAdapter.ClearBeforeFill = true;
            // 
            // apmIdDataGridViewTextBoxColumn
            // 
            this.apmIdDataGridViewTextBoxColumn.DataPropertyName = "Apm_Id";
            this.apmIdDataGridViewTextBoxColumn.HeaderText = "Apm_Id";
            this.apmIdDataGridViewTextBoxColumn.Name = "apmIdDataGridViewTextBoxColumn";
            this.apmIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apmdateDataGridViewTextBoxColumn
            // 
            this.apmdateDataGridViewTextBoxColumn.DataPropertyName = "Apm_date";
            this.apmdateDataGridViewTextBoxColumn.HeaderText = "Apm_date";
            this.apmdateDataGridViewTextBoxColumn.Name = "apmdateDataGridViewTextBoxColumn";
            // 
            // apmscannerDataGridViewTextBoxColumn
            // 
            this.apmscannerDataGridViewTextBoxColumn.DataPropertyName = "Apm_scanner";
            this.apmscannerDataGridViewTextBoxColumn.HeaderText = "Apm_scanner";
            this.apmscannerDataGridViewTextBoxColumn.Name = "apmscannerDataGridViewTextBoxColumn";
            // 
            // apmpatientDataGridViewTextBoxColumn
            // 
            this.apmpatientDataGridViewTextBoxColumn.DataPropertyName = "Apm_patient";
            this.apmpatientDataGridViewTextBoxColumn.HeaderText = "Apm_patient";
            this.apmpatientDataGridViewTextBoxColumn.Name = "apmpatientDataGridViewTextBoxColumn";
            // 
            // apmorganDataGridViewTextBoxColumn
            // 
            this.apmorganDataGridViewTextBoxColumn.DataPropertyName = "Apm_organ";
            this.apmorganDataGridViewTextBoxColumn.HeaderText = "Apm_organ";
            this.apmorganDataGridViewTextBoxColumn.Name = "apmorganDataGridViewTextBoxColumn";
            // 
            // apmdoctorDataGridViewTextBoxColumn
            // 
            this.apmdoctorDataGridViewTextBoxColumn.DataPropertyName = "Apm_doctor";
            this.apmdoctorDataGridViewTextBoxColumn.HeaderText = "Apm_doctor";
            this.apmdoctorDataGridViewTextBoxColumn.Name = "apmdoctorDataGridViewTextBoxColumn";
            // 
            // AddAppmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 558);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.dateTimePicker5);
            this.Controls.Add(this.dateTimePicker6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddAppmForm";
            this.Text = "AddAppmForm";
            this.Load += new System.EventHandler(this.AddAppmForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ApmSaveBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPatient;
        private System.Windows.Forms.Button ptSearchBtn;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker5;
        private System.Windows.Forms.DateTimePicker dateTimePicker6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button helpSeachBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.DateTimePicker dateTimePicker9;
        private System.Windows.Forms.DateTimePicker dateTimePicker10;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtDoctor;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtOrgan;
        private System.Windows.Forms.TextBox txtScan;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataGridView dataGridView1;
        private AppointmentDatabaseDataSet appointmentDatabaseDataSet;
        private System.Windows.Forms.BindingSource appointmentsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn apmpateintDataGridViewTextBoxColumn;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateApm;
        private System.Windows.Forms.BindingSource appointmentsBindingSource1;
        private AppointmentDatabaseDataSetTableAdapters.AppointmentsTableAdapter appointmentsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn apmIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apmdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apmscannerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apmpatientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apmorganDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apmdoctorDataGridViewTextBoxColumn;
    }
}