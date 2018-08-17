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
        int ap_Id;
        int drc_id;
        public AppointmentForm(DataGridViewRow App)
        {
            InitializeComponent();

            reqCob = SQL.readRequest(reqCob);

            ap_Id = Convert.ToInt16(App.Cells["ap_Id"].Value.ToString().Trim());
            drc_id = Convert.ToInt16(App.Cells["ap_drc"].Value.ToString().Trim());
            todayDatePicker.Value = Convert.ToDateTime(App.Cells["drc_date"].Value.ToString());
            HNtxt.Text = App.Cells["ap_patient"].Value.ToString().Trim();
            drTxt.Text = App.Cells["drw_dr"].Value.ToString().Trim();
            reqCob.SelectedIndex = Convert.ToInt16(App.Cells["ap_request"].Value.ToString().Trim());
            paidCob.SelectedIndex = SQL.getPeriod(App.Cells["drw_period"].Value.ToString().Trim());
            detail_text.Text = App.Cells["ap_detail"].Value.ToString().Trim();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(global::AppointmentQueue.Properties.Settings.Default.Database1ConnectionString);
            SqlCommand command = cn.CreateCommand();
            command.CommandText = "UPDATE Appointments SET ap_appstatus = @stat,ap_drc = @ap_drc WHERE ap_Id = @id";
            command.Parameters.AddWithValue("@stat", "InQeue");
            command.Parameters.AddWithValue("@id", ap_Id.ToString().Trim());
            command.Parameters.AddWithValue("@ap_drc", drc_id.ToString().Trim());

            cn.Open();
            command.ExecuteNonQuery();
            cn.Close();
           
            this.Close();
        }

        private void calendarBtn_Click(object sender, EventArgs e)
        {
            CalendarForm clf_form = new CalendarForm(paidCob.SelectedIndex, reqCob.SelectedIndex,
                todayDatePicker.Value.Date, Convert.ToInt16(kidCheckBox.Checked));

            clf_form.exist = false;
            clf_form.ShowDialog();
            if ((clf_form.exist == true))
            {
                drc_id = Convert.ToInt16(clf_form.drcInx);
                todayDatePicker.Value = clf_form.chosenT;
                reqCob.SelectedIndex = clf_form.requestInx;
                paidCob.SelectedIndex = clf_form.periodInx;
                drTxt.Text = clf_form.drInx;
                kidCheckBox.Checked = Convert.ToBoolean(clf_form.kidInx);
                saveBtn.Enabled = true;
            }
        }
    }
}
