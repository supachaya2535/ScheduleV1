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
    public partial class DayOffForm : Form
    {
        public DayOffForm()
        {
            InitializeComponent();
        }

        private void addDayOffBtn_Click(object sender, EventArgs e)
        {
            try{
                if (MessageBox.Show("Do you want to insert a new day off?", "Insert new day off", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SqlConnection cn = new SqlConnection(global::AppointmentQueue.Properties.Settings.Default.Database1ConnectionString);
                    SqlCommand command = new SqlCommand(
                        "INSERT INTO DayOffs (df_date,df_dr,df_period,df_detail) " +
                        "VALUE (@df_date,@df_dr,df_period,df_detail)", cn);

                    command.Parameters.AddWithValue("@df_date", dayOffDate.Value.Date);
                    command.Parameters.AddWithValue("@df_dr", Idtxt.Text);
                    command.Parameters.AddWithValue("@df_period", pedCob.SelectedItem.ToString().Trim());
                    command.Parameters.AddWithValue("@df_detail", detailTxt.Text);
                    command.Connection = cn;

                    cn.Open();
                    command.ExecuteNonQuery();
                    cn.Close();
                }

            }
            catch
            {
                MessageBox.Show("Could not insert a new record!!!!");
            }
        }

        private void seachPaBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
