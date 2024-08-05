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

        public FormMode formMode { get; set; }

        public enum FormMode { Them, Sua }

        private void frmAddSanPham_Load_1(object sender, EventArgs e)
        {
            if (formMode == FormMode.Them)
            {
                lbHeaderText.Text = "THÊM THÔNG TIN SẢN PHẨM";
            }
            if (formMode == FormMode.Sua)
            {
                lbHeaderText.Text = "CẬP NHẬT THÔNG TIN SẢN PHẨM";
            }
            txtDuongDan.Enabled = false;
        }

        // phương thức này dùng để gọi Notfication khi thêm thành công
        public void Message(string msg, frmNotification.enumType type)
        {
            frmNotification notification = new frmNotification();
            frmNotification.showNotfication(msg, type);
        }

        public string id = "";
        private void btnLuu_Click(object sender, EventArgs e)
        {
            float gia;
            bool isfloat = float.TryParse(txtGia.Text.Trim(), out gia);
            string trangthai = rdoCo.Checked ? "Còn Bán" : "Ngưng Bán";

            // Kiểm tra các điều kiện
            if (string.IsNullOrWhiteSpace(txtMaSanPham.Text))
            {
                MessageBox.Show("Vui lòng nhập mã sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaSanPham.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtTenSanPham.Text))
            {
                MessageBox.Show("Vui lòng nhập tên sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenSanPham.Focus();
                return;
            }
            if (!isfloat || gia < 0)
            {
                MessageBox.Show("Vui lòng nhập giá hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtGia.Focus();
                return;
            }
            if (!rdoCo.Checked && !rdoKhong.Checked)
            {
                MessageBox.Show("Vui lòng chọn trạng thái!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cbLoaiSanPham.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng chọn loại cho sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbLoaiSanPham.Focus();
                return;
            }

            string fileAddress = txtDuongDan.Text;
            if (!File.Exists(fileAddress))
            {
                MessageBox.Show("Tệp không tồn tại: " + fileAddress, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // Đường dẫn thư mục
            string directory = Path.Combine(Application.StartupPath, "img", "Product");
            // Tên tệp

            // Đường dẫn đầy đủ
            string fullpath = Path.Combine(directory, fileName);

            try
            {
                // Kiểm tra và tạo thư mục nếu chưa tồn tại
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                // Đọc ảnh từ file và tạo bản sao
                using (FileStream fs = new FileStream(fileAddress, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        fs.CopyTo(ms);
                        ms.Position = 0;
                        picSanPham.Image = Image.FromStream(ms);

                        // Lưu ảnh vào đường dẫn đầy đủ
                        using (FileStream saveFile = new FileStream(fullpath, FileMode.Create, FileAccess.Write))
                        {
                            ms.CopyTo(saveFile);
                        }
                    }
                }

                txtDuongDan.Text = fullpath;
                DTO_Product product = new DTO_Product(txtMaSanPham.Text, txtTenSanPham.Text,
                    gia, fileSavePath, trangthai, cbLoaiSanPham.Text);

                if (formMode == FormMode.Them)
                {
                    if (string.IsNullOrEmpty(id))
                    {
                        if (busproduct.insert(product))
                        {
                            MessageBox.Show("Thêm sản phẩm thành công!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            this.Message("Thêm thất bại :(", frmNotification.enumType.Failed);
                        }
                    }
                }
                else
                {
                    product.IdProduct = id;
                    if (busproduct.update(product))
                    {
                        //lbtagname.Visible = true;
                        if (txtDuongDan.Text != checkUrlImage)
                        {
                            if (File.Exists(fileAddress))
                            {
                                File.Copy(fileAddress, fullpath, true);
                                MessageBox.Show("Cập nhật sản phẩm thành công!", "Thông báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("File nguồn không tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            this.Message("Cập nhật thất bại :(", frmNotification.enumType.Failed);
                        }
                    }
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show("Lỗi khi lưu ảnh: Không có quyền truy cập vào đường dẫn. " + ex.Message, "Thông Báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu ảnh: " + ex.Message, "Thông Báo");
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

                    // Đọc ảnh vào MemoryStream và gán cho PictureBox
                    using (FileStream fs = new FileStream(fileAddress, FileMode.Open, FileAccess.Read))
                    {
                        MemoryStream ms = new MemoryStream();
                        fs.CopyTo(ms);
                        ms.Position = 0;
                        picSanPham.Image = Image.FromStream(ms);
                    }

                    fileName = Path.GetFileName(dlgopen.FileName); // Tên ảnh

                    // Tạo đường dẫn để lưu file vào thư mục của project
                    string saveDirectory = Path.Combine(Application.StartupPath.Substring(0,
                        (Application.StartupPath.Length - 10)), "img", "Product");
                    if (!Directory.Exists(saveDirectory))
                    {
                        Directory.CreateDirectory(saveDirectory);
                    }

                    fileSavePath = Path.Combine(saveDirectory, fileName);

                    // Hiển thị đường dẫn ảnh trên giao diện
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
            DialogResult dl = MessageBox.Show("Bạn chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dl == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}