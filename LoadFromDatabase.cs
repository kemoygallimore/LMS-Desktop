using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS_Desktop
{
    internal class LoadFromDatabase
    {
        public string connection = " data source=kemoyslenovo\\SQLEXPRESS;initial catalog=LeaveManagementSystem;integrated Security=true";
        LeaveManagementSystemEntities4 LMS = new LeaveManagementSystemEntities4();

        public LoadFromDatabase() { }

        public void LoadAllRequests(DataGridView gridView)
        {
            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("Select * from ViewAll order by SubmissionDate DESC", con))
                {
                    SqlDataReader dr = cmd.ExecuteReader();
                    gridView.DataSource = dr;
                    //gridView.DataBind();
                }
            }
        }
        public void LoadAllStaff(DataGridView gv, string id)
        {
            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("Select * from ViewAll where EmployeeID <> @EmployeeID order by SubmissionDate DESC ", con))
                {
                    cmd.Parameters.AddWithValue("@EmployeeID", id);
                    SqlDataReader dr = cmd.ExecuteReader();
                    gv.DataSource = dr;
                    //gv.DataBind();
                }
            }
        }
        public void LoadEmployeeRequests(DataGridView gv, string lbl)
        {
            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("Select * from ViewAll where EmployeeID = @EmployeeID order by SubmissionDate DESC ", con))
                {
                    cmd.Parameters.AddWithValue("@EmployeeID", lbl);
                    SqlDataReader dr = cmd.ExecuteReader();
                    gv.DataSource = dr;
                    //gv.DataBind();
                }
            }
        }
        public void LoadType(ComboBox type)
        {
            var load = LMS.LeaveTypes.ToList();
            type.DisplayMember = "Type";
            type.ValueMember = "id";
            type.DataSource = load;
        }
        public void LoadStatus(ComboBox status)
        {
            var load = LMS.LeaveStatus.ToList();
            status.DisplayMember = "status";
            status.ValueMember = "id";
            status.DataSource = load;
        }



    }
}
