using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Gym_desktop
{
    public partial class tambahLatihan : Form
    {
        string strKoneksi = "Data Source=DEFARREL;Initial Catalog=GYM;Integrated Security=True;MultipleActiveResultSets=true";

        public tambahLatihan()
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

        private void btnTambah_Click(object sender, EventArgs e)
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
                try
                {
                    connection.Open();

                    string query = @"INSERT INTO Latihan (Id_latihan, Jenis_latihan, Gerakan_gerakan, Tgl_latihan, Durasi_latihan, Id_member, Id_trainer) 
                                     VALUES (@Id_latihan, @Jenis_latihan, @Gerakan_gerakan, @Tgl_latihan, @Durasi_latihan, @Id_member, @Id_trainer)";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Id_latihan", ID.Text);
                    command.Parameters.AddWithValue("@Jenis_latihan", latihan.Text);
                    command.Parameters.AddWithValue("@Gerakan_gerakan", gerakan.Text);
                    command.Parameters.AddWithValue("@Tgl_latihan", tanggal.Value);
                    command.Parameters.AddWithValue("@Durasi_latihan", durasi.Text);
                    command.Parameters.AddWithValue("@Id_member", memberValue);
                    command.Parameters.AddWithValue("@Id_trainer", id_trainer.Text);

                    command.ExecuteNonQuery();

                    MessageBox.Show("Data berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ID.Enabled = false;
                    latihan.Enabled = false;
                    gerakan.Enabled = false;
                    tanggal.Enabled = false;
                    durasi.Enabled = false;
                    id_member.Enabled = false;
                    id_trainer.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi kesalahan saat menyimpan data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tambahLatihan_Load(object sender, EventArgs e)
        {
            GenerateNewId();

            DataTable dataTableTrainer = new DataTable();
            DataTable dataTableMember = new DataTable();



            SqlConnection connection = new SqlConnection(strKoneksi);
            connection.Open();
            string queryTrainer = "SELECT * FROM PersonalTrainer";
            SqlCommand cmdTrainer = new SqlCommand(queryTrainer, connection);
            cmdTrainer.CommandType = CommandType.Text;
            SqlDataAdapter adapterTrainer = new SqlDataAdapter(cmdTrainer);
            adapterTrainer.Fill(dataTableTrainer);

            string queryJadwal = "SELECT * FROM Member";
            SqlCommand cmdJadwal = new SqlCommand(queryJadwal, connection);
            cmdJadwal.CommandType = CommandType.Text;
            SqlDataAdapter adapterJadwal = new SqlDataAdapter(cmdJadwal);
            adapterJadwal.Fill(dataTableMember);

            dataGridView1.DataSource = dataTableMember;
            dataGridView2.DataSource = dataTableTrainer;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GenerateNewId()
        {
            using (SqlConnection connection = new SqlConnection(strKoneksi))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT TOP 1 Id_latihan FROM Latihan ORDER BY Id_latihan DESC";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        string lastId = reader["Id_latihan"].ToString();
                        int ctr = int.Parse(lastId.Substring(2)) + 1;

                        ID.Text = "JD" + ctr.ToString().PadLeft(5, '0');
                    }
                    else
                    {
                        ID.Text = "JD00001";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi kesalahan saat mengambil ID terakhir: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            ID.Enabled = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                id_member.Text = row.Cells["Id_member"].Value.ToString();
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
