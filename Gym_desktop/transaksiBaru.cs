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
    public partial class transaksiBaru : Form
    {
        DataTable dt;
        DataRow dr;
        public transaksiBaru()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tanggal_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnTambah_Click(object sender, EventArgs e)
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

                dr = dt.NewRow();
                dr["Tanggal_transaksi"] = tanggal.Value;
                dr["Total"] = totalValue;
                dr["Id_member"] = idMemberValue;
                dr["Id_paket"] = idPaket.Text;
                dt.Rows.Add(dr);

                transaksiTableAdapter.Update(gYMDataSet);

                this.transaksiTableAdapter.Fill(this.gYMDataSet.Transaksi);

                tanggal.Enabled = false;
                total.Enabled = false;
                idMember.Enabled = false;
                idPaket.Enabled = false;

                MessageBox.Show("Data berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
          

        }

        private void transaksiBaru_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gYMDataSet.Transaksi' table. You can move, or remove it, as needed.
            this.transaksiTableAdapter.Fill(this.gYMDataSet.Transaksi);

        }
    }
}
