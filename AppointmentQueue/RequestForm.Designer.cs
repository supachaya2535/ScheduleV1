﻿namespace AppointmentQueue
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
            this.drReqId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.reqName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.reqTime = new System.Windows.Forms.NumericUpDown();
            this.label20 = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.reqDataGridView = new System.Windows.Forms.DataGridView();
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
            this.groupBox6.Controls.Add(this.label20);
            this.groupBox6.Controls.Add(this.saveBtn);
            this.groupBox6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(1, 1);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox6.Size = new System.Drawing.Size(497, 191);
            this.groupBox6.TabIndex = 58;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Request Information";
            // 
            // drReqId
            // 
            this.drReqId.Enabled = false;
            this.drReqId.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drReqId.Location = new System.Drawing.Point(153, 32);
            this.drReqId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.drReqId.Name = "drReqId";
            this.drReqId.Size = new System.Drawing.Size(309, 27);
            this.drReqId.TabIndex = 69;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 68;
            this.label2.Text = "Req.ID";
            // 
            // reqName
            // 
            this.reqName.Enabled = false;
            this.reqName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reqName.Location = new System.Drawing.Point(153, 68);
            this.reqName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reqName.Name = "reqName";
            this.reqName.Size = new System.Drawing.Size(309, 27);
            this.reqName.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 110);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 45;
            this.label1.Text = "RequiredTime";
            // 
            // reqTime
            // 
            this.reqTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reqTime.Location = new System.Drawing.Point(153, 103);
            this.reqTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reqTime.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.reqTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.reqTime.Name = "reqTime";
            this.reqTime.Size = new System.Drawing.Size(191, 26);
            this.reqTime.TabIndex = 44;
            this.reqTime.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.reqTime.ValueChanged += new System.EventHandler(this.reqTime_ValueChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(33, 71);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(86, 20);
            this.label20.TabIndex = 35;
            this.label20.Text = "BodyPart";
            // 
            // saveBtn
            // 
            this.saveBtn.Enabled = false;
            this.saveBtn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(127, 146);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(240, 37);
            this.saveBtn.TabIndex = 38;
            this.saveBtn.Text = "Save adjusting request";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.reqEditBtn_Click);
            // 
            // reqDataGridView
            // 
            this.reqDataGridView.AllowUserToOrderColumns = true;
            this.reqDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.reqDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.reqDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reqDataGridView.Location = new System.Drawing.Point(1, 199);
            this.reqDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reqDataGridView.Name = "reqDataGridView";
            this.reqDataGridView.Size = new System.Drawing.Size(497, 425);
            this.reqDataGridView.TabIndex = 59;
            this.reqDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.reqDataGridView_CellContentClick);
            this.reqDataGridView.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.reqDataGridView_RowHeaderMouseDoubleClick);
            // 
            // RequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 625);
            this.Controls.Add(this.reqDataGridView);
            this.Controls.Add(this.groupBox6);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.DataGridView reqDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown reqTime;
        private System.Windows.Forms.TextBox reqName;
        private System.Windows.Forms.TextBox drReqId;
        private System.Windows.Forms.Label label2;
    }
}