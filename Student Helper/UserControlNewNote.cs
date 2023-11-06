﻿using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Helper
{
    public partial class UserControlNewNote : UserControl
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;

        private string alamat, query;

        public static string Title;
        public UserControlNewNote()
        {
            alamat = "server=localhost; database=helperdb; username=root; password=;";
            koneksi = new MySqlConnection(alamat);
            InitializeComponent();
        }
   

        private void NewNotes_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.DimGray;
            NotesForm.editBool = true;
        }

        private void NoteLbl_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.DimGray;
            NotesForm.editBool = true;
        }

        public void displayJudulFromIndex(int index)
        {
            if (koneksi.State != ConnectionState.Open)
            {
                koneksi.Open();
            }
            try
            {
                // Kode sebelumnya untuk mengambil judul catatan terbaru dari database
                query = string.Format("SELECT judul FROM notes limit 1 offset {0}", index);
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);

                MySqlDataReader reader = perintah.ExecuteReader();
                {
                    // Jika ada data yang dapat dibaca
                    if (reader.Read())
                    {
                        Title = reader["judul"].ToString();
                    }
                    else
                    {
                        Title = "New Notes";
                    }
                }

                NoteLbl.Text = Title;
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
