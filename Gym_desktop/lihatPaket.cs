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
    public partial class lihatPaket : Form
    {
        public lihatPaket()
        {
            InitializeComponent();
        }

        private void lihatPaket_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gYMDataSet1.PaketMember' table. You can move, or remove it, as needed.
            this.paketMemberTableAdapter.Fill(this.gYMDataSet1.PaketMember);

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
