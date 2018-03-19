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
    public partial class seachPaForm : Form
    {
        //SqlConnection cn = new SqlConnection(global::AppointmentQueue.Properties.Settings.Default.Database1ConnectionString);
        //SqlCommand command;
        //SqlDataAdapter adapt;
        int ID = 0;
        bool did_lock = false;
        private string _HNpatient;
        private string _PatName;
        private string _PatLName;
        private string _PatBD;
        public seachPaForm()
        {
            InitializeComponent();
        }

        private void seachPaForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Patients' table. You can move, or remove it, as needed.
            this.patientsTableAdapter.Fill(this.database1DataSet.Patients);

        }
        public string HNpatient
        {
            get { return _HNpatient; }
            set { _HNpatient = value; }
        }
        public string PatName
        {
            get { return _PatName; }
            set { _PatName = value; }
        }
        public string PatLName
        {
            get { return _PatLName; }
            set { _PatLName = value; }
        }
        public string PatBD
        {
            get { return _PatBD; }
            set { _PatBD = value; }
        }
    

    private DataTable readPatient(String id, String name, String lname)
        {
            SqlConnection cn = new SqlConnection(global::AppointmentQueue.Properties.Settings.Default.Database1ConnectionString);
            cn.Open();
            SqlCommand command = new SqlCommand("SELECT pa_id,pa_name,pa_lname,pa_birthday FROM Patients WHERE pa_id LIKE '%" + id + "%'" +
                "AND pa_name LIKE '%" + name + "%' AND pa_lname LIKE '%" + lname + "%'", cn);
            SqlDataReader reader = command.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Columns.Add("pa_id", typeof(String));
            dt.Columns.Add("pa_name", typeof(string));
            dt.Columns.Add("pa_lname", typeof(string));
            dt.Columns.Add("pa_birthday", typeof(string));
            dt.Load(reader);
            cn.Close();
            return dt;
        }
        private void HNtxt_TextChanged(object sender, EventArgs e)
        {
            if (!did_lock)
            {
                DataTable dt = readPatient(HNtxt.Text, nametxt.Text, lnametxt.Text);
                patGridView.DataSource = dt;
                acceptBtn.Enabled = false;
            }
        }

        private void lnametxt_TextChanged(object sender, EventArgs e)
        {
            if (!did_lock)
            {
                DataTable dt = readPatient(HNtxt.Text, nametxt.Text, lnametxt.Text);
                patGridView.DataSource = dt;
                acceptBtn.Enabled = false;
            }
        }

        private void HNtxt_TextChanged_1(object sender, EventArgs e)
        {
            if (!did_lock) {
                DataTable dt = readPatient(HNtxt.Text, nametxt.Text, lnametxt.Text);
                patGridView.DataSource = dt;
                acceptBtn.Enabled = false;
            }
        }

        private void patGridView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            acceptBtn.Enabled = true;
            did_lock = true;
            ID = patGridView.CurrentRow.Index;
            HNtxt.Text = patGridView.Rows[ID].Cells[0].Value.ToString();
            nametxt.Text = patGridView.Rows[ID].Cells[1].Value.ToString();
            lnametxt.Text = patGridView.Rows[ID].Cells[2].Value.ToString();
            this.HNpatient = HNtxt.Text;
            this.PatName = nametxt.Text;
            this.PatLName = lnametxt.Text;
            this.PatBD = patGridView.Rows[ID].Cells[3].Value.ToString();
        did_lock = false;
        }

        private void acceptBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
