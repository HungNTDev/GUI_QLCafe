﻿using GUI_QLCafe.HandleForm;
using System;
using System.IO;
using System.Windows.Forms;

namespace GUI_QLCafe
{
    public partial class frmMainQLCF : Form
    {
        public static int session = 0; //tình trạng login
        public static string role { set; get; } //kiểm tra vai trò sau đăng nhập
        public static int status { set; get; }
        public static string email; //dùng để truyền email từ frmMainQLBH qua các form khác (static)
        public static string dateTime;

        //Tạo form đăng nhập
        frmDangNhap dn;

        public frmMainQLCF()
        {
            InitializeComponent();

        }

        public void frmDangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Refresh();
            frmMainQLCF_Load(sender, e);
        }
        public void AddControls(Form form)
        {
            panelBody.Controls.Clear();
            form.Dock = DockStyle.Fill;
            form.TopLevel = false;
            panelBody.Controls.Add(form);
            form.Show();
        }

        private void frmMainQLCF_Load(object sender, EventArgs e)
        {
            // Hiển thị ngày + giờ trên lbNgay
            lbNgay.Text = DateTime.Now.ToShortDateString() + "  |  " + DateTime.Now.ToLongTimeString();
            PhanQuyen();
            posExpand = flpPOS.Height >= 174;
        }

        public void reLogin()
        {
            this.Hide();
            session = 0;
            frmDangNhap dangNhap = new frmDangNhap();
            dangNhap.Show();
        }
        public void checkStatus(string emailAfter, string roleAfter, int statusAfter)
        {

            if (email == emailAfter && role != roleAfter)
            {
                MessageBox.Show("Vai trò của bạn đã thay đổi, vui lòng đăng nhập lại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                reLogin();
            }
            else if (email == emailAfter && status != statusAfter)
            {
                MessageBox.Show("Trạng thái của bạn đã thay đổi, vui lòng đăng nhập lại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                reLogin();
            }
        }
        public void PhanQuyen()
        {

            lblEmail.Text = email + "  |  " + role;

            if (session == 1)
            {
                if (role == "Quản trị" || role == "Chủ sở hữu")
                {
                    //btnQLNhanVien.Enabled = true;
                    //btnThongKe.Enabled = true;
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
                flpQuanLy.Height += 20;

                // Nếu chiều cao đạt 300
                if (flpQuanLy.Height >= 310)
                {
                    quanlyTransition.Stop(); // Dừng timer
                    quanlyExpand = true; // Mở rộng
                }
            }
            else
            {
                // Giảm chiều cao xuống 5
                flpQuanLy.Height -= 20;

                // Nếu chiều cao nhỏ hơn hoặc bằng 45
                if (flpQuanLy.Height <= 45)
                {
                    quanlyTransition.Stop(); // Dừng timer
                    quanlyExpand = false; // Thu gọn
                }
            }
        }

        private void btnQuanLy_Click(object sender, EventArgs e)
        {
            if (role == "Quản trị" || role == "Chủ sở hữu")
                quanlyTransition.Start();
            else
                messageDialog.Show("Bạn không có quyền truy cập chức năng này!", "Cảnh báo");
        }

        bool thongkeExpand = false;
        private void thongkeTransition_Tick(object sender, EventArgs e)
        {
            // Nếu chưa mở rộng
            if (thongkeExpand == false)
            {
                // Tăng chiều cao lên 5
                flpThongKe.Height += 15;

                // Nếu chiều cao đạt 300
                if (flpThongKe.Height >= 110)
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
                if (flpThongKe.Height <= 45)
                {
                    thongkeTransition.Stop(); // Dừng timer
                    thongkeExpand = false; // Thu gọn
                }
            }
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            if (role == "Quản trị" || role == "Chủ sở hữu")
                thongkeTransition.Start();
            else
                messageDialog.Show("Bạn không có quyền truy cập chức năng này!", "Thông báo");
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
                if (flpHeThong.Height >= 105)
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
                flpSidebar.Width -= 15;

                // Nếu chiều rộng nhỏ hơn hoặc bằng 61
                if (flpSidebar.Width <= 54)
                {
                    sidebarExpand = false; // Thu gọn
                    sidebarTransition.Stop(); // Dừng timer
                }
            }
            else
            {
                // Tăng chiều rộng lên 5
                flpSidebar.Width += 15;

                // Nếu chiều rộng đạt tới 300
                if (flpSidebar.Width >= 300)
                {
                    sidebarExpand = true; // Mở rộng
                    sidebarTransition.Stop(); // Dừng timer
                }
            }
        }


        bool posExpand;
        private void posTransition_Tick(object sender, EventArgs e)
        {
            //Nếu chưa mở rộng
            if (!posExpand)
            {
                // Tăng chiều cao lên 5
                flpPOS.Height += 15;

                // Nếu chiều cao đạt 300
                if (flpPOS.Height >= 174)
                {
                    posTransition.Stop(); // Dừng timer
                    posExpand = true; // Mở rộng
                }
            }
            else
            {
                // Giảm chiều cao xuống 5
                flpPOS.Height -= 15;

                // Nếu chiều cao nhỏ hơn hoặc bằng 45
                if (flpPOS.Height <= 45)
                {
                    posTransition.Stop(); // Dừng timer
                    posExpand = false; // Thu gọn
                }
            }
        }

        private void btnPOS_Click(object sender, EventArgs e)
        {
            posExpand = flpPOS.Height >= 174;
            posTransition.Start();
        }

        private void btnBan_Click(object sender, EventArgs e)
        {
            AddControls(new frmPOS());
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            AddControls(new frmMenuProduct());
        }

        private void frmMainQLCF_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void picHam_Click(object sender, EventArgs e)
        {
            //sidebarTransition.Start();
        }

        private void btnQLNhanVien_Click(object sender, EventArgs e)
        {
            if (role == "Quản trị" || role == "Chủ sở hữu")
                AddControls(new frmQLNhanVien(this));
            else
                messageDialog.Show("Bạn không có quyền truy cập chức năng này!", "Cảnh báo");
        }

        private void btnQLSanPham_Click(object sender, EventArgs e)
        {
            if (role == "Quản trị" || role == "Chủ sở hữu")
                AddControls(new frmQLSanPham());
            else
                messageDialog.Show("Bạn không có quyền truy cập chức năng này!", "Cảnh báo");
        }

        private void btnQLVoucher_Click_1(object sender, EventArgs e)
        {

            if (role == "Quản trị" || role == "Chủ sở hữu")
                AddControls(new frmQLVoucher());
            else
                messageDialog.Show("Bạn không có quyền truy cập chức năng này!", "Cảnh báo");
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau frmDoiMatKhau = new frmDoiMatKhau(frmMainQLCF.email, this);
            frmDoiMatKhau.ShowDialog();
        }

        private void btnQLHoaDon_Click(object sender, EventArgs e)
        {
            if (role == "Quản trị" || role == "Chủ sở hữu")
                AddControls(new frmQLHoaDon());
            else
                messageDialog.Show("Bạn không có quyền truy cập chức năng này!", "Cảnh báo");
        }

        private void btnQLBan_Click(object sender, EventArgs e)
        {
            if (role == "Quản trị" || role == "Chủ sở hữu")
                AddControls(new frmQLBan());
            else
                messageDialog.Show("Bạn không có quyền truy cập chức năng này!", "Cảnh báo");
        }

        private void btnThongKeSLHoaDon_Click(object sender, EventArgs e)
        {
            if (role == "Quản trị" || role == "Chủ sở hữu")
                AddControls(new frmQLThongKe());
            else
                messageDialog.Show("Bạn không có quyền truy cập chức năng này!", "Cảnh báo");
        }

        private void timer_ThoiGian_Tick(object sender, EventArgs e)
        {
            // Hiển thị ngày + giờ trên lbNgay
            lbNgay.Text = DateTime.Now.ToShortDateString() + "  |  " + DateTime.Now.ToLongTimeString();

            timer_ThoiGian.Start();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn chắc chắn muốn đăng xuất?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dl == DialogResult.Yes)
            {
                session = 0;
                this.Hide();
                frmDangNhap dangNhap = new frmDangNhap();
                dangNhap.Show();
            }
        }

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            AddControls(new frmMenuProduct());
        }

        private void btn_Ban_Click(object sender, EventArgs e)
        {
            AddControls(new frmPOS());
        }

        private void btnHD_Click(object sender, EventArgs e)
        {
            try
            {
                var path = Path.Combine(Directory.GetCurrentDirectory(), "HDSD.odt");
                System.Diagnostics.Process.Start(path);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex);
            }
        }

        private void btnGT_Click(object sender, EventArgs e)
        {
            AddControls(new frmGioiThieu());
        }
    }
}
