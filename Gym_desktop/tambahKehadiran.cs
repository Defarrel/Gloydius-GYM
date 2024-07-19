using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Gym_desktop
{
    public partial class tambahKehadiran : Form
    {
        string strKoneksi = "Data Source=DEFARREL;Initial Catalog=GYM;Integrated Security=True;MultipleActiveResultSets=true";
        string code;

        public tambahKehadiran()
        {
            InitializeComponent();
            cbx();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ID.Text) ||
                string.IsNullOrWhiteSpace(kehadiran.Text) ||
                string.IsNullOrWhiteSpace(id_trainer.Text) ||
                string.IsNullOrWhiteSpace(id_jadwal.Text))
            {
                MessageBox.Show("Semua field harus diisi!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(strKoneksi))
                {
                    string query = "INSERT INTO KehadiranTrainer (Id_kehadiran, Kehadiran, Tanggal_kehadiran, Id_trainer, Id_jadwal) " +
                                   "VALUES (@id_kehadiran, @kehadiran, @tanggal_kehadiran, @id_trainer, @id_jadwal)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id_kehadiran", ID.Text);
                        command.Parameters.AddWithValue("@kehadiran", kehadiran.Text);
                        command.Parameters.AddWithValue("@tanggal_kehadiran", tanggal.Value);
                        command.Parameters.AddWithValue("@id_trainer", id_trainer.Text);
                        command.Parameters.AddWithValue("@id_jadwal", id_jadwal.Text);

                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Data berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ID.Enabled = false;
                kehadiran.Enabled = false;
                tanggal.Enabled = false;
                id_trainer.Enabled = false;
                id_jadwal.Enabled = false;
                GenerateNewId();
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

        private void tambahKehadiran_Load(object sender, EventArgs e)
        {
            GenerateNewId();

            DataTable dataTableTrainer = new DataTable();
            DataTable dataTableJadwal = new DataTable();



            SqlConnection connection = new SqlConnection(strKoneksi);
            connection.Open();
            string queryTrainer = "SELECT * FROM PersonalTrainer";
            SqlCommand cmdTrainer = new SqlCommand(queryTrainer, connection);
            cmdTrainer.CommandType = CommandType.Text;
            SqlDataAdapter adapterTrainer = new SqlDataAdapter(cmdTrainer);
            adapterTrainer.Fill(dataTableTrainer);

            string queryJadwal = "SELECT * FROM Jadwal";
            SqlCommand cmdJadwal = new SqlCommand(queryJadwal, connection);
            cmdJadwal.CommandType = CommandType.Text;
            SqlDataAdapter adapterJadwal = new SqlDataAdapter(cmdJadwal);
            adapterJadwal.Fill(dataTableJadwal);

            dataGridView1.DataSource = dataTableJadwal;
            dataGridView2.DataSource = dataTableTrainer;
        }

    



        private void cbx()
        {
            kehadiran.Items.Add("hadir");
            kehadiran.Items.Add("tidak hadir");
        }

        private void GenerateNewId()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(strKoneksi))
                {
                    string query = "SELECT TOP 1 Id_kehadiran FROM KehadiranTrainer ORDER BY Id_kehadiran DESC";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            string lastId = reader["Id_kehadiran"].ToString();
                            int ctr = int.Parse(lastId.Substring(2, 3)) + 1;

                            if (ctr <= 9)
                            {
                                ID.Text = "KH00" + ctr;
                            }
                            else if (ctr <= 99)
                            {
                                ID.Text = "KH0" + ctr;
                            }
                            else
                            {
                                ID.Text = "KH" + ctr;
                            }
                        }
                        else
                        {
                            ID.Text = "KH001";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ID.Enabled = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                id_jadwal.Text = row.Cells["Id_jadwal"].Value.ToString();
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
                id_trainer.Text = row.Cells["Id_trainer"].Value.ToString();

            }
        }
    }
}
