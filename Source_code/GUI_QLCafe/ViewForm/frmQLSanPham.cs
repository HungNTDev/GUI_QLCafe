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
    public partial class frmQLSanPham : Form
    {
        public frmQLSanPham()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmAddSanPham frmAddSanPham = new frmAddSanPham();
            frmAddSanPham.ShowDialog();
        }

        private void dgvDanhSachSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
