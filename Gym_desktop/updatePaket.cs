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
    public partial class updatePaket : Form
    {

        DataTable dt;
        DataRow dr;
        public updatePaket()
        {
            InitializeComponent();
        }

        private void updatePaket_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gYMDataSet1.PaketMember' table. You can move, or remove it, as needed.
            this.paketMemberTableAdapter.Fill(this.gYMDataSet1.PaketMember);

        }

        private void cari_Click(object sender, EventArgs e)
        {
            string searchID = textBoxID.Text.Trim();
            if (string.IsNullOrEmpty(searchID))
            {
                MessageBox.Show("Silakan masukkan nama paket untuk mencari.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataView dv = new DataView(gYMDataSet1.Tables["PaketMember"]);
            dv.RowFilter = string.Format("Convert(Nama_paket, 'System.String') like '{0}%'", searchID);
            dataGridView1.DataSource = dv;

            if (dv.Count == 0)
            {
                MessageBox.Show("Tidak ada paket yang ditemukan dengan nama tersebut.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            textBoxID.Text = string.Empty;
            DataView dv = new DataView(gYMDataSet1.Tables["PaketMember"]);
            dataGridView1.DataSource = dv;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                id_paket.Text = row.Cells[0].Value.ToString();
                nama_paket.Text = row.Cells[1].Value.ToString();
                if (row.Cells[2].Value != null && decimal.TryParse(row.Cells[2].Value.ToString(), out decimal hargaValue))
                {
                    harga_paket.Text = hargaValue.ToString();
                }
                durasi.Text = row.Cells[3].Value.ToString();

            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void update_Click(object sender, EventArgs e)
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
            dr = dt.Rows.Find(id_paket.Text);

            dr.BeginEdit();

            dr["Id_paket"] = id_paket.Text;
            dr["Nama_paket"] = nama_paket.Text;
            dr["Harga_paket"] = decimal.Parse(harga_paket.Text);
            dr["Durasi_paket"] = durasi.Text;

            dr.EndEdit();

            paketMemberTableAdapter.Update(gYMDataSet1.PaketMember);

            MessageBox.Show("Data berhasil diupdate!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
