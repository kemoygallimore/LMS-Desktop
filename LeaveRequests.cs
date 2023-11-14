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
    public partial class LeaveRequests : Form
    {
        private readonly LeaveManagementSystemEntities LMS;

        public LeaveRequests()
        {
            InitializeComponent();
            LMS = new LeaveManagementSystemEntities();

        }

        private void LeaveRequests_Load(object sender, EventArgs e)
        {
            var requests = LMS.ViewAll.Where(id => id.EmployeeID != "1234").ToList();
            dataGridView1.DataSource = requests;
        }
    }
}
