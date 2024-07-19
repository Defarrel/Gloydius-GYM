using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Gym_desktop
{
    public partial class tambahPaketMember : Form
    {
        string strKoneksi = "Data Source=DEFARREL;Initial Catalog=GYM;Integrated Security=True;MultipleActiveResultSets=true";

        public tambahPaketMember()
        {
            InitializeComponent();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(id_paket.Text) ||
                string.IsNullOrWhiteSpace(nama_paket.Text) ||
                string.IsNullOrWhiteSpace(harga_paket.Text) ||
                string.IsNullOrWhiteSpace(durasi.Text))
            {
                MessageBox.Show("Semua field harus diisi!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(harga_paket.Text, out decimal hargaValue))
            {
                MessageBox.Show("Harga harus berupa angka!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(strKoneksi))
                {
                    connection.Open();

                    string query = @"INSERT INTO PaketMember (Id_paket, Nama_paket, Harga_paket, Durasi_paket) 
                                     VALUES (@Id_paket, @Nama_paket, @Harga_paket, @Durasi_paket)";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Id_paket", id_paket.Text);
                    command.Parameters.AddWithValue("@Nama_paket", nama_paket.Text);
                    command.Parameters.AddWithValue("@Harga_paket", hargaValue);
                    command.Parameters.AddWithValue("@Durasi_paket", durasi.Text);

                    command.ExecuteNonQuery();

                    MessageBox.Show("Paket member berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    id_paket.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat menyimpan data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tambahPaketMember_Load(object sender, EventArgs e)
        {
            GenerateNewId();
        }

        private void GenerateNewId()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(strKoneksi))
                {
                    string query = "SELECT TOP 1 Id_paket FROM PaketMember ORDER BY Id_paket DESC";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            string lastId = reader["Id_Paket"].ToString();
                            int ctr = int.Parse(lastId.Substring(2, 3)) + 1;

                            if (ctr <= 9)
                            {
                                id_paket.Text = "PK00" + ctr;
                            }
                            else if (ctr <= 99)
                            {
                                id_paket.Text = "PK0" + ctr;
                            }
                            else
                            {
                                id_paket.Text = "PK" + ctr;
                            }
                        }
                        else
                        {
                            id_paket.Text = "PK001";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            id_paket.Enabled = false;
        }
    }
}
