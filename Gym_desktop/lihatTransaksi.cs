using System;
using System.Windows.Forms;

namespace Gym_desktop
{
    public partial class lihatTransaksi : Form
    {
        public lihatTransaksi()
        {
            InitializeComponent();
        }

        private void lihatTransaksi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gYMDataSet.Transaksi' table. You can move, or remove it, as needed.
            this.transaksiTableAdapter.Fill(this.gYMDataSet.Transaksi);

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
