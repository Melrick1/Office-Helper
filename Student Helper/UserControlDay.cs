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
    public partial class UserControlDay : UserControl
    {
        String conn = "server=localhost; database=helperdb; username=root; password=;";

        public static string currentDay;
        public UserControlDay()
        {
            InitializeComponent();
        }
        private void UserControlDay_Load(object sender, EventArgs e)
        {

        }

        public void days(int numday)
        {
            labelDay.Text = numday + "";
        }

        private void UserControlDay_Click(object sender, EventArgs e)
        {
            currentDay = labelDay.Text;
            Add_Event EventFrm = new Add_Event();
            timer1.Start();
            EventFrm.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            displayEvent();
        }

        private void displayEvent()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection();
                conn.Open();
                string sql = string.Format("Select event from event_date where date = '{0}'", UserControlDay.currentDay + "-" + CalendarForm.currentMonth + "-" + CalendarForm.currentYear);
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Saved");
                cmd.Dispose();
                conn.Close();
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    EventLbl.Text = reader["event"].ToString();
                }
                reader.Dispose();
                cmd.Dispose();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
