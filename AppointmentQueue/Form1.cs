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
    public partial class Form1 : Form
    {
        public static String ConnectionStr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + Environment.CurrentDirectory.Split(new string[] { "bin" }, StringSplitOptions.None)[0] + "Database1.mdf;Integrated Security=True";
        public string drc_id;

        public Form1()
        {
            InitializeComponent();
            //scan_CoBox = SQL.readScanner(scan_CoBox);
            reqCob = SQL.readRequest(reqCob);
            paidCob.SelectedIndex = 0;
            reqCob.SelectedIndex = 31;

            
            startDate.Value = DateTime.Today;
            endDate.Value = DateTime.Today.AddDays(7);


        }
        private void update_datagridview()
        {
            DataTable dt;
            string available = "";
            string req_chk = "";
            string ped_chk = "";

            if (waitCheckBox.Checked == false) available = ""; else available = "Available";
            if (req_checkBox.Checked == false) req_chk = ""; else req_chk = reqCob.SelectedItem.ToString().Trim();
            if (ped_checkBox.Checked == false) ped_chk = ""; else ped_chk = paidCob.SelectedItem.ToString().Trim();

            if(betweenCheckBox.Checked == false)
            {
                dt = SQL.GetDoctorCalendars( available,
                                req_chk,
                                Convert.ToInt16(kidCheckBox.Checked).ToString().Trim(),
                                ped_chk);
            }
            else
            {
                dt = SQL.GetDoctorCalendars(startDate.Value, endDate.Value, available,
                                req_chk,
                                Convert.ToInt16(kidCheckBox.Checked).ToString().Trim(), 
                                ped_chk);

            }
            
            appDataGridView.DataSource = dt;
            SQL.ChangeHeaderText(dt, appDataGridView);

        }
        private void betweenCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            update_datagridview();
        }
        
        private void startDate_ValueChanged(object sender, EventArgs e)
        {
            if (startDate.Value.Date> endDate.Value.Date)
                endDate.Value = startDate.Value.Date.AddDays(1);
            betweenCheckBox_CheckedChanged(sender, e);
        }

        private void endDate_ValueChanged(object sender, EventArgs e)
        {
            if (startDate.Value.Date > endDate.Value.Date)
                endDate.Value = startDate.Value.Date.AddDays(1);
            betweenCheckBox_CheckedChanged(sender, e);
        }
      
        private void manReq_Click(object sender, EventArgs e)
        {
            DocterRequestForm sForm = new DocterRequestForm();
            sForm.ShowDialog();
        }

        private void manDayOff_Click(object sender, EventArgs e)
        {
            DayOffForm sForm = new DayOffForm();
            sForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RequestForm sForm = new RequestForm();
            sForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ScannerForm sForm = new ScannerForm();
            sForm.ShowDialog();
        }

        private void appDataGridView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
             //ap_id,ap_startT,ap_patient,ap_period,ap_request,req_bodypart,ap_appstatus,ap_scan,scan_name,req_time
            int ID = appDataGridView.CurrentCell.RowIndex;
            
            string dr_name = appDataGridView.Rows[ID].Cells["dr_name"].Value.ToString().Trim();
            DataTable dt = SQL.GetDoctorRequests("", dr_name.Trim());
            reqDataGridView.DataSource = dt;
            SQL.ChangeHeaderText(dt, reqDataGridView);

        }
        

        private void manDrBtn_Click(object sender, EventArgs e)
        {
            DoctorForm sForm = new DoctorForm();
            sForm.ShowDialog();
        }

        private void manDrWorkBtn_Click(object sender, EventArgs e)
        {
            DoctorWorkForm sForm = new DoctorWorkForm();
            sForm.ShowDialog();
        }

        private void show_calendar_btn_Click(object sender, EventArgs e)
        {
            CalendarForm clf_form = new CalendarForm(paidCob.SelectedIndex, reqCob.SelectedIndex,
                startDate.Value.Date, Convert.ToInt16(kidCheckBox.Checked));
           
            clf_form.exist = false;
            clf_form.ShowDialog();
            if ((clf_form.exist == true))
            {
               
                reqCob.SelectedIndex = clf_form.requestInx;
                paidCob.SelectedIndex = clf_form.periodInx;
                kidCheckBox.Checked = Convert.ToBoolean(clf_form.kidInx);
                drc_id = clf_form.drcInx;
                
            }
        }

        private void waitCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            update_datagridview();
        }

        private void appDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void kidCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            update_datagridview();
        }

        private void req_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            update_datagridview();
        }

        private void reqCob_SelectedIndexChanged(object sender, EventArgs e)
        {
            update_datagridview();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
