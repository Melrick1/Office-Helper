using System.Data;
using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Student_Helper
{
    public partial class TabToDoList : UserControl
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;

        private DataSet ds = new DataSet();
        private string alamat, query;

        public TabToDoList()
        {
            alamat = "server=localhost; database=helperdb; username=root; password=;";
            koneksi = new MySqlConnection(alamat);

            InitializeComponent();
        }
        private void TabToDoList_Load(object sender, EventArgs e)
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
                ToDoListView.Columns[2].Width = 100;
                ToDoListView.Columns[2].HeaderText = "Due-Date";
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
                    MessageBox.Show("New list successfully created");
                    TabToDoList_Load(null, null);
                }
                else
                {
                    MessageBox.Show("Failed to create new list");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
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

                TabToDoList_Load(null, null);
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

                TabToDoList_Load(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
