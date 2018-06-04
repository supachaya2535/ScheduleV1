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
            this.label1 = new System.Windows.Forms.Label();
            this.HNtxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateSelected = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Scanner = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.appId = new System.Windows.Forms.TextBox();
            this.statusComb = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.scanTxt = new System.Windows.Forms.TextBox();
            this.reqTxt = new System.Windows.Forms.TextBox();
            this.pedTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "HN";
            // 
            // HNtxt
            // 
            this.HNtxt.Enabled = false;
            this.HNtxt.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HNtxt.Location = new System.Drawing.Point(103, 59);
            this.HNtxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HNtxt.Name = "HNtxt";
            this.HNtxt.Size = new System.Drawing.Size(309, 27);
            this.HNtxt.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 105);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Date";
            // 
            // dateSelected
            // 
            this.dateSelected.CalendarFont = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateSelected.Enabled = false;
            this.dateSelected.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateSelected.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateSelected.Location = new System.Drawing.Point(103, 105);
            this.dateSelected.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateSelected.MaxDate = new System.DateTime(2019, 12, 31, 0, 0, 0, 0);
            this.dateSelected.MinDate = new System.DateTime(1909, 11, 24, 0, 0, 0, 0);
            this.dateSelected.Name = "dateSelected";
            this.dateSelected.Size = new System.Drawing.Size(309, 27);
            this.dateSelected.TabIndex = 18;
            this.dateSelected.Value = new System.DateTime(2018, 1, 5, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 208);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Request";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 260);
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
            this.Scanner.Location = new System.Drawing.Point(9, 158);
            this.Scanner.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Scanner.Name = "Scanner";
            this.Scanner.Size = new System.Drawing.Size(79, 20);
            this.Scanner.TabIndex = 0;
            this.Scanner.Text = "Scanner";
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(31, 354);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(155, 37);
            this.saveBtn.TabIndex = 21;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(249, 354);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(164, 37);
            this.deleteBtn.TabIndex = 4;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 18);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "App. ID";
            // 
            // appId
            // 
            this.appId.Enabled = false;
            this.appId.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appId.Location = new System.Drawing.Point(103, 15);
            this.appId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.appId.Name = "appId";
            this.appId.Size = new System.Drawing.Size(309, 27);
            this.appId.TabIndex = 25;
            // 
            // statusComb
            // 
            this.statusComb.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusComb.FormattingEnabled = true;
            this.statusComb.Items.AddRange(new object[] {
            "Waiting",
            "Cancled",
            "Done",
            "Changed"});
            this.statusComb.Location = new System.Drawing.Point(100, 304);
            this.statusComb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.statusComb.Name = "statusComb";
            this.statusComb.Size = new System.Drawing.Size(309, 26);
            this.statusComb.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Enabled = false;
            this.label9.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(19, 308);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "Status";
            // 
            // scanTxt
            // 
            this.scanTxt.Enabled = false;
            this.scanTxt.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scanTxt.Location = new System.Drawing.Point(100, 154);
            this.scanTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.scanTxt.Name = "scanTxt";
            this.scanTxt.Size = new System.Drawing.Size(309, 27);
            this.scanTxt.TabIndex = 26;
            // 
            // reqTxt
            // 
            this.reqTxt.Enabled = false;
            this.reqTxt.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reqTxt.Location = new System.Drawing.Point(100, 204);
            this.reqTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reqTxt.Name = "reqTxt";
            this.reqTxt.Size = new System.Drawing.Size(309, 27);
            this.reqTxt.TabIndex = 27;
            // 
            // pedTxt
            // 
            this.pedTxt.Enabled = false;
            this.pedTxt.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pedTxt.Location = new System.Drawing.Point(100, 256);
            this.pedTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pedTxt.Name = "pedTxt";
            this.pedTxt.Size = new System.Drawing.Size(309, 27);
            this.pedTxt.TabIndex = 28;
            // 
            // AppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 405);
            this.Controls.Add(this.pedTxt);
            this.Controls.Add(this.reqTxt);
            this.Controls.Add(this.scanTxt);
            this.Controls.Add(this.statusComb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.appId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateSelected);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.HNtxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Scanner);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.deleteBtn);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AppointmentForm";
            this.Text = "AppointmentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox HNtxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateSelected;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Scanner;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox appId;
        private System.Windows.Forms.ComboBox statusComb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox scanTxt;
        private System.Windows.Forms.TextBox reqTxt;
        private System.Windows.Forms.TextBox pedTxt;
    }
}