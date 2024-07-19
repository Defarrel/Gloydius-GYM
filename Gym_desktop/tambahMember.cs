using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing;
using System.IO;

namespace Gym_desktop
{
    public partial class tambahMember : Form
    {

        string curFileName;
        string strKoneksi = "Data Source=DEFARREL;Initial Catalog=GYM;Integrated Security=True;MultipleActiveResultSets=true";
        public tambahMember()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nama.Text) ||
                string.IsNullOrWhiteSpace(berat_badan.Text) ||
                string.IsNullOrWhiteSpace(umur.Text) ||
                string.IsNullOrWhiteSpace(no_hp.Text) ||
                string.IsNullOrWhiteSpace(curFileName))
            {
                MessageBox.Show("Semua field harus diisi!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(umur.Text, out int umurValue))
            {
                MessageBox.Show("Umur harus berupa angka!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (no_hp.Text.Length != 12 || !IsNumeric(no_hp.Text))
            {
                MessageBox.Show("Nomor hp harus terdiri dari 12 digit angka!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                byte[] rawdata;
                using (FileStream file = new FileStream(curFileName, FileMode.Open, FileAccess.Read))
                {
                    rawdata = new byte[file.Length];
                    file.Read(rawdata, 0, rawdata.Length);
                }

                using (SqlConnection connection = new SqlConnection(strKoneksi))
                {
                    connection.Open();

                    string query = "INSERT INTO Member (Nama_member, Berat_bdn, Umur, No_hp, Tgl_daftar, Tgl_tenggat, Gambar) VALUES (@Nama, @Berat, @Umur, @NoHp, @TglDaftar, @TglTenggat, @Gambar)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Nama", nama.Text);
                        command.Parameters.AddWithValue("@Berat", berat_badan.Text);
                        command.Parameters.AddWithValue("@Umur", umurValue);
                        command.Parameters.AddWithValue("@NoHp", no_hp.Text);
                        command.Parameters.AddWithValue("@TglDaftar", daftar.Value);
                        command.Parameters.AddWithValue("@TglTenggat", tenggat.Value);
                        command.Parameters.AddWithValue("@Gambar", rawdata);

                        command.ExecuteNonQuery();
                    }

                    connection.Close();
                }

                MessageBox.Show("Data berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                nama.Text = string.Empty;
                berat_badan.Text = string.Empty;
                umur.Text = string.Empty;
                no_hp.Text = string.Empty;
                gambar.Text = string.Empty;
                curFileName = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat menyimpan data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private bool IsNumeric(string text)
        {
            foreach (char c in text)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cari_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDlg = new OpenFileDialog();
            if (openDlg.ShowDialog() == DialogResult.OK)
            {
                curFileName = openDlg.FileName;
                gambar.Text = openDlg.FileName;
            }
        }

        private void lanjut_Click(object sender, EventArgs e)
        {
            transaksiBaru tb = new transaksiBaru();
            tb.MdiParent = this.MdiParent;
            tb.Show();
        }
    }
}
