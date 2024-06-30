using Gym_desktop.GYMDataSetTableAdapters;
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
    public partial class tambahJadwal : Form
    {
        DataTable dt;
        DataRow dr;
        String code;

        public tambahJadwal()
        {
            InitializeComponent();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(id_jadwal.Text) ||
                string.IsNullOrWhiteSpace(nama_jadwal.Text) ||
                string.IsNullOrWhiteSpace(hari_latihan.Text))
            {
                MessageBox.Show("Semua field harus diisi!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            dt = gYMDataSet.Tables["Jadwal"];

            dr = dt.NewRow();
            dr["Id_jadwal"] = id_jadwal.Text;
            dr["Nama_jadwal"] = nama_jadwal.Text;
            dr["Hari_latihan"] = hari_latihan.Text;
            dt.Rows.Add(dr);

            try
            {
                jadwalTableAdapter.Update(gYMDataSet);
                this.jadwalTableAdapter.Fill(this.gYMDataSet.Jadwal);

                MessageBox.Show("Data berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                id_jadwal.Enabled = false;
                nama_jadwal.Enabled = false;
                hari_latihan.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat menyimpan data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tambahJadwal_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gYMDataSet.Jadwal' table. You can move, or remove it, as needed.
            this.jadwalTableAdapter.Fill(this.gYMDataSet.Jadwal);

            int ctr, len;
            string codeval;

            dt = gYMDataSet.Tables["Jadwal"];
            len = dt.Rows.Count - 1;
            dr = dt.Rows[len];
            code = dr["Id_jadwal"].ToString();
            codeval = code.Substring(2, 3);
            ctr = Convert.ToInt32(codeval);

            if ((ctr >= 1) && (ctr < 9))
            {
                ctr = ctr + 1;
                id_jadwal.Text = "JD00" + ctr;
            }

            else if ((ctr >= 9) && (ctr <= 99))
            {
                ctr = ctr + 1;
                id_jadwal.Text = "JD0" + ctr;
            }

            else if (ctr > 999)
            {
                ctr = ctr + 1;
                id_jadwal.Text = "Mhs" + ctr;
            }

            id_jadwal.Enabled = false;

        }
    }
}
