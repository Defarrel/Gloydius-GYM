using System;
using System.Windows.Forms;

namespace Gym_desktop
{
    public partial class Menu_utama : Form
    {

        public Menu_utama()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           memberManagement Mm = new memberManagement();
            Mm.MdiParent = this;
            Mm.Show();
            Mm.FormClosed += (s, args) => panel2.Visible = true;
            panel2.Visible = false;
        }

        private void Menu_utama_Load(object sender, EventArgs e)
        {
            panel2.Visible=true;
        }

        private void btnPaket_Click(object sender, EventArgs e)
        {
            paketManagement pm = new paketManagement();
            pm.MdiParent = this;
            pm.Show();
            pm.FormClosed += (s, args) => panel2.Visible = true;
            panel2.Visible = false;
        }

        private void btnTransaksi_Click(object sender, EventArgs e)
        {
            transaksiManagement tm = new transaksiManagement();
            tm.MdiParent = this;
            tm.Show();
            tm.FormClosed += (s, args) => panel2.Visible = true;
            panel2.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            trainerManagement tm = new trainerManagement();
            tm.MdiParent = this;
            tm.Show();
            tm.FormClosed += (s, args) => panel2.Visible = true;
            panel2.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            jadwalManagement jm = new jadwalManagement();
            jm.MdiParent = this;
            jm.Show();
            jm.FormClosed += (s, args) => panel2.Visible = true;
            panel2.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            latihanManagement lm = new latihanManagement();
            lm .MdiParent = this;
            lm .Show();
            lm.FormClosed += (s, args) => panel2.Visible = true;
            panel2.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            kehadiranManagement km = new kehadiranManagement();
            km .MdiParent = this;
            km .Show();
            km.FormClosed += (s, args) => panel2.Visible = true;
            panel2.Visible = false;
        }

        private void member_Click(object sender, EventArgs e)
        {
            memberManagement Mm = new memberManagement();
            Mm.MdiParent = this;
            Mm.Show();
            Mm.FormClosed += (s, args) => panel2.Visible = true;
            panel2.Visible = false;
        }

        private void paket_Click(object sender, EventArgs e)
        {
            paketManagement pm = new paketManagement();
            pm.MdiParent = this;
            pm.Show();
            pm.FormClosed += (s, args) => panel2.Visible = true;
            panel2.Visible = false;
        }

        private void latihan_Click(object sender, EventArgs e)
        {
            latihanManagement lm = new latihanManagement();
            lm.MdiParent = this;
            lm.Show();
            lm.FormClosed += (s, args) => panel2.Visible = true;
            panel2.Visible = false;
        }

        private void transaksi_Click(object sender, EventArgs e)
        {
            transaksiManagement tm = new transaksiManagement();
            tm.MdiParent = this;
            tm.Show();
            tm.FormClosed += (s, args) => panel2.Visible = true;
            panel2.Visible = false;
        }

        private void trainer_Click(object sender, EventArgs e)
        {
            trainerManagement tm = new trainerManagement();
            tm.MdiParent = this;
            tm.Show();
            tm.FormClosed += (s, args) => panel2.Visible = true;
            panel2.Visible = false;
        }

        private void jadwal_Click(object sender, EventArgs e)
        {
            jadwalManagement jm = new jadwalManagement();
            jm.MdiParent = this;
            jm.Show();
            jm.FormClosed += (s, args) => panel2.Visible = true;
            panel2.Visible = false;
        }

        private void kehadiran_Click(object sender, EventArgs e)
        {
            kehadiranManagement km = new kehadiranManagement();
            km.MdiParent = this;
            km.Show();
            km.FormClosed += (s, args) => panel2.Visible = true;
            panel2.Visible = false;
        }
    }
}

