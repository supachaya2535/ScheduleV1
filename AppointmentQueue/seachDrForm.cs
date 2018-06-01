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
    public partial class seachDrForm : Form
    {
        int ID = 0;
        bool did_lock = false;
        private string _DrId;
        private string _DrName;
        private string _DrLName;
        public seachDrForm()
        {
            InitializeComponent();
        }

        private DataTable readDoctor(String id, String name, String lname)
        {
            SqlConnection cn = new SqlConnection(global::AppointmentQueue.Properties.Settings.Default.Database1ConnectionString);
            cn.Open();
            SqlCommand command = new SqlCommand("SELECT dr_id,dr_name,dr_lname FROM Doctors WHERE dr_id LIKE '%" + id + "%'" +
                "AND dr_name LIKE '%" + name + "%' AND dr_lname LIKE '%" + lname + "%'", cn);
            SqlDataReader reader = command.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Columns.Add("dr_id", typeof(String));
            dt.Columns.Add("dr_name", typeof(string));
            dt.Columns.Add("dr_lname", typeof(string));
            dt.Load(reader);
            cn.Close();
            return dt;
        }
        private void nametxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
