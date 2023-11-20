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
    public partial class ManageUsers : Form
    {
        private readonly LeaveManagementSystemEntities4 LMS;
        public ManageUsers()
        {
            InitializeComponent();
            LMS = new LeaveManagementSystemEntities4();
        }

        private void ManageUsers_Load(object sender, EventArgs e)
        {
            var data = LMS.ViewEmployees.ToList();
            dataGridView1.DataSource = data;
        }
    }
}
