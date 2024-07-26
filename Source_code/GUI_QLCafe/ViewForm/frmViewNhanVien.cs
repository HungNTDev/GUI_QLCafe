using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLCafe.ViewForm
{
    public partial class frmViewNhanVien : Form
    {
        public frmViewNhanVien()
        {
            InitializeComponent();
        }

        public void HienThi()
        {
            txtEmail.Enabled = false;
            txtTenNhanVien.Enabled = false;
            txtDuongDan.Enabled = false;    
            rdoHoatDong.Enabled = false;
            rdoNgungHoatDong.Enabled = false;
            rdoNhanVien.Enabled = false;
            rdoQuanTri.Enabled = false;
        }

        private void frmViewNhanVien_Load(object sender, EventArgs e)
        {
            HienThi();
        }

        public void SetStaffInfo(string email, string tenNhanVien, string duongDan, bool trangThai, bool vaiTro)
        {
            txtEmail.Text = email;   
            txtTenNhanVien.Text = tenNhanVien;
            txtDuongDan.Text = duongDan;
            rdoQuanTri.Checked = vaiTro;
            rdoHoatDong.Checked = trangThai;

            string saveDirectory = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
            string imagePath = Path.Combine(saveDirectory, duongDan.TrimStart('\\'));
            if (File.Exists(imagePath))
            {
                picNhanVien.Image = Image.FromFile(imagePath);
            }
            else
            {
                picNhanVien.Image = null;
                MessageBox.Show("Hình ảnh không tồn tại: " + imagePath, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
