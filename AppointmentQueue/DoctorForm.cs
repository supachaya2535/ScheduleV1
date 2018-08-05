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
    public partial class DoctorForm : Form
    {
        public DoctorForm()
        {
            InitializeComponent();
        }
        
        private void drDataGridView_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int ID = drDataGridView.CurrentCell.RowIndex;
            Idtxt.Text = drDataGridView.Rows[ID].Cells[0].Value.ToString().Trim();
            drNameTxt.Text = drDataGridView.Rows[ID].Cells[1].Value.ToString().Trim();
            drLnameTxt.Text = drDataGridView.Rows[ID].Cells[2].Value.ToString().Trim();
            
        }

        private void drSeachBtn_Click(object sender, EventArgs e)
        {
            DataTable dt = SQL.GetDoctors(drNameTxt.Text, drLnameTxt.Text);
            drDataGridView.DataSource = dt;
        }

        private void drInsertBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to insert a new day off?", "Insert new day off", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SqlConnection cn = new SqlConnection(global::AppointmentQueue.Properties.Settings.Default.Database1ConnectionString);
                    SqlCommand command = new SqlCommand(
                        "INSERT INTO Doctors (dr_name,dr_lname) " +
                        "VALUES (@dr_name,@dr_lname)", cn);

                    command.Parameters.AddWithValue("@dr_name", drNameTxt.Text.Trim());
                    command.Parameters.AddWithValue("@dr_lname", drLnameTxt.Text.Trim());
                    command.Connection = cn;

                    cn.Open();
                    command.ExecuteNonQuery();
                    cn.Close();

                    drSeachBtn_Click(sender, e);
                }

            }
            catch (SystemException ex)
            {
                MessageBox.Show(string.Format("Couldn't insert a new record : An error occurred: {0}", ex.Message));
            }
        }
    }
}
