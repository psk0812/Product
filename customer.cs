using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Product
{
    public partial class Customerform : Form
    {
        private CustomerViewModel vm;
        public Customerform()
        {
            try {
                InitializeComponent();
                vm = new CustomerViewModel();
                vm.CustomerBindingSource = customersBindingSource;
                this.Load += delegate { vm.Load(); };
                btn_New.Click += delegate { vm.New(); };
                btn_Delete.Click += delegate { vm.Delete(); };
                btn_Save.Click += delegate { vm.save(); };
                this.FormClosing += delegate { vm.Dispose(); };
            }
            catch(Exception ex)
            {
                Console.Write(ex);
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {//클릭한 셀의 행 색 바꾸기
 

            try
            {
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
            catch (Exception ex)
            {
                Console.Write(ex);
            }
        }
    }
}
