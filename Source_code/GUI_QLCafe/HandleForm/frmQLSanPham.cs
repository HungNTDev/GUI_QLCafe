using BUS_QLCafe;
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
            LoadData();
            currentPageIndex = 1;
            lbCurrentPage.Text = currentPageIndex.ToString();
        }

        private void dgvDanhSachSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDanhSachSanPham.CurrentCell.OwningColumn.Name == "dgvSua")
            {
                frmAddSanPham frmAddSanPham = new frmAddSanPham();
                frmAddSanPham.txtMaSanPham.Enabled = false;
                frmAddSanPham.cbLoaiSanPham.Enabled = false;
                frmAddSanPham.txtDuongDan.Enabled = false;
                frmAddSanPham.lbtagname.Visible = false;
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
                    MessageBox.Show("Hình ảnh không tồn tại: " + imagePath, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                frmAddSanPham.ShowDialog();
                LoadData();
            }
            else if (dgvDanhSachSanPham.CurrentCell.OwningColumn.Name == "dgvXoa")
            {
                string maSanPham = Convert.ToString((dgvDanhSachSanPham.CurrentRow.Cells["dgvMaSanPham"].Value));
                if (MessageBox.Show("Bạn chắc chắn  muốn xóa sản phẩm?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (busSanPham.delete(maSanPham))
                    {
                        this.Nofication("Xóa thành công!", frmNotification.enumType.Success);
                        LoadData();
                    }
                    else
                    {
                        this.Nofication("Xóa thất bại!", frmNotification.enumType.Failed);
                    }
                }
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

        private void LoadHinhAnh(DataTable dt)
        {
            //BindingSource bs = new BindingSource();
            //bs.DataSource = dt;

            //DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            //imageColumn.HeaderText = "Hình ảnh";
            //imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            //imageColumn.Name = "ImageColumn";
            //dgvDanhSachSanPham.Columns.Add(imageColumn);

            //// Đặt DataSource của DataGridView
            //dgvDanhSachSanPham.DataSource = bs;

            //foreach (DataGridViewRow row in dgvDanhSachSanPham.Rows)
            //{
            //    if (row.Cells["ImagePath"].Value != DBNull.Value)
            //    {
            //        byte[] imageBytes = (byte[])row.Cells["ImagePath"].Value;
            //        Image image = ByteArrayToImage(imageBytes);
            //        row.Cells["ImageColumn"].Value = image;
            //    }
            //}
            //if (dt.Rows.Count > 0)
            //{
            //    foreach (DataRow dataRow in dt.Rows)
            //    {
            //        string imagePath = dataRow["ImageProduct"].ToString();

            //        if (File.Exists(imagePath))
            //        {
            //            using (Image imageProduct = Image.FromFile(imagePath))
            //            {
            //                dataRow["ImageProduct"] = ImageToByteArray(imageProduct);
            //            }
            //        }
            //        else
            //        {
            //            //ataRow["ImageProduct"] = DBNull.Value;
            //        }
            //    }
            //}
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
                lbTotalRows.Text = totalRows.ToString();

                LoadHinhAnh(dt);
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

        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            currentPageIndex = 1;
            LoadData();
            lbCurrentPage.Text = currentPageIndex.ToString();
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
            DataTable dt = busSanPham.search(sp);
            if (dt.Rows.Count > 0)
            {
                dgvDanhSachSanPham.DataSource = dt;
                dgvDanhSachSanPham.Columns[2].HeaderText = "Mã sản phẩm";
                dgvDanhSachSanPham.Columns[3].HeaderText = "Tên sản phẩm";
                dgvDanhSachSanPham.Columns[4].HeaderText = "Giá";
                dgvDanhSachSanPham.Columns[5].HeaderText = "Đường dẫn";
                dgvDanhSachSanPham.Columns[6].HeaderText = "Trạng thái";
                dgvDanhSachSanPham.Columns[7].HeaderText = "Loại sản phẩm";
            }
            else
            {
                MessageBox.Show("Không tìm thấy sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            //LoadGridView_SanPham();
            LoadData();
        }


    }
}
