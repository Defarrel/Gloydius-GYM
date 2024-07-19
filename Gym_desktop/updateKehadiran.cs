using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Gym_desktop
{
    public partial class updateKehadiran : Form
    {
        string strKoneksi = "Data Source = DEFARREL; Initial Catalog = GYM; Integrated Security = True; MultipleActiveResultSets=true";

        public updateKehadiran()
        {
            InitializeComponent();
            cbx();
        }

        public void cbx()
        {
            kehadiran.Items.Add("hadir");
            kehadiran.Items.Add("tidak hadir");
        }

        private void updateKehadiran_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(strKoneksi))
            {
                connection.Open();
                string query = "SELECT * FROM kehadiran_pt";
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
                ID.Text = row.Cells[0].Value.ToString();
                kehadiran.Text = row.Cells[1].Value.ToString();
                if (row.Cells[2].Value != null && DateTime.TryParse(row.Cells[2].Value.ToString(), out DateTime tanggalValue))
                {
                    tanggal.Value = tanggalValue;
                }
                id_trainer.Text = row.Cells[3].Value.ToString();
                id_jadwal.Text = row.Cells[4].Value.ToString();
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ID.Text) ||
                string.IsNullOrWhiteSpace(kehadiran.Text) ||
                string.IsNullOrWhiteSpace(id_trainer.Text) ||
                string.IsNullOrWhiteSpace(id_jadwal.Text))
            {
                MessageBox.Show("Semua field harus diisi!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection connection = new SqlConnection(strKoneksi))
            {
                string query = "UPDATE KehadiranTrainer SET Kehadiran = @kehadiran, Tanggal_kehadiran = @tanggal, Id_trainer = @id_trainer, Id_jadwal = @id_jadwal WHERE Id_kehadiran = @id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", ID.Text);
                    command.Parameters.AddWithValue("@kehadiran", kehadiran.Text);
                    command.Parameters.AddWithValue("@tanggal", tanggal.Value);
                    command.Parameters.AddWithValue("@id_trainer", id_trainer.Text);
                    command.Parameters.AddWithValue("@id_jadwal", id_jadwal.Text);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Data berhasil diupdate!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();
        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {
            string namaTrainer = textBoxID.Text.Trim();
            if (string.IsNullOrEmpty(namaTrainer))
            {
                LoadData();
            }

            using (SqlConnection connection = new SqlConnection(strKoneksi))
            {
                DataTable searchResults = new DataTable();
                string query = "EXEC GetKehadiranIdByTrainerName @Nama_trainer";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nama_trainer", namaTrainer);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    connection.Open();
                    adapter.Fill(searchResults);
                }

                dataGridView1.DataSource = searchResults;

                if (searchResults.Rows.Count == 0)
                {
                    MessageBox.Show("Tidak ada data kehadiran untuk trainer tersebut.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
