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
    public partial class updatelatihan : Form
    {
        DataTable dt;
        DataRow dr;
        public updatelatihan()
        {
            InitializeComponent();
        }

        private void updatelatihan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gYMDataSet2.Latihan' table. You can move, or remove it, as needed.
            this.latihanTableAdapter.Fill(this.gYMDataSet2.Latihan);
            // TODO: This line of code loads data into the 'gYMDataSet2.Riwayat_latihan' table. You can move, or remove it, as needed.
            this.riwayat_latihanTableAdapter.Fill(this.gYMDataSet2.Riwayat_latihan);

        }

        private void cari_Click(object sender, EventArgs e)
        {
            string searchID = textBoxID.Text.Trim();
            if (string.IsNullOrEmpty(searchID))
            {
                MessageBox.Show("Silakan masukkan ID untuk mencari.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataView dv = new DataView(gYMDataSet2.Tables["Latihan"]);
            dv.RowFilter = string.Format("Convert(Id_latihan, 'System.String') like '{0}%'", searchID);
            dataGridView1.DataSource = dv;

            if (dv.Count == 0)
            {
                MessageBox.Show("ID tidak ditemukan.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            textBoxID.Text = string.Empty;
            DataView dv = new DataView(gYMDataSet2.Tables["Latihan"]);
            dataGridView1.DataSource = dv;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                ID.Text = row.Cells[0].Value.ToString();
                latihan.Text = row.Cells[1].Value.ToString();
                gerakan.Text = row.Cells[2].Value.ToString();
                if (row.Cells[3].Value != null && DateTime.TryParse(row.Cells[3].Value.ToString(), out DateTime tanggalValue))  
                {
                    tanggal.Value = tanggalValue;
                }
                durasi.Text = row.Cells[4].Value.ToString();
                if (row.Cells[5].Value != null && int.TryParse(row.Cells[5].Value.ToString(), out int memberValue))
                {
                    id_member.Text = memberValue.ToString();
                }
                else
                {
                    id_member.Text = "0";
                }
                id_trainer.Text = row.Cells[6].Value.ToString();
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void update_Click(object sender, EventArgs e)
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
            dr = dt.Rows.Find(ID.Text);

            dr.BeginEdit();
            dr["Id_latihan"] = ID.Text;
            dr["Jenis_latihan"] = latihan.Text;
            dr["Gerakan_gerakan"] = gerakan.Text;
            dr["Tgl_latihan"] = tanggal.Value;
            dr["Durasi_latihan"] = durasi.Text;
            dr["Id_member"] = memberValue;
            dr["Id_trainer"] = id_trainer.Text;
            dr.EndEdit();

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
    }
}
