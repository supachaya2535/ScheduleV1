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
    public partial class edit_CondReq_Form : Form
    {
        public edit_CondReq_Form()
        {
            InitializeComponent();
        }

        private void edit_CondReq_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.ConditionRequest' table. You can move, or remove it, as needed.
            this.conditionRequestTableAdapter.Fill(this.database1DataSet.ConditionRequest);

        }
    }
}
