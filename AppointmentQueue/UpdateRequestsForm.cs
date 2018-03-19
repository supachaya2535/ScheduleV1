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
using System.Data.SqlLocalDb;

namespace AppointmentQueue
{
    public partial class UpdateRequestsForm : Form
    {
        SqlConnection con = new SqlConnection(global::AppointmentQueue.Properties.Settings.Default.Database1ConnectionString);
        SqlCommand cmd;
        SqlDataAdapter adapt_dat;

        // id for update and delete record
        int id_record = -1;

        public UpdateRequestsForm()
        {
            InitializeComponent();
            DisplayData();
        }

        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt_dat = new SqlDataAdapter("select * from Requests", con);
            adapt_dat.Fill(dt);
            datagridview_req.DataSource = dt;
            con.Close();
        }

        private void ClearData()
        {
            txt_req_bodypart.Text = "";
            txt_req_id.Text = "";
            txt_req_scan.Text = "";
            txt_req_time.Text = "";
            id_record = -1;
        }

        private void UpdateRequestsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet13032561.Requests' table. You can move, or remove it, as needed.
            //this.requestsTableAdapter.Fill(this.database1DataSet13032561.Requests);
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            if (txt_req_bodypart.Text != "" &&
                txt_req_scan.Text != "" &&
                txt_req_time.Text != "")
            {
                cmd = new SqlCommand("insert into Requests(req_scan, req_bodypart, req_time)" +
                    "values(@req_scan, @req_bodypart, @req_time)", con);
                try
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@req_scan", Convert.ToInt16(txt_req_scan.Text));
                    cmd.Parameters.AddWithValue("@req_bodypart", txt_req_bodypart.Text);
                    cmd.Parameters.AddWithValue("@req_time", txt_req_time.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Inserted Successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Fill Detail");
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (id_record != -1)
            {
                if (txt_req_bodypart.Text != "" &&
                    txt_req_scan.Text != "" &&
                    txt_req_time.Text != "")
                {
                    cmd = new SqlCommand("update Requests set req_scan=@scan," +
                        "req_bodypart=@bdpart,req_time=@time where req_Id=@id", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txt_req_id.Text));
                    cmd.Parameters.AddWithValue("@scan", Convert.ToInt32(txt_req_scan.Text));
                    cmd.Parameters.AddWithValue("@bdpart", txt_req_bodypart.Text);
                    cmd.Parameters.AddWithValue("@time", Convert.ToInt32(txt_req_time.Text));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Update Successfully !!");
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Fail to Update : Some Detail Doesn't Exist");
                }

                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Update");
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (id_record != -1)
            {
                cmd = new SqlCommand("delete Requests where req_Id=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", id_record);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Delete Successfully !!");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }
        }

        private void datagridview_req_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id_record = Convert.ToInt32(datagridview_req.Rows[e.RowIndex].Cells[0].Value.ToString());
            txt_req_id.Text = datagridview_req.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
            txt_req_scan.Text = datagridview_req.Rows[e.RowIndex].Cells[1].Value.ToString().Trim();
            txt_req_bodypart.Text = datagridview_req.Rows[e.RowIndex].Cells[2].Value.ToString().Trim();
            txt_req_time.Text = datagridview_req.Rows[e.RowIndex].Cells[3].Value.ToString().Trim();
        }
    }
}
