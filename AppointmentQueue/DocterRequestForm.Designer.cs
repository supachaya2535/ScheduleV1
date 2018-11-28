namespace AppointmentQueue
{
    partial class DocterRequestForm
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
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.kidCheckBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.reqComb = new System.Windows.Forms.ComboBox();
            this.drName2 = new System.Windows.Forms.TextBox();
            this.seachDrReq = new System.Windows.Forms.Button();
            this.drReqId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.drReqDelBtn = new System.Windows.Forms.Button();
            this.drReqAddBtn = new System.Windows.Forms.Button();
            this.drReqGidView = new System.Windows.Forms.DataGridView();
            this.drDataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.drLnameTxt2 = new System.Windows.Forms.TextBox();
            this.drIdTxt = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.drNameTxt2 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drReqGidView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drDataGridView2)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox7.Controls.Add(this.kidCheckBox);
            this.groupBox7.Controls.Add(this.label4);
            this.groupBox7.Controls.Add(this.label3);
            this.groupBox7.Controls.Add(this.reqComb);
            this.groupBox7.Controls.Add(this.drName2);
            this.groupBox7.Controls.Add(this.seachDrReq);
            this.groupBox7.Controls.Add(this.drReqId);
            this.groupBox7.Controls.Add(this.label2);
            this.groupBox7.Controls.Add(this.drReqDelBtn);
            this.groupBox7.Controls.Add(this.drReqAddBtn);
            this.groupBox7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(476, 2);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox7.Size = new System.Drawing.Size(647, 208);
            this.groupBox7.TabIndex = 53;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Doctor Request Information";
            // 
            // kidCheckBox
            // 
            this.kidCheckBox.AutoSize = true;
            this.kidCheckBox.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kidCheckBox.Location = new System.Drawing.Point(384, 36);
            this.kidCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kidCheckBox.Name = "kidCheckBox";
            this.kidCheckBox.Size = new System.Drawing.Size(180, 24);
            this.kidCheckBox.TabIndex = 72;
            this.kidCheckBox.Text = "Pediatric Patients";
            this.kidCheckBox.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(80, 117);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 66;
            this.label4.Text = "Request";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(89, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 71;
            this.label3.Text = "Dr.Name";
            // 
            // reqComb
            // 
            this.reqComb.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reqComb.FormattingEnabled = true;
            this.reqComb.Location = new System.Drawing.Point(193, 117);
            this.reqComb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reqComb.Name = "reqComb";
            this.reqComb.Size = new System.Drawing.Size(440, 26);
            this.reqComb.TabIndex = 42;
            this.reqComb.SelectedIndexChanged += new System.EventHandler(this.reqComb_SelectedIndexChanged);
            // 
            // drName2
            // 
            this.drName2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drName2.Location = new System.Drawing.Point(192, 71);
            this.drName2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.drName2.Name = "drName2";
            this.drName2.Size = new System.Drawing.Size(249, 27);
            this.drName2.TabIndex = 69;
            // 
            // seachDrReq
            // 
            this.seachDrReq.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seachDrReq.Location = new System.Drawing.Point(451, 66);
            this.seachDrReq.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.seachDrReq.Name = "seachDrReq";
            this.seachDrReq.Size = new System.Drawing.Size(182, 37);
            this.seachDrReq.TabIndex = 68;
            this.seachDrReq.Text = "Search Dr. Name";
            this.seachDrReq.UseVisualStyleBackColor = true;
            this.seachDrReq.Click += new System.EventHandler(this.seachDrReq_Click);
            // 
            // drReqId
            // 
            this.drReqId.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.drReqId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.drReqId.Enabled = false;
            this.drReqId.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drReqId.Location = new System.Drawing.Point(193, 33);
            this.drReqId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.drReqId.Name = "drReqId";
            this.drReqId.Size = new System.Drawing.Size(151, 20);
            this.drReqId.TabIndex = 67;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 66;
            this.label2.Text = "Dr. Req. ID";
            // 
            // drReqDelBtn
            // 
            this.drReqDelBtn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drReqDelBtn.Location = new System.Drawing.Point(381, 155);
            this.drReqDelBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.drReqDelBtn.Name = "drReqDelBtn";
            this.drReqDelBtn.Size = new System.Drawing.Size(252, 37);
            this.drReqDelBtn.TabIndex = 36;
            this.drReqDelBtn.Text = "Delete Docter Request";
            this.drReqDelBtn.UseVisualStyleBackColor = true;
            this.drReqDelBtn.Click += new System.EventHandler(this.drReqDelBtn_Click);
            // 
            // drReqAddBtn
            // 
            this.drReqAddBtn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drReqAddBtn.Location = new System.Drawing.Point(8, 155);
            this.drReqAddBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.drReqAddBtn.Name = "drReqAddBtn";
            this.drReqAddBtn.Size = new System.Drawing.Size(260, 37);
            this.drReqAddBtn.TabIndex = 35;
            this.drReqAddBtn.Text = "Insert New Doctor Request";
            this.drReqAddBtn.UseVisualStyleBackColor = true;
            this.drReqAddBtn.Click += new System.EventHandler(this.drReqAddBtn_Click);
            // 
            // drReqGidView
            // 
            this.drReqGidView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.drReqGidView.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.drReqGidView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.drReqGidView.Location = new System.Drawing.Point(476, 218);
            this.drReqGidView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.drReqGidView.Name = "drReqGidView";
            this.drReqGidView.Size = new System.Drawing.Size(647, 394);
            this.drReqGidView.TabIndex = 56;
            this.drReqGidView.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.drReqGidView_RowHeaderMouseDoubleClick);
            // 
            // drDataGridView2
            // 
            this.drDataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.drDataGridView2.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.drDataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.drDataGridView2.Location = new System.Drawing.Point(3, 165);
            this.drDataGridView2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.drDataGridView2.Name = "drDataGridView2";
            this.drDataGridView2.Size = new System.Drawing.Size(465, 447);
            this.drDataGridView2.TabIndex = 55;
            this.drDataGridView2.ColumnHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.drDataGridView2_ColumnHeaderMouseDoubleClick);
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
            this.groupBox4.Location = new System.Drawing.Point(3, 2);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(465, 155);
            this.groupBox4.TabIndex = 52;
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
            // DocterRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 618);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.drReqGidView);
            this.Controls.Add(this.drDataGridView2);
            this.Controls.Add(this.groupBox4);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DocterRequestForm";
            this.Text = "DocterRequestForm";
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drReqGidView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drDataGridView2)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button drReqDelBtn;
        private System.Windows.Forms.Button drReqAddBtn;
        private System.Windows.Forms.DataGridView drReqGidView;
        private System.Windows.Forms.ComboBox reqComb;
        private System.Windows.Forms.DataGridView drDataGridView2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox drLnameTxt2;
        private System.Windows.Forms.TextBox drIdTxt;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox drNameTxt2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox drReqId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button seachDrReq;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox drName2;
        private System.Windows.Forms.CheckBox kidCheckBox;
    }
}