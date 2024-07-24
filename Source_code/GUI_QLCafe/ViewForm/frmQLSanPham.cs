using BUS_QLCafe;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web.UI.Design;
using System.Windows.Forms;
namespace GUI_QLCafe
{
    public partial class frmQLSanPham : Form
    {
        BUS_Product busSanPham = new BUS_Product();


        int pageNumber = 1;
        int numberRecord = 5;

        private const int PageSize = 10;
        private int currentPageIndex = 1;
        private int totalPages = 0;
        private int totalRows = 0;

        public frmQLSanPham()
        {
            InitializeComponent();
            //dgvDanhSachSanPham.DataSource = LoadRecord(pageNumber, numberRecord);
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
            //LoadGridView_SanPham();
            //LoadCombobox_Loai();
            LoadData();
            currentPageIndex = 1;
            lbCurrentPage.Text = currentPageIndex.ToString();
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

        //List<Product> LoadRecord(int page, int recordNum)
        //{
        //    List<Product> result = new List<Product>();

        //    using (ThongTinSanPhamDataContext db = new ThongTinSanPhamDataContext())
        //    {
        //        result = db.Products.Skip((page - 1) * recordNum).Take(numberRecord).ToList();
        //    }
        //    return result;
        //}


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

        private byte[] ImageToByteArray(Image image)
        {
            using(MemoryStream ms = new MemoryStream())
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

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dataRow in dt.Rows)
                {
                    string imagePath = dataRow["ImageProduct"].ToString();

                    if (File.Exists(imagePath))
                    {
                        using(Image imageProduct = Image.FromFile(imagePath))
                        {
                            dataRow["ImageProduct"] =ImageToByteArray(imageProduct);
                        }
                    }
                    else
                    {
                        //ataRow["ImageProduct"] = DBNull.Value;
                    }
                }
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
                lbTotalRows.Text = totalRows.ToString();

                LoadHinhAnh(dt);
                foreach(DataGridViewColumn column in dgvDanhSachSanPham.Columns)
                {
                    if(column.Name == "ProductImage" && column is DataGridViewImageColumn)
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
            //if (pageNumber - 1 > 0)
            //{
            //    pageNumber--;
            //    dgvDanhSachSanPham.DataSource = LoadRecord(pageNumber, numberRecord);
            //}

            if (currentPageIndex > 1)
            {
                currentPageIndex--;
                LoadData();
                lbCurrentPage.Text = currentPageIndex.ToString();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //int totalrecord = 0;
            //using (ThongTinSanPhamDataContext db = new ThongTinSanPhamDataContext())
            //{
            //    totalrecord = db.Products.Count();
            //}
            //if (pageNumber - 1 <= totalrecord / numberRecord)
            //{
            //    pageNumber++;
            //    dgvDanhSachSanPham.DataSource = LoadRecord(pageNumber, numberRecord);
            //}

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

        private void dgvDanhSachSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
