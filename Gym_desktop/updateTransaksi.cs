using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Gym_desktop
{
    public partial class updateTransaksi : Form
    {

        DataTable dt;
        DataRow dr;
        Image curImage;
        string curFIleName;
        public updateTransaksi()
        {
            InitializeComponent();
        }

        private void updateTransaksi_Load(object sender, EventArgs e)
        {
            // This line of code loads data into the 'gYMDataSet.Transaksi' table. You can move, or remove it, as needed.
            this.transaksiTableAdapter.Fill(this.gYMDataSet.Transaksi);

            ID.Enabled = false;
            idMember.Enabled = false;
        }


        private void cari_Click(object sender, EventArgs e)
        {
            string searchID = textBoxID.Text.Trim();
            if (string.IsNullOrEmpty(searchID))
            {
                MessageBox.Show("Silakan masukkan ID untuk mencari.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataView dv = new DataView(gYMDataSet.Tables["Transaksi"]);
            dv.RowFilter = string.Format("Convert(Id_transaksi, 'System.String') like '{0}%'", searchID);
            dataGridView1.DataSource = dv;

            if (dv.Count == 0)
            {
                MessageBox.Show("ID tidak ditemukan.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            textBoxID.Text = string.Empty;
            DataView dv = new DataView(gYMDataSet.Tables["Transaksi"]);
            dataGridView1.DataSource = dv;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                if (row.Cells[0].Value != null && int.TryParse(row.Cells[0].Value.ToString(), out int idValue))
                {
                    ID.Text = idValue.ToString();
                }

                if (row.Cells[1].Value != null && DateTime.TryParse(row.Cells[1].Value.ToString(), out DateTime tanggalvalue))  
                {
                    tanggal.Value = tanggalvalue;
                }
                if (row.Cells[2].Value != null && decimal.TryParse(row.Cells[2].Value.ToString(), out decimal totalValue))
                {
                    total.Text = totalValue.ToString();
                }
                else
                {
                    total.Text = "0";
                }
                if (row.Cells[3].Value != null && int.TryParse(row.Cells[3].Value.ToString(), out int memberValue))
                {
                    idMember.Text = memberValue.ToString();
                }
                else
                {
                    idMember.Text = "0";
                }
                idPaket.Text = row.Cells[4].Value.ToString();
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tanggal.Text) ||
              string.IsNullOrWhiteSpace(total.Text) ||
              string.IsNullOrWhiteSpace(idMember.Text) ||
              string.IsNullOrWhiteSpace(idPaket.Text))
            {
                MessageBox.Show("Semua field harus diisi!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(total.Text, out decimal totalValue))
            {
                MessageBox.Show("Total harus berupa angka!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(idMember.Text, out int idMemberValue))
            {
                MessageBox.Show("ID Member harus berupa angka!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dt = gYMDataSet.Tables["Transaksi"];
            dr = dt.Rows.Find(ID.Text);

            dr.BeginEdit();
            dr["Tanggal_transaksi"] = tanggal.Value;
            dr["Total"] = totalValue;
            dr["Id_member"] = idMemberValue;
            dr["Id_paket"] = idPaket.Text;
            dr.EndEdit();

            transaksiTableAdapter.Update(gYMDataSet);

            this.transaksiTableAdapter.Fill(this.gYMDataSet.Transaksi);

            tanggal.Enabled = false;
            total.Enabled = false;
            idMember.Enabled = false;
            idPaket.Enabled = false;
        }
    }
}
