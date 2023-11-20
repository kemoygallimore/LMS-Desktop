namespace LMS_Desktop
{
    partial class PopError
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ErrorText = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.ErrorText, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Title, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.54589F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.45411F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(348, 207);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ErrorText
            // 
            this.ErrorText.AutoSize = true;
            this.ErrorText.Location = new System.Drawing.Point(13, 87);
            this.ErrorText.Name = "ErrorText";
            this.ErrorText.Size = new System.Drawing.Size(179, 13);
            this.ErrorText.TabIndex = 1;
            this.ErrorText.Text = "This is will be the error mess displyed";
            // 
            // Title
            // 
            this.Title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Arial", 20F);
            this.Title.Location = new System.Drawing.Point(142, 32);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(64, 32);
            this.Title.TabIndex = 0;
            this.Title.Text = "Title";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PopError
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 207);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PopError";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PopError";
            this.Load += new System.EventHandler(this.PopError_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label ErrorText;
        private System.Windows.Forms.Label Title;
    }
}