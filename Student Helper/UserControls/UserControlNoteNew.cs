using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace Student_Helper
{
    public partial class UserControlNoteNew : UserControl
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;

        private string alamat, query;

        string Title, ID;
        public static bool boolTrash = false;
        public UserControlNoteNew()
        {
            alamat = "server=localhost; database=helperdb; username=root; password=;";
            koneksi = new MySqlConnection(alamat);

            InitializeComponent();
        }

        private void NewNotes_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Transparent;
            TitleBox.BackColor = Color.Gray;
            TitleBox.ReadOnly = true;
        }

        //Select
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (this.BackColor == Color.Transparent) {
                this.BackColor = Color.DimGray;
                TitleBox.BackColor = Color.DimGray;
            }
            else
            {
                this.BackColor = Color.Transparent;
                TitleBox.BackColor = Color.Gray;
            }
        }

        //Renaming Title
        private void TitleBox_DoubleClick(object sender, EventArgs e)
        {
            TitleBox.BorderStyle = BorderStyle.FixedSingle;
            TitleBox.BackColor = Color.White;
            TitleBox.ReadOnly = false;
        }

        //Update SQL when losing focus on component
        private void TitleBox_Leave(object sender, EventArgs e)
        {
            TitleBox.BorderStyle = BorderStyle.None;
            TitleBox.BackColor = Color.Gray;
            TitleBox.ReadOnly = true;
            Title = TitleBox.Text;
            this.Name = Title;

            if (koneksi.State != ConnectionState.Open)
            {
                koneksi.Open();
            }
            try
            {
                query = string.Format("update notes set judul = '{0}' where id = '{1}' ", Title, ID);
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                int res = perintah.ExecuteNonQuery();
            }
            finally
            {
                koneksi.Close();
            }
        }

        //Update SQL when pressing Enter
        private void TitleBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TitleBox_Leave(null,null);
            }
        }

        //Getting Title
        public void displayJudulFromIndex(int index)
        {
            if (koneksi.State != ConnectionState.Open)
            {
                koneksi.Open();
            }
            try
            {
                query = string.Format("SELECT judul FROM notes limit 1 offset {0}", index);
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);

                MySqlDataReader reader = perintah.ExecuteReader();
                {
                    if (reader.Read())
                    {
                        Title = reader["judul"].ToString();
                    }
                    else
                    {
                        Title = "New Notes";
                    }
                }
                this.Name = Title;
                TitleBox.Text = Title;
            }
            finally
            {
                koneksi.Close();
            }
        }

        //Getting ID
        public void IDFromIndex(int index)
        {
            if (koneksi.State != ConnectionState.Open)
            {
                koneksi.Open();
            }
            try
            {
                query = string.Format("SELECT ID FROM notes limit 1 offset {0}", index);
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);

                MySqlDataReader reader = perintah.ExecuteReader();
                {
                    if (reader.Read())
                    {
                        ID = reader["ID"].ToString();
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

