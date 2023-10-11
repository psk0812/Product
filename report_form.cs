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
using System.Windows.Forms.DataVisualization.Charting;

namespace Product
{
    public partial class report_form : Form
    {
        string connectionString = "Data Source=DESKTOP-8MVAM1C;Initial Catalog=Hamburger;User ID=test;Password=0000;";
        private static string startDateString = "2023-10-02";
        private static string endDateString = "2023-10-07";
        public report_form()
        {
            InitializeComponent();
            lbl_error.Text = "Error Code 1 - 재료 상함 \nError Code 2 - 패티 태움 \nError Code 3 - 번이 틀림 \nError Code 4 - 소스 적음";
            update();
        }



        public void update()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                
                

                connection.Open();

            ///////////////첫번째 그래프 시작//////////
                chart1.Series.Clear();

                Series series1 = new Series("code1");
                Series series2 = new Series("code2");
                Series series3 = new Series("code3");
                Series series4 = new Series("code4");
                series1.ChartType = SeriesChartType.Column;

               
               
                string query_code1 = $"SELECT product_day,COUNT(*) as code1_count FROM  product WHERE product_day BETWEEN '{startDateString}' AND '{endDateString}' AND Defective_code = '01' GROUP BY product_day";
                string query_code2 = $"SELECT product_day,COUNT(*) as code2_count FROM  product WHERE product_day BETWEEN '{startDateString}' AND '{endDateString}' AND Defective_code = '02' GROUP BY product_day";
                string query_code3 = $"SELECT product_day,COUNT(*) as code3_count FROM  product WHERE product_day BETWEEN '{startDateString}' AND '{endDateString}' AND Defective_code = '03' GROUP BY product_day";
                string query_code4 = $"SELECT product_day,COUNT(*) as code4_count FROM  product WHERE product_day BETWEEN '{startDateString}' AND '{endDateString}' AND Defective_code = '04' GROUP BY product_day";

               
                using (SqlDataAdapter adapter = new SqlDataAdapter(query_code1, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                   
                    foreach (DataRow row in dataTable.Rows)
                    {
                       
                        int code1Count = (int)row["code1_count"];
                        //아래 두줄은 X축을 적기 위한 것이다. 
                        DateTime productDay = (DateTime)row["product_day"];
                        string productDayString = productDay.ToString("MM-dd"); 


                       series1.Points.AddXY(productDayString,code1Count);
                    }
                    

                }

                using (SqlDataAdapter adapter = new SqlDataAdapter(query_code2, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                   
                    foreach (DataRow row in dataTable.Rows)
                    {

                        int code1Count = (int)row["code2_count"];
                        Console.WriteLine(code1Count);
                        series2.Points.AddY(code1Count);
                    }
                    

                }


                using (SqlDataAdapter adapter = new SqlDataAdapter(query_code3, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                   
                    foreach (DataRow row in dataTable.Rows)
                    {

                        int code1Count = (int)row["code3_count"];
                        Console.WriteLine(code1Count);
                        series3.Points.AddY(code1Count);
                    }
                   

                }


                using (SqlDataAdapter adapter = new SqlDataAdapter(query_code4, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    
                    foreach (DataRow row in dataTable.Rows)
                    {

                        int code1Count = (int)row["code4_count"];
                        Console.WriteLine(code1Count);
                        series4.Points.AddY(code1Count);
                    }
                   

                }

                chart1.Series.Add(series1);
                chart1.Series.Add(series2);
                chart1.Series.Add(series3);
                chart1.Series.Add(series4);

                ///##############도넛 차트 시작
                donut_chart.Series.Clear();


                string donut_code1 = $"SELECT COUNT(*) as donut1_count FROM  product WHERE product_day BETWEEN '{startDateString}' AND '{endDateString}' AND Defective_code = '01'";
                string donut_code2 = $"SELECT COUNT(*) as donut2_count FROM  product WHERE product_day BETWEEN '{startDateString}' AND '{endDateString}' AND Defective_code = '02'";
                string donut_code3 = $"SELECT COUNT(*) as donut3_count FROM  product WHERE product_day BETWEEN '{startDateString}' AND '{endDateString}' AND Defective_code = '03'";
                string donut_code4 = $"SELECT COUNT(*) as donut4_count FROM  product WHERE product_day BETWEEN '{startDateString}' AND '{endDateString}' AND Defective_code = '04'";


           
                int do_code1;
                int do_code2;
                int do_code3;
                int do_code4;
                using (SqlDataAdapter adapter = new SqlDataAdapter(donut_code1, connection))
                {
                    DataTable countDataTable = new DataTable();
                    adapter.Fill(countDataTable);
                    if (countDataTable.Rows.Count > 0)
                    {
                        do_code1 = (int)countDataTable.Rows[0]["donut1_count"];
                    }
                    else
                    {
                        do_code1=0; // 결과가 없을 경우 0으로 설정
                    }
                }

                using (SqlDataAdapter adapter = new SqlDataAdapter(donut_code2, connection))
                {
                    DataTable countDataTable = new DataTable();
                    adapter.Fill(countDataTable);
                    if (countDataTable.Rows.Count > 0)
                    {
                        do_code2 = (int)countDataTable.Rows[0]["donut2_count"];
                    }
                    else
                    {
                        do_code2 = 0; // 결과가 없을 경우 0으로 설정
                    }
                }

                using (SqlDataAdapter adapter = new SqlDataAdapter(donut_code3, connection))
                {
                    DataTable countDataTable = new DataTable();
                    adapter.Fill(countDataTable);
                    if (countDataTable.Rows.Count > 0)
                    {
                        do_code3 = (int)countDataTable.Rows[0]["donut3_count"];
                    }
                    else
                    {
                        do_code3 = 0; // 결과가 없을 경우 0으로 설정
                    }

                }

                using (SqlDataAdapter adapter = new SqlDataAdapter(donut_code4, connection))
                {
                    DataTable countDataTable = new DataTable();
                    adapter.Fill(countDataTable);
                    if (countDataTable.Rows.Count > 0)
                    {
                        do_code4 = (int)countDataTable.Rows[0]["donut4_count"];
                    }
                    else
                    {
                        do_code4 = 0; // 결과가 없을 경우 0으로 설정
                    }
                }
                

                Series series = new Series("Donut");
                series.ChartType = SeriesChartType.Doughnut;
                //퍼센트 만들어 가는중
                int total = do_code1 + do_code2 + do_code3 + do_code4;
                double per_a = ((double)do_code1 / total) * 100;
                double per_b = ((double)do_code2 / total) * 100;
                double per_c = ((double)do_code3 / total) * 100;
                double per_d = ((double)do_code4 / total) * 100;

                string formattedPer_a = per_a.ToString("N2"); // 소수점 둘째 자릿수까지 표시
                string formattedPer_b = per_b.ToString("N2");
                string formattedPer_c = per_c.ToString("N2");
                string formattedPer_d = per_d.ToString("N2");

                string s_per_a = $"{formattedPer_a}%";
                string s_per_b = $"{formattedPer_b}%";
                string s_per_c = $"{formattedPer_c}%";
                string s_per_d = $"{formattedPer_d}%";
              //퍼센트 표시완료

                
                series.Points.AddXY(s_per_a, do_code1);
                series.Points.AddXY(s_per_b, do_code2);
                series.Points.AddXY(s_per_c, do_code3);
                series.Points.AddXY(s_per_d, do_code4);
              
                series.Points[0].LegendText = "Code1";
                series.Points[1].LegendText = "Code2";
                series.Points[2].LegendText = "Code3";
                series.Points[3].LegendText = "Code4";
                donut_chart.Series.Add(series);

                ///////////////////// 생산량. 결함품 그래프////////////////////////////////
                chart2.Series.Clear();

                Series series_total = new Series("Total");
                Series series_code = new Series("Defect");

                series_total.ChartType = SeriesChartType.Line;
                series_code.ChartType = SeriesChartType.Line;
                string total_sql = $"SELECT product_day,COUNT(*) as total_count FROM  product WHERE product_day BETWEEN '{startDateString}' AND '{endDateString}' GROUP BY product_day";
                string defect_sql = $"SELECT product_day,COUNT(*) as defect_count FROM  product WHERE product_day BETWEEN '{startDateString}' AND '{endDateString}' AND Defective='TRUE' GROUP BY product_day";
               
                using (SqlDataAdapter adapter = new SqlDataAdapter(total_sql, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);


                    foreach (DataRow row in dataTable.Rows)
                    {

                        int totalCount = (int)row["total_count"];
                        DateTime productDay = (DateTime)row["product_day"];
                        string productDayString = productDay.ToString("MM-dd");
                        series_total.Points.AddXY(productDayString, totalCount);
                    }
                    

                }

                using (SqlDataAdapter adapter = new SqlDataAdapter(defect_sql, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);


                    foreach (DataRow row in dataTable.Rows)
                    {

                        int defectCount = (int)row["defect_count"];

                        series_code.Points.AddY(defectCount);
                    }


                }
                chart2.Series.Add(series_total);
                chart2.Series.Add(series_code);


                connection.Close();

            }

        }

        //시작 날이바뀌면
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            startDateString = start_date.Value.ToString("yyyy-MM-dd");
            update();
        }


        //마지막 날이 바뀌면
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            endDateString = end_date.Value.ToString("yyyy-MM-dd");
            update();
        }
    }
}
