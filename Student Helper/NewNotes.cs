using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Helper
{
    public partial class NewNotes : UserControl
    {
        private string title;

 
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;

        private string alamat, query;

        public static DateTime ToDate = DateTime.Now;

        public NewNotes()
        {
            alamat = "server=localhost; database=helperdb; username=root; password=;";
            koneksi = new MySqlConnection(alamat);
            InitializeComponent();
        }
   

        private void NewNotes_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            displayJudul();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void displayJudul()
        {
            if (koneksi.State != ConnectionState.Open)
            {
                koneksi.Open();
            }

            try
            {
                // Kode sebelumnya untuk mengambil judul catatan terbaru dari database
                query = "SELECT judul FROM notes ORDER BY id DESC LIMIT 2";
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);

                using (MySqlDataReader reader = perintah.ExecuteReader())
                {
                    // Jika ada data yang dapat dibaca
                    if (reader.Read())
                    {
                        title = reader["judul"].ToString();
                    }
                    else
                    {
                        title = "New Notes";
                    }
                }

                NoteLbl.Text = title;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                // Pastikan selalu menutup koneksi, terlepas dari apapun yang terjadi
                koneksi.Close();
            }
        }



    }
}

