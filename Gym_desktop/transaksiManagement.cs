using System;
using System.Windows.Forms;

namespace Gym_desktop
{
    public partial class transaksiManagement : Form
    {
        public transaksiManagement()
        {
            InitializeComponent();
        }

        private void btnLihatTransaksi_Click(object sender, EventArgs e)
        {
            lihatTransaksi lt = new lihatTransaksi();
            lt.MdiParent = this.MdiParent;
            lt.Show();
        }

        private void TambahPaketMember_Click(object sender, EventArgs e)
        {
            transaksiBaru Tt = new transaksiBaru();
            Tt.MdiParent = this.MdiParent;
            Tt.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateTransaksi ut = new updateTransaksi();
            ut.MdiParent = this.MdiParent;
            ut.Show();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
