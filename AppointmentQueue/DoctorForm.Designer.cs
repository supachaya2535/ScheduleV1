namespace AppointmentQueue
{
    partial class DoctorForm
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
            this.drDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.acceptBtn = new System.Windows.Forms.Button();
            this.drLnameTxt = new System.Windows.Forms.TextBox();
            this.Idtxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.drNameTxt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.drDelBtn = new System.Windows.Forms.Button();
            this.drInsertBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.drDataGridView)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // drDataGridView
            // 
            this.drDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.drDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.drDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.drDataGridView.Location = new System.Drawing.Point(1, 166);
            this.drDataGridView.Name = "drDataGridView";
            this.drDataGridView.Size = new System.Drawing.Size(448, 375);
            this.drDataGridView.TabIndex = 61;
            this.drDataGridView.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.drDataGridView_RowHeaderMouseDoubleClick);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox3.Controls.Add(this.drLnameTxt);
            this.groupBox3.Controls.Add(this.Idtxt);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.drNameTxt);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(4, 7);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(445, 119);
            this.groupBox3.TabIndex = 60;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Seach Doctor";
            // 
            // acceptBtn
            // 
            this.acceptBtn.Enabled = false;
            this.acceptBtn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acceptBtn.Location = new System.Drawing.Point(269, 132);
            this.acceptBtn.Name = "acceptBtn";
            this.acceptBtn.Size = new System.Drawing.Size(108, 30);
            this.acceptBtn.TabIndex = 63;
            this.acceptBtn.Text = "Accept";
            this.acceptBtn.UseVisualStyleBackColor = true;
            this.acceptBtn.Click += new System.EventHandler(this.acceptBtn_Click);
            // 
            // drLnameTxt
            // 
            this.drLnameTxt.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drLnameTxt.Location = new System.Drawing.Point(86, 88);
            this.drLnameTxt.Name = "drLnameTxt";
            this.drLnameTxt.Size = new System.Drawing.Size(343, 23);
            this.drLnameTxt.TabIndex = 34;
            this.drLnameTxt.TextChanged += new System.EventHandler(this.drLnameTxt_TextChanged);
            // 
            // Idtxt
            // 
            this.Idtxt.Enabled = false;
            this.Idtxt.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Idtxt.Location = new System.Drawing.Point(86, 33);
            this.Idtxt.Name = "Idtxt";
            this.Idtxt.Size = new System.Drawing.Size(343, 23);
            this.Idtxt.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 16);
            this.label9.TabIndex = 33;
            this.label9.Text = "Last Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(8, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 16);
            this.label10.TabIndex = 29;
            this.label10.Text = "Dr.Name";
            // 
            // drNameTxt
            // 
            this.drNameTxt.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drNameTxt.Location = new System.Drawing.Point(86, 60);
            this.drNameTxt.Name = "drNameTxt";
            this.drNameTxt.Size = new System.Drawing.Size(343, 23);
            this.drNameTxt.TabIndex = 30;
            this.drNameTxt.TextChanged += new System.EventHandler(this.drNameTxt_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(8, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 16);
            this.label11.TabIndex = 31;
            this.label11.Text = "Dr. ID";
            // 
            // drDelBtn
            // 
            this.drDelBtn.Enabled = false;
            this.drDelBtn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drDelBtn.Location = new System.Drawing.Point(140, 132);
            this.drDelBtn.Name = "drDelBtn";
            this.drDelBtn.Size = new System.Drawing.Size(114, 30);
            this.drDelBtn.TabIndex = 61;
            this.drDelBtn.Text = "Delete";
            this.drDelBtn.UseVisualStyleBackColor = true;
            this.drDelBtn.Click += new System.EventHandler(this.drDelBtn_Click);
            // 
            // drInsertBtn
            // 
            this.drInsertBtn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drInsertBtn.Location = new System.Drawing.Point(4, 132);
            this.drInsertBtn.Name = "drInsertBtn";
            this.drInsertBtn.Size = new System.Drawing.Size(123, 30);
            this.drInsertBtn.TabIndex = 55;
            this.drInsertBtn.Text = "Insert";
            this.drInsertBtn.UseVisualStyleBackColor = true;
            this.drInsertBtn.Click += new System.EventHandler(this.drInsertBtn_Click);
            // 
            // DoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 544);
            this.Controls.Add(this.acceptBtn);
            this.Controls.Add(this.drDataGridView);
            this.Controls.Add(this.drDelBtn);
            this.Controls.Add(this.drInsertBtn);
            this.Controls.Add(this.groupBox3);
            this.Name = "DoctorForm";
            this.Text = "doctorForm";
            ((System.ComponentModel.ISupportInitialize)(this.drDataGridView)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView drDataGridView;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button drDelBtn;
        private System.Windows.Forms.Button drInsertBtn;
        private System.Windows.Forms.TextBox drLnameTxt;
        private System.Windows.Forms.TextBox Idtxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox drNameTxt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button acceptBtn;
    }
}