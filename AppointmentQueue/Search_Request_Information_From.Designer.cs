namespace AppointmentQueue
{
    partial class Search_Request_Information_From
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.database1DataSet1 = new AppointmentQueue.Database1DataSet1();
            this.conditionRequestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.conditionRequestTableAdapter = new AppointmentQueue.Database1DataSet1TableAdapters.ConditionRequestTableAdapter();
            this.day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conditionRequestBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.day,
            this.time});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(653, 302);
            this.dataGridView1.TabIndex = 1;
            // 
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "Database1DataSet1";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // conditionRequestBindingSource
            // 
            this.conditionRequestBindingSource.DataMember = "ConditionRequest";
            this.conditionRequestBindingSource.DataSource = this.database1DataSet1;
            // 
            // conditionRequestTableAdapter
            // 
            this.conditionRequestTableAdapter.ClearBeforeFill = true;
            // 
            // day
            // 
            this.day.HeaderText = "day";
            this.day.Name = "day";
            // 
            // time
            // 
            this.time.HeaderText = "time";
            this.time.Name = "time";
            // 
            // Search_Request_Information_From
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 317);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Search_Request_Information_From";
            this.Text = "Search_Request_Information_From";
            this.Load += new System.EventHandler(this.Search_Request_Information_From_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conditionRequestBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private Database1DataSet1 database1DataSet1;
        private System.Windows.Forms.BindingSource conditionRequestBindingSource;
        private Database1DataSet1TableAdapters.ConditionRequestTableAdapter conditionRequestTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn day;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
    }
}