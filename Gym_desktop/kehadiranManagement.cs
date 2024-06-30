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
    public partial class kehadiranManagement : Form
    {
        public kehadiranManagement()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            tambahKehadiran tk = new tambahKehadiran();
            tk.MdiParent = this.MdiParent;
            tk.Show();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            hapusKehadiran hk = new hapusKehadiran();
            hk.MdiParent = this.MdiParent;
            hk.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateKehadiran uk = new updateKehadiran();
            uk.MdiParent = this.MdiParent;
            uk.Show();
        }

        private void btnLihat_Click(object sender, EventArgs e)
        {
            lihatKehadiran lk = new lihatKehadiran();
            lk.MdiParent= this.MdiParent;
            lk.Show();
        }
    }
}
