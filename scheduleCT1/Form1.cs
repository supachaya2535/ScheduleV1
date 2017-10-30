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

        private int _daysToView = 5;

        #endregion


        public MainForm()
        {
            _appointments = new List<Calendar.Appointment>();
            InitializeComponent();
        }
    }
}
