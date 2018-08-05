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
        public Form1()
        {
            InitializeComponent();
            scan_CoBox = SQL.readScanner(scan_CoBox);
            reqCob = SQL.readRequest(reqCob);
            scan_CoBox.SelectedIndex = 0;
            paidCob.SelectedIndex = 0;
            reqCob.SelectedIndex = 31;

            todayDatePicker.Value = DateTime.Today;
            todayDay.Value = DateTime.Today;
            startDate.Value = DateTime.Today;
            endDate.Value = DateTime.Today.AddDays(7);
            
            DataTable dt = SQL.GetAppointment(todayDay.Value, todayDay.Value, " ", " ", " ");
            appDataGridView.DataSource = dt;

            detail_text.Enabled = false;
            HNtxt.Enabled = false;
        }
        
        private int getAge(DateTime birthDate)
        {
            DateTime n = DateTime.Now; // To avoid a race condition around midnight
            int age = n.Year - birthDate.Year;

            if (n.Month < birthDate.Month || (n.Month == birthDate.Month && n.Day < birthDate.Day))
                age--;

            return age;
        }
        
        //start over again
        private void seachPaBtn_Click_1(object sender, EventArgs e)
        {
            SeachPaForm sForm = new SeachPaForm();
            sForm.exist = false;
            sForm.ShowDialog();
            if ((sForm.exist==true))
            {
                this.HNtxt.Text = sForm.HNpatient;
                this.nameTxt.Text = sForm.PatName;
                this.lnameTxt.Text = sForm.PatLName;
                this.birthDatePicker.Value = Convert.ToDateTime(sForm.PatBD);
                this.ageTxt.Text = Convert.ToString(getAge(this.birthDatePicker.Value.Date));
                addBtn.Enabled = true;
            }
            
        }

        private void seachDateForReq_Click(object sender, EventArgs e)
        {
            DateForReqSuggestionForm sForm = new DateForReqSuggestionForm(scan_CoBox.SelectedIndex,paidCob.SelectedIndex, reqCob.SelectedIndex, todayDatePicker.Value.Date);
            sForm.exist = false;
            sForm.ShowDialog();
            if ((sForm.exist == true))
            {
                todayDatePicker.Value = sForm.chosenT;
                scan_CoBox.SelectedIndex = sForm.scannerInx;
                reqCob.SelectedIndex = sForm.requestInx;
                paidCob.SelectedIndex = sForm.periodInx;
            }
            
        }

        private void betweenCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (betweenCheckBox.Checked == true)
            {
                todayCheckBox.Checked = false;
                DataTable dt = SQL.GetAppointment(startDate.Value, endDate.Value, "", "", "");
                appDataGridView.DataSource = dt;
            }
        }

        private void todayCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(todayCheckBox.Checked == true)
            {
                betweenCheckBox.Checked = false;
                DataTable dt = SQL.GetAppointment(todayDay.Value, todayDay.Value, "", "", "");
                appDataGridView.DataSource = dt;
            }
        }

        private void todayDay_ValueChanged(object sender, EventArgs e)
        {
            todayCheckBox_CheckedChanged(sender, e);
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

        private void HNtxt_TextChanged(object sender, EventArgs e)
        {
            if(HNtxt.Text == null)
                seachDateForReq.Enabled = false;
            else
                seachDateForReq.Enabled = true;
        }

        private void todayDatePicker_ValueChanged(object sender, EventArgs e)
        {
            //DataTable dt = SQL.GetAppointment(todayDay.Value.Date, todayDay.Value.Date, " ", " ", " ");
            //appDataGridView.DataSource = dt;
            
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try {
                if (MessageBox.Show("Do you want to insert a new appointment?", "Insert new appointment", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SqlConnection cn = new SqlConnection(global::AppointmentQueue.Properties.Settings.Default.Database1ConnectionString);
                    SqlCommand command = new SqlCommand(
                        "INSERT INTO Appointments (ap_startT,ap_patient,ap_request,ap_detail,ap_period,ap_appstatus,ap_scan) " +
                        "VALUES (@ap_startT,@ap_patient,@ap_request,@ap_detail,@ap_period,@ap_appstatus,@ap_scan)", cn);

                    command.Parameters.AddWithValue("@ap_startT", todayDatePicker.Value.Date.ToString().Trim());
                    command.Parameters.AddWithValue("@ap_patient", HNtxt.Text.Trim());
                    command.Parameters.AddWithValue("@ap_request", reqCob.SelectedIndex + 1);
                    command.Parameters.AddWithValue("@ap_detail", detail_text.Text.Trim());
                    command.Parameters.AddWithValue("@ap_period", paidCob.SelectedItem.ToString().Trim());
                    command.Parameters.AddWithValue("@ap_appstatus", "Waiting");
                    command.Parameters.AddWithValue("@ap_scan", scan_CoBox.SelectedIndex + 1);
                    command.Connection = cn;

                    cn.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Row inserted !! ");
                    cn.Close();

                }
                
            }
            catch (SystemException ex)
            {
                MessageBox.Show(string.Format("Couldn't insert a new record : An error occurred: {0}", ex.Message));
            }
            todayCheckBox_CheckedChanged(sender, e);
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
            AppointmentForm sForm = new AppointmentForm(appDataGridView.Rows[ID]);
            sForm.ShowDialog();
            //string date_str = appDataGridView.Rows[ID].Cells[1].Value.ToString();
            //DateTime tmpDate = Convert.ToDateTime(date_str);
            todayCheckBox_CheckedChanged(sender, e);
            betweenCheckBox_CheckedChanged(sender, e);
        }

        private void reqCob_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(reqCob.SelectedIndex >= 39 && reqCob.SelectedIndex <= 49)
            {
                detail_text.Enabled = true;
                detail_text.Text = "";
            }
            else
            {
                detail_text.Enabled = false;
                detail_text.Text = "";
            }
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
            CalendarForm clf_form = new CalendarForm();
            clf_form.ShowDialog();
        }
    }
}
