using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Student_Helper
{
    public partial class Login : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;

        private DataSet ds = new DataSet();
        private string alamat, query;
        public Login()
        {
            alamat = "server=localhost; database=helperdb; username=root; password=;";
            koneksi = new MySqlConnection(alamat);

            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e)
        {
            ErrorMsg.Text = "";
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (UserBox.Text == "")
            {
                ErrorMsg.Text = "Please enter your username or email!";
                return;
            }
            if (UserBox.Text.Contains(" "))
            {
                ErrorMsg.Text = "Your username or email can not have a space!";
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
            if (UserBox.Text == "admin" && PassBox.Text == "admin")
            {
                Admin admin = new Admin();
                admin.Show();
                this.Hide();
                return;
            }
            LoginSql();
        }

        private void ShowCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowCheck.Checked != false)
            {
                PassBox.UseSystemPasswordChar = false;
                return;
            }
            PassBox.UseSystemPasswordChar = true;
        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            Signup signUp = new Signup();
            signUp.Show();
            this.Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            
        }

        private void Exit_MouseHover(object sender, EventArgs e)
        {
            Exit.Image = Properties.Resources.logoutHover;
        }

        private void Exit_MouseLeave(object sender, EventArgs e)
        {
            Exit.Image = Properties.Resources.logout;
        }

        private void LoginSql()
        {
            if (koneksi.State != ConnectionState.Open)
            {
                koneksi.Open();
            }
            try
            {
                query = string.Format("select * from user where username = '{0}' and password = '{1}'", UserBox.Text, PassBox.Text);
                ds.Clear();
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                perintah.ExecuteNonQuery();
                adapter.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow column in ds.Tables[0].Rows)
                    {
                        string pass;
                        pass = column["password"].ToString();
                        if (pass != PassBox.Text)
                        {
                            MessageBox.Show("Anda salah input password");
                            return;
                        }
                        Main mainMenu = new Main();
                        mainMenu.Show();
                        this.Hide();
                    }
                }
            }
            catch (Exception ex)
            {
                koneksi.Close();
                MessageBox.Show(ex.ToString());
            }
        }

    }
}
