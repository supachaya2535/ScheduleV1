using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
 
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AppointmentQueue
{
    public partial class DayOffForm : Form
    {
        String pkDr;
        public DayOffForm()
        {
            InitializeComponent();
            dayOffDate.Value = DateTime.Today;
            pedCob.SelectedIndex = 0;

        }

        private void addDayOffBtn_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Do you want to insert a new day off?", "Insert new day off", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                pkDr = drIdTxt.Text;
                if (pkDr == "" || dayOffDate.Value == null || pedCob.SelectedItem.ToString() == "")
                {
                    MessageBox.Show("Please fill your information");
                }
                else
                {
                    SQL.InsertDayOffs(dayOffDate.Value, pkDr, pedCob.SelectedItem.ToString(), detailTxt.Text);
                    seachDrReq_Click(sender, e);
                    detailTxt.Text = "";
                    DataTable dt = SQL.GetDoctorCalendars(pkDr, dayOffDate.Value);
                    int numrow = Convert.ToInt16(dt.Rows.Count);
                    if (numrow > 0)
                    {
                        SQL.UpDateDoctorCalendars(dt.Rows[0]["drc_id"].ToString().Trim(), "Canceled");
                        SQL.UpDateAppointmentsWhenCalendarListWereCanceled("Canceled", "Waiting");
                    }
                }
            }
            
        }

        
        private void seachDrReq_Click(object sender, EventArgs e)
        {
            DataTable dt = SQL.GetDayOffs(drNameTxt2.Text);
            dayOffGridView.DataSource = dt;
            SQL.ChangeHeaderText(dt, dayOffGridView);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (id_df != -1)
            {
                if (MessageBox.Show("Do you want to delete a Day off record?", "Delete Day-off", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SqlConnection cn = new SqlConnection(SQL.ConnectionStr);
                    SqlCommand command = new SqlCommand("DELETE FROM DayOffs WHERE df_id = " + Convert.ToInt32(id_df), cn);

                    cn.Open();
                    command.ExecuteNonQuery();
                    cn.Close();
                    seachDrReq_Click(sender, e);
                    id_df = -1;
                    MessageBox.Show("Delete Day-off Successful");
                }
            }
            else
            {
                MessageBox.Show("Please Choose a Day-off record to delete");
            }
        }

        int id_df = -1;

        private void dayOffGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int ID = dayOffGridView.CurrentCell.RowIndex;
            id_df = Convert.ToInt32(dayOffGridView.Rows[ID].Cells[0].Value.ToString().Trim());
        }

        private void button1_Click(object sender, EventArgs e)
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
    }
}
