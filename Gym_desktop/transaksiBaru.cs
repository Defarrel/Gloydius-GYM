using Gym_desktop.GYMDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_desktop
{
    public partial class transaksiBaru : Form
    {
        private string strKoneksi = "Data Source=DEFARREL;Initial Catalog=GYM;Integrated Security=True;MultipleActiveResultSets=true";

        public transaksiBaru()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tanggal.Text) ||
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

            try
            {
                using (SqlConnection connection = new SqlConnection(strKoneksi))
                {
                    connection.Open();

                    string query = @"INSERT INTO Transaksi (Tanggal_transaksi, Total, Id_member, Id_paket) 
                                     VALUES (@Tanggal_transaksi, @Total, @Id_member, @Id_paket)";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Tanggal_transaksi", tanggal.Value);
                    command.Parameters.AddWithValue("@Total", totalValue);
                    command.Parameters.AddWithValue("@Id_member", idMemberValue);
                    command.Parameters.AddWithValue("@Id_paket", idPaket.Text);

                    command.ExecuteNonQuery();

                    MessageBox.Show("Data berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    tanggal.Enabled = false;
                    total.Enabled = false;
                    idMember.Enabled = false;
                    idPaket.Enabled = false;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat menyimpan data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void transaksiBaru_Load(object sender, EventArgs e)
        {
            DataTable dataTablePaket = new DataTable();
            DataTable dataTableMember = new DataTable();



            SqlConnection connection = new SqlConnection(strKoneksi);
            connection.Open();
            string queryTrainer = "SELECT * FROM PaketMember";
            SqlCommand cmdTrainer = new SqlCommand(queryTrainer, connection);
            cmdTrainer.CommandType = CommandType.Text;
            SqlDataAdapter adapterTrainer = new SqlDataAdapter(cmdTrainer);
            adapterTrainer.Fill(dataTablePaket);

            string queryJadwal = "SELECT * FROM Member";
            SqlCommand cmdJadwal = new SqlCommand(queryJadwal, connection);
            cmdJadwal.CommandType = CommandType.Text;
            SqlDataAdapter adapterJadwal = new SqlDataAdapter(cmdJadwal);
            adapterJadwal.Fill(dataTableMember);

            dataGridView1.DataSource = dataTableMember;
            dataGridView2.DataSource = dataTablePaket;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                idMember.Text = row.Cells["Id_member"].Value.ToString();
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
                if (row.Cells["Harga_paket"].Value != null && double.TryParse(row.Cells["Harga_paket"].Value.ToString(), out double totalValue))
                {
                    total.Text = totalValue.ToString();
                }
                idPaket.Text = row.Cells["Id_paket"].Value.ToString();

            }
        }
    }
}
