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

        private void userControlAddNote_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AddNote addNote = new AddNote();
            addNote.Show();
        }

        private void NoteLbl_Click(object sender, EventArgs e)
        {
            AddNote addNote = new AddNote();
            addNote.Show();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.DimGray;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.Transparent;
        }
    }
}
