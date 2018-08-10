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
    public partial class DoctorWorkForm : Form
    {
        public DoctorWorkForm()
        {
            InitializeComponent();
            week1CheckBox.Checked = true;
            week2CheckBox.Checked = true;
            week3CheckBox.Checked = true;
            week4CheckBox.Checked = true;
            dofComb.SelectedIndex = 0;
            pedComb.SelectedIndex = 0;
            startDate.Value = DateTime.Today;
            endDate.Value = startDate.Value.AddDays(1);

        }
        private void seachDrWork_Click(object sender, EventArgs e)
        {
            DataTable dt = SQL.GetDoctorWorks("", drIdTxt.Text.Trim(),"","","");
            drWorkGidView.DataSource = dt;
        }
        
        private void drWorkAddBtn_Click(object sender, EventArgs e)
        {
            DataTable dt = SQL.GetDoctorWorks(pedComb.SelectedItem.ToString().Trim(), drIdTxt.Text.Trim(),
                Convert.ToInt16(kidCheckBox.Checked).ToString().Trim(),"Active",
                dofComb.SelectedItem.ToString().Trim());
            int numrow = Convert.ToInt16(dt.Rows.Count);
            if(numrow==0)
            {
                if (MessageBox.Show("Do you want to insert a new doctor work?", "Insert a new doctor work", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SQL.InsertDoctorWorks(drIdTxt.Text.Trim(),
                        startDate.Value,
                        endDate.Value,
                        dofComb.SelectedItem.ToString().Trim(),
                        pedComb.SelectedItem.ToString().Trim(),
                        kidCheckBox.Checked,
                        week1CheckBox.Checked,
                        week2CheckBox.Checked,
                        week3CheckBox.Checked,
                        week4CheckBox.Checked,
                        "Waiting");

                    
                    //Create Doctor Calender
                    SQL.CreateDoctorCalendarsList(pedComb.SelectedItem.ToString().Trim(), drIdTxt.Text.Trim(),
                        kidCheckBox.Checked, "Waiting", dofComb.SelectedItem.ToString().Trim());

                    seachDrWork_Click(sender, e);

                }

            }
            else
            {
                 drWorkId.Text = dt.Rows[0][0].ToString().Trim();

                if (MessageBox.Show("this doctor work already exists, Do you want to replace a new doctor work in the difference time ?", "Replace a new doctor work time", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SQL.UpDateDoctorWorks(drWorkId.Text.Trim(),"Inactive");

                    SQL.InsertDoctorWorks(drIdTxt.Text.Trim(),
                        startDate.Value,
                        endDate.Value,
                        dofComb.SelectedItem.ToString().Trim(),
                        pedComb.SelectedItem.ToString().Trim(),
                        kidCheckBox.Checked,
                        week1CheckBox.Checked,
                        week2CheckBox.Checked,
                        week3CheckBox.Checked,
                        week4CheckBox.Checked,
                        "Waiting");

                    

                    //Create Doctor Calender
                    SQL.CreateDoctorCalendarsList(pedComb.SelectedItem.ToString().Trim(), drIdTxt.Text.Trim(),
                        kidCheckBox.Checked, "Waiting", dofComb.SelectedItem.ToString().Trim());

                    seachDrWork_Click(sender, e);
                }

            }
        }
    
        private void button1_Click(object sender, EventArgs e)
        {
            DoctorForm sForm = new DoctorForm();
            sForm.exist = false;
            sForm.ShowDialog();
            if ((sForm.exist == true))
            {
                this.drIdTxt.Text = Convert.ToString(sForm.drId).Trim();
                this.drNameTxt2.Text = sForm.drName.ToString().Trim();
                this.drLnameTxt2.Text = sForm.drLname.ToString().Trim();
                seachDrWork_Click(sender, e);
                drWorkAddBtn.Enabled = true;
            }

        }

        private void drWorkDeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to delete this record?", "Detete this record", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SqlConnection cn = new SqlConnection(global::AppointmentQueue.Properties.Settings.Default.Database1ConnectionString);
                    SqlCommand command = new SqlCommand("DELETE FROM DoctorWorks WHERE drw_Id = '" + drWorkId.Text.Trim() + "'", cn);
                    command.Connection = cn;

                    cn.Open();
                    command.ExecuteNonQuery();
                    cn.Close();
                    seachDrWork_Click(sender, e);
                }
            }
            catch (SystemException ex)
            {
                MessageBox.Show(string.Format("Couldn't insert a new record : An error occurred: {0}", ex.Message));
            }
        }

        private void startDate_ValueChanged(object sender, EventArgs e)
        {
            if (endDate.Value < startDate.Value)
            {
                MessageBox.Show("StartDate can not be greater than EndDate");
                endDate.Value = startDate.Value.AddDays(1);
            }
            
        }

        private void endDate_ValueChanged(object sender, EventArgs e)
        {
            if (endDate.Value < startDate.Value)
            {
                MessageBox.Show("EndDate can not be lesser than StartDate");
                endDate.Value = startDate.Value.AddDays(1);
            }
        }

        private void drWorkGidView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int ID = drWorkGidView.CurrentCell.RowIndex;
            drWorkId.Text = drWorkGidView.Rows[ID].Cells[0].Value.ToString().Trim();
            drWorkDeleteBtn.Enabled = true;
        }
    }
}
