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
    public partial class RequestForm : Form
    {
        public static String ConnectionStr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + Environment.CurrentDirectory.Split(new string[] { "bin" }, StringSplitOptions.None)[0] + "Database1.mdf;Integrated Security=True";

        public RequestForm()
        {
            InitializeComponent();
            DataTable dt = SQL.GetRequests("");
            reqDataGridView.DataSource = dt;
            SQL.ChangeHeaderText(dt, reqDataGridView);
        }

        private void reqEditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to insert a new request?", "Insert new request", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SqlConnection cn = new SqlConnection(ConnectionStr);
                    SqlCommand command = new SqlCommand(
                        "UPDATE Requests SET req_time = @newV " +
                        "WHERE req_Id = @req_Id"
                        , cn);
                    command.Parameters.AddWithValue("@newV", reqTime.Value);
                    command.Parameters.AddWithValue("@req_Id", Convert.ToInt16(drReqId.Text));
                    command.Connection = cn;

                    cn.Open();
                    command.ExecuteNonQuery();
                    cn.Close();
                    reqDataGridView.DataSource = SQL.GetRequests("");
                }

            }
            catch (SystemException ex)
            {
                MessageBox.Show(string.Format("Couldn't save a new value : An error occurred: {0}", ex.Message));
            }

        }

        private void reqDataGridView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int ID = reqDataGridView.CurrentCell.RowIndex;
            drReqId.Text = reqDataGridView.Rows[ID].Cells[0].Value.ToString().Trim();
            reqName.Text = reqDataGridView.Rows[ID].Cells[1].Value.ToString().Trim();
            reqTime.Value = Convert.ToInt16(reqDataGridView.Rows[ID].Cells[2].Value.ToString().Trim());
        }

        private void reqTime_ValueChanged(object sender, EventArgs e)
        {
            saveBtn.Enabled = true;
        }
    }
}
