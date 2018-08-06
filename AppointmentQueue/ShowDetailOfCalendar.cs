using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppointmentQueue
{
    public partial class ShowDetailOfCalendar : Form
    {
        public List<DataRow> morning_data;
        public List<DataRow> evening_data;
        public DateTime date;

        public ShowDetailOfCalendar()
        {
            InitializeComponent();
        }

        private void ShowDetailOfCalendar_Load(object sender, EventArgs e)
        {
            // set the detail of text box
            detail_tb.AppendText("Detail of date : " + date.Day + "/" + date.Month + "/" + date.Year);
            detail_tb.AppendText(Environment.NewLine);

            // set morning data
            if (morning_data.Count > 0)
            {
                detail_tb.AppendText("Morning : ");
                detail_tb.AppendText(Environment.NewLine);
                for (int i = 0; i < morning_data.Count; i++)
                {
                    string dr_name = morning_data[i]["dr_name"].ToString().Trim() + " " +
                                     morning_data[i]["dr_lname"].ToString().Trim();
                    string use_time = morning_data[i]["drc_time"].ToString().Trim();

                    detail_tb.AppendText("(" + (i + 1).ToString() + ")");
                    if (morning_data[i]["drw_kid"].ToString().Trim() == "1")
                        detail_tb.AppendText(" (KID) ");

                    detail_tb.AppendText(Environment.NewLine);
                    detail_tb.AppendText("Doctor : " + dr_name);
                    detail_tb.AppendText(Environment.NewLine);
                    detail_tb.AppendText("Usage Time : " + use_time);
                    detail_tb.AppendText(Environment.NewLine);
                }
            }

            // set evening data
            if (evening_data.Count > 0)
            {
                detail_tb.AppendText("Evening : ");
                detail_tb.AppendText(Environment.NewLine);
                for (int i = 0; i < evening_data.Count; i++)
                {
                    string dr_name = evening_data[i]["dr_name"].ToString().Trim() + " " +
                                     evening_data[i]["dr_lname"].ToString().Trim();
                    string use_time = evening_data[i]["drc_time"].ToString().Trim();

                    detail_tb.AppendText("(" + (i + 1).ToString() + ")");
                    if (evening_data[i]["drw_kid"].ToString().Trim() == "1")
                        detail_tb.AppendText(" (KID) ");

                    detail_tb.AppendText(Environment.NewLine);
                    detail_tb.AppendText("Doctor : " + dr_name);
                    detail_tb.AppendText(Environment.NewLine);
                    detail_tb.AppendText("Usage Time : " + use_time);
                    detail_tb.AppendText(Environment.NewLine);
                }
            }
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
