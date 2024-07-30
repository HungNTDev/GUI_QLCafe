using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLCafe.ViewForm
{
    public partial class frmViewVoucher : Form
    {
        public frmViewVoucher()
        {
            InitializeComponent();
        }
        public void SetInfo(string ma, string ten, string phantram, int trangThai)
        {
            txtMaKhuyenMai.Text = ma;
            txtTenKhuyenMai.Text = ten;
            txtPhanTramKM.Text = phantram;
            cbTrangThai.SelectedIndex = 1-trangThai;

        }
            private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void HienThi()
        {
            txtMaKhuyenMai.Enabled = false;
            txtTenKhuyenMai.Enabled = false;
            txtPhanTramKM.Enabled = false;
            cbTrangThai.Enabled = false;
        }
        private void frmViewVoucher_Load(object sender, EventArgs e)
        {
            HienThi();
        }
    }
}
