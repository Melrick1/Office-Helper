using MySql.Data.MySqlClient;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Student_Helper
{
    public partial class TabNotes : UserControl
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;

        private string id;
        private string alamat, query;
        public static bool resetBool = false, trashBool = false;
        public TabNotes()
        {
            alamat = "server=localhost; database=helperdb; username=root; password=;";
            koneksi = new MySqlConnection(alamat);

            InitializeComponent();
        }

        private void TabNotes_Load(object sender, EventArgs e)
        {
            currentNotes();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Check for resets
            if (resetBool == true)
            {
                currentNotes();
                resetBool = false;
            }
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            foreach (Control item in NotesContainer.Controls)
            {
                item.Show();
                string search = SearchBox.Text.ToLower();
                string itemName = Convert.ToString(TypeDescriptor.GetProperties(item)["Name"].GetValue(item)).ToLower();

                bool found = itemName.Contains(search);

                if (found == false)
                {
                    item.Hide();
                }
            }
        }

        //Manual Refresh
        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            currentNotes();
        }

        private void SelectCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (SelectCheckBox.Checked != false)
            {
                foreach (Control item in NotesContainer.Controls)
                {
                    item.BackColor = Color.DimGray;
                }
                return;
            }

            foreach (Control item in NotesContainer.Controls)
            {
                    item.BackColor = Color.Transparent;
            } 
        }

        private void TrashBtn_Click(object sender, EventArgs e)
        {
            foreach (Control item in NotesContainer.Controls)
            {
                if (item.BackColor == Color.DimGray)
                {
                    string itemName = (TypeDescriptor.GetProperties(item)["Name"].GetValue(item)).ToString();
                    Delete(itemName);
                }
            }
            currentNotes();
        }

        //Display current available notes
        public void currentNotes()
        {
            NotesContainer.Controls.Clear();    //Clear Container
            UserControlNoteAdd UCAddNote = new UserControlNoteAdd();    //Insert the "Add Button" into Container
            NotesContainer.Controls.Add(UCAddNote);

            if (koneksi.State != ConnectionState.Open)
            {
                koneksi.Open();
            }
            try
            {
                query = "SELECT COUNT(ID) FROM notes;";
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);

                using (MySqlDataReader reader = perintah.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        id = reader["Count(ID)"].ToString();
                    }
                    reader.Dispose();
                    perintah.Dispose();
                }
            }
            finally
            {
                koneksi.Close();
            }

            for (int i = 0; i <= Convert.ToInt32(id) - 1; i++)
            {
                UserControlNoteNew newNotes = new UserControlNoteNew();
                newNotes.displayJudulFromIndex(i);
                newNotes.IDFromIndex(i);
                NotesContainer.Controls.Add(newNotes);
            }
        }

        public void Delete(string name)
        {
            if (koneksi.State != ConnectionState.Open)
            {
                koneksi.Open();
            }
            try
            {
                query = string.Format("Delete from notes where judul = '{0}'", name);
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                int res = perintah.ExecuteNonQuery();
            }
            finally
            {
                koneksi.Close();
            }
        }
    }
}
