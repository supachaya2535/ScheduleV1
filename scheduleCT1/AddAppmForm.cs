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

namespace scheduleCT1
{
    public partial class AddAppmForm : Form
    {
        public AddAppmForm()
        {
            InitializeComponent();
        }

        private void AddAppmForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appointmentDatabaseDataSet.Appointments' table. You can move, or remove it, as needed.
            this.appointmentsTableAdapter.Fill(this.appointmentDatabaseDataSet.Appointments);

        }

        private void ApmSaveBtn_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(global::scheduleCT1.Properties.Settings.Default.AppointmentDatabaseConnectionString);
            try
            {
                string sql = "INSERT INTO Appointments (Apm_date,Apm_scanner,Apm_patient,Apm_organ,Apm_doctor) values('" 
                    + dateApm.Value + "','"+ txtScan.Text + "','" + txtPatient.Text + "','"
                    + txtOrgan.Text + "','" + txtDoctor.Text + "')";
                SqlCommand exeSql = new SqlCommand(sql, cn);
                cn.Open();
                exeSql.ExecuteNonQuery();

                MessageBox.Show("Add New Appointment Done!!","Messeg", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.appointmentsTableAdapter.Fill(this.appointmentDatabaseDataSet.Appointments);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
