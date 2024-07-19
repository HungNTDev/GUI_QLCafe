using BUS_QLCafe;
using DTO_QLCafe;
using System;
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

        private void btnLuu_Click(object sender, EventArgs e)
        {
            float gia;
            bool isfloat = float.TryParse(txtGia.Text.Trim(), out gia);
            int trangthai;
            bool isInt = int.TryParse(cbTrangThai.SelectedItem?.ToString(), out trangthai);

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
            else if (cbTrangThai.Text.Trim().Length == 0)
            {
                messageDialog.Show("Vui lòng chọn trạng thái!", "Thông báo");
                cbTrangThai.Focus();
                return;
            }
            else if (guna2TextBox1.Text.Trim().Length == 0)
            {
                messageDialog.Show("Vui mới chọn loại cho sản phẩm!", " 😀 báo");
                guna2TextBox1.Focus();
                return;
            }
            else
            {
                try
                {


                    DTO_Product product = new DTO_Product(txtMaSanPham.Text, txtTenSanPham.Text,
                        gia, fileSavePath, trangthai, guna2TextBox1.Text);

                    if (busproduct.insert(product))
                    {
                        File.Copy(fileAddress, fileSavePath, true);
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
                    MessageBox.Show("Error" + ex.Message);
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
                //if (dlgopen.ShowDialog() == DialogResult.OK)
                //{
                //    fileAddress = dlgopen.FileName;
                //    fileName = Path.GetFileName(dlgopen.FileName);
                //    string saveDirectory = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                //    fileSavePath = Path.Combine(saveDirectory, "img", fileName);

                //    // Sao chép tệp tin vào thư mục đích trước khi sử dụng trong PictureBox
                //    File.Copy(fileAddress, fileSavePath, true);

                //    // Sử dụng FileStream để mở ảnh từ tệp tin đích
                //    using (FileStream fs = new FileStream(fileSavePath, FileMode.Open, FileAccess.Read))
                //    {
                //        picSanPham.Image = Image.FromStream(fs);
                //    }
                //}

                if (dlgopen.ShowDialog() == DialogResult.OK)
                {
                    picSanPham.Image = Image.FromFile(dlgopen.FileName);

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
