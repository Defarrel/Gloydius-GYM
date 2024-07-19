using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Gym_desktop
{
    public partial class lihatTransaksi : Form
    {
        string strKoneksi = "Data Source = DEFARREL; Initial Catalog = GYM;" +
"Integrated Security = True; MultipleActiveResultSets=true";
        public lihatTransaksi()
        {
            InitializeComponent();
        }

        private void lihatTransaksi_Load(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(strKoneksi);
            connection.Open();
            string query = "SELECT * FROM Transaksi";
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
