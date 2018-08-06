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
        private void seachDrWork_Click(object sender, EventArgs e)
        {
            DataTable dt = SQL.GetDoctorWorks("", drNameTxt2.Text, Convert.ToInt16(kidCheckBox.Checked).ToString().Trim());
            drWorkGidView.DataSource = dt;
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
                        "INSERT INTO DoctorWorks (drw_dr,drw_sdate,drw_edate,drw_dow,drw_period,"+
                        "drw_kid,drw_w1,drw_w2,drw_w3,drw_w4,drw_status) " +
                        "VALUES (@drw_dr,@drw_sdate,@drw_edate,@drw_dow,@drw_period," +
                        "@drw_kid,@drw_w1,@drw_w2,@drw_w3,@drw_w4,@drw_status)", cn);

                    command.Parameters.AddWithValue("@drw_dr", drIdTxt.Text.Trim());
                    command.Parameters.AddWithValue("@drw_sdate", startDate.Value.Date);
                    command.Parameters.AddWithValue("@drw_edate", startDate.Value.Date);
                    command.Parameters.AddWithValue("@drw_dow", dofComb.SelectedItem.ToString().Trim());
                    command.Parameters.AddWithValue("@drw_period", pedComb.SelectedItem.ToString().Trim());
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

                    seachDrWork_Click(sender, e);
                }

            }
            catch (SystemException ex)
            {
                MessageBox.Show(string.Format("Couldn't insert a new record : An error occurred: {0}", ex.Message));
            }
        }
    
        private void drDataGridView2_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int ID = drDataGridView2.CurrentCell.RowIndex;

            String tempdrIdTxt = drDataGridView2.Rows[ID].Cells[0].Value.ToString().Trim();
            String tempdrNameTxt = drDataGridView2.Rows[ID].Cells[1].Value.ToString().Trim();
            String tempdrLnameTxt = drDataGridView2.Rows[ID].Cells[2].Value.ToString().Trim();

            drName2.Text = tempdrNameTxt;
            drIdTxt.Text = tempdrIdTxt;
            drNameTxt2.Text = tempdrNameTxt;
            drLnameTxt2.Text = tempdrLnameTxt;
        }

        private void seachDrWork_Click_1(object sender, EventArgs e)
        {
            seachDrWork_Click(sender, e);
        }
    }
}
