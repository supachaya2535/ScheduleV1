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
    public partial class DoctorWorkForm : Form
    {
        public DoctorWorkForm()
        {
            InitializeComponent();
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

        private void drWorkAddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to insert a new doctor work?", "Insert a new doctor work", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SqlConnection cn = new SqlConnection(global::AppointmentQueue.Properties.Settings.Default.Database1ConnectionString);
                    SqlCommand command = new SqlCommand(
                        "INSERT INTO DoctorWorks (drw_id,drw_dr,drw_sdate,drw_edate,drw_dow,drw_period,"+
                        "drw_kid,drw_w1,drw_w2,drw_w3,drw_w4,drw_status) " +
                        "VALUES (@drw_id,@drw_dr,@drw_sdate,@drw_edate,@drw_dow,@drw_period," +
                        "@drw_kid,@drw_w1,@drw_w2,@drw_w3,@drw_w4,@drw_status", cn);

                    command.Parameters.AddWithValue("@drw_id", drIdTxt.Text.Trim());
                    command.Parameters.AddWithValue("@drw_dr", drIdTxt.Text.Trim());
                    command.Parameters.AddWithValue("@drw_sdate", startDate.Value.Date);
                    command.Parameters.AddWithValue("@drw_edate", startDate.Value.Date);
                    command.Parameters.AddWithValue("@drw_dow", dofComb.SelectedItem.ToString().Trim());
                    command.Parameters.AddWithValue("@drw_peroid", pedComb.SelectedItem.ToString().Trim());
                    command.Parameters.AddWithValue("@drw_kid", Convert.ToInt16(kidCheckBox.Checked).ToString().Trim());
                    command.Parameters.AddWithValue("@drw_w1", Convert.ToInt16(week1CheckBox.Checked).ToString().Trim());
                    command.Parameters.AddWithValue("@drw_w2", Convert.ToInt16(week2CheckBox.Checked).ToString().Trim());
                    command.Parameters.AddWithValue("@drw_w3", Convert.ToInt16(week3CheckBox.Checked).ToString().Trim());
                    command.Parameters.AddWithValue("@drw_w4", Convert.ToInt16(week4CheckBox.Checked).ToString().Trim());
                    command.Parameters.AddWithValue("@drw_status", detailTxt.Text);


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
