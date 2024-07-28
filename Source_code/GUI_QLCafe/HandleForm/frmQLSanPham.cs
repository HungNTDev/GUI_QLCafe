using BUS_QLCafe;
using GUI_QLCafe.ViewForm;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
namespace GUI_QLCafe
{
    public partial class frmQLSanPham : Form
    {
        BUS_Product busSanPham = new BUS_Product();

        private string saveDirectory;
        private string relativePath;
        private const int PageSize = 10;
        private int currentPageIndex = 1;
        private int totalPages = 0;
        private int totalRows = 0;

        public frmQLSanPham()
        {
            InitializeComponent();
        }

        public void Message(string msg, frmNotification.enumType type)
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
            LoadData();
            currentPageIndex = 1;
            lbCurrentPage.Text = currentPageIndex.ToString();
        }

        private void dgvDanhSachSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDanhSachSanPham.CurrentCell.OwningColumn.Name == "dgvSua")
            {
                frmAddSanPham frmAddSanPham = new frmAddSanPham
                {
                    formMode = frmAddSanPham.FormMode.Sua
                };
                frmAddSanPham.txtMaSanPham.Enabled = false;
                frmAddSanPham.cbLoaiSanPham.Enabled = false;
                frmAddSanPham.txtDuongDan.Enabled = false;
                
                string maSanPham = Convert.ToString(dgvDanhSachSanPham.CurrentRow.Cells["dgvMaSanPham"].Value);
                frmAddSanPham.id = maSanPham;
                frmAddSanPham.txtMaSanPham.Text = maSanPham;
                frmAddSanPham.txtTenSanPham.Text = Convert.ToString(dgvDanhSachSanPham.CurrentRow.Cells["dgvTenSanPham"].Value);
                frmAddSanPham.txtGia.Text = Convert.ToString(dgvDanhSachSanPham.CurrentRow.Cells["dgvGia"].Value);
                frmAddSanPham.txtDuongDan.Text = Convert.ToString(dgvDanhSachSanPham.CurrentRow.Cells["dgvDuongDan"].Value);
                frmAddSanPham.rdoCo.Checked = Convert.ToBoolean(dgvDanhSachSanPham.CurrentRow.Cells["dgvTrangThai"].Value) ? true : false;
                frmAddSanPham.cbLoaiSanPham.Text = Convert.ToString(dgvDanhSachSanPham.CurrentRow.Cells["dgvMaLoai"].Value).Trim();

                saveDirectory = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                relativePath = dgvDanhSachSanPham.CurrentRow.Cells["dgvDuongDan"].Value.ToString();
                string imagePath = Path.Combine(saveDirectory, relativePath.TrimStart('\\'));
                if (File.Exists(imagePath))
                {
                    frmAddSanPham.picSanPham.Image = Image.FromFile(imagePath);
                }
                else
                {
                    MessageBox.Show("Hình ảnh không tồn tại: " + imagePath, "Thông báo", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                frmAddSanPham.ShowDialog();
                LoadData();
            }
            else if (dgvDanhSachSanPham.CurrentCell.OwningColumn.Name == "dgvXem")
            {
                frmViewSanPham frmViewSanPham = new frmViewSanPham();   

                string maSanPham = Convert.ToString(dgvDanhSachSanPham.CurrentRow.Cells["dgvMaSanPham"].Value);
                string tenSanPham = Convert.ToString(dgvDanhSachSanPham.CurrentRow.Cells["dgvTenSanPham"].Value);
                string giaSanPham = Convert.ToString(dgvDanhSachSanPham.CurrentRow.Cells["dgvGia"].Value);
                string duongDan = Convert.ToString(dgvDanhSachSanPham.CurrentRow.Cells["dgvDuongDan"].Value);
                bool trangThai = Convert.ToBoolean(dgvDanhSachSanPham.CurrentRow.Cells["dgvTrangThai"].Value);
                string loaiSanPham = Convert.ToString(dgvDanhSachSanPham.CurrentRow.Cells["dgvMaLoai"].Value);

                frmViewSanPham.SetProductInfo(maSanPham, tenSanPham, giaSanPham, duongDan, trangThai, loaiSanPham);
                frmViewSanPham.ShowDialog();
            }
            else if (dgvDanhSachSanPham.CurrentCell.OwningColumn.Name == "dgvXoa")
            {
                string maSanPham = Convert.ToString((dgvDanhSachSanPham.CurrentRow.Cells["dgvMaSanPham"].Value));
                if (MessageBox.Show("Bạn chắc chắn  muốn xóa sản phẩm?", "Thông báo", 
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    if (busSanPham.delete(maSanPham))
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
            else if (dgvDanhSachSanPham.CurrentCell.OwningColumn.Name == "dgvXem")
            {
                frmViewSanPham frmViewSanPham = new frmViewSanPham();

                string maSanPham = Convert.ToString(dgvDanhSachSanPham.CurrentRow.Cells["dgvMaSanPham"].Value);
                string tenSanPham = Convert.ToString(dgvDanhSachSanPham.CurrentRow.Cells["dgvTenSanPham"].Value);
                string giaSanPham = Convert.ToString(dgvDanhSachSanPham.CurrentRow.Cells["dgvGia"].Value);
                string duongDan = Convert.ToString(dgvDanhSachSanPham.CurrentRow.Cells["dgvDuongDan"].Value);
                bool trangThai = Convert.ToBoolean(dgvDanhSachSanPham.CurrentRow.Cells["dgvTrangThai"].Value);
                string loaiSanPham = Convert.ToString(dgvDanhSachSanPham.CurrentRow.Cells["dgvMaLoai"].Value);

                frmViewSanPham.SetProductInfo(maSanPham, tenSanPham, giaSanPham, duongDan, trangThai, loaiSanPham);
                frmViewSanPham.ShowDialog();
            }
        }

        private byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        public Image ByteArrayToImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }

        private void LoadData()
        {
            try
            {
                totalRows = busSanPham.GetTotalProductCount();
                totalPages = (int)Math.Ceiling((double)totalRows / PageSize);
                lbTotalPage.Text = totalPages.ToString();

                DataTable dt = busSanPham.GetPageProduct(currentPageIndex, PageSize);
                dgvDanhSachSanPham.DataSource = dt;

                dgvDanhSachSanPham.Refresh();
                lbTotalRows.Text = "Tổng số dòng: " + totalRows.ToString();

                foreach (DataGridViewColumn column in dgvDanhSachSanPham.Columns)
                {
                    if (column.Name == "ProductImage" && column is DataGridViewImageColumn)
                    {
                        DataGridViewImageColumn imageColumn = (DataGridViewImageColumn)column;
                        imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            currentPageIndex = 1;
            LoadData();
            lbCurrentPage.Text = currentPageIndex.ToString();
        }
        private void btnPrev_Click(object sender, EventArgs e)
        {

            if (currentPageIndex > 1)
            {
                currentPageIndex--;
                LoadData();
                lbCurrentPage.Text = currentPageIndex.ToString();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

            if (currentPageIndex < totalPages)
            {
                currentPageIndex++;
                LoadData();
                lbCurrentPage.Text = currentPageIndex.ToString();
            }
        }
        private void btnLastPage_Click(object sender, EventArgs e)
        {
            currentPageIndex = totalPages;
            LoadData();
            lbCurrentPage.Text = currentPageIndex.ToString();
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

        private void btnTimKiem_Click_1(object sender, EventArgs e)
        {
            string sp = txtTimKiem.Text;
            if (string.IsNullOrEmpty(sp))
            {
                MessageBox.Show("Vui lòng nhập nội dung cần tìm!", "Thông báo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DataTable dt = busSanPham.search(sp);
                if (dt.Rows.Count > 0)
                {
                    dgvDanhSachSanPham.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sản phẩm", "Thông báo", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
