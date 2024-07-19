using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Gym_desktop
{
    public partial class tambahJadwal : Form
    {
        string strKoneksi = "Data Source=DEFARREL;Initial Catalog=GYM;Integrated Security=True;MultipleActiveResultSets=true";
        string code;

        public tambahJadwal()
        {
            InitializeComponent();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(id_jadwal.Text) ||
                string.IsNullOrWhiteSpace(nama_jadwal.Text) ||
                string.IsNullOrWhiteSpace(hari_latihan.Text))
            {
                MessageBox.Show("Semua field harus diisi!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection connection = new SqlConnection(strKoneksi))
            {
                string query = "INSERT INTO Jadwal (Id_jadwal, Nama_jadwal, Hari_latihan) VALUES (@id_jadwal, @nama_jadwal, @hari_latihan)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id_jadwal", id_jadwal.Text);
                    command.Parameters.AddWithValue("@nama_jadwal", nama_jadwal.Text);
                    command.Parameters.AddWithValue("@hari_latihan", hari_latihan.Text);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Data berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

            id_jadwal.Enabled = false;
            nama_jadwal.Enabled = false;
            hari_latihan.Enabled = false;
            GenerateNewId();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tambahJadwal_Load(object sender, EventArgs e)
        {
            GenerateNewId();
        }

        private void GenerateNewId()
        {
            using (SqlConnection connection = new SqlConnection(strKoneksi))
            {
                string query = "SELECT TOP 1 Id_jadwal FROM Jadwal ORDER BY Id_jadwal DESC";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        string lastId = reader["Id_jadwal"].ToString();
                        int ctr = int.Parse(lastId.Substring(2, 3)) + 1;

                        if (ctr <= 9)
                        {
                            id_jadwal.Text = "JD00" + ctr;
                        }
                        else if (ctr <= 99)
                        {
                            id_jadwal.Text = "JD0" + ctr;
                        }
                        else
                        {
                            id_jadwal.Text = "JD" + ctr;
                        }
                    }
                    else
                    {
                        id_jadwal.Text = "JD001";
                    }
                }
            }

            id_jadwal.Enabled = false;
        }
    }
}
