using System.Data;
using System;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Student_Helper
{
    public partial class ToDoForm : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;

        private DataSet ds = new DataSet();
        private string alamat, query;

        public ToDoForm()
        {
            alamat = "server=localhost; database=helperdb; username=root; password=;";
            koneksi = new MySqlConnection(alamat);

            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        DataTable ToDoList = new DataTable();

        private void ToDoForm_Load(object sender, EventArgs e)
        {
            try
            {
                koneksi.Open();

                query = string.Format("select * from list");
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                perintah.ExecuteNonQuery();
                ds.Clear();
                adapter.Fill(ds);
                koneksi.Close();

                ToDoListView.DataSource = ds.Tables[0];
                ToDoListView.Columns[0].Width = 50;
                ToDoListView.Columns[0].HeaderText = "Title";
                ToDoListView.Columns[1].Width = 100;
                ToDoListView.Columns[1].HeaderText = "Description";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            //Update (If row exists)
            if (koneksi.State != ConnectionState.Open)
            {
                koneksi.Open();
            }
            try
            {
                query = string.Format("update list set Description = '{1}', DueDate = '{2}' where Title ='{0}'", TitleBox.Text, DescBox.Text, DueBox.Text);
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                perintah.ExecuteNonQuery();
                ds.Clear();
                adapter.Fill(ds);
                koneksi.Close();

                ToDoForm_Load(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            if (koneksi.State != ConnectionState.Open)
            {
                koneksi.Open();
            }
            try
            {
                query = string.Format("insert into List (Title, Description, DueDate) values ('{0}', '{1}', '{2}')", TitleBox.Text, DescBox.Text, DueBox.Text);
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                int res = perintah.ExecuteNonQuery();
                koneksi.Close();
                if (res == 1)
                {
                    MessageBox.Show("Insert data berhasil");
                    ToDoForm_Load(null, null);
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

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (koneksi.State != ConnectionState.Open)
            {
                koneksi.Open();
            }
            try
            {
                query = string.Format("delete from list where Title = '{0}'", TitleBox.Text);
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                perintah.ExecuteNonQuery();
                ds.Clear();
                adapter.Fill(ds);
                koneksi.Close();

                ToDoForm_Load(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonSchedule_Click(object sender, EventArgs e)
        {
            this.Hide();
            ScheduleForm ScheduleForm = new ScheduleForm();
            ScheduleForm.Show();
        }

        private void buttonReminder_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReminderForm ReminderForm = new ReminderForm();
            ReminderForm.Show();
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