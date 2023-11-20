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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LMS_Desktop
{
    public partial class LookupLeave : Form
    {
        private readonly LeaveManagementSystemEntities4 LMS;
        private string query = "id => id.EmployeeID == \"1234\"";
        LoadFromDatabase database;
        string type;
        string status;
        string today = string.Empty;
        string tomorrow = string.Empty;
        public LookupLeave()
        {
            InitializeComponent();
            LMS = new LeaveManagementSystemEntities4();
            database = new LoadFromDatabase();
        }
        
        private void LookupLeave_Load(object sender, EventArgs e)
        {
            textcode();
            var type = LMS.LeaveTypes.ToList();
            LeaveTypeCobx.DisplayMember = "Type";
            LeaveTypeCobx.ValueMember = "id";
            LeaveTypeCobx.DataSource = type;

            var status = LMS.LeaveStatus.ToList();
            LeaveStatusCobx.DisplayMember = "status";
            LeaveStatusCobx.ValueMember = "id";
            LeaveStatusCobx.DataSource = status;
            sdate.MinDate = DateTime.Now.AddYears(-10);
            sdate.Value = DateTime.Now.AddYears(-9);
        }

        private void LeaveTypeCobx_SelectedIndexChanged(object sender, EventArgs e)
        {
            textcode();
        }

        private void LeaveStatusCobx_SelectedIndexChanged(object sender, EventArgs e)
        {
            textcode();

        }

        private void sdate_ValueChanged(object sender, EventArgs e)
        {
            textcode();
        }

        private void edate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void clearbtn_Click(object sender, EventArgs e)
        {

        }

        private void textcode()
        {
            type = LeaveTypeCobx.Text;
            status = LeaveStatusCobx.Text;
            if (type == "Select a Leave Type")
                type = string.Empty;
            if (status == "Select Status")
                status = string.Empty;

            SqlConnection conn = new SqlConnection(database.connection);
            conn.Open();
            SqlCommand cmd = new SqlCommand("Filters", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@EmpID", "1234");
            cmd.Parameters.AddWithValue("@StartDate", sdate.Value.ToShortDateString());
            cmd.Parameters.AddWithValue("@type", type);
            cmd.Parameters.AddWithValue("@status", status);
            
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["id"].HeaderText = "#";
            dataGridView1.Columns["EmployeeID"].HeaderText = "ID";
            dataGridView1.Columns["type"].HeaderText = "Type";
            dataGridView1.Columns["SubmissionDate"].HeaderText = "Submission Date";
            dataGridView1.Columns["StartDate"].HeaderText = "Start Date";
            dataGridView1.Columns["EndDate"].HeaderText = "End Date";
            dataGridView1.Columns["TotalDays"].HeaderText = "Days";
            dataGridView1.Columns["Status"].HeaderText = "Status";
            dataGridView1.Columns["gender"].Visible = false;
            dataGridView1.Columns["gender"].Visible = false;
            dataGridView1.Columns["comments"].Visible = false;
            dataGridView1.Columns["reason"].Visible = false;
        }
    }
}
