using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS_Desktop
{
    public partial class RoleAccess : Form
    {
        int selectid=100;
        private readonly LeaveManagementSystemEntities LMS;
        SqlCommand cmd;
        public RoleAccess()
        {
            InitializeComponent();
            LMS = new LeaveManagementSystemEntities();
        }
        public void populate()
        {
            var roles = LMS.Roletest.ToList();
            dataGridView1.DataSource = roles;
        }
        private void RoleAccess_Load(object sender, EventArgs e)
        {
            //populate the gridview with the data from the roletype table
            populate();
            //disable all buttons
            Deletebtn.Enabled = false;
            Updatebtn.Enabled = false;
            Clearbtn.Enabled = false;
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            if(selectid==100)
            {
                Roletest tesst = new Roletest();
                tesst.role = roletxtbx.Text;
                LMS.Roletest.Add(tesst);
                LMS.SaveChanges();
                populate();
                roletxtbx.Clear();
            }
            else
            {
                var update = LMS.Roletest.FirstOrDefault(u => u.id == selectid);
                update.role = roletxtbx.Text;
                LMS.SaveChanges();
                populate();
                roletxtbx.Clear();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //populate the textboxt based on the value in the 2nd column and store the value from the first cell in a variable
            selectid = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            roletxtbx.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            Updatebtn.Enabled = true;
            Clearbtn.Enabled = true;
            Deletebtn.Enabled = true;
        }

        private void roletxtbx_TextChanged(object sender, EventArgs e)
        {
            if(roletxtbx.Text.Trim()=="")
            {
                Updatebtn.Enabled = false;
                Clearbtn.Enabled = false;
                Deletebtn.Enabled = false;
                selectid = 100;
            }
            else
            {
                Updatebtn.Enabled = true;
                Clearbtn.Enabled = true;
            }
        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            roletxtbx.Clear();
            selectid =100;
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            var delete = LMS.Roletest.FirstOrDefault(u => u.id == selectid);
            if(delete != null)
            {
                LMS.Roletest.Remove(delete);
                LMS.SaveChanges();
            }
        }
    }
}
