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
    public partial class jadwalManagement : Form
    {
        public jadwalManagement()
        {
            InitializeComponent();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            tambahJadwal tj = new tambahJadwal();
            tj.MdiParent = this.MdiParent;
            tj.Show();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            hapusJadwal hj = new hapusJadwal();
            hj.MdiParent = this.MdiParent;
            hj.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateJadwal uj = new updateJadwal();
            uj.MdiParent = this.MdiParent;
            uj.Show();
        }

        private void btnLihat_Click(object sender, EventArgs e)
        {
            lihatJadwal lj = new lihatJadwal();
            lj.MdiParent= this.MdiParent;
            lj.Show();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void jadwalManagement_Load(object sender, EventArgs e)
        {

        }
    }
}
