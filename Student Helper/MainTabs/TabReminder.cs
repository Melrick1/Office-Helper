using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Student_Helper
{
    public partial class TabReminder : UserControl
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;

        private DataSet ds1 = new DataSet();
        private DataSet ds2 = new DataSet();
        private DataSet ds3 = new DataSet();
        private string alamat, query;
        public TabReminder()
        {
            alamat = "server=localhost; database=helperdb; username=root; password=;";
            koneksi = new MySqlConnection(alamat);

            InitializeComponent();
        }

        private void TabReminder_Load(object sender, EventArgs e)
        {
            try
            {
                koneksi.Open();

                query = string.Format("select * from list");
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                perintah.ExecuteNonQuery();
                ds1.Clear();
                adapter.Fill(ds1);
                koneksi.Close();

                dataToDo.DataSource = ds1.Tables[0];
                dataToDo.Columns[0].Width = 50;
                dataToDo.Columns[0].HeaderText = "Title";
                dataToDo.Columns[1].Width = 100;
                dataToDo.Columns[1].HeaderText = "Description";
                dataToDo.Columns[2].Width = 100;
                dataToDo.Columns[2].HeaderText = "Due-Date";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            try
            {
                koneksi.Open();

                query = string.Format("select * from event_date");
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                perintah.ExecuteNonQuery();
                ds2.Clear();
                adapter.Fill(ds2);
                koneksi.Close();

                DataCalendar.DataSource = ds2.Tables[0];
                DataCalendar.Columns[0].Width = 50;
                DataCalendar.Columns[0].HeaderText = "Date";
                DataCalendar.Columns[1].Width = 100;
                DataCalendar.Columns[1].HeaderText = "Event";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            RecentNotes();
        }

        //Display current available notes
        public void RecentNotes()
        {
            if (koneksi.State != ConnectionState.Open)
            {
                koneksi.Open();
            }
            try
            {
                query = "SELECT * FROM notes;";
                ds3.Clear();
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                perintah.ExecuteNonQuery();
                adapter.Fill(ds3);
                if (ds3.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow column in ds3.Tables[0].Rows)
                    {
                        string DateCreated, Title;
                        DateCreated = column["tanggal"].ToString();
                        Title = column["judul"].ToString();

                        //DateTime to string
                        DateTime DateStr = DateTime.Parse(DateCreated);

                        //timeDiff = Today - Date created
                        TimeSpan timeDiff = DateTime.Now - DateStr;

                        //max required time : 168 Hours, 0 mins, 0 Secs
                        TimeSpan maxTime = new TimeSpan(168, 0, 0); 

                        //if timeDiff < max required time, then : It is recent
                        if(timeDiff < maxTime)
                        {
                            UserControlNoteNew newNotes = new UserControlNoteNew();
                            newNotes.selectfromJudul(Title);
                            NotesContainer.Controls.Add(newNotes);
                        }
                    }
                }
            }
            finally
            {
                koneksi.Close();
            }
        }
    }
}
