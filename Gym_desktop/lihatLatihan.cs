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
    public partial class lihatLatihan : Form
    {
        public lihatLatihan()
        {
            InitializeComponent();
        }

        private void lihatLatihan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gYMDataSet2.Latihan' table. You can move, or remove it, as needed.
            this.latihanTableAdapter.Fill(this.gYMDataSet2.Latihan);
            // TODO: This line of code loads data into the 'gYMDataSet2.Riwayat_latihan' table. You can move, or remove it, as needed.
            this.riwayat_latihanTableAdapter.Fill(this.gYMDataSet2.Riwayat_latihan);

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
