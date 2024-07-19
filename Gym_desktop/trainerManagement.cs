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
    public partial class trainerManagement : Form
    {
        public trainerManagement()
        {
            InitializeComponent();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            tambahTransaksi Tt = new tambahTransaksi();
            Tt.MdiParent = this.MdiParent;
            Tt.Show();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            hapustrainer ht = new hapustrainer();
            ht.MdiParent = this.MdiParent;
            ht.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateTrainer ut = new updateTrainer();
            ut.MdiParent = this.MdiParent;
            ut.Show();
        }

        private void btnLihat_Click(object sender, EventArgs e)
        {
            lihatTrainer lt = new lihatTrainer();
            lt.MdiParent = this.MdiParent;
            lt.Show();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bntImport_Click(object sender, EventArgs e)
        {
            importData id = new importData();
            id.MdiParent = this.MdiParent;
            id.Show();
        }
    }
}
