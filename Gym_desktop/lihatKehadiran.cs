using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_desktop
{
    public partial class lihatKehadiran : Form
    {
        string strKoneksi = "Data Source = DEFARREL; Initial Catalog = GYM;" +
"Integrated Security = True; MultipleActiveResultSets=true";
        public lihatKehadiran()
        {
            InitializeComponent();
        }

        private void lihatKehadiran_Load(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(strKoneksi);
            connection.Open();
            string query = "SELECT * FROM KehadiranTrainer";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dataTable);


            dataGridView1.DataSource = dataTable;

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
