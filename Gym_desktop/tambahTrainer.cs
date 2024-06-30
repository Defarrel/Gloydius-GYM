using System;
using System.Data;
using System.Windows.Forms;

namespace Gym_desktop
{
    public partial class tambahTrainer : Form
    {
        DataTable dt;
        DataRow dr;
        String code;

        public tambahTrainer()
        {
            InitializeComponent();
        }

        private void btnTambah_Click(object sender, EventArgs e)
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

            dr = dt.NewRow();
            dr["Id_trainer"] = id_trainer.Text;
            dr["Nama_trainer"] = nama_trainer.Text;
            dr["No_hp_trainer"] = no_hp.Text;
            dt.Rows.Add(dr);

            try
            {
                personalTrainerTableAdapter.Update(gYMDataSet);
                this.personalTrainerTableAdapter.Fill(this.gYMDataSet.PersonalTrainer);

                MessageBox.Show("Data berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void tambahTrainer_Load(object sender, EventArgs e)
        {
            // This line of code loads data into the 'gYMDataSet.PersonalTrainer' table. You can move, or remove it, as needed.
            this.personalTrainerTableAdapter.Fill(this.gYMDataSet.PersonalTrainer);

            int ctr, len;
            string codeval;

            dt = gYMDataSet.Tables["PersonalTrainer"];
            len = dt.Rows.Count - 1;
            dr = dt.Rows[len];
            code = dr["Id_trainer"].ToString();
            codeval = code.Substring(2, 3);
            ctr = Convert.ToInt32(codeval);

            if ((ctr >= 1) && (ctr < 9))
            {
                ctr = ctr + 1;
                id_trainer.Text = "PT00" + ctr;
            }

            else if ((ctr >= 9) && (ctr <= 99))
            {
                ctr = ctr + 1;
                id_trainer.Text = "PT0" + ctr;
            }

            else if (ctr > 999)
            {
                ctr = ctr + 1;
                id_trainer.Text = "Mhs" + ctr;
            }

            id_trainer.Enabled = false;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
