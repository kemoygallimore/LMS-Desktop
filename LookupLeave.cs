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
        private readonly LeaveManagementSystemEntities LMS;
        private string query = "id => id.EmployeeID == \"1234\"";
        LoadFromDatabase database;
        string type;
        string status;
        string today = string.Empty;
        string tomorrow = string.Empty;
        public LookupLeave()
        {
            InitializeComponent();
            LMS = new LeaveManagementSystemEntities();
            database = new LoadFromDatabase();
        }
        private void Loadup()
        {
            var requests = LMS.ViewAll.Where(id => id.EmployeeID == "1234").ToList();
            dataGridView1.DataSource = requests;
            dataGridView1.Columns["id"].HeaderText = "#";
            dataGridView1.Columns["EmployeeID"].HeaderText = "ID";
            dataGridView1.Columns["Full_Name"].HeaderText = "Full Name";
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
        
        private void LookupLeave_Load(object sender, EventArgs e)
        {
            
            Loadup();
            var type = LMS.LeaveTypes.ToList();
            LeaveTypeCobx.DisplayMember = "Type";
            LeaveTypeCobx.ValueMember = "id";
            LeaveTypeCobx.DataSource = type;

            var status = LMS.LeaveStatus.ToList();
            LeaveStatusCobx.DisplayMember = "status";
            LeaveStatusCobx.ValueMember = "id";
            LeaveStatusCobx.DataSource = status;
            edate.MaxDate = DateTime.Now.AddYears(5);
            edate.Value = DateTime.Now.AddYears(5);
            sdate.MinDate = DateTime.Now.AddYears(-10);
            sdate.Value = DateTime.Now.AddYears(-10);
        }

        private void LeaveTypeCobx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(LeaveTypeCobx.SelectedIndex==0)
            {
                Loadup();
            }
            else
            {
                today = sdate.Value.ToShortDateString();
                tomorrow = edate.Value.ToShortDateString();
                type = LeaveTypeCobx.Text;
                status = LeaveStatusCobx.Text;
                if (type == "Select a Leave Type")
                    type = string.Empty;
                if (status == "Select Status")
                    status = string.Empty;
                
                SqlConnection conn = new SqlConnection(database.connection);
                conn.Open();
                SqlCommand cmd = new SqlCommand("FilterbyAllFields", conn);                
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EmpID", "1234");
                cmd.Parameters.AddWithValue("@type", type);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@StartDate", "fire");
                cmd.Parameters.AddWithValue("@EndDate","ice");
                SqlDataReader reader = cmd.ExecuteReader();
                dataGridView1.DataSource = reader;
                    //leaveRequestGV.DataBind();
                

                /*var requests = LMS.ViewAll.Where(id => id.EmployeeID == "1234" && id.type == LeaveTypeCobx.Text

            ).ToList();
                dataGridView1.DataSource = requests;













                dataGridView1.Columns["id"].HeaderText = "#";
                dataGridView1.Columns["EmployeeID"].HeaderText = "ID";
                dataGridView1.Columns["Full_Name"].HeaderText = "Full Name";
                dataGridView1.Columns["type"].HeaderText = "Type";
                dataGridView1.Columns["SubmissionDate"].HeaderText = "Submission Date";
                dataGridView1.Columns["StartDate"].HeaderText = "Start Date";
                dataGridView1.Columns["EndDate"].HeaderText = "End Date";
                dataGridView1.Columns["TotalDays"].HeaderText = "Days";
                dataGridView1.Columns["Status"].HeaderText = "Status";
                dataGridView1.Columns["gender"].Visible = false;
                dataGridView1.Columns["gender"].Visible = false;
                dataGridView1.Columns["comments"].Visible = false;
                dataGridView1.Columns["reason"].Visible = false;*/
            }
            
        }

        private void LeaveStatusCobx_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void sdate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void clearbtn_Click(object sender, EventArgs e)
        {

        }
    }
}
