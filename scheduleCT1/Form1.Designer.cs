﻿namespace scheduleCT1
{
    partial class MainForm
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
            Calendar.DrawTool drawTool1 = new Calendar.DrawTool();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dayView1 = new Calendar.DayView();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.lstTypeOfScan = new System.Windows.Forms.CheckedListBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButtonViewType = new System.Windows.Forms.ToolStripDropDownButton();
            this.dayViewToolStripMenuItem5Days = new System.Windows.Forms.ToolStripMenuItem();
            this.dayViewToolStripMenuItem7Days = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButtonTeamView = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDayView = new System.Windows.Forms.ToolStripButton();
            this.ApmAddBtn = new System.Windows.Forms.Button();
            this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.specialCheckBox = new System.Windows.Forms.CheckBox();
            this.noonCheckBox = new System.Windows.Forms.CheckBox();
            this.morningCheckBox = new System.Windows.Forms.CheckBox();
            this.ScanSchBtn = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dayView1
            // 
            drawTool1.DayView = this.dayView1;
            this.dayView1.ActiveTool = drawTool1;
            this.dayView1.AlwaysShowAppointmentText = true;
            this.dayView1.AmPmDisplay = false;
            this.dayView1.ContextMenuAllDay = null;
            this.dayView1.ContextMenuDiary = null;
            this.dayView1.ContextMenuHeader = null;
            this.dayView1.DrawAllAppointmentBorders = false;
            this.dayView1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.dayView1.Location = new System.Drawing.Point(315, 28);
            this.dayView1.Name = "dayView1";
            this.dayView1.SelectedAppointment = null;
            this.dayView1.SelectionEnd = new System.DateTime(((long)(0)));
            this.dayView1.SelectionStart = new System.DateTime(((long)(0)));
            this.dayView1.ShowMinutes = true;
            this.dayView1.Size = new System.Drawing.Size(592, 532);
            this.dayView1.StartDate = new System.DateTime(((long)(0)));
            this.dayView1.TabIndex = 2;
            this.dayView1.Text = "dayView1";
            this.dayView1.ResolveAppointments += new Calendar.ResolveAppointmentsEventHandler(this.dayView1_ResolveAppointments);
            this.dayView1.BeforeAppointmentMove += new Calendar.BeforeMoveAppointmentEventHandler(this.dayView1_BeforeAppointmentMove);
            this.dayView1.MultiCount += new Calendar.MultiCountEventHandler(this.dayView1_MultiCount);
            this.dayView1.MultiHeader += new Calendar.MultiGetEventHandler(this.dayView1_MultiHeader);
            this.dayView1.ToolTipShow += new Calendar.TooltipEventHandler(this.dayView1_ToolTipShow);
            this.dayView1.WorkingHours += new Calendar.WorkingHoursEventHandler(this.dayView1_WorkingHours);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(82, 125);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // lstTypeOfScan
            // 
            this.lstTypeOfScan.FormattingEnabled = true;
            this.lstTypeOfScan.Items.AddRange(new object[] {
            "CT_1",
            "CT_2",
            "MRI",
            "Ultrasound"});
            this.lstTypeOfScan.Location = new System.Drawing.Point(82, 451);
            this.lstTypeOfScan.Name = "lstTypeOfScan";
            this.lstTypeOfScan.Size = new System.Drawing.Size(113, 109);
            this.lstTypeOfScan.TabIndex = 3;
            this.lstTypeOfScan.SelectedIndexChanged += new System.EventHandler(this.lstTypeOfScan_SelectedIndexChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButtonViewType,
            this.toolStripButtonTeamView,
            this.toolStripButtonDayView});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(910, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButtonViewType
            // 
            this.toolStripDropDownButtonViewType.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButtonViewType.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dayViewToolStripMenuItem5Days,
            this.dayViewToolStripMenuItem7Days});
            this.toolStripDropDownButtonViewType.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButtonViewType.Image")));
            this.toolStripDropDownButtonViewType.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButtonViewType.Name = "toolStripDropDownButtonViewType";
            this.toolStripDropDownButtonViewType.Size = new System.Drawing.Size(45, 22);
            this.toolStripDropDownButtonViewType.Text = "Days";
            // 
            // dayViewToolStripMenuItem5Days
            // 
            this.dayViewToolStripMenuItem5Days.Name = "dayViewToolStripMenuItem5Days";
            this.dayViewToolStripMenuItem5Days.Size = new System.Drawing.Size(108, 22);
            this.dayViewToolStripMenuItem5Days.Text = "5 Days";
            this.dayViewToolStripMenuItem5Days.Click += new System.EventHandler(this.dayViewToolStripMenuItem5Days_Click);
            // 
            // dayViewToolStripMenuItem7Days
            // 
            this.dayViewToolStripMenuItem7Days.Name = "dayViewToolStripMenuItem7Days";
            this.dayViewToolStripMenuItem7Days.Size = new System.Drawing.Size(108, 22);
            this.dayViewToolStripMenuItem7Days.Text = "7 Days";
            this.dayViewToolStripMenuItem7Days.Click += new System.EventHandler(this.teamViewToolStripMenuItem7Days_Click);
            // 
            // toolStripButtonTeamView
            // 
            this.toolStripButtonTeamView.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonTeamView.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonTeamView.Image")));
            this.toolStripButtonTeamView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonTeamView.Name = "toolStripButtonTeamView";
            this.toolStripButtonTeamView.Size = new System.Drawing.Size(53, 22);
            this.toolStripButtonTeamView.Text = "Scanner";
            this.toolStripButtonTeamView.Click += new System.EventHandler(this.toolStripButtonTeamView_Click);
            // 
            // toolStripButtonDayView
            // 
            this.toolStripButtonDayView.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonDayView.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDayView.Image")));
            this.toolStripButtonDayView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDayView.Name = "toolStripButtonDayView";
            this.toolStripButtonDayView.Size = new System.Drawing.Size(31, 22);
            this.toolStripButtonDayView.Text = "Day";
            this.toolStripButtonDayView.Click += new System.EventHandler(this.toolStripButtonDayView_Click);
            // 
            // ApmAddBtn
            // 
            this.ApmAddBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ApmAddBtn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApmAddBtn.Location = new System.Drawing.Point(4, 28);
            this.ApmAddBtn.Name = "ApmAddBtn";
            this.ApmAddBtn.Size = new System.Drawing.Size(76, 61);
            this.ApmAddBtn.TabIndex = 5;
            this.ApmAddBtn.Text = "เพิ่มการ\r\nนัดหมาย";
            this.ApmAddBtn.UseVisualStyleBackColor = true;
            this.ApmAddBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.Location = new System.Drawing.Point(82, 286);
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.ShowToday = false;
            this.monthCalendar2.TabIndex = 6;
            this.monthCalendar2.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar2_DateChanged);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(196, 451);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(113, 109);
            this.checkedListBox1.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.specialCheckBox);
            this.groupBox1.Controls.Add(this.noonCheckBox);
            this.groupBox1.Controls.Add(this.morningCheckBox);
            this.groupBox1.Location = new System.Drawing.Point(82, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 95);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "การนัดตรวจ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(186, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "...";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "...";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(186, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "...";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // specialCheckBox
            // 
            this.specialCheckBox.AutoSize = true;
            this.specialCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.specialCheckBox.Location = new System.Drawing.Point(6, 69);
            this.specialCheckBox.Name = "specialCheckBox";
            this.specialCheckBox.Size = new System.Drawing.Size(101, 18);
            this.specialCheckBox.TabIndex = 2;
            this.specialCheckBox.Text = "นัดตรวจพิเศษ";
            this.specialCheckBox.UseVisualStyleBackColor = true;
            // 
            // noonCheckBox
            // 
            this.noonCheckBox.AutoSize = true;
            this.noonCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.noonCheckBox.Location = new System.Drawing.Point(6, 45);
            this.noonCheckBox.Name = "noonCheckBox";
            this.noonCheckBox.Size = new System.Drawing.Size(91, 18);
            this.noonCheckBox.TabIndex = 1;
            this.noonCheckBox.Text = "นัดตรวจบ่าย";
            this.noonCheckBox.UseVisualStyleBackColor = true;
            // 
            // morningCheckBox
            // 
            this.morningCheckBox.AutoSize = true;
            this.morningCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.morningCheckBox.Location = new System.Drawing.Point(6, 21);
            this.morningCheckBox.Name = "morningCheckBox";
            this.morningCheckBox.Size = new System.Drawing.Size(89, 18);
            this.morningCheckBox.TabIndex = 0;
            this.morningCheckBox.Text = "นัดตรวจเช้า";
            this.morningCheckBox.UseVisualStyleBackColor = true;
            // 
            // ScanSchBtn
            // 
            this.ScanSchBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ScanSchBtn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScanSchBtn.Location = new System.Drawing.Point(4, 95);
            this.ScanSchBtn.Name = "ScanSchBtn";
            this.ScanSchBtn.Size = new System.Drawing.Size(76, 75);
            this.ScanSchBtn.TabIndex = 9;
            this.ScanSchBtn.Text = "จัดการขอบเขตการนัดหมาย";
            this.ScanSchBtn.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 571);
            this.Controls.Add(this.ScanSchBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.monthCalendar2);
            this.Controls.Add(this.ApmAddBtn);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lstTypeOfScan);
            this.Controls.Add(this.dayView1);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "MainForm";
            this.Text = "ระบบจัดการการนัดหมาย";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private Calendar.DayView dayView1;
        private System.Windows.Forms.CheckedListBox lstTypeOfScan;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonViewType;
        private System.Windows.Forms.ToolStripMenuItem dayViewToolStripMenuItem5Days;
        private System.Windows.Forms.ToolStripMenuItem dayViewToolStripMenuItem7Days;
        private System.Windows.Forms.ToolStripButton toolStripButtonTeamView;
        private System.Windows.Forms.ToolStripButton toolStripButtonDayView;
        private System.Windows.Forms.Button ApmAddBtn;
        private System.Windows.Forms.MonthCalendar monthCalendar2;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox specialCheckBox;
        private System.Windows.Forms.CheckBox noonCheckBox;
        private System.Windows.Forms.CheckBox morningCheckBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ScanSchBtn;
    }
}

