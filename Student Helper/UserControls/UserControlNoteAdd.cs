using System;
using System.Drawing;
using System.Windows.Forms;

namespace Student_Helper
{
    public partial class UserControlNoteAdd : UserControl
    {
        public UserControlNoteAdd()
        {
            InitializeComponent();
        }

        private void UserControlAddNote_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.DimGray;
            TabNotes.addBool = true;
        }

        private void NoteLbl_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.DimGray;
            TabNotes.addBool = true;
        }
    }
}
