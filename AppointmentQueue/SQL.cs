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
        public static String ConnectionStr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Toon\\Documents\\GitDoc\\ScheduleHospital\\AppointmentQueue\\Database1.mdf;Integrated Security=True";
        public static DataTable GetAppointment(DateTime startT, DateTime endT, String patient, String period, String request)
        {
            SqlConnection cn = new SqlConnection(ConnectionStr);
            cn.Open();
            endT = endT.AddDays(1).AddTicks(-1);

            SqlCommand command = new SqlCommand(
               "SELECT ap_Id,ap_drc,drc_date,ap_patient,drw_dr,dr_name,ap_request," +
               "req_bodypart,ap_detail,ap_appstatus, drw_kid,drw_period " +
               "FROM Appointments " +
               "JOIN DoctorCalendars ON drc_id = ap_drc " +
               "JOIN DoctorWorks ON drw_id = drc_drw " +
               "JOIN Requests ON ap_request = req_Id " +
                "JOIN Doctors ON drw_dr = dr_Id " +
               "WHERE drw_period LIKE '" + period.Trim() + "%' " +
               "AND drc_date BETWEEN @StartT AND @EndT " +
               "AND ap_patient LIKE '%" + patient.Trim() + "%' " +
               "AND req_bodypart LIKE '%" + request.Trim() + "%' " +
               "ORDER BY drc_date", cn);

            command.Parameters.AddWithValue("@StartT", startT);
            command.Parameters.AddWithValue("@EndT", endT);

            SqlDataReader reader = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("ap_Id", typeof(Int16));
            dt.Columns.Add("ap_drc", typeof(String));
            dt.Columns.Add("drc_date", typeof(String));
            dt.Columns.Add("ap_patient", typeof(String));
            dt.Columns.Add("dr_name", typeof(String));
            dt.Columns.Add("drw_period", typeof(String));
            dt.Columns.Add("req_bodypart", typeof(String));
            dt.Columns.Add("ap_appstatus", typeof(String));

            dt.Columns.Add("ap_detail", typeof(String));
            dt.Columns.Add("drw_dr", typeof(String));
            dt.Columns.Add("ap_request", typeof(Int16));

            dt.Load(reader);

            dt.Columns["ap_Id"].ColumnName = "Appointment ID";
            dt.Columns["ap_drc"].ColumnName = "Appointment Docter Calendar";
            dt.Columns["drc_date"].ColumnName = "Date of Appointment";
            dt.Columns["ap_patient"].ColumnName = "Patient Information";
            dt.Columns["dr_name"].ColumnName = "Doctor Name";
            dt.Columns["drw_period"].ColumnName = "Doctor Work Period";
            dt.Columns["req_bodypart"].ColumnName = "Part of request";
            dt.Columns["ap_appstatus"].ColumnName = "Appointment Status";
            dt.Columns["drw_kid"].ColumnName = "Kid Status";
            dt.Columns["ap_detail"].ColumnName = "Appointment Detail";
            dt.Columns["drw_dr"].ColumnName = "Doctor Work";
            dt.Columns["ap_request"].ColumnName = "Appointment Request";

            cn.Close();
            return dt;
        }

        public static DataTable GetAppointment(String status)
        {
            SqlConnection cn = new SqlConnection(ConnectionStr);
            cn.Open();

            SqlCommand command = new SqlCommand(
               "SELECT ap_Id,ap_drc,drc_date,ap_patient,drw_dr,dr_name,ap_request," +
               "req_bodypart,ap_detail,ap_appstatus, drw_kid,drw_period " +
               "FROM Appointments " +
               "JOIN DoctorCalendars ON drc_id = ap_drc " +
               "JOIN DoctorWorks ON drw_id = drc_drw " +
               "JOIN Requests ON ap_request = req_Id " +
               "JOIN Doctors ON drw_dr = dr_Id " +
               "WHERE ap_appstatus LIKE '" + status.Trim() + "%' " +
               "ORDER BY drc_date", cn);


            SqlDataReader reader = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("ap_id", typeof(Int16));
            dt.Columns.Add("ap_drc", typeof(String));
            dt.Columns.Add("drc_date", typeof(String));
            dt.Columns.Add("ap_patient", typeof(String));
            dt.Columns.Add("dr_name", typeof(String));
            dt.Columns.Add("drw_period", typeof(String));
            dt.Columns.Add("req_bodypart", typeof(String));
            dt.Columns.Add("ap_appstatus", typeof(String));

            dt.Columns.Add("ap_detail", typeof(String));
            dt.Columns.Add("drw_dr", typeof(String));
            dt.Columns.Add("ap_request", typeof(Int16));

            dt.Load(reader);

            cn.Close();
            return dt;
        }

        public static DataTable GetRequests(String request)
        {
            SqlConnection cn = new SqlConnection(ConnectionStr);
            cn.Open();
            SqlCommand command = new SqlCommand("SELECT req_Id, req_bodypart, req_time " +
                "FROM Requests " +
                "WHERE req_bodypart LIKE '" + request.Trim() + "%'"
                , cn);

            SqlDataReader reader = command.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Columns.Add("req_Id", typeof(Int16));
            dt.Columns.Add("req_bodypart", typeof(string));
            dt.Columns.Add("req_time", typeof(Int16)); // minute measure

            dt.Load(reader);

            dt.Columns["req_Id"].ColumnName = "Request ID";
            dt.Columns["req_bodypart"].ColumnName = "Bodypart";
            dt.Columns["req_time"].ColumnName = "Time Used of each Request";

            cn.Close();
            return dt;
        }

        public static DataTable GetScanner(String scanname)
        {
            SqlConnection cn = new SqlConnection(ConnectionStr);
            cn.Open();
            SqlCommand command = new SqlCommand("SELECT scan_Id, scan_name FROM Scanners " +
                "WHERE scan_name LIKE '%" + scanname + "%'", cn);

            SqlDataReader reader = command.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Columns.Add("scan_Id", typeof(Int16));
            dt.Columns.Add("scan_name", typeof(string));
            dt.Load(reader);

            dt.Columns["scan_Id"].ColumnName = "Scanner ID";
            dt.Columns["scan_name"].ColumnName = "Scanner Name";

            cn.Close();
            return dt;
        }

        public static DataTable GetDoctors(String name, String lname)
        {
            SqlConnection cn = new SqlConnection(ConnectionStr);
            cn.Open();
            SqlCommand command = new SqlCommand(
                "SELECT dr_id,dr_name,dr_lname " +
                "FROM Doctors WHERE dr_name LIKE '%" + name + "%' " +
                "AND dr_lname LIKE '%" + lname + "%'", cn);
            SqlDataReader reader = command.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Columns.Add("dr_id", typeof(string));
            dt.Columns.Add("dr_name", typeof(string));
            dt.Columns.Add("dr_lname", typeof(string));

            dt.Load(reader);
            dt.Columns["dr_id"].ColumnName = "Doctor ID";
            dt.Columns["dr_name"].ColumnName = "Doctor Name";
            dt.Columns["dr_lname"].ColumnName = "Doctor Last Name";

            cn.Close();
            return dt;
        }

        public static DataTable GetDayOffs(DateTime startT, DateTime endT, String drName)
        {
            SqlConnection cn = new SqlConnection(ConnectionStr);
            cn.Open();
            endT = endT.AddDays(1).AddTicks(-1);
            SqlCommand command = new SqlCommand(
                "SELECT df_id,df_date,df_dr,dr_name,df_period,df_detail " +
                "FROM DayOffs " +
                "JOIN Doctors ON df_dr = dr_Id " +
                "WHERE df_date BETWEEN @StartT AND  @EndT " +
                "AND dr_name LIKE '%" + drName + "%'"
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

        public static DataTable GetDayOffs(String drName)
        {
            SqlConnection cn = new SqlConnection(ConnectionStr);
            cn.Open();
            
            SqlCommand command = new SqlCommand(
                "SELECT df_id,df_date,df_dr,dr_name,df_period,df_detail " +
                "FROM DayOffs " +
                "JOIN Doctors ON df_dr = dr_Id " +
                "WHERE dr_name LIKE '%" + drName + "%'"
                , cn);
            SqlDataReader reader = command.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Columns.Add("df_id", typeof(Int16));
            dt.Columns.Add("df_date", typeof(String));
            dt.Columns.Add("df_dr", typeof(string));
            dt.Columns.Add("dr_name", typeof(string));
            dt.Columns.Add("df_period", typeof(string));
            dt.Columns.Add("df_detail", typeof(string));
            dt.Load(reader);

            dt.Columns["df_id"].ColumnName = "Day Off ID";
            dt.Columns["df_date"].ColumnName = "Date and Time";
            dt.Columns["df_dr"].ColumnName = "Doctor ID";
            dt.Columns["dr_name"].ColumnName = "Doctor Name";
            dt.Columns["df_period"].ColumnName = "Day Off Period";
            dt.Columns["df_detail"].ColumnName = "Detail";

            cn.Close();

            /*foreach (DataRow item in dt.Rows)
            {
                string date = item["df_date"].ToString();
                string new_format_date = date.Split(' ')[0];
                item["df_date"] = new_format_date;
            }*/

            return dt;
        }


        public static void InsertDayOffs(DateTime date, String dr_id, String ped, String detail)
        {
            SqlConnection cn = new SqlConnection(ConnectionStr);
            SqlCommand command = new SqlCommand(
                "INSERT INTO DayOffs (df_date,df_dr,df_period,df_detail) " +
                "VALUES (@df_date,@df_dr,@df_period,@df_detail)", cn);

            command.Parameters.AddWithValue("@df_date", date);
            command.Parameters.AddWithValue("@df_dr", dr_id);
            command.Parameters.AddWithValue("@df_period", ped.Trim());
            command.Parameters.AddWithValue("@df_detail", detail.Trim());
            command.Connection = cn;

            cn.Open();
            command.ExecuteNonQuery();
            cn.Close();


        }

        public static DataTable GetDoctorCalendars()
        {
            SqlConnection cn = new SqlConnection(ConnectionStr);
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
            SqlConnection cn = new SqlConnection(ConnectionStr);
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

            return dt;
        }

        public static DataTable GetDoctorCalendars(String dr_id, DateTime date)
        {
            SqlConnection cn = new SqlConnection(ConnectionStr);
            cn.Open();
            SqlCommand command = new SqlCommand(
               "SELECT * " +
               "FROM DoctorCalendars " +
               "JOIN DoctorWorks ON drc_drw = drw_id " +
               "JOIN Doctors ON dr_Id = drw_dr " +
               "WHERE drc_date BETWEEN @StartT AND @EndT"
               , cn);

            command.Parameters.AddWithValue("@StartT", date);
            command.Parameters.AddWithValue("@EndT", date.AddDays(1).AddTicks(-1));

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

            return dt;
        }

        public static void UpDateDoctorCalendars(String drc_id, String drc_status)
        {
            SqlConnection cn = new SqlConnection(ConnectionStr);
            SqlCommand command = new SqlCommand(
                "UPDATE DoctorCalendars SET drc_status = @drc_status " +
                "WHERE drc_id = @drc_id ", cn);

            command.Parameters.AddWithValue("@drc_id", drc_id.Trim());
            command.Parameters.AddWithValue("@drc_status", drc_status.Trim());

            command.Connection = cn;

            cn.Open();
            command.ExecuteNonQuery();
            cn.Close();
        }


        public static DataTable GetDoctorRequests()
        {
            SqlConnection cn = new SqlConnection(ConnectionStr);
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
            SqlConnection cn = new SqlConnection(ConnectionStr);
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

            dt.Columns["drreq_Id"].ColumnName = "Doctor Request ID";
            dt.Columns["drreq_req"].ColumnName = "Request ID";
            dt.Columns["req_bodypart"].ColumnName = "Bodypart";
            dt.Columns["drreq_dr"].ColumnName = "Doctor ID";
            dt.Columns["dr_name"].ColumnName = "Doctor Name";

            cn.Close();
            return dt;
        }
        
        public static DataTable GetDoctorWorks(String drw_id)
        {
            SqlConnection cn = new SqlConnection(ConnectionStr);
            cn.Open();
            SqlCommand command = new SqlCommand(
                "SELECT *" +
                "FROM DoctorWorks " +
                "JOIN Doctors ON dr_Id = drw_dr "+
                "WHERE drw_id LIKE '"+ drw_id +"'"
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
            dt.Columns.Add("drw_scan", typeof(String));


            dt.Load(reader);
            cn.Close();
            return dt;
        }

        public static DataTable GetDoctorWorks(String ped, String dr, string kid, String status, String dow, String scan)
        {
            SqlConnection cn = new SqlConnection(ConnectionStr);
            cn.Open();
            SqlCommand command = new SqlCommand(
                "SELECT drw_id,drw_dr,drw_sdate,drw_edate,drw_dow,drw_period," +
                        "drw_kid,drw_w1,drw_w2,drw_w3,drw_w4,drw_status,drw_scan " +
                "FROM DoctorWorks " +
                "JOIN Doctors ON dr_Id = drw_dr " +
                "WHERE drw_dow LIKE '" + dow.Trim() + "%' " +
                "AND drw_dr LIKE '" + dr.Trim() + "%' " +
                "AND drw_kid LIKE '" + kid.Trim() + "%' " +
                "AND drw_status LIKE '" + status.Trim() + "%' " +
                "AND drw_scan LIKE '" + scan.Trim() + "%' " +
                "AND drw_period LIKE '" + ped.Trim() + "%' "
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
            dt.Columns.Add("drw_scan", typeof(String));

            dt.Load(reader);
            cn.Close();
            return dt;
        }

        public static DataTable GetDoctorWorks(String ped, String dr, string kid, String status, String dow)
        {
            SqlConnection cn = new SqlConnection(ConnectionStr);
            cn.Open();
            SqlCommand command = new SqlCommand(
                "SELECT drw_id,drw_dr,drw_sdate,drw_edate,drw_dow,drw_period," +
                        "drw_kid,drw_w1,drw_w2,drw_w3,drw_w4,drw_status,drw_scan "+
                "FROM DoctorWorks " +
                "JOIN Doctors ON dr_Id = drw_dr " +
                "WHERE drw_dow LIKE '" + dow.Trim() + "%'" +
                "AND drw_dr LIKE '" + dr.Trim() + "%'" +
                "AND drw_kid LIKE '" + kid.Trim() + "%'" +
                "AND drw_status LIKE '" + status.Trim() + "%'" +
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
            dt.Columns.Add("drw_scan", typeof(String));

            dt.Load(reader);

            dt.Columns["drw_id"].ColumnName = "Doctor Work ID";
            dt.Columns["drw_dr"].ColumnName = "Doctor Name";
            dt.Columns["drw_sdate"].ColumnName = "Start Date";
            dt.Columns["drw_edate"].ColumnName = "End Date";
            dt.Columns["drw_dow"].ColumnName = "Day of Work";
            dt.Columns["drw_period"].ColumnName = "Period Of Day";
            dt.Columns["drw_kid"].ColumnName = "Kid Status";
            dt.Columns["drw_w1"].ColumnName = "Week1 Work";
            dt.Columns["drw_w2"].ColumnName = "Week2 Work";
            dt.Columns["drw_w3"].ColumnName = "Week3 Work";
            dt.Columns["drw_w4"].ColumnName = "Week4 Work";
            dt.Columns["drw_status"].ColumnName = "Status";
            dt.Columns["drw_scan"].ColumnName = "Scanner";

            cn.Close();
            return dt;
        }

        public static DataTable GetDoctorCalendars(DateTime startT, DateTime endT, String req, String kid, String ped)
        {
            SqlConnection cn = new SqlConnection(ConnectionStr);
            cn.Open();
            
            SqlCommand command = new SqlCommand(
            "SELECT drc_id,drc_date,drc_time,drc_status,dr_name,drw_period " +
            "FROM DoctorCalendars "+
            "JOIN DoctorWorks ON drw_id=drc_drw "+
            "JOIN Doctors ON dr_Id=drw_dr " +
            "WHERE drc_drw IN (SELECT drw_id FROM DoctorWorks " +
                               "WHERE drw_dr IN (SELECT drreq_dr FROM DoctorRequests " +
                                                "JOIN Requests ON req_Id = drreq_req "+
                                                "WHERE drw_period LIKE '" + ped.Trim() + "%' " +
                                                "AND req_bodypart LIKE '%" + req.Trim() + "%') "+
                               "AND drw_kid LIKE '" + kid.Trim() + "%') " +
             "AND drc_date BETWEEN @StartT AND  @EndT " 
             , cn);

           
            command.Parameters.AddWithValue("@StartT", startT);
            command.Parameters.AddWithValue("@EndT", endT);
            
            SqlDataReader reader = command.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Columns.Add("drc_time", typeof(Int16));
            dt.Columns.Add("drc_date", typeof(String));
            dt.Columns.Add("dr_name", typeof(String));
            dt.Columns.Add("drw_period", typeof(String));
            dt.Columns.Add("drc_id", typeof(Int16));
            dt.Columns.Add("drc_status", typeof(String));
            //dt.Columns.Add("drw_dr", typeof(Int16));
            //dt.Columns.Add("drc_drw", typeof(String));

            dt.Load(reader);

            dt.Columns["drc_time"].ColumnName = "Doctor Used Time";
            dt.Columns["drc_date"].ColumnName = "Date and Time";
            dt.Columns["dr_name"].ColumnName = "Doctor Name";
            dt.Columns["drw_period"].ColumnName = "Doctor Work Period";
            dt.Columns["drc_id"].ColumnName = "Doctor Calendar ID";
            dt.Columns["drc_status"].ColumnName = "Status";

            cn.Close();
            return dt;
        }

        public static void InsertDoctorWorks(String drw_dr, DateTime drw_sdate, DateTime drw_edate, String drw_dow,
            String drw_period, bool drw_kid,bool drw_w1, bool drw_w2, bool drw_w3,bool drw_w4, String drw_status, String drw_scan)
        {
            SqlConnection cn = new SqlConnection(ConnectionStr);

            SqlCommand command = new SqlCommand(
                "INSERT INTO DoctorWorks (drw_dr,drw_sdate,drw_edate,drw_dow,drw_period," +
                "drw_kid,drw_w1,drw_w2,drw_w3,drw_w4,drw_status,drw_scan) " +
                "VALUES (@drw_dr,@drw_sdate,@drw_edate,@drw_dow,@drw_period," +
                "@drw_kid,@drw_w1,@drw_w2,@drw_w3,@drw_w4,@drw_status,@drw_scan )", cn);

            command.Parameters.AddWithValue("@drw_dr", drw_dr.Trim());
            command.Parameters.AddWithValue("@drw_sdate", drw_sdate.Date);
            command.Parameters.AddWithValue("@drw_edate", drw_edate.Date);
            command.Parameters.AddWithValue("@drw_dow", drw_dow.Trim());
            command.Parameters.AddWithValue("@drw_period", drw_period.Trim());
            command.Parameters.AddWithValue("@drw_kid", Convert.ToInt16(drw_kid).ToString().Trim());
            command.Parameters.AddWithValue("@drw_w1", Convert.ToInt16(drw_w1).ToString().Trim());
            command.Parameters.AddWithValue("@drw_w2", Convert.ToInt16(drw_w2).ToString().Trim());
            command.Parameters.AddWithValue("@drw_w3", Convert.ToInt16(drw_w3).ToString().Trim());
            command.Parameters.AddWithValue("@drw_w4", Convert.ToInt16(drw_w4).ToString().Trim());
            command.Parameters.AddWithValue("@drw_status", drw_status.Trim());
            command.Parameters.AddWithValue("@drw_scan", drw_scan.Trim());
            command.Connection = cn;

            cn.Open();
            command.ExecuteNonQuery();
            cn.Close();
        }

        public static void UpDateDoctorWorks(String drw_id, String drw_status)
        {
            SqlConnection cn = new SqlConnection(ConnectionStr);
            SqlCommand command = new SqlCommand(
                "UPDATE DoctorWorks SET drw_status = @drw_status " +
                "WHERE drw_id = @drw_id ", cn);

            command.Parameters.AddWithValue("@drw_id", drw_id.Trim());
            command.Parameters.AddWithValue("@drw_status", drw_status.Trim());

            command.Connection = cn;

            cn.Open();
            command.ExecuteNonQuery();
            cn.Close();
        }

        public static void UpDateDoctorWorks(String drw_id, DateTime drw_sdate, DateTime drw_edate)
        {
            SqlConnection cn = new SqlConnection(ConnectionStr);
            SqlCommand command = new SqlCommand(
                "UPDATE DoctorWorks SET drw_sdate = @drw_sdate, drw_edate = @drw_edate " +
                "WHERE drw_id = @drw_id ", cn);

            command.Parameters.AddWithValue("@drw_id", drw_id.Trim());
            command.Parameters.AddWithValue("@drw_sdate", drw_sdate.ToString().Trim());
            command.Parameters.AddWithValue("@drw_edate", drw_edate.ToString().Trim());

            command.Connection = cn;

            cn.Open();
            command.ExecuteNonQuery();
            cn.Close();
        }

        public static void DropDoctorWorks(String drw_id)
        {
            SqlConnection cn = new SqlConnection(ConnectionStr);
            SqlCommand command = new SqlCommand("DELETE FROM DoctorWorks WHERE drw_id = '" + drw_id.Trim() + "'", cn);
            cn.Open();
            command.ExecuteNonQuery();
            cn.Close();
        }

        public static void InsertDoctorCalendars(DateTime drc_date, String drc_drw, int drc_time, String drc_status)
        {
            SqlConnection cn = new SqlConnection(ConnectionStr);
            SqlCommand command = new SqlCommand(
                "INSERT INTO DoctorCalendars (drc_date,drc_drw,drc_time,drc_status) " +
                "VALUES (@drc_date,@drc_drw,@drc_time,@drc_status)", cn);

            command.Parameters.AddWithValue("@drc_date", drc_date.Date);
            command.Parameters.AddWithValue("@drc_drw", drc_drw.Trim());
            command.Parameters.AddWithValue("@drc_time", drc_time);
            command.Parameters.AddWithValue("@drc_status", drc_status.Trim());

            command.Connection = cn;

            cn.Open();
            command.ExecuteNonQuery();
            cn.Close();
        }

        public static void CreateDoctorCalendarsList(String ped, String dr_id, bool kid, String status, String dow, String scan)
        {
            //Create Doctor Calender
            DataTable dt = SQL.GetDoctorWorks(ped.Trim(), dr_id.Trim(),Convert.ToInt16(kid).ToString().Trim(), status, dow.Trim(),scan.Trim());

            int drw_id = Convert.ToInt16(dt.Rows[0]["drw_id"]);
            DateTime drw_sdate = Convert.ToDateTime(dt.Rows[0]["drw_sdate"].ToString().Trim());
            DateTime drw_edate = Convert.ToDateTime(dt.Rows[0]["drw_edate"].ToString().Trim());
            int drw_w1 = Convert.ToInt16(dt.Rows[0]["drw_w1"]);
            int drw_w2 = Convert.ToInt16(dt.Rows[0]["drw_w2"]);
            int drw_w3 = Convert.ToInt16(dt.Rows[0]["drw_w3"]);
            int drw_w4 = Convert.ToInt16(dt.Rows[0]["drw_w4"]);
            int drw_dow = SQL.getDof(dt.Rows[0]["drw_dow"].ToString().Trim());
            DateTime drc_date = drw_sdate;
            int w = SQL.getDof(drc_date.DayOfWeek.ToString());
            if (drw_dow - w > 0)
                drc_date = drc_date.AddDays(drw_dow - w);
            else
                drc_date = drc_date.AddDays(7 + (drw_dow - w));

            while (drc_date <= drw_edate)
            {
                if (drw_w1 == 1 && drc_date.Day >= 1 && drc_date.Day <= 7)
                {
                    SQL.InsertDoctorCalendars(drc_date, drw_id.ToString().Trim(), 0, "Available");

                }

                if (drw_w2 == 1 && drc_date.Day >= 8 && drc_date.Day <= 14)
                {
                    SQL.InsertDoctorCalendars(drc_date, drw_id.ToString().Trim(), 0, "Available");

                }

                if (drw_w3 == 1 && drc_date.Day >= 15 && drc_date.Day <= 21)
                {
                    SQL.InsertDoctorCalendars(drc_date, drw_id.ToString().Trim(), 0, "Available");

                }

                if (drw_w4 == 1 && drc_date.Day >= 22 && drc_date.Day <= 31)
                {
                    SQL.InsertDoctorCalendars(drc_date, drw_id.ToString().Trim(), 0, "Available");

                }
                drc_date = drc_date.AddDays(7);
            }
            SQL.UpDateDoctorWorks(drw_id.ToString().Trim(), "Active");

        }

        public static void UpdateAddDoctorCalendarsList(String drw_id, String drc_status, DateTime drw_sdate, DateTime drw_edate)
        {
            //Create Doctor Calender
            DataTable dt = SQL.GetDoctorWorks(drw_id.Trim());
            int drw_w1 = Convert.ToInt16(dt.Rows[0]["drw_w1"]);
            int drw_w2 = Convert.ToInt16(dt.Rows[0]["drw_w2"]);
            int drw_w3 = Convert.ToInt16(dt.Rows[0]["drw_w3"]);
            int drw_w4 = Convert.ToInt16(dt.Rows[0]["drw_w4"]);
            int drw_dow = SQL.getDof(dt.Rows[0]["drw_dow"].ToString().Trim());

            DateTime drc_date = drw_sdate;
            int w = SQL.getDof(drc_date.DayOfWeek.ToString());
            if (drw_dow - w > 0)
                drc_date = drc_date.AddDays(drw_dow - w);
            else
                drc_date = drc_date.AddDays(7 + (drw_dow - w));

            while (drc_date <= drw_edate)
            {
                if (drw_w1 == 1 && drc_date.Day >= 1 && drc_date.Day <= 7)
                {
                    SQL.InsertDoctorCalendars(drc_date, drw_id.ToString().Trim(), 0, "Available");

                }

                if (drw_w2 == 1 && drc_date.Day >= 8 && drc_date.Day <= 14)
                {
                    SQL.InsertDoctorCalendars(drc_date, drw_id.ToString().Trim(), 0, "Available");

                }

                if (drw_w3 == 1 && drc_date.Day >= 15 && drc_date.Day <= 21)
                {
                    SQL.InsertDoctorCalendars(drc_date, drw_id.ToString().Trim(), 0, "Available");

                }

                if (drw_w4 == 1 && drc_date.Day >= 22 && drc_date.Day <= 31)
                {
                    SQL.InsertDoctorCalendars(drc_date, drw_id.ToString().Trim(), 0, "Available");

                }
                drc_date = drc_date.AddDays(7);
            }
            SQL.UpDateDoctorWorks(drw_id.ToString().Trim(), "Active");

        }


        public static void UpDateDoctorCalendarsList(String drw_id, String drc_status)
        {
            SqlConnection cn = new SqlConnection(ConnectionStr);
            SqlCommand command = new SqlCommand(
                "UPDATE DoctorCalendars SET drc_status = @drc_status " +
                "WHERE drc_drw = @drw_id ", cn);

            command.Parameters.AddWithValue("@drw_id", drw_id.Trim());
            command.Parameters.AddWithValue("@drc_status", drc_status.Trim());

            command.Connection = cn;

            cn.Open();
            command.ExecuteNonQuery();
            cn.Close();
        }

        
        public static void UpDateDoctorCalendarsList(String drw_id, String drc_status, DateTime drw_sdate, DateTime drw_edate)
        {
            SqlConnection cn = new SqlConnection(ConnectionStr);
            SqlCommand command = new SqlCommand(
                "UPDATE DoctorCalendars SET drc_status = @drc_status " +
                "WHERE drc_drw = @drw_id "+
                "AND drc_date BETWEEN @StartT AND @EndT " 
               , cn);

            command.Parameters.AddWithValue("@drw_id", drw_id.Trim());
            command.Parameters.AddWithValue("@drc_status", drc_status.Trim());
            command.Parameters.AddWithValue("@StartT", drw_sdate.ToString().Trim());
            command.Parameters.AddWithValue("@EndT", drw_edate.ToString().Trim());

            command.Connection = cn;

            cn.Open();
            command.ExecuteNonQuery();
            cn.Close();
        }


        public static void DropDoctorCalendarsList(String drc_drw)
        {
            SqlConnection cn = new SqlConnection(ConnectionStr);
            SqlCommand command = new SqlCommand("DELETE FROM DoctorCalendars WHERE drc_drw = '" + drc_drw.Trim() + "'", cn);
            cn.Open();
            command.ExecuteNonQuery();
            cn.Close();
        }

        public static void UpDateAppointmentsWhenCalendarListWereCanceled(String drc_status,String ap_appstatus)
        {
            SqlConnection cn = new SqlConnection(ConnectionStr);
            SqlCommand command = new SqlCommand(
                "UPDATE Appointments SET ap_appstatus = @ap_appstatus " +
                "WHERE ap_drc IN (SELECT drc_id FROM DoctorCalendars WHERE drc_status LIKE '%"+drc_status+"%' ) "+
                "AND ap_appstatus LIKE '%InQueue%'", cn);

            //command.Parameters.AddWithValue("@drc_status", drc_status.Trim());
            command.Parameters.AddWithValue("@ap_appstatus", ap_appstatus.Trim());

            command.Connection = cn;

            cn.Open();
            command.ExecuteNonQuery();
            cn.Close();
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

        public static int getPeriod(String ped)
        {
            if (ped.Equals("Morning".Trim()))
                return 0;
            else if (ped.Equals("Afternoon".Trim()))
                return 1;
            else
                return 2;
        }

        public static String getIdReq(int pkReq)
        {
            string zero = "";
            if (pkReq < 10)
                zero = "00";
            else
                zero = "0";

            return zero+Convert.ToString(pkReq).Trim();
        }
       
        public static ComboBox readScanner(ComboBox scan_CoBox)
        {
            SqlConnection cn = new SqlConnection(ConnectionStr);
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
            SqlConnection cn = new SqlConnection(ConnectionStr);
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

        public static DataTable suggestionDate(DateTime startT, DateTime endT, String req, String kid, String ped)
        {
            DataTable suggestDate = SQL.GetDoctorCalendars(startT, endT, req.Trim(),
                Convert.ToInt16(kid).ToString().Trim(),
                ped.Trim());
            return suggestDate;
        }

        public static int getTimeReq(String req)
        {
            DataTable dt = SQL.GetRequests(req);
            return Convert.ToInt16(dt.Rows[0]["req_time"]);
        }
    }
}
