﻿using System;
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
        //tình trạng login
        public static int session = 0; 
        public static int profile = 0;
        public static string email;


        //kiểm tra vai trò sau đăng nhập
        public static string role { get; set; }
        // vai trò 0 là nv
        // vai tro 1 là quản trị

        frmDangNhap dn;

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
        public void PhanQuyen()
        {
            btnQLNhanVien.Visible = false;
            btnThongKe.Visible = false;
            if (session == 1)
            {
                if (role == "1")
                {
                    btnQLNhanVien.Visible = true;
                    btnThongKe.Visible = true;
                }
            }
        }
        bool quanlyExpand = false;  
        private void quanlyTransition_Tick(object sender, EventArgs e)
        {
            // Nếu chưa mở rộng
            if (quanlyExpand == false) 
            {
                // Tăng chiều cao lên 5
                flpQuanLy.Height += 15;
                
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
                flpQuanLy.Height -= 15; 

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

        bool thongkeExpand = false;
        private void thongkeTransition_Tick(object sender, EventArgs e)
        {
            // Nếu chưa mở rộng
            if(thongkeExpand == false)
            {
                // Tăng chiều cao lên 5
                flpThongKe.Height += 15; 

                // Nếu chiều cao đạt 300
                if(flpThongKe.Height >= 162)
                {
                    thongkeTransition.Stop(); // Dừng timer
                    thongkeExpand = true; // Mở rộng
                }
            }
            else
            {
                // Giảm chiều cao xuống 5
                flpThongKe.Height -= 15; 

                // Nếu chiều cao nhỏ hơn hoặc bằng 45
                if(flpThongKe.Height <= 45)
                {
                    thongkeTransition.Stop(); // Dừng timer
                    thongkeExpand = false; // Thu gọn
                }
            }
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            thongkeTransition.Start();
        }

        bool huongdanExpand = false;
        private void huongdanTransition_Tick(object sender, EventArgs e)
        {
            // Nếu chưa mở rộng
            if (huongdanExpand == false)
            {
                // Tăng chiều cao lên 5
                flpHuongDan.Height += 15;

                // Nếu chiều cao đạt 300
                if (flpHuongDan.Height >= 162)
                {
                    huongdanTransition.Stop(); // Dừng timer
                    huongdanExpand = true; // Mở rộng
                }
            }
            else
            {
                // Giảm chiều cao xuống 5
                flpHuongDan.Height -= 15;

                // Nếu chiều cao nhỏ hơn hoặc bằng 45
                if (flpHuongDan.Height <= 45)
                {
                    huongdanTransition.Stop(); // Dừng timer
                    huongdanExpand = false; // Thu gọn
                }
            }
        }
        private void btnHuongDan_Click(object sender, EventArgs e)
        {
            huongdanTransition.Start(); 
        }

        bool hethongExpand = false;
        private void hethongTransition_Tick(object sender, EventArgs e)
        {
            // Nếu chưa mở rộng
            if (hethongExpand == false)
            {
                // Tăng chiều cao lên 5
                flpHeThong.Height += 15;

                // Nếu chiều cao đạt 300
                if (flpHeThong.Height >= 165)
                {
                    hethongTransition.Stop(); // Dừng timer
                    hethongExpand = true; // Mở rộng
                }
            }
            else
            {
                // Giảm chiều cao xuống 5
                flpHeThong.Height -= 15;

                // Nếu chiều cao nhỏ hơn hoặc bằng 45
                if (flpHeThong.Height <= 45)
                {
                    hethongTransition.Stop(); // Dừng timer
                    hethongExpand = false; // Thu gọn
                }
            }
        }
        private void btnHeThong_Click(object sender, EventArgs e)
        {
            hethongTransition.Start();
        }


        bool sidebarExpand = true;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            // Nếu thanh sidebar đang mở rộng
            if (sidebarExpand)
            {
                // Giảm chiều rộng xuống 5
                flpSidebar.Width -= 10;

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
                flpSidebar.Width += 10;

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
        private void btnQLBan_Click(object sender, EventArgs e)
        {

        }

    }
}
