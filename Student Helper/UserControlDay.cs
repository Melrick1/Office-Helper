using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Helper
{
    public partial class UserControlDay : UserControl
    {
        public UserControlDay()
        {
            InitializeComponent();
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {

        }

        public void days(int numday)
        {
            labelDay.Text = numday + "";
        }

        private void labelDay_Click(object sender, EventArgs e)
        {

        }
    }
}
