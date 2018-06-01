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
            this.drReqId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.dofComb = new System.Windows.Forms.ComboBox();
            this.pedComb = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.drReqDelBtn = new System.Windows.Forms.Button();
            this.drReqAddBtn = new System.Windows.Forms.Button();
            this.drReqGidView = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.reqId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.reqComb = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.drDataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.drLnameTxt2 = new System.Windows.Forms.TextBox();
            this.drIdTxt = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.drNameTxt2 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.seachDrReq = new System.Windows.Forms.Button();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drReqGidView)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drDataGridView2)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox7.Controls.Add(this.seachDrReq);
            this.groupBox7.Controls.Add(this.drReqId);
            this.groupBox7.Controls.Add(this.label2);
            this.groupBox7.Controls.Add(this.label19);
            this.groupBox7.Controls.Add(this.dofComb);
            this.groupBox7.Controls.Add(this.pedComb);
            this.groupBox7.Controls.Add(this.label17);
            this.groupBox7.Controls.Add(this.drReqDelBtn);
            this.groupBox7.Controls.Add(this.drReqAddBtn);
            this.groupBox7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(381, 2);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(458, 176);
            this.groupBox7.TabIndex = 53;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Doctor Request Information";
            // 
            // drReqId
            // 
            this.drReqId.Enabled = false;
            this.drReqId.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drReqId.Location = new System.Drawing.Point(103, 27);
            this.drReqId.Name = "drReqId";
            this.drReqId.Size = new System.Drawing.Size(255, 23);
            this.drReqId.TabIndex = 67;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 66;
            this.label2.Text = "Req.ID";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(3, 71);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(91, 16);
            this.label19.TabIndex = 49;
            this.label19.Text = "Day of Week";
            // 
            // dofComb
            // 
            this.dofComb.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dofComb.FormattingEnabled = true;
            this.dofComb.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesay",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.dofComb.Location = new System.Drawing.Point(103, 63);
            this.dofComb.Name = "dofComb";
            this.dofComb.Size = new System.Drawing.Size(256, 24);
            this.dofComb.TabIndex = 48;
            // 
            // pedComb
            // 
            this.pedComb.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pedComb.FormattingEnabled = true;
            this.pedComb.Items.AddRange(new object[] {
            "Morning",
            "Afternoon",
            "Evening"});
            this.pedComb.Location = new System.Drawing.Point(103, 102);
            this.pedComb.Name = "pedComb";
            this.pedComb.Size = new System.Drawing.Size(256, 24);
            this.pedComb.TabIndex = 47;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(29, 105);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(48, 16);
            this.label17.TabIndex = 46;
            this.label17.Text = "Period";
            // 
            // drReqDelBtn
            // 
            this.drReqDelBtn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drReqDelBtn.Location = new System.Drawing.Point(254, 140);
            this.drReqDelBtn.Name = "drReqDelBtn";
            this.drReqDelBtn.Size = new System.Drawing.Size(189, 30);
            this.drReqDelBtn.TabIndex = 36;
            this.drReqDelBtn.Text = "Delete a doctor request";
            this.drReqDelBtn.UseVisualStyleBackColor = true;
            // 
            // drReqAddBtn
            // 
            this.drReqAddBtn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drReqAddBtn.Location = new System.Drawing.Point(6, 140);
            this.drReqAddBtn.Name = "drReqAddBtn";
            this.drReqAddBtn.Size = new System.Drawing.Size(195, 30);
            this.drReqAddBtn.TabIndex = 35;
            this.drReqAddBtn.Text = "Insert a new doctor request";
            this.drReqAddBtn.UseVisualStyleBackColor = true;
            this.drReqAddBtn.Click += new System.EventHandler(this.drReqAddBtn_Click);
            // 
            // drReqGidView
            // 
            this.drReqGidView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.drReqGidView.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.drReqGidView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.drReqGidView.Location = new System.Drawing.Point(381, 184);
            this.drReqGidView.Name = "drReqGidView";
            this.drReqGidView.Size = new System.Drawing.Size(458, 313);
            this.drReqGidView.TabIndex = 56;
            this.drReqGidView.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.drReqGidView_RowHeaderMouseDoubleClick);
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox6.Controls.Add(this.reqId);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Controls.Add(this.reqComb);
            this.groupBox6.Controls.Add(this.label20);
            this.groupBox6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(2, 268);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(373, 94);
            this.groupBox6.TabIndex = 54;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Request Information";
            // 
            // reqId
            // 
            this.reqId.Enabled = false;
            this.reqId.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reqId.Location = new System.Drawing.Point(84, 26);
            this.reqId.Name = "reqId";
            this.reqId.Size = new System.Drawing.Size(255, 23);
            this.reqId.TabIndex = 65;
            this.reqId.TextChanged += new System.EventHandler(this.scanId_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 64;
            this.label1.Text = "Req.ID";
            // 
            // reqComb
            // 
            this.reqComb.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reqComb.FormattingEnabled = true;
            this.reqComb.Location = new System.Drawing.Point(84, 55);
            this.reqComb.Name = "reqComb";
            this.reqComb.Size = new System.Drawing.Size(255, 24);
            this.reqComb.TabIndex = 42;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(12, 58);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(67, 16);
            this.label20.TabIndex = 35;
            this.label20.Text = "BodyPart";
            // 
            // drDataGridView2
            // 
            this.drDataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.drDataGridView2.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.drDataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.drDataGridView2.Location = new System.Drawing.Point(2, 134);
            this.drDataGridView2.Name = "drDataGridView2";
            this.drDataGridView2.Size = new System.Drawing.Size(373, 128);
            this.drDataGridView2.TabIndex = 55;
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
            this.groupBox4.Location = new System.Drawing.Point(2, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(373, 126);
            this.groupBox4.TabIndex = 52;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Doctor Information";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(6, 91);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 16);
            this.label14.TabIndex = 35;
            this.label14.Text = "LastName";
            // 
            // drLnameTxt2
            // 
            this.drLnameTxt2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drLnameTxt2.Location = new System.Drawing.Point(84, 88);
            this.drLnameTxt2.Name = "drLnameTxt2";
            this.drLnameTxt2.Size = new System.Drawing.Size(255, 23);
            this.drLnameTxt2.TabIndex = 34;
            this.drLnameTxt2.TextChanged += new System.EventHandler(this.drLnameTxt2_TextChanged);
            // 
            // drIdTxt
            // 
            this.drIdTxt.Enabled = false;
            this.drIdTxt.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drIdTxt.Location = new System.Drawing.Point(84, 30);
            this.drIdTxt.Name = "drIdTxt";
            this.drIdTxt.Size = new System.Drawing.Size(255, 23);
            this.drIdTxt.TabIndex = 32;
            this.drIdTxt.TextChanged += new System.EventHandler(this.drIdTxt_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(12, 59);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 16);
            this.label15.TabIndex = 29;
            this.label15.Text = "Dr.Name";
            // 
            // drNameTxt2
            // 
            this.drNameTxt2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drNameTxt2.Location = new System.Drawing.Point(84, 59);
            this.drNameTxt2.Name = "drNameTxt2";
            this.drNameTxt2.Size = new System.Drawing.Size(255, 23);
            this.drNameTxt2.TabIndex = 30;
            this.drNameTxt2.TextChanged += new System.EventHandler(this.drNameTxt2_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(17, 30);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(44, 16);
            this.label16.TabIndex = 31;
            this.label16.Text = "Dr. ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 368);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(373, 128);
            this.dataGridView1.TabIndex = 57;
            this.dataGridView1.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseDoubleClick);
            // 
            // seachDrReq
            // 
            this.seachDrReq.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seachDrReq.Location = new System.Drawing.Point(381, 59);
            this.seachDrReq.Margin = new System.Windows.Forms.Padding(2);
            this.seachDrReq.Name = "seachDrReq";
            this.seachDrReq.Size = new System.Drawing.Size(62, 30);
            this.seachDrReq.TabIndex = 68;
            this.seachDrReq.Text = "Search";
            this.seachDrReq.UseVisualStyleBackColor = true;
            this.seachDrReq.Click += new System.EventHandler(this.seachDrReq_Click);
            // 
            // DocterRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 502);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.drReqGidView);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.drDataGridView2);
            this.Controls.Add(this.groupBox4);
            this.Name = "DocterRequestForm";
            this.Text = "DocterRequestForm";
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drReqGidView)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drDataGridView2)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ComboBox dofComb;
        private System.Windows.Forms.ComboBox pedComb;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button drReqDelBtn;
        private System.Windows.Forms.Button drReqAddBtn;
        private System.Windows.Forms.DataGridView drReqGidView;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox reqComb;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DataGridView drDataGridView2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox drLnameTxt2;
        private System.Windows.Forms.TextBox drIdTxt;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox drNameTxt2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox reqId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox drReqId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button seachDrReq;
    }
}