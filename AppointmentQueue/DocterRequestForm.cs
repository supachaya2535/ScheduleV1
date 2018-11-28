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
        public static String ConnectionStr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + Environment.CurrentDirectory.Split(new string[] { "bin" }, StringSplitOptions.None)[0] + "Database1.mdf;Integrated Security=True";
        int pkDr;
        int pkReq;
        public DocterRequestForm()
        {
            InitializeComponent();
            reqComb = SQL.readRequest(reqComb);
            reqComb.SelectedIndex = 0;
        }
        
        private void reqComb_SelectedIndexChanged(object sender, EventArgs e)
        {
            pkReq = Convert.ToInt16(reqComb.SelectedIndex + 1);
        }

        private void drReqGidView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {//drreq_Id,req_bodypart,dr_name,drreq_period,drreq_time,drreq_dayofweek,
            int ID = drReqGidView.CurrentCell.RowIndex;
            pkReq = Convert.ToInt16(SQL.getDof(drReqGidView.Rows[ID].Cells[5].Value.ToString().Trim()));
            pkDr = Convert.ToInt16(drReqGidView.Rows[ID].Cells[6].Value.ToString().Trim());

            drReqId.Text = drReqGidView.Rows[ID].Cells[0].Value.ToString().Trim();
            reqComb.Text = drReqGidView.Rows[ID].Cells[1].Value.ToString().Trim();
            
        }
        
        private void seachDrReq_Click(object sender, EventArgs e)
        {
            DataTable dt = SQL.GetDoctorRequests( "", drNameTxt2.Text);
            drReqGidView.DataSource = dt;
            SQL.ChangeHeaderText(dt, drReqGidView);
        }

        private void drReqAddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to insert a new doctor request?", "Insert new appointment", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SqlConnection cn = new SqlConnection(ConnectionStr);
                    SqlCommand command = new SqlCommand(
                        "INSERT INTO DoctorRequests (drreq_Id,drreq_req,drreq_dr) " +
                        "VALUES (@drreq_Id,@drreq_req,@drreq_dr)", cn);
                    
                    command.Parameters.AddWithValue("@drreq_Id", Convert.ToString(SQL.getIdReq(pkDr)+SQL.getIdReq(pkReq)));
                    command.Parameters.AddWithValue("@drreq_req", Convert.ToString(pkReq).Trim());
                    command.Parameters.AddWithValue("@drreq_dr", Convert.ToString(pkDr));
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
        
        private void drReqDelBtn_Click(object sender, EventArgs e)
        {
            if (drReqId.Text != "")
            {
                if (MessageBox.Show("Do you want to delete doctor request?", "Delete doctor request", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int id_del = Convert.ToInt32(drReqId.Text);
                    SqlConnection cn = new SqlConnection(ConnectionStr);
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

        private void button2_Click(object sender, EventArgs e)
        {
            DoctorForm sForm = new DoctorForm(false, false);
            sForm.exist = false;
            sForm.ShowDialog();
            if ((sForm.exist == true))
            {
                this.drIdTxt.Text = Convert.ToString(sForm.drId).Trim();
                this.drNameTxt2.Text = sForm.drName.ToString().Trim();
                this.drLnameTxt2.Text = sForm.drLname.ToString().Trim();
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = SQL.GetDoctorRequests(reqComb.SelectedItem.ToString().Trim(), "");
            drReqGidView.DataSource = dt;
            SQL.ChangeHeaderText(dt, drReqGidView);
        }
    }
}
