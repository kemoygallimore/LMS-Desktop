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
    public partial class PopError : Form
    {
        public PopError()
        {
            InitializeComponent();
        }
        public PopError(string title, string error)
        {
            InitializeComponent();
            Title.Text = title;
            ErrorText.Text = error;
        }

        private void PopError_Load(object sender, EventArgs e)
        {

        }
    }
}
