namespace AppointmentQueue
{
    partial class CalendarForm
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CalendarPanel = new System.Windows.Forms.TableLayoutPanel();
            this.sunday_btn = new System.Windows.Forms.Button();
            this.monday_btn = new System.Windows.Forms.Button();
            this.tuesday_btn = new System.Windows.Forms.Button();
            this.wednesday_btn = new System.Windows.Forms.Button();
            this.thrusday_btn = new System.Windows.Forms.Button();
            this.friday_btn = new System.Windows.Forms.Button();
            this.saturday_btn = new System.Windows.Forms.Button();
            this.day_0_0_btn = new System.Windows.Forms.Button();
            this.day_0_1_btn = new System.Windows.Forms.Button();
            this.day_0_2_btn = new System.Windows.Forms.Button();
            this.day_0_3_btn = new System.Windows.Forms.Button();
            this.day_0_4_btn = new System.Windows.Forms.Button();
            this.day_0_5_btn = new System.Windows.Forms.Button();
            this.day_0_6_btn = new System.Windows.Forms.Button();
            this.day_1_2_btn = new System.Windows.Forms.Button();
            this.day_1_0_btn = new System.Windows.Forms.Button();
            this.day_1_1_btn = new System.Windows.Forms.Button();
            this.day_1_3_btn = new System.Windows.Forms.Button();
            this.day_1_4_btn = new System.Windows.Forms.Button();
            this.day_1_5_btn = new System.Windows.Forms.Button();
            this.day_1_6_btn = new System.Windows.Forms.Button();
            this.day_2_0_btn = new System.Windows.Forms.Button();
            this.day_2_1_btn = new System.Windows.Forms.Button();
            this.day_2_2_btn = new System.Windows.Forms.Button();
            this.day_2_3_btn = new System.Windows.Forms.Button();
            this.day_2_4_btn = new System.Windows.Forms.Button();
            this.day_2_5_btn = new System.Windows.Forms.Button();
            this.day_2_6_btn = new System.Windows.Forms.Button();
            this.day_3_0_btn = new System.Windows.Forms.Button();
            this.day_3_3_btn = new System.Windows.Forms.Button();
            this.day_3_2_btn = new System.Windows.Forms.Button();
            this.day_3_1_btn = new System.Windows.Forms.Button();
            this.day_3_4_btn = new System.Windows.Forms.Button();
            this.day_3_5_btn = new System.Windows.Forms.Button();
            this.day_3_6_btn = new System.Windows.Forms.Button();
            this.day_4_0_btn = new System.Windows.Forms.Button();
            this.day_4_1_btn = new System.Windows.Forms.Button();
            this.day_4_2_btn = new System.Windows.Forms.Button();
            this.day_4_4_btn = new System.Windows.Forms.Button();
            this.day_4_3_btn = new System.Windows.Forms.Button();
            this.day_4_5_btn = new System.Windows.Forms.Button();
            this.day_4_6_btn = new System.Windows.Forms.Button();
            this.day_5_2_btn = new System.Windows.Forms.Button();
            this.day_5_4_btn = new System.Windows.Forms.Button();
            this.day_5_1_btn = new System.Windows.Forms.Button();
            this.day_5_0_btn = new System.Windows.Forms.Button();
            this.day_5_3_btn = new System.Windows.Forms.Button();
            this.day_5_5_btn = new System.Windows.Forms.Button();
            this.day_5_6_btn = new System.Windows.Forms.Button();
            this.next_month_btn = new System.Windows.Forms.Button();
            this.prev_month_btn = new System.Windows.Forms.Button();
            this.month_btn = new System.Windows.Forms.Button();
            this.year_btn = new System.Windows.Forms.Button();
            this.today_show_btn = new System.Windows.Forms.Button();
            this.today_text_btn = new System.Windows.Forms.Button();
            this.today_date_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.CalendarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthCalendar1.Location = new System.Drawing.Point(27, 9);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            this.monthCalendar1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.monthCalendar1_MouseMove);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.monthCalendar1);
            this.panel1.Location = new System.Drawing.Point(12, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 233);
            this.panel1.TabIndex = 1;
            // 
            // CalendarPanel
            // 
            this.CalendarPanel.BackColor = System.Drawing.SystemColors.Control;
            this.CalendarPanel.ColumnCount = 7;
            this.CalendarPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.CalendarPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.CalendarPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.CalendarPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.CalendarPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.CalendarPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.CalendarPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28816F));
            this.CalendarPanel.Controls.Add(this.sunday_btn, 0, 1);
            this.CalendarPanel.Controls.Add(this.monday_btn, 1, 1);
            this.CalendarPanel.Controls.Add(this.tuesday_btn, 2, 1);
            this.CalendarPanel.Controls.Add(this.wednesday_btn, 3, 1);
            this.CalendarPanel.Controls.Add(this.thrusday_btn, 4, 1);
            this.CalendarPanel.Controls.Add(this.friday_btn, 5, 1);
            this.CalendarPanel.Controls.Add(this.saturday_btn, 6, 1);
            this.CalendarPanel.Controls.Add(this.day_0_0_btn, 0, 2);
            this.CalendarPanel.Controls.Add(this.day_0_1_btn, 1, 2);
            this.CalendarPanel.Controls.Add(this.day_0_2_btn, 2, 2);
            this.CalendarPanel.Controls.Add(this.day_0_3_btn, 3, 2);
            this.CalendarPanel.Controls.Add(this.day_0_4_btn, 4, 2);
            this.CalendarPanel.Controls.Add(this.day_0_5_btn, 5, 2);
            this.CalendarPanel.Controls.Add(this.day_0_6_btn, 6, 2);
            this.CalendarPanel.Controls.Add(this.day_1_2_btn, 2, 3);
            this.CalendarPanel.Controls.Add(this.day_1_0_btn, 0, 3);
            this.CalendarPanel.Controls.Add(this.day_1_1_btn, 1, 3);
            this.CalendarPanel.Controls.Add(this.day_1_3_btn, 3, 3);
            this.CalendarPanel.Controls.Add(this.day_1_4_btn, 4, 3);
            this.CalendarPanel.Controls.Add(this.day_1_5_btn, 5, 3);
            this.CalendarPanel.Controls.Add(this.day_1_6_btn, 6, 3);
            this.CalendarPanel.Controls.Add(this.day_2_0_btn, 0, 4);
            this.CalendarPanel.Controls.Add(this.day_2_1_btn, 1, 4);
            this.CalendarPanel.Controls.Add(this.day_2_2_btn, 2, 4);
            this.CalendarPanel.Controls.Add(this.day_2_3_btn, 3, 4);
            this.CalendarPanel.Controls.Add(this.day_2_4_btn, 4, 4);
            this.CalendarPanel.Controls.Add(this.day_2_5_btn, 5, 4);
            this.CalendarPanel.Controls.Add(this.day_2_6_btn, 6, 4);
            this.CalendarPanel.Controls.Add(this.day_3_0_btn, 0, 5);
            this.CalendarPanel.Controls.Add(this.day_3_3_btn, 3, 5);
            this.CalendarPanel.Controls.Add(this.day_3_2_btn, 2, 5);
            this.CalendarPanel.Controls.Add(this.day_3_1_btn, 1, 5);
            this.CalendarPanel.Controls.Add(this.day_3_4_btn, 4, 5);
            this.CalendarPanel.Controls.Add(this.day_3_5_btn, 5, 5);
            this.CalendarPanel.Controls.Add(this.day_3_6_btn, 6, 5);
            this.CalendarPanel.Controls.Add(this.day_4_0_btn, 0, 6);
            this.CalendarPanel.Controls.Add(this.day_4_1_btn, 1, 6);
            this.CalendarPanel.Controls.Add(this.day_4_2_btn, 2, 6);
            this.CalendarPanel.Controls.Add(this.day_4_4_btn, 4, 6);
            this.CalendarPanel.Controls.Add(this.day_4_3_btn, 3, 6);
            this.CalendarPanel.Controls.Add(this.day_4_5_btn, 5, 6);
            this.CalendarPanel.Controls.Add(this.day_4_6_btn, 6, 6);
            this.CalendarPanel.Controls.Add(this.day_5_2_btn, 2, 7);
            this.CalendarPanel.Controls.Add(this.day_5_4_btn, 4, 7);
            this.CalendarPanel.Controls.Add(this.day_5_1_btn, 1, 7);
            this.CalendarPanel.Controls.Add(this.day_5_0_btn, 0, 7);
            this.CalendarPanel.Controls.Add(this.day_5_3_btn, 3, 7);
            this.CalendarPanel.Controls.Add(this.day_5_5_btn, 5, 7);
            this.CalendarPanel.Controls.Add(this.day_5_6_btn, 6, 7);
            this.CalendarPanel.Controls.Add(this.next_month_btn, 6, 0);
            this.CalendarPanel.Controls.Add(this.prev_month_btn, 0, 0);
            this.CalendarPanel.Controls.Add(this.month_btn, 3, 0);
            this.CalendarPanel.Controls.Add(this.year_btn, 4, 0);
            this.CalendarPanel.Controls.Add(this.today_show_btn, 2, 8);
            this.CalendarPanel.Controls.Add(this.today_text_btn, 3, 8);
            this.CalendarPanel.Controls.Add(this.today_date_btn, 4, 8);
            this.CalendarPanel.ForeColor = System.Drawing.Color.Black;
            this.CalendarPanel.Location = new System.Drawing.Point(76, 289);
            this.CalendarPanel.Name = "CalendarPanel";
            this.CalendarPanel.RowCount = 9;
            this.CalendarPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.803922F));
            this.CalendarPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.0098F));
            this.CalendarPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11037F));
            this.CalendarPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11037F));
            this.CalendarPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11037F));
            this.CalendarPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11037F));
            this.CalendarPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11259F));
            this.CalendarPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11259F));
            this.CalendarPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11259F));
            this.CalendarPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.CalendarPanel.Size = new System.Drawing.Size(794, 408);
            this.CalendarPanel.TabIndex = 2;
            // 
            // sunday_btn
            // 
            this.sunday_btn.BackColor = System.Drawing.Color.Transparent;
            this.sunday_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.sunday_btn.FlatAppearance.BorderSize = 0;
            this.sunday_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.sunday_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.sunday_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sunday_btn.Location = new System.Drawing.Point(3, 43);
            this.sunday_btn.Name = "sunday_btn";
            this.sunday_btn.Size = new System.Drawing.Size(107, 43);
            this.sunday_btn.TabIndex = 0;
            this.sunday_btn.Text = "Sunday";
            this.sunday_btn.UseVisualStyleBackColor = false;
            // 
            // monday_btn
            // 
            this.monday_btn.BackColor = System.Drawing.Color.Transparent;
            this.monday_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.monday_btn.FlatAppearance.BorderSize = 0;
            this.monday_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.monday_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.monday_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.monday_btn.Location = new System.Drawing.Point(116, 43);
            this.monday_btn.Name = "monday_btn";
            this.monday_btn.Size = new System.Drawing.Size(107, 43);
            this.monday_btn.TabIndex = 1;
            this.monday_btn.Text = "Monday";
            this.monday_btn.UseVisualStyleBackColor = false;
            // 
            // tuesday_btn
            // 
            this.tuesday_btn.BackColor = System.Drawing.Color.Transparent;
            this.tuesday_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.tuesday_btn.FlatAppearance.BorderSize = 0;
            this.tuesday_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.tuesday_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.tuesday_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tuesday_btn.Location = new System.Drawing.Point(229, 43);
            this.tuesday_btn.Name = "tuesday_btn";
            this.tuesday_btn.Size = new System.Drawing.Size(107, 43);
            this.tuesday_btn.TabIndex = 2;
            this.tuesday_btn.Text = "Tuesday";
            this.tuesday_btn.UseVisualStyleBackColor = false;
            // 
            // wednesday_btn
            // 
            this.wednesday_btn.BackColor = System.Drawing.Color.Transparent;
            this.wednesday_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.wednesday_btn.FlatAppearance.BorderSize = 0;
            this.wednesday_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.wednesday_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.wednesday_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wednesday_btn.Location = new System.Drawing.Point(342, 43);
            this.wednesday_btn.Name = "wednesday_btn";
            this.wednesday_btn.Size = new System.Drawing.Size(107, 43);
            this.wednesday_btn.TabIndex = 3;
            this.wednesday_btn.Text = "Wednesday";
            this.wednesday_btn.UseVisualStyleBackColor = false;
            // 
            // thrusday_btn
            // 
            this.thrusday_btn.BackColor = System.Drawing.Color.Transparent;
            this.thrusday_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.thrusday_btn.FlatAppearance.BorderSize = 0;
            this.thrusday_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.thrusday_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.thrusday_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.thrusday_btn.Location = new System.Drawing.Point(455, 43);
            this.thrusday_btn.Name = "thrusday_btn";
            this.thrusday_btn.Size = new System.Drawing.Size(107, 43);
            this.thrusday_btn.TabIndex = 4;
            this.thrusday_btn.Text = "Thrusday";
            this.thrusday_btn.UseVisualStyleBackColor = false;
            // 
            // friday_btn
            // 
            this.friday_btn.BackColor = System.Drawing.Color.Transparent;
            this.friday_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.friday_btn.FlatAppearance.BorderSize = 0;
            this.friday_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.friday_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.friday_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.friday_btn.Location = new System.Drawing.Point(568, 43);
            this.friday_btn.Name = "friday_btn";
            this.friday_btn.Size = new System.Drawing.Size(107, 43);
            this.friday_btn.TabIndex = 5;
            this.friday_btn.Text = "Friday";
            this.friday_btn.UseVisualStyleBackColor = false;
            // 
            // saturday_btn
            // 
            this.saturday_btn.BackColor = System.Drawing.Color.Transparent;
            this.saturday_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.saturday_btn.FlatAppearance.BorderSize = 0;
            this.saturday_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.saturday_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.saturday_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saturday_btn.Location = new System.Drawing.Point(681, 43);
            this.saturday_btn.Name = "saturday_btn";
            this.saturday_btn.Size = new System.Drawing.Size(107, 43);
            this.saturday_btn.TabIndex = 6;
            this.saturday_btn.Text = "Saturday";
            this.saturday_btn.UseVisualStyleBackColor = false;
            // 
            // day_0_0_btn
            // 
            this.day_0_0_btn.BackColor = System.Drawing.Color.Transparent;
            this.day_0_0_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.day_0_0_btn.FlatAppearance.BorderSize = 0;
            this.day_0_0_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.day_0_0_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.day_0_0_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.day_0_0_btn.Location = new System.Drawing.Point(3, 92);
            this.day_0_0_btn.Name = "day_0_0_btn";
            this.day_0_0_btn.Size = new System.Drawing.Size(107, 39);
            this.day_0_0_btn.TabIndex = 7;
            this.day_0_0_btn.Text = "r0c0";
            this.day_0_0_btn.UseVisualStyleBackColor = false;
            this.day_0_0_btn.Click += new System.EventHandler(this.DayClick);
            // 
            // day_0_1_btn
            // 
            this.day_0_1_btn.BackColor = System.Drawing.Color.Transparent;
            this.day_0_1_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.day_0_1_btn.FlatAppearance.BorderSize = 0;
            this.day_0_1_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.day_0_1_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.day_0_1_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.day_0_1_btn.Location = new System.Drawing.Point(116, 92);
            this.day_0_1_btn.Name = "day_0_1_btn";
            this.day_0_1_btn.Size = new System.Drawing.Size(107, 39);
            this.day_0_1_btn.TabIndex = 8;
            this.day_0_1_btn.Text = "r0c1";
            this.day_0_1_btn.UseVisualStyleBackColor = false;
            this.day_0_1_btn.Click += new System.EventHandler(this.DayClick);
            // 
            // day_0_2_btn
            // 
            this.day_0_2_btn.BackColor = System.Drawing.Color.Transparent;
            this.day_0_2_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.day_0_2_btn.FlatAppearance.BorderSize = 0;
            this.day_0_2_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.day_0_2_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.day_0_2_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.day_0_2_btn.Location = new System.Drawing.Point(229, 92);
            this.day_0_2_btn.Name = "day_0_2_btn";
            this.day_0_2_btn.Size = new System.Drawing.Size(107, 39);
            this.day_0_2_btn.TabIndex = 9;
            this.day_0_2_btn.Text = "r0c2";
            this.day_0_2_btn.UseVisualStyleBackColor = false;
            this.day_0_2_btn.Click += new System.EventHandler(this.DayClick);
            // 
            // day_0_3_btn
            // 
            this.day_0_3_btn.BackColor = System.Drawing.Color.Transparent;
            this.day_0_3_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.day_0_3_btn.FlatAppearance.BorderSize = 0;
            this.day_0_3_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.day_0_3_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.day_0_3_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.day_0_3_btn.Location = new System.Drawing.Point(342, 92);
            this.day_0_3_btn.Name = "day_0_3_btn";
            this.day_0_3_btn.Size = new System.Drawing.Size(107, 39);
            this.day_0_3_btn.TabIndex = 10;
            this.day_0_3_btn.Text = "r0c3";
            this.day_0_3_btn.UseVisualStyleBackColor = false;
            this.day_0_3_btn.Click += new System.EventHandler(this.DayClick);
            // 
            // day_0_4_btn
            // 
            this.day_0_4_btn.BackColor = System.Drawing.Color.Transparent;
            this.day_0_4_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.day_0_4_btn.FlatAppearance.BorderSize = 0;
            this.day_0_4_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.day_0_4_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.day_0_4_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.day_0_4_btn.Location = new System.Drawing.Point(455, 92);
            this.day_0_4_btn.Name = "day_0_4_btn";
            this.day_0_4_btn.Size = new System.Drawing.Size(107, 39);
            this.day_0_4_btn.TabIndex = 11;
            this.day_0_4_btn.Text = "r0c4";
            this.day_0_4_btn.UseVisualStyleBackColor = false;
            this.day_0_4_btn.Click += new System.EventHandler(this.DayClick);
            // 
            // day_0_5_btn
            // 
            this.day_0_5_btn.BackColor = System.Drawing.Color.Transparent;
            this.day_0_5_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.day_0_5_btn.FlatAppearance.BorderSize = 0;
            this.day_0_5_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.day_0_5_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.day_0_5_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.day_0_5_btn.Location = new System.Drawing.Point(568, 92);
            this.day_0_5_btn.Name = "day_0_5_btn";
            this.day_0_5_btn.Size = new System.Drawing.Size(107, 39);
            this.day_0_5_btn.TabIndex = 12;
            this.day_0_5_btn.Text = "r0c5";
            this.day_0_5_btn.UseVisualStyleBackColor = false;
            this.day_0_5_btn.Click += new System.EventHandler(this.DayClick);
            // 
            // day_0_6_btn
            // 
            this.day_0_6_btn.BackColor = System.Drawing.Color.Transparent;
            this.day_0_6_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.day_0_6_btn.FlatAppearance.BorderSize = 0;
            this.day_0_6_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.day_0_6_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.day_0_6_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.day_0_6_btn.Location = new System.Drawing.Point(681, 92);
            this.day_0_6_btn.Name = "day_0_6_btn";
            this.day_0_6_btn.Size = new System.Drawing.Size(107, 39);
            this.day_0_6_btn.TabIndex = 13;
            this.day_0_6_btn.Text = "r0c6";
            this.day_0_6_btn.UseVisualStyleBackColor = false;
            this.day_0_6_btn.Click += new System.EventHandler(this.DayClick);
            // 
            // day_1_2_btn
            // 
            this.day_1_2_btn.BackColor = System.Drawing.Color.Transparent;
            this.day_1_2_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.day_1_2_btn.FlatAppearance.BorderSize = 0;
            this.day_1_2_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.day_1_2_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.day_1_2_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.day_1_2_btn.Location = new System.Drawing.Point(229, 137);
            this.day_1_2_btn.Name = "day_1_2_btn";
            this.day_1_2_btn.Size = new System.Drawing.Size(107, 39);
            this.day_1_2_btn.TabIndex = 16;
            this.day_1_2_btn.Text = "r1c2";
            this.day_1_2_btn.UseVisualStyleBackColor = false;
            this.day_1_2_btn.Click += new System.EventHandler(this.DayClick);
            // 
            // day_1_0_btn
            // 
            this.day_1_0_btn.BackColor = System.Drawing.Color.Transparent;
            this.day_1_0_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.day_1_0_btn.FlatAppearance.BorderSize = 0;
            this.day_1_0_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.day_1_0_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.day_1_0_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.day_1_0_btn.Location = new System.Drawing.Point(3, 137);
            this.day_1_0_btn.Name = "day_1_0_btn";
            this.day_1_0_btn.Size = new System.Drawing.Size(107, 39);
            this.day_1_0_btn.TabIndex = 14;
            this.day_1_0_btn.Text = "r1c0";
            this.day_1_0_btn.UseVisualStyleBackColor = false;
            this.day_1_0_btn.Click += new System.EventHandler(this.DayClick);
            // 
            // day_1_1_btn
            // 
            this.day_1_1_btn.BackColor = System.Drawing.Color.Transparent;
            this.day_1_1_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.day_1_1_btn.FlatAppearance.BorderSize = 0;
            this.day_1_1_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.day_1_1_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.day_1_1_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.day_1_1_btn.Location = new System.Drawing.Point(116, 137);
            this.day_1_1_btn.Name = "day_1_1_btn";
            this.day_1_1_btn.Size = new System.Drawing.Size(107, 39);
            this.day_1_1_btn.TabIndex = 15;
            this.day_1_1_btn.Text = "r1c1";
            this.day_1_1_btn.UseVisualStyleBackColor = false;
            this.day_1_1_btn.Click += new System.EventHandler(this.DayClick);
            // 
            // day_1_3_btn
            // 
            this.day_1_3_btn.BackColor = System.Drawing.Color.Transparent;
            this.day_1_3_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.day_1_3_btn.FlatAppearance.BorderSize = 0;
            this.day_1_3_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.day_1_3_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.day_1_3_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.day_1_3_btn.Location = new System.Drawing.Point(342, 137);
            this.day_1_3_btn.Name = "day_1_3_btn";
            this.day_1_3_btn.Size = new System.Drawing.Size(107, 39);
            this.day_1_3_btn.TabIndex = 17;
            this.day_1_3_btn.Text = "r1c3";
            this.day_1_3_btn.UseVisualStyleBackColor = false;
            this.day_1_3_btn.Click += new System.EventHandler(this.DayClick);
            // 
            // day_1_4_btn
            // 
            this.day_1_4_btn.BackColor = System.Drawing.Color.Transparent;
            this.day_1_4_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.day_1_4_btn.FlatAppearance.BorderSize = 0;
            this.day_1_4_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.day_1_4_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.day_1_4_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.day_1_4_btn.Location = new System.Drawing.Point(455, 137);
            this.day_1_4_btn.Name = "day_1_4_btn";
            this.day_1_4_btn.Size = new System.Drawing.Size(107, 39);
            this.day_1_4_btn.TabIndex = 18;
            this.day_1_4_btn.Text = "r1c4";
            this.day_1_4_btn.UseVisualStyleBackColor = false;
            this.day_1_4_btn.Click += new System.EventHandler(this.DayClick);
            // 
            // day_1_5_btn
            // 
            this.day_1_5_btn.BackColor = System.Drawing.Color.Transparent;
            this.day_1_5_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.day_1_5_btn.FlatAppearance.BorderSize = 0;
            this.day_1_5_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.day_1_5_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.day_1_5_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.day_1_5_btn.Location = new System.Drawing.Point(568, 137);
            this.day_1_5_btn.Name = "day_1_5_btn";
            this.day_1_5_btn.Size = new System.Drawing.Size(107, 39);
            this.day_1_5_btn.TabIndex = 19;
            this.day_1_5_btn.Text = "r1c5";
            this.day_1_5_btn.UseVisualStyleBackColor = false;
            this.day_1_5_btn.Click += new System.EventHandler(this.DayClick);
            // 
            // day_1_6_btn
            // 
            this.day_1_6_btn.BackColor = System.Drawing.Color.Transparent;
            this.day_1_6_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.day_1_6_btn.FlatAppearance.BorderSize = 0;
            this.day_1_6_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.day_1_6_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.day_1_6_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.day_1_6_btn.Location = new System.Drawing.Point(681, 137);
            this.day_1_6_btn.Name = "day_1_6_btn";
            this.day_1_6_btn.Size = new System.Drawing.Size(107, 39);
            this.day_1_6_btn.TabIndex = 20;
            this.day_1_6_btn.Text = "r1c6";
            this.day_1_6_btn.UseVisualStyleBackColor = false;
            this.day_1_6_btn.Click += new System.EventHandler(this.DayClick);
            // 
            // day_2_0_btn
            // 
            this.day_2_0_btn.BackColor = System.Drawing.Color.Transparent;
            this.day_2_0_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.day_2_0_btn.FlatAppearance.BorderSize = 0;
            this.day_2_0_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.day_2_0_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.day_2_0_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.day_2_0_btn.Location = new System.Drawing.Point(3, 182);
            this.day_2_0_btn.Name = "day_2_0_btn";
            this.day_2_0_btn.Size = new System.Drawing.Size(107, 39);
            this.day_2_0_btn.TabIndex = 21;
            this.day_2_0_btn.Text = "r2c0";
            this.day_2_0_btn.UseVisualStyleBackColor = false;
            this.day_2_0_btn.Click += new System.EventHandler(this.DayClick);
            // 
            // day_2_1_btn
            // 
            this.day_2_1_btn.BackColor = System.Drawing.Color.Transparent;
            this.day_2_1_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.day_2_1_btn.FlatAppearance.BorderSize = 0;
            this.day_2_1_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.day_2_1_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.day_2_1_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.day_2_1_btn.Location = new System.Drawing.Point(116, 182);
            this.day_2_1_btn.Name = "day_2_1_btn";
            this.day_2_1_btn.Size = new System.Drawing.Size(107, 39);
            this.day_2_1_btn.TabIndex = 22;
            this.day_2_1_btn.Text = "r2c1";
            this.day_2_1_btn.UseVisualStyleBackColor = false;
            this.day_2_1_btn.Click += new System.EventHandler(this.DayClick);
            // 
            // day_2_2_btn
            // 
            this.day_2_2_btn.BackColor = System.Drawing.Color.Transparent;
            this.day_2_2_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.day_2_2_btn.FlatAppearance.BorderSize = 0;
            this.day_2_2_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.day_2_2_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.day_2_2_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.day_2_2_btn.Location = new System.Drawing.Point(229, 182);
            this.day_2_2_btn.Name = "day_2_2_btn";
            this.day_2_2_btn.Size = new System.Drawing.Size(107, 39);
            this.day_2_2_btn.TabIndex = 23;
            this.day_2_2_btn.Text = "r2c2";
            this.day_2_2_btn.UseVisualStyleBackColor = false;
            this.day_2_2_btn.Click += new System.EventHandler(this.DayClick);
            // 
            // day_2_3_btn
            // 
            this.day_2_3_btn.BackColor = System.Drawing.Color.Transparent;
            this.day_2_3_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.day_2_3_btn.FlatAppearance.BorderSize = 0;
            this.day_2_3_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.day_2_3_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.day_2_3_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.day_2_3_btn.Location = new System.Drawing.Point(342, 182);
            this.day_2_3_btn.Name = "day_2_3_btn";
            this.day_2_3_btn.Size = new System.Drawing.Size(107, 39);
            this.day_2_3_btn.TabIndex = 24;
            this.day_2_3_btn.Text = "r2c3";
            this.day_2_3_btn.UseVisualStyleBackColor = false;
            this.day_2_3_btn.Click += new System.EventHandler(this.DayClick);
            // 
            // day_2_4_btn
            // 
            this.day_2_4_btn.BackColor = System.Drawing.Color.Transparent;
            this.day_2_4_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.day_2_4_btn.FlatAppearance.BorderSize = 0;
            this.day_2_4_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.day_2_4_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.day_2_4_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.day_2_4_btn.Location = new System.Drawing.Point(455, 182);
            this.day_2_4_btn.Name = "day_2_4_btn";
            this.day_2_4_btn.Size = new System.Drawing.Size(107, 39);
            this.day_2_4_btn.TabIndex = 25;
            this.day_2_4_btn.Text = "r2c4";
            this.day_2_4_btn.UseVisualStyleBackColor = false;
            this.day_2_4_btn.Click += new System.EventHandler(this.DayClick);
            // 
            // day_2_5_btn
            // 
            this.day_2_5_btn.BackColor = System.Drawing.Color.Transparent;
            this.day_2_5_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.day_2_5_btn.FlatAppearance.BorderSize = 0;
            this.day_2_5_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.day_2_5_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.day_2_5_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.day_2_5_btn.Location = new System.Drawing.Point(568, 182);
            this.day_2_5_btn.Name = "day_2_5_btn";
            this.day_2_5_btn.Size = new System.Drawing.Size(107, 39);
            this.day_2_5_btn.TabIndex = 26;
            this.day_2_5_btn.Text = "r2c5";
            this.day_2_5_btn.UseVisualStyleBackColor = false;
            this.day_2_5_btn.Click += new System.EventHandler(this.DayClick);
            // 
            // day_2_6_btn
            // 
            this.day_2_6_btn.BackColor = System.Drawing.Color.Transparent;
            this.day_2_6_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.day_2_6_btn.FlatAppearance.BorderSize = 0;
            this.day_2_6_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.day_2_6_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.day_2_6_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.day_2_6_btn.Location = new System.Drawing.Point(681, 182);
            this.day_2_6_btn.Name = "day_2_6_btn";
            this.day_2_6_btn.Size = new System.Drawing.Size(107, 39);
            this.day_2_6_btn.TabIndex = 27;
            this.day_2_6_btn.Text = "r2c6";
            this.day_2_6_btn.UseVisualStyleBackColor = false;
            this.day_2_6_btn.Click += new System.EventHandler(this.DayClick);
            // 
            // day_3_0_btn
            // 
            this.day_3_0_btn.BackColor = System.Drawing.Color.Transparent;
            this.day_3_0_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.day_3_0_btn.FlatAppearance.BorderSize = 0;
            this.day_3_0_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.day_3_0_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.day_3_0_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.day_3_0_btn.Location = new System.Drawing.Point(3, 227);
            this.day_3_0_btn.Name = "day_3_0_btn";
            this.day_3_0_btn.Size = new System.Drawing.Size(107, 39);
            this.day_3_0_btn.TabIndex = 28;
            this.day_3_0_btn.Text = "r3c0";
            this.day_3_0_btn.UseVisualStyleBackColor = false;
            this.day_3_0_btn.Click += new System.EventHandler(this.DayClick);
            // 
            // day_3_3_btn
            // 
            this.day_3_3_btn.BackColor = System.Drawing.Color.Transparent;
            this.day_3_3_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.day_3_3_btn.FlatAppearance.BorderSize = 0;
            this.day_3_3_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.day_3_3_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.day_3_3_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.day_3_3_btn.Location = new System.Drawing.Point(342, 227);
            this.day_3_3_btn.Name = "day_3_3_btn";
            this.day_3_3_btn.Size = new System.Drawing.Size(107, 39);
            this.day_3_3_btn.TabIndex = 31;
            this.day_3_3_btn.Text = "r3c3";
            this.day_3_3_btn.UseVisualStyleBackColor = false;
            this.day_3_3_btn.Click += new System.EventHandler(this.DayClick);
            // 
            // day_3_2_btn
            // 
            this.day_3_2_btn.BackColor = System.Drawing.Color.Transparent;
            this.day_3_2_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.day_3_2_btn.FlatAppearance.BorderSize = 0;
            this.day_3_2_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.day_3_2_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.day_3_2_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.day_3_2_btn.Location = new System.Drawing.Point(229, 227);
            this.day_3_2_btn.Name = "day_3_2_btn";
            this.day_3_2_btn.Size = new System.Drawing.Size(107, 39);
            this.day_3_2_btn.TabIndex = 30;
            this.day_3_2_btn.Text = "r3c2";
            this.day_3_2_btn.UseVisualStyleBackColor = false;
            this.day_3_2_btn.Click += new System.EventHandler(this.DayClick);
            // 
            // day_3_1_btn
            // 
            this.day_3_1_btn.BackColor = System.Drawing.Color.Transparent;
            this.day_3_1_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.day_3_1_btn.FlatAppearance.BorderSize = 0;
            this.day_3_1_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.day_3_1_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.day_3_1_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.day_3_1_btn.Location = new System.Drawing.Point(116, 227);
            this.day_3_1_btn.Name = "day_3_1_btn";
            this.day_3_1_btn.Size = new System.Drawing.Size(107, 39);
            this.day_3_1_btn.TabIndex = 29;
            this.day_3_1_btn.Text = "r3c1";
            this.day_3_1_btn.UseVisualStyleBackColor = false;
            this.day_3_1_btn.Click += new System.EventHandler(this.DayClick);
            // 
            // day_3_4_btn
            // 
            this.day_3_4_btn.BackColor = System.Drawing.Color.Transparent;
            this.day_3_4_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.day_3_4_btn.FlatAppearance.BorderSize = 0;
            this.day_3_4_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.day_3_4_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.day_3_4_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.day_3_4_btn.Location = new System.Drawing.Point(455, 227);
            this.day_3_4_btn.Name = "day_3_4_btn";
            this.day_3_4_btn.Size = new System.Drawing.Size(107, 39);
            this.day_3_4_btn.TabIndex = 32;
            this.day_3_4_btn.Text = "r3c4";
            this.day_3_4_btn.UseVisualStyleBackColor = false;
            this.day_3_4_btn.Click += new System.EventHandler(this.DayClick);
            // 
            // day_3_5_btn
            // 
            this.day_3_5_btn.BackColor = System.Drawing.Color.Transparent;
            this.day_3_5_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.day_3_5_btn.FlatAppearance.BorderSize = 0;
            this.day_3_5_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.day_3_5_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.day_3_5_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.day_3_5_btn.Location = new System.Drawing.Point(568, 227);
            this.day_3_5_btn.Name = "day_3_5_btn";
            this.day_3_5_btn.Size = new System.Drawing.Size(107, 39);
            this.day_3_5_btn.TabIndex = 33;
            this.day_3_5_btn.Text = "r3c5";
            this.day_3_5_btn.UseVisualStyleBackColor = false;
            this.day_3_5_btn.Click += new System.EventHandler(this.DayClick);
            // 
            // day_3_6_btn
            // 
            this.day_3_6_btn.BackColor = System.Drawing.Color.Transparent;
            this.day_3_6_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.day_3_6_btn.FlatAppearance.BorderSize = 0;
            this.day_3_6_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.day_3_6_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.day_3_6_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.day_3_6_btn.Location = new System.Drawing.Point(681, 227);
            this.day_3_6_btn.Name = "day_3_6_btn";
            this.day_3_6_btn.Size = new System.Drawing.Size(107, 39);
            this.day_3_6_btn.TabIndex = 34;
            this.day_3_6_btn.Text = "r3c6";
            this.day_3_6_btn.UseVisualStyleBackColor = false;
            this.day_3_6_btn.Click += new System.EventHandler(this.DayClick);
            // 
            // day_4_0_btn
            // 
            this.day_4_0_btn.BackColor = System.Drawing.Color.Transparent;
            this.day_4_0_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.day_4_0_btn.FlatAppearance.BorderSize = 0;
            this.day_4_0_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.day_4_0_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.day_4_0_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.day_4_0_btn.Location = new System.Drawing.Point(3, 272);
            this.day_4_0_btn.Name = "day_4_0_btn";
            this.day_4_0_btn.Size = new System.Drawing.Size(107, 39);
            this.day_4_0_btn.TabIndex = 35;
            this.day_4_0_btn.Text = "r4c0";
            this.day_4_0_btn.UseVisualStyleBackColor = false;
            this.day_4_0_btn.Click += new System.EventHandler(this.DayClick);
            // 
            // day_4_1_btn
            // 
            this.day_4_1_btn.BackColor = System.Drawing.Color.Transparent;
            this.day_4_1_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.day_4_1_btn.FlatAppearance.BorderSize = 0;
            this.day_4_1_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.day_4_1_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.day_4_1_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.day_4_1_btn.Location = new System.Drawing.Point(116, 272);
            this.day_4_1_btn.Name = "day_4_1_btn";
            this.day_4_1_btn.Size = new System.Drawing.Size(107, 39);
            this.day_4_1_btn.TabIndex = 36;
            this.day_4_1_btn.Text = "r4c1";
            this.day_4_1_btn.UseVisualStyleBackColor = false;
            this.day_4_1_btn.Click += new System.EventHandler(this.DayClick);
            // 
            // day_4_2_btn
            // 
            this.day_4_2_btn.BackColor = System.Drawing.Color.Transparent;
            this.day_4_2_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.day_4_2_btn.FlatAppearance.BorderSize = 0;
            this.day_4_2_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.day_4_2_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.day_4_2_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.day_4_2_btn.Location = new System.Drawing.Point(229, 272);
            this.day_4_2_btn.Name = "day_4_2_btn";
            this.day_4_2_btn.Size = new System.Drawing.Size(107, 39);
            this.day_4_2_btn.TabIndex = 37;
            this.day_4_2_btn.Text = "r4c2";
            this.day_4_2_btn.UseVisualStyleBackColor = false;
            this.day_4_2_btn.Click += new System.EventHandler(this.DayClick);
            // 
            // day_4_4_btn
            // 
            this.day_4_4_btn.BackColor = System.Drawing.Color.Transparent;
            this.day_4_4_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.day_4_4_btn.FlatAppearance.BorderSize = 0;
            this.day_4_4_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.day_4_4_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.day_4_4_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.day_4_4_btn.Location = new System.Drawing.Point(455, 272);
            this.day_4_4_btn.Name = "day_4_4_btn";
            this.day_4_4_btn.Size = new System.Drawing.Size(107, 39);
            this.day_4_4_btn.TabIndex = 39;
            this.day_4_4_btn.Text = "r4c4";
            this.day_4_4_btn.UseVisualStyleBackColor = false;
            this.day_4_4_btn.Click += new System.EventHandler(this.DayClick);
            // 
            // day_4_3_btn
            // 
            this.day_4_3_btn.BackColor = System.Drawing.Color.Transparent;
            this.day_4_3_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.day_4_3_btn.FlatAppearance.BorderSize = 0;
            this.day_4_3_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.day_4_3_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.day_4_3_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.day_4_3_btn.Location = new System.Drawing.Point(342, 272);
            this.day_4_3_btn.Name = "day_4_3_btn";
            this.day_4_3_btn.Size = new System.Drawing.Size(107, 39);
            this.day_4_3_btn.TabIndex = 38;
            this.day_4_3_btn.Text = "r4c3";
            this.day_4_3_btn.UseVisualStyleBackColor = false;
            this.day_4_3_btn.Click += new System.EventHandler(this.DayClick);
            // 
            // day_4_5_btn
            // 
            this.day_4_5_btn.BackColor = System.Drawing.Color.Transparent;
            this.day_4_5_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.day_4_5_btn.FlatAppearance.BorderSize = 0;
            this.day_4_5_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.day_4_5_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.day_4_5_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.day_4_5_btn.Location = new System.Drawing.Point(568, 272);
            this.day_4_5_btn.Name = "day_4_5_btn";
            this.day_4_5_btn.Size = new System.Drawing.Size(107, 39);
            this.day_4_5_btn.TabIndex = 40;
            this.day_4_5_btn.Text = "r4c5";
            this.day_4_5_btn.UseVisualStyleBackColor = false;
            this.day_4_5_btn.Click += new System.EventHandler(this.DayClick);
            // 
            // day_4_6_btn
            // 
            this.day_4_6_btn.BackColor = System.Drawing.Color.Transparent;
            this.day_4_6_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.day_4_6_btn.FlatAppearance.BorderSize = 0;
            this.day_4_6_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.day_4_6_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.day_4_6_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.day_4_6_btn.Location = new System.Drawing.Point(681, 272);
            this.day_4_6_btn.Name = "day_4_6_btn";
            this.day_4_6_btn.Size = new System.Drawing.Size(107, 39);
            this.day_4_6_btn.TabIndex = 41;
            this.day_4_6_btn.Text = "r4c6";
            this.day_4_6_btn.UseVisualStyleBackColor = false;
            this.day_4_6_btn.Click += new System.EventHandler(this.DayClick);
            // 
            // day_5_2_btn
            // 
            this.day_5_2_btn.BackColor = System.Drawing.Color.Transparent;
            this.day_5_2_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.day_5_2_btn.FlatAppearance.BorderSize = 0;
            this.day_5_2_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.day_5_2_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.day_5_2_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.day_5_2_btn.Location = new System.Drawing.Point(229, 317);
            this.day_5_2_btn.Name = "day_5_2_btn";
            this.day_5_2_btn.Size = new System.Drawing.Size(107, 39);
            this.day_5_2_btn.TabIndex = 44;
            this.day_5_2_btn.Text = "r5c2";
            this.day_5_2_btn.UseVisualStyleBackColor = false;
            this.day_5_2_btn.Click += new System.EventHandler(this.DayClick);
            // 
            // day_5_4_btn
            // 
            this.day_5_4_btn.BackColor = System.Drawing.Color.Transparent;
            this.day_5_4_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.day_5_4_btn.FlatAppearance.BorderSize = 0;
            this.day_5_4_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.day_5_4_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.day_5_4_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.day_5_4_btn.Location = new System.Drawing.Point(455, 317);
            this.day_5_4_btn.Name = "day_5_4_btn";
            this.day_5_4_btn.Size = new System.Drawing.Size(107, 39);
            this.day_5_4_btn.TabIndex = 46;
            this.day_5_4_btn.Text = "r5c4";
            this.day_5_4_btn.UseVisualStyleBackColor = false;
            this.day_5_4_btn.Click += new System.EventHandler(this.DayClick);
            // 
            // day_5_1_btn
            // 
            this.day_5_1_btn.BackColor = System.Drawing.Color.Transparent;
            this.day_5_1_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.day_5_1_btn.FlatAppearance.BorderSize = 0;
            this.day_5_1_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.day_5_1_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.day_5_1_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.day_5_1_btn.Location = new System.Drawing.Point(116, 317);
            this.day_5_1_btn.Name = "day_5_1_btn";
            this.day_5_1_btn.Size = new System.Drawing.Size(107, 39);
            this.day_5_1_btn.TabIndex = 43;
            this.day_5_1_btn.Text = "r5c1";
            this.day_5_1_btn.UseVisualStyleBackColor = false;
            this.day_5_1_btn.Click += new System.EventHandler(this.DayClick);
            // 
            // day_5_0_btn
            // 
            this.day_5_0_btn.BackColor = System.Drawing.Color.Transparent;
            this.day_5_0_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.day_5_0_btn.FlatAppearance.BorderSize = 0;
            this.day_5_0_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.day_5_0_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.day_5_0_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.day_5_0_btn.Location = new System.Drawing.Point(3, 317);
            this.day_5_0_btn.Name = "day_5_0_btn";
            this.day_5_0_btn.Size = new System.Drawing.Size(107, 39);
            this.day_5_0_btn.TabIndex = 42;
            this.day_5_0_btn.Text = "r5c0";
            this.day_5_0_btn.UseVisualStyleBackColor = false;
            this.day_5_0_btn.Click += new System.EventHandler(this.DayClick);
            // 
            // day_5_3_btn
            // 
            this.day_5_3_btn.BackColor = System.Drawing.Color.Transparent;
            this.day_5_3_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.day_5_3_btn.FlatAppearance.BorderSize = 0;
            this.day_5_3_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.day_5_3_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.day_5_3_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.day_5_3_btn.Location = new System.Drawing.Point(342, 317);
            this.day_5_3_btn.Name = "day_5_3_btn";
            this.day_5_3_btn.Size = new System.Drawing.Size(107, 39);
            this.day_5_3_btn.TabIndex = 45;
            this.day_5_3_btn.Text = "r5c3";
            this.day_5_3_btn.UseVisualStyleBackColor = false;
            this.day_5_3_btn.Click += new System.EventHandler(this.DayClick);
            // 
            // day_5_5_btn
            // 
            this.day_5_5_btn.BackColor = System.Drawing.Color.Transparent;
            this.day_5_5_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.day_5_5_btn.FlatAppearance.BorderSize = 0;
            this.day_5_5_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.day_5_5_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.day_5_5_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.day_5_5_btn.Location = new System.Drawing.Point(568, 317);
            this.day_5_5_btn.Name = "day_5_5_btn";
            this.day_5_5_btn.Size = new System.Drawing.Size(107, 39);
            this.day_5_5_btn.TabIndex = 47;
            this.day_5_5_btn.Text = "r5c5";
            this.day_5_5_btn.UseVisualStyleBackColor = false;
            this.day_5_5_btn.Click += new System.EventHandler(this.DayClick);
            // 
            // day_5_6_btn
            // 
            this.day_5_6_btn.BackColor = System.Drawing.Color.Transparent;
            this.day_5_6_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.day_5_6_btn.FlatAppearance.BorderSize = 0;
            this.day_5_6_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.day_5_6_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.day_5_6_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.day_5_6_btn.Location = new System.Drawing.Point(681, 317);
            this.day_5_6_btn.Name = "day_5_6_btn";
            this.day_5_6_btn.Size = new System.Drawing.Size(107, 39);
            this.day_5_6_btn.TabIndex = 48;
            this.day_5_6_btn.Text = "r5c6";
            this.day_5_6_btn.UseVisualStyleBackColor = false;
            this.day_5_6_btn.Click += new System.EventHandler(this.DayClick);
            // 
            // next_month_btn
            // 
            this.next_month_btn.BackColor = System.Drawing.Color.Green;
            this.next_month_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.next_month_btn.FlatAppearance.BorderSize = 0;
            this.next_month_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.next_month_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOliveGreen;
            this.next_month_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.next_month_btn.ForeColor = System.Drawing.Color.White;
            this.next_month_btn.Location = new System.Drawing.Point(681, 3);
            this.next_month_btn.Name = "next_month_btn";
            this.next_month_btn.Size = new System.Drawing.Size(107, 34);
            this.next_month_btn.TabIndex = 49;
            this.next_month_btn.Text = "next month";
            this.next_month_btn.UseVisualStyleBackColor = false;
            // 
            // prev_month_btn
            // 
            this.prev_month_btn.BackColor = System.Drawing.Color.Red;
            this.prev_month_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.prev_month_btn.FlatAppearance.BorderSize = 0;
            this.prev_month_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.prev_month_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.prev_month_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prev_month_btn.ForeColor = System.Drawing.Color.White;
            this.prev_month_btn.Location = new System.Drawing.Point(3, 3);
            this.prev_month_btn.Name = "prev_month_btn";
            this.prev_month_btn.Size = new System.Drawing.Size(107, 34);
            this.prev_month_btn.TabIndex = 50;
            this.prev_month_btn.Text = "previous month";
            this.prev_month_btn.UseVisualStyleBackColor = false;
            // 
            // month_btn
            // 
            this.month_btn.BackColor = System.Drawing.Color.Transparent;
            this.month_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.month_btn.FlatAppearance.BorderSize = 0;
            this.month_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.month_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.month_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.month_btn.Location = new System.Drawing.Point(342, 3);
            this.month_btn.Name = "month_btn";
            this.month_btn.Size = new System.Drawing.Size(107, 34);
            this.month_btn.TabIndex = 51;
            this.month_btn.Text = "month";
            this.month_btn.UseVisualStyleBackColor = false;
            // 
            // year_btn
            // 
            this.year_btn.BackColor = System.Drawing.Color.Transparent;
            this.year_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.year_btn.FlatAppearance.BorderSize = 0;
            this.year_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.year_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.year_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.year_btn.Location = new System.Drawing.Point(455, 3);
            this.year_btn.Name = "year_btn";
            this.year_btn.Size = new System.Drawing.Size(107, 34);
            this.year_btn.TabIndex = 52;
            this.year_btn.Text = "year";
            this.year_btn.UseVisualStyleBackColor = false;
            // 
            // today_show_btn
            // 
            this.today_show_btn.BackColor = System.Drawing.Color.LightGray;
            this.today_show_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.today_show_btn.FlatAppearance.BorderSize = 0;
            this.today_show_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.today_show_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.today_show_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.today_show_btn.Location = new System.Drawing.Point(229, 362);
            this.today_show_btn.Name = "today_show_btn";
            this.today_show_btn.Size = new System.Drawing.Size(107, 43);
            this.today_show_btn.TabIndex = 53;
            this.today_show_btn.Text = "show";
            this.today_show_btn.UseVisualStyleBackColor = false;
            // 
            // today_text_btn
            // 
            this.today_text_btn.BackColor = System.Drawing.Color.Transparent;
            this.today_text_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.today_text_btn.FlatAppearance.BorderSize = 0;
            this.today_text_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.today_text_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.today_text_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.today_text_btn.Location = new System.Drawing.Point(342, 362);
            this.today_text_btn.Name = "today_text_btn";
            this.today_text_btn.Size = new System.Drawing.Size(107, 34);
            this.today_text_btn.TabIndex = 54;
            this.today_text_btn.Text = "Today:";
            this.today_text_btn.UseVisualStyleBackColor = false;
            // 
            // today_date_btn
            // 
            this.today_date_btn.BackColor = System.Drawing.Color.Transparent;
            this.today_date_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.today_date_btn.FlatAppearance.BorderSize = 0;
            this.today_date_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.today_date_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.today_date_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.today_date_btn.Location = new System.Drawing.Point(455, 362);
            this.today_date_btn.Name = "today_date_btn";
            this.today_date_btn.Size = new System.Drawing.Size(107, 34);
            this.today_date_btn.TabIndex = 55;
            this.today_date_btn.Text = "date today";
            this.today_date_btn.UseVisualStyleBackColor = false;
            // 
            // CalendarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 721);
            this.Controls.Add(this.CalendarPanel);
            this.Controls.Add(this.panel1);
            this.Name = "CalendarForm";
            this.Text = "CalendarForm";
            this.Load += new System.EventHandler(this.CalendarForm_Load);
            this.panel1.ResumeLayout(false);
            this.CalendarPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel CalendarPanel;
        private System.Windows.Forms.Button sunday_btn;
        private System.Windows.Forms.Button monday_btn;
        private System.Windows.Forms.Button tuesday_btn;
        private System.Windows.Forms.Button wednesday_btn;
        private System.Windows.Forms.Button thrusday_btn;
        private System.Windows.Forms.Button friday_btn;
        private System.Windows.Forms.Button saturday_btn;
        private System.Windows.Forms.Button day_0_0_btn;
        private System.Windows.Forms.Button day_0_1_btn;
        private System.Windows.Forms.Button day_0_2_btn;
        private System.Windows.Forms.Button day_0_3_btn;
        private System.Windows.Forms.Button day_0_4_btn;
        private System.Windows.Forms.Button day_0_5_btn;
        private System.Windows.Forms.Button day_0_6_btn;
        private System.Windows.Forms.Button day_1_2_btn;
        private System.Windows.Forms.Button day_1_0_btn;
        private System.Windows.Forms.Button day_1_1_btn;
        private System.Windows.Forms.Button day_1_3_btn;
        private System.Windows.Forms.Button day_1_4_btn;
        private System.Windows.Forms.Button day_1_5_btn;
        private System.Windows.Forms.Button day_1_6_btn;
        private System.Windows.Forms.Button day_2_0_btn;
        private System.Windows.Forms.Button day_2_1_btn;
        private System.Windows.Forms.Button day_2_2_btn;
        private System.Windows.Forms.Button day_2_3_btn;
        private System.Windows.Forms.Button day_2_4_btn;
        private System.Windows.Forms.Button day_2_5_btn;
        private System.Windows.Forms.Button day_2_6_btn;
        private System.Windows.Forms.Button day_3_0_btn;
        private System.Windows.Forms.Button day_3_3_btn;
        private System.Windows.Forms.Button day_3_2_btn;
        private System.Windows.Forms.Button day_3_1_btn;
        private System.Windows.Forms.Button day_3_4_btn;
        private System.Windows.Forms.Button day_3_5_btn;
        private System.Windows.Forms.Button day_3_6_btn;
        private System.Windows.Forms.Button day_4_0_btn;
        private System.Windows.Forms.Button day_4_1_btn;
        private System.Windows.Forms.Button day_4_2_btn;
        private System.Windows.Forms.Button day_4_4_btn;
        private System.Windows.Forms.Button day_4_3_btn;
        private System.Windows.Forms.Button day_4_5_btn;
        private System.Windows.Forms.Button day_4_6_btn;
        private System.Windows.Forms.Button day_5_2_btn;
        private System.Windows.Forms.Button day_5_4_btn;
        private System.Windows.Forms.Button day_5_1_btn;
        private System.Windows.Forms.Button day_5_0_btn;
        private System.Windows.Forms.Button day_5_3_btn;
        private System.Windows.Forms.Button day_5_5_btn;
        private System.Windows.Forms.Button day_5_6_btn;
        private System.Windows.Forms.Button next_month_btn;
        private System.Windows.Forms.Button prev_month_btn;
        private System.Windows.Forms.Button month_btn;
        private System.Windows.Forms.Button year_btn;
        private System.Windows.Forms.Button today_show_btn;
        private System.Windows.Forms.Button today_text_btn;
        private System.Windows.Forms.Button today_date_btn;
    }
}