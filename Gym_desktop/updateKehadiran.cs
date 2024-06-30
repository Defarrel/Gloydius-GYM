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

    public partial class updateKehadiran : Form
    {
        DataTable dt;
        DataRow dr;
        public updateKehadiran()
        {
            InitializeComponent();
        }

        private void updateKehadiran_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gYMDataSet2.KehadiranTrainer' table. You can move, or remove it, as needed.
            this.kehadiranTrainerTableAdapter.Fill(this.gYMDataSet2.KehadiranTrainer);

        }

        private void cari_Click(object sender, EventArgs e)
        {
            string searchID = textBoxID.Text.Trim();
            if (string.IsNullOrEmpty(searchID))
            {
                MessageBox.Show("Silakan masukkan ID untuk mencari.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataView dv = new DataView(gYMDataSet2.Tables["KehadiranTrainer"]);
            dv.RowFilter = string.Format("Convert(Id_kehadiran, 'System.String') like '{0}%'", searchID);
            dataGridView1.DataSource = dv;

            if (dv.Count == 0)
            {
                MessageBox.Show("Tidak ada ID yang ditemukan.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            textBoxID.Text = string.Empty;
            DataView dv = new DataView(gYMDataSet2.Tables["KehadiranTrainer"]);
            dataGridView1.DataSource = dv;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                ID.Text = row.Cells[0].Value.ToString();
                kehadiran.Text = row.Cells[1].Value.ToString();
                if (row.Cells[2].Value != null && DateTime.TryParse(row.Cells[4].Value.ToString(), out DateTime tanggalValue)) 
                {
                    tanggal.Value = tanggalValue;
                }
                id_trainer.Text = row.Cells[3].Value.ToString();
                id_jadwal.Text = row.Cells[4].Value.ToString();
            }
        }

        private void update_Click(object sender, EventArgs e)
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
            dr = dt.Rows.Find(ID.Text);

            dr.BeginEdit();
            dr["Id_kehadiran"] = ID.Text;
            dr["Kehadiran"] = kehadiran.Text;
            dr["Tanggal_kehadiran"] = tanggal.Value;
            dr["Id_trainer"] = id_trainer.Text;
            dr["Id_jadwal"] = id_jadwal.Text;
            dr.EndEdit();

            kehadiranTrainerTableAdapter.Update(gYMDataSet2);

            this.kehadiranTrainerTableAdapter.Fill(this.gYMDataSet2.KehadiranTrainer);

            ID.Enabled = false;
            kehadiran.Enabled = false;
            tanggal.Enabled = false;
            tanggal.Enabled = false;
            id_trainer.Enabled = false;
            id_jadwal.Enabled = false;

            MessageBox.Show("Data berhasil diupdate!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
