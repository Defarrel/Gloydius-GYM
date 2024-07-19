using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Gym_desktop
{
    public partial class lihatMember : Form
    {
        string strKoneksi = "Data Source = DEFARREL; Initial Catalog = GYM;" +
    "Integrated Security = True; MultipleActiveResultSets=true";

        public lihatMember()
        {
            InitializeComponent();
        }

        private void lihatMember_Load(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(strKoneksi);
            connection.Open();
            string query = "SELECT * FROM Member";
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
