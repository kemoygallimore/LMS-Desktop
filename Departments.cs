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
    public partial class Departments : Form
    {
        private readonly LeaveManagementSystemEntities LMS;
        public Departments()
        {
            InitializeComponent();
            LMS = new LeaveManagementSystemEntities();
        }

        private void Departments_Load(object sender, EventArgs e)
        {
            /*var dept = LMS.Departments.ToList();
            dataGridView1.DataSource = dept;*/
        }
    }
}
