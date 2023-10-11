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


         



            InitializeComponent();
           
        }
        #region sql문
        private void productform_Load(object sender, EventArgs e)
        {

            update();


        }

        public void update()
        { using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string selection = "";

                
                connection.Open();

                if (cboxMonsterX.Checked) 
                {   
                    if (selection == "")
                    {
                        selection += " AND (product_name = 'monsterX'";
                    }
                    else { selection += " OR product_name = 'monsterX'"; }
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
               

                // SQL 쿼리 작성 (예: "SELECT * FROM YourTable")
                string query1 = $"SELECT * FROM product  WHERE product_day Between '{startDateString}' and '{endDateString}'{selection} ORDER BY product_day";
                string query_monster = $"SELECT COUNT(*) AS monsterX_count FROM product WHERE product_day BETWEEN '{startDateString}' AND '{endDateString}' AND product_name = 'monsterX'";
                string query_Cheese = $"SELECT COUNT(*) AS CheeseWhaper_count FROM product WHERE product_day BETWEEN '{startDateString}' AND '{endDateString}' AND product_name = 'CheeseWhaper'";
                string query_Shrimp = $"SELECT COUNT(*) AS ShrimpWhaper_count FROM product WHERE product_day BETWEEN '{startDateString}' AND '{endDateString}' AND product_name = 'ShrimpWhaper'";
                string query_BulgogiWhaper = $"SELECT COUNT(*) AS BulgogiWhaper_count FROM product WHERE product_day BETWEEN '{startDateString}' AND '{endDateString}' AND product_name = 'BulgogiWhaper'";

                string defect_monster = $"SELECT COUNT(*) AS monsterX_count FROM product WHERE product_day BETWEEN '{startDateString}' AND '{endDateString}' AND product_name = 'monsterX' and Defective_code IS NOT NULL";
                string defect_Cheese = $"SELECT COUNT(*) AS CheeseWhaper_count FROM product WHERE product_day BETWEEN '{startDateString}' AND '{endDateString}' AND product_name = 'CheeseWhaper'and Defective_code IS NOT NULL";
                string defect_Shrimp = $"SELECT COUNT(*) AS ShrimpWhaper_count FROM product WHERE product_day BETWEEN '{startDateString}' AND '{endDateString}' AND product_name = 'ShrimpWhaper'and Defective_code IS NOT NULL";
                string defect_BulgogiWhaper = $"SELECT COUNT(*) AS BulgogiWhaper_count FROM product WHERE product_day BETWEEN '{startDateString}' AND '{endDateString}' AND product_name = 'BulgogiWhaper'and Defective_code IS NOT NULL";


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


                connection.Close();
            }

        }

        #endregion

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
    }
}
