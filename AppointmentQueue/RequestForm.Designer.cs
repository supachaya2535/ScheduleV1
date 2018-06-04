namespace AppointmentQueue
{
    partial class RequestForm
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
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.reqTime = new System.Windows.Forms.NumericUpDown();
            this.delBtn = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.insertBtn = new System.Windows.Forms.Button();
            this.reqDataGridView = new System.Windows.Forms.DataGridView();
            this.reqName = new System.Windows.Forms.TextBox();
            this.drReqId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reqTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reqDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox6.Controls.Add(this.drReqId);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.reqName);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Controls.Add(this.reqTime);
            this.groupBox6.Controls.Add(this.delBtn);
            this.groupBox6.Controls.Add(this.label20);
            this.groupBox6.Controls.Add(this.insertBtn);
            this.groupBox6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(1, 1);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(373, 155);
            this.groupBox6.TabIndex = 58;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Request Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 45;
            this.label1.Text = "RequiredTime";
            // 
            // reqTime
            // 
            this.reqTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reqTime.Location = new System.Drawing.Point(115, 84);
            this.reqTime.Maximum = new decimal(new int[] {
            365,
            0,
            0,
            0});
            this.reqTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.reqTime.Name = "reqTime";
            this.reqTime.Size = new System.Drawing.Size(143, 22);
            this.reqTime.TabIndex = 44;
            this.reqTime.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // delBtn
            // 
            this.delBtn.Enabled = false;
            this.delBtn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delBtn.Location = new System.Drawing.Point(193, 117);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(170, 30);
            this.delBtn.TabIndex = 43;
            this.delBtn.Text = "Delete a request";
            this.delBtn.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(25, 58);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(67, 16);
            this.label20.TabIndex = 35;
            this.label20.Text = "BodyPart";
            // 
            // insertBtn
            // 
            this.insertBtn.Enabled = false;
            this.insertBtn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertBtn.Location = new System.Drawing.Point(7, 117);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(180, 30);
            this.insertBtn.TabIndex = 38;
            this.insertBtn.Text = "Save adjusting request";
            this.insertBtn.UseVisualStyleBackColor = true;
            this.insertBtn.Click += new System.EventHandler(this.reqEditBtn_Click);
            // 
            // reqDataGridView
            // 
            this.reqDataGridView.AllowUserToOrderColumns = true;
            this.reqDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.reqDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.reqDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reqDataGridView.Location = new System.Drawing.Point(1, 162);
            this.reqDataGridView.Name = "reqDataGridView";
            this.reqDataGridView.Size = new System.Drawing.Size(373, 345);
            this.reqDataGridView.TabIndex = 59;
            // 
            // reqName
            // 
            this.reqName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reqName.Location = new System.Drawing.Point(115, 55);
            this.reqName.Name = "reqName";
            this.reqName.Size = new System.Drawing.Size(233, 23);
            this.reqName.TabIndex = 46;
            // 
            // drReqId
            // 
            this.drReqId.Enabled = false;
            this.drReqId.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drReqId.Location = new System.Drawing.Point(115, 26);
            this.drReqId.Name = "drReqId";
            this.drReqId.Size = new System.Drawing.Size(233, 23);
            this.drReqId.TabIndex = 69;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 68;
            this.label2.Text = "Req.ID";
            // 
            // RequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 508);
            this.Controls.Add(this.reqDataGridView);
            this.Controls.Add(this.groupBox6);
            this.Name = "RequestForm";
            this.Text = "mageRequestForm";
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reqTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reqDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button insertBtn;
        private System.Windows.Forms.DataGridView reqDataGridView;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown reqTime;
        private System.Windows.Forms.TextBox reqName;
        private System.Windows.Forms.TextBox drReqId;
        private System.Windows.Forms.Label label2;
    }
}