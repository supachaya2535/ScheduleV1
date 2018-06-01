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
            this.reqComb = new System.Windows.Forms.ComboBox();
            this.scanComb = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.insertBtn = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.reqDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reqTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reqDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Controls.Add(this.reqTime);
            this.groupBox6.Controls.Add(this.delBtn);
            this.groupBox6.Controls.Add(this.reqComb);
            this.groupBox6.Controls.Add(this.scanComb);
            this.groupBox6.Controls.Add(this.label20);
            this.groupBox6.Controls.Add(this.insertBtn);
            this.groupBox6.Controls.Add(this.label21);
            this.groupBox6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(1, 1);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(373, 177);
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
            this.reqTime.Location = new System.Drawing.Point(131, 87);
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
            this.reqTime.Size = new System.Drawing.Size(179, 22);
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
            this.delBtn.Location = new System.Drawing.Point(209, 132);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(154, 30);
            this.delBtn.TabIndex = 43;
            this.delBtn.Text = "Delete a new request";
            this.delBtn.UseVisualStyleBackColor = true;
            // 
            // reqComb
            // 
            this.reqComb.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reqComb.FormattingEnabled = true;
            this.reqComb.Location = new System.Drawing.Point(84, 57);
            this.reqComb.Name = "reqComb";
            this.reqComb.Size = new System.Drawing.Size(226, 24);
            this.reqComb.TabIndex = 42;
            // 
            // scanComb
            // 
            this.scanComb.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scanComb.FormattingEnabled = true;
            this.scanComb.Location = new System.Drawing.Point(84, 27);
            this.scanComb.Name = "scanComb";
            this.scanComb.Size = new System.Drawing.Size(226, 24);
            this.scanComb.TabIndex = 41;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(11, 60);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(67, 16);
            this.label20.TabIndex = 35;
            this.label20.Text = "BodyPart";
            // 
            // insertBtn
            // 
            this.insertBtn.Enabled = false;
            this.insertBtn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertBtn.Location = new System.Drawing.Point(11, 132);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(159, 30);
            this.insertBtn.TabIndex = 38;
            this.insertBtn.Text = "Insert a new request";
            this.insertBtn.UseVisualStyleBackColor = true;
            this.insertBtn.Click += new System.EventHandler(this.reqEditBtn_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(11, 30);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(62, 16);
            this.label21.TabIndex = 29;
            this.label21.Text = "Scanner";
            // 
            // reqDataGridView
            // 
            this.reqDataGridView.AllowUserToOrderColumns = true;
            this.reqDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.reqDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.reqDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reqDataGridView.Location = new System.Drawing.Point(1, 184);
            this.reqDataGridView.Name = "reqDataGridView";
            this.reqDataGridView.Size = new System.Drawing.Size(373, 255);
            this.reqDataGridView.TabIndex = 59;
            // 
            // RequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 439);
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
        private System.Windows.Forms.ComboBox reqComb;
        private System.Windows.Forms.ComboBox scanComb;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button insertBtn;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DataGridView reqDataGridView;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown reqTime;
    }
}