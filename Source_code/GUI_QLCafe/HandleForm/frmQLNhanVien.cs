using BUS_QLCafe;
using DTO_QLCafe;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
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


        int pageNumber = 1;
        int numberRecord = 5;

        private const int PageSize = 10;
        private int currentPageIndex = 1;
        private int totalPages = 0;
        private int totalRows = 0;
        private void LoadData(int status)
        {
            try
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

            rdoQuanTri.Enabled=false;
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

            currentPageIndex = 1;
            lbCurrentPage.Text = currentPageIndex.ToString();
            LoadData(status);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            btnSu.Enabled=false;

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
                btnSu.Enabled = true;
                btnMoHinh.Enabled = true;

                txtEmail.Enabled = true;
                txtTen.Enabled = true;
                rdoHoatDong.Enabled = true;
                rdoNgungHoatDong.Enabled=true;
                rdoNhanVien.Enabled = true;
                rdoQuanTri.Enabled= true;

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

                // Update totalRows and totalPages based on the new status
                currentPageIndex = 1; // Reset to the first page when changing status
                LoadData(status); // Load data based on the new status
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
            if (selected)
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
                else if (rdoQuanTri.Checked == false && rdoNhanVien.Checked == false)
                {
                    MessageBox.Show("Vui lòng chọn vai trò!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (rdoHoatDong.Checked == false && rdoNgungHoatDong.Checked == false)
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
                else if (txtEmail.Text != email && busNhanVien.KiemTraEmail(txtEmail.Text))
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

                            // Call checkStatus on the main form
                            if (this.mainForm != null)
                            {
                                this.mainForm.checkStatus(txtEmail.Text, role);
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

            rdoHoatDong.Enabled = false;
            rdoHoatDong.Checked = false;

            rdoNgungHoatDong.Enabled = false;
            rdoNgungHoatDong.Checked = false;

            rdoNhanVien.Enabled = false;
            rdoNhanVien.Checked = false;

            rdoNhanVien.Enabled = false;
            rdoQuanTri.Checked = false;
            
            txtEmail.Enabled = false;
            txtTen.Enabled = false;

            btnSu.Enabled = false;

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

        private void dgvDanhSachNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
