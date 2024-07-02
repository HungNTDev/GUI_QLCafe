using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLCafe
{
    public partial class frmMainQLCF : Form
    {
        public frmMainQLCF()
        {
            InitializeComponent();
        }

        private void frmMainQLCF_Load(object sender, EventArgs e)
        {
            // Hiển thị ngày trên lbNgay
            lbNgay.Text = DateTime.Now.ToShortDateString();
            // Hiển thị giờ trên lbGio
            lbGio.Text = DateTime.Now.ToShortTimeString();
        }

        bool quanlyExpand = false;  
        private void quanlyTransition_Tick(object sender, EventArgs e)
        {
            // Nếu chưa mở rộng
            if (quanlyExpand == false) 
            {
                // Tăng chiều cao của lên 5
                flpQuanLy.Height += 5;
                
                // Nếu chiều cao đạt 300
                if (flpQuanLy.Height >= 300)
                {
                    quanlyTransition.Stop(); // Dừng timer
                    quanlyExpand = true; // Mở rộng
                }
            }
            else
            {
                // Giảm chiều cao xuống 5
                flpQuanLy.Height -= 5; 

                // Nếu chiều cao nhỏ hơn hoặc bằng 45
                if(flpQuanLy.Height <= 45)
                {
                    quanlyTransition.Stop(); // Dừng timer
                    quanlyExpand = false; // Thu gọn
                }
            }
        }

        private void btnQuanLy_Click(object sender, EventArgs e)
        {
            quanlyTransition.Start();
        }

        bool sidebarExpand = true;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            // Nếu thanh sidebar đang mở rộng
            if (sidebarExpand)
            {
                // Giảm chiều rộng xuống 5
                flpSidebar.Width -= 5;

                // Nếu chiều rộng nhỏ hơn hoặc bằng 61
                if(flpSidebar.Width <= 61)
                {
                    sidebarExpand = false; // Thu gọn
                    sidebarTransition.Stop(); // Dừng timer
                }
            }
            else
            {
                // Tăng chiều rộng lên 5
                flpSidebar.Width += 5;

                // Nếu chiều rộng đạt tới 300
                if(flpSidebar.Width >= 300)
                {
                    sidebarExpand = true; // Mở rộng
                    sidebarTransition.Stop(); // Dừng timer
                }
            }
        }

        private void picHam_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

 
    }
}
