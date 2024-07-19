using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Gym_desktop
{
    public partial class tambahTrainer : Form
    {
        string strKoneksi = "Data Source=DEFARREL;Initial Catalog=GYM;Integrated Security=True;MultipleActiveResultSets=true";

        public tambahTrainer()
        {
            InitializeComponent();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(id_trainer.Text) ||
                string.IsNullOrWhiteSpace(nama_trainer.Text) ||
                string.IsNullOrWhiteSpace(no_hp.Text))
            {
                MessageBox.Show("Semua field harus diisi!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (no_hp.Text.Length != 12 || !IsNumeric(no_hp.Text))
            {
                MessageBox.Show("Nomor hp harus terdiri dari 12 digit angka!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(strKoneksi))
                {
                    connection.Open();

                    string query = @"INSERT INTO PersonalTrainer (Id_trainer, Nama_trainer, No_hp_trainer) 
                                     VALUES (@Id_trainer, @Nama_trainer, @No_hp_trainer)";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Id_trainer", id_trainer.Text);
                    command.Parameters.AddWithValue("@Nama_trainer", nama_trainer.Text);
                    command.Parameters.AddWithValue("@No_hp_trainer", no_hp.Text);

                    command.ExecuteNonQuery();

                    MessageBox.Show("Data berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    id_trainer.Enabled = false;
                    nama_trainer.Enabled = false;
                    no_hp.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat menyimpan data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tambahTrainer_Load(object sender, EventArgs e)
        {
            GenerateNewId();
        }

        private void GenerateNewId()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(strKoneksi))
                {
                    string query = "SELECT TOP 1 Id_trainer FROM PersonalTrainer ORDER BY Id_trainer DESC";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            string lastId = reader["Id_trainer"].ToString();
                            int ctr = int.Parse(lastId.Substring(2, 3)) + 1;

                            if (ctr <= 9)
                            {
                                id_trainer.Text = "PT00" + ctr;
                            }
                            else if (ctr <= 99)
                            {
                                id_trainer.Text = "PT0" + ctr;
                            }
                            else
                            {
                                id_trainer.Text = "PT" + ctr;
                            }
                        }
                        else
                        {
                            id_trainer.Text = "PT001";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            id_trainer.Enabled = false;
        }

        private bool IsNumeric(string text)
        {
            foreach (char c in text)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
