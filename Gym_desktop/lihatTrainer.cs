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
    public partial class lihatTrainer : Form
    {
        public lihatTrainer()
        {
            InitializeComponent();
        }

        private void lihatTrainer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gYMDataSet.PersonalTrainer' table. You can move, or remove it, as needed.
            this.personalTrainerTableAdapter.Fill(this.gYMDataSet.PersonalTrainer);

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
