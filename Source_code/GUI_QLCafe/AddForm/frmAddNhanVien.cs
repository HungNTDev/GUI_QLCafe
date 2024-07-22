﻿using BUS_QLCafe;
using DTO_QLCafe;
using System;
using System.Drawing;
using System.IO;
using System.Net.Mail;
using System.Windows.Forms;

namespace GUI_QLCafe
{
    public partial class frmAddNhanVien : Form
    {
        private string id;
        private string chucnang;
        private string email;
        private string fullname;
        private int role;
        private int status;
        private string image;
        private string saveDirectory;


        BUS_Staff busNhanVien = new BUS_Staff();

        string checkImgUrl; //Kiểm tra ảnh
        string fileName; //tên file
        string fileSavePath; //vị trí lưu
        string fileAddress;
        public frmAddNhanVien(string id, string chucnang, string email, string fullname, int role, int status, string image, string saveDirectory)
        {
            InitializeComponent();
            this.id = id;
            this.chucnang = chucnang;
            this.email = email;
            this.fullname = fullname;
            this.role = role;
            this.status = status;
            this.image = image;
            this.saveDirectory = saveDirectory;
            LoadFormData();
        }

        // phương thức này dùng để gọi Notfication khi thêm thành công
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
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (chucnang == "luu")
            {
                int role = 0; //vai tro nhan vien
                if (rdoQuanTri.Checked)
                {
                    role = 1;
                }
                int status = 0; //ngung hoat dong
                if (rdoHoatDong.Checked)
                {
                    status = 1;
                }
                if (txtEmail.Text.Trim().Length == 0)
                {
                    messageDialog.Show("Vui lòng nhập email!", "Thông báo");
                    txtEmail.Focus();
                    return;
                }
                else if (!IsValid(txtEmail.Text.Trim()))
                {
                    messageDialog.Show("Vui lòng nhập đúng định dạng email!", "Thông báo");
                    txtEmail.Focus();
                    return;
                }
                else if (txtTenNhanVien.Text.Trim().Length == 0)
                {
                    messageDialog.Show("Vui lòng nhập tên nhân viên!", "Thông báo");
                    txtTenNhanVien.Focus();
                    return;
                }
                else if (rdoQuanTri.Checked == false && rdoNhanVien.Checked == false)
                {
                    messageDialog.Show("Vui lòng chọn vai trò!", "Thông báo");
                    return;
                }
                else if (rdoHoatDong.Checked == false && rdoNgungHoatDong.Checked == false)
                {
                    messageDialog.Show("Vui lòng chọn trạng thái!", "Thông báo");
                    return;
                }
                else if (txtDuongDan.Text.Trim().Length == 0) // phải nhập hình
                {
                    messageDialog.Show("Vui lòng chọn hình", "Thông Báo");
                    return;
                }

                //Nếu thêm nhân viên thành công thì hiện cái Nofication lên không thì ngược lại
                else
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

                    try
                    {
                        // Copy the image to the specified directory
                        File.Copy(fileAddress, fileSavePath, true); // Copy and overwrite if exists

                        // Update txtHinh to point to the new location
                        txtDuongDan.Text = fileSavePath;

                        DTO_Staff staff = new DTO_Staff(txtTenNhanVien.Text, txtDuongDan.Text, txtEmail.Text, role, status);

                        if (busNhanVien.insert(staff))
                        {
                            
                            frmQLNhanVien qlnv = new frmQLNhanVien();
                            qlnv.Reload();
                            Nofication("Thêm thành công!", frmNotification.enumType.Success);
                        }
                        else
                        {
                            Nofication("Thêm thất bại!", frmNotification.enumType.Failed);
                            return;
                        }
                    }
                    catch (Exception ex)
                    {
                        messageDialog.Show("Lỗi khi lưu ảnh: " + ex.Message, "Thông Báo");
                        return;
                    }

                }
            }
            else
            {
                int role = 0; //vai tro nhan vien
                if (rdoQuanTri.Checked)
                {
                    role = 1;
                }
                int status = 0; //ngung hoat dong
                if (rdoHoatDong.Checked)
                {
                    status = 1;
                }
                if (txtEmail.Text.Trim().Length == 0)
                {
                    messageDialog.Show("Vui lòng nhập email!", "Thông báo");
                    txtEmail.Focus();
                    return;
                }
                else if (!IsValid(txtEmail.Text.Trim()))
                {
                    messageDialog.Show("Vui lòng nhập đúng định dạng email!", "Thông báo");
                    txtEmail.Focus();
                    return;
                }
                else if (txtTenNhanVien.Text.Trim().Length == 0)
                {
                    messageDialog.Show("Vui lòng nhập tên nhân viên!", "Thông báo");
                    txtTenNhanVien.Focus();
                    return;
                }
                else if (rdoQuanTri.Checked == false && rdoNhanVien.Checked == false)
                {
                    messageDialog.Show("Vui lòng chọn vai trò!", "Thông báo");
                    return;
                }
                else if (rdoHoatDong.Checked == false && rdoNgungHoatDong.Checked == false)
                {
                    messageDialog.Show("Vui lòng chọn trạng thái!", "Thông báo");
                    return;
                }
                else if (txtDuongDan.Text.Trim().Length == 0) // phải nhập hình
                {
                    messageDialog.Show("Vui lòng chọn hình", "Thông Báo");
                    return;
                }

                else
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

                    DTO_Staff staff = new DTO_Staff(txtTenNhanVien.Text, txtDuongDan.Text, txtEmail.Text, role, status);

                    if (busNhanVien.update(staff, id))
                    {   
                        frmQLNhanVien qlnv = new frmQLNhanVien();
                        qlnv.Reload();
                        this.Nofication("Sửa thành công!", frmNotification.enumType.Success);
                    }
                    else
                    {
                        this.Nofication("Sửa thất bại!", frmNotification.enumType.Failed);
                        return;
                    }
                    
                }
            }
        }
        public void Load()
        {
            frmAddNhanVien_Load(this, EventArgs.Empty);
        }
        private void frmAddNhanVien_Load(object sender, EventArgs e)
        {
            //if (chucnang == "sua")
            //{
            //    btnLuu.Text = "SỬA";
            //}
        }
        private void LoadFormData()
        {

            btnLuu.Text = chucnang == "sua" ? "SỬA" : "LƯU";
            if (chucnang == "sua")
            {

                txtEmail.Text = email;
                txtTenNhanVien.Text = fullname;
                rdoQuanTri.Checked = role == 1;
                rdoNhanVien.Checked = role != 1;
                rdoHoatDong.Checked = status == 1;
                rdoNgungHoatDong.Checked = status != 1;
                txtDuongDan.Text = image;


                string imagePath = Path.Combine(saveDirectory, image.TrimStart('\\')); // Chuyển đổi thành đường dẫn tuyệt đối


                //Nếu file đã tồn tại thì gửi ảnh lên picture box
                if (File.Exists(imagePath))
                {
                    picNhanVien.Image = Image.FromFile(imagePath);
                    txtDuongDan.Text = imagePath;
                }
                else
                {
                    MessageBox.Show("Hình ảnh không tồn tại: " + imagePath, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    picNhanVien.Image = null;
                }
            }
            //txtEmail.Text = email;
            //txtTenNhanVien.Text = fullname;


            //if (role == 1)
            //{
            //    rdoQuanTri.Checked = true;
            //}
            //else
            //{
            //    rdoNhanVien.Checked = true;
            //}

            //if (status == 1)
            //{
            //    rdoHoatDong.Checked = true;
            //}
            //else
            //{
            //    rdoNgungHoatDong.Checked = true;
            //}

            //string relativePath = image;
            //string imagePath = Path.Combine(saveDirectory, relativePath.TrimStart('\\')); // Chuyển đổi thành đường dẫn tuyệt đối


            ////Nếu file đã tồn tại thì gửi ảnh lên picture box
            //if (File.Exists(imagePath))
            //{
            //    picNhanVien.Image = Image.FromFile(imagePath);
            //}
            //else
            //{
            //    MessageBox.Show("Hình ảnh không tồn tại: " + imagePath, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

        }

        //Nếu thiếu thông tin thì trở về
        private bool ValidateInput()
        {
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                messageDialog.Show("Vui lòng nhập email!", "Thông báo");
                txtEmail.Focus();
                return false;
            }
            else if (!IsValid(txtEmail.Text))
            {
                messageDialog.Show("Vui lòng nhập đúng định dạng email!", "Thông báo");
                txtEmail.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(txtTenNhanVien.Text))
            {
                messageDialog.Show("Vui lòng nhập tên nhân viên!", "Thông báo");
                txtTenNhanVien.Focus();
                return false;
            }
            else if (!rdoQuanTri.Checked && !rdoNhanVien.Checked)
            {
                messageDialog.Show("Vui lòng chọn vai trò!", "Thông báo");
                return false;
            }
            else if (!rdoHoatDong.Checked && !rdoNgungHoatDong.Checked)
            {
                messageDialog.Show("Vui lòng chọn trạng thái!", "Thông báo");
                return false;
            }
            else if (string.IsNullOrEmpty(txtDuongDan.Text))
            {
                messageDialog.Show("Vui lòng chọn hình", "Thông Báo");
                return false;
            }

            role = rdoQuanTri.Checked ? 1 : 0;
            status = rdoHoatDong.Checked ? 1 : 0;
            return true;
        }
        private void btnMoHinh_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Bitmap(*.bmp)|*.bmp|JPEG(*.jpg)|*.jpg|GIF(*.gif)|*.gif|All files(*.*)|*.*";
            ofd.FilterIndex = 2;
            ofd.Title = "Chọn ảnh của sản phẩm";

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
