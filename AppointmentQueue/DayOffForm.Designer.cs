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
            this.drDataGridView = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.detailTxt = new System.Windows.Forms.TextBox();
            this.pedCob = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.addDayOffBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.seachPaBtn = new System.Windows.Forms.Button();
            this.drLnameTxt = new System.Windows.Forms.TextBox();
            this.Idtxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.drNameTxt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dayOffDate = new System.Windows.Forms.DateTimePicker();
            this.drGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.drDataGridView)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(667, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 30);
            this.button1.TabIndex = 61;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(756, 101);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(61, 30);
            this.button2.TabIndex = 60;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // drDataGridView
            // 
            this.drDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.drDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.drDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.drDataGridView.Location = new System.Drawing.Point(2, 137);
            this.drDataGridView.Name = "drDataGridView";
            this.drDataGridView.Size = new System.Drawing.Size(376, 317);
            this.drDataGridView.TabIndex = 59;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(389, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 58;
            this.label4.Text = "Detail";
            // 
            // detailTxt
            // 
            this.detailTxt.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailTxt.Location = new System.Drawing.Point(421, 56);
            this.detailTxt.Multiline = true;
            this.detailTxt.Name = "detailTxt";
            this.detailTxt.Size = new System.Drawing.Size(396, 35);
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
            this.pedCob.Location = new System.Drawing.Point(634, 4);
            this.pedCob.Name = "pedCob";
            this.pedCob.Size = new System.Drawing.Size(145, 24);
            this.pedCob.TabIndex = 57;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(580, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 16);
            this.label7.TabIndex = 56;
            this.label7.Text = "Period";
            // 
            // addDayOffBtn
            // 
            this.addDayOffBtn.Enabled = false;
            this.addDayOffBtn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDayOffBtn.Location = new System.Drawing.Point(565, 104);
            this.addDayOffBtn.Name = "addDayOffBtn";
            this.addDayOffBtn.Size = new System.Drawing.Size(63, 25);
            this.addDayOffBtn.TabIndex = 54;
            this.addDayOffBtn.Text = "Add ";
            this.addDayOffBtn.UseVisualStyleBackColor = true;
            this.addDayOffBtn.Click += new System.EventHandler(this.addDayOffBtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox3.Controls.Add(this.seachPaBtn);
            this.groupBox3.Controls.Add(this.drLnameTxt);
            this.groupBox3.Controls.Add(this.Idtxt);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.drNameTxt);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(2, 1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(373, 130);
            this.groupBox3.TabIndex = 55;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Doctor Information";
            // 
            // seachPaBtn
            // 
            this.seachPaBtn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seachPaBtn.Location = new System.Drawing.Point(298, 20);
            this.seachPaBtn.Name = "seachPaBtn";
            this.seachPaBtn.Size = new System.Drawing.Size(63, 30);
            this.seachPaBtn.TabIndex = 35;
            this.seachPaBtn.Text = "Seach";
            this.seachPaBtn.UseVisualStyleBackColor = true;
            this.seachPaBtn.Click += new System.EventHandler(this.seachPaBtn_Click);
            // 
            // drLnameTxt
            // 
            this.drLnameTxt.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drLnameTxt.Location = new System.Drawing.Point(86, 92);
            this.drLnameTxt.Name = "drLnameTxt";
            this.drLnameTxt.Size = new System.Drawing.Size(275, 23);
            this.drLnameTxt.TabIndex = 34;
            // 
            // Idtxt
            // 
            this.Idtxt.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Idtxt.Location = new System.Drawing.Point(86, 27);
            this.Idtxt.Name = "Idtxt";
            this.Idtxt.Size = new System.Drawing.Size(205, 23);
            this.Idtxt.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 16);
            this.label9.TabIndex = 33;
            this.label9.Text = "Last Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(36, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 16);
            this.label10.TabIndex = 29;
            this.label10.Text = "Name";
            // 
            // drNameTxt
            // 
            this.drNameTxt.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drNameTxt.Location = new System.Drawing.Point(86, 59);
            this.drNameTxt.Name = "drNameTxt";
            this.drNameTxt.Size = new System.Drawing.Size(275, 23);
            this.drNameTxt.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(39, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 16);
            this.label11.TabIndex = 31;
            this.label11.Text = "Dr. ID";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(389, 7);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 16);
            this.label13.TabIndex = 52;
            this.label13.Text = "Date";
            // 
            // dayOffDate
            // 
            this.dayOffDate.CalendarFont = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayOffDate.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayOffDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dayOffDate.Location = new System.Drawing.Point(433, 4);
            this.dayOffDate.MaxDate = new System.DateTime(2019, 12, 31, 0, 0, 0, 0);
            this.dayOffDate.MinDate = new System.DateTime(2018, 5, 18, 0, 0, 0, 0);
            this.dayOffDate.Name = "dayOffDate";
            this.dayOffDate.Size = new System.Drawing.Size(141, 23);
            this.dayOffDate.TabIndex = 51;
            this.dayOffDate.Value = new System.DateTime(2018, 5, 18, 0, 0, 0, 0);
            // 
            // drGridView
            // 
            this.drGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.drGridView.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.drGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.drGridView.Location = new System.Drawing.Point(383, 137);
            this.drGridView.Name = "drGridView";
            this.drGridView.Size = new System.Drawing.Size(479, 317);
            this.drGridView.TabIndex = 50;
            // 
            // DayOffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 460);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.drDataGridView);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.detailTxt);
            this.Controls.Add(this.pedCob);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.addDayOffBtn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dayOffDate);
            this.Controls.Add(this.drGridView);
            this.Name = "DayOffForm";
            this.Text = "DayOffForm";
            ((System.ComponentModel.ISupportInitialize)(this.drDataGridView)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView drDataGridView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox detailTxt;
        private System.Windows.Forms.ComboBox pedCob;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button addDayOffBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox drLnameTxt;
        private System.Windows.Forms.TextBox Idtxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox drNameTxt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dayOffDate;
        private System.Windows.Forms.DataGridView drGridView;
        private System.Windows.Forms.Button seachPaBtn;
    }
}