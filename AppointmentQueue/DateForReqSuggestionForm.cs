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
    public partial class DateForReqSuggestionForm : Form
    {
        public int scannerInx;
        public int periodInx;
        public int requestInx;
        public DateTime startT;
        public DateTime chosenT;
        public bool exist = false;

        public DateForReqSuggestionForm(int scan, int ped, int req, DateTime sT)
        {
            InitializeComponent();
            scannerInx = scan;
            periodInx = ped;
            requestInx = req;
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
        
        public static DataTable GetDistinctRecords(DataTable dt, string[] Columns)
        {
            DataTable dtUniqRecords = new DataTable();
            dtUniqRecords = dt.DefaultView.ToTable(true, Columns);
            return dtUniqRecords;
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
            DataTable dtPossibleDrReq = SQL.GetDoctorRequests(comboBox1.SelectedItem.ToString().Trim(), reqCob.SelectedItem.ToString().Trim(),"");
            dataGridView2.DataSource = dtPossibleDrReq;

            //2.Find Day off of req in the range time
            //df_id ,df_date ,df_dr ,dr_name ,df_period ,df_detail
            startT = startT.Date;
            int offSet = Convert.ToInt16(dayNumericUpDown.Value);
            DateTime endT = startT.AddDays(offSet);
            DataTable dtDayOff = SQL.GetDayOffs(startT,endT,"");
            dataGridView1.DataSource = dtDayOff;

            DataTable suggestDate = new DataTable();
            suggestDate.Columns.Add("Suggest_date", typeof(String));
            suggestDate.Columns.Add("day_of_week", typeof(String));
            suggestDate.Columns.Add("Dr name", typeof(String));
            suggestDate.Columns.Add("Used time", typeof(Int16));
            suggestDate.Columns.Add("Scan name", typeof(String));
            suggestDate.Columns.Add("Period", typeof(String));
            for (int r = 0; r < dtPossibleDrReq.Rows.Count; r++)
            {
                //3.Select req to insert into a suggestion table
                //drreq_Id ,req_bodypart ,dr_name ,drreq_period ,drreq_time ,drreq_dayofweek
                DataRow req = dtPossibleDrReq.Rows[r];
                String strDof = req[5].ToString().Trim();
                int dof = getDof(req[5].ToString());
                DateTime sT = startT.AddDays(7 - getDof(startT.DayOfWeek.ToString()) + dof);
                while (sT <= endT)
                {
                    //4.
                    DataRow[] sTDayOff = dtDayOff.Select("df_date LIKE '%" + sT.Date + 
                        "%' AND dr_name LIKE '%" + req["dr_name"].ToString().Trim() + "%'");
                    
                    //5.Select
                    DataTable dt = SQL.GetAppointment(sT, sT, " ",comboBox1.SelectedItem.ToString().Trim(), "");
                    
                    int usedTime = 0;
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        usedTime += Convert.ToInt16(dt.Rows[i]["req_time"].ToString());
                    }

                    if (sTDayOff.Length==0)
                    {
                        DataRow dr = suggestDate.NewRow();
                        dr[0] = sT;
                        dr[1] = strDof;
                        dr[2] = req["dr_name"].ToString().Trim();
                        dr[3] = usedTime;
                        dr[4] = scan_CoBox.SelectedItem.ToString().Trim();
                        dr[5] = comboBox1.SelectedItem.ToString().Trim();
                        suggestDate.Rows.Add(dr);
                        
                        suggDataGridView.DataSource = suggestDate;
                    }
                    sT = sT.AddDays(7);
                }
            }
            
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
            chosenT = Convert.ToDateTime(suggDataGridView.Rows[ID].Cells[0].Value.ToString().Trim());
            selectedDate.Value = chosenT.Date;
            DataTable dt = SQL.GetAppointment(selectedDate.Value.Date, selectedDate.Value.Date, "", comboBox1.SelectedItem.ToString().Trim(), "");
            dataGridView3.DataSource = dt;
            DataTable dt2 = SQL.GetAppointment(selectedDate.Value.Date, selectedDate.Value.Date, "", "", "");
            dataGridView4.DataSource = dt2;
        }

        private void dayNumericUpDown_ValueChanged_1(object sender, EventArgs e)
        {
            suggDataGridView.DataSource = getSuggestionDate();
        }
        
        private void DateForReqSuggestionForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Scanners' table. You can move, or remove it, as needed.
            this.scannersTableAdapter.Fill(this.database1DataSet.Scanners);

        }
    }
}
