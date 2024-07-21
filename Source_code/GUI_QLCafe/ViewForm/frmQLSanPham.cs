using BUS_QLCafe;
using System;
using System.Windows.Forms;

namespace GUI_QLCafe
{
    public partial class frmQLSanPham : Form
    {
        BUS_Product busSanPham = new BUS_Product();
        public frmQLSanPham()
        {
            InitializeComponent();
        }

        public void Nofication(string msg, frmNotification.enumType type)
        {
            frmNotification notification = new frmNotification();
            frmNotification.showNotfication(msg, type);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmAddSanPham frmAddSanPham = new frmAddSanPham();
            frmAddSanPham.ShowDialog();
        }
        public void LoadGridView_SanPham()
        {
            dgvDanhSachSanPham.DataSource = busSanPham.get();
        }

        private void frmQLSanPham_Load(object sender, EventArgs e)
        {
            LoadGridView_SanPham();
        }

        private void dgvDanhSachSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDanhSachSanPham.CurrentCell.OwningColumn.Name == "dgvSua")
            {
                frmAddSanPham frmAddSanPham = new frmAddSanPham();
                string maSanPham = Convert.ToString(dgvDanhSachSanPham.CurrentRow.Cells["dgvMaSanPham"].Value);
                frmAddSanPham.id = maSanPham;
                frmAddSanPham.txtMaSanPham.Text = maSanPham;
                frmAddSanPham.txtTenSanPham.Text = Convert.ToString(dgvDanhSachSanPham.CurrentRow.Cells["dgvTenSanPham"].Value);
                frmAddSanPham.txtGia.Text = Convert.ToString(dgvDanhSachSanPham.CurrentRow.Cells["dgvGia"].Value);
                frmAddSanPham.rdoCo.Checked = Convert.ToBoolean(dgvDanhSachSanPham.CurrentRow.Cells["dgvTrangThai"].Value) ? true : false;
                frmAddSanPham.txtDuongDan.Text = Convert.ToString(dgvDanhSachSanPham.CurrentRow.Cells["dgvHinhAnh"].Value);
                frmAddSanPham.ShowDialog();
                LoadGridView_SanPham();
            }
            else if(dgvDanhSachSanPham.CurrentCell.OwningColumn.Name == "dgvXoa")
            {
                string maSanPham = Convert.ToString((dgvDanhSachSanPham.CurrentRow.Cells["dgvMaSanPham"].Value));
                if (MessageBox.Show("Bạn chắc chắn  muốn xóa sản phẩm?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (busSanPham.delete(maSanPham))
                    {
                        this.Nofication("Xóa thành công!", frmNotification.enumType.Success);
                        LoadGridView_SanPham();
                    }
                    else
                    {
                        this.Nofication("Xóa thất bại!", frmNotification.enumType.Failed);
                    }
                }
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {

        }
    }
}
