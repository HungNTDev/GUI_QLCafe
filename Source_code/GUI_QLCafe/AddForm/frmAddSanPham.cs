using BUS_QLCafe;
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
                messageDialog.Show("Vui lòng chọn loại cho sản phẩm!", "Thông báo");
                txtLoaiSanPham.Focus();
                return;
            }
            else
            {
                try
                {
                    DTO_Product product = new DTO_Product(txtMaSanPham.Text, txtTenSanPham.Text, gia, fileSavePath, trangthai, txtLoaiSanPham.Text);

                    if (string.IsNullOrEmpty(id))
                    {
                        if (busproduct.insert(product))
                        {
                            File.Copy(fileAddress, fileSavePath, true);
                            this.Nofication("Thêm thành công!", frmNotification.enumType.Success);
                            if (this.Owner is frmQLSanPham frm)
                            {
                                frm.LoadGridView_SanPham();
                            }
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
                        else
                        {
                            this.Nofication("Cập nhật thất bại :(", frmNotification.enumType.Failed);
                        }
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
                if (dlgopen.ShowDialog() == DialogResult.OK)
                {
                    fileAddress = dlgopen.FileName;
                    fileName = Path.GetFileName(dlgopen.FileName);
                    string saveDirectory = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                    fileSavePath = Path.Combine(saveDirectory, "img", fileName);

                    // Sao chép tệp tin vào thư mục đích trước khi sử dụng trong PictureBox
                    File.Copy(fileAddress, fileSavePath, true);

                    // Sử dụng FileStream để mở ảnh từ tệp tin đích
                    using (FileStream fs = new FileStream(fileSavePath, FileMode.Open, FileAccess.Read))
                    {
                        picSanPham.Image = Image.FromStream(fs);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
          this.Close();
        }
    }
}
