using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using KAutoHelper;

namespace GUI_QLCafe
{
    public partial class frmLoading : Form
    {
        public frmLoading()
        {
            InitializeComponent();
        }

        // Đặt biến tĩnh để theo dõi trạng thái
        public static int Status = 0;
        private void loadingTransition_Tick(object sender, EventArgs e)
        {
            if(Status == 1)
            {
                this.Hide();
                loadingTransition.Stop();
                // Khởi tạo con trỏ cửa sổ
                IntPtr hWnd = IntPtr.Zero;
                hWnd = AutoControl.FindWindowHandle(null, "Đăng nhập");
                AutoControl.BringToFront(hWnd);
            }
        }

        private void frmLoading_Load(object sender, EventArgs e)
        {
            Thread thread = new Thread(() =>
            {
            Thread.Sleep(1000);
            frmDangNhap frmDangNhap = new frmDangNhap();
            frmDangNhap.ShowDialog();
            });  
            thread.SetApartmentState(ApartmentState.STA);   
            thread.Start();
        }

        private void frmLoading_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;    
        }
    }
}
