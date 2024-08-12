using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GUI_QLCafe.ViewForm
{
    public partial class frmViewSanPham : Form
    {
        public frmViewSanPham()
        {
            InitializeComponent();
        }

        public void HienThi()
        {
            txtMaSanPham.Enabled = false;
            txtDuongDan.Enabled = false;
            txtTenSanPham.Enabled = false;
            cbLoaiSanPham.Enabled = false;
            rdoKhong.Enabled = false;
            rdoCo.Enabled = false;
            txtGia.Enabled = false;
        }

        private void frmViewSanPham_Load(object sender, EventArgs e)
        {
            HienThi();
        }

        public void SetProductInfo(string maSanPham, string tenSanPham, string giaSanPham, string duongDan, string trangThai, string loaiSanPham)
        {
            txtMaSanPham.Text = maSanPham;
            txtTenSanPham.Text = tenSanPham;
            txtGia.Text = giaSanPham;
            txtDuongDan.Text = duongDan;
            cbLoaiSanPham.Text = loaiSanPham;

            if (trangThai == "Còn Bán")
            {
                rdoCo.Checked = true;
            }
            else
            {
                rdoKhong.Checked = true;
            }

            // Hiển thị hình ảnh
            string saveDirectory = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
            string imagePath = Path.Combine(saveDirectory, duongDan.TrimStart('\\'));
            if (File.Exists(imagePath))
            {
                picSanPham.Image = Image.FromFile(imagePath);
            }
            else
            {
                picSanPham.Image = null;
                MessageBox.Show("Hình ảnh không tồn tại: " + imagePath, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
