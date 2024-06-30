using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Gym_desktop
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = username_text.Text;
            string password = password_text.Text;

            string connectionString = $"Data Source=DEFARREL;Initial Catalog=GYM;User ID={username};Password={password}";

            if (ValidateLogin(connectionString))
            {
                MessageBox.Show("Login successful!");
                this.Hide();

                Menu_utama fm3 = new Menu_utama();
                fm3.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }

        private bool ValidateLogin(string connectionString)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    return true; 
                }
                catch (SqlException)
                {
                    return false; 
                }
            }
        }
    }
}
