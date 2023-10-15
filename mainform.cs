using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Product
{
    public partial class mainform : Form
    {
        private static IconButton currentbtn;
        private Form currentForm;
        private int bordersize =2;
        public mainform()
        {
            try 
            {
                InitializeComponent();
                
                currentbtn = bnt_productfrom;

                OpenChildForm(new productform());
                this.Opacity = 1.0;
                this.Padding = new Padding(bordersize);
                // 네트워크 상태 변경 이벤트 핸들러 등록
                NetworkChange.NetworkAvailabilityChanged += NetworkChange_NetworkAvailabilityChanged;

                // 초기 네트워크 상태 확인
                bool isNetworkAvailable = NetworkInterface.GetIsNetworkAvailable();

                UpdateNetworkStatus(isNetworkAvailable);

            }catch(Exception ex)
            { Console.WriteLine(ex); }
        }

        private void NetworkChange_NetworkAvailabilityChanged(object sender, NetworkAvailabilityEventArgs e)
        {
            // 네트워크 상태 변경 시 호출되는 이벤트 핸들러
            UpdateNetworkStatus(e.IsAvailable);
        }

        private void UpdateNetworkStatus(bool isAvailable)
        {
            if (isAvailable)
            {
                lbl_network.Text = "정상";
                panelNetwork.BackColor = Color.MediumSeaGreen;
            }
            else
            {
                lbl_network.Text = "오류";
                panelNetwork.BackColor = Color.Crimson;
            }
        }
     

      
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 폼 종료 시에 네트워크 상태 변경 이벤트 핸들러 제거
            NetworkChange.NetworkAvailabilityChanged -= NetworkChange_NetworkAvailabilityChanged;
        }

        private void OpenChildForm(Form childForm)
        {
            try
            {


                if (currentForm != null)
                {
                 
                    currentForm.Close();
                    currentForm.Dispose();
                    
                }


                currentForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                mainpanel.Controls.Add(childForm);
                childForm.BringToFront();
                childForm.Show();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitlebar_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            }catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void btn_mini_Click(object sender, EventArgs e)
        {
            try
            {
                this.WindowState = FormWindowState.Minimized;

            }catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void btn_maxi_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.WindowState != FormWindowState.Maximized)
                {
                    this.WindowState = FormWindowState.Maximized;
                }
                else
                {
                    this.WindowState = FormWindowState.Normal;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
           
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public struct RGBColors
        {
            public static Color color_btn_clicked = Color.FromArgb(64, 86, 141);
            public static Color color_btn_unclicked = Color.FromArgb(54, 150, 255);
            public static Color color_mouser_hover = Color.FromArgb(53, 61, 79);
            public static Color color_pink = Color.FromArgb(254, 110, 135);

  
        }


        private void ActivateButton(object senderBtn)
        {

            try
            {
                currentbtn.BackColor = RGBColors.color_btn_unclicked;
                currentbtn = (IconButton)senderBtn;
                currentbtn.BackColor = RGBColors.color_btn_clicked;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            
        }

        private void bnt_productfrom_Click(object sender, EventArgs e)
        {
            try
            {
                ActivateButton(sender);
                OpenChildForm(new productform());
            }catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }


        private void btn_report_Click(object sender, EventArgs e)
        {
            try
            {
                ActivateButton(sender);
                OpenChildForm(new report_form());
            }catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void mainform_Load(object sender, EventArgs e)
        {   try
            {
                timer1.Interval = 100;
                timer1.Start();
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                DateTime nowDate = DateTime.Now;
                lbltime.Text = nowDate.ToString("yyyy년MM월dd일ddd요일 \n HH:mm:ss");
            }catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void btnCuostomer_Click(object sender, EventArgs e)
        {   try
            {
                ActivateButton(sender);
                OpenChildForm(new Customerform());
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }
    }
}
