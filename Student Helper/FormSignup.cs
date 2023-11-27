using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Student_Helper
{
    public partial class FormSignup : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;

        private string alamat, query;
        public FormSignup()
        {
            alamat = "server=localhost; database=helperdb; username=root; password=;";
            koneksi = new MySqlConnection(alamat);

            InitializeComponent();
        }
        private void Signup_Load(object sender, EventArgs e)
        {
            ErrorMsg.Text = "";
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
            this.Hide();
        }

        private void SignUpBtn_Click(object sender, EventArgs e)
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
            if (PassBox.Text != ConfirmPassBox.Text)
            {
                ErrorMsg.Text = "Please reconfirm your password!";
                return;
            }
            SignupSql();
            CancelBtn_Click(null, null);
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

        private void ShowCheck2_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowCheck2.Checked != false)
            {
                ConfirmPassBox.UseSystemPasswordChar = false;
                return;
            }
            ConfirmPassBox.UseSystemPasswordChar = true;
        }

        private void SignupSql()
        {
            if (koneksi.State != ConnectionState.Open)
            {
                koneksi.Open();
            }
            try
            {
                query = string.Format("insert into user (Username, Email, Password) values ('{0}', '{1}', '{2}')", UserBox.Text, EmailBox.Text, PassBox.Text);
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                int res = perintah.ExecuteNonQuery();
                koneksi.Close();
                if (res == 1)
                {
                    MessageBox.Show("Sign-up successfuly");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

    }
}
