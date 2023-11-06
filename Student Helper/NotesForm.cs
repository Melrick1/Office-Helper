using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Helper
{
    public partial class NotesForm : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;

        private string id;
        private string alamat, query;
        public NotesForm()
        {
            alamat = "server=localhost; database=helperdb; username=root; password=;";
            koneksi = new MySqlConnection(alamat);
            InitializeComponent();
        }

        private void NotesForm_Load(object sender, EventArgs e)
        {
            if (koneksi.State != ConnectionState.Open)
            {
                koneksi.Open();
            }
            try
            {
                // Kode sebelumnya untuk mengambil judul catatan terbaru dari database
                query = "SELECT id FROM notes ORDER BY id DESC LIMIT 1";
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);

                using (MySqlDataReader reader = perintah.ExecuteReader())
                {
                    // Jika ada data yang dapat dibaca
                    if (reader.Read())
                    {
                        id = reader["id"].ToString();
                    }
                    else
                    {
                        id = "New Notes";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            for (int i = 1; i <= Convert.ToInt32(id); i++)
            {

            }
        }

        //Main Menu Buttons
        private void buttonSchedule_Click(object sender, EventArgs e)
        {
            this.Hide();
            ScheduleForm ScheduleForm = new ScheduleForm();
            ScheduleForm.Show();
        }

        private void buttonReminder_Click(object sender, EventArgs e)
        {
            this.Hide();
            NotesForm NotesForm = new NotesForm();
            NotesForm.Show();
        }

        private void buttonToDo_Click(object sender, EventArgs e)
        {
            this.Hide();
            ToDoForm ToDoForm = new ToDoForm();
            ToDoForm.Show();
        }

        private void buttonNotes_Click(object sender, EventArgs e)
        {
            this.Hide();
            NotesForm NotesForm = new NotesForm();
            NotesForm.Show();
        }

        private void buttonCalendar_Click(object sender, EventArgs e)
        {
            this.Hide();
            CalendarForm CalendarForm = new CalendarForm();
            CalendarForm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Add_Notes add_Notes = new Add_Notes();
            add_Notes.Show();
            NewNotes newNotes = new NewNotes();
            NotesContainer.Controls.Add(newNotes);
        }
    }  
}
