﻿using System;
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
        private readonly LeaveManagementSystemEntities LMS;
        public CancelLeave()
        {
            InitializeComponent();
            LMS = new LeaveManagementSystemEntities();
        }

        private void CancelLeave_Load(object sender, EventArgs e)
        {
            var data = LMS.ViewAll.ToList();
            dataGridView1.DataSource = data;
            dataGridView1.Columns["reason"].Visible = false;
        }
    }
}
