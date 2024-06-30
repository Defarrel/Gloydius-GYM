using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Gym_desktop
{
    public partial class updateMember : Form
    {
        DataTable dt;
        DataRow dr;
        Image curImage;
        string curFIleName;

        int bttn;
        public updateMember()
        {
            InitializeComponent();
        }

        private void updateMember_Load(object sender, EventArgs e)
        {
            // This line of code loads data into the 'gYMDataSet.Member' table. You can move, or remove it, as needed.
            this.memberTableAdapter.Fill(this.gYMDataSet.Member);
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

                if (row.Cells[5].Value != null && DateTime.TryParse(row.Cells[5].Value.ToString(), out DateTime daftarValue))  // Asumsikan Tgl_daftar adalah kolom kelima
                {
                    daftar.Value = daftarValue;
                }

                if (row.Cells[6].Value != null && DateTime.TryParse(row.Cells[6].Value.ToString(), out DateTime tenggatValue))  // Asumsikan Tgl_tenggat adalah kolom keenam
                {
                    tenggat.Value = tenggatValue;
                }

                if (row.Cells[7].Value != null && row.Cells[7].Value is byte[])
                {
                    byte[] imageData = (byte[])row.Cells[7].Value;
                    gambar.Text = BitConverter.ToString(imageData);
                }
                else
                {
                    gambar.Text = string.Empty;
                }
            }
        }



        private void textBoxID_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchID = textBoxID.Text.Trim();
            if (string.IsNullOrEmpty(searchID))
            {
                MessageBox.Show("Silakan masukkan nama untuk mencari.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataView dv = new DataView(gYMDataSet.Tables["Member"]);
            dv.RowFilter = string.Format("Convert(Nama_member, 'System.String') like '{0}%'", searchID);
            dataGridView1.DataSource = dv;

            if (dv.Count == 0)
            {
                MessageBox.Show("Tidak ada member yang ditemukan dengan nama tersebut.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void RefreshButton_Click_1(object sender, EventArgs e)
        {
            textBoxID.Text = string.Empty;
            DataView dv = new DataView(gYMDataSet.Tables["Member"]);
            dataGridView1.DataSource = dv;

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
            if (bttn == 1)
            {
                FileStream file = new FileStream(curFIleName, FileMode.OpenOrCreate, FileAccess.Read);
                byte[] rawdata = new byte[file.Length];
                file.Read(rawdata, 0, System.Convert.ToInt32(file.Length));
                file.Close();

                dt = gYMDataSet.Tables["Member"];
                //mencari primary key yang akan diubah datanya
                dr = dt.Rows.Find(ID.Text);

                dr.BeginEdit();
                dr["Nama_member"] = nama.Text;
                dr["Berat_bdn"] = berat_badan.Text;
                dr["Umur"] = umurValue;
                dr["No_hp"] = no_hp.Text;
                dr["Tgl_daftar"] = daftar.Value;
                dr["Tgl_tenggat"] = tenggat.Value;
                dr["Gambar"] = rawdata;
                dr.EndEdit();

                MessageBox.Show("Data berhasil diupdate!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                dt = gYMDataSet.Tables["Member"];
                //mencari primary key yang akan diubah datanya
                dr = dt.Rows.Find(ID.Text);

                dr.BeginEdit();
                dr["Nama_member"] = nama.Text;
                dr["Berat_bdn"] = berat_badan.Text;
                dr["Umur"] = umurValue;
                dr["No_hp"] = no_hp.Text;
                dr["Tgl_daftar"] = daftar.Value;
                dr["Tgl_tenggat"] = tenggat.Value;
                dr.EndEdit();
            }

            MessageBox.Show("Data berhasil diupdate!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

            memberTableAdapter.Update(gYMDataSet);

            this.memberTableAdapter.Fill(this.gYMDataSet.Member);
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
                curFIleName = openDlg.FileName;
                gambar.Text = openDlg.FileName;
            }
        }
    }
}
