using BUS_QLCafe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
namespace GUI_QLCafe
{
    public partial class frmQLSanPham : Form
    {
        BUS_Product busSanPham = new BUS_Product();


        int pageNumber = 1;
        int numberRecord = 5;

        public frmQLSanPham()
        {
            InitializeComponent();
            dgvDanhSachSanPham.DataSource = LoadRecord(pageNumber, numberRecord);
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
            LoadGridView_SanPham();
        }
        public void LoadGridView_SanPham()
        {
            dgvDanhSachSanPham.DataSource = busSanPham.get();
        }

        private void frmQLSanPham_Load(object sender, EventArgs e)
        {
            LoadGridView_SanPham();
            LoadCombobox_Loai();
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
            else if (dgvDanhSachSanPham.CurrentCell.OwningColumn.Name == "dgvXoa")
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

        List<Product> LoadRecord(int page, int recordNum)
        {
            List<Product> result = new List<Product>();

            using (ThongTinSanPhamDataContext db = new ThongTinSanPhamDataContext())
            {
                result = db.Products.Skip((page - 1) * recordNum).Take(numberRecord).ToList();
            }
            return result;
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (pageNumber - 1 > 0)
            {
                pageNumber--;
                dgvDanhSachSanPham.DataSource = LoadRecord(pageNumber, numberRecord);
            }
        }

        private void LoadCombobox_Loai()
        {
            //cboLoai.DataSource = busSanPham.LoadIDPT();
            //cboLoai.ValueMember = "IdPT";
            //cboLoai.DisplayMember = "IdPT";
        }

        private void cboLoai_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //string id = cboLoai.SelectedValue.ToString();

            //if (id == "")
            //{
            //    LoadGridView_SanPham();
            //}
            //else
            //{
            //    dgvDanhSachSanPham.DataSource = busSanPham.ListType(id);
            //}
        }

        private void btn_First_Click(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int totalrecord = 0;
            using (ThongTinSanPhamDataContext db = new ThongTinSanPhamDataContext())
            {
                totalrecord = db.Products.Count();
            }
            if (pageNumber - 1 <= totalrecord / numberRecord)
            {
                pageNumber++;
                dgvDanhSachSanPham.DataSource = LoadRecord(pageNumber, numberRecord);
            }

        }

        private void btn_Last_Click(object sender, EventArgs e)
        {

        }

        private void dgvDanhSachSanPham_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try
            {
                // Ghi lại chi tiết lỗi
                Console.WriteLine("Lỗi DataGridView: " + e.Exception.Message);

                // Đánh dấu lỗi là đã được xử lý
                e.ThrowException = false;
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi cho người dùng (nếu cần)
                MessageBox.Show("Đã xảy ra lỗi khi xử lý dữ liệu trong DataGridView." + ex.Message);
            }
        }
    }
}
