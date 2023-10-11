using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms.DataVisualization.Charting;

namespace Product
{

    public partial class productform : Form
    {
        string connectionString = "Data Source=DESKTOP-8MVAM1C;Initial Catalog=Hamburger;User ID=test;Password=0000;";
        private static string startDateString = "2023-10-02";
        private static string endDateString = "2023-10-07";




        public productform()
        {
            // 원하는 날짜를 생성
            DateTimePicker datepicker2 = new DateTimePicker();
            DateTime startDate = DateTime.Parse(startDateString);

            Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // 1초
           
            timer.Start();




            InitializeComponent();

        }
        #region sql문
        private void productform_Load(object sender, EventArgs e)
        {

            update();


        }

        public void update()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string selection = "";


                connection.Open();

                #region 체크박스 
                ///////////체크박스에 맞는 경우에 수 만들기
                if (cboxMonsterX.Checked)
                {
                    if (selection == "")
                    {
                        selection += " AND (product_name = 'monsterX'";//만약 처음이면 and이고
                    }
                    else { selection += " OR product_name = 'monsterX'"; }//기존에 체크된것이 있다면 or
                }



                if (cboxCheese.Checked)
                {
                    if (selection == "")
                    {
                        selection += " AND (product_name = 'CheeseWhaper'";
                    }
                    else { selection += " OR product_name = 'CheeseWhaper'"; }

                }

                if (cboxBulgogiWhaper.Checked)
                {
                    if (selection == "")
                    {
                        selection += " AND (product_name = 'BulgogiWhaper'";
                    }
                    else { selection += " OR product_name = 'BulgogiWhaper'"; }

                }

                if (cboxShrimpWhaper.Checked)
                {
                    if (selection == "")
                    {
                        selection += " AND (product_name = 'ShrimpWhaper'";
                    }
                    else { selection += " OR product_name = 'ShrimpWhaper'"; }

                }



                if (selection != "") { selection += ")"; }
                ///체크박스 완료
                #endregion

                #region 데이터그리드와총갯수구하기
                string query1 = $"SELECT * FROM product  WHERE product_day Between '{startDateString}' and '{endDateString}'{selection} ORDER BY product_day";
                string query_monster = $"SELECT COUNT(*) AS monsterX_count FROM product WHERE product_day BETWEEN '{startDateString}' AND '{endDateString}' AND product_name = 'monsterX'";
                string query_Cheese = $"SELECT COUNT(*) AS CheeseWhaper_count FROM product WHERE product_day BETWEEN '{startDateString}' AND '{endDateString}' AND product_name = 'CheeseWhaper'";
                string query_Shrimp = $"SELECT COUNT(*) AS ShrimpWhaper_count FROM product WHERE product_day BETWEEN '{startDateString}' AND '{endDateString}' AND product_name = 'ShrimpWhaper'";
                string query_BulgogiWhaper = $"SELECT COUNT(*) AS BulgogiWhaper_count FROM product WHERE product_day BETWEEN '{startDateString}' AND '{endDateString}' AND product_name = 'BulgogiWhaper'";

               

                //전체 데이터 그리드에 붙이기
                using (SqlDataAdapter adapter = new SqlDataAdapter(query1, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // DataGridView에 데이터 바인딩
                    dataGridView1.DataSource = dataTable;
                }

                using (SqlDataAdapter adapter = new SqlDataAdapter(query_monster, connection))
                {
                    DataTable countDataTable = new DataTable();
                    adapter.Fill(countDataTable);
                    if (countDataTable.Rows.Count > 0)
                    {
                        monsterX_total.Text = countDataTable.Rows[0]["monsterX_count"].ToString();
                    }
                    else
                    {
                        monsterX_total.Text = "0"; // 결과가 없을 경우 0으로 설정
                    }
                }

                using (SqlDataAdapter adapter = new SqlDataAdapter(query_Cheese, connection))
                {
                    DataTable countDataTable = new DataTable();
                    adapter.Fill(countDataTable);
                    if (countDataTable.Rows.Count > 0)
                    {
                        Cheese_total.Text = countDataTable.Rows[0]["CheeseWhaper_count"].ToString();
                    }
                    else
                    {
                        Cheese_total.Text = "0"; // 결과가 없을 경우 0으로 설정
                    }
                }

                using (SqlDataAdapter adapter = new SqlDataAdapter(query_BulgogiWhaper, connection))
                {
                    DataTable countDataTable = new DataTable();
                    adapter.Fill(countDataTable);
                    if (countDataTable.Rows.Count > 0)
                    {
                        Bulgogi_total.Text = countDataTable.Rows[0]["BulgogiWhaper_count"].ToString();
                    }
                    else
                    {
                        Bulgogi_total.Text = "0"; // 결과가 없을 경우 0으로 설정
                    }
                }

                using (SqlDataAdapter adapter = new SqlDataAdapter(query_Shrimp, connection))
                {
                    DataTable countDataTable = new DataTable();
                    adapter.Fill(countDataTable);
                    if (countDataTable.Rows.Count > 0)
                    {
                        Shrimp_Total.Text = countDataTable.Rows[0]["ShrimpWhaper_count"].ToString();
                    }
                    else
                    {
                        Shrimp_Total.Text = "0"; // 결과가 없을 경우 0으로 설정
                    }
                }
                #endregion

                #region 불량품갯수구하기
                string defect_monster = $"SELECT COUNT(*) AS monsterX_count FROM product WHERE product_day BETWEEN '{startDateString}' AND '{endDateString}' AND product_name = 'monsterX' and Defective_code IS NOT NULL";
                string defect_Cheese = $"SELECT COUNT(*) AS CheeseWhaper_count FROM product WHERE product_day BETWEEN '{startDateString}' AND '{endDateString}' AND product_name = 'CheeseWhaper'and Defective_code IS NOT NULL";
                string defect_Shrimp = $"SELECT COUNT(*) AS ShrimpWhaper_count FROM product WHERE product_day BETWEEN '{startDateString}' AND '{endDateString}' AND product_name = 'ShrimpWhaper'and Defective_code IS NOT NULL";
                string defect_BulgogiWhaper = $"SELECT COUNT(*) AS BulgogiWhaper_count FROM product WHERE product_day BETWEEN '{startDateString}' AND '{endDateString}' AND product_name = 'BulgogiWhaper'and Defective_code IS NOT NULL";

                using (SqlDataAdapter adapter = new SqlDataAdapter(defect_monster, connection))
                {
                    DataTable countDataTable = new DataTable();
                    adapter.Fill(countDataTable);
                    if (countDataTable.Rows.Count > 0)
                    {
                        defect_moster.Text = countDataTable.Rows[0]["monsterX_count"].ToString();
                    }
                    else
                    {
                        defect_moster.Text = "0"; // 결과가 없을 경우 0으로 설정
                    }
                }

                using (SqlDataAdapter adapter = new SqlDataAdapter(defect_Cheese, connection))
                {
                    DataTable countDataTable = new DataTable();
                    adapter.Fill(countDataTable);
                    if (countDataTable.Rows.Count > 0)
                    {
                        defect_cheese.Text = countDataTable.Rows[0]["CheeseWhaper_count"].ToString();
                    }
                    else
                    {
                        defect_cheese.Text = "0"; // 결과가 없을 경우 0으로 설정
                    }
                }

                using (SqlDataAdapter adapter = new SqlDataAdapter(defect_Shrimp, connection))
                {
                    DataTable countDataTable = new DataTable();
                    adapter.Fill(countDataTable);
                    if (countDataTable.Rows.Count > 0)
                    {
                        defect_shrimp.Text = countDataTable.Rows[0]["ShrimpWhaper_count"].ToString();
                    }
                    else
                    {
                        defect_shrimp.Text = "0"; // 결과가 없을 경우 0으로 설정
                    }
                }


                using (SqlDataAdapter adapter = new SqlDataAdapter(defect_BulgogiWhaper, connection))
                {
                    DataTable countDataTable = new DataTable();
                    adapter.Fill(countDataTable);
                    if (countDataTable.Rows.Count > 0)
                    {
                        detect_bulgogi.Text = countDataTable.Rows[0]["BulgogiWhaper_count"].ToString();
                    }
                    else
                    {
                        detect_bulgogi.Text = "0"; // 결과가 없을 경우 0으로 설정
                    }
                }

                #endregion

                connection.Close();


                //도넛차트그리기
                donut_Chart.Series.Clear();

                Series series = new Series("Donut");
                series.ChartType = SeriesChartType.Doughnut;

                int a = int.Parse(monsterX_total.Text);
                int b = int.Parse(Cheese_total.Text);
                int c = int.Parse(Bulgogi_total.Text);
                int d = int.Parse(Shrimp_Total.Text);
                int total = a + b + c + d;
                double per_a = ((double)a / total) * 100;
                double per_b = ((double)b / total) * 100;
                double per_c = ((double)c / total) * 100;
                double per_d = ((double)d / total) * 100;

                string formattedPer_a = per_a.ToString("N2"); // 소수점 둘째 자릿수까지 표시
                string formattedPer_b = per_b.ToString("N2");
                string formattedPer_c = per_c.ToString("N2");
                string formattedPer_d = per_d.ToString("N2");

                string s_per_a = $"{formattedPer_a}%";
                string s_per_b = $"{formattedPer_b}%";
                string s_per_c = $"{formattedPer_c}%";
                string s_per_d = $"{formattedPer_d}%";
               

                series.Points.AddXY(s_per_a, int.Parse(monsterX_total.Text));
                series.Points.AddXY(s_per_b, int.Parse(Cheese_total.Text));
                series.Points.AddXY(s_per_c, int.Parse(Bulgogi_total.Text));
                series.Points.AddXY(s_per_d, int.Parse(Shrimp_Total.Text));

                series.Points[0].LegendText = "MonsterX";
                series.Points[1].LegendText = "Cheese Whaper";
                series.Points[2].LegendText = "Bulgogi Whaper";
                series.Points[3].LegendText = "Shrimp Whaper";


                // 차트에 시리즈 추가

                donut_Chart.Series.Add(series);

                donut_Chart.Series[0].Points[0].Color = Color.FromArgb(54, 150, 255);
                donut_Chart.Series[0].Points[1].Color = Color.FromArgb(255, 140, 129);
                donut_Chart.Series[0].Points[2].Color = Color.FromArgb(0, 173, 195);
                donut_Chart.Series[0].Points[3].Color = Color.FromArgb(129, 128, 129);




            }

        }

        #endregion

        #region 체크박스 처리
        private void datepicker1_ValueChanged(object sender, EventArgs e)
        {
            startDateString = datepicker1.Value.ToString("yyyy-MM-dd");
            update();
        }

        private void end_date_ValueChanged(object sender, EventArgs e)
        {
            endDateString = end_date.Value.ToString("yyyy-MM-dd");
            update();
        }

      

        private void cboxMonsterX_CheckedChanged(object sender, EventArgs e)
        {
            update();
        }

        private void cboxCheese_CheckedChanged(object sender, EventArgs e)
        {
            update();
        }

        private void cboxBulgogiWhaper_CheckedChanged(object sender, EventArgs e)
        {
            update();
        }

        private void cboxShrimpWhaper_CheckedChanged(object sender, EventArgs e)
        {
            update();
        }
        #endregion
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // 클릭된 행의 배경색 변경
            if (e.RowIndex >= 0)
            {
                if (dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor != Color.FromArgb(192, 192, 255))
                {
                    dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(192, 192, 255);
                    dataGridView1.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
                }
                else
                {
                    dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                    dataGridView1.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
                }
            }
        }


    }
}
