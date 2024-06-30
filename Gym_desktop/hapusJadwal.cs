using System;
using System.Data;
using System.Windows.Forms;

namespace Gym_desktop
{
    public partial class hapusJadwal : Form
    {
        DataRow dr;
        public hapusJadwal()
        {
            InitializeComponent();
        }

        private void hapusJadwal_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gYMDataSet.Jadwal' table. You can move, or remove it, as needed.
            this.jadwalTableAdapter.Fill(this.gYMDataSet.Jadwal);

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

            dr = gYMDataSet.Tables["Jadwal"].Rows.Find(code);

            if (dr != null)
            {
                dr.Delete();

                jadwalTableAdapter.Update(gYMDataSet);

                MessageBox.Show("Data berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
