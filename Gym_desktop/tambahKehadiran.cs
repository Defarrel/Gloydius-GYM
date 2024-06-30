using System;
using System.Data;
using System.Windows.Forms;

namespace Gym_desktop
{
    public partial class tambahKehadiran : Form
    {
        DataTable dt;
        DataRow dr;
        String code;

        public void cbx()
        {
            //menambah item pada combobox
            kehadiran.Items.Add("hadir");
            kehadiran.Items.Add("tidak hadir");

        }
        public tambahKehadiran()
        {
            InitializeComponent();
            cbx();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ID.Text) ||
                string.IsNullOrWhiteSpace(kehadiran.Text) ||
                string.IsNullOrWhiteSpace(id_trainer.Text) ||
                string.IsNullOrWhiteSpace(id_jadwal.Text))

            {
                MessageBox.Show("Semua field harus diisi!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dt = gYMDataSet2.Tables["KehadiranTrainer"];

            dr = dt.NewRow();
            dr["Id_kehadiran"] = ID.Text;
            dr["Kehadiran"] = kehadiran.Text;
            dr["Tanggal_kehadiran"] = tanggal.Value;
            dr["Id_trainer"] = id_trainer.Text;
            dr["Id_jadwal"] = id_jadwal.Text;
            dt.Rows.Add(dr);

            kehadiranTrainerTableAdapter.Update(gYMDataSet2);

            this.kehadiranTrainerTableAdapter.Fill(this.gYMDataSet2.KehadiranTrainer);

            ID.Enabled = false;
            kehadiran.Enabled = false;
            tanggal.Enabled = false;
            tanggal.Enabled = false;
            id_trainer.Enabled = false;
            id_jadwal.Enabled = false;

            MessageBox.Show("Data berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tambahKehadiran_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gYMDataSet2.KehadiranTrainer' table. You can move, or remove it, as needed.
            this.kehadiranTrainerTableAdapter.Fill(this.gYMDataSet2.KehadiranTrainer);

            int ctr, len;
            string codeval;

            dt = gYMDataSet2.Tables["KehadiranTrainer"];
            len = dt.Rows.Count - 1;
            dr = dt.Rows[len];
            code = dr["Id_kehadiran"].ToString();
            codeval = code.Substring(2, 3);
            ctr = Convert.ToInt32(codeval);

            if ((ctr >= 1) && (ctr < 9))
            {
                ctr = ctr + 1;
                ID.Text = "KH00" + ctr;
            }

            else if ((ctr >= 9) && (ctr <= 99))
            {
                ctr = ctr + 1;
                ID.Text = "KH0" + ctr;
            }

            else if (ctr > 999)
            {
                ctr = ctr + 1;
                ID.Text = "Mhs" + ctr;
            }

            ID.Enabled = false;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
