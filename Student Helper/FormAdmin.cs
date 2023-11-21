using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Student_Helper
{
    public partial class FormAdmin : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;

        private DataSet ds = new DataSet();
        private string alamat, query;
        public FormAdmin()
        {
            alamat = "server=localhost; database=helperdb; username=root; password=;";
            koneksi = new MySqlConnection(alamat);

            InitializeComponent();
        }

        private void ShowCheck1_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowCheck1.Checked != false)
            {
                PassBox.UseSystemPasswordChar = false;
                return;
            }
            PassBox.UseSystemPasswordChar = true;
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            ErrorMsg.Text = "";
            try
            {
                koneksi.Open();

                query = string.Format("select * from user");
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                perintah.ExecuteNonQuery();
                ds.Clear();
                adapter.Fill(ds);
                koneksi.Close();

                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns[0].Width = 75;
                dataGridView1.Columns[0].HeaderText = "Username";
                dataGridView1.Columns[1].Width = 75;
                dataGridView1.Columns[1].HeaderText = "Email";
                dataGridView1.Columns[2].Width = 75;
                dataGridView1.Columns[2].HeaderText = "Password";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (UserBox.Text == "")
            {
                ErrorMsg.Text = "Please enter your username!";
                return;
            }
            if (UserBox.Text.Contains(" "))
            {
                ErrorMsg.Text = "Your username can not have a space!";
                return;
            }
            if (EmailBox.Text == "")
            {
                ErrorMsg.Text = "Please enter your Email!";
                return;
            }
            string emailPattern = @"\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Z|a-z]{2,}\b";
            if (Regex.IsMatch(EmailBox.Text, emailPattern) == false)
            {
                ErrorMsg.Text = "Your Email format is incorrect!";
                return;
            }
            if (EmailBox.Text.Contains(" "))
            {
                ErrorMsg.Text = "Your Email can not have a space!";
                return;
            }
            if (PassBox.Text == "")
            {
                ErrorMsg.Text = "Please enter your password!";
                return;
            }
            if (PassBox.Text.Contains(" "))
            {
                ErrorMsg.Text = "Your password can not have a space!";
                return;
            }
            InsertSql();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (UserBox.Text == "")
            {
                ErrorMsg.Text = "Please enter your username!";
                return;
            }
            if (UserBox.Text.Contains(" "))
            {
                ErrorMsg.Text = "Your username can not have a space!";
                return;
            }
            if (EmailBox.Text == "")
            {
                ErrorMsg.Text = "Please enter your Email!";
                return;
            }
            string emailPattern = @"\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Z|a-z]{2,}\b";
            if (Regex.IsMatch(EmailBox.Text, emailPattern) == false)
            {
                ErrorMsg.Text = "Your Email format is incorrect!";
                return;
            }
            if (EmailBox.Text.Contains(" "))
            {
                ErrorMsg.Text = "Your Email can not have a space!";
                return;
            }
            if (PassBox.Text == "")
            {
                ErrorMsg.Text = "Please enter your password!";
                return;
            }
            if (PassBox.Text.Contains(" "))
            {
                ErrorMsg.Text = "Your password can not have a space!";
                return;
            }
            UpdateSql();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (koneksi.State != ConnectionState.Open)
            {
                koneksi.Open();
            }
            try
            {
                query = string.Format("delete from user where Username = '{0}'", UserBox.Text);
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                perintah.ExecuteNonQuery();
                ds.Clear();
                adapter.Fill(ds);
                koneksi.Close();

                Admin_Load(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void InsertSql()
        {
            if (koneksi.State != ConnectionState.Open)
            {
                koneksi.Open();
            }
            try
            {
                query = string.Format("insert into user (Username, Email, Password) values ('{0}', '{1}'. '{2}')", UserBox.Text, EmailBox.Text, UserBox.Text);
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                int res = perintah.ExecuteNonQuery();
                koneksi.Close();
                if (res == 1)
                {
                    MessageBox.Show("Insert data berhasil");
                    Admin_Load(null, null);
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

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
            this.Hide();
        }

        public void UpdateSql()
        {
            if (koneksi.State != ConnectionState.Open)
            {
                koneksi.Open();
            }
            try
            {
                query = string.Format("update user set Email='{1}', Password='{2}' where Username='{0}'", UserBox.Text, EmailBox.Text, PassBox.Text);
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                perintah.ExecuteNonQuery();
                ds.Clear();
                adapter.Fill(ds);
                koneksi.Close();

                Admin_Load(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

    }
}
