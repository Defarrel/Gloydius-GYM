using System;
using System.Data;
using System.Windows.Forms;

namespace Gym_desktop
{
    public partial class updateTrainer : Form
    {

        DataTable dt;
        DataRow dr;
        public updateTrainer()
        {
            InitializeComponent();
        }

        private void updateTrainer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gYMDataSet.PersonalTrainer' table. You can move, or remove it, as needed.
            this.personalTrainerTableAdapter.Fill(this.gYMDataSet.PersonalTrainer);
        }


        private void cari_Click(object sender, EventArgs e)
        {
            string searchID = textBoxID.Text.Trim();
            if (string.IsNullOrEmpty(searchID))
            {
                MessageBox.Show("Silakan masukkan Nama untuk mencari.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataView dv = new DataView(gYMDataSet.Tables["PersonalTrainer"]);
            dv.RowFilter = string.Format("Convert(Nama_trainer, 'System.String') like '{0}%'", searchID);
            dataGridView1.DataSource = dv;

            if (dv.Count == 0)
            {
                MessageBox.Show("Tidak ada trainer yang ditemukan dengan nama tersebut.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            textBoxID.Text = string.Empty;
            DataView dv = new DataView(gYMDataSet.Tables["PersonalTrainer"]);
            dataGridView1.DataSource = dv;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                id_trainer.Text = row.Cells[0].Value.ToString();
                nama_trainer.Text = row.Cells[1].Value.ToString();
                no_hp.Text = row.Cells[2].Value.ToString();

            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(id_trainer.Text) ||
                string.IsNullOrWhiteSpace(nama_trainer.Text) ||
                string.IsNullOrWhiteSpace(no_hp.Text))
            {
                MessageBox.Show("Semua field harus diisi!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (no_hp.Text.Length != 12 || !IsNumeric(no_hp.Text))
            {
                MessageBox.Show("Nomor hp harus terdiri dari 12 digit angka!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dt = gYMDataSet.Tables["PersonalTrainer"];
            dr = dt.Rows.Find(id_trainer.Text);

            dr.BeginEdit();
            dr["Id_trainer"] = id_trainer.Text;
            dr["Nama_trainer"] = nama_trainer.Text;
            dr["No_hp_trainer"] = no_hp.Text;
            dr.EndEdit();

            try
            {
                personalTrainerTableAdapter.Update(gYMDataSet);
                this.personalTrainerTableAdapter.Fill(this.gYMDataSet.PersonalTrainer);

                MessageBox.Show("Data berhasil diupdate!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                id_trainer.Enabled = false;
                nama_trainer.Enabled = false;
                no_hp.Enabled = false;
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
    }
}
