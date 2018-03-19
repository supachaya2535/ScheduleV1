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
using System.Data.SqlLocalDb;

namespace AppointmentQueue
{
    public partial class edit_CondReq_Form : Form
    {
        SqlConnection cn = new SqlConnection(global::AppointmentQueue.Properties.Settings.Default.Database1ConnectionString);
        
        int ID = -1;
        int order = 0;
        public edit_CondReq_Form()
        {
            InitializeComponent();
        }
        private void edit_CondReq_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.ConditionRequest' table. You can move, or remove it, as needed.
            this.conditionRequestTableAdapter.Fill(this.database1DataSet.ConditionRequest);

            DataTable ConReqTable = readConditionRequest();
            dataGridView1.DataSource = ConReqTable;

        }
        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataTable ReqTable = SQL.GetRequests();
            ID = dataGridView1.CurrentRow.Index;
            condReq_listV.Items.Clear();
            readRequest();
            reqCob.Enabled = true;
            string posReq = dataGridView1.Rows[ID].Cells[1].Value.ToString().Trim();
            int dofInt = Convert.ToInt32(dataGridView1.Rows[ID].Cells[3].Value);
            if (dofInt == 1) dof_txt.Text = "Monday";
            else if (dofInt == 2) dof_txt.Text = "Tueday";
            else if (dofInt == 3) dof_txt.Text = "Wendday";
            else if (dofInt == 4) dof_txt.Text = "Thurtday";
            else if (dofInt == 5) dof_txt.Text = "Friday";
            else if (dofInt == 6) dof_txt.Text = "Saturday";
            else if (dofInt == 7) dof_txt.Text = "Sunday";

            int PeroidOfoDay = Convert.ToInt32(dataGridView1.Rows[ID].Cells[2].Value);
            if (PeroidOfoDay == 1)
            {
                morn_radioBtn.Checked = true;
                after_radioBtn.Checked = false;
            }
            else
            {
                morn_radioBtn.Checked = false;
                after_radioBtn.Checked = true;
            }

            dutimeUpDo.Value = Convert.ToInt32(dataGridView1.Rows[ID].Cells[4].Value);
            dutimeUpDo.Enabled = true;
            int macNum = Convert.ToInt32(dataGridView1.Rows[ID].Cells[5].Value);
            if (macNum == 1) mac_txt.Text = "Up";
            else mac_txt.Text = "Down";

            string[] reqAray = posReq.Split(',');
            order = 1;
            foreach (string req in reqAray)
            {
                int req_id = Convert.ToInt32(req);
                string search_req = "req_id = " + req_id;
                string req_bodypart = ReqTable.Select(search_req)[0]["req_bodypart"].ToString();
                ListViewItem lvItem = new ListViewItem(order.ToString());
                lvItem.SubItems.Add(req_id.ToString());
                lvItem.SubItems.Add(req_bodypart);
                condReq_listV.Items.Add(lvItem);
                order++;
            }

        }
        
        private void readRequest()
        {
            DataTable ReqTable = SQL.GetRequests();
            foreach (DataRow item in ReqTable.Rows)
                reqCob.Items.Add(item["req_bodypart"].ToString());
        }

        private string readStringRequest()
        {
            string strReq = "";
            for (int i = 0; i < condReq_listV.Items.Count; i++)
            {
                string codeR = condReq_listV.Items[i].SubItems[1].Text;
                strReq += codeR;
                if (i < condReq_listV.Items.Count - 1)
                    strReq += ',';
            }
            return strReq;
        }

        private DataTable readConditionRequest()
        {
            cn.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM ConditionRequest", cn);
            SqlDataReader reader = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            cn.Close();
            return dt;
        }


        private void edit_btn_Click(object sender, EventArgs e)
        {
            if (ID > -1)
            {
                if (MessageBox.Show("Do you want to update this record?", "Warning", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        cn.Open();
                        string str_poss = readStringRequest();
                        int cond = Convert.ToInt16(dutimeUpDo.Value);
                        int idcond = Convert.ToInt16(dataGridView1.Rows[ID].Cells[0].Value);
                        SqlCommand cmd = new SqlCommand("update ConditionRequest set possible_req=@poss_r,cond_limit_time=@cond_lim "+
                            "WHERE Id=@id_cond", cn);
                        cmd.Parameters.AddWithValue("@poss_r", str_poss.Trim());
                        cmd.Parameters.AddWithValue("@cond_lim", cond);
                        cmd.Parameters.AddWithValue("@id_cond", idcond);
                        cmd.ExecuteNonQuery();
                        cn.Close();
                        MessageBox.Show("Record Updated Successfully");
                        this.conditionRequestTableAdapter.Fill(this.database1DataSet.ConditionRequest);
                        DataTable ConReqTable = readConditionRequest();
                        dataGridView1.DataSource = ConReqTable;
                        
                    }
                    catch
                    {
                        MessageBox.Show("Can not update this record");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please Select Record to Update");
            }
        }
        
        private void reqCob_SelectedIndexChanged(object sender, EventArgs e)
        {
            add_req_btn.Enabled = true;
            edit_btn.Enabled = true;
        }

        private void condReq_listV_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (ID > -1)
            {
                remove_btn.Enabled = true;
            }
            else
            {
                MessageBox.Show("Please Select Record to Update");
            }
        }
        
        private void add_req_btn_Click_1(object sender, EventArgs e)
        {
            if (ID > -1)
            {
                if(reqCob.Text.Trim()=="")
                {
                    MessageBox.Show("Please Select Request!!!");
                }
                else
                {
                    for (int i = 0;i < condReq_listV.Items.Count; i++)
                    {
                        if (condReq_listV.Items[i].SubItems[2].Text.Trim() == reqCob.Text.Trim())
                        {
                            MessageBox.Show("This Request is exist!!!");
                            return;
                        }
                    }
                    ListViewItem lvItem = new ListViewItem(order.ToString());
                    DataTable ReqTable = SQL.GetRequests();
                    string codeR = "";
                    for (int i=0;i< ReqTable.Rows.Count; i++){
                        if(ReqTable.Rows[i]["req_bodypart"].ToString().Trim() == reqCob.Text.Trim())
                        {
                            codeR = ReqTable.Rows[i]["req_id"].ToString().Trim();
                        }
                    }
                    lvItem.SubItems.Add(codeR.Trim());
                    lvItem.SubItems.Add(reqCob.Text.Trim());
                    condReq_listV.Items.Add(lvItem);
                    order++;
                    MessageBox.Show("Add Request is successful!!!");
                }
            }
            else
            {
                MessageBox.Show("Please Select Record to Update");
            }
        }

        private void remove_btn_Click(object sender, EventArgs e)
        {
            if (condReq_listV.SelectedItems.Count == 0) return;
            condReq_listV.FocusedItem.Remove();
            for (int i = 0; i < condReq_listV.Items.Count; i++)
            {
                condReq_listV.Items[i].SubItems[0].Text = (i + 1).ToString();
            }
            order--;
            ID = -1;
        }
    }
}
