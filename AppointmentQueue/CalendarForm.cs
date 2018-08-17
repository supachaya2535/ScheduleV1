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
        /// <Additional parameter>
        public int usageTime;
        public int periodInx;
        public int requestInx;
        public string drInx;
        public int kidInx;
        public string drcInx;
        public DateTime startT;
        public DateTime chosenT;
        public bool exist = false;
        /// </summary>

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
        private DateTime[,] calendar_day_all_date;
        private List<DataRow>[,] morning_all_btn;
        private List<DataRow>[,] evening_all_btn;

        public CalendarForm(int ped, int req, DateTime sT, int kid)
        {
            InitializeComponent();
            
            periodInx = ped;
            requestInx = req;
            kidInx = kid;
            reqCob = SQL.readRequest(reqCob);
            reqCob.SelectedIndex = requestInx;
            comboBox1.SelectedIndex = periodInx;
            dateTimePicker1.Value = sT;
            selectedDate.Value = sT;
            startT = sT;
            chosenT = sT;

            usageTime = SQL.getTimeReq(reqCob.SelectedItem.ToString().Trim());
        }

        private void SetDoctorWorkDataButtonToBasic()
        {
            morning_all_btn = new List<DataRow>[6, 7];
            evening_all_btn = new List<DataRow>[6, 7];
            for (int i = 0; i < morning_all_btn.GetLength(0); i++)
            {
                for (int j = 0; j < morning_all_btn.GetLength(1); j++)
                {
                    morning_all_btn[i, j] = new List<DataRow>();
                    evening_all_btn[i, j] = new List<DataRow>();
                }
            }
        }

        private void CalendarForm_Load(object sender, EventArgs e)
        {
            // set initialize
            SetDoctorWorkDataButtonToBasic();

            // assign button of day
            calendar_day_all_btn = new Button[6, 7];
            calendar_day_all_date = new DateTime[6, 7];
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

            if (morning_all_btn[row_bt, col_bt].Count > 0 ||
                evening_all_btn[row_bt, col_bt].Count > 0)
            {
                
                //ShowDetailOfCalendar detail_form = new ShowDetailOfCalendar();
                //detail_form.morning_data = morning_all_btn[row_bt, col_bt];
                //detail_form.evening_data = evening_all_btn[row_bt, col_bt];
                //detail_form.date = calendar_day_all_date[row_bt, col_bt];

                startT = calendar_day_all_date[row_bt, col_bt]; 
                DataTable suggestDate = SQL.GetDoctorCalendars(startT, startT, "", "", "");
                suggDataGridView.DataSource = suggestDate;

                //detail_form.ShowDialog();
            }
            //MessageBox.Show("row:" + row_bt + "|col:" + col_bt);
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

            Point start_rc = AssignDayOfCalendar(start_row, (int)first_day_of_week, count_of_month, year, month);
            int day_start = AssignDayOfPrevCalendar(first_date);
            int day_end = AssignDayOfNextCalendar(start_rc.X, start_rc.Y, year, month);

            // find and set up today button 
            SetupTodayButton(month, year);

            // database doctor section
            DateTime start_date = FindDateStartOfCurrentMonth(month, year, day_start);
            DateTime ending_date = FindDateEndingOfCurrentMonth(month, year, day_end);

            DataTable dt = SQL.GetDoctorCalendars(start_date, ending_date);
            AssignDoctorWorkOnCalendar(dt);

        }

        private void AssignDataOfDoctorWorksToVariable(DataTable data)
        {
            List<DataRow> data_by_row = new List<DataRow>();
            foreach (DataRow row in data.Rows)
            {
                if (row["drc_status"].ToString().Trim() == "Available")
                    data_by_row.Add(row);
            }

            for (int i = 0; i < calendar_day_all_btn.GetLength(0); i++)
            {
                for (int j = 0; j < calendar_day_all_btn.GetLength(1); j++)
                {
                    int deletedIndex = -1;
                    for (int k = 0; k < data_by_row.Count; k++)
                    {
                        DateTime date_row = (DateTime)data_by_row[k]["drc_date"];
                        string drw_period = data_by_row[k]["drw_period"].ToString().Trim();

                        if (calendar_day_all_date[i, j].Day == date_row.Day &&
                            calendar_day_all_date[i, j].Month == date_row.Month &&
                            calendar_day_all_date[i, j].Year == date_row.Year)
                        {
                            deletedIndex = k;
                            if (drw_period == "Morning")
                                morning_all_btn[i, j].Add(data_by_row[k]);
                            else
                                evening_all_btn[i, j].Add(data_by_row[k]);

                            break;
                        }
                    }

                    if (deletedIndex != -1)
                        data_by_row.RemoveAt(deletedIndex);

                    if (data_by_row.Count <= 0)
                        break;
                }

                if (data_by_row.Count <= 0)
                    break;
            }
        }

        private void AssignDoctorWorksVariableToButtonCalendar()
        {
            for (int i = 0; i < calendar_day_all_btn.GetLength(0); i++)
            {
                for (int j = 0; j < calendar_day_all_btn.GetLength(1); j++)
                {
                    string display_on_btn = "";
                    if (morning_all_btn[i, j].Count > 0)
                    {
                        display_on_btn += "Morning : \n";
                        for (int k = 0; k < morning_all_btn[i, j].Count; k++)
                        {
                            string dr_name_lname = morning_all_btn[i, j][k]["dr_name"].ToString().Trim() + " " +
                                                   morning_all_btn[i, j][k]["dr_lname"].ToString().Trim();
                            display_on_btn += (k + 1).ToString() + ": " + dr_name_lname + "\n";
                        }
                    }
                    if (evening_all_btn[i, j].Count > 0)
                    {
                        display_on_btn += "Evening : \n";
                        for (int k = 0; k < evening_all_btn[i, j].Count; k++)
                        {
                            string dr_name_lname = evening_all_btn[i, j][k]["dr_name"].ToString().Trim() + " " +
                                                   evening_all_btn[i, j][k]["dr_lname"].ToString().Trim();
                            display_on_btn += (k + 1).ToString() + ": " + dr_name_lname + "\n";
                        }
                    }
                    calendar_day_all_btn[i, j].Text += "\n" + display_on_btn;

                    // kid and no kid checking
                    bool is_have_kid = CheckKidOrNoKid(i, j);
                    bool is_limit_day = CheckLimitDay(i, j);

                    if (morning_all_btn[i, j].Count > 0 ||
                        evening_all_btn[i, j].Count > 0)
                    {
                        // set color follow by doctor work properties
                        // 1. limit
                        // Aqua background color button
                        if (is_limit_day)
                        {
                            calendar_day_all_btn[i, j].BackColor = Color.Pink;
                        }
                        // 2. no kid
                        // AntiqueWhite background color button
                        else if (!is_have_kid)
                        {
                            calendar_day_all_btn[i, j].BackColor = Color.AntiqueWhite;
                        }
                        // 3. have kid
                        // Azure background color button
                        else if (is_have_kid)
                        {
                            calendar_day_all_btn[i, j].BackColor = Color.Gold;
                        }
                    }
                }
            }
        }

        private bool CheckLimitDay(int i, int j)
        {
            bool is_limit_morning = true;
            bool is_limit_evening = true;
            // morning
            foreach (DataRow row in morning_all_btn[i, j])
            {
                if (Convert.ToInt32(row["drc_time"]) < 100)
                    is_limit_morning = false;
            }
            // evening
            foreach (DataRow row in evening_all_btn[i, j])
            {
                if (Convert.ToInt32(row["drc_time"]) < 100)
                    is_limit_evening = false;
            }

            if (is_limit_evening && is_limit_morning)
                return true;
            else
                return false;
        }

        private bool CheckKidOrNoKid(int i, int j)
        {
            bool is_kid = false;
            // morning checking
            foreach (DataRow row in morning_all_btn[i, j])
            {
                if (row["drw_kid"].ToString().Trim() == "1")
                {
                    is_kid = true;
                    break;
                }
            }

            // evening checking
            foreach (DataRow row in evening_all_btn[i, j])
            {
                if (row["drw_kid"].ToString().Trim() == "1")
                {
                    is_kid = true;
                    break;
                }
            }

            return is_kid;
        }

        private void AssignDoctorWorkOnCalendar(DataTable data)
        {
            SetDoctorWorkDataButtonToBasic();
            AssignDataOfDoctorWorksToVariable(data);
            AssignDoctorWorksVariableToButtonCalendar();
        }

        private Point FindPositionOfCalendarButton(DateTime date)
        {
            Point pos = new Point(-1, -1);
            bool is_break = false;
            for (int i = 0; i < calendar_day_all_date.GetLength(0); i++)
            {
                for (int j = 0; j < calendar_day_all_date.GetLength(1); j++)
                {
                    if (date.Day == calendar_day_all_date[i, j].Day &&
                        date.Month == calendar_day_all_date[i, j].Month &&
                        date.Year == calendar_day_all_date[i, j].Year)
                    {
                        pos.X = i;
                        pos.Y = j;
                        is_break = true;
                        break;
                    }
                }
                if (is_break)
                    break;
            }

            return pos;
        }

        private DateTime FindDateStartOfCurrentMonth(int cur_month, int cur_year, int day_start)
        {
            int month_start = cur_month - 1;
            int year_start = cur_year;

            if (cur_month == 1)
            {
                month_start = 12;
                year_start--;
            }

            return new DateTime(year_start, month_start, day_start);
        }

        private DateTime FindDateEndingOfCurrentMonth(int cur_month, int cur_year, int day_end)
        {
            int month_end = cur_month + 1;
            int year_end = cur_year;

            if (cur_month == 12)
            {
                month_end = 1;
                year_end++;
            }

            return new DateTime(year_end, month_end, day_end);
        }

        private void SetupTodayButton(int month, int year)
        {
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
                    // text alignment
                    calendar_day_all_btn[i, j].TextAlign = ContentAlignment.TopLeft;

                    // border color
                    calendar_day_all_btn[i, j].FlatAppearance.BorderColor = Color.Black;
                    calendar_day_all_btn[i, j].FlatAppearance.BorderSize = 1;

                    // color of foreground (text)
                    calendar_day_all_btn[i, j].BackColor = Color.Transparent;
                    calendar_day_all_btn[i, j].ForeColor = Color.Black;
                    calendar_day_all_btn[i, j].Text = "";
                }
            }
        }

        private Point AssignDayOfCalendar(int row, int col, int count_of_month, int year, int month)
        {
            int count_day = 1;
            // first row assign
            for (int i = col; i < 7; i++)
            {
                calendar_day_all_btn[row, i].Text = count_day.ToString();
                calendar_day_all_date[row, i] = new DateTime(year, month, count_day);
                count_day++;
            }

            row++;
            Point end_rc = new Point(1, 1);
            bool is_break_assign = false;
            // another row assign
            for (int i = row; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    calendar_day_all_btn[i, j].Text = count_day.ToString();
                    calendar_day_all_date[i, j] = new DateTime(year, month, count_day);
                    count_day++;
                    if (count_day > count_of_month)
                    {
                        j++;
                        if (j == 7)
                        {
                            j = 0;
                            i++;
                        }

                        end_rc = new Point(i, j);
                        is_break_assign = true;
                        break;
                    }
                }
                row++;
                if (is_break_assign)
                    break;
            }

            return end_rc;
        }

        private int AssignDayOfNextCalendar(int start_row, int start_col, int cur_year, int cur_month)
        {
            int day = 1;
            int next_month = cur_month + 1;
            int next_year = cur_year;
            if (next_month > 12)
            {
                next_month = 1;
                next_year++;
            }

            // first start row
            for (int i = start_col; i < 7; i++)
            {
                calendar_day_all_btn[start_row, i].Text = day.ToString();
                calendar_day_all_btn[start_row, i].ForeColor = Color.Green;
                calendar_day_all_date[start_row, i] = new DateTime(next_year, next_month, day);
                day++;
            }

            start_row++;
            for (int i = start_row; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    calendar_day_all_btn[i, j].Text = day.ToString();
                    calendar_day_all_btn[i, j].ForeColor = Color.Green;
                    calendar_day_all_date[i, j] = new DateTime(next_year, next_month, day);
                    day++;
                }
            }

            day--;
            return day;
        }

        private int AssignDayOfPrevCalendar(DateTime first_date)
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
                calendar_day_all_date[0, i] = new DateTime(prev_year, prev_month, count_of_month);
                count_of_month--;
            }

            count_of_month++;
            return count_of_month;
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

        private void seachDateForReq_Click(object sender, EventArgs e)
        {
            startT = startT.Date;
            int offSet = Convert.ToInt16(dayNumericUpDown.Value);
            DateTime endT = startT.AddDays(offSet);

            DataTable suggestDate = SQL.GetDoctorCalendars(startT, 
                endT, 
                reqCob.SelectedItem.ToString().Trim(),
                Convert.ToInt16(kidCheckBox.Checked).ToString().Trim(), 
                comboBox1.SelectedItem.ToString().Trim());
            suggDataGridView.DataSource = suggestDate;
            
        }

        private void acceptDateForReq_Click(object sender, EventArgs e)
        {
            exist = true;
            Close();
        }

        
        private void suggDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int ID = suggDataGridView.CurrentRow.Index;
            reqCob.SelectedIndex = requestInx;
            comboBox1.SelectedIndex = periodInx;
            kidCheckBox.Checked = Convert.ToBoolean(kidInx);
            drInx = suggDataGridView.Rows[ID].Cells["drw_dr"].Value.ToString().Trim();
            drcInx = suggDataGridView.Rows[ID].Cells["drc_id"].Value.ToString().Trim();

            chosenT = Convert.ToDateTime(suggDataGridView.Rows[ID].Cells["drc_date"].Value.ToString().Trim());
            selectedDate.Value = chosenT.Date;
        }

        private void reqCob_SelectedIndexChanged(object sender, EventArgs e)
        {
            usageTime = SQL.getTimeReq(reqCob.SelectedItem.ToString().Trim());
            requestInx = reqCob.SelectedIndex;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            periodInx = comboBox1.SelectedIndex;
        }

        private void suggDataGridView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int ID = suggDataGridView.CurrentRow.Index;
            reqCob.SelectedIndex = requestInx;
            comboBox1.SelectedIndex = periodInx;
            kidCheckBox.Checked = Convert.ToBoolean(kidInx);
            drInx = suggDataGridView.Rows[ID].Cells["drw_dr"].Value.ToString().Trim();
            drcInx = suggDataGridView.Rows[ID].Cells["drc_id"].Value.ToString().Trim();

            chosenT = Convert.ToDateTime(suggDataGridView.Rows[ID].Cells["drc_date"].Value.ToString().Trim());
            selectedDate.Value = chosenT.Date;

        }
    }
}
