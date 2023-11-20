using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS_Desktop
{
    public partial class CancelLeave : Form
    {
        private readonly LeaveManagementSystemEntities4 LMS;
        public CancelLeave()
        {
            InitializeComponent();
            LMS = new LeaveManagementSystemEntities4();
        }
        private void refresh()
        {
            var data = LMS.AllRequests_SP();
            dataGridView1.DataSource = data;

            var cancel = LMS.CancelationReasons.ToList();
            LeaveStatusCobx.DisplayMember = "reason";
            LeaveStatusCobx.ValueMember = "id";
            LeaveStatusCobx.DataSource = cancel;
            clear();
        }
        private void clear()
        {
            EmpIDtxtbx.Clear();
            Idtxtbx.Clear();
            Nametxtbx.Clear();
            Typetxtbx.Clear();
        }
        private void CancelLeave_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Idtxtbx.Text = dataGridView1.SelectedRows[0].Cells["id"].Value.ToString();
            EmpIDtxtbx.Text = dataGridView1.SelectedRows[0].Cells["EmployeeID"].Value.ToString();
            Nametxtbx.Text = dataGridView1.SelectedRows[0].Cells["Name"].Value.ToString();
            Typetxtbx.Text = dataGridView1.SelectedRows[0].Cells["type"].Value.ToString();
        }

        private void Applybtn_Click(object sender, EventArgs e)
        {
            if(Idtxtbx.Text=="")
            {
                PopError popup = new PopError("INVALID","Please double click an entry from the table to populate the fields");
                popup.ShowDialog();
            }
            else
            {
                int indexnum = Convert.ToInt32(Idtxtbx.Text);
                var cancel = LMS.LeaveSubmissionTable.FirstOrDefault(a => a.id == indexnum);
                if (cancel != null)
                {
                    cancel.CancelId = Convert.ToInt32(LeaveStatusCobx.SelectedValue);
                    cancel.LeaveStatusId = 6;
                }
                LMS.SaveChanges();
                refresh();   
            }
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            refresh();
        }
    }
}
