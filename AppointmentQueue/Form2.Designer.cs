namespace AppointmentQueue
{
    partial class edit_CondReq_Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.possiblereqDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.condtimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conddayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.condlimittimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.condmrimachineidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conditionRequestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new AppointmentQueue.Database1DataSet();
            this.database1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.conditionRequestTableAdapter = new AppointmentQueue.Database1DataSetTableAdapters.ConditionRequestTableAdapter();
            this.edit_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.reqCob = new System.Windows.Forms.ComboBox();
            this.condReq_listV = new System.Windows.Forms.ListView();
            this.order_col = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name_req = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.remove_btn = new System.Windows.Forms.Button();
            this.add_req_btn = new System.Windows.Forms.Button();
            this.after_radioBtn = new System.Windows.Forms.RadioButton();
            this.morn_radioBtn = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.primary_key = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dof_txt = new System.Windows.Forms.Label();
            this.mac_txt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dutimeUpDo = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conditionRequestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dutimeUpDo)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.possiblereqDataGridViewTextBoxColumn,
            this.condtimeDataGridViewTextBoxColumn,
            this.conddayDataGridViewTextBoxColumn,
            this.condlimittimeDataGridViewTextBoxColumn,
            this.condmrimachineidDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.conditionRequestBindingSource;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridView1.Location = new System.Drawing.Point(1, 199);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridView1.Size = new System.Drawing.Size(663, 240);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseDoubleClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // possiblereqDataGridViewTextBoxColumn
            // 
            this.possiblereqDataGridViewTextBoxColumn.DataPropertyName = "possible_req";
            this.possiblereqDataGridViewTextBoxColumn.HeaderText = "possible_req";
            this.possiblereqDataGridViewTextBoxColumn.Name = "possiblereqDataGridViewTextBoxColumn";
            // 
            // condtimeDataGridViewTextBoxColumn
            // 
            this.condtimeDataGridViewTextBoxColumn.DataPropertyName = "cond_time";
            this.condtimeDataGridViewTextBoxColumn.HeaderText = "cond_time";
            this.condtimeDataGridViewTextBoxColumn.Name = "condtimeDataGridViewTextBoxColumn";
            // 
            // conddayDataGridViewTextBoxColumn
            // 
            this.conddayDataGridViewTextBoxColumn.DataPropertyName = "cond_day";
            this.conddayDataGridViewTextBoxColumn.HeaderText = "cond_day";
            this.conddayDataGridViewTextBoxColumn.Name = "conddayDataGridViewTextBoxColumn";
            // 
            // condlimittimeDataGridViewTextBoxColumn
            // 
            this.condlimittimeDataGridViewTextBoxColumn.DataPropertyName = "cond_limit_time";
            this.condlimittimeDataGridViewTextBoxColumn.HeaderText = "cond_limit_time";
            this.condlimittimeDataGridViewTextBoxColumn.Name = "condlimittimeDataGridViewTextBoxColumn";
            // 
            // condmrimachineidDataGridViewTextBoxColumn
            // 
            this.condmrimachineidDataGridViewTextBoxColumn.DataPropertyName = "cond_mri_machine_id";
            this.condmrimachineidDataGridViewTextBoxColumn.HeaderText = "cond_mri_machine_id";
            this.condmrimachineidDataGridViewTextBoxColumn.Name = "condmrimachineidDataGridViewTextBoxColumn";
            // 
            // conditionRequestBindingSource
            // 
            this.conditionRequestBindingSource.DataMember = "ConditionRequest";
            this.conditionRequestBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // database1DataSetBindingSource
            // 
            this.database1DataSetBindingSource.DataSource = this.database1DataSet;
            this.database1DataSetBindingSource.Position = 0;
            // 
            // conditionRequestTableAdapter
            // 
            this.conditionRequestTableAdapter.ClearBeforeFill = true;
            // 
            // edit_btn
            // 
            this.edit_btn.Enabled = false;
            this.edit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_btn.Location = new System.Drawing.Point(545, 153);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(89, 33);
            this.edit_btn.TabIndex = 0;
            this.edit_btn.Text = "Save";
            this.edit_btn.UseVisualStyleBackColor = true;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(362, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Request";
            // 
            // reqCob
            // 
            this.reqCob.Enabled = false;
            this.reqCob.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reqCob.FormattingEnabled = true;
            this.reqCob.Location = new System.Drawing.Point(436, 23);
            this.reqCob.Name = "reqCob";
            this.reqCob.Size = new System.Drawing.Size(198, 24);
            this.reqCob.TabIndex = 9;
            this.reqCob.SelectedIndexChanged += new System.EventHandler(this.reqCob_SelectedIndexChanged);
            // 
            // condReq_listV
            // 
            this.condReq_listV.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.condReq_listV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.order_col,
            this.primary_key,
            this.name_req});
            this.condReq_listV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.condReq_listV.ForeColor = System.Drawing.SystemColors.ControlText;
            this.condReq_listV.GridLines = true;
            this.condReq_listV.Location = new System.Drawing.Point(669, 0);
            this.condReq_listV.Name = "condReq_listV";
            this.condReq_listV.Size = new System.Drawing.Size(308, 442);
            this.condReq_listV.TabIndex = 4;
            this.condReq_listV.UseCompatibleStateImageBehavior = false;
            this.condReq_listV.View = System.Windows.Forms.View.Details;
            this.condReq_listV.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.condReq_listV_MouseDoubleClick);
            // 
            // order_col
            // 
            this.order_col.Text = "Order";
            this.order_col.Width = 44;
            // 
            // name_req
            // 
            this.name_req.Text = "Request";
            this.name_req.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.name_req.Width = 201;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox1.Controls.Add(this.dutimeUpDo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.mac_txt);
            this.groupBox1.Controls.Add(this.dof_txt);
            this.groupBox1.Controls.Add(this.remove_btn);
            this.groupBox1.Controls.Add(this.add_req_btn);
            this.groupBox1.Controls.Add(this.after_radioBtn);
            this.groupBox1.Controls.Add(this.morn_radioBtn);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.reqCob);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.edit_btn);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1, -3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(663, 196);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information";
            // 
            // remove_btn
            // 
            this.remove_btn.Enabled = false;
            this.remove_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remove_btn.Location = new System.Drawing.Point(545, 110);
            this.remove_btn.Name = "remove_btn";
            this.remove_btn.Size = new System.Drawing.Size(89, 33);
            this.remove_btn.TabIndex = 21;
            this.remove_btn.Text = "-";
            this.remove_btn.UseVisualStyleBackColor = true;
            this.remove_btn.Click += new System.EventHandler(this.remove_btn_Click);
            // 
            // add_req_btn
            // 
            this.add_req_btn.Enabled = false;
            this.add_req_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_req_btn.Location = new System.Drawing.Point(545, 64);
            this.add_req_btn.Name = "add_req_btn";
            this.add_req_btn.Size = new System.Drawing.Size(89, 33);
            this.add_req_btn.TabIndex = 20;
            this.add_req_btn.Text = "+";
            this.add_req_btn.UseVisualStyleBackColor = true;
            this.add_req_btn.Click += new System.EventHandler(this.add_req_btn_Click_1);
            // 
            // after_radioBtn
            // 
            this.after_radioBtn.AutoSize = true;
            this.after_radioBtn.Enabled = false;
            this.after_radioBtn.Location = new System.Drawing.Point(137, 156);
            this.after_radioBtn.Name = "after_radioBtn";
            this.after_radioBtn.Size = new System.Drawing.Size(98, 24);
            this.after_radioBtn.TabIndex = 19;
            this.after_radioBtn.Text = "Afternoon";
            this.after_radioBtn.UseVisualStyleBackColor = true;
            // 
            // morn_radioBtn
            // 
            this.morn_radioBtn.AutoSize = true;
            this.morn_radioBtn.Enabled = false;
            this.morn_radioBtn.Location = new System.Drawing.Point(20, 156);
            this.morn_radioBtn.Name = "morn_radioBtn";
            this.morn_radioBtn.Size = new System.Drawing.Size(84, 24);
            this.morn_radioBtn.TabIndex = 18;
            this.morn_radioBtn.Text = "Morning";
            this.morn_radioBtn.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(16, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Machine";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(16, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Day of Week";
            // 
            // primary_key
            // 
            this.primary_key.Text = "Code";
            // 
            // dof_txt
            // 
            this.dof_txt.AutoSize = true;
            this.dof_txt.Enabled = false;
            this.dof_txt.Location = new System.Drawing.Point(133, 38);
            this.dof_txt.Name = "dof_txt";
            this.dof_txt.Size = new System.Drawing.Size(21, 20);
            this.dof_txt.TabIndex = 22;
            this.dof_txt.Text = "...";
            // 
            // mac_txt
            // 
            this.mac_txt.AutoSize = true;
            this.mac_txt.Enabled = false;
            this.mac_txt.Location = new System.Drawing.Point(133, 77);
            this.mac_txt.Name = "mac_txt";
            this.mac_txt.Size = new System.Drawing.Size(25, 20);
            this.mac_txt.TabIndex = 23;
            this.mac_txt.Text = "....";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(16, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Duration";
            // 
            // dutimeUpDo
            // 
            this.dutimeUpDo.Enabled = false;
            this.dutimeUpDo.Location = new System.Drawing.Point(137, 113);
            this.dutimeUpDo.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.dutimeUpDo.Name = "dutimeUpDo";
            this.dutimeUpDo.Size = new System.Drawing.Size(120, 26);
            this.dutimeUpDo.TabIndex = 25;
            // 
            // edit_CondReq_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 445);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.condReq_listV);
            this.Controls.Add(this.dataGridView1);
            this.Name = "edit_CondReq_Form";
            this.Text = "Condition Request ";
            this.Load += new System.EventHandler(this.edit_CondReq_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conditionRequestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dutimeUpDo)).EndInit();
            this.ResumeLayout(false);

        }

        private void DataGridView1_RowHeaderMouseDoubleClick(object sender, System.Windows.Forms.DataGridViewCellMouseEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource database1DataSetBindingSource;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource conditionRequestBindingSource;
        private Database1DataSetTableAdapters.ConditionRequestTableAdapter conditionRequestTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn possiblereqDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn condtimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn conddayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn condlimittimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn condmrimachineidDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.ListView condReq_listV;
        private System.Windows.Forms.ColumnHeader order_col;
        private System.Windows.Forms.ColumnHeader name_req;
        private System.Windows.Forms.ComboBox reqCob;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton after_radioBtn;
        private System.Windows.Forms.RadioButton morn_radioBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button remove_btn;
        private System.Windows.Forms.Button add_req_btn;
        private System.Windows.Forms.ColumnHeader primary_key;
        private System.Windows.Forms.Label mac_txt;
        private System.Windows.Forms.Label dof_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown dutimeUpDo;
    }
}