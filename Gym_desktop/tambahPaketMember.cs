using System;
using System.Data;
using System.Drawing;
using System.Runtime.ConstrainedExecution;
using System.Windows.Forms;

namespace Gym_desktop
{
    public partial class tambahPaketMember : Form
    {
        DataTable dt;
        DataRow dr;
        String code;

        public tambahPaketMember()
        {
            InitializeComponent();
        }


        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(id_paket.Text) ||
                string.IsNullOrWhiteSpace(nama_paket.Text) ||
                string.IsNullOrWhiteSpace(harga_paket.Text) ||
                string.IsNullOrWhiteSpace(durasi.Text))
            {
                MessageBox.Show("Semua field harus diisi!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(harga_paket.Text, out decimal hargaValue))
            {
                MessageBox.Show("Harga harus berupa angka!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            dt = gYMDataSet1.Tables["PaketMember"];

            dr = dt.NewRow();

            dr["Id_paket"] = id_paket.Text;
            dr["Nama_paket"] = nama_paket.Text;
            dr["Harga_paket"] = decimal.Parse(harga_paket.Text);
            dr["Durasi_paket"] = durasi.Text;

            dt.Rows.Add(dr);

            paketMemberTableAdapter.Update(gYMDataSet1.PaketMember);

            MessageBox.Show("Paket member berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tambahPaketMember_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gYMDataSet1.PaketMember' table. You can move, or remove it, as needed.
            this.paketMemberTableAdapter.Fill(this.gYMDataSet1.PaketMember);

            int ctr, len;
            string codeval;

            dt = gYMDataSet1.Tables["PaketMember"];
            len = dt.Rows.Count - 1;
            dr = dt.Rows[len];
            code = dr["Id_paket"].ToString();
            codeval = code.Substring(2, 3);
            ctr = Convert.ToInt32(codeval);

            if ((ctr >= 1) && (ctr < 9))
            {
                ctr = ctr + 1;
                id_paket.Text = "PK00" + ctr;
            }

            else if ((ctr >= 9) && (ctr <= 99))
            {
                ctr = ctr + 1;
                id_paket.Text = "PK0" + ctr;
            }

            else if (ctr > 999)
            {
                ctr = ctr + 1;
                id_paket.Text = "Mhs" + ctr;
            }

            id_paket.Enabled = false;
        }
    }
}
