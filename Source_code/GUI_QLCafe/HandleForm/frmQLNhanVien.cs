using BUS_QLCafe;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Windows.Forms;

namespace GUI_QLCafe
{
    public partial class frmQLNhanVien : Form
    {
        public frmQLNhanVien()
        {
            InitializeComponent();
            originalImage = picNhanVien.Image;
        }
        private Image originalImage;

        BUS_Staff busNhanVien = new BUS_Staff();

        private int status = 1;
        private const int PageSize = 10;
        private int currentPageIndex = 1;
        private int totalPages = 0;
        private int totalRows = 0;

        public FormMode formMode { get; set; }

        public enum FormMode { Sua }

        private void LoadData(int status)
        {
            try
            {
                txtEmail.Clear();
                txtTen.Clear();
                txtTimKiem.Clear();
                txtDuongDan.Clear();
                picNhanVien.Image = originalImage;
                rdoHoatDong.Checked = false;
                rdoNgungHoatDong.Checked = false;
                rdoNhanVien.Checked = false;
                rdoQuanTri.Checked = false;

                selected = false;

                cboStatus.SelectedIndex = 1 - status;

                totalRows = busNhanVien.GetTotalStaffCount(status);
                totalPages = (int)Math.Ceiling((double)totalRows / PageSize);
                lbTotalPage.Text = totalPages.ToString();

                DataTable dt = busNhanVien.GetPageStaff(currentPageIndex, PageSize, status);
                dgvDanhSachNhanVien.DataSource = dt;

                dgvDanhSachNhanVien.Refresh();
                lbTotalRows.Text = totalRows.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void LoadGridView_NhanVien()
        {


            cboStatus.SelectedIndex = 1 - status;
            dgvDanhSachNhanVien.DataSource = busNhanVien.get(status);
        }

        public void Reload()
        {
            txtEmail.Clear();
            txtTen.Clear();
            txtTimKiem.Clear();
            txtDuongDan.Clear();
            picNhanVien.Image = originalImage;
            rdoHoatDong.Checked = false;
            rdoNgungHoatDong.Checked = false;
            rdoNhanVien.Checked = false;
            rdoQuanTri.Checked = false;

            selected = false;
            LoadGridView_NhanVien();
        }
        private void frmQLNhanVien_Load(object sender, EventArgs e)
        {
            //Reload();

            currentPageIndex = 1;
            lbCurrentPage.Text = currentPageIndex.ToString();
            LoadData(status);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            currentPageIndex = 1; // Start at the first page
            string column = "";
            int pageSize = 10; // Set the page size (number of rows per page)
            int totalRows;
            int totalPages;

            if (txtTimKiem.Text.Trim().Length == 0)
            {
                Notification("Nhập nội dung cần tìm!", frmNotification.enumType.Failed);
                return;
            }

            if (cboTim.SelectedIndex == -1)
            {
                column = "rong";
            }
            else
            {
                switch (cboTim.SelectedIndex)
                {
                    case 0:
                        column = "IdStaff";
                        break;
                    case 1:
                        column = "Email";
                        break;
                    case 2:
                        column = "FullName";
                        break;
                    case 3:
                        column = "RoleStaff";
                        break;
                }
            }

            // Call the search function with pagination parameters
            var result = busNhanVien.search(column, txtTimKiem.Text, status, currentPageIndex, pageSize, out totalRows, out totalPages);

            dgvDanhSachNhanVien.DataSource = result;

            // Update pagination controls or display relevant information
            lbTotalRows.Text = totalRows.ToString();
            lbTotalPage.Text = totalPages.ToString();
            lbCurrentPage.Text = currentPageIndex.ToString();

        }
        private string saveDirectory;
        private string relativePath;
        private void dgvDanhSachNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Lấy vị trí lưu

            saveDirectory = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
            if (dgvDanhSachNhanVien.Rows.Count > 0)
            {
                txtTen.Enabled = true;
                txtEmail.Enabled = true;
                gbTrangThai.Enabled = true;
                gbVaiTro.Enabled = true;


                txtTen.Text = dgvDanhSachNhanVien.CurrentRow.Cells["FullName"].Value.ToString();
                txtEmail.Text = dgvDanhSachNhanVien.CurrentRow.Cells["Email"].Value.ToString();
                txtDuongDan.Text = dgvDanhSachNhanVien.CurrentRow.Cells["ImageStaff"].Value.ToString();

                if (dgvDanhSachNhanVien.CurrentRow.Cells["RoleStaff"].Value.ToString() == "Quản trị")
                {
                    rdoQuanTri.Checked = true;
                }
                else
                {
                    rdoNhanVien.Checked = true;
                }

                if (int.Parse(dgvDanhSachNhanVien.CurrentRow.Cells["StatusStaff"].Value.ToString()) == 1)
                {
                    rdoHoatDong.Checked = true;
                }
                else
                {
                    rdoNgungHoatDong.Checked = true;
                }

                relativePath = dgvDanhSachNhanVien.CurrentRow.Cells["ImageStaff"].Value.ToString();
                string imagePath = Path.Combine(saveDirectory, relativePath.TrimStart('\\')); // Chuyển đổi thành đường dẫn tuyệt đối


                //Nếu file đã tồn tại thì gửi ảnh lên picture box
                if (File.Exists(imagePath))
                {
                    picNhanVien.Image = Image.FromFile(imagePath);
                }
                else
                {
                    messageDialog.Show("Hình ảnh không tồn tại: " + imagePath, "Thông báo");
                    return;
                }
                selected = true;
            }
            else
            {
                MessageBox.Show("Bảng trống", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        // phương thức này dùng để gọi Notfication khi thêm thành công
        public void Notification(string msg, frmNotification.enumType type)
        {
            frmNotification notification = new frmNotification();
            frmNotification.showNotfication(msg, type);
        }
        private bool selected;

        private void cboTim_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTim.SelectedItem != null)
            {
                txtTimKiem.PlaceholderText = $"Nhập {cboTim.SelectedItem.ToString().Substring(0, 1).ToLower()}" +
                    $"{cboTim.SelectedItem.ToString().Substring(1)} cần tìm";
            }
        }

        private void cboStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtEmail.Clear();
            txtTen.Clear();
            txtTimKiem.Clear();
            txtDuongDan.Clear();
            picNhanVien.Image = originalImage;
            rdoHoatDong.Checked = false;
            rdoNgungHoatDong.Checked = false;
            rdoNhanVien.Checked = false;
            rdoQuanTri.Checked = false;

            if (cboStatus.SelectedItem != null)
            {
                switch (cboStatus.SelectedIndex)
                {
                    case 0:
                        status = 1;
                        break;
                    case 1:
                        status = 0;
                        break;
                }

                // Update totalRows and totalPages based on the new status
                currentPageIndex = 1; // Reset to the first page when changing status
                LoadData(status); // Load data based on the new status
                lbCurrentPage.Text = currentPageIndex.ToString();
            }
        }

        private void btnThe_Click(object sender, EventArgs e)
        {
            frmAddNhanVien frmAddNV = new frmAddNhanVien("", "luu", null, null, 0, 0, null, "");
            frmAddNV.ShowDialog();
            Reload();
        }

        private void btnSu_Click(object sender, EventArgs e)
        {
            if (selected)
            {
                string id = dgvDanhSachNhanVien.CurrentRow.Cells["IdStaff"].Value.ToString();
                string email = dgvDanhSachNhanVien.CurrentRow.Cells["Email"].Value.ToString();
                string fullname = dgvDanhSachNhanVien.CurrentRow.Cells["FullName"].Value.ToString();
                int role = int.Parse(dgvDanhSachNhanVien.CurrentRow.Cells["RoleStaff"].Value.ToString());
                int status = int.Parse(dgvDanhSachNhanVien.CurrentRow.Cells["StatusStaff"].Value.ToString());
                string image = dgvDanhSachNhanVien.CurrentRow.Cells["ImageStaff"].Value.ToString();

                frmAddNhanVien frmAddNV = new frmAddNhanVien(id, "sua", email, fullname, role, status, image, saveDirectory);
                frmAddNV.ShowDialog();
                Reload();
            }
            else
            {
                Notification("Vui lòng chọn nhân viên cần sửa!", frmNotification.enumType.Failed);
                return;
            }
        }

        private void btnLamMo_Click(object sender, EventArgs e)
        {

            txtEmail.Clear();
            txtTen.Clear();
            txtTimKiem.Clear();
            txtDuongDan.Clear();
            picNhanVien.Image = originalImage;
            rdoHoatDong.Checked = false;
            rdoNgungHoatDong.Checked = false;
            rdoNhanVien.Checked = false;
            rdoQuanTri.Checked = false;

            selected = false;

            LoadData(status);
        }

        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            currentPageIndex = 1;
            LoadData(status);
            lbCurrentPage.Text = currentPageIndex.ToString();
        }

        private void btnLastPage_Click(object sender, EventArgs e)
        {
            currentPageIndex = totalPages;
            LoadData(status);
            lbCurrentPage.Text = currentPageIndex.ToString();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (currentPageIndex > 1)
            {
                currentPageIndex--;
                LoadData(status);
                lbCurrentPage.Text = currentPageIndex.ToString();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentPageIndex < totalPages)
            {
                currentPageIndex++;
                LoadData(status);
                lbCurrentPage.Text = currentPageIndex.ToString();
            }
        }
    }
}
