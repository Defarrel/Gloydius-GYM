using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Gym_desktop
{
    public partial class updatePaket : Form
    {
        string strKoneksi = "Data Source = DEFARREL; Initial Catalog = GYM; Integrated Security = True; MultipleActiveResultSets=true";

        public updatePaket()
        {
            InitializeComponent();
        }

        private void updatePaket_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(strKoneksi))
            {
                connection.Open();
                string query = "SELECT * FROM PaketMember";
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
                id_paket.Text = row.Cells[0].Value.ToString();
                nama_paket.Text = row.Cells[1].Value.ToString();
                if (row.Cells[2].Value != null && decimal.TryParse(row.Cells[2].Value.ToString(), out decimal hargaValue))
                {
                    harga_paket.Text = hargaValue.ToString();
                }
                durasi.Text = row.Cells[3].Value.ToString();

            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void update_Click(object sender, EventArgs e)
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

            using (SqlConnection connection = new SqlConnection(strKoneksi))
            {
                string query = "UPDATE PaketMember SET Nama_paket = @nama_paket, Harga_paket = @harga_paket, Durasi_paket = @durasi_paket WHERE Id_paket = @id_paket";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id_paket", id_paket.Text);
                    command.Parameters.AddWithValue("@nama_paket", nama_paket.Text);
                    command.Parameters.AddWithValue("@harga_paket", hargaValue);
                    command.Parameters.AddWithValue("@durasi_paket", durasi.Text);

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
                string query = "SELECT * FROM PaketMember WHERE Nama_paket LIKE @searchID";
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
                    MessageBox.Show("Tidak ada paket yang ditemukan dengan nama tersebut.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
