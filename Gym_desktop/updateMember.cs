using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Gym_desktop
{
    public partial class updateMember : Form
    {
        string strKoneksi = "Data Source = DEFARREL; Initial Catalog = GYM;" +
            "Integrated Security = True; MultipleActiveResultSets=true";
        string curFileName;
        int bttn;
        Image curImage;

        public updateMember()
        {
            InitializeComponent();
        }

        private void updateMember_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(strKoneksi))
            {
                connection.Open();
                string query = "SELECT * FROM Member";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataTable);
            }

            dataGridView1.DataSource = dataTable;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                ID.Text = row.Cells[0].Value.ToString();
                nama.Text = row.Cells[1].Value.ToString();
                berat_badan.Text = row.Cells[2].Value.ToString();

                if (row.Cells[3].Value != null && int.TryParse(row.Cells[3].Value.ToString(), out int umurValue))
                {
                    umur.Text = umurValue.ToString();
                }
                else
                {
                    umur.Text = "0";
                }

                no_hp.Text = row.Cells[4].Value.ToString();

                if (row.Cells[5].Value != null && DateTime.TryParse(row.Cells[5].Value.ToString(), out DateTime daftarValue))
                {
                    daftar.Value = daftarValue;
                }

                if (row.Cells[6].Value != null && DateTime.TryParse(row.Cells[6].Value.ToString(), out DateTime tenggatValue))
                {
                    tenggat.Value = tenggatValue;
                }

                if (row.Cells[7].Value != null && row.Cells[7].Value is byte[])
                {
                    byte[] imageData = (byte[])row.Cells[7].Value;
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        curImage = Image.FromStream(ms);
                    }
                }
                else
                {
                    curImage = null;
                }
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nama.Text) ||
                string.IsNullOrWhiteSpace(berat_badan.Text) ||
                string.IsNullOrWhiteSpace(umur.Text) ||
                string.IsNullOrWhiteSpace(no_hp.Text))
            {
                MessageBox.Show("Semua field harus diisi!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(umur.Text, out int umurValue))
            {
                MessageBox.Show("Berat badan dan umur harus berupa angka!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (no_hp.Text.Length != 12 || !IsNumeric(no_hp.Text))
            {
                MessageBox.Show("Nomor hp harus terdiri dari 12 digit angka!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            byte[] imageData = null;
            if (bttn == 1)
            {
                using (FileStream file = new FileStream(curFileName, FileMode.OpenOrCreate, FileAccess.Read))
                {
                    imageData = new byte[file.Length];
                    file.Read(imageData, 0, (int)file.Length);
                }
            }

            using (SqlConnection connection = new SqlConnection(strKoneksi))
            {
                connection.Open();
                string query = bttn == 1 ?
                    "UPDATE Member SET Nama_member = @nama, Berat_bdn = @berat, Umur = @umur, No_hp = @no_hp, Tgl_daftar = @daftar, Tgl_tenggat = @tenggat, Gambar = @gambar WHERE Id_member = @id" :
                    "UPDATE Member SET Nama_member = @nama, Berat_bdn = @berat, Umur = @umur, No_hp = @no_hp, Tgl_daftar = @daftar, Tgl_tenggat = @tenggat WHERE Id_member = @id";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", ID.Text);
                    command.Parameters.AddWithValue("@nama", nama.Text);
                    command.Parameters.AddWithValue("@berat", berat_badan.Text);
                    command.Parameters.AddWithValue("@umur", umurValue);
                    command.Parameters.AddWithValue("@no_hp", no_hp.Text);
                    command.Parameters.AddWithValue("@daftar", daftar.Value);
                    command.Parameters.AddWithValue("@tenggat", tenggat.Value);
                    if (bttn == 1)
                    {
                        command.Parameters.AddWithValue("@gambar", imageData);
                    }

                    command.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Data berhasil diupdate!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();
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

        private void upload_Click(object sender, EventArgs e)
        {
            bttn = 1;
            OpenFileDialog openDlg = new OpenFileDialog();
            if (openDlg.ShowDialog() == DialogResult.OK)
            {
                curFileName = openDlg.FileName;
                gambar.Text = openDlg.FileName;
            }
        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {
            string searchID = textBoxID.Text.Trim();
            if (string.IsNullOrEmpty(searchID))
            {
                LoadData();
            }

            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(strKoneksi))
            {
                string query = "SELECT * FROM Member WHERE Nama_member LIKE @searchID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@searchID", searchID + "%");

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        connection.Open();
                        adapter.Fill(dataTable);
                    }
                }
            }

            dataGridView1.DataSource = dataTable;

            if (dataTable.Rows.Count == 0)
            {
                MessageBox.Show("Tidak ada member yang ditemukan dengan nama tersebut.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
