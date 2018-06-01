using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace AppointmentQueue
{
    public partial class ScannerForm : Form
    {
        public bool exit = false;
        public ScannerForm()
        {
            InitializeComponent();
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            try {
                if (MessageBox.Show("Do you want to insert a new appointment?", "Insert new appointment", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SqlConnection cn = new SqlConnection(global::AppointmentQueue.Properties.Settings.Default.Database1ConnectionString);
                    SqlCommand command = new SqlCommand(
                        "INSERT INTO Scanners (scan_name,scan_detail) " +
                        "VALUE (@scan_name,@scan_detail)", cn);

                   command.Parameters.AddWithValue("@scan_name", scanName.Text);
                   command.Parameters.AddWithValue("@scan_detail", drDetail.Text);
                    command.Connection = cn;

                    cn.Open();
                    command.ExecuteNonQuery();
                    cn.Close();
                }

            }
            catch (SystemException ex)
            {
                MessageBox.Show(string.Format("Couldn't insert a new record : An error occurred: {0}", ex.Message));
            }
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to insert a new appointment?", "Insert new appointment", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SqlConnection cn = new SqlConnection(global::AppointmentQueue.Properties.Settings.Default.Database1ConnectionString);

                    SqlCommand command = new SqlCommand("DELETE FROM Scanners  WHERE scan_id = " + scanId.Text.Trim(), cn);
                    cn.Open();
                    command.ExecuteNonQuery();
                    cn.Close();
                }
                
            }
            catch (SystemException ex)
            {
                MessageBox.Show(string.Format("Couldn't insert a new record : An error occurred: {0}", ex.Message));
            }
        }
    
    }
}
