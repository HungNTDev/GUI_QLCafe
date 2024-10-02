using BUS_QLCafe;
using DTO_QLCafe;
using GUI_QLCafe.ViewForm;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net.Mail;
using System.Windows.Forms;

namespace GUI_QLCafe
{
    public partial class frmQLNhanVien : Form
    {
        private frmMainQLCF mainForm;
        public frmQLNhanVien(frmMainQLCF mainForm)
        {
            InitializeComponent();
            originalImage = picNhanVien.Image;
            this.mainForm = mainForm;

            // Initialize the ComboBox items
            cboStatus.Items.Clear();
            cboStatus.Items.Add("Hoạt động"); // Corresponds to status = 1
            cboStatus.Items.Add("Ngừng hoạt động"); // Corresponds to status = 0
        }


        private Image originalImage;

        BUS_Staff busNhanVien = new BUS_Staff();
        private int status = 1;


        string checkImgUrl; //Kiểm tra ảnh
        string fileName; //tên file
        string fileSavePath; //vị trí lưu
        string fileAddress;

        private const int PageSize = 15;
        private int currentPageIndex = 1;
        private int totalPages = 0;
        private int totalRows = 0;
        private void LoadData(int status)
        {
            try
            {

                txtTimKiem.Clear();
                selected = false;


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
                }

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

        private void Default()
        {

            txtEmail.Clear();
            txtTen.Clear();
            txtDuongDan.Clear();

            btnMoHinh.Enabled = false;

            picNhanVien.Image = originalImage;

            rdoHoatDong.Enabled = false;
            rdoHoatDong.Checked = false;

            rdoNgungHoatDong.Enabled = false;
            rdoNgungHoatDong.Checked = false;

            rdoNhanVien.Enabled = false;
            rdoNhanVien.Checked = false;

            rdoQuanTri.Enabled = false;
            rdoQuanTri.Checked = false;

            rdoChuSoHuu.Enabled = false;
            rdoChuSoHuu.Checked = false;


            txtEmail.Enabled = false;
            txtTen.Enabled = false;
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


            btnMoHinh.Enabled = false;

            picNhanVien.Image = originalImage;
            rdoHoatDong.Checked = false;
            rdoNgungHoatDong.Checked = false;
            rdoNhanVien.Checked = false;
            rdoQuanTri.Checked = false;


            rdoHoatDong.Enabled = false;
            rdoHoatDong.Checked = false;

            rdoNgungHoatDong.Enabled = false;
            rdoNgungHoatDong.Checked = false;

            rdoNhanVien.Enabled = false;
            rdoNhanVien.Checked = false;

            rdoQuanTri.Enabled = false;
            rdoQuanTri.Checked = false;

            txtEmail.Enabled = false;
            txtTen.Enabled = false;

            btnSu.Enabled = false;

            selected = false;
            LoadGridView_NhanVien();
        }
        private void frmQLNhanVien_Load(object sender, EventArgs e)
        {
            //Reload();
            Default();
            currentPageIndex = 1;
            lbCurrentPage.Text = currentPageIndex.ToString();
            LoadData(status);
        }
        bool searching = false;

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            searching = true;
            currentPageIndex = 1; // Start at the first page
            PerformSearch();
        }
        private void PerformSearch()
        {
            try
            {
                btnSu.Enabled = false;

                string column = "";
                int pageSize = 15; // Giới hạn số trang

                if (txtTimKiem.Text.Trim().Length == 0)
                {
                    Nofication("Nhập nội dung cần tìm!", frmNotification.enumType.Failed);
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

                // Tìm
                var result = busNhanVien.search(column, txtTimKiem.Text, status, currentPageIndex, pageSize, out totalRows, out totalPages);

                dgvDanhSachNhanVien.DataSource = result;

                // Cập nhật số trang và số dòng
                lbTotalRows.Text = totalRows.ToString();
                lbTotalPage.Text = totalPages.ToString();
                lbCurrentPage.Text = currentPageIndex.ToString();

                Default();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private string saveDirectory;
        private string relativePath;

        private string currentEmail = "";
        private void dgvDanhSachNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDanhSachNhanVien.CurrentCell.OwningColumn.Name == "dgvSua")
            {
                frmAddNhanVien frmAdd = new frmAddNhanVien
                {
                    formMode = frmAddNhanVien.FormMode.Sua
                };
                frmAdd.txtMaNV.Enabled = false;
                frmAdd.txtEmail.Enabled = true;
                frmAdd.txtTenNhanVien.Enabled = true;
                frmAdd.txtDuongDan.Enabled = false;

                frmAdd.txtMaNV.Text = Convert.ToString(dgvDanhSachNhanVien.CurrentRow.Cells["dgvMaNV"].Value);
                frmAdd.txtEmail.Text = Convert.ToString(dgvDanhSachNhanVien.CurrentRow.Cells["dgvEmail"].Value);
                frmAdd.txtTenNhanVien.Text = Convert.ToString(dgvDanhSachNhanVien.CurrentRow.Cells["dgvFullName"].Value);


                if (Convert.ToString(dgvDanhSachNhanVien.CurrentRow.Cells["dgvRoleStaff"].Value) == "Nhân viên")
                {
                    frmAdd.rdoNhanVien.Checked = true;
                }
                else
                {
                    frmAdd.rdoQuanTri.Checked = true;
                }

                if (Convert.ToString(dgvDanhSachNhanVien.CurrentRow.Cells["dgvStatusStaff"].Value) == "Hoạt động")
                {
                    frmAdd.rdoHoatDong.Checked = true;
                }
                else
                {
                    frmAdd.rdoNgungHoatDong.Checked = true;
                }
                string saveDirectory = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                string relativePath = dgvDanhSachNhanVien.CurrentRow.Cells["dgvImageStaff"].Value.ToString();
                string imagePath = Path.Combine(saveDirectory, relativePath.TrimStart('\\'));

                //Nếu file đã tồn tại thì gửi ảnh lên picture box
                if (File.Exists(imagePath))
                {
                    frmAdd.picNhanVien.Image = Image.FromFile(imagePath);
                }

                frmAdd.ShowDialog();

                LoadData(status);
            }
            else if (dgvDanhSachNhanVien.CurrentCell.OwningColumn.Name == "dgvXem")
            {
                frmViewNhanVien frmView = new frmViewNhanVien();

                string maNV = Convert.ToString(dgvDanhSachNhanVien.CurrentRow.Cells["dgvMaNV"].Value);
                string tenNV = Convert.ToString(dgvDanhSachNhanVien.CurrentRow.Cells["dgvFullName"].Value);
                string email = Convert.ToString(dgvDanhSachNhanVien.CurrentRow.Cells["dgvEmail"].Value);
                string duongDan = Convert.ToString(dgvDanhSachNhanVien.CurrentRow.Cells["dgvDuongDan"].Value);
                bool trangThai = false;
                bool vaiTro = false;

                if (Convert.ToString(dgvDanhSachNhanVien.CurrentRow.Cells["dgvRoleStaff"].Value) == "Nhân viên")
                {
                    vaiTro = true;
                }

                if (Convert.ToString(dgvDanhSachNhanVien.CurrentRow.Cells["dgvStatusStaff"].Value) == "Hoạt động")
                {
                    trangThai = true;
                }

                frmView.SetStaffInfo(maNV, tenNV, email, duongDan, trangThai, vaiTro);
                frmView.ShowDialog();
            }
            ////Lấy vị trí lưu
            //saveDirectory = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
            //if (dgvDanhSachNhanVien.Rows.Count > 0)
            //{
            //    txtTen.Enabled = true;
            //    txtEmail.Enabled = true;
            //    btnSu.Enabled = true;
            //    btnMoHinh.Enabled = true;

            //    txtEmail.Enabled = true;
            //    txtTen.Enabled = true;

            //    rdoHoatDong.Enabled = true;
            //    rdoNgungHoatDong.Enabled = true;
            //    rdoNhanVien.Enabled = true;
            //    rdoQuanTri.Enabled = true;

            //    txtTen.Text = dgvDanhSachNhanVien.CurrentRow.Cells["dgvFullName"].Value.ToString();
            //    txtEmail.Text = dgvDanhSachNhanVien.CurrentRow.Cells["dgvEmail"].Value.ToString();
            //    txtDuongDan.Text = dgvDanhSachNhanVien.CurrentRow.Cells["dgvImageStaff"].Value.ToString();

            //    currentEmail = dgvDanhSachNhanVien.CurrentRow.Cells["dgvEmail"].Value.ToString();

            //    string role = dgvDanhSachNhanVien.CurrentRow.Cells["dgvRoleStaff"].Value.ToString();

            //    switch (role)
            //    {
            //        case "Chủ sở hữu":
            //            rdoChuSoHuu.Checked = true;
            //            break;
            //        case "Quản trị":
            //            rdoQuanTri.Checked = true;
            //            break;
            //        case "Nhân viên":
            //            rdoNhanVien.Checked = true;
            //            break;
            //    }

            //    if (int.Parse(dgvDanhSachNhanVien.CurrentRow.Cells["dgvStatusStaff"].Value.ToString()) == 1)
            //    {
            //        rdoHoatDong.Checked = true;
            //    }
            //    else
            //    {
            //        rdoNgungHoatDong.Checked = true;
            //    }

            //    relativePath = dgvDanhSachNhanVien.CurrentRow.Cells["dgvImageStaff"].Value.ToString();
            //    string imagePath = Path.Combine(saveDirectory, relativePath.TrimStart('\\')); // Chuyển đổi thành đường dẫn tuyệt đối


            //    //Nếu file đã tồn tại thì gửi ảnh lên picture box
            //    if (File.Exists(imagePath))
            //    {
            //        picNhanVien.Image = Image.FromFile(imagePath);
            //    }
            //    else
            //    {
            //        messageDialog.Show("Hình ảnh không tồn tại: " + imagePath, "Thông báo");
            //        return;
            //    }
            //    selected = true;

            //    //Chủ sở hữu với chủ sở hữu khác
            //    if (frmMainQLCF.role == "Chủ sở hữu" && role == "Chủ sở hữu")
            //    {
            //        rdoHoatDong.Enabled = false;
            //        rdoNgungHoatDong.Enabled = false;
            //        rdoNhanVien.Enabled = false;
            //        rdoQuanTri.Enabled = false;
            //        rdoChuSoHuu.Enabled = false;
            //        txtEmail.Enabled = false;
            //        btnMoHinh.Enabled = false;
            //    }

            //    //Bản thân quản trị
            //    else if (frmMainQLCF.email == txtEmail.Text && frmMainQLCF.role == "Quản trị")
            //    {
            //        //rdoHoatDong.Enabled = false;
            //        //rdoNgungHoatDong.Enabled = false;
            //        //rdoNhanVien.Enabled = false;
            //        //rdoQuanTri.Enabled = false;
            //        //rdoChuSoHuu.Enabled = false;

            //        txtEmail.Enabled = false;
            //        //txtTen.Enabled = false;
            //        //btnMoHinh.Enabled = false;
            //        //btnSu.Enabled = false;
            //    }

            //    //Quản trị với chủ sở hữu
            //    else if (frmMainQLCF.role == "Quản trị" && role == "Chủ sở hữu")
            //    {
            //        rdoHoatDong.Enabled = false;
            //        rdoNgungHoatDong.Enabled = false;
            //        rdoNhanVien.Enabled = false;
            //        rdoQuanTri.Enabled = false;
            //        rdoChuSoHuu.Enabled = false;

            //        txtEmail.Enabled = false;
            //        txtTen.Enabled = false;
            //        btnMoHinh.Enabled = false;
            //        btnSu.Enabled = false;
            //    }

            //    //Quản trị với quản trị khác
            //    else if (frmMainQLCF.role == "Quản trị" && role == "Quản trị")
            //    {
            //        rdoChuSoHuu.Enabled = false;

            //        //txtEmail.Enabled = false;
            //        //txtTen.Enabled = false;
            //        //btnMoHinh.Enabled = false;
            //        //btnSu.Enabled = false;
            //    }


            //    //Quản trị với nhân viên khác
            //    else if (frmMainQLCF.role == "Quản trị" && role == "Nhân viên")
            //    {
            //        rdoQuanTri.Enabled = false;
            //        rdoChuSoHuu.Enabled = false;
            //    }

            //}
            //else
            //{
            //    MessageBox.Show("Bảng trống", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
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
            rdoChuSoHuu.Checked = false;

            btnSu.Enabled = false;




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

                searching = false; // Reset 
                // Update số dòng and số trang theo status mới
                currentPageIndex = 1; // Reset khi đổi status
                LoadData(status); // Load data 
                lbCurrentPage.Text = currentPageIndex.ToString();
            }
        }

        private void btnThe_Click(object sender, EventArgs e)
        {
            frmAddNhanVien frmAddNV = new frmAddNhanVien(/*"", "luu", null, null, 0, 0, null, ""*/);
            frmAddNV.ShowDialog();
            LoadData(status);
        }
        public void Nofication(string msg, frmNotification.enumType type)
        {
            frmNotification notification = new frmNotification();
            frmNotification.showNotfication(msg, type);
        }
        public bool IsValid(string emailaddress) //kiem tra xem email co hop le khong
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }
        private void btnSu_Click(object sender, EventArgs e)
        {
            string id = dgvDanhSachNhanVien.CurrentRow.Cells["IdStaff"].Value.ToString();
            string email = dgvDanhSachNhanVien.CurrentRow.Cells["Email"].Value.ToString();
            string fullname = dgvDanhSachNhanVien.CurrentRow.Cells["FullName"].Value.ToString();
            string image = dgvDanhSachNhanVien.CurrentRow.Cells["ImageStaff"].Value.ToString();

            string role = "Nhân viên"; //vai tro nhan vien
            int status = 0; //ngung hoat dong

            //frmAddNhanVien frmAddNV = new frmAddNhanVien(id, "sua", email, fullname, role, status, image, saveDirectory);
            //frmAddNV.ShowDialog();
            //Reload();

            if (rdoQuanTri.Checked)
            {
                role = "Quản trị";
            }
            else if (rdoChuSoHuu.Checked)
            {
                role = "Chủ sở hữu";
            }
            if (rdoHoatDong.Checked)
            {
                status = 1;
            }


            if (txtEmail.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập email!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }
            else if (!IsValid(txtEmail.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng email!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }
            else if (txtTen.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập tên nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTen.Focus();
                return;
            }
            else if (rdoQuanTri.Checked == false && rdoNhanVien.Checked == false && rdoChuSoHuu.Checked == false)
            {
                MessageBox.Show("Vui lòng chọn vai trò!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (rdoHoatDong.Checked == false && rdoNgungHoatDong.Checked == false && rdoChuSoHuu.Checked == false)
            {
                MessageBox.Show("Vui lòng chọn trạng thái!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txtDuongDan.Text.Trim().Length == 0) // phải nhập hình
            {
                MessageBox.Show("Vui lòng chọn hình", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Nếu email mới khác với email hiện tại, kiểm tra xem email mới có tồn tại trong hệ thống hay không
            else if (txtEmail.Text != currentEmail && busNhanVien.KiemTraEmail(txtEmail.Text))
            {
                MessageBox.Show("Email đã tồn tại trong hệ thống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }
            else
            {
                if (MessageBox.Show("Chắc chắn sửa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Đường dẫn thư mục gốc của dự án
                    string projectDirectory = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\.."));
                    string saveDirectory = Path.Combine(projectDirectory, "GUI_QLCafe", "img", "Staff");

                    // Tạo thư mục nếu chưa có
                    if (!Directory.Exists(saveDirectory))
                    {
                        Directory.CreateDirectory(saveDirectory);
                    }


                    // Đường dẫn ảnh
                    string fileAddress = txtDuongDan.Text; // txtDuongDan chứa đường dẫn tới ảnh
                    string fileName = Path.GetFileName(fileAddress);
                    string fileSavePath = Path.Combine(saveDirectory, fileName);



                    // Kiểm tra xem hình đã tồn tại trong thư mục staff hay chưa
                    if (!File.Exists(fileSavePath))
                    {
                        try
                        {
                            File.Copy(fileAddress, fileSavePath, true); // Sao chép hình vào thư mục Images nếu chưa tồn tại
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi khi lưu ảnh: " + ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // Update txtHinh to point to the new location
                    txtDuongDan.Text = fileSavePath;

                    DTO_Staff staff = new DTO_Staff(txtTen.Text, txtDuongDan.Text, txtEmail.Text, role, status);

                    if (busNhanVien.update(staff, id))
                    {
                        frmMainQLCF ql = new frmMainQLCF();

                        this.Nofication("Sửa thành công!", frmNotification.enumType.Success);

                        //Gọi check status
                        if (this.mainForm != null)
                        {
                            this.mainForm.checkStatus(txtEmail.Text, role, status);
                        }

                        LoadData(status);



                        //if (changes)
                        //{
                        //    MessageBox.Show("Vai trò của bạn đã thay đổi, vui lòng đăng nhập lại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        //    this.Hide();
                        //    ql.Close();
                        //}
                    }
                    else
                    {
                        this.Nofication("Sửa thất bại!", frmNotification.enumType.Failed);
                        return;
                    }
                }
            }
        }

        private void btnLamMo_Click(object sender, EventArgs e)
        {

            Default();

            btnSu.Enabled = false;

            cboTim.SelectedIndex = -1;

            selected = false;
            searching = false; // Reset tìm kiếm
            LoadData(status);
        }


        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            currentPageIndex = 1;
            if (!searching)
            {
                LoadData(status);
            }
            else
            {
                PerformSearch();
            }

            lbCurrentPage.Text = currentPageIndex.ToString();
        }

        private void btnLastPage_Click(object sender, EventArgs e)
        {
            currentPageIndex = totalPages;
            if (!searching)
            {
                LoadData(status);
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
                    LoadData(status);
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
                    LoadData(status);
                }
                else
                {

                    PerformSearch();
                }
                lbCurrentPage.Text = currentPageIndex.ToString();
            }
        }

        private void btnMoHinh_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Bitmap(*.bmp)|*.bmp|JPEG(*.jpg)|*.jpg|GIF(*.gif)|*.gif|All files(*.*)|*.*";
            ofd.FilterIndex = 2;
            ofd.Title = "Chọn ảnh của nhân viên";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                fileAddress = ofd.FileName; // Lấy đường dẫn ảnh
                picNhanVien.Image = Image.FromFile(fileAddress);
                fileName = Path.GetFileName(ofd.FileName); // Tên ảnh

                saveDirectory = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));

                fileSavePath = saveDirectory + "\\img\\" + fileName; //combine with file name
                /*Path.Combine(saveDirectory, fileName);*/ // Tạo đường dẫn để lưu file vào thư mục của project
                txtDuongDan.Text = fileAddress;
            }
        }
    }
}
