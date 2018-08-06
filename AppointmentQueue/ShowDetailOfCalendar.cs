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
            detail_tb.AppendText("Detail of date : " + date.ToString());
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

                    detail_tb.AppendText("(" + (i + 1).ToString() + ")");
                    detail_tb.AppendText(Environment.NewLine);
                    detail_tb.AppendText("Name Of Doctor : " + dr_name);
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

                    detail_tb.AppendText("(" + (i + 1).ToString() + ")");
                    detail_tb.AppendText(Environment.NewLine);
                    detail_tb.AppendText("Name Of Doctor : " + dr_name);
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
