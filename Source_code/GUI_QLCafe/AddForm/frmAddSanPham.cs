using BUS_QLCafe;
using DTO_QLCafe;
using System;
using System.Drawing;
using System.IO;
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
        private void btnLuu_Click(object sender, EventArgs e)
        {
            float gia;
            bool isfloat = float.TryParse(txtGia.Text.Trim(), out gia);
            int trangthai = rdoCo.Checked ? 1 : 0;

            // Kiểm tra các điều kiện
            if (string.IsNullOrWhiteSpace(txtMaSanPham.Text))
            {
                messageDialog.Show("Vui lòng nhập mã sản phẩm!", "Thông báo");
                txtMaSanPham.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtTenSanPham.Text))
            {
                messageDialog.Show("Vui lòng nhập tên sản phẩm!", "Thông báo");
                txtTenSanPham.Focus();
                return;
            }
            if (!isfloat || gia < 0)
            {
                messageDialog.Show("Vui lòng nhập giá hợp lệ!", "Thông báo");
                txtGia.Focus();
                return;
            }
            if (!rdoCo.Checked && !rdoKhong.Checked)
            {
                messageDialog.Show("Vui lòng chọn trạng thái!", "Thông báo");
                return;
            }
            if (cbLoaiSanPham.Text.Trim().Length == 0)
            {
                messageDialog.Show("Vui lòng chọn loại cho sản phẩm!", "Thông báo");

                cbLoaiSanPham.Focus();


                return;
            }

            string fileAddress = txtDuongDan.Text;
            if (!File.Exists(fileAddress))
            {
                messageDialog.Show("Tệp không tồn tại: " + fileAddress, "Thông Báo");
                return;
            }

            //string projectDirectory = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\.."));

            string saveDirectory = Path.Combine("\\img\\", "\\Product\\", fileName);

            if (!Directory.Exists(saveDirectory))
            {
                Directory.CreateDirectory(saveDirectory);
            }

            //string fileName = Path.GetFileName(fileAddress);


            DTO_Product product = new DTO_Product(txtMaSanPham.Text,
                txtTenSanPham.Text, gia, fileSavePath, trangthai, cbLoaiSanPham.Text);

            try
            {
                // Đọc ảnh từ file và tạo bản sao
                using (FileStream fs = new FileStream(fileAddress, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        fs.CopyTo(ms);
                        ms.Position = 0;
                        picSanPham.Image = Image.FromStream(ms);
                    }
                }

                txtDuongDan.Text = fileSavePath;

                if (string.IsNullOrEmpty(id))
                {
                    if (busproduct.insert(product))
                    {
                        MessageBox.Show("Thêm thành công");
                        this.Nofication("Thêm thành công!", frmNotification.enumType.Success);
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
                            if (File.Exists(fileSavePath))
                            {
                                File.Delete(fileSavePath);
                            }
                            File.Copy(fileAddress, fileSavePath, true);
                        }
                        this.Nofication("Cập nhật thành công!", frmNotification.enumType.Success);
                        this.Close();
                    }
                    else
                    {
                        this.Nofication("Cập nhật thất bại :(", frmNotification.enumType.Failed);
                    }
                }
            }
            catch (Exception ex)
            {
                messageDialog.Show("Lỗi khi lưu ảnh: " + ex.Message, "Thông Báo");
            }
        }

        private void picSanPham_Click(object sender, EventArgs e)
        {

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

                    // Đọc ảnh vào MemoryStream và gán cho PictureBox
                    using (FileStream fs = new FileStream(fileAddress, FileMode.Open, FileAccess.Read))
                    {
                        MemoryStream ms = new MemoryStream();

                        fs.CopyTo(ms);
                        ms.Position = 0;
                        picSanPham.Image = Image.FromStream(ms);

                    }

                    fileName = Path.GetFileName(dlgopen.FileName); // Tên ảnh

                    string saveDirectory = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                    fileSavePath = Path.Combine("img", "Product", fileName);
                    // Tạo đường dẫn để lưu file vào thư mục của project

                    txtDuongDan.Text = fileAddress;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}