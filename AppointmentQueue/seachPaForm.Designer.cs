﻿namespace AppointmentQueue
{
    partial class seachPaForm
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
            this.patGridView = new System.Windows.Forms.DataGridView();
            this.database1DataSet = new AppointmentQueue.Database1DataSet();
            this.patientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientsTableAdapter = new AppointmentQueue.Database1DataSetTableAdapters.PatientsTableAdapter();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.HNtxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lnametxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.acceptBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.patGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // patGridView
            // 
            this.patGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patGridView.Location = new System.Drawing.Point(6, 93);
            this.patGridView.Name = "patGridView";
            this.patGridView.Size = new System.Drawing.Size(482, 182);
            this.patGridView.TabIndex = 0;
            this.patGridView.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.patGridView_RowHeaderMouseDoubleClick);
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientsBindingSource
            // 
            this.patientsBindingSource.DataMember = "Patients";
            this.patientsBindingSource.DataSource = this.database1DataSet;
            // 
            // patientsTableAdapter
            // 
            this.patientsTableAdapter.ClearBeforeFill = true;
            // 
            // nametxt
            // 
            this.nametxt.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nametxt.Location = new System.Drawing.Point(49, 12);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(175, 23);
            this.nametxt.TabIndex = 7;
            this.nametxt.TextChanged += new System.EventHandler(this.HNtxt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            // 
            // HNtxt
            // 
            this.HNtxt.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HNtxt.Location = new System.Drawing.Point(49, 55);
            this.HNtxt.Name = "HNtxt";
            this.HNtxt.Size = new System.Drawing.Size(175, 23);
            this.HNtxt.TabIndex = 9;
            this.HNtxt.TextChanged += new System.EventHandler(this.HNtxt_TextChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "HN";
            // 
            // lnametxt
            // 
            this.lnametxt.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnametxt.Location = new System.Drawing.Point(313, 12);
            this.lnametxt.Name = "lnametxt";
            this.lnametxt.Size = new System.Drawing.Size(175, 23);
            this.lnametxt.TabIndex = 11;
            this.lnametxt.TextChanged += new System.EventHandler(this.lnametxt_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(230, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Last Name";
            // 
            // acceptBtn
            // 
            this.acceptBtn.Enabled = false;
            this.acceptBtn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acceptBtn.Location = new System.Drawing.Point(254, 50);
            this.acceptBtn.Name = "acceptBtn";
            this.acceptBtn.Size = new System.Drawing.Size(73, 30);
            this.acceptBtn.TabIndex = 21;
            this.acceptBtn.Text = "Accept";
            this.acceptBtn.UseVisualStyleBackColor = true;
            this.acceptBtn.Click += new System.EventHandler(this.acceptBtn_Click);
            // 
            // seachPaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 283);
            this.Controls.Add(this.acceptBtn);
            this.Controls.Add(this.lnametxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.HNtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.patGridView);
            this.Name = "seachPaForm";
            this.Text = "Seach Patient";
            this.Load += new System.EventHandler(this.seachPaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.patGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView patGridView;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource patientsBindingSource;
        private Database1DataSetTableAdapters.PatientsTableAdapter patientsTableAdapter;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox HNtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lnametxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button acceptBtn;
    }
}