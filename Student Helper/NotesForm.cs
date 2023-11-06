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
        public static bool resetBool = false, addBool = false, editBool = false;

        public NotesForm()
        {
            alamat = "server=localhost; database=helperdb; username=root; password=;";
            koneksi = new MySqlConnection(alamat);
            InitializeComponent();
        }

        private void NotesForm_Load(object sender, EventArgs e)
        {
            currentNotes();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Check for resets
            if (resetBool == true)
            {
                NotesContainer.Controls.Clear();
                currentNotes();
                resetBool = false;
            }
            
            //Check for adds
            if (addBool == true)
            {
                AddNote addNote = new AddNote();
                addNote.Show();
                addBool = false;
            }

            //Check for edits
            if (editBool == true)
            {
                EditNote editNote = new EditNote();
                editNote.Show();
                editBool = false;
            }
        }


        public void currentNotes()
        {
            UserControlAddNote UCAddNote = new UserControlAddNote();
            NotesContainer.Controls.Add(UCAddNote);

            if (koneksi.State != ConnectionState.Open)
            {
                koneksi.Open();
            }
            try
            {
                // Kode sebelumnya untuk mengambil judul catatan terbaru dari database
                query = "SELECT COUNT(ID) FROM notes;";
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);

                using (MySqlDataReader reader = perintah.ExecuteReader())
                {
                    // Jika ada data yang dapat dibaca
                    if (reader.Read())
                    {
                        id = reader["Count(ID)"].ToString();
                    }
                    reader.Dispose();
                    perintah.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            for (int i = 0; i <= Convert.ToInt32(id) - 1; i++)
            {
                UserControlNewNote newNotes = new UserControlNewNote();
                newNotes.displayJudulFromIndex(i);
                NotesContainer.Controls.Add(newNotes);
            }
        }

        //Manual Refresh
        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            NotesContainer.Controls.Clear();
            currentNotes();
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
    }  
}
