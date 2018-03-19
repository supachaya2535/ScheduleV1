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
    public partial class Search_Request_Information_From : Form
    {
        public static DateTimePicker picker_date_time;
        public static DateTime startT_needed;
        public static int req_needed;
        public static int scanner_needed;

        public void SetPickerDatetime(DateTimePicker dtpk) { picker_date_time = dtpk; }
        public void SetRequest(int request) { req_needed = request; }
        public void SetScanner(int scan) { scanner_needed = scan; }
        public void SetStartTime(DateTime t) { startT_needed = t; }

        public Search_Request_Information_From()
        {
            InitializeComponent();

        }

        private void Search_Request_Information_From_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet1.ConditionRequest' table. You can move, or remove it, as needed.
            // this.conditionRequestTableAdapter.Fill(this.database1DataSet1.ConditionRequest);
            //this.appointmentsTableAdapter1.Fill(this.database1DataSet1.Appointments);

            DataTable dt_for_show = GetDayCanReservation();
            if (dt_for_show == null)
            {
                MessageBox.Show("No Condition for this request");
                this.Close();
                return;
            }
            DataTable dt_for_show_read_easy = ConvertDataTableReadEasier(dt_for_show);
            dataGridView1.DataSource = dt_for_show_read_easy;

        }

        private static DataTable ConvertDataTableReadEasier(DataTable dt)
        {
            DataTable dt_fix = new DataTable();
            dt_fix.Columns.Add("Date Time", typeof(string));
            dt_fix.Columns.Add("Day Of Week", typeof(string));
            dt_fix.Columns.Add("Time On Day", typeof(string));
            dt_fix.Columns.Add("Scanner Type", typeof(string));
            dt_fix.Columns.Add("Request Type", typeof(string));
            dt_fix.Columns.Add("Scanner Position", typeof(string));

            DataTable scan_dat = SQL.GetScanner();
            DataTable req_dat = SQL.GetRequests();

            foreach (DataRow item in dt.Rows)
            {
                DateTime date = Convert.ToDateTime(item["day"]);
                // new date time 
                DateTime date_new = date;
                if (date.Year < 2500)
                    date_new = new DateTime(date.Year + 543, date.Month, date.Day);
                else
                    date_new = new DateTime(date.Year, date.Month, date.Day);
                int time = Convert.ToInt32(item["time"].ToString());
                string time_on_day = "";
                if (time == 1)
                    time_on_day = "Morning";
                else
                    time_on_day = "Afternoon";
                int scan_type = Convert.ToInt32(item["scan_type"].ToString());
                string scan_type_cmd = "scan_Id = " + scan_type;
                string scanner_type = scan_dat.Select(scan_type_cmd)[0]["scan_name"].ToString();
                int req_type = Convert.ToInt32(item["req_type"].ToString());
                string req_type_cmd = "req_Id = " + req_type;
                string req_type_str = req_dat.Select(req_type_cmd)[0]["req_bodypart"].ToString();
                int pos_scan = Convert.ToInt32(item["scan_numb"].ToString());
                string pos_scan_str = "";
                if (pos_scan == 1) pos_scan_str = "Down";
                else if (pos_scan == 2) pos_scan_str = "Up";
                string day_of_week = "";
                // 
                DateTime test = DateTime.Today.Date;

                switch (date_new.DayOfWeek)
                {
                    case DayOfWeek.Sunday:
                        day_of_week = "Sunday";
                        break;
                    case DayOfWeek.Monday:
                        day_of_week = "Monday";
                        break;
                    case DayOfWeek.Tuesday:
                        day_of_week = "Tuesday";
                        break;
                    case DayOfWeek.Wednesday:
                        day_of_week = "Wednesday";
                        break;
                    case DayOfWeek.Thursday:
                        day_of_week = "Thrusday";
                        break;
                    case DayOfWeek.Friday:
                        day_of_week = "Friday";
                        break;
                    case DayOfWeek.Saturday:
                        day_of_week = "Saturday";
                        break;
                    default:
                        break;
                }
                DataRow dr_fix = dt_fix.NewRow();
                dr_fix["Date Time"] = date_new.ToString().Split(' ')[0];
                dr_fix["Day Of Week"] = day_of_week.Trim();
                dr_fix["Time On Day"] = time_on_day.Trim();
                dr_fix["Scanner Type"] = scanner_type.Trim();
                dr_fix["Request Type"] = req_type_str.Trim();
                dr_fix["Scanner Position"] = pos_scan_str.Trim();
                dt_fix.Rows.Add(dr_fix);
            }

            return dt_fix;
        }

        private static DataTable GetDayCanReservation()
        {
            // create datatable for show 
            DataTable dt_reservation = new DataTable();
            dt_reservation.Columns.Add("day", typeof(string));
            dt_reservation.Columns.Add("time", typeof(Int16));
            dt_reservation.Columns.Add("scan_type", typeof(Int16));
            dt_reservation.Columns.Add("req_type", typeof(Int16));
            dt_reservation.Columns.Add("scan_numb", typeof(Int16));

            // do it for get that datatable to show
            DataTable appoint_dat = SQL.GetAppointment();
            DataTable req_cond_dat = SQL.GetReqCondition();
            DataTable req_dat = SQL.GetRequests();
            string search_req = "req_id = " + req_needed;
            int time_req_used = Convert.ToInt32(req_dat.Select(search_req)[0]["req_time"]);
            int count_on_show = 0;
            DateTime time_shifted = startT_needed;
            // check have cond req
            bool isFound = false;
            foreach (DataRow item in req_cond_dat.Rows)
            {
                string[] str_dat = item["possible_req"].ToString().Trim().Split(',');
                for (int i = 0; i < str_dat.Length; i++)
                {
                    int req_id_dat = Convert.ToInt32(str_dat[i]);
                    if (req_id_dat == req_needed)
                        isFound = true;
                }
            }

            if (!isFound)
                return null;

            // find day
            while (count_on_show <= 10)
            {
                // check the condition day 
                // sunday = 0, monday = 1, tuesday = 2, ....... to 6
                int day = (int)time_shifted.DayOfWeek;
                string day_needed = "cond_day = " + day;
                DataRow[] cond_day_needed = req_cond_dat.Select(day_needed);
                foreach (DataRow row_follow_day in cond_day_needed)
                {
                    string[] req_can_appoint = row_follow_day["possible_req"].ToString().Trim().Split(',');
                    for (int i = 0; i < req_can_appoint.Length; i++)
                    {
                        int req_possible = Convert.ToInt32(req_can_appoint[i]);
                        int time_limit = Convert.ToInt32(row_follow_day["cond_limit_time"]);
                        if (req_possible == req_needed)
                        {
                            // check time left
                            double time_left = GetTimeLeft(appoint_dat, req_dat,
                                time_shifted, Convert.ToInt32(row_follow_day["cond_time"]),
                                Convert.ToInt32(row_follow_day["cond_mri_machine_id"]), time_limit);

                            if (time_req_used < time_left)
                            {
                                // add this information to the list
                                DataRow dr_reservation = dt_reservation.NewRow();
                                string date_str = time_shifted.Day + "/" + time_shifted.Month
                                    + "/" + time_shifted.Year;
                                dr_reservation["day"] = date_str;
                                dr_reservation["time"] = Convert.ToInt16(row_follow_day["cond_time"]);
                                dr_reservation["scan_type"] = scanner_needed;
                                dr_reservation["req_type"] = req_needed;
                                dr_reservation["scan_numb"] = Convert.ToInt16(row_follow_day["cond_mri_machine_id"]);
                                dt_reservation.Rows.Add(dr_reservation);
                                count_on_show++;
                            }
                        }
                    }
                }
                time_shifted = time_shifted.AddDays(1);
            }
            return dt_reservation;
        }

        private static double GetTimeLeft(DataTable appointment_dat, DataTable req_dat,
            DateTime date_needed, int cond_time_needed, int mri_mac_cond, int time_limit)
        {
            double sum_of_time_used = 0;

            int day_needed = date_needed.Day;
            int month_needed = date_needed.Month;
            int year_needed = date_needed.Year;

            foreach (DataRow row in appointment_dat.Rows)
            {
                DateTime date_ap = Convert.ToDateTime(row["ap_startT"]);
                int day_ap = date_ap.Day;
                int month_ap = date_ap.Month;
                int year_ap = date_ap.Year;
                if (day_ap == day_needed && month_ap == month_needed
                    && year_ap == year_needed)
                {
                    // same day
                    // then check the range of that day
                    int hour_ap = date_ap.Hour;
                    int cond_time_ap = hour_ap <= 12 ? 1 : 2;
                    if (cond_time_ap == cond_time_needed)
                    {
                        // check mri machine condition
                        // 1 = machine down
                        // 2 = machine top
                        int mac_ap = Convert.ToInt32(row["ap_scan"]);
                        if (mac_ap == mri_mac_cond)
                        {
                            // adding the time
                            int req_ap = Convert.ToInt32(row["ap_request"]);
                            string req_search = "req_Id = " + req_ap;
                            int req_time_of_this_ap = Convert.ToInt32(req_dat.Select(req_search)[0]["req_time"]);
                            sum_of_time_used += req_time_of_this_ap;
                        }
                    }
                }
            }

            return time_limit - sum_of_time_used;
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int idx = dataGridView1.CurrentRow.Index;
            string date_str = dataGridView1.Rows[idx].Cells[0].Value.ToString();
            int day = Convert.ToInt32(date_str.Split('/')[0]);
            int month = Convert.ToInt32(date_str.Split('/')[1]);
            int year = Convert.ToInt32(date_str.Split('/')[2]) - 543;
            string time = dataGridView1.Rows[idx].Cells[2].Value.ToString();
            int hour = -1;
            if (time == "Morning") // morning
                hour = 9;
            else
                hour = 13;
            DateTime dt_pick = new DateTime(year, month, day, hour, 0, 0);

            picker_date_time.Value = dt_pick;

            Close();
        }
    }
}
