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
    public partial class AppointmentForm : Form
    {

        public AppointmentForm(DataGridViewRow App)
        {//ap_id,ap_startT,ap_patient,ap_period,ap_request,req_bodypart,ap_appstatus,ap_scan,scan_name,req_time 
            InitializeComponent();
            appId.Text = App.Cells[0].Value.ToString().Trim();
            dateSelected.Value = Convert.ToDateTime(App.Cells[1].Value.ToString());
            HNtxt.Text = App.Cells[2].Value.ToString().Trim();
            dateSelected.Value = Convert.ToDateTime(App.Cells[1].Value);
            scanTxt.Text = App.Cells[8].Value.ToString().Trim();
            reqTxt.Text = App.Cells[5].Value.ToString().Trim();
            pedTxt.Text = App.Cells[3].Value.ToString().Trim();
            statusComb.Text = App.Cells[6].Value.ToString().Trim();


            //todayDay.Value = Convert.ToDateTime(appDataGridView.Rows[ID].Cells[2].ToString().Trim());
            //scan_CoBox.SelectedIndex = Convert.ToInt16(appDataGridView.Rows[ID].Cells[7].ToString().Trim()) - 1;

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(global::AppointmentQueue.Properties.Settings.Default.Database1ConnectionString);
            SqlCommand command = cn.CreateCommand();
            command.CommandText = "UPDATE Appointments SET ap_appstatus = @stat Where ap_Id = @id";
            command.Parameters.AddWithValue("@stat", statusComb.Text);
            command.Parameters.AddWithValue("@id", appId.Text.Trim());

            cn.Open();
            command.ExecuteNonQuery();
            cn.Close();



            this.Close();
        }
    }
}
