namespace AppointmentQueue
{
    partial class ScannerForm
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
            this.scanDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.scanId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.delBtn = new System.Windows.Forms.Button();
            this.insertBtn = new System.Windows.Forms.Button();
            this.scanName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.scanDataGridView)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // scanDataGridView
            // 
            this.scanDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.scanDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.scanDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scanDataGridView.Location = new System.Drawing.Point(4, 159);
            this.scanDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.scanDataGridView.Name = "scanDataGridView";
            this.scanDataGridView.Size = new System.Drawing.Size(497, 304);
            this.scanDataGridView.TabIndex = 61;
            this.scanDataGridView.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.scanDataGridView_RowHeaderMouseDoubleClick);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox3.Controls.Add(this.scanId);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.delBtn);
            this.groupBox3.Controls.Add(this.insertBtn);
            this.groupBox3.Controls.Add(this.scanName);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(4, 4);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(497, 155);
            this.groupBox3.TabIndex = 60;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Scanner Information";
            // 
            // scanId
            // 
            this.scanId.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scanId.Location = new System.Drawing.Point(120, 32);
            this.scanId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.scanId.Name = "scanId";
            this.scanId.Size = new System.Drawing.Size(351, 27);
            this.scanId.TabIndex = 63;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 62;
            this.label1.Text = "ScanID";
            // 
            // delBtn
            // 
            this.delBtn.Enabled = false;
            this.delBtn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delBtn.Location = new System.Drawing.Point(255, 111);
            this.delBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(217, 37);
            this.delBtn.TabIndex = 61;
            this.delBtn.Text = "Delete Scanner";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // insertBtn
            // 
            this.insertBtn.Enabled = false;
            this.insertBtn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertBtn.Location = new System.Drawing.Point(15, 111);
            this.insertBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(212, 37);
            this.insertBtn.TabIndex = 55;
            this.insertBtn.Text = "Insert Scanner ";
            this.insertBtn.UseVisualStyleBackColor = true;
            this.insertBtn.Click += new System.EventHandler(this.insertBtn_Click);
            // 
            // scanName
            // 
            this.scanName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scanName.Location = new System.Drawing.Point(120, 75);
            this.scanName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.scanName.Name = "scanName";
            this.scanName.Size = new System.Drawing.Size(351, 27);
            this.scanName.TabIndex = 32;
            this.scanName.TextChanged += new System.EventHandler(this.scanName_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(8, 75);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 20);
            this.label11.TabIndex = 31;
            this.label11.Text = "ScanName";
            // 
            // ScannerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 464);
            this.Controls.Add(this.scanDataGridView);
            this.Controls.Add(this.groupBox3);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ScannerForm";
            this.Text = "Scanner Management Form";
            ((System.ComponentModel.ISupportInitialize)(this.scanDataGridView)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView scanDataGridView;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Button insertBtn;
        private System.Windows.Forms.TextBox scanName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox scanId;
        private System.Windows.Forms.Label label1;
    }
}