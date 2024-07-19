using BUS_QLCafe;
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
        private void dgvDanhSachNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmQLNhanVien_Load(object sender, EventArgs e)
        {
            LoadGridView_NhanVien();
        }
    }
}
