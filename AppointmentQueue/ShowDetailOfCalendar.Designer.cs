namespace AppointmentQueue
{
    partial class ShowDetailOfCalendar
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
            this.detail_tb = new System.Windows.Forms.TextBox();
            this.close_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // detail_tb
            // 
            this.detail_tb.Location = new System.Drawing.Point(12, 12);
            this.detail_tb.Multiline = true;
            this.detail_tb.Name = "detail_tb";
            this.detail_tb.ReadOnly = true;
            this.detail_tb.Size = new System.Drawing.Size(486, 569);
            this.detail_tb.TabIndex = 0;
            // 
            // close_btn
            // 
            this.close_btn.Location = new System.Drawing.Point(12, 587);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(486, 41);
            this.close_btn.TabIndex = 1;
            this.close_btn.Text = "Close Detail";
            this.close_btn.UseVisualStyleBackColor = true;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // ShowDetailOfCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 640);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.detail_tb);
            this.Name = "ShowDetailOfCalendar";
            this.Text = "ShowDetailOfCalendar";
            this.Load += new System.EventHandler(this.ShowDetailOfCalendar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox detail_tb;
        private System.Windows.Forms.Button close_btn;
    }
}