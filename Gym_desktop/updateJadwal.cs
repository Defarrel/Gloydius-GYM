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
    public partial class updateJadwal : Form
    {

        DataTable dt;
        DataRow dr;
        public updateJadwal()
        {
            InitializeComponent();
        }

        private void updateJadwal_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gYMDataSet.Jadwal' table. You can move, or remove it, as needed.
            this.jadwalTableAdapter.Fill(this.gYMDataSet.Jadwal);

        }

        private void cari_Click(object sender, EventArgs e)
        {
            string searchID = textBoxID.Text.Trim();
            if (string.IsNullOrEmpty(searchID))
            {
                MessageBox.Show("Silakan masukkan nama jadwal untuk mencari.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataView dv = new DataView(gYMDataSet.Tables["Jadwal"]);
            dv.RowFilter = string.Format("Convert(Nama_jadwal, 'System.String') like '{0}%'", searchID);
            dataGridView1.DataSource = dv;

            if (dv.Count == 0)
            {
                MessageBox.Show("Tidak ada jadwal yang ditemukan dengan nama tersebut.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            textBoxID.Text = string.Empty;
            DataView dv = new DataView(gYMDataSet.Tables["Jadwal"]);
            dataGridView1.DataSource = dv;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                id_jadwal.Text = row.Cells[0].Value.ToString();
                nama_jadwal.Text = row.Cells[1].Value.ToString();
                hari_latihan.Text = row.Cells[2].Value.ToString();
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(id_jadwal.Text) ||
                string.IsNullOrWhiteSpace(nama_jadwal.Text) ||
                string.IsNullOrWhiteSpace(hari_latihan.Text))
            {
                MessageBox.Show("Semua field harus diisi!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            dt = gYMDataSet.Tables["Jadwal"];
            dr = dt.Rows.Find(id_jadwal.Text);

            dr.BeginEdit();
            dr["Id_jadwal"] = id_jadwal.Text;
            dr["Nama_jadwal"] = nama_jadwal.Text;
            dr["Hari_latihan"] = hari_latihan.Text;
            dr.EndEdit();

            try
            {
                jadwalTableAdapter.Update(gYMDataSet);
                this.jadwalTableAdapter.Fill(this.gYMDataSet.Jadwal);

                MessageBox.Show("Data berhasil diupdate!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                id_jadwal.Enabled = false;
                nama_jadwal.Enabled = false;
                hari_latihan.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat menyimpan data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
