using System;
using System.Data;
using System.Windows.Forms;

namespace Gym_desktop
{
    public partial class hapusPaket : Form
    {
        DataRow dr;
        public hapusPaket()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
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

            dr = gYMDataSet1.Tables["PaketMember"].Rows.Find(code);

            if (dr != null)
            {
                dr.Delete();

                paketMemberTableAdapter.Update(gYMDataSet1);

                MessageBox.Show("Data berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void hapusPaket_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gYMDataSet1.PaketMember' table. You can move, or remove it, as needed.
            this.paketMemberTableAdapter.Fill(this.gYMDataSet1.PaketMember);

        }
    }
}
