using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Gym_desktop
{
    public partial class diagramPaket : Form
    {
        string strKoneksi = "Data Source=DEFARREL;Initial Catalog=GYM;Integrated Security=True;MultipleActiveResultSets=true";

        public diagramPaket()
        {
            InitializeComponent();
            display();
        }

        private void display(DateTime? startDate = null, DateTime? endDate = null)
        {
            using (SqlConnection koneksi = new SqlConnection(strKoneksi))
            {
                koneksi.Open();

                string query = "SELECT p.Nama_paket, SUM(t.Total) AS TotalPendapatan, COUNT(t.Id_transaksi) AS TotalTransaksi FROM Transaksi t " +
                    "INNER JOIN PaketMember p ON t.Id_paket = p.Id_paket {0} GROUP BY p.Nama_paket;";

                string dateFilter = "";
                if (startDate.HasValue && endDate.HasValue)
                {
                    dateFilter = "WHERE t.Tanggal_transaksi BETWEEN @StartDate AND @EndDate";
                }
                query = string.Format(query, dateFilter);

                SqlCommand cmd = new SqlCommand(query, koneksi);
                if (startDate.HasValue && endDate.HasValue)
                {
                    cmd.Parameters.AddWithValue("@StartDate", startDate.Value);
                    cmd.Parameters.AddWithValue("@EndDate", endDate.Value);
                }

                SqlDataReader dr = cmd.ExecuteReader();

                List<string> paketArr = new List<string>();
                List<double> pendapatanArr = new List<double>();
                int totalTransaksi = 0;
                double totalPendapatan = 0;

                while (dr.Read())
                {
                    paketArr.Add(dr["Nama_paket"].ToString());
                    double pendapatan = Convert.ToDouble(dr["TotalPendapatan"]);
                    pendapatanArr.Add(pendapatan);
                    totalPendapatan += pendapatan;

                    totalTransaksi += Convert.ToInt32(dr["TotalTransaksi"]);
                }
                dr.Close();
                koneksi.Close();

                if (paketArr.Count != 0)
                {
                    chart1.Series.Clear();
                    chart1.Titles.Clear();

                    chart1.Titles.Add("Total Pendapatan Per Paket Member");
                    Series series = chart1.Series.Add("Total Pendapatan");
                    series.ChartType = SeriesChartType.Pie;
                    series.IsValueShownAsLabel = true;

                    for (int i = 0; i < paketArr.Count; i++)
                    {
                        DataPoint point = new DataPoint();
                        point.AxisLabel = paketArr[i];
                        point.YValues = new double[] { pendapatanArr[i] };
                        point.Label = "Rp " + pendapatanArr[i].ToString("#,##0");

                        series.Points.Add(point);

                        series.Points[i].LegendText = paketArr[i];
                    }

                    chart1.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.White;
                    chart1.Legends[0].Enabled = true;

                    total.Text = "Rp " + totalPendapatan.ToString("#,##0");
                    transaksi.Text = totalTransaksi.ToString();
                }
                else
                {
                    MessageBox.Show("Data Tidak Ada", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            DateTime startDate = dateTimePicker1.Value;
            DateTime endDate = dateTimePicker2.Value;

            display(startDate, endDate);
        }

        private void total_TextChanged(object sender, EventArgs e)
        {
            total.Enabled = false;
        }

        private void transaksi_TextChanged(object sender, EventArgs e)
        {
            transaksi.Enabled = false;
        }
    }
}
