namespace LMS_Desktop
{
    partial class Parent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lookupLeaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leaveRequestsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelLeaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roleTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.submitLeaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submitLeaveToolStripMenuItem,
            this.lookupLeaveToolStripMenuItem,
            this.leaveRequestsToolStripMenuItem,
            this.cancelLeaveToolStripMenuItem,
            this.manageUsersToolStripMenuItem,
            this.departmentsToolStripMenuItem,
            this.roleTypesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lookupLeaveToolStripMenuItem
            // 
            this.lookupLeaveToolStripMenuItem.Name = "lookupLeaveToolStripMenuItem";
            this.lookupLeaveToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.lookupLeaveToolStripMenuItem.Text = "Lookup Leave";
            this.lookupLeaveToolStripMenuItem.Click += new System.EventHandler(this.lookupLeaveToolStripMenuItem_Click);
            // 
            // leaveRequestsToolStripMenuItem
            // 
            this.leaveRequestsToolStripMenuItem.Name = "leaveRequestsToolStripMenuItem";
            this.leaveRequestsToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.leaveRequestsToolStripMenuItem.Text = "Leave Requests";
            this.leaveRequestsToolStripMenuItem.Click += new System.EventHandler(this.leaveRequestsToolStripMenuItem_Click);
            // 
            // manageUsersToolStripMenuItem
            // 
            this.manageUsersToolStripMenuItem.Name = "manageUsersToolStripMenuItem";
            this.manageUsersToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.manageUsersToolStripMenuItem.Text = "Manage Users";
            this.manageUsersToolStripMenuItem.Click += new System.EventHandler(this.manageUsersToolStripMenuItem_Click);
            // 
            // cancelLeaveToolStripMenuItem
            // 
            this.cancelLeaveToolStripMenuItem.Name = "cancelLeaveToolStripMenuItem";
            this.cancelLeaveToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.cancelLeaveToolStripMenuItem.Text = "Cancel Leave";
            this.cancelLeaveToolStripMenuItem.Click += new System.EventHandler(this.cancelLeaveToolStripMenuItem_Click);
            // 
            // departmentsToolStripMenuItem
            // 
            this.departmentsToolStripMenuItem.Name = "departmentsToolStripMenuItem";
            this.departmentsToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.departmentsToolStripMenuItem.Text = "Departments";
            this.departmentsToolStripMenuItem.Click += new System.EventHandler(this.departmentsToolStripMenuItem_Click);
            // 
            // roleTypesToolStripMenuItem
            // 
            this.roleTypesToolStripMenuItem.Name = "roleTypesToolStripMenuItem";
            this.roleTypesToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.roleTypesToolStripMenuItem.Text = "Role Types";
            this.roleTypesToolStripMenuItem.Click += new System.EventHandler(this.roleTypesToolStripMenuItem_Click);
            // 
            // submitLeaveToolStripMenuItem
            // 
            this.submitLeaveToolStripMenuItem.Name = "submitLeaveToolStripMenuItem";
            this.submitLeaveToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.submitLeaveToolStripMenuItem.Text = "Submit Leave";
            this.submitLeaveToolStripMenuItem.Click += new System.EventHandler(this.submitLeaveToolStripMenuItem_Click);
            // 
            // Parent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Parent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parent";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lookupLeaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leaveRequestsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelLeaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roleTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem submitLeaveToolStripMenuItem;
    }
}