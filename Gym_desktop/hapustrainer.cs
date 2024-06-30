using System;
using System.Data;
using System.Windows.Forms;

namespace Gym_desktop
{
    public partial class hapustrainer : Form
    {

        DataRow dr;
        public hapustrainer()
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

            dr = gYMDataSet.Tables["PersonalTrainer"].Rows.Find(code);

            if (dr != null)
            {
                dr.Delete();

                personalTrainerTableAdapter.Update(gYMDataSet);

                MessageBox.Show("Data berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void hapus_trainer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gYMDataSet.PersonalTrainer' table. You can move, or remove it, as needed.
            this.personalTrainerTableAdapter.Fill(this.gYMDataSet.PersonalTrainer);

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
