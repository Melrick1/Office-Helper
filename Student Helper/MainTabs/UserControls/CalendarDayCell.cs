using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Student_Helper
{
    public partial class CalendarDayCell : UserControl
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;

        private string alamat, query;

        public static string Date;
        private int thisDay = DateTime.Now.Day;
        private int thisMonth = DateTime.Now.Month;
        private int thisYear = DateTime.Now.Year;

        public CalendarDayCell()
        {
            alamat = "server=localhost; database=helperdb; username=root; password=;";
            koneksi = new MySqlConnection(alamat);

            InitializeComponent();
        }

        private void UserControlDay_Load(object sender, EventArgs e)
        {
            //Convert string to int
            calendarDisplayEvent(Convert.ToInt32(labelDay.Text));

            //Show Today
            if (labelDay.Text == thisDay.ToString() && 
                TabCalendar.currentMonth == thisMonth && 
                TabCalendar.currentYear == thisYear)
            {
                this.BackColor = Color.Gold;
            }

            //Timer to check for updates
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Timer for updates
            calendarDisplayEvent(Convert.ToInt32(labelDay.Text));
        }

        //Label Day
        public void days(int numDay)
        {
            labelDay.Text = numDay.ToString();
        }

        //Control Click
        private void UserControlDay_Click(object sender, EventArgs e)
        {
            Date = labelDay.Text;
            Add_Event addEventFrm = new Add_Event();
            addEventFrm.Show();
        }

        private void EventLbl_Click(object sender, EventArgs e)
        {
            Date = labelDay.Text;
            Add_Event addEventFrm = new Add_Event();
            addEventFrm.Show();
        }

        //Date Display
        public void calendarDisplayEvent(int numDay)
        {
            if (koneksi.State != ConnectionState.Open)
            {
                koneksi.Open();
            }
            try
            {
                query = string.Format("Select event from event_date where Date = '{0}'", numDay + "-" + TabCalendar.currentMonth + "-" + TabCalendar.currentYear);
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                MySqlDataReader reader = perintah.ExecuteReader();

                //if Readable(bool=true) then display EventText from database
                if (reader.Read())
                {
                    EventLbl.Text = reader["Event"].ToString();
                }
                //else then display empty
                else
                {
                    EventLbl.Text = "";
                }
                reader.Dispose();
                perintah.Dispose();
                koneksi.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
