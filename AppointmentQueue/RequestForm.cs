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
        public RequestForm()
        {
            InitializeComponent();
            DataTable dt = SQL.GetRequests(reqName.Text.Trim());
            reqDataGridView.DataSource = dt;
        }

        private void reqEditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to insert a new request?", "Insert new request", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SqlConnection cn = new SqlConnection(global::AppointmentQueue.Properties.Settings.Default.Database1ConnectionString);
                    SqlCommand command = new SqlCommand(
                        "INSERT INTO Requests (req_Id,req_bodypart,req_time) " +
                        "VALUE (@req_Id,@req_bodypart,@req_time)", cn);

                    command.Parameters.AddWithValue("@req_bodypart", reqName.Text.Trim());
                    command.Parameters.AddWithValue("@req_time", reqTime.Value);
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

    }
}
