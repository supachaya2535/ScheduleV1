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
    public partial class DocterRequestForm : Form
    {
        bool did_lock = false;
        int pkDr;
        int pkReq;
        public DocterRequestForm()
        {
            InitializeComponent();
            reqComb = SQL.readRequest(reqComb);
        }

        private void drIdTxt_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = SQL.GetDoctors(drNameTxt2.Text, drLnameTxt2.Text);
            drDataGridView2.DataSource = dt;
        }

        private void drNameTxt2_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = SQL.GetDoctors(drNameTxt2.Text, drLnameTxt2.Text);
            drDataGridView2.DataSource = dt;
        }

        private void drLnameTxt2_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = SQL.GetDoctors(drNameTxt2.Text, drLnameTxt2.Text);
            drDataGridView2.DataSource = dt;
        }

        private void reqComb_SelectedIndexChanged(object sender, EventArgs e)
        {
            pkReq = Convert.ToInt16(reqComb.SelectedIndex + 1);
        }

        private void drDataGridView2_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int ID = drDataGridView2.CurrentCell.RowIndex;

            String tempdrIdTxt = drDataGridView2.Rows[ID].Cells[0].Value.ToString().Trim();
            String tempdrNameTxt = drDataGridView2.Rows[ID].Cells[1].Value.ToString().Trim();
            String tempdrLnameTxt = drDataGridView2.Rows[ID].Cells[2].Value.ToString().Trim();

            pkDr = Convert.ToInt16(drDataGridView2.Rows[ID].Cells[0].Value.ToString());
            drName2.Text = tempdrNameTxt;

            drIdTxt.Text = tempdrIdTxt;
            drNameTxt2.Text = tempdrNameTxt;
            drLnameTxt2.Text = tempdrLnameTxt;
        }

        private void drReqGidView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {//drreq_Id,req_bodypart,dr_name,drreq_period,drreq_time,drreq_dayofweek,
            int ID = drReqGidView.CurrentCell.RowIndex;
            pkReq = Convert.ToInt16(SQL.getDof(drReqGidView.Rows[ID].Cells[5].Value.ToString().Trim()));
            pkDr = Convert.ToInt16(drReqGidView.Rows[ID].Cells[6].Value.ToString().Trim());

            drReqId.Text = drReqGidView.Rows[ID].Cells[0].Value.ToString().Trim();
            drName2.Text = drReqGidView.Rows[ID].Cells[2].Value.ToString().Trim();
            reqComb.Text = drReqGidView.Rows[ID].Cells[1].Value.ToString().Trim();
            dofComb.SelectedIndex = Convert.ToInt16(SQL.getDof(drReqGidView.Rows[ID].Cells[5].Value.ToString().Trim())) - 1;
            pedComb.Text = drReqGidView.Rows[ID].Cells[3].Value.ToString().Trim();

        }


        private void seachDrReq_Click(object sender, EventArgs e)
        {
            DataTable dt = SQL.GetDoctorRequests("", "", drNameTxt2.Text);
            drReqGidView.DataSource = dt;
        }

        private void drReqAddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to insert a new appointment?", "Insert new appointment", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SqlConnection cn = new SqlConnection(global::AppointmentQueue.Properties.Settings.Default.Database1ConnectionString);
                    SqlCommand command = new SqlCommand(
                        "INSERT INTO DoctorRequests (drreq_req,drreq_dr,drreq_period,drreq_time,drreq_dayofweek) " +
                        "VALUES (@drreq_req,@drreq_dr,@drreq_period,@drreq_time,@drreq_dayofweek)", cn);

                    command.Parameters.AddWithValue("@drreq_req", Convert.ToString(pkReq));
                    command.Parameters.AddWithValue("@drreq_dr", Convert.ToString(drIdTxt.Text.Trim()));
                    command.Parameters.AddWithValue("@drreq_period", pedComb.SelectedItem.ToString().Trim());
                    command.Parameters.AddWithValue("@drreq_time", 100);
                    command.Parameters.AddWithValue("@drreq_dayofweek", dofComb.SelectedItem.ToString().Trim());
                    command.Connection = cn;

                    cn.Open();
                    command.ExecuteNonQuery();
                    cn.Close();
                    seachDrReq_Click(sender, e);
                }

            }
            catch (SystemException ex)
            {
                MessageBox.Show(string.Format("Couldn't insert a new record : An error occurred: {0}", ex.Message));
            }

        }

        private void drDataGridView2_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int ID = drDataGridView2.CurrentCell.RowIndex;


        }

        private void drReqDelBtn_Click(object sender, EventArgs e)
        {
            if (drReqId.Text != "")
            {
                if (MessageBox.Show("Do you want to delete doctor request?", "Delete doctor request", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int id_del = Convert.ToInt32(drReqId.Text);
                    SqlConnection cn = new SqlConnection(global::AppointmentQueue.Properties.Settings.Default.Database1ConnectionString);
                    SqlCommand command = new SqlCommand("DELETE FROM DoctorRequests WHERE drreq_Id = '" + id_del + "'", cn);

                    cn.Open();
                    command.ExecuteNonQuery();
                    cn.Close();
                    seachDrReq_Click(sender, e);
                    drReqId.Text = "";
                    MessageBox.Show("Delete Requests Success");
                }
            }
            else
            {
                MessageBox.Show("Please Choose Your Requests that want to delete");
            }
        }
    }
}
