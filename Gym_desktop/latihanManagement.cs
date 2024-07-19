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
    public partial class latihanManagement : Form
    {
        public latihanManagement()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            tambahLatihan tl = new tambahLatihan();
            tl.MdiParent = this.MdiParent;
            tl.Show();
        }

        private void btnLihat_Click(object sender, EventArgs e)
        {
            lihatLatihan lt = new lihatLatihan();
            lt.MdiParent = this.MdiParent;
            lt.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updatelatihan ul = new updatelatihan();
            ul.MdiParent = this.MdiParent;
            ul.Show();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            hapusLatihan hl = new hapusLatihan();
            hl.MdiParent=this.MdiParent;
            hl.Show();
        }

        private void laporan_Click(object sender, EventArgs e)
        {
            laporanLatihan ll = new laporanLatihan();
            ll.MdiParent = this.MdiParent;
            ll.Show();  
        }
    }
}
