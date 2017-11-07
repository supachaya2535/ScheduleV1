using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace scheduleCT1
{
    
    public partial class MainForm : Form
    {
        #region Private Members

        List<Calendar.Appointment> _appointments;
        private int[] _overlappedAppointments = new int[] { 600, 600, 660, 720, 720, 720,
            810, 810, 840, 840, 870, 960, 960, 960 };
        private int[] _overlapDurations = new int[] { 120, 120, 120, 105, 60, 60, 45, 45,
            135, 135, 120, 120, 120, 120 };
        private int _daysToView = 5;

        #endregion
        #region Constructors
        public MainForm()
        {
            _appointments = new List<Calendar.Appointment>();
            InitializeComponent();
      
            dayView1.ViewType = Calendar.DayView.DayViewType.SingleView;

            //select all people
            for (int i = 0; i < lstTypeOfScan.Items.Count; i++)
                lstTypeOfScan.SetItemChecked(i, true);

           
            CreateRandomAppointments();

            ForceRefresh();
            UpdateUI();


        }
        #endregion Constructors

        #region Private Methods
        private void ForceRefresh()
        {
            UpdateUI();
            dayView1.StartDate = monthCalendar1.SelectionStart;
            dayView1.Refresh();
        }
        private void ForceRefresh2()
        {
            UpdateUI();
            dayView1.StartDate = monthCalendar2.SelectionStart;
            dayView1.Refresh();
        }

        private void UpdateUI()
        {
            toolStripButtonTeamView.Checked = dayView1.ViewType == Calendar.DayView.DayViewType.TeamView;
            toolStripButtonDayView.Checked = !toolStripButtonTeamView.Checked;
            dayView1.Focus();
        }

        private void CreateAppointments()
        {
            //allday appointments
            for (int i = 0; i < 2; ++i)
            {
                Calendar.Appointment appt = new Calendar.Appointment();
                appt.AllDayEvent = true;
                appt.Color = Color.BurlyWood;
                DateTime date = DateTime.Now.Date;
                appt.StartDate = date;
                appt.EndDate = date.AddDays(i);
                appt.Title = String.Format("All Day Appointment {0}", i);
                _appointments.Add(appt);
            }

            Random rnd = new Random();

            foreach (string person in lstTypeOfScan.Items)
            {
                for (int i = 2; i < 5; i++) // four each
                {
                    for (int day = 0; day < 7; ++day) //per day
                    {
                        Calendar.Appointment appt = new Calendar.Appointment();
                        appt.Object = person;
                        appt.Color = Color.BlanchedAlmond; // dont ask me why I chose this color?
                        DateTime date = DateTime.Now.Date.AddDays(day).AddHours(rnd.Next(10, 17));
                        appt.StartDate = date;
                        appt.EndDate = date.AddMinutes(i * 15);
                        appt.Title = String.Format("Test Appointment {0}", i);
                        _appointments.Add(appt);
                    }
                }
            }

            // overlapped appointments
            string firstPerson = (string)lstTypeOfScan.Items[0];

            for (int i = 0; i < _overlappedAppointments.Length; i++)
            {
                Calendar.Appointment appt = new Calendar.Appointment();
                appt.Object = firstPerson;
                appt.Color = Color.BlanchedAlmond; // dont ask me why I chose this color?
                DateTime date = DateTime.Now.Date.AddMinutes(_overlappedAppointments[i]);
                appt.StartDate = date;
                appt.EndDate = date.AddMinutes(_overlapDurations[i]);
                appt.Title = String.Format("Overlap {0}", i);
                _appointments.Add(appt);
            }
        }
        private void CreateRandomAppointments()
        {
            //allday appointments
            for (int i = 0; i < 2; ++i)
            {
                Calendar.Appointment appt = new Calendar.Appointment();
                appt.AllDayEvent = true;
                appt.Color = Color.BurlyWood;
                DateTime date = DateTime.Now.Date;
                appt.StartDate = date;
                appt.EndDate = date.AddDays(i);
                appt.Title = String.Format("All Day Appointment {0}", i);
                _appointments.Add(appt);
            }

            Random rnd = new Random();
<<<<<<< HEAD

=======
            //Get class manage Appointment
            Appointment newApp = new Appointment();
>>>>>>> d37cf9e39861e9834372e35c3ec209f1d3833c6d
            foreach (string person in lstTypeOfScan.Items)
            {
                for (int i = 2; i < 5; i++) // four each
                {
                    for (int day = 0; day < 7; ++day) //per day
                    {
<<<<<<< HEAD

                        //DateTime date = DateTime.Now.Date.AddDays(day).AddHours(rnd.Next(10, 17));
                        //DateTime start = date;
                        //DateTime ened = date.AddMinutes(i * 15);
                        //typeOfScanners randType = (typeOfScanners)Enum.Parse(typeof(typeOfScanners), rnd.Next(0, 4) + "", true);
                        //newApp.CreateAppointment("นายแพทย์จุดๆ", randType, start, ened, String.Format("Test Appointment {0}", i));

<<<<<<< HEAD
                        //_appointments.Add(test(day, rnd, i));
=======

>>>>>>> d37cf9e39861e9834372e35c3ec209f1d3833c6d
                        //_appointments.Add(newApp.appt);

                        Calendar.Appointment appt = new Calendar.Appointment();
                        appt.Object = person;
                        appt.Color = Color.BlanchedAlmond;
                        DateTime date2 = DateTime.Now.Date.AddDays(day).AddHours(rnd.Next(10, 17));
                        appt.StartDate = date2;
                        appt.EndDate = date2.AddMinutes(i * 15);
                        appt.Title = String.Format("Test Appointment {0}", i);
                        _appointments.Add(appt);





=======
                        Calendar.Appointment appt = new Calendar.Appointment();
                        appt.Object = person;
                        appt.Color = Color.BlanchedAlmond; // dont ask me why I chose this color?
                        DateTime date = DateTime.Now.Date.AddDays(day).AddHours(rnd.Next(10, 17));
                        appt.StartDate = date;
                        appt.EndDate = date.AddMinutes(i * 15);
                        appt.Title = String.Format("Test Appointment {0}", i);
                        _appointments.Add(appt);
>>>>>>> parent of 61092b3... Add config appointment
                    }
                }
            }

            // overlapped appointments
            string firstPerson = (string)lstTypeOfScan.Items[0];

            for (int i = 0; i < _overlappedAppointments.Length; i++)
            {
                Calendar.Appointment appt = new Calendar.Appointment();
                appt.Object = firstPerson;
                appt.Color = Color.BlanchedAlmond; // dont ask me why I chose this color?
                DateTime date = DateTime.Now.Date.AddMinutes(_overlappedAppointments[i]);
                appt.StartDate = date;
                appt.EndDate = date.AddMinutes(_overlapDurations[i]);
                appt.Title = String.Format("Overlap {0}", i);
                _appointments.Add(appt);
            }
        }
        #endregion Private Methods

        
        private void dayViewToolStripMenuItem5Days_Click(object sender, EventArgs e)
        {
            _daysToView = 5;
            ForceRefresh();
        }

        private void teamViewToolStripMenuItem7Days_Click(object sender, EventArgs e)
        {
            _daysToView = 7;
            ForceRefresh();
        }

        #region Tool Strip Events
        private void toolStripButtonDayView_Click(object sender, EventArgs e)
        {
            dayView1.ViewType = Calendar.DayView.DayViewType.SingleView;

            //in single view remove all other selections
            for (int i = 0; i < lstTypeOfScan.Items.Count; ++i)
            {
                lstTypeOfScan.SetItemChecked(i, i == lstTypeOfScan.SelectedIndex);
            }

            ForceRefresh();
        }

        private void toolStripButtonTeamView_Click(object sender, EventArgs e)
        {
            dayView1.ViewType = Calendar.DayView.DayViewType.TeamView;
            ForceRefresh();
        }
        #endregion

        private void lstTypeOfScan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dayView1.ViewType == Calendar.DayView.DayViewType.SingleView)
            {
                //in single view remove all other selections
                for (int i = 0; i < lstTypeOfScan.Items.Count; ++i)
                {
                    lstTypeOfScan.SetItemChecked(i, i == lstTypeOfScan.SelectedIndex);
                }
            }
            ForceRefresh();
        }

        private int GetTypeOfScannerColumn(string Scanner)
        {
            int Result = -1;

            for (int i = 0; i < lstTypeOfScan.CheckedItems.Count; ++i)
            {
                if ((string)lstTypeOfScan.CheckedItems[i] == Scanner)
                {
                    Result = i;
                    break;
                }
            }

            return (Result);
        }

        private void dayView1_ResolveAppointments(object sender, Calendar.ResolveAppointmentsEventArgs e)
        {
            List<Calendar.Appointment> resolvedAppointments = new List<Calendar.Appointment>();

            foreach (Calendar.Appointment appt in _appointments)
            {
                if ((!appt.AllDayEvent && (appt.StartDate.Date >= e.StartDate.Date && appt.EndDate.Date <= e.EndDate)
                    || (appt.AllDayEvent && dayView1.DateWithin(e.StartDate, e.EndDate, appt.StartDate, appt.EndDate))))
                {
                    if (dayView1.SelectedAppointment != appt)
                    {
                        if (dayView1.ViewType == Calendar.DayView.DayViewType.TeamView)
                        {
                            //if its team view get the column for the person
                            appt.Column = GetTypeOfScannerColumn((string)appt.Object);

                            //if person not found, continue...
                            if (!appt.AllDayEvent && appt.Column == -1)
                                continue;
                        }
                        else
                        {
                            //if dayview only show appointments for selected person
                            if (!appt.AllDayEvent && (string)appt.Object != (string)lstTypeOfScan.CheckedItems[0])
                                continue;
                        }
                    }

                    resolvedAppointments.Add(appt);
                }
            }

            e.Appointments = resolvedAppointments;
        }

        private void dayView1_WorkingHours(object sender, Calendar.WorkingHoursEventArgs e)
        {
            //Just an example of working hours, derive proper data from DB or similar
            switch (e.Column)
            {
                case 0:
                    e.WorkingHourStart = 10;
                    e.WorkingMinuteStart = 0;
                    e.WorkingHourFinish = 18;
                    e.WorkingMinuteFinish = 0;
                    break;
                case 1:
                case 3:
                    e.WorkingHourStart = 9;
                    e.WorkingMinuteStart = 30;
                    e.WorkingHourFinish = 17;
                    e.WorkingMinuteFinish = 30;
                    break;
                default:
                    e.WorkingHourStart = 9;
                    e.WorkingMinuteStart = 0;
                    e.WorkingHourFinish = 17;
                    e.WorkingMinuteFinish = 0;
                    break;
            }
        }

        private void dayView1_ToolTipShow(object sender, Calendar.TooltipEventArgs e)
        {
            e.ShowBalloon = false;

            if (e.Appointment != null)
            {
                e.Title = "Appointment for " + (string)e.Appointment.Object;
                e.Text = "Hovering over appointment";
                e.ShowBalloon = false;
            }
            else
            {
                if (e.CurrentCellDateTime < DateTime.Now)
                    e.Text = "Can not create appointment in the past";
                else
                    e.Text = "Double Click to add an appointment";
            }

            e.AllowShow = true;
        }

        private void dayView1_MultiHeader(object sender, Calendar.TeamViewGetEventArgs e)
        {
            if (dayView1.ViewType == Calendar.DayView.DayViewType.TeamView)
                e.HeaderText = (string)lstTypeOfScan.CheckedItems[e.Index];
            else
                e.HeaderText = dayView1.StartDate.AddDays(e.Index).ToShortDateString();
        }

        private void dayView1_MultiCount(object sender, Calendar.TeamViewCountEventArgs e)
        {
            //how many columns to show in day view?
            if (dayView1.ViewType == Calendar.DayView.DayViewType.SingleView)
                e.Count = _daysToView;
            else
                e.Count = lstTypeOfScan.CheckedItems.Count;
        }

        private void dayView1_BeforeAppointmentMove(object sender, Calendar.AppointmentMoveEventArgs e)
        {
            e.AllowMove = false;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            ForceRefresh();
        }

        private void monthCalendar2_DateChanged(object sender, DateRangeEventArgs e)
        {
            ForceRefresh2();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddAppmForm addf = new AddAppmForm();
            addf.ShowDialog(); 
        }

       

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
