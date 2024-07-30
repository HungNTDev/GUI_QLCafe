using BUS_QLCafe;
using GUI_QLCafe.ViewForm;
using System;
using System.Data;
using System.Data.Common;
using System.Drawing.Printing;
using System.IO;
using System.Windows.Forms;

namespace GUI_QLCafe
{
    public partial class frmQLVoucher : Form
    {
        BUS_Voucher bus = new BUS_Voucher();

        private const int PageSize = 15;
        private int currentPageIndex = 1;
        private int totalPages = 0;
        private int totalRows = 0;
        public frmQLVoucher()
        {
            InitializeComponent();
        }

        private void frmQLVoucher_Load(object sender, EventArgs e)
        {

            LoadData();
            currentPageIndex = 1;
            lbCurrentPage.Text = currentPageIndex.ToString();
        }
        public void Message(string msg, frmNotification.enumType type)
        {
            frmNotification notification = new frmNotification();
            frmNotification.showNotfication(msg, type);
        }
        private void LoadData()
        {
            try
            {
                totalRows = bus.GetTotalVoucherCount();
                totalPages = (int)Math.Ceiling((double)totalRows / PageSize);
                lbTotalPage.Text = totalPages.ToString();

                DataTable dt = bus.GetPageVoucher(currentPageIndex, PageSize);
                dgvDanhSachKhuyenMai.DataSource = dt;

                dgvDanhSachKhuyenMai.Refresh();
                lbTotalRows.Text = "Tổng số dòng: " + totalRows.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            frmAddVoucher frmAddVoucher = new frmAddVoucher();
            frmAddVoucher.ShowDialog();
            LoadData();
        }

        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            currentPageIndex = 1;
            if (!searching)
            {
                LoadData();
            }
            else
            {
                PerformSearch();
            }

            lbCurrentPage.Text = currentPageIndex.ToString();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (currentPageIndex > 1)
            {
                currentPageIndex--;
                if (!searching)
                {
                    LoadData();
                }
                else
                {

                    PerformSearch();
                }

                lbCurrentPage.Text = currentPageIndex.ToString();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentPageIndex < totalPages)
            {
                currentPageIndex++;
                if (!searching)
                {
                    LoadData();
                }
                else
                {

                    PerformSearch();
                }
                lbCurrentPage.Text = currentPageIndex.ToString();
            }
        }

        private void btnLastPage_Click(object sender, EventArgs e)
        {
            currentPageIndex = totalPages;
            if (!searching)
            {
                LoadData();
            }
            else
            {

                PerformSearch();
            }
            lbCurrentPage.Text = currentPageIndex.ToString();
        }


        bool searching = false;
        private void PerformSearch()
        {
            string sp = txtTimKiem.Text;
            if (string.IsNullOrEmpty(sp))
            {
                MessageBox.Show("Vui lòng nhập nội dung cần tìm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                var dt = bus.search(txtTimKiem.Text, currentPageIndex, PageSize, out totalRows, out totalPages);
                if (dt.Rows.Count > 0)
                {
                    dgvDanhSachKhuyenMai.DataSource = dt;


                    lbTotalRows.Text = "Tổng số dòng: " + totalRows.ToString();
                    lbTotalPage.Text = totalPages.ToString();
                    lbCurrentPage.Text = currentPageIndex.ToString();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy khuyến mãi", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
            }
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            searching = true;
            PerformSearch();
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            searching = false;
            LoadData();
        }

        private void dgvDanhSachKhuyenMai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDanhSachKhuyenMai.CurrentCell.OwningColumn.Name == "dgvSua")
            {
                frmAddVoucher frmAdd = new frmAddVoucher
                {
                    formMode = frmAddVoucher.FormMode.Sua
                };
                frmAdd.txtMaKhuyenMai.Enabled = false;

                string ma = dgvDanhSachKhuyenMai.CurrentRow.Cells["dgvMaKhuyenMai"].Value.ToString();

                frmAdd.id = ma;

                frmAdd.txtMaKhuyenMai.Text = dgvDanhSachKhuyenMai.CurrentRow.Cells["dgvMaKhuyenMai"].Value.ToString();
                frmAdd.txtTenKhuyenMai.Text = dgvDanhSachKhuyenMai.CurrentRow.Cells["dgvTenKhuyenMai"].Value.ToString();
                frmAdd.txtPhanTramKM.Text = dgvDanhSachKhuyenMai.CurrentRow.Cells["dgvPhanTramKM"].Value.ToString();

                int status = int.Parse(dgvDanhSachKhuyenMai.CurrentRow.Cells["dgvTrangThai"].Value.ToString());

                if (status == 0)
                {
                    frmAdd.cbTrangThai.SelectedIndex = 1;
                }
                else
                {
                    frmAdd.cbTrangThai.SelectedIndex = 0;
                }


                frmAdd.ShowDialog();
                LoadData();
            }
            else if (dgvDanhSachKhuyenMai.CurrentCell.OwningColumn.Name == "dgvXem")
            {
                frmViewVoucher view = new frmViewVoucher();

                string ma = dgvDanhSachKhuyenMai.CurrentRow.Cells["dgvMaKhuyenMai"].Value.ToString();
                string ten = dgvDanhSachKhuyenMai.CurrentRow.Cells["dgvTenKhuyenMai"].Value.ToString();
                string phantram = dgvDanhSachKhuyenMai.CurrentRow.Cells["dgvPhanTramKM"].Value.ToString();

                int trangthai = int.Parse(dgvDanhSachKhuyenMai.CurrentRow.Cells["dgvTrangThai"].Value.ToString());



                view.SetInfo(ma, ten, phantram, trangthai);
                view.ShowDialog();
            }
            else if (dgvDanhSachKhuyenMai.CurrentCell.OwningColumn.Name == "dgvXoa")
            {
                string ma = dgvDanhSachKhuyenMai.CurrentRow.Cells["dgvMaKhuyenMai"].Value.ToString();
                if (MessageBox.Show("Bạn chắc chắn muốn xóa mã khuyến mãi này?", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    if (bus.delete(ma))
                    {
                        this.Message("Xóa thành công!", frmNotification.enumType.Success);
                        LoadData();
                    }
                    else
                    {
                        this.Message("Xóa thất bại!", frmNotification.enumType.Failed);
                    }
                }
            }
        }
    }
}
