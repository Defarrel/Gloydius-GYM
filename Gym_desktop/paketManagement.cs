using System;
using System.Windows.Forms;

namespace Gym_desktop
{
    public partial class paketManagement : Form
    {
        public paketManagement()
        {
            InitializeComponent();
        }

        private void TambahPaketMember_Click(object sender, EventArgs e)
        {
            tambahPaketMember tp = new tambahPaketMember();
            tp.MdiParent = this.MdiParent;
            tp.Show();
        }

        private void btnHapusPaket_Click(object sender, EventArgs e)
        {
            hapusPaket hm = new hapusPaket();
            hm.MdiParent = this.MdiParent;
            hm.Show();
        }

        private void btnLihatPaket_Click(object sender, EventArgs e)
        {
            lihatPaket lp = new lihatPaket();
            lp.MdiParent = this.MdiParent;
            lp.Show();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updatePaket up = new updatePaket();
            up.MdiParent = this.MdiParent;
            up.Show();
        }
    }
}
