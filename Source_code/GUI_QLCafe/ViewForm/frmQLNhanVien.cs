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

        private void frmQLNhanVien_Load(object sender, EventArgs e)
        {
            LoadGridView_NhanVien();
        }
        BUS_Staff busNhanVien = new BUS_Staff();
        private void LoadGridView_NhanVien()
        {
            dgvDanhSachNhanVien.DataSource = busNhanVien.get();
        }
        private void dgvDanhSachNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
