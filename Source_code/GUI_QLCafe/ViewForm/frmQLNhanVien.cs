using BUS_QLCafe;
using System;
using System.Windows.Forms;

namespace GUI_QLCafe
{
    public partial class frmQLNhanVien : Form
    {
        public frmQLNhanVien()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmAddNhanVien frmAddNhanVien = new frmAddNhanVien();
            frmAddNhanVien.ShowDialog();
        }
        BUS_Staff busNhanVien = new BUS_Staff();
        private void LoadGridView_NhanVien()
        {
            dgvDanhSachNhanVien.DataSource = busNhanVien.get();
        }
        private void frmQLNhanVien_Load(object sender, EventArgs e)
        {
            LoadGridView_NhanVien();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dgvDanhSachNhanVien.DataSource=busNhanVien.search("StatusStaff", txtTimKiem.Text);
        }
    }
}
