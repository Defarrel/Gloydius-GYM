using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Gym_desktop
{
    public partial class hapusJadwal : Form
    {
        string strKoneksi = "Data Source = DEFARREL; Initial Catalog = GYM;" +
"Integrated Security = True; MultipleActiveResultSets=true";
        public hapusJadwal()
        {
            InitializeComponent();
        }

        private void hapusJadwal_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(strKoneksi);
            connection.Open();
            string query = "SELECT * FROM Jadwal";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dataTable);


            dataGridView1.DataSource = dataTable;
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(this, "Apakah Anda ingin menghapus data ini?",
                                      "Konfirmasi Penghapusan Data",
                                      MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                hapus();
            }
        }

        public void hapus()
        {
            string code = hapus_text.Text;

            SqlConnection connection = new SqlConnection(strKoneksi);
            {
                connection.Open();

                string query = "DELETE FROM Jadwal WHERE Id_jadwal = @Id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", code);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Data tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadData();
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            hapus_text.Text = row.Cells["Id_jadwal"].Value.ToString();
        }
    }
}
