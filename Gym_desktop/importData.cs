using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelDataReader;

namespace Gym_desktop
{
    public partial class importData : Form
    {
        public importData()
        {
            InitializeComponent();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog { Filter = "Excel Workbook|*.xlsx" })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read))
                    {
                        using (var reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            var result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration { UseHeaderRow = true }

                            });
                            DataTable dataTable = result.Tables[0];

                            dataGridView1.DataSource = dataTable;

                            string connectionString = "Data source = DEFARREL;" +
                                "Initial Catalog = GYM;Integrated Security=True";
                            using (SqlConnection conn = new SqlConnection(connectionString))
                            {
                                using (SqlBulkCopy bulkCopy = new SqlBulkCopy(conn))
                                {
                                    bulkCopy.DestinationTableName = "dbo.PersonalTrainer";
                                    conn.Open();
                                    bulkCopy.WriteToServer(dataTable);
                                    MessageBox.Show("Data Imported and displayed successfully");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
