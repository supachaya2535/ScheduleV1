using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppointmentQueue
{
    public partial class AppointmentForm : Form
    {
       
        public AppointmentForm(DataGridViewRow App)
        {//ap_id,ap_startT,ap_patient,ap_period,ap_request,req_bodypart,ap_appstatus,ap_scan,scan_name,req_time 
            InitializeComponent();
            appId.Text = App.Cells[0].ToString().Trim();
            HNtxt.Text = App.Cells[2].ToString().Trim();
            dateSelected.Value = Convert.ToDateTime(App.Cells[1].Value);
            scanTxt.Text = App.Cells[8].ToString().Trim();
            reqTxt.Text = App.Cells[5].ToString().Trim();
            pedTxt.Text = App.Cells[3].ToString().Trim(); 
            statusComb.Text =  App.Cells[6].ToString().Trim(); 
              

            //todayDay.Value = Convert.ToDateTime(appDataGridView.Rows[ID].Cells[2].ToString().Trim());
            //scan_CoBox.SelectedIndex = Convert.ToInt16(appDataGridView.Rows[ID].Cells[7].ToString().Trim()) - 1;
            
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
