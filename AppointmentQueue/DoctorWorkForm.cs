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
        public DateTime sdate;
        public DateTime edate;
        public DoctorWorkForm()
        {
            InitializeComponent();
            scanComb = SQL.readScanner(scanComb);

            week1CheckBox.Checked = true;
            week2CheckBox.Checked = true;
            week3CheckBox.Checked = true;
            week4CheckBox.Checked = true;
            dofComb.SelectedIndex = 0;
            pedComb.SelectedIndex = 0;
            scanComb.SelectedIndex = 0;

            endDate.Value = DateTime.Today;
            startDate.Value = DateTime.Today;
            endDate.Value = startDate.Value.AddDays(1);
            
            startDateEdit.MaxDate = DateTime.Today.AddYears(5);
            startDateEdit.MinDate = DateTime.Today.AddYears(-5);
            endDateEdit.MaxDate = DateTime.Today.AddYears(5);
            endDateEdit.MaxDate = DateTime.Today.AddYears(5);
        }

        private void seachDrWork_Click(object sender, EventArgs e)
        {
            DataTable dt = SQL.GetDoctorWorks("", drIdTxt.Text.Trim(),"","","");
            drWorkGidView.DataSource = dt;
        }
        
        private void drWorkAddBtn_Click(object sender, EventArgs e)
        {
            DataTable dt = SQL.GetDoctorWorks(pedComb.SelectedItem.ToString().Trim(),
                drIdTxt.Text.Trim(),
                Convert.ToInt16(kidCheckBox.Checked).ToString().Trim(),"Active",
                dofComb.SelectedItem.ToString().Trim(),
                scanComb.SelectedItem.ToString().Trim());

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
                DateTime sdate = Convert.ToDateTime(dt.Rows[0]["drw_sdate"].ToString().Trim());
                DateTime edate = Convert.ToDateTime(dt.Rows[0]["drw_edate"].ToString().Trim());
                ///Check overappling date
                if (startDate.Value < edate)
                {
                    MessageBox.Show("This date range of work overlap another date of work that already exists by the same doctor in the same period\n" +
                        "Suggestion!!!"+
                        "1.Edit the range of old work \n"+
                        "2.Insert the new range of work");
  
                }
                if (MessageBox.Show("This doctor work already exists in overlapping date, Do you want to replace a new doctor work in the difference time ?", "Replace a new doctor work time", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                   
                    SQL.UpDateDoctorWorks(drWorkId.Text.Trim(),"Inactive");

                    SQL.UpDateDoctorCalendarsList(drWorkId.Text.Trim(), "Canceled");

                    SQL.UpDateAppointmentsWhenCalendarListWereCanceled("Canceled", "Waiting");
                    MessageBox.Show("All related calender records were calcled!."+
                        " It will effect to change status 'InQueue' of some appointment records become 'Waiting'"+
                        "(Waiting for you change the appointment date");
                    
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
            DataTable dt = SQL.GetDoctorWorks(drWorkId.Text.Trim());
            if(dt.Rows[0]["drw_status"].ToString().Trim() == "Active")
            {
                //Delete Calendar list
                if (MessageBox.Show("This Doctor work record is \"Active\". Deleting this record will effect to some Appointment records ." +
                    "\nDo you want to delete this record?", "Detete this record", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SQL.UpDateDoctorWorks(drWorkId.Text.Trim(), "Inactive");

                    MessageBox.Show("Change stautus of this record to be \"Inactive\" is successful");

                    SQL.UpDateDoctorCalendarsList(drWorkId.Text.Trim(), "Canceled");
                   
                    SQL.UpDateAppointmentsWhenCalendarListWereCanceled("Canceled", "Waiting");

                    MessageBox.Show("All related calender records were calceled!." +
                       " It will effect to change status 'InQueue' of some appointment records become 'Waiting'" +
                       "(Waiting for you change the appointment date");
                }

            }
            else
            {
                if (MessageBox.Show("Do you want to delete this record?", "Detete this record", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SQL.UpDateDoctorWorks(drWorkId.Text.Trim(), "Inactive");
                    seachDrWork_Click(sender, e);
                    MessageBox.Show("Change stautus of this record to be \"Inactive\" is successful");
                }

            }
        }

        private void startDate_ValueChanged(object sender, EventArgs e)
        {
            if (startDate.Value < DateTime.Today)
            {
                MessageBox.Show("Can not assign The Date in past");
               startDate.Value = DateTime.Today;
            }
            else if (endDate.Value < startDate.Value)
            {
                MessageBox.Show("StartDate can not be greater than EndDate");
                endDate.Value = startDate.Value;
            }
            
        }

        private void endDate_ValueChanged(object sender, EventArgs e)
        {
            if (endDate.Value < startDate.Value)
            {
                MessageBox.Show("EndDate can not be lesser than StartDate");
                endDate.Value = startDate.Value;
            }
        }

        private void drWorkGidView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int ID = drWorkGidView.CurrentCell.RowIndex;
            drWorkId.Text = drWorkGidView.Rows[ID].Cells[0].Value.ToString().Trim();
            drWorkDeleteBtn.Enabled = true;

            sdate = Convert.ToDateTime(drWorkGidView.Rows[ID].Cells["drw_sdate"].Value.ToString().Trim());
            edate = Convert.ToDateTime(drWorkGidView.Rows[ID].Cells["drw_edate"].Value.ToString().Trim());

            startDateEdit.Value = Convert.ToDateTime(drWorkGidView.Rows[ID].Cells["drw_sdate"].Value.ToString().Trim());
            endDateEdit.Value = Convert.ToDateTime(drWorkGidView.Rows[ID].Cells["drw_edate"].Value.ToString().Trim());
            
            drWorkSaveBtn.Enabled = true;
        }

        private void drWorkSaveBtn_Click(object sender, EventArgs e)
        {
            DataTable dt = SQL.GetDoctorWorks(drWorkId.Text.Trim());
            String drw_id = dt.Rows[0]["drw_id"].ToString().Trim();
            DateTime sdate = Convert.ToDateTime(dt.Rows[0]["drw_sdate"].ToString().Trim());
            DateTime edate = Convert.ToDateTime(dt.Rows[0]["drw_edate"].ToString().Trim());

            if (dt.Rows[0]["drw_status"].ToString().Trim() == "Active")
            {
                //Delete Calendar list
                if (MessageBox.Show("Do you want to change this date range?", "Change this record", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SQL.UpDateDoctorWorks(drWorkId.Text.Trim(), startDateEdit.Value, endDateEdit.Value);
                    seachDrWork_Click(sender, e);
                    MessageBox.Show("Update the record successful");

                    //1.
                    if(startDateEdit.Value < sdate)
                    {//Insert more
                        SQL.UpdateAddDoctorCalendarsList(drw_id, "Available", sdate, startDateEdit.Value.AddDays(-1));
                    }
                    else if(startDateEdit.Value > sdate)
                    {//Cancle 
                        SQL.UpDateDoctorCalendarsList(drw_id, "Canceled", startDateEdit.Value, endDateEdit.Value);
                    }

                    if(endDateEdit.Value > edate)
                    {//Insert more
                        SQL.UpdateAddDoctorCalendarsList(drw_id, "Available", edate.AddDays(1), endDateEdit.Value);
                    }
                    else if(endDateEdit.Value < edate)
                    {//Cancle 
                        SQL.UpDateDoctorCalendarsList(drw_id, "Canceled", endDateEdit.Value.AddDays(-1), edate);
                    }
                    
                    SQL.UpDateAppointmentsWhenCalendarListWereCanceled("Canceled", "Waiting");

                    MessageBox.Show("All related calender records were calceled!." +
                       " It will effect to change status 'InQueue' of some appointment records become 'Waiting'" +
                       "(Waiting for you change the appointment date");

                }

            }
            else
            {
                MessageBox.Show("This record is InActive, You can't do anything with this record");
             
            }
        }

        private void startDateEdit_ValueChanged(object sender, EventArgs e)
        {
            if(sdate < DateTime.Today)
            {
                if (startDateEdit.Value > endDateEdit.Value)
                {
                    MessageBox.Show("StartDate can not be greater than EndDate");
                    startDateEdit.Value = sdate;
                }
            }
            else
            {
                if (startDateEdit.Value < DateTime.Today)
                {
                    MessageBox.Show("Can not assign The Date in past");
                    startDateEdit.Value = DateTime.Today;
                }
                else if (startDateEdit.Value > endDateEdit.Value)
                {
                    MessageBox.Show("StartDate can not be greater than EndDate");
                    startDateEdit.Value = sdate;
                }
            }

        }

        private void endDateEdit_ValueChanged(object sender, EventArgs e)
        {
            if (sdate < DateTime.Today)
            {
                if (endDateEdit.Value < startDateEdit.Value)
                {
                    MessageBox.Show("StartDate can not be greater than EndDate");
                    endDateEdit.Value = startDateEdit.Value;
                }
            }
            else
            {
                if (endDateEdit.Value < DateTime.Today)
                {
                    MessageBox.Show("Can not assign The Date in past");
                    endDate.Value = DateTime.Today;
                }
                else if (endDateEdit.Value < startDateEdit.Value)
                {
                    MessageBox.Show("EndDate can not be lesser than EndDate");
                    endDateEdit.Value = startDateEdit.Value;
                }
            }
            
        }
    }
}
