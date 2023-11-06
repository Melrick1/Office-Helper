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
    public partial class Add_Notes : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;

        private string alamat, query;
        public static DateTime ToDate = DateTime.Now;

        public Add_Notes(string noteTitle)
        {
            // Inisialisasi form dan lakukan logika yang sesuai
            // Gunakan noteTitle sesuai kebutuhan Anda
        }


        public Add_Notes()
        {
            alamat = "server=localhost; database=helperdb; username=root; password=;";
            koneksi = new MySqlConnection(alamat);
            InitializeComponent();
        }

        private void Add_Notes_Load(object sender, EventArgs e)
        {

        }

        private void AddEvent_Click(object sender, EventArgs e)
        {
            if (koneksi.State != ConnectionState.Open)
            {
                koneksi.Open();
            }
            try
            {
                query = string.Format("insert into notes (judul, tanggal) values ('{0}', '{1}')",NewNotesTxt.Text, ToDate);
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                int res = perintah.ExecuteNonQuery();
                koneksi.Close();
                if (res == 1)
                {
                    MessageBox.Show("Insert data berhasil");
                    Add_Notes_Load(null, null);
                }
                else
                {
                    MessageBox.Show("Insert data gagal");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            NotesForm.resetBool = true;
            this.Close();
        }
    }
}
