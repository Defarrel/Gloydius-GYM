using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Gym_desktop
{
    public partial class updateTransaksi : Form
    {
        string strKoneksi = "Data Source = DEFARREL; Initial Catalog = GYM; Integrated Security = True; MultipleActiveResultSets=true";

        public updateTransaksi()
        {
            InitializeComponent();
        }

        private void updateTransaksi_Load(object sender, EventArgs e)
        {
            LoadData();
            ID.Enabled = false;
            idMember.Enabled = false;
        }

        private void LoadData()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(strKoneksi))
            {
                connection.Open();
                string query = "SELECT * FROM Transaksi_v";
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
                tanggal.Value = Convert.ToDateTime(row.Cells[1].Value);
                total.Text = row.Cells[2].Value.ToString();
                idMember.Text = row.Cells[3].Value.ToString();
                idPaket.Text = row.Cells[4].Value.ToString();
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ID.Text) ||
                string.IsNullOrWhiteSpace(tanggal.Text) ||
                string.IsNullOrWhiteSpace(total.Text) ||
                string.IsNullOrWhiteSpace(idMember.Text) ||
                string.IsNullOrWhiteSpace(idPaket.Text))
            {
                MessageBox.Show("Semua field harus diisi!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(total.Text, out decimal totalValue))
            {
                MessageBox.Show("Total harus berupa angka!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(idMember.Text, out int idMemberValue))
            {
                MessageBox.Show("ID Member harus berupa angka!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection connection = new SqlConnection(strKoneksi))
            {
                string query = "UPDATE Transaksi SET Tanggal_transaksi = @tanggal, Total = @total, Id_member = @idMember, Id_paket = @idPaket WHERE Id_transaksi = @id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", ID.Text);
                    command.Parameters.AddWithValue("@tanggal", tanggal.Value);
                    command.Parameters.AddWithValue("@total", totalValue);
                    command.Parameters.AddWithValue("@idMember", idMemberValue);
                    command.Parameters.AddWithValue("@idPaket", idPaket.Text);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Data berhasil diupdate!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();
        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {
            string namaMember = textBoxID.Text.Trim();
            if (string.IsNullOrEmpty(namaMember))
            {
                LoadData();
            }

            using (SqlConnection connection = new SqlConnection(strKoneksi))
            {
                DataTable searchResults = new DataTable();
                string query = "EXEC GetTransaksiIdByMemberName @Nama_member";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nama_member", namaMember);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    connection.Open();
                    adapter.Fill(searchResults);
                }

                dataGridView1.DataSource = searchResults;

                if (searchResults.Rows.Count == 0)
                {
                    MessageBox.Show("Tidak ada data transaksi untuk member tersebut.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
