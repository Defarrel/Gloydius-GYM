using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Gym_desktop
{
    public partial class laporanLatihan : Form
    {
        private string strKoneksi = "Data Source=DEFARREL;Initial Catalog=GYM;Integrated Security=True;MultipleActiveResultSets=true";

        CrystalReport1 cr = new CrystalReport1();
        public laporanLatihan()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void id_member_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            try
            {
                int idMember;
                string nama = id_member.Text;
                string sql = "SELECT Id_member FROM Member WHERE Nama_member = @id";
                using (SqlConnection connection = new SqlConnection(strKoneksi))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(sql, connection);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@id", nama);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        idMember = Convert.ToInt32(reader["Id_member"].ToString());
                        GenerateExerciseReport(idMember);
                    }
                    else
                    {
                        MessageBox.Show("ID Member tidak ditemukan", "Kesalahan Input Data",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Kesalahan Input Data",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void GenerateExerciseReport(int idMember)
        {
            using (SqlConnection connection = new SqlConnection(strKoneksi))
            {
                string query =
                    "SELECT l.Jenis_latihan, l.Gerakan_gerakan, l.Tgl_latihan, l.Durasi_latihan, m.Nama_member, t.Nama_trainer, COUNT(l.Id_latihan) OVER() AS Jumlah_Pertemuan" +
                    " FROM Latihan l INNER JOIN Member m ON l.Id_member = m.Id_member INNER JOIN PersonalTrainer t " +
                    "ON l.Id_trainer = t.Id_trainer WHERE l.Id_member = @id_member ";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id_member", idMember);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                connection.Close();
                cr.SetDataSource(dataTable);
                crystalReportViewer1.ReportSource = cr;
                crystalReportViewer1.Refresh();
            }
        }
    }
}
