namespace AppointmentQueue
{
    partial class DayOffForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.detailTxt = new System.Windows.Forms.TextBox();
            this.pedCob = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.addDayOffBtn = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.dayOffDate = new System.Windows.Forms.DateTimePicker();
            this.dayOffGridView = new System.Windows.Forms.DataGridView();
            this.drDataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.drLnameTxt2 = new System.Windows.Forms.TextBox();
            this.drIdTxt = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.drNameTxt2 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.drName2 = new System.Windows.Forms.TextBox();
            this.seachDrReq = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dayOffGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drDataGridView2)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(729, 138);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 31);
            this.button1.TabIndex = 61;
            this.button1.Text = "Update a day off";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(953, 138);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(211, 31);
            this.button2.TabIndex = 60;
            this.button2.Text = "Delete a day off";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(519, 84);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 58;
            this.label4.Text = "Detail";
            // 
            // detailTxt
            // 
            this.detailTxt.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailTxt.Location = new System.Drawing.Point(617, 84);
            this.detailTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.detailTxt.Multiline = true;
            this.detailTxt.Name = "detailTxt";
            this.detailTxt.Size = new System.Drawing.Size(545, 42);
            this.detailTxt.TabIndex = 53;
            // 
            // pedCob
            // 
            this.pedCob.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pedCob.FormattingEnabled = true;
            this.pedCob.Items.AddRange(new object[] {
            "Morning",
            "Afternoon",
            "Allday"});
            this.pedCob.Location = new System.Drawing.Point(971, 4);
            this.pedCob.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pedCob.Name = "pedCob";
            this.pedCob.Size = new System.Drawing.Size(192, 26);
            this.pedCob.TabIndex = 57;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(895, 4);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 20);
            this.label7.TabIndex = 56;
            this.label7.Text = "Period";
            // 
            // addDayOffBtn
            // 
            this.addDayOffBtn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDayOffBtn.Location = new System.Drawing.Point(511, 138);
            this.addDayOffBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addDayOffBtn.Name = "addDayOffBtn";
            this.addDayOffBtn.Size = new System.Drawing.Size(211, 31);
            this.addDayOffBtn.TabIndex = 54;
            this.addDayOffBtn.Text = "Insert a new day off";
            this.addDayOffBtn.UseVisualStyleBackColor = true;
            this.addDayOffBtn.Click += new System.EventHandler(this.addDayOffBtn_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(527, 7);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 20);
            this.label13.TabIndex = 52;
            this.label13.Text = "Date";
            // 
            // dayOffDate
            // 
            this.dayOffDate.CalendarFont = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayOffDate.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayOffDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dayOffDate.Location = new System.Drawing.Point(617, 5);
            this.dayOffDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dayOffDate.MaxDate = new System.DateTime(2019, 12, 31, 0, 0, 0, 0);
            this.dayOffDate.MinDate = new System.DateTime(2018, 5, 18, 0, 0, 0, 0);
            this.dayOffDate.Name = "dayOffDate";
            this.dayOffDate.Size = new System.Drawing.Size(187, 27);
            this.dayOffDate.TabIndex = 51;
            this.dayOffDate.Value = new System.DateTime(2018, 5, 18, 0, 0, 0, 0);
            // 
            // dayOffGridView
            // 
            this.dayOffGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dayOffGridView.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dayOffGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dayOffGridView.Location = new System.Drawing.Point(511, 176);
            this.dayOffGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dayOffGridView.Name = "dayOffGridView";
            this.dayOffGridView.Size = new System.Drawing.Size(653, 383);
            this.dayOffGridView.TabIndex = 50;
            this.dayOffGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dayOffGridView_RowHeaderMouseClick);
            // 
            // drDataGridView2
            // 
            this.drDataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.drDataGridView2.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.drDataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.drDataGridView2.Location = new System.Drawing.Point(16, 176);
            this.drDataGridView2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.drDataGridView2.Name = "drDataGridView2";
            this.drDataGridView2.Size = new System.Drawing.Size(487, 383);
            this.drDataGridView2.TabIndex = 63;
            this.drDataGridView2.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.drDataGridView2_RowHeaderMouseDoubleClick);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.drLnameTxt2);
            this.groupBox4.Controls.Add(this.drIdTxt);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.drNameTxt2);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(16, 11);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(487, 158);
            this.groupBox4.TabIndex = 62;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Doctor Information";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(8, 112);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(94, 20);
            this.label14.TabIndex = 35;
            this.label14.Text = "LastName";
            // 
            // drLnameTxt2
            // 
            this.drLnameTxt2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drLnameTxt2.Location = new System.Drawing.Point(112, 108);
            this.drLnameTxt2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.drLnameTxt2.Name = "drLnameTxt2";
            this.drLnameTxt2.Size = new System.Drawing.Size(339, 27);
            this.drLnameTxt2.TabIndex = 34;
            this.drLnameTxt2.TextChanged += new System.EventHandler(this.drLnameTxt2_TextChanged);
            // 
            // drIdTxt
            // 
            this.drIdTxt.Enabled = false;
            this.drIdTxt.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drIdTxt.Location = new System.Drawing.Point(112, 37);
            this.drIdTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.drIdTxt.Name = "drIdTxt";
            this.drIdTxt.Size = new System.Drawing.Size(339, 27);
            this.drIdTxt.TabIndex = 32;
            this.drIdTxt.TextChanged += new System.EventHandler(this.drIdTxt_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(16, 73);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(83, 20);
            this.label15.TabIndex = 29;
            this.label15.Text = "Dr.Name";
            // 
            // drNameTxt2
            // 
            this.drNameTxt2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drNameTxt2.Location = new System.Drawing.Point(112, 73);
            this.drNameTxt2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.drNameTxt2.Name = "drNameTxt2";
            this.drNameTxt2.Size = new System.Drawing.Size(339, 27);
            this.drNameTxt2.TabIndex = 30;
            this.drNameTxt2.TextChanged += new System.EventHandler(this.drNameTxt2_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(23, 37);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 20);
            this.label16.TabIndex = 31;
            this.label16.Text = "Dr. ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(515, 48);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 74;
            this.label3.Text = "Dr.Name";
            // 
            // drName2
            // 
            this.drName2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drName2.Location = new System.Drawing.Point(617, 44);
            this.drName2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.drName2.Name = "drName2";
            this.drName2.Size = new System.Drawing.Size(249, 27);
            this.drName2.TabIndex = 73;
            // 
            // seachDrReq
            // 
            this.seachDrReq.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seachDrReq.Location = new System.Drawing.Point(876, 39);
            this.seachDrReq.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.seachDrReq.Name = "seachDrReq";
            this.seachDrReq.Size = new System.Drawing.Size(83, 37);
            this.seachDrReq.TabIndex = 72;
            this.seachDrReq.Text = "Search";
            this.seachDrReq.UseVisualStyleBackColor = true;
            this.seachDrReq.Click += new System.EventHandler(this.seachDrReq_Click);
            // 
            // DayOffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 566);
            this.Controls.Add(this.drDataGridView2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.drName2);
            this.Controls.Add(this.seachDrReq);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.detailTxt);
            this.Controls.Add(this.pedCob);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.addDayOffBtn);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dayOffDate);
            this.Controls.Add(this.dayOffGridView);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DayOffForm";
            this.Text = "DayOffForm";
            ((System.ComponentModel.ISupportInitialize)(this.dayOffGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drDataGridView2)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox detailTxt;
        private System.Windows.Forms.ComboBox pedCob;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button addDayOffBtn;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dayOffDate;
        private System.Windows.Forms.DataGridView dayOffGridView;
        private System.Windows.Forms.DataGridView drDataGridView2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox drLnameTxt2;
        private System.Windows.Forms.TextBox drIdTxt;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox drNameTxt2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox drName2;
        private System.Windows.Forms.Button seachDrReq;
    }
}