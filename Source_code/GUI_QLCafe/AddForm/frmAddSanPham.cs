﻿using BUS_QLCafe;
using DTO_QLCafe;
using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLCafe
{
    public partial class frmAddSanPham : Form
    {
        BUS_Product busproduct = new BUS_Product();

        string checkUrlImage;
        string fileName;
        string fileSavePath;
        string fileAddress;
        public frmAddSanPham()
        {
            InitializeComponent();
        }

        // phương thức này dùng để gọi Notfication khi thêm thành công
        public void Nofication(string msg, frmNotification.enumType type)
        {
            frmNotification notification = new frmNotification();
            frmNotification.showNotfication(msg, type);
        }

        public string id = "";
        private async void btnLuu_Click(object sender, EventArgs e)
        {
            float gia;
            bool isfloat = float.TryParse(txtGia.Text.Trim(), out gia);
            int trangthai = 0;

            if (rdoCo.Checked)
            {
                trangthai = 1;
            }

            if (txtMaSanPham.Text.Trim().Length == 0)
            {
                messageDialog.Show("Vui lòng nhập mã sản phẩm!", "Thông báo");
                txtMaSanPham.Focus();
                return;
            }
            else if (txtTenSanPham.Text.Trim().Length == 0)
            {
                messageDialog.Show("Vui lòng nhập tên sản phẩm!", "Thông báo");
                txtTenSanPham.Focus();
                return;
            }
            else if (!isfloat || gia < 0)
            {
                messageDialog.Show("Vui lòng nhập giá!", "Thông báo");
                txtGia.Focus();
                return;
            }
            else if (rdoCo.Checked == false && rdoKhong.Checked == false)
            {
                messageDialog.Show("Vui lòng chọn trạng thái!", "Thông báo");
                return;
            }
            else if (txtLoaiSanPham.Text.Trim().Length == 0)
            {
                messageDialog.Show("Vui mới chọn loại cho sản phẩm!", " 😀 báo");
                txtLoaiSanPham.Focus();
                return;
            }
            else
            {
                // Đường dẫn thư mục gốc của dự án
                string projectDirectory = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\.."));
                string saveDirectory = Path.Combine(projectDirectory, "GUI_QLCafe", "img", "Product");

                // Tạo thư mục nếu chưa có
                if (!Directory.Exists(saveDirectory))
                {
                    Directory.CreateDirectory(saveDirectory);
                }


                // Đường dẫn ảnh
                string fileAddress = txtDuongDan.Text; // txtDuongDan chứa đường dẫn tới ảnh
                string fileName = Path.GetFileName(fileAddress);
                string fileSavePath = Path.Combine(saveDirectory, fileName);

                DTO_Product product = new DTO_Product(txtMaSanPham.Text, txtTenSanPham.Text, gia, fileSavePath, trangthai, txtLoaiSanPham.Text);

                try
                {
                    // Copy the image to the specified directory
                    File.Copy(fileAddress, fileSavePath, true); // Copy and overwrite if exists

                    // Update txtHinh to point to the new location
                    txtDuongDan.Text = fileSavePath;

                    if (string.IsNullOrEmpty(id))
                    {
                        if (busproduct.insert(product))
                        {
                            this.Nofication("Thêm thành công!", frmNotification.enumType.Success);
                            await Task.Delay(3000);
                            this.Close();
                        }
                        else
                        {
                            this.Nofication("Thêm thất bại :(", frmNotification.enumType.Failed);
                        }
                    }
                    else
                    {
                        product.IdProduct = id;
                        if (busproduct.update(product))
                        {
                            if (txtDuongDan.Text != checkUrlImage)
                            {
                                File.Copy(fileAddress, fileSavePath, true);
                            }
                            this.Nofication("Cập nhật thành công!", frmNotification.enumType.Success);
                            await Task.Delay(3000);
                            this.Close();
                        }
                    }
                }
                    DTO_Product product = new DTO_Product(txtMaSanPham.Text, txtTenSanPham.Text,
                        gia, fileSavePath, trangthai, guna2TextBox1.Text);

                    if (busproduct.insert(product))
                    {
                        this.Nofication("Thêm thành công!", frmNotification.enumType.Success);
                        this.Close();
                    }
                    else
                    {
                        this.Nofication("Thêm thất bại :(", frmNotification.enumType.Failed);
                    }
                }
                catch (Exception ex)
                {
                    messageDialog.Show("Lỗi khi lưu ảnh: " + ex.Message, "Thông Báo");
                }

            }
        }


        private void btnMoHinh_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlgopen = new OpenFileDialog();
                dlgopen.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.gif;*.bmp)|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                dlgopen.FilterIndex = 2;
                dlgopen.Title = "Chọn ảnh minh họa cho sản phẩm";
                if (dlgopen.ShowDialog() == DialogResult.OK)
                {
                    fileAddress = dlgopen.FileName; // Lấy đường dẫn ảnh
                    picSanPham.Image = Image.FromFile(fileAddress);
                    fileName = Path.GetFileName(dlgopen.FileName); // Tên ảnh

                    string saveDirectory = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));

                    fileSavePath = saveDirectory + "\\img\\" + "\\products\\" + fileName; //combine with file name
                    /*Path.Combine(saveDirectory, fileName);*/ // Tạo đường dẫn để lưu file vào thư mục của project
                    txtDuongDan.Text = fileAddress;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }

        private void frmAddSanPham_Load(object sender, EventArgs e)
        {

        }

        private void cbTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
