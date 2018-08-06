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
            DataTable dt = SQL.GetScanner("");
            scanDataGridView.DataSource = dt;
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            try {
                if (MessageBox.Show("Do you want to insert a new appointment?", "Insert new appointment", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SqlConnection cn = new SqlConnection(global::AppointmentQueue.Properties.Settings.Default.Database1ConnectionString);
                    SqlCommand command = new SqlCommand(
                        "INSERT INTO Scanners (scan_name) " +
                        "VALUES (@scan_name)", cn);

                   command.Parameters.AddWithValue("@scan_name", scanName.Text);
                    command.Connection = cn;

                    cn.Open();
                    command.ExecuteNonQuery();
                    cn.Close();
                    DataTable dt = SQL.GetScanner("");
                    scanDataGridView.DataSource = dt;
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
                    DataTable dt = SQL.GetScanner("");
                    scanDataGridView.DataSource = dt;
                }
                
            }
            catch (SystemException ex)
            {
                MessageBox.Show(string.Format("Couldn't insert a new record : An error occurred: {0}", ex.Message));
            }
        }

        private void scanName_TextChanged(object sender, EventArgs e)
        {
            insertBtn.Enabled = true;
        }

        private void scanDataGridView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int ID = scanDataGridView.CurrentCell.RowIndex;
            scanId.Text = scanDataGridView.Rows[ID].Cells[0].Value.ToString().Trim();
            scanName.Text = scanDataGridView.Rows[ID].Cells[1].Value.ToString().Trim();
        }
    }
}
