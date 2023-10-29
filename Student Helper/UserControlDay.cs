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
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;

        private DataSet ds = new DataSet();
        private string alamat, query;

        public static string currentDay;
        public UserControlDay()
        {
            alamat = "server=localhost; database=helperdb; username=root; password=;";
            koneksi = new MySqlConnection(alamat);

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
            EventFrm.Show();
        }

        //Display Event
        public void displayEvent(int numday)
        {
            if (koneksi.State != ConnectionState.Open)
            {
                koneksi.Open();
            }
            try
            {
                query = string.Format("Select event from event_date where date = '{0}'", numday + "-" + CalendarForm.currentMonth + "-" + CalendarForm.currentYear);
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                MySqlDataReader reader = perintah.ExecuteReader();

                while (reader.Read())
                {
                    EventLbl.Text = reader["Event"].ToString();
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
