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
            dgvDanhSachNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void frmQLNhanVien_Load_1(object sender, EventArgs e)
        {
            LoadGridView_NhanVien();
        }


    }
}
