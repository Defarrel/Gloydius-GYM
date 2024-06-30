using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_desktop
{
    public partial class tambahLatihan : Form
    {

        DataTable dt;
        DataRow dr;
        String code;
        public tambahLatihan()
        {
            InitializeComponent();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ID.Text) ||
                string.IsNullOrWhiteSpace(latihan.Text) ||
                string.IsNullOrWhiteSpace(gerakan.Text) ||
                string.IsNullOrWhiteSpace(durasi.Text) ||
                string.IsNullOrWhiteSpace(id_member.Text) ||
                string.IsNullOrWhiteSpace(id_trainer.Text))
            {
                MessageBox.Show("Semua field harus diisi!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(id_member.Text, out int memberValue))
            {
                MessageBox.Show("Id Member dan Id trainer harus berupa angka!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dt = gYMDataSet2.Tables["Latihan"];

            dr = dt.NewRow();
            dr["Id_latihan"] = ID.Text;
            dr["Jenis_latihan"] = latihan.Text;
            dr["Gerakan_gerakan"] = gerakan.Text;
            dr["Tgl_latihan"] = tanggal.Value;
            dr["Durasi_latihan"] = durasi.Text;
            dr["Id_member"] = memberValue;
            dr["Id_trainer"] = id_trainer.Text;
            dt.Rows.Add(dr);

            latihanTableAdapter.Update(gYMDataSet2);

            this.latihanTableAdapter.Fill(this.gYMDataSet2.Latihan);

            ID.Enabled = false;
            latihan.Enabled = false;
            gerakan.Enabled = false;
            tanggal.Enabled = false;
            durasi.Enabled = false;
            id_member.Enabled = false;
            id_trainer.Enabled = false;

            MessageBox.Show("Data berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tambahLatihan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gYMDataSet2.Latihan' table. You can move, or remove it, as needed.
            this.latihanTableAdapter.Fill(this.gYMDataSet2.Latihan);

            int ctr, len;
            string codeval;

            dt = gYMDataSet2.Tables["Latihan"];
            len = dt.Rows.Count - 1;
            dr = dt.Rows[len];
            code = dr["Id_latihan"].ToString();
            codeval = code.Substring(2, 5);
            ctr = Convert.ToInt32(codeval);

            if ((ctr >= 1) && (ctr < 9))
            {
                ctr = ctr + 1;
                ID.Text = "JD0000" + ctr;
            }

            else if ((ctr >= 9) && (ctr <= 99))
            {
                ctr = ctr + 1;
                ID.Text = "JD000" + ctr;
            }

            else if ((ctr >= 99) && (ctr <= 999))
            {
                ctr = ctr + 1;
                ID.Text = "JD00" + ctr;
            }

            else if ((ctr >= 999) && (ctr <= 9999))
            {
                ctr = ctr + 1;
                ID.Text = "JD0" + ctr;
            }

            else if (ctr > 99999)
            {
                ctr = ctr + 1;
                ID.Text = "JD" + ctr;
            }

            ID.Enabled = false;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
