using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Student_Helper
{
    public partial class TabSchedule : UserControl
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;

        private DataSet ds = new DataSet();
        private string alamat, query;

        public TabSchedule()
        {
            alamat = "server=localhost; database=helperdb; username=root; password=;";
            koneksi = new MySqlConnection(alamat);

            InitializeComponent();
        }

        private void ScheduleTab_Load(object sender, EventArgs e)
        {
            try
            {
                koneksi.Open();

                query = string.Format("select * from schedule_table");
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                perintah.ExecuteNonQuery();
                ds.Clear();
                adapter.Fill(ds);
                koneksi.Close();

                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns[0].Width = 75;
                dataGridView1.Columns[0].HeaderText = "Monday";
                dataGridView1.Columns[1].Width = 75;
                dataGridView1.Columns[1].HeaderText = "Tuesday";
                dataGridView1.Columns[2].Width = 75;
                dataGridView1.Columns[2].HeaderText = "Wednesday";
                dataGridView1.Columns[3].Width = 75;
                dataGridView1.Columns[3].HeaderText = "Thursday";
                dataGridView1.Columns[4].Width = 75;
                dataGridView1.Columns[4].HeaderText = "Friday";
                dataGridView1.Columns[5].Width = 75;
                dataGridView1.Columns[5].HeaderText = "Saturday";
                dataGridView1.Columns[6].Width = 75;
                dataGridView1.Columns[6].HeaderText = "Sunday";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //Add
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //Insert (Only for new Rows)
            if (koneksi.State != ConnectionState.Open)
            {
                koneksi.Open();
            }
            try
            {
                query = string.Format("insert into schedule_table ({0}) values ('{1}')", Day.Text, ScheduleInput.Text);
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                int res = perintah.ExecuteNonQuery();
                koneksi.Close();
                if (res == 1)
                {
                    MessageBox.Show("Insert data berhasil");
                    ScheduleTab_Load(null, null);
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
        }

        //Update
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            //Update (If row exists)
            if (koneksi.State != ConnectionState.Open)
            {
                koneksi.Open();
            }
            try
            {
                query = string.Format("update schedule_table set {0} = '{1}' where {0}=''", Day.Text, ScheduleInput.Text);
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                perintah.ExecuteNonQuery();
                ds.Clear();
                adapter.Fill(ds);
                koneksi.Close();

                ScheduleTab_Load(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //Delete
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (koneksi.State != ConnectionState.Open)
            {
                koneksi.Open();
            }
            try
            {
                query = string.Format("update schedule_table set {0} = '' where {0} = '{1}'", Day.Text, ScheduleInput.Text);
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                perintah.ExecuteNonQuery();
                ds.Clear();
                adapter.Fill(ds);
                koneksi.Close();

                ScheduleTab_Load(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //Clear
        private void buttonClear_Click(object sender, EventArgs e)
        {
            if (koneksi.State != ConnectionState.Open)
            {
                koneksi.Open();
            }
            try
            {
                query = string.Format("delete from schedule_table where {0} = '{1}'", Day.Text, ScheduleInput.Text);
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                perintah.ExecuteNonQuery();
                ds.Clear();
                adapter.Fill(ds);
                koneksi.Close();

                ScheduleTab_Load(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
