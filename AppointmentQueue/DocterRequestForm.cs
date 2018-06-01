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

        private void scanId_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = SQL.GetRequests(reqComb.SelectedItem.ToString().Trim());
            dataGridView1.DataSource = dt;
        }

        private void reqComb_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = SQL.GetRequests(reqComb.SelectedItem.ToString().Trim());
            dataGridView1.DataSource = dt;
            reqId.Text = Convert.ToString(reqComb.SelectedIndex + 1);
        }

        private void drDataGridView2_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (!did_lock)
            { 
                did_lock = true;
                int ID = drDataGridView2.CurrentCell.RowIndex;
                drIdTxt.Text = drDataGridView2.Rows[ID].Cells[0].Value.ToString().Trim();
                drNameTxt2.Text = drDataGridView2.Rows[ID].Cells[1].Value.ToString().Trim();
                drLnameTxt2.Text = drDataGridView2.Rows[ID].Cells[2].Value.ToString().Trim();
            }
            did_lock = false;
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (!did_lock)
            {
                did_lock = true;
                int ID = dataGridView1.CurrentCell.RowIndex;
                reqId.Text = dataGridView1.Rows[ID].Cells[0].Value.ToString().Trim();
                reqComb.SelectedIndex = Convert.ToInt16(dataGridView1.Rows[ID].Cells[0].Value.ToString())-1;
            }
            did_lock = false;
        }

        private void drReqGidView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (!did_lock)
            {
                did_lock = true;
                int ID1 = drReqGidView.CurrentCell.RowIndex;
                int ID2 = drDataGridView2.CurrentCell.RowIndex;
                int ID3 = dataGridView1.CurrentCell.RowIndex;
                drIdTxt.Text = drDataGridView2.Rows[ID2].Cells[0].Value.ToString().Trim();
                drNameTxt2.Text = drDataGridView2.Rows[ID2].Cells[1].Value.ToString().Trim();
                drLnameTxt2.Text = drDataGridView2.Rows[ID2].Cells[2].Value.ToString().Trim();

                reqId.Text = dataGridView1.Rows[ID3].Cells[0].Value.ToString().Trim();
                reqComb.SelectedIndex = Convert.ToInt16(dataGridView1.Rows[ID3].Cells[0].Value.ToString().Trim()) - 1;

                drReqId.Text = drDataGridView2.Rows[ID1].Cells[0].Value.ToString().Trim();
                dofComb.SelectedIndex = Convert.ToInt16(SQL.getDof(drDataGridView2.Rows[ID1].Cells[5].Value.ToString().Trim())) - 1;
                pedComb.Text = drDataGridView2.Rows[ID1].Cells[3].Value.ToString().Trim();
            }
            did_lock = false;
        }

        
        private void seachDrReq_Click(object sender, EventArgs e)
        {
            DataTable dt = SQL.GetDoctorRequests(pedComb.SelectedItem.ToString(), "",drNameTxt2.Text);
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
                        "INSERT INTO doctorRequests (drreq_Id,drreq_req,drreq_dr,drreq_period,drreq_time,drreq_dayofweek) " +
                        "VALUE (@drreq_Id,@drreq_req,@drreq_dr,@drreq_period,@drreq_time,@drreq_dayofweek)", cn);

                    command.Parameters.AddWithValue("@drreq_req", Convert.ToString(reqId.Text ));
                    command.Parameters.AddWithValue("@drreq_dr", Convert.ToString(drIdTxt.Text.Trim()));
                    command.Parameters.AddWithValue("@drreq_period", pedComb.SelectedItem.ToString().Trim());
                    command.Parameters.AddWithValue("@drreq_time", 100);
                    command.Parameters.AddWithValue("@drreq_dayofweek", dofComb.SelectedItem.ToString().Trim());
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
