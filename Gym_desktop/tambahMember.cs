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
        DataTable dt;
        DataRow dr;
        Image curImage;
        string curFIleName;
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
                string.IsNullOrWhiteSpace(no_hp.Text))
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
            FileStream file = new FileStream(curFIleName, FileMode.OpenOrCreate, FileAccess.Read);
            byte[] rawdata = new byte[file.Length];
            file.Read(rawdata, 0, System.Convert.ToInt32(file.Length));
            file.Close();

            dt = gYMDataSet.Tables["Member"];

            dr = dt.NewRow();
            dr["Nama_member"] = nama.Text;
            dr["Berat_bdn"] = berat_badan.Text;
            dr["Umur"] = umurValue;
            dr["No_hp"] = no_hp.Text;
            dr["Tgl_daftar"] = daftar.Value;
            dr["Tgl_tenggat"] = tenggat.Value;
            dr["Gambar"] = rawdata;
            dt.Rows.Add(dr);

            memberTableAdapter.Update(gYMDataSet);

            this.memberTableAdapter.Fill(this.gYMDataSet.Member);

            nama.Enabled = false;
            berat_badan.Enabled = false;
            umur.Enabled = false;
            no_hp.Enabled = false;
            daftar.Enabled = false;
            tenggat.Enabled = false;

            MessageBox.Show("Data berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
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


        private void tambahMember_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gYMDataSet.Member' table. You can move, or remove it, as needed.
            this.memberTableAdapter.Fill(this.gYMDataSet.Member);
        }

        private void tgl_daftar_TextChanged(object sender, EventArgs e)
        {

        }

        private void no_hp_TextChanged(object sender, EventArgs e)
        {

        }

        private void umur_TextChanged(object sender, EventArgs e)
        {

        }

        private void berat_badan_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void gambar_TextChanged(object sender, EventArgs e)
        {

        }

        private void cari_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDlg = new OpenFileDialog();
            if (openDlg.ShowDialog() == DialogResult.OK)
            {
                curFIleName = openDlg.FileName;
                gambar.Text = openDlg.FileName;
            }
        }
    }
}
