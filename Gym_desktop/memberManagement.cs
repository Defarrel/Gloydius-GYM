using System;
using System.Windows.Forms;

namespace Gym_desktop
{
    public partial class memberManagement : Form
    {
        public memberManagement()
        {
            InitializeComponent();
        }

        private void btnTambahMember_Click(object sender, EventArgs e)
        {
            tambahMember tm = new tambahMember();
            tm.MdiParent = this.MdiParent;
            tm.Show();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            hapusMember hm = new hapusMember();
            hm.MdiParent = this.MdiParent;
            hm.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateMember um = new updateMember();
            um.MdiParent = this.MdiParent;
            um.Show();
        }

        private void btnLihat_Click(object sender, EventArgs e)
        {
            lihatMember lm = new lihatMember();
            lm.MdiParent = this.MdiParent;
            lm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
