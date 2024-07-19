using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Gym_desktop
{
    public partial class updatelatihan : Form
    {
        string strKoneksi = "Data Source = DEFARREL; Initial Catalog = GYM; Integrated Security = True; MultipleActiveResultSets=true";

        public updatelatihan()
        {
            InitializeComponent();
            cbx();
        }

        public void cbx()
        {
            durasi.Items.Add("1 jam");
            durasi.Items.Add("2 jam");
            durasi.Items.Add("3 jam");
            durasi.Items.Add("4 jam");
            durasi.Items.Add("5 jam");
            durasi.Items.Add("6 jam");
            durasi.Items.Add("7 jam");
            durasi.Items.Add("8 jam");
        }

        private void updatelatihan_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(strKoneksi))
            {
                connection.Open();
                string query = "SELECT * FROM Riwayat_latihan";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataTable);
            }

            dataGridView1.DataSource = dataTable;

            id_member.Enabled = false;
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                ID.Text = row.Cells[0].Value.ToString();
                latihan.Text = row.Cells[1].Value.ToString();
                gerakan.Text = row.Cells[2].Value.ToString();
                if (row.Cells[3].Value != null && DateTime.TryParse(row.Cells[3].Value.ToString(), out DateTime tanggalValue))
                {
                    tanggal.Value = tanggalValue;
                }
                durasi.Text = row.Cells[4].Value.ToString();
                id_member.Text = row.Cells[5].Value.ToString();
                id_trainer.Text = row.Cells[6].Value.ToString();
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ID.Text) ||
                string.IsNullOrWhiteSpace(latihan.Text) ||
                string.IsNullOrWhiteSpace(gerakan.Text) ||
                string.IsNullOrWhiteSpace(durasi.Text) ||
                string.IsNullOrWhiteSpace(id_member.Text) ||
                string.IsNullOrWhiteSpace(id_trainer.Text))
            {
                MessageBox.Show("Semua field harus diisi!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(id_member.Text, out int memberValue))
            {
                MessageBox.Show("Id Member harus berupa angka!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection connection = new SqlConnection(strKoneksi))
            {
                string query = "UPDATE Latihan SET Jenis_latihan = @latihan, Gerakan_gerakan = @gerakan, Tgl_latihan = @tanggal, Durasi_latihan = @durasi, Id_member = @id_member, Id_trainer = @id_trainer WHERE Id_latihan = @id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", ID.Text);
                    command.Parameters.AddWithValue("@latihan", latihan.Text);
                    command.Parameters.AddWithValue("@gerakan", gerakan.Text);
                    command.Parameters.AddWithValue("@tanggal", tanggal.Value);
                    command.Parameters.AddWithValue("@durasi", durasi.Text);
                    command.Parameters.AddWithValue("@id_member", memberValue);
                    command.Parameters.AddWithValue("@id_trainer", id_trainer.Text);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Data berhasil diupdate!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();

        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {
            string searchNamaMember = textBoxID.Text.Trim();
            if (string.IsNullOrEmpty(searchNamaMember))
            {
                LoadData();
            }

            using (SqlConnection connection = new SqlConnection(strKoneksi))
            {
                DataTable searchResults = new DataTable();
                string query = "EXEC GetLatihanIdByMemberName @Nama_member";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nama_member", searchNamaMember);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    connection.Open();
                    adapter.Fill(searchResults);
                }

                dataGridView1.DataSource = searchResults;

                if (searchResults.Rows.Count == 0)
                {
                    MessageBox.Show("Nama member tidak ditemukan.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
