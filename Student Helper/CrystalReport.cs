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
    public partial class CrystalReport : Form
    {
        public CrystalReport()
        {
            InitializeComponent();
        }

        private void crystalReportViewer2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CrystalReport11.SetParameterValue("Title", textBox1.Text);
            crystalReportViewer1.ReportSource = CrystalReport11;
            crystalReportViewer1.Refresh();
        }

        private void CrystalReport_Load(object sender, EventArgs e)
        {

        }
    }
}
