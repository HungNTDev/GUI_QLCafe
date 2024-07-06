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
                // Tìm handlde của cửa sổ đăng nhập
                hWnd = AutoControl.FindWindowHandle(null, "Đăng nhập");
                // Đưa cửa sổ đăng nhập lên trước
                AutoControl.BringToFront(hWnd);
            }
        }

        private void frmLoading_Load(object sender, EventArgs e)
        {
            Thread thread = new Thread(() =>
            {
                // Mô phỏng quá trình tải dữ liệu
                Thread.Sleep(1000);

                // Cập nhật trạng thái sau khi tải xong
                Status = 1;

                // Hiện form DangNhap
                frmDangNhap frmDangNhap = new frmDangNhap();
                frmDangNhap.ShowDialog();
            });  
            // Đặt trạng thái apartment củ luồng là STA
            thread.SetApartmentState(ApartmentState.STA);   
            // Bắt đầu luồng
            thread.Start();
        }

        private void frmLoading_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Hủy sự kiện đóng form
            e.Cancel = true;    
        }
    }
}
