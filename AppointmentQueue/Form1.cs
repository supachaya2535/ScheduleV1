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
        SqlConnection cn = new SqlConnection(global::AppointmentQueue.Properties.Settings.Default.Database1ConnectionString);
        int ID = -1;
        public Form1()
        {
            InitializeComponent();
            readScanner();
            readRequest();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.todayDatePicker.Value = DateTime.Now;
            // TODO: This line of code loads data into the 'database1DataSet.Appointments' table. You can move, or remove it, as needed.
            this.appointmentsTableAdapter.Fill(this.database1DataSet.Appointments);

            DataTable dt2 = readAppointmentToday();
            dataGridView2.DataSource = dt2;

        }
        private void ClearData()
        {
            HNtxt.Text = "";
            reqCob.Text = "";
            paidCob.Text = "";
            insuCob.Text = "";
            statusCob.Text = "";
            nameTxt.Text = "";
            lnameTxt.Text = "";
            ageTxt.Text = "";
            ID = 0;
        }
        private int getAge(DateTime birthDate)
        {
            DateTime n = DateTime.Now; // To avoid a race condition around midnight
            int age = n.Year - birthDate.Year;

            if (n.Month < birthDate.Month || (n.Month == birthDate.Month && n.Day < birthDate.Day))
                age--;

            return age;
        }
        private void UpdatePiority(DateTime theday, int newPio)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Appointments SET ap_piority = ap_piority+1 WHERE ap_piority>=@NewPio " +
                "AND ap_startT=@TheDay", cn);

            cmd.Parameters.AddWithValue("@TheDay", theday);
            cmd.Parameters.AddWithValue("@NewPio", newPio);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Updated Successfully");
            cn.Close();

        }
        private void dataGridView2_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = dataGridView2.CurrentRow.Index;
            HNtxt.Text = dataGridView2.Rows[ID].Cells[4].Value.ToString();
            reqCob.SelectedIndex = Convert.ToInt32(dataGridView2.Rows[ID].Cells[5].Value.ToString()) + 1;
            paidCob.SelectedIndex = Convert.ToInt32(dataGridView2.Rows[ID].Cells[6].Value.ToString()) + 1;
            statusCob.SelectedIndex = Convert.ToInt32(dataGridView2.Rows[ID].Cells[8].Value.ToString()) + 1;
            insuCob.SelectedIndex = Convert.ToInt32(dataGridView2.Rows[ID].Cells[9].Value.ToString()) + 1;
            scan_CoBox.SelectedIndex = Convert.ToInt32(dataGridView2.Rows[ID].Cells[10].Value.ToString()) + 1;

        }
        private DateTime calDurationTimePiority()
        {
            DateTime dura = new DateTime();

            return dura;
        }
        private void readScanner()
        {
            Console.WriteLine("---Scanner---");
            SqlConnection cn = new SqlConnection(global::AppointmentQueue.Properties.Settings.Default.Database1ConnectionString);
            cn.Open();
            SqlCommand command = new SqlCommand("SELECT scan_id,scan_name FROM Scanners", cn);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
                scan_CoBox.Items.Add(reader[1].ToString());
            for (int i = 0; i < scan_CoBox.Items.Count; i++)
            {
                Console.WriteLine(scan_CoBox.Items[i]);
            }
            cn.Close();
        }
        private void readRequest()
        {
            Console.WriteLine("---Request---");
            //SqlConnection cn = new SqlConnection(global::AppointmentQueue.Properties.Settings.Default.Database1ConnectionString);
            cn.Open();
            SqlCommand command = new SqlCommand("SELECT req_id,req_scan,req_bodypart FROM Requests WHERE [req_scan] =" + "1", cn);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
                reqCob.Items.Add(reader[2].ToString());
            for (int i = 0; i < reqCob.Items.Count; i++)
            {
                Console.WriteLine(reqCob.Items[i]);
            }
            cn.Close();
        }
        private DataTable readAppointmentToday()
        {
            //SqlConnection cn = new SqlConnection(global::AppointmentQueue.Properties.Settings.Default.Database1ConnectionString);
            cn.Open();
            DateTime startT = todayDatePicker.Value.Date;
            DateTime endT = startT.Date.AddDays(1).AddTicks(-1);
            SqlCommand command = new SqlCommand("SELECT ap_id,ap_piority,ap_startT,ap_duraT,ap_patient,ap_request,ap_paid," +
                "ap_patientstatus,ap_insu,ap_scan,ap_scannum FROM Appointments WHERE ap_startT >= @StartT AND ap_startT < @EndT ORDER BY ap_piority", cn);
            command.Parameters.AddWithValue("@StartT", startT);
            command.Parameters.AddWithValue("@EndT", endT);
            SqlDataReader reader = command.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Columns.Add("ap_id", typeof(Int16));
            dt.Columns.Add("ap_piority", typeof(Int16));
            dt.Columns.Add("ap_startT", typeof(string));
            dt.Columns.Add("ap_duraT", typeof(string));
            dt.Columns.Add("ap_patient", typeof(string));
            dt.Columns.Add("ap_request", typeof(Int16));
            dt.Columns.Add("ap_paid", typeof(Int16));
            dt.Columns.Add("ap_patientstatus", typeof(Int16));
            dt.Columns.Add("ap_insu", typeof(Int16));
            dt.Columns.Add("ap_scan", typeof(Int16));
            dt.Columns.Add("ap_scannum", typeof(Int16));
            dt.Load(reader);

            cn.Close();
            return dt;

        }
        private DataTable readAppointment()
        {
            //SqlConnection cn = new SqlConnection(global::AppointmentQueue.Properties.Settings.Default.Database1ConnectionString);
            cn.Open();
            SqlCommand command = new SqlCommand("SELECT ap_piority,ap_startT,ap_duraT,ap_patient,ap_request,ap_paid," +
                "ap_patientstatus,ap_insu,ap_scan,ap_scannum FROM Appointments", cn);
            SqlDataReader reader = command.ExecuteReader();

            Console.WriteLine(reader[0]);

            DataTable dt = new DataTable();
            dt.Columns.Add("ap_piority", typeof(Int16));
            dt.Columns.Add("ap_startT", typeof(string));
            dt.Columns.Add("ap_duraT", typeof(string));
            dt.Columns.Add("ap_patient", typeof(string));
            dt.Columns.Add("ap_request", typeof(Int16));
            dt.Columns.Add("ap_paid", typeof(Int16));
            dt.Columns.Add("ap_patientstatus", typeof(Int16));
            dt.Columns.Add("ap_insu", typeof(Int16));
            dt.Columns.Add("ap_scan", typeof(Int16));
            dt.Columns.Add("ap_scannum", typeof(Int16));
            dt.Load(reader);

            cn.Close();
            return dt;
        }
        private void addBtn_Click(object sender, EventArgs e)
        {
            //SqlConnection cn = new SqlConnection(global::AppointmentQueue.Properties.Settings.Default.Database1ConnectionString);
            try
            {
                string sql = "INSERT INTO Appointments (ap_piority,ap_startT,ap_duraT,ap_patient,ap_request,ap_paid,ap_patientstatus,ap_insu,ap_scan,ap_scannum) " +
                    "VALUES(@ap_piority,@ap_startT,@ap_duraT,@ap_patient,@ap_request,@ap_paid,@ap_patientstatus,@ap_insu,@ap_scan,@ap_scannum)";
                SqlCommand exeSql = new SqlCommand(sql, cn);

                int scannum = 1;
                //DataTable dt = readAppointment();
                DataTable dt2 = readAppointmentToday();
                Appointment app = new Appointment(todayDatePicker.Value.Date, HNtxt.Text, reqCob.Text, paidCob.Text, birthDatePicker.Value.Date, statusCob.Text, insuCob.Text, scan_CoBox.Text, scannum, dt2);
                UpdatePiority(app.startT, app.piority);
                exeSql.Parameters.AddWithValue("@ap_piority", app.piority);
                exeSql.Parameters.AddWithValue("@ap_startT", app.startT);
                exeSql.Parameters.AddWithValue("@ap_duraT", app.duraT);
                exeSql.Parameters.AddWithValue("@ap_patient", app.patientHN);
                exeSql.Parameters.AddWithValue("@ap_request", app.requestScan);
                exeSql.Parameters.AddWithValue("@ap_paid", app.paid);
                exeSql.Parameters.AddWithValue("@ap_patientstatus", app.patientstatus);
                exeSql.Parameters.AddWithValue("@ap_insu", app.patientinsu);
                exeSql.Parameters.AddWithValue("@ap_scan", app.scan);
                exeSql.Parameters.AddWithValue("@ap_scannum", app.scannum);
                cn.Open();
                exeSql.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Add New Appointment Done!!", "Messeg", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.appointmentsTableAdapter.Fill(this.database1DataSet.Appointments);

                dt2 = readAppointmentToday();
                dataGridView2.DataSource = dt2;

                ClearData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cn.Close();
            }
        }
        private void scan_CoBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            reqCob.Enabled = true;
            addBtn.Enabled = true;
        }
        private void todayDatePicker_ValueChanged(object sender, EventArgs e)
        {
            DataTable dt2 = readAppointmentToday();
            dataGridView2.DataSource = dt2;
        }
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (ID > -1)
            {
                if (MessageBox.Show("Do you want to delete this record?", "Warning", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        //SqlConnection cn = new SqlConnection(global::AppointmentQueue.Properties.Settings.Default.Database1ConnectionString);
                        cn.Open();
                        string id = dataGridView2.Rows[ID].Cells[0].Value.ToString();
                        string sql = "DELETE FROM Appointments WHERE ap_id=" + id + "";

                        SqlCommand delcmd = new SqlCommand(sql, cn);
                        delcmd.Connection = cn;
                        int x = delcmd.ExecuteNonQuery();
                        cn.Close();
                        this.appointmentsTableAdapter.Fill(this.database1DataSet.Appointments);

                        DataTable dt2 = readAppointmentToday();
                        dataGridView2.DataSource = dt2;
                        ClearData();

                        if (x != 0)
                        {
                            MessageBox.Show("Deleted succesfully");
                        }
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }
        }
        private void editBtn_Click(object sender, EventArgs e)
        {
            if (ID > -1)
            {
                if (MessageBox.Show("Do you want to update this record?", "Warning", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {

                        ClearData();

                    }
                    catch
                    {

                    }
                }
            }
            else
            {
                MessageBox.Show("Please Select Record to Update");
            }
        }
        private void seachPaBtn_Click(object sender, EventArgs e)
        {
            seachPaForm sForm = new seachPaForm();
            sForm.ShowDialog();
            this.HNtxt.Text = sForm.HNpatient;
            this.nameTxt.Text = sForm.PatName;
            this.lnameTxt.Text = sForm.PatLName;
            this.birthDatePicker.Value = Convert.ToDateTime(sForm.PatBD);
            this.ageTxt.Text = Convert.ToString(getAge(this.birthDatePicker.Value.Date));
        }

        private void Search_request_info_btn_Click(object sender, EventArgs e)
        {
            if (reqCob.Items != null && scan_CoBox.Items != null)
            {
                Search_Request_Information_From sFrom = new Search_Request_Information_From();
                //this.todayDatePicker.Value = DateTime.Now;
                sFrom.SetStartTime(this.todayDatePicker.Value);
                sFrom.SetScanner(Appointment.getScanner(scan_CoBox.Items.ToString()));
                sFrom.SetRequest(Appointment.getRequest(reqCob.Items.ToString()));
                sFrom.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please insert your request and scanner you want");
            }
        }

        private void edit_cond_req_btn_Click(object sender, EventArgs e)
        {

        }

        private void edit_requests_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
