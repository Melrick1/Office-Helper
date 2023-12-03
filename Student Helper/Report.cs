using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Student_Helper
{
    public partial class Report : Form
    {

        public Report()
        {
            InitializeComponent();
            this.Resize += YourForm_Resize;
        }

        private void YourForm_Resize(object sender, EventArgs e)
        {
            // Check if the form is maximized
            if (this.WindowState == FormWindowState.Maximized)
            {
                // Make the panel fullscreen
                pnl_child.Dock = DockStyle.Fill;
            }
            else
            {
                // Restore the panel to its original size and location
                pnl_child.Dock = DockStyle.None;
                pnl_child.Size = new System.Drawing.Size(300, 200); // Adjust the size as needed
                pnl_child.Location = new System.Drawing.Point(10, 10); // Adjust the location as needed
            }
        }

        private Form activeForm = null;
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnl_child.Controls.Add(childForm);
            pnl_child.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void Back_Click(object sender, EventArgs e)
        {
            FormAdmin admin = new FormAdmin();
            admin.Show();
            this.Hide();
            return;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Report_Load(object sender, EventArgs e)
        {
            OpenChildForm(new report2());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
