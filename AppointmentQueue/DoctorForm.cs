using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
 
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace AppointmentQueue
{
    public partial class DoctorForm : Form
    {
        public static String ConnectionStr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + Environment.CurrentDirectory.Split(new string[] { "bin" }, StringSplitOptions.None)[0] + "Database1.mdf;Integrated Security=True";

        public int drId;
        public String drName;
        public String drLname;
        public bool exist = false;

        public DoctorForm()
        {
            InitializeComponent();
        }
        public DoctorForm(bool insert,bool delete)
        {
            InitializeComponent();
            this.drInsertBtn.Visible = insert;
            this.drDelBtn.Visible = delete;
        }

        private void drInsertBtn_Click(object sender, EventArgs e)
        {
            DataTable dt = SQL.GetDoctors(drNameTxt.Text.Trim(), drLnameTxt.Text.Trim());
            int numrow = Convert.ToInt16(dt.Rows.Count);
            if (drNameTxt.Text.Trim() !="" && drLnameTxt.Text.Trim() != ""&& numrow == 0)
            {
                if (MessageBox.Show("Do you want to insert a new doctor?", "Insert new doctor Success", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SqlConnection cn = new SqlConnection(ConnectionStr);
                    SqlCommand command = new SqlCommand(
                        "INSERT INTO Doctors (dr_name,dr_lname) " +
                        "VALUES (@dr_name,@dr_lname)", cn);

                    command.Parameters.AddWithValue("@dr_name", drNameTxt.Text.Trim());
                    command.Parameters.AddWithValue("@dr_lname", drLnameTxt.Text.Trim());
                    command.Connection = cn;

                    cn.Open();
                    command.ExecuteNonQuery();
                    cn.Close();

                    drNameTxt_TextChanged(sender, e);
                }

            }
            else 
            {
                if(numrow>0)
                    MessageBox.Show("Couldn't insert a new record : this record already exists ");
                else
                    MessageBox.Show("Couldn't insert a new record : Dr.Name or Last Name can not be empty");
                
            }
        }

        private void drDelBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to delete this record?", "Detete this record", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SqlConnection cn = new SqlConnection(ConnectionStr);
                    SqlCommand command = new SqlCommand("DELETE FROM Doctors WHERE dr_Id = '" + drId + "'", cn);
                    command.Connection = cn;

                    cn.Open();
                    command.ExecuteNonQuery();
                    cn.Close();

                    drNameTxt_TextChanged(sender, e);
                }

            }
            catch (SystemException ex)
            {
                MessageBox.Show(string.Format("Couldn't insert a new record : An error occurred: {0}", ex.Message));
            }
        }

        private void acceptBtn_Click(object sender, EventArgs e)
        {
            exist = true;
            Close();
        }

        private void drNameTxt_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = SQL.GetDoctors(drNameTxt.Text, drLnameTxt.Text);
            drDataGridView.DataSource = dt;
            SQL.ChangeHeaderText(dt, drDataGridView);
        }

        private void drLnameTxt_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = SQL.GetDoctors(drNameTxt.Text, drLnameTxt.Text);
            drDataGridView.DataSource = dt;
            SQL.ChangeHeaderText(dt, drDataGridView);
        }

        private void drDataGridView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int ID = drDataGridView.CurrentCell.RowIndex;
            drId = Convert.ToInt16(drDataGridView.Rows[ID].Cells[0].Value.ToString().Trim());
            drName = drDataGridView.Rows[ID].Cells[1].Value.ToString().Trim();
            drLname = drDataGridView.Rows[ID].Cells[2].Value.ToString().Trim();

            Idtxt.Text = drId.ToString().Trim();
            drNameTxt.Text = drName;
            drLnameTxt.Text = drLname;

            acceptBtn.Enabled = true;
            drDelBtn.Enabled = true;
        }
    }
}
