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
    public partial class DayOffForm : Form
    {
        int pkDr;
        public DayOffForm()
        {
            InitializeComponent();
        }

        private void addDayOffBtn_Click(object sender, EventArgs e)
        {
            try{
                if (MessageBox.Show("Do you want to insert a new day off?", "Insert new day off", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SqlConnection cn = new SqlConnection(global::AppointmentQueue.Properties.Settings.Default.Database1ConnectionString);
                    SqlCommand command = new SqlCommand(
                        "INSERT INTO DayOffs (df_date,df_dr,df_period,df_detail) " +
                        "VALUES (@df_date,@df_dr,@df_period,@df_detail)", cn);

                    command.Parameters.AddWithValue("@df_date", dayOffDate.Value.Date);
                    command.Parameters.AddWithValue("@df_dr", pkDr);
                    command.Parameters.AddWithValue("@df_period", pedCob.SelectedItem.ToString().Trim());
                    command.Parameters.AddWithValue("@df_detail", detailTxt.Text);
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

        private void seachDrReq_Click(object sender, EventArgs e)
        {
            DataTable dt = SQL.GetDayOffs(dayOffDate.Value, dayOffDate.Value.Date.AddMonths(1), drNameTxt2.Text);
            dayOffGridView.DataSource = dt;
        }
    }
}
