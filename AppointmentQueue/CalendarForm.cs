using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace AppointmentQueue
{
    public partial class CalendarForm : Form
    {

        public enum MonthName
        {
            January = 1,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December
        }

        private Button[,] calendar_day_all_btn;

        public CalendarForm()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            // when click another date that it's not the same date
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            // when click the selected date
        }

        private void monthCalendar1_MouseMove(object sender, MouseEventArgs e)
        {
            // trick when mouse is over on the calendar
        }

        private void CalendarForm_Load(object sender, EventArgs e)
        {
            // assign button of day
            calendar_day_all_btn = new Button[6, 7];
            for (int i = 0; i < calendar_day_all_btn.GetLength(0); i++)
            {
                for (int j = 0; j < calendar_day_all_btn.GetLength(1); j++)
                {
                    string name_bt = "day_" + i + "_" + j + "_btn";
                    Button bt = this.Controls.Find(name_bt, true).FirstOrDefault() as Button;
                    calendar_day_all_btn[i, j] = bt;
                }
            }

            GenarateCalendar(DateTime.Today.Month, DateTime.Today.Year);
        }

        private void DayClick(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            int row_bt = Convert.ToInt32(bt.Name.Split('_')[1]);
            int col_bt = Convert.ToInt32(bt.Name.Split('_')[2]);

            MessageBox.Show("row:" + row_bt + "|col:" + col_bt);
        }

        // column 0 : Sunday
        // column 1 : Monday
        // column 2 : Tuesday
        // column 3 : Wednesday
        // column 4 : Thrusday
        // column 5 : Friday
        // column 6 : Saturday
        private void GenarateCalendar(int month, int year)
        {
            // let's set button to begin
            SetButtonToBegin();

            // set button 
            month_btn.Text = ((MonthName)month).ToString();
            year_btn.Text = year.ToString();
            today_date_btn.Text = DateTime.Today.ToString();
            today_show_btn.Text = "";

            // genarate day in month
            DateTime first_date = new DateTime(year, month, 1);
            DayOfWeek first_day_of_week = first_date.DayOfWeek;
            int count_of_month = DateTime.DaysInMonth(first_date.Year, first_date.Month);
            int start_row = first_day_of_week == DayOfWeek.Sunday ? 1 : 0;

            Point start_rc = AssignDayOfCalendar(start_row, (int)first_day_of_week, count_of_month);
            AssignDayOfPrevCalendar(first_date);
            AssignDayOfNextCalendar(start_rc.X, start_rc.Y);

            // set today color
            // find button today
            for (int i = 0; i < calendar_day_all_btn.GetLength(0); i++)
            {
                for (int j = 0; j < calendar_day_all_btn.GetLength(1); j++)
                {
                    if (DateTime.Today.Day.ToString().Trim() == calendar_day_all_btn[i, j].Text.Trim())
                    {
                        if (calendar_day_all_btn[i, j].ForeColor == Color.Black &&
                            month == DateTime.Today.Month && year == DateTime.Today.Year)
                        {
                            calendar_day_all_btn[i, j].BackColor = Color.LightGray;
                        }
                        else if (calendar_day_all_btn[i, j].ForeColor == Color.Red)
                        {
                            int month_prev = month - 1;
                            int year_prev = year;
                            if (month < 1)
                            {
                                month_prev = 12;
                                year_prev--;
                            }
                            if (month_prev == DateTime.Today.Month && year_prev == DateTime.Today.Year)
                            {
                                calendar_day_all_btn[i, j].BackColor = Color.LightGray;
                            }
                        }
                        else if (calendar_day_all_btn[i, j].ForeColor == Color.Green)
                        {
                            int month_next = month + 1;
                            int year_next = year;
                            if (month > 12)
                            {
                                month_next = 1;
                                year_next++;
                            }
                            if (month_next == DateTime.Today.Month && year_next == DateTime.Today.Year)
                            {
                                calendar_day_all_btn[i, j].BackColor = Color.LightGray;
                            }
                        }

                    }
                }
            }
        }

        private void SetButtonToBegin()
        {
            for (int i = 0; i < calendar_day_all_btn.GetLength(0); i++)
            {
                for (int j = 0; j < calendar_day_all_btn.GetLength(1); j++)
                {
                    calendar_day_all_btn[i, j].BackColor = Color.Transparent;
                    calendar_day_all_btn[i, j].ForeColor = Color.Black;
                }
            }
        }

        private Point AssignDayOfCalendar(int row, int col, int count_of_month)
        {
            int count_day = 1;
            // first row assign
            for (int i = col; i < 7; i++)
            {
                calendar_day_all_btn[row, i].Text = count_day.ToString();
                count_day++;
            }

            row++;
            Point end_rc = new Point(1, 1);
            // another row assign
            for (int i = row; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    calendar_day_all_btn[i, j].Text = count_day.ToString();
                    count_day++;
                    if (count_day > count_of_month)
                    {
                        end_rc = new Point(i, j);
                        break;
                    }
                }
                row++;
            }

            return end_rc;
        }

        private void AssignDayOfNextCalendar(int start_row, int start_col)
        {
            int day = 1;
            // first start row
            for (int i = start_col; i < 7; i++)
            {
                calendar_day_all_btn[start_row, i].Text = day.ToString();
                calendar_day_all_btn[start_row, i].ForeColor = Color.Green;
                day++;
            }

            start_row++;
            for (int i = start_row; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    calendar_day_all_btn[i, j].Text = day.ToString();
                    calendar_day_all_btn[i, j].ForeColor = Color.Green;
                    day++;
                }
            }
        }

        private void AssignDayOfPrevCalendar(DateTime first_date)
        {
            DayOfWeek day_of_week = first_date.DayOfWeek;
            int prev_month = first_date.Month - 1;
            int prev_year = first_date.Year;
            if (prev_month < 1)
            {
                prev_month = 12;
                prev_year -= 1;
            }
            int count_of_month = DateTime.DaysInMonth(prev_year, prev_month);
            int start_col = -1;
            switch (day_of_week)
            {
                case DayOfWeek.Sunday:
                    start_col = 6;
                    break;
                case DayOfWeek.Monday:
                    start_col = 0;
                    break;
                case DayOfWeek.Tuesday:
                    start_col = 1;
                    break;
                case DayOfWeek.Wednesday:
                    start_col = 2;
                    break;
                case DayOfWeek.Thursday:
                    start_col = 3;
                    break;
                case DayOfWeek.Friday:
                    start_col = 4;
                    break;
                case DayOfWeek.Saturday:
                    start_col = 5;
                    break;
                default:
                    break;
            }

            for (int i = start_col; i >= 0; i--)
            {
                calendar_day_all_btn[0, i].Text = count_of_month.ToString();
                calendar_day_all_btn[0, i].ForeColor = Color.Red;
                count_of_month--;
            }

        }

        private void prev_month_btn_Click(object sender, EventArgs e)
        {
            int cur_year = Convert.ToInt32(year_btn.Text);
            int cur_month = Convert.ToInt32(Enum.Parse(typeof(MonthName), month_btn.Text));
            // decrease month 
            cur_month--;
            if (cur_month < 1)
            {
                cur_year--;
                cur_month = 12;
            }

            GenarateCalendar(cur_month, cur_year);
        }

        private void next_month_btn_Click(object sender, EventArgs e)
        {
            int cur_year = Convert.ToInt32(year_btn.Text);
            int cur_month = Convert.ToInt32(Enum.Parse(typeof(MonthName), month_btn.Text));
            // increase month
            cur_month++;
            if (cur_month > 12)
            {
                cur_month = 1;
                cur_year++;
            }

            GenarateCalendar(cur_month, cur_year);
        }
    }
}
