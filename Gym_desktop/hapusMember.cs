using Gym_desktop.GYMDataSetTableAdapters;
using System;
using System.Data;
using System.Windows.Forms;

namespace Gym_desktop
{
    public partial class hapusMember : Form
    {
        DataRow dr;


        public hapusMember()
        {
            InitializeComponent();
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

            dr = gYMDataSet.Tables["Member"].Rows.Find(code);

            if (dr != null)
            {
                dr.Delete();

                memberTableAdapter.Update(gYMDataSet);

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

        private void hapusMember_Load(object sender, EventArgs e)
        {
            this.memberTableAdapter.Fill(this.gYMDataSet.Member);
        }
    }
}
