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

        private void frmViewNhanVien_Load(object sender, EventArgs e)
        {
        }

        public void SetStaffInfo(string maNV, string tenNhanVien, string email, string duongDan, bool trangThai, bool vaiTro)
        {
            txtMaNV.Text = maNV;
            txtEmail.Text = email;   
            txtTenNhanVien.Text = tenNhanVien;
            txtDuongDan.Text = duongDan;
            vaiTro = true ? rdoNhanVien.Checked = true : rdoQuanTri.Checked = true;
            trangThai = true ? rdoHoatDong.Checked = true : rdoNgungHoatDong.Checked = true;

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
