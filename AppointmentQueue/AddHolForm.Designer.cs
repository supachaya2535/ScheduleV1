namespace AppointmentQueue
{
    partial class AddHolForm
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.seachDrBtn = new System.Windows.Forms.Button();
            this.detailTxt = new System.Windows.Forms.TextBox();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Drtxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.todayDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.patGridView = new System.Windows.Forms.DataGridView();
            this.editBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox2.Controls.Add(this.deleteBtn);
            this.groupBox2.Controls.Add(this.addBtn);
            this.groupBox2.Controls.Add(this.editBtn);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.seachDrBtn);
            this.groupBox2.Controls.Add(this.todayDatePicker);
            this.groupBox2.Controls.Add(this.detailTxt);
            this.groupBox2.Controls.Add(this.nameTxt);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.Drtxt);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(370, 275);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Doctor Information";
            // 
            // seachDrBtn
            // 
            this.seachDrBtn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seachDrBtn.Location = new System.Drawing.Point(293, 23);
            this.seachDrBtn.Name = "seachDrBtn";
            this.seachDrBtn.Size = new System.Drawing.Size(63, 30);
            this.seachDrBtn.TabIndex = 20;
            this.seachDrBtn.Text = "Seach";
            this.seachDrBtn.UseVisualStyleBackColor = true;
            // 
            // detailTxt
            // 
            this.detailTxt.Enabled = false;
            this.detailTxt.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailTxt.Location = new System.Drawing.Point(56, 130);
            this.detailTxt.Multiline = true;
            this.detailTxt.Name = "detailTxt";
            this.detailTxt.Size = new System.Drawing.Size(300, 99);
            this.detailTxt.TabIndex = 17;
            // 
            // nameTxt
            // 
            this.nameTxt.Enabled = false;
            this.nameTxt.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTxt.Location = new System.Drawing.Point(56, 61);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(141, 23);
            this.nameTxt.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 64);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 16);
            this.label12.TabIndex = 2;
            this.label12.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dr. Id";
            // 
            // Drtxt
            // 
            this.Drtxt.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Drtxt.Location = new System.Drawing.Point(56, 27);
            this.Drtxt.Name = "Drtxt";
            this.Drtxt.Size = new System.Drawing.Size(231, 23);
            this.Drtxt.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Date";
            // 
            // todayDatePicker
            // 
            this.todayDatePicker.CalendarFont = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todayDatePicker.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todayDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.todayDatePicker.Location = new System.Drawing.Point(56, 98);
            this.todayDatePicker.MaxDate = new System.DateTime(2019, 12, 31, 0, 0, 0, 0);
            this.todayDatePicker.MinDate = new System.DateTime(1909, 11, 24, 0, 0, 0, 0);
            this.todayDatePicker.Name = "todayDatePicker";
            this.todayDatePicker.Size = new System.Drawing.Size(182, 23);
            this.todayDatePicker.TabIndex = 18;
            this.todayDatePicker.Value = new System.DateTime(2018, 1, 5, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Detail";
            // 
            // patGridView
            // 
            this.patGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patGridView.Location = new System.Drawing.Point(388, 12);
            this.patGridView.Name = "patGridView";
            this.patGridView.Size = new System.Drawing.Size(315, 275);
            this.patGridView.TabIndex = 23;
            // 
            // editBtn
            // 
            this.editBtn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBtn.Location = new System.Drawing.Point(135, 235);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(103, 30);
            this.editBtn.TabIndex = 24;
            this.editBtn.Text = "Update";
            this.editBtn.UseVisualStyleBackColor = true;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(253, 235);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(103, 30);
            this.deleteBtn.TabIndex = 23;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            // 
            // addBtn
            // 
            this.addBtn.Enabled = false;
            this.addBtn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(9, 235);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(103, 30);
            this.addBtn.TabIndex = 22;
            this.addBtn.Text = "Add ";
            this.addBtn.UseVisualStyleBackColor = true;
            // 
            // AddHolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 295);
            this.Controls.Add(this.patGridView);
            this.Controls.Add(this.groupBox2);
            this.Name = "AddHolForm";
            this.Text = "Add Holiday Date";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button seachDrBtn;
        private System.Windows.Forms.TextBox detailTxt;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Drtxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker todayDatePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView patGridView;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button editBtn;
    }
}