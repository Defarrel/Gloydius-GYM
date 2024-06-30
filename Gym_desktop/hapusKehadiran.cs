using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_desktop
{
    public partial class hapusKehadiran : Form
    {
        DataRow dr;
        public hapusKehadiran()
        {
            InitializeComponent();
        }

        private void hapusKehadiran_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gYMDataSet2.KehadiranTrainer' table. You can move, or remove it, as needed.
            this.kehadiranTrainerTableAdapter.Fill(this.gYMDataSet2.KehadiranTrainer);

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

            dr = gYMDataSet2.Tables["KehadiranTrainer"].Rows.Find(code);

            if (dr != null)
            {
                dr.Delete();

                kehadiranTrainerTableAdapter.Update(gYMDataSet2);

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
    }
}
