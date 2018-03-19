namespace AppointmentQueue
{
    partial class UpdateRequestsForm
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
            this.datagridview_req = new System.Windows.Forms.DataGridView();
            this.reqIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reqscanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reqbodypartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reqtimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet1 = new AppointmentQueue.Database1DataSet1();
            this.requestsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.requestsTableAdapter = new AppointmentQueue.Database1DataSet1TableAdapters.RequestsTableAdapter();
            this.txt_req_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_insert = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_req_scan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_req_bodypart = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_req_time = new System.Windows.Forms.TextBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_req)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // datagridview_req
            // 
            this.datagridview_req.AutoGenerateColumns = false;
            this.datagridview_req.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridview_req.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reqIdDataGridViewTextBoxColumn,
            this.reqscanDataGridViewTextBoxColumn,
            this.reqbodypartDataGridViewTextBoxColumn,
            this.reqtimeDataGridViewTextBoxColumn});
            this.datagridview_req.DataSource = this.requestsBindingSource1;
            this.datagridview_req.Location = new System.Drawing.Point(9, 141);
            this.datagridview_req.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.datagridview_req.Name = "datagridview_req";
            this.datagridview_req.RowHeadersWidth = 50;
            this.datagridview_req.RowTemplate.Height = 24;
            this.datagridview_req.Size = new System.Drawing.Size(455, 223);
            this.datagridview_req.TabIndex = 1;
            this.datagridview_req.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.datagridview_req_RowHeaderMouseClick);
            // 
            // reqIdDataGridViewTextBoxColumn
            // 
            this.reqIdDataGridViewTextBoxColumn.DataPropertyName = "req_Id";
            this.reqIdDataGridViewTextBoxColumn.HeaderText = "req_Id";
            this.reqIdDataGridViewTextBoxColumn.Name = "reqIdDataGridViewTextBoxColumn";
            this.reqIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reqscanDataGridViewTextBoxColumn
            // 
            this.reqscanDataGridViewTextBoxColumn.DataPropertyName = "req_scan";
            this.reqscanDataGridViewTextBoxColumn.HeaderText = "req_scan";
            this.reqscanDataGridViewTextBoxColumn.Name = "reqscanDataGridViewTextBoxColumn";
            // 
            // reqbodypartDataGridViewTextBoxColumn
            // 
            this.reqbodypartDataGridViewTextBoxColumn.DataPropertyName = "req_bodypart";
            this.reqbodypartDataGridViewTextBoxColumn.HeaderText = "req_bodypart";
            this.reqbodypartDataGridViewTextBoxColumn.Name = "reqbodypartDataGridViewTextBoxColumn";
            // 
            // reqtimeDataGridViewTextBoxColumn
            // 
            this.reqtimeDataGridViewTextBoxColumn.DataPropertyName = "req_time";
            this.reqtimeDataGridViewTextBoxColumn.HeaderText = "req_time";
            this.reqtimeDataGridViewTextBoxColumn.Name = "reqtimeDataGridViewTextBoxColumn";
            // 
            // requestsBindingSource1
            // 
            this.requestsBindingSource1.DataMember = "Requests";
            this.requestsBindingSource1.DataSource = this.database1DataSet1;
            // 
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "Database1DataSet1";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // requestsTableAdapter
            // 
            this.requestsTableAdapter.ClearBeforeFill = true;
            // 
            // txt_req_id
            // 
            this.txt_req_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txt_req_id.Location = new System.Drawing.Point(98, 12);
            this.txt_req_id.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_req_id.Name = "txt_req_id";
            this.txt_req_id.ReadOnly = true;
            this.txt_req_id.Size = new System.Drawing.Size(114, 24);
            this.txt_req_id.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(60, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID";
            // 
            // btn_insert
            // 
            this.btn_insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btn_insert.Location = new System.Drawing.Point(16, 90);
            this.btn_insert.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(89, 32);
            this.btn_insert.TabIndex = 10;
            this.btn_insert.Text = "Insert";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(258, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "Scan";
            // 
            // txt_req_scan
            // 
            this.txt_req_scan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txt_req_scan.Location = new System.Drawing.Point(327, 11);
            this.txt_req_scan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_req_scan.Name = "txt_req_scan";
            this.txt_req_scan.Size = new System.Drawing.Size(114, 24);
            this.txt_req_scan.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(13, 51);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 18);
            this.label3.TabIndex = 16;
            this.label3.Text = "Request";
            // 
            // txt_req_bodypart
            // 
            this.txt_req_bodypart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txt_req_bodypart.Location = new System.Drawing.Point(98, 48);
            this.txt_req_bodypart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_req_bodypart.Name = "txt_req_bodypart";
            this.txt_req_bodypart.Size = new System.Drawing.Size(114, 24);
            this.txt_req_bodypart.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.Location = new System.Drawing.Point(259, 49);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 18);
            this.label4.TabIndex = 18;
            this.label4.Text = "Time";
            // 
            // txt_req_time
            // 
            this.txt_req_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txt_req_time.Location = new System.Drawing.Point(327, 47);
            this.txt_req_time.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_req_time.Name = "txt_req_time";
            this.txt_req_time.Size = new System.Drawing.Size(114, 24);
            this.txt_req_time.TabIndex = 17;
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btn_delete.Location = new System.Drawing.Point(341, 90);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(100, 32);
            this.btn_delete.TabIndex = 19;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btn_update.Location = new System.Drawing.Point(176, 90);
            this.btn_update.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(104, 32);
            this.btn_update.TabIndex = 20;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // UpdateRequestsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 374);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_req_time);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_req_bodypart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_req_scan);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_req_id);
            this.Controls.Add(this.datagridview_req);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UpdateRequestsForm";
            this.Text = "UpdateRequestsForm";
            this.Load += new System.EventHandler(this.UpdateRequestsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_req)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView datagridview_req;
        private System.Windows.Forms.BindingSource requestsBindingSource;
        private Database1DataSet1TableAdapters.RequestsTableAdapter requestsTableAdapter;
        private System.Windows.Forms.TextBox txt_req_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_req_scan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_req_bodypart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_req_time;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.DataGridViewTextBoxColumn reqIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reqscanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reqbodypartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reqtimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource requestsBindingSource1;
        private Database1DataSet1 database1DataSet1;
    }
}