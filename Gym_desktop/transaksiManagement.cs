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
            tambahTransaksi Tt = new tambahTransaksi();
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
