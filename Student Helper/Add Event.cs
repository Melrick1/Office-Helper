using MySql.Data.MySqlClient;
using System;
using System.Collections;
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
    public partial class Add_Event : Form
    {
        String conn = "server=localhost; database=helperdb; username=root; password=;";
        public Add_Event()
        {
            InitializeComponent();
        }
        private void Add_Event_Load(object sender, EventArgs e)
        {
            DateTxt.Text = UserControlDay.currentDay + "-" + CalendarForm.currentMonth + "-" + CalendarForm.currentYear;
        }

        private void AddEvent_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection();
            conn.Open();
            string sql = string.Format("Insert into event_date (date,event) values('{0}', '{1}')", DateTxt.Text, EventTxt.Text);
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Saved");
            cmd.Dispose();
            conn.Close();
        }
    }
}
