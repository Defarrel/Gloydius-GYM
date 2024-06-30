using System;
using System.Windows.Forms;

namespace Gym_desktop
{
    public partial class tambahTransaksi : Form
    {
        public tambahTransaksi()
        {
            InitializeComponent();
        }

        private void btnMemberbaru_Click(object sender, EventArgs e)
        {
            tambahMember tm = new tambahMember();
            tm.MdiParent = this.MdiParent;
            tm.Show();
        }

        private void btnTransaksibaru_Click(object sender, EventArgs e)
        {
            transaksiBaru tb = new transaksiBaru();
            tb.MdiParent = this.MdiParent;
            tb.Show();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
