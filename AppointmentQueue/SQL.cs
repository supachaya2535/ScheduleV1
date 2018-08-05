using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlLocalDb;

namespace AppointmentQueue
{
    class SQL
    {
        public static DataTable GetAppointment(DateTime startT, DateTime endT, String patient, String period, String request)
        {
            SqlConnection cn = new SqlConnection(global::AppointmentQueue.Properties.Settings.Default.Database1ConnectionString);
            cn.Open();

            //startT = new DateTime(startT.Year, startT.Month, startT.Day, 1, 0, 0);
            //startT = startT.AddTicks(+1);
            endT = endT.AddDays(1).AddTicks(-1);
            SqlCommand command = new SqlCommand(
                "SELECT ap_id,ap_startT,ap_patient,ap_period,ap_request,ap_detail,req_bodypart,ap_appstatus,ap_scan,scan_name,req_time " +
                "FROM Appointments " +
                "JOIN Scanners ON ap_scan = scan_Id "+
                "JOIN Requests ON ap_request = req_Id "+
                "WHERE ap_startT BETWEEN @StartT AND @EndT "+
                "AND ap_patient LIKE '%" + patient.Trim() + "%' "+
                "AND ap_period LIKE '" + period.Trim() + "%'"+
                "AND req_bodypart LIKE '" + request.Trim() + "%' ORDER BY ap_startT", cn);
            
            command.Parameters.AddWithValue("@StartT", startT);
            command.Parameters.AddWithValue("@EndT", endT);

            SqlDataReader reader = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("ap_id", typeof(Int16));
            dt.Columns.Add("ap_startT", typeof(String));
            dt.Columns.Add("ap_patient", typeof(String));
            dt.Columns.Add("ap_period", typeof(String));
            dt.Columns.Add("ap_request", typeof(Int16));
            dt.Columns.Add("req_bodypart", typeof(String));
            dt.Columns.Add("ap_detail", typeof(String));
            dt.Columns.Add("ap_appstatus", typeof(String));
            dt.Columns.Add("ap_scan", typeof(Int16));
            dt.Columns.Add("scan_name", typeof(String));
            dt.Columns.Add("req_time", typeof(Int16));

            dt.Load(reader);

            /*// cut out time from column ap_startT
            foreach (DataRow item in dt.Rows)
            {
                string date = item["ap_startT"].ToString();
                string new_format_date = date.Split(' ')[0];
                item["ap_startT"] = new_format_date;
            }*/

            cn.Close();
            return dt;
        }
        
        public static DataTable GetRequests(String request)
        {
            SqlConnection cn = new SqlConnection(global::AppointmentQueue.Properties.Settings.Default.Database1ConnectionString);
            cn.Open();
            SqlCommand command = new SqlCommand("SELECT req_Id, req_bodypart, req_time " +
                "FROM Requests "+
                "WHERE req_bodypart LIKE '" + request.Trim() + "%'"
                , cn);
            
            SqlDataReader reader = command.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Columns.Add("req_Id", typeof(Int16));
            dt.Columns.Add("req_bodypart", typeof(string));
            dt.Columns.Add("req_time", typeof(Int16)); // minute measure

            dt.Load(reader);
            cn.Close();
            return dt;
        }

        public static DataTable GetScanner(String scanname)
        {
            SqlConnection cn = new SqlConnection(global::AppointmentQueue.Properties.Settings.Default.Database1ConnectionString);
            cn.Open();
            SqlCommand command = new SqlCommand("SELECT scan_Id, scan_name, scan_quantity FROM Scanners "+
                "WHERE scan_name LIKE '%" + scanname + "%'", cn);
            
            SqlDataReader reader = command.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Columns.Add("scan_Id", typeof(Int16));
            dt.Columns.Add("scan_name", typeof(string));
            dt.Columns.Add("scan_quantity", typeof(Int16));

            dt.Load(reader);
            cn.Close();
            return dt;
        }

        public static DataTable GetDoctors(String name, String lname)
        {
            SqlConnection cn = new SqlConnection(global::AppointmentQueue.Properties.Settings.Default.Database1ConnectionString);
            cn.Open();
            SqlCommand command = new SqlCommand(
                "SELECT dr_id,dr_name,dr_lname "+
                "FROM Doctors WHERE dr_name LIKE '%" + name + "%' "+
                "AND dr_lname LIKE '%" + lname + "%'", cn);
            SqlDataReader reader = command.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Columns.Add("dr_id", typeof(string));
            dt.Columns.Add("dr_name", typeof(string));
            dt.Columns.Add("dr_lname", typeof(string));
            
            dt.Load(reader);
            cn.Close();
            return dt;
        }

        public static DataTable GetDayOffs(DateTime startT, DateTime endT, String drName)
        {
            SqlConnection cn = new SqlConnection(global::AppointmentQueue.Properties.Settings.Default.Database1ConnectionString);
            cn.Open();
            endT = endT.AddDays(1).AddTicks(-1);
            SqlCommand command = new SqlCommand(
                "SELECT df_id,df_date,df_dr,dr_name,df_period,df_detail " +
                "FROM DayOffs "+
                "JOIN Doctors ON df_dr = dr_Id "+
                "WHERE df_date BETWEEN @StartT AND  @EndT "+
                "AND dr_lname LIKE '%" + drName + "%'"
                , cn);
            command.Parameters.AddWithValue("@StartT", startT);
            command.Parameters.AddWithValue("@EndT", endT);
            SqlDataReader reader = command.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Columns.Add("df_id", typeof(Int16));
            dt.Columns.Add("df_date", typeof(String));
            dt.Columns.Add("df_dr", typeof(string));
            dt.Columns.Add("dr_name", typeof(string));
            dt.Columns.Add("df_period", typeof(string));
            dt.Columns.Add("df_detail", typeof(string));
            dt.Load(reader);
            cn.Close();

            /*foreach (DataRow item in dt.Rows)
            {
                string date = item["df_date"].ToString();
                string new_format_date = date.Split(' ')[0];
                item["df_date"] = new_format_date;
            }*/

            return dt;
        }
        
        /// <summary>
        /// fully return doctor calendars (all of data)
        /// </summary>
        /// <returns></returns>
        public static DataTable GetDoctorCalendars()
        {
            SqlConnection cn = new SqlConnection(global::AppointmentQueue.Properties.Settings.Default.Database1ConnectionString);
            cn.Open();
            SqlCommand command = new SqlCommand(
               "SELECT drc_id, drc_date, drc_drw, drc_time, drc_status " +
               "FROM DoctorCalendars "
               , cn);
            SqlDataReader reader = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("drc_id", typeof(Int16));
            dt.Columns.Add("drc_date", typeof(String));
            dt.Columns.Add("drc_drw", typeof(String));
            dt.Columns.Add("drc_time", typeof(Int16));
            dt.Columns.Add("drc_status", typeof(String));
            dt.Load(reader);
            cn.Close();

            foreach (DataRow item in dt.Rows)
            {
                string display = "";
                display += item["drc_id"].ToString() + "\n";
                display += item["drc_date"].ToString() + "\n";
                display += item["drc_drw"].ToString() + "\n";
                display += item["drc_time"].ToString() + "\n";
                display += item["drc_status"].ToString() + "\n";
                MessageBox.Show(display);
            }

            return dt;
        }

        public static DataTable GetDoctorCalendars(DateTime start_date, DateTime end_date)
        {
            SqlConnection cn = new SqlConnection(global::AppointmentQueue.Properties.Settings.Default.Database1ConnectionString);
            cn.Open();
            SqlCommand command = new SqlCommand(
               "SELECT * " +
               "FROM DoctorCalendars " +
               "JOIN DoctorWorks ON drc_drw = drw_id " +
               "JOIN Doctors ON dr_Id = drw_dr " +
               "WHERE drc_date BETWEEN @StartT AND @EndT"
               , cn);

            command.Parameters.AddWithValue("@StartT", start_date);
            command.Parameters.AddWithValue("@EndT", end_date);

            SqlDataReader reader = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("drc_id", typeof(Int16));
            dt.Columns.Add("drc_date", typeof(DateTime));
            dt.Columns.Add("drc_drw", typeof(String));
            dt.Columns.Add("drc_time", typeof(Int16));
            dt.Columns.Add("drc_status", typeof(String));
            dt.Columns.Add("drw_dow", typeof(String));
            dt.Columns.Add("drw_period", typeof(String));
            dt.Columns.Add("dr_name", typeof(String));
            dt.Columns.Add("dr_lname", typeof(String));

            dt.Load(reader);
            cn.Close();

            //foreach (DataRow item in dt.Rows)
            //{
            //    string display = "";
            //    display += item["drc_id"].ToString() + "\n";
            //    display += item["drc_date"].ToString() + "\n";
            //    display += item["drc_drw"].ToString() + "\n";
            //    display += item["drc_time"].ToString() + "\n";
            //    display += item["drc_status"].ToString() + "\n";
            //    display += item["drw_dow"].ToString() + "\n";
            //    display += item["drw_period"].ToString() + "\n";
            //    display += item["dr_name"].ToString() + " " + item["dr_lname"].ToString();
            //    MessageBox.Show(display);
            //}

            return dt;
        }

        /// <summary>
        /// get fully of data of DoctorRequests database (join with doctor and request database)
        /// </summary>
        /// <returns></returns>
        public static DataTable GetDoctorRequests()
        {
            SqlConnection cn = new SqlConnection(global::AppointmentQueue.Properties.Settings.Default.Database1ConnectionString);
            cn.Open();
            SqlCommand command = new SqlCommand(
                "SELECT drreq_Id,req_bodypart,dr_name,drreq_period,drreq_kid,drreq_dayofweek,dr_Id " +
                "FROM DoctorRequests " +
                "JOIN Doctors ON dr_Id = drreq_dr " +
                "JOIN Requests ON req_Id = drreq_req "
                , cn);
            SqlDataReader reader = command.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Columns.Add("drreq_Id", typeof(Int16));
            dt.Columns.Add("req_bodypart", typeof(String));
            dt.Columns.Add("dr_name", typeof(String));
            dt.Columns.Add("drreq_period", typeof(String));
            dt.Columns.Add("drreq_kid", typeof(String));
            dt.Columns.Add("drreq_dayofweek", typeof(String));
            dt.Columns.Add("dr_Id", typeof(Int16));
            dt.Load(reader);
            cn.Close();
            return dt;
        }
        
        public static DataTable GetDoctorRequests(String req, String dr)
        {
            SqlConnection cn = new SqlConnection(global::AppointmentQueue.Properties.Settings.Default.Database1ConnectionString);
            cn.Open();
            SqlCommand command = new SqlCommand(
                "SELECT drreq_Id,drreq_req,req_bodypart,drreq_dr,dr_name " +
                "FROM DoctorRequests "+
                "JOIN Doctors ON dr_Id = drreq_dr " +
                "JOIN Requests ON req_Id = drreq_req " +
                "WHERE req_bodypart LIKE '%" + req.Trim() + "%' " +
                "AND dr_name LIKE '%" + dr.Trim() + "%'" 
                , cn);

            SqlDataReader reader = command.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Columns.Add("drreq_Id", typeof(String));
            dt.Columns.Add("drreq_req", typeof(String));
            dt.Columns.Add("req_bodypart", typeof(String));
            dt.Columns.Add("drreq_dr", typeof(String));
            dt.Columns.Add("dr_name", typeof(String));

            dt.Load(reader);
            cn.Close();
            return dt;
        }

        /// <summary>
        ///  fully get data of GetDoctorWorks database (join with Doctors database)
        /// </summary>
        /// <returns></returns>
        public static DataTable GetDoctorWorks()
        {
            SqlConnection cn = new SqlConnection(global::AppointmentQueue.Properties.Settings.Default.Database1ConnectionString);
            cn.Open();
            SqlCommand command = new SqlCommand(
                "SELECT *" +
                "FROM DoctorWorks " +
                "JOIN Doctors ON dr_Id = drw_dr "
                , cn);
            SqlDataReader reader = command.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Columns.Add("drw_Id", typeof(Int16));
            dt.Columns.Add("drw_dr", typeof(String));
            dt.Columns.Add("dr_name", typeof(String));
            dt.Columns.Add("drw_period", typeof(String));
            dt.Columns.Add("drw_kid", typeof(String));
            dt.Columns.Add("drw_dayofweek", typeof(String));
            dt.Load(reader);
            cn.Close();
            return dt;
        }

        public static DataTable GetDoctorWorks(String ped, String dr, string kid)
        {
            SqlConnection cn = new SqlConnection(global::AppointmentQueue.Properties.Settings.Default.Database1ConnectionString);
            cn.Open();
            SqlCommand command = new SqlCommand(
                "SELECT drw_id,drw_dr,drw_sdate,drw_edate,drw_dow,drw_period," +
                        "drw_kid,drw_w1,drw_w2,drw_w3,drw_w4,drw_status "+
                "FROM DoctorWorks " +
                "JOIN Doctors ON dr_Id = drw_dr " +
                "AND dr_name LIKE '" + dr.Trim() + "%'" +
                "AND drw_kid LIKE '" + kid.Trim() + "%'" +
                "AND drw_period LIKE '" + ped.Trim() + "%'"
                , cn);
            SqlDataReader reader = command.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Columns.Add("drw_id", typeof(Int16));
            dt.Columns.Add("drw_dr", typeof(String));
            dt.Columns.Add("drw_sdate", typeof(String));
            dt.Columns.Add("drw_edate", typeof(String));
            dt.Columns.Add("drw_dow", typeof(String));
            dt.Columns.Add("drw_period", typeof(String));
            dt.Columns.Add("drw_kid", typeof(String));
            dt.Columns.Add("drw_w1", typeof(String));
            dt.Columns.Add("drw_w2", typeof(String));
            dt.Columns.Add("drw_w3", typeof(String));
            dt.Columns.Add("drw_w4", typeof(String));
            dt.Columns.Add("drw_status", typeof(String));

            dt.Load(reader);
            cn.Close();
            return dt;
        }

        public static DataTable GetDoctorCalendars(DateTime startT, DateTime endT, String req, String kid)
        {
            SqlConnection cn = new SqlConnection(global::AppointmentQueue.Properties.Settings.Default.Database1ConnectionString);
            cn.Open();
            
            /*SqlCommand command = new SqlCommand(
                "SELECT drc_id,drc_date,drc_drw,drc_time,drw_status" +
                "FROM DoctorCalendars "+
                "JOIN DoctorWorks ON drw_id = drc_drw " +
                "JOIN DoctorRequests ON drw_dr = drreq_dr " +
                "WHERE drc_date BETWEEN @StartT AND  @EndT " +
                "AND drw_kid LIKE '" + kid.Trim() + "%'" +
                "AND drreq_req LIKE '%" + req + "%'"
                , cn);*/

            SqlCommand command = new SqlCommand(
            "SELECT drc_id,drc_date,drc_drw,drc_time,drc_status " +
            "FROM DoctorCalendars "+
            "WHERE drc_drw IN (SELECT drw_Id FROM DoctorWorks " +
                               "WHERE drw_dr IN (SELECT drreq_dr FROM DoctorRequests " +
                                                "JOIN Requests ON req_Id = drreq_req "+
                                                "WHERE req_bodypart LIKE '%" + req.Trim() + "%') "+
                               "AND drw_kid LIKE '" + kid.Trim() + "%') " +
             "AND drc_date BETWEEN @StartT AND  @EndT " 
             , cn);

           
            command.Parameters.AddWithValue("@StartT", startT);
            command.Parameters.AddWithValue("@EndT", endT);
            
            SqlDataReader reader = command.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Columns.Add("drc_id", typeof(Int16));
            dt.Columns.Add("drc_date", typeof(String));
            dt.Columns.Add("drc_drw", typeof(String));
            dt.Columns.Add("drc_time", typeof(Int16));
            dt.Columns.Add("drc_status", typeof(String));

            dt.Load(reader);
            cn.Close();
            return dt;
        }
        
        public static int getDof(String dayName)
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

        public static ComboBox readScanner(ComboBox scan_CoBox)
        {
            SqlConnection cn = new SqlConnection(global::AppointmentQueue.Properties.Settings.Default.Database1ConnectionString);
            cn.Open();
            SqlCommand command = new SqlCommand("SELECT scan_id,scan_name FROM Scanners", cn);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                scan_CoBox.Items.Add(reader[1].ToString());

            }

            cn.Close();
            return scan_CoBox;
        }

        public static ComboBox readRequest(ComboBox reqCob)
        {
            SqlConnection cn = new SqlConnection(global::AppointmentQueue.Properties.Settings.Default.Database1ConnectionString);
            cn.Open();
            SqlCommand command = new SqlCommand("SELECT req_id,req_bodypart FROM Requests ", cn);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                reqCob.Items.Add(reader[1].ToString());
                string str = reader[1].ToString();
            }

            cn.Close();
            return reqCob;
        }


    }
}
