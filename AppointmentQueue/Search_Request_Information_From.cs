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
        public static DateTime startT_needed;
        public static int req_needed;
        public static int scanner_needed;

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

            GetDayCanReservation();
        }

        private static List<DateTime> GetDayCanReservation()
        {
            DataTable appoint_dat = GetAppointment();
            DataTable req_cond_dat = GetReqCondition();
            DataTable req_dat = GetRequests();
            foreach (DataRow item in appoint_dat.Rows)
            {
                DateTime ap_startT = Convert.ToDateTime(item["ap_startT"]);
                if (DateTime.Compare(ap_startT, startT_needed) >= 0)
                {
                    string search_req = "req_id = " + req_needed;
                    int time_req_used = Convert.ToInt32(req_dat.Select(search_req)[0]["req_time"]);
                    int count_on_show = 0;
                    DateTime time_shifted = startT_needed;
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
                                if (req_possible == req_needed)
                                {
                                    // check time left
                                }
                            }
                        }



                        time_shifted = time_shifted.AddDays(1);
                    }
                    //Console.WriteLine(ap_startT.ToString());

                }
            }
            return null;
        }

        //private double GetTimeLeft(DataTable appointment_dat, )

        private static DataTable GetAppointment()
        {
            SqlConnection cn = new SqlConnection(global::AppointmentQueue.Properties.Settings.Default.Database1ConnectionString);
            cn.Open();
            SqlCommand command = new SqlCommand("SELECT ap_id, ap_piority,ap_startT,ap_duraT,ap_patient,ap_request,ap_paid," +
                "ap_patientstatus,ap_insu,ap_scan,ap_scannum FROM Appointments", cn);
            //command.Parameters.AddWithValue("@StartT", startT);
            //command.Parameters.AddWithValue("@EndT", endT);
            SqlDataReader reader = command.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Columns.Add("ap_id", typeof(Int16));
            dt.Columns.Add("ap_piority", typeof(Int16));
            dt.Columns.Add("ap_startT", typeof(DateTime));
            dt.Columns.Add("ap_duraT", typeof(DateTime));
            dt.Columns.Add("ap_patient", typeof(string));
            dt.Columns.Add("ap_request", typeof(Int16));
            dt.Columns.Add("ap_paid", typeof(Int16));
            dt.Columns.Add("ap_patientstatus", typeof(Int16));
            dt.Columns.Add("ap_insu", typeof(Int16));
            dt.Columns.Add("ap_scan", typeof(Int16));
            dt.Columns.Add("ap_scannum", typeof(Int16));
            //dt.Load(reader);

            Console.WriteLine("---start read appointment---");
            while (reader.Read())
            {
                //scan_CoBox.Items.Add(reader[1].ToString());
                DataRow row = dt.NewRow();
                row["ap_id"] = reader[0];
                row["ap_piority"] = reader[1];
                row["ap_startT"] = reader[2];
                row["ap_duraT"] = reader[3];
                row["ap_patient"] = reader[4];
                row["ap_request"] = reader[5];
                row["ap_paid"] = reader[6];
                row["ap_patientstatus"] = reader[7];
                row["ap_insu"] = reader[8];
                row["ap_scan"] = reader[9];
                row["ap_scannum"] = reader[10];
                dt.Rows.Add(row);
            }

            Console.WriteLine("---read end---");
            //Console.WriteLine("---show id loading sample---");
            //foreach (DataRow item in dt.Rows)
            //{
            //    Console.WriteLine(item["ap_id"]);
            //    DateTime startdate = Convert.ToDateTime(item["ap_startT"]);
            //    Console.WriteLine(startdate.DayOfWeek.ToString());
            //}

            Console.WriteLine("---close connection---");
            cn.Close();
            return dt;
        }

        private static DataTable GetReqCondition()
        {
            SqlConnection cn = new SqlConnection(global::AppointmentQueue.Properties.Settings.Default.Database1ConnectionString);
            cn.Open();
            SqlCommand command = new SqlCommand("SELECT Id, possible_req, cond_time, cond_day, " +
                "cond_limit_time, cond_mri_machine_id FROM ConditionRequest", cn);
            //command.Parameters.AddWithValue("@StartT", startT);
            //command.Parameters.AddWithValue("@EndT", endT);
            SqlDataReader reader = command.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Columns.Add("Id", typeof(Int16));
            dt.Columns.Add("possible_req", typeof(string));
            dt.Columns.Add("cond_time", typeof(Int16));
            dt.Columns.Add("cond_day", typeof(Int16));
            dt.Columns.Add("cond_limit_time", typeof(Int16));
            dt.Columns.Add("cond_mri_machine_id", typeof(Int16));
            //dt.Load(reader);

            Console.WriteLine("---start read Condition Request---");
            while (reader.Read())
            {
                //scan_CoBox.Items.Add(reader[1].ToString());
                DataRow row = dt.NewRow();
                row["Id"] = reader[0];
                row["possible_req"] = reader[1];
                row["cond_time"] = reader[2];
                row["cond_day"] = reader[3];
                row["cond_limit_time"] = reader[4];
                row["cond_mri_machine_id"] = reader[5];
                dt.Rows.Add(row);
            }

            Console.WriteLine("---read end---");
            Console.WriteLine("---show id loading sample---");
            foreach (DataRow item in dt.Rows)
            {
                Console.WriteLine(item["Id"]);
                Console.WriteLine(item["possible_req"]);
                Console.WriteLine(item["cond_time"]);
                Console.WriteLine(item["cond_day"]);
                Console.WriteLine(item["cond_limit_time"]);
                Console.WriteLine(item["cond_mri_machine_id"]);
                Console.WriteLine("-------------------------");
            }

            Console.WriteLine("---close connection---");
            cn.Close();
            return dt;
        }

        private static DataTable GetRequests()
        {
            SqlConnection cn = new SqlConnection(global::AppointmentQueue.Properties.Settings.Default.Database1ConnectionString);
            cn.Open();
            SqlCommand command = new SqlCommand("SELECT req_Id, req_scan, req_bodypart, req_time FROM Requests", cn);
            //command.Parameters.AddWithValue("@StartT", startT);
            //command.Parameters.AddWithValue("@EndT", endT);
            SqlDataReader reader = command.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Columns.Add("req_Id", typeof(Int16));
            dt.Columns.Add("req_scan", typeof(Int16));
            dt.Columns.Add("req_bodypart", typeof(string));
            dt.Columns.Add("req_time", typeof(Int16)); // minute measure
            //dt.Load(reader);

            Console.WriteLine("---start read Request---");
            while (reader.Read())
            {
                //scan_CoBox.Items.Add(reader[1].ToString());
                DataRow row = dt.NewRow();
                row["req_Id"] = reader[0];
                row["req_scan"] = reader[1];
                row["req_bodypart"] = reader[2];
                row["req_time"] = reader[3];
                dt.Rows.Add(row);
            }

            Console.WriteLine("---read end---");
            Console.WriteLine("---show id loading sample---");
            foreach (DataRow item in dt.Rows)
            {
                Console.WriteLine(item["req_Id"]);
                Console.WriteLine(item["req_scan"]);
                Console.WriteLine(item["req_bodypart"]);
                Console.WriteLine(item["req_time"]);
                Console.WriteLine("-------------------------");
            }

            Console.WriteLine("---close connection---");
            cn.Close();
            return dt;
        }
    }
}
