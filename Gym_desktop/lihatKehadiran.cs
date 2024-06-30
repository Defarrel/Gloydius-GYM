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
    public partial class lihatKehadiran : Form
    {
        public lihatKehadiran()
        {
            InitializeComponent();
        }

        private void lihatKehadiran_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gYMDataSet2.KehadiranTrainer' table. You can move, or remove it, as needed.
            this.kehadiranTrainerTableAdapter.Fill(this.gYMDataSet2.KehadiranTrainer);

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
