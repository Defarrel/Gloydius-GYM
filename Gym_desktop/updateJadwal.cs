using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Gym_desktop
{
    public partial class updateJadwal : Form
    {
        string strKoneksi = "Data Source = DEFARREL; Initial Catalog = GYM; Integrated Security = True; MultipleActiveResultSets=true";

        public updateJadwal()
        {
            InitializeComponent();
        }

        private void updateJadwal_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(strKoneksi))
            {
                connection.Open();
                string query = "SELECT * FROM Jadwal";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataTable);
            }

            dataGridView1.DataSource = dataTable;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                id_jadwal.Text = row.Cells[0].Value.ToString();
                nama_jadwal.Text = row.Cells[1].Value.ToString();
                hari_latihan.Text = row.Cells[2].Value.ToString();
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void update_Click(object sender, EventArgs e)
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
                string query = "UPDATE Jadwal SET Nama_jadwal = @nama_jadwal, Hari_latihan = @hari_latihan WHERE Id_jadwal = @id_jadwal";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id_jadwal", id_jadwal.Text);
                    command.Parameters.AddWithValue("@nama_jadwal", nama_jadwal.Text);
                    command.Parameters.AddWithValue("@hari_latihan", hari_latihan.Text);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Data berhasil diupdate!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();

        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {
            string searchID = textBoxID.Text.Trim();
            if (string.IsNullOrEmpty(searchID))
            {
                LoadData();
            }

            using (SqlConnection connection = new SqlConnection(strKoneksi))
            {
                DataTable searchResults = new DataTable();
                string query = "SELECT * FROM Jadwal WHERE Nama_jadwal LIKE @searchID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@searchID", searchID + "%");
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    connection.Open();
                    adapter.Fill(searchResults);
                }

                dataGridView1.DataSource = searchResults;

                if (searchResults.Rows.Count == 0)
                {
                    MessageBox.Show("Tidak ada jadwal yang ditemukan dengan nama tersebut.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
