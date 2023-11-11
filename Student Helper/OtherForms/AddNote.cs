using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Student_Helper
{
    public partial class AddNote : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;

        private string alamat, query;

        public static DateTime toDate = DateTime.Now;

        public AddNote()
        {
            alamat = "server=localhost; database=helperdb; username=root; password=;";
            koneksi = new MySqlConnection(alamat);
            InitializeComponent();
        }

        private void AddNote_Load(object sender, EventArgs e)
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
                query = string.Format("insert into notes (judul, tanggal) values ('{0}', '{1}')", AddNoteTxt.Text, toDate);
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                int res = perintah.ExecuteNonQuery();
                koneksi.Close();
                if (res == 1)
                {
                    MessageBox.Show("New Notes added");
                }
                else
                {
                    MessageBox.Show("Failed to add new notes");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            TabNotes.resetBool = true;
            this.Close();
        }
    }
}
