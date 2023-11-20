using LMS_Desktop.Custom_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LMS_Desktop
{
    public partial class LeaveRequests : Form
    {
        private readonly LeaveManagementSystemEntities4 LMS;
        private LoadFromDatabase load;
        string type;
        string status;

        public LeaveRequests()
        {
            InitializeComponent();
            LMS = new LeaveManagementSystemEntities4();
            load = new LoadFromDatabase();
        }

        private void LeaveRequests_Load(object sender, EventArgs e)
        {
            Filter();
            load.LoadStatus(LeaveStatusCobx);
            load.LoadType(leavetypeCobx);
        }

        private void Filter()
        {            
            sdate.Value = DateTime.Now.AddMonths(-2);            

            type = leavetypeCobx.Text;
            status = LeaveStatusCobx.Text;
            if (type == "Select a Leave Type")
                type = string.Empty;
            if (status == "Select Status")
                status = string.Empty;

            SqlConnection conn = new SqlConnection(load.connection);
            conn.Open();
            SqlCommand cmd = new SqlCommand("LeaveRequestFilters", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.AddWithValue("@EmpID", "1234");
            cmd.Parameters.AddWithValue("@SubmissionDate", sdate.Value.ToShortDateString());
            cmd.Parameters.AddWithValue("@type", type);
            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@staff", Nametxtbx.Text);
           
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["id"].HeaderText = "#";
            dataGridView1.Columns["EmployeeID"].HeaderText = "ID";
            dataGridView1.Columns["type"].HeaderText = "Type";
            dataGridView1.Columns["SubmissionDate"].HeaderText = "Submission Date";
            //dataGridView1.Columns["FullName"].HeaderText = "Full Name";
            dataGridView1.Columns["StartDate"].HeaderText = "Start Date";
            dataGridView1.Columns["EndDate"].HeaderText = "End Date";
            dataGridView1.Columns["TotalDays"].HeaderText = "Days";
            dataGridView1.Columns["Status"].HeaderText = "Status";
            dataGridView1.Columns["gender"].Visible = false;
            dataGridView1.Columns["comments"].Visible = false;
            dataGridView1.Columns["reason"].Visible = false;
        }

        private void Applybtn_Click(object sender, EventArgs e)
        {
            Filter();
        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            EmpIDtxtbx.Clear();
            Nametxtbx.Clear();
            load.LoadStatus(LeaveStatusCobx);
            load.LoadType(leavetypeCobx);
            Filter();

        }
    }
}
