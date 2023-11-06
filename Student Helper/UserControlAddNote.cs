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
    public partial class UserControlAddNote : UserControl
    {
        public UserControlAddNote()
        {
            InitializeComponent();
        }

        private void UserControlAddNote_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.DimGray;
            NotesForm.addBool = true;
        }

        private void NoteLbl_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.DimGray;
            NotesForm.addBool = true;
        }
    }
}
