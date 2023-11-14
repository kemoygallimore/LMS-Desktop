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
    public partial class Parent : Form
    {
        public Parent()
        {
            InitializeComponent();
        }

        private void lookupLeaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LookupLeave lookup = new LookupLeave();
            lookup.MdiParent = this;
            lookup.Dock = DockStyle.Fill;
            lookup.Show();
        }

        private void leaveRequestsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LeaveRequests leaveRequests = new LeaveRequests();
            leaveRequests.MdiParent = this;
            leaveRequests.Dock = DockStyle.Fill;
            leaveRequests.Show();
        }

        private void cancelLeaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CancelLeave cancelLeave = new CancelLeave();
            cancelLeave.MdiParent = this;
            cancelLeave.Dock = DockStyle.Fill;
            cancelLeave.Show();
        }

        private void departmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Departments departments = new Departments();
            departments.ShowDialog();
        }

        private void roleTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RoleAccess role = new RoleAccess();
            role.ShowDialog();
        }

        private void manageUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageUsers manageUsers = new ManageUsers();
            manageUsers.MdiParent= this;
            manageUsers.Dock = DockStyle.Fill;
            manageUsers.Show();
        }

        private void submitLeaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LeaveSubmission leaveSubmission = new LeaveSubmission();
            leaveSubmission.ShowDialog();
        }
    }
}
