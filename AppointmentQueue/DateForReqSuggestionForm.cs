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
    public partial class DateForReqSuggestionForm : Form
    {
        public int scannerInx;
        public int periodInx;
        public int requestInx;
        public string drInx;
        public int kidInx;
        public string drwInx;
        public DateTime startT;
        public DateTime chosenT;
        public bool exist = false;

        public DateForReqSuggestionForm(int scan, int ped, int req, DateTime sT, int kid)
        {
            InitializeComponent();
            scannerInx = scan;
            periodInx = ped;
            requestInx = req;
            kidInx = kid;
            scan_CoBox = SQL.readScanner(scan_CoBox);
            reqCob = SQL.readRequest(reqCob);
            scan_CoBox.SelectedIndex = scannerInx;
            reqCob.SelectedIndex = requestInx;
            comboBox1.SelectedIndex = periodInx;
            dateTimePicker1.Value = sT;
            selectedDate.Value = sT;
            startT = sT;
            chosenT = sT;
            suggDataGridView.DataSource = getSuggestionDate();
            
        }
        
        public int getDof(string dayName)
        {
            dayName = dayName.Trim();
            if (dayName.Equals("Monday".Trim()))
                return 1;
            else if (dayName.Equals("Tuesday".Trim()))
                return 2;
            else if (dayName.Equals("Wednesay".Trim()))
                return 3;
            else if (dayName.Equals("Thursday".Trim()))
                return 4;
            else if (dayName.Equals("Friday".Trim()))
                return 5;
            else if (dayName.Equals("Saturday".Trim()))
                return 6;
            else
                return 7;
        }

        public DataTable getSuggestionDate()
        {
           //1.Find possible day of week of req in the range time
            DataTable dtPossibleDrReq = SQL.GetDoctorRequests(reqCob.SelectedItem.ToString().Trim(),"");
            req_dataGridView.DataSource = dtPossibleDrReq;
            SQL.ChangeHeaderText(dtPossibleDrReq, req_dataGridView);

            //2.Find Day off of req in the range time
            startT = startT.Date;
            int offSet = Convert.ToInt16(dayNumericUpDown.Value);
            DateTime endT = startT.AddDays(offSet);
            DataTable dtDayOff = SQL.GetDayOffs(startT,endT,"");
            dataGridView1.DataSource = dtDayOff;
            SQL.ChangeHeaderText(dtDayOff, dataGridView1);

            DataTable suggestDate = SQL.GetDoctorCalendars(startT, endT, reqCob.SelectedItem.ToString().Trim(),
                Convert.ToInt16(kidCheckBox.Checked).ToString().Trim(), 
                comboBox1.SelectedItem.ToString().Trim());
            suggDataGridView.DataSource = suggestDate;
            SQL.ChangeHeaderText(suggestDate, suggDataGridView);
            
            return suggestDate;
        }
        
        private void scan_CoBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            scannerInx = scan_CoBox.SelectedIndex;
        }

        private void reqCob_SelectedIndexChanged(object sender, EventArgs e)
        {
            requestInx = reqCob.SelectedIndex;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            periodInx = comboBox1.SelectedIndex;
        }

        private void seachDateForReq_Click(object sender, EventArgs e)
        {
            suggDataGridView.DataSource = getSuggestionDate();
        }

        private void acceptDateForReq_Click(object sender, EventArgs e)
        {
            exist = true;
            Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            startT = dateTimePicker1.Value.Date;
        }

        private void suggDataGridView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int ID = suggDataGridView.CurrentRow.Index;
            scan_CoBox.SelectedIndex = scannerInx;
            reqCob.SelectedIndex = requestInx;
            comboBox1.SelectedIndex = periodInx;
            kidCheckBox.Checked = Convert.ToBoolean(kidInx);
            drInx = suggDataGridView.Rows[ID].Cells[5].Value.ToString().Trim();
            drwInx = suggDataGridView.Rows[ID].Cells[0].Value.ToString().Trim();

            chosenT = Convert.ToDateTime(suggDataGridView.Rows[ID].Cells[1].Value.ToString().Trim());
            selectedDate.Value = chosenT.Date;
            //DataTable dt = SQL.GetAppointment(selectedDate.Value.Date, selectedDate.Value.Date, "", comboBox1.SelectedItem.ToString().Trim(), "");
            //dataGridView3.DataSource = dt;

            //DataTable dt2 = SQL.GetAppointment(selectedDate.Value.Date, selectedDate.Value.Date, "", "", "");
            //dataGridView4.DataSource = dt2;
        }

        private void dayNumericUpDown_ValueChanged_1(object sender, EventArgs e)
        {
            suggDataGridView.DataSource = getSuggestionDate();
        }

        private void kidCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            kidInx = Convert.ToInt16(kidCheckBox.Checked);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
