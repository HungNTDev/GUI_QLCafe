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

        private void btnLuu_Click(object sender, EventArgs e)
        {
            float gia;
            bool isInt = float.TryParse(txtGia.Text.Trim(), out gia);
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
            else if (!isInt || float.Parse(txtGia.Text) <= 0)
            {
                messageDialog.Show("Vui lòng nhập giá!", "Thông báo");
                txtGia.Focus();
                return;
            }
            else if (cbTrangThai.SelectedIndex == -1)
            {
                messageDialog.Show("Vui lòng chọn trạng thái!", "Thông báo");
                cbTrangThai.Focus();
                return;
            }
            else
            {
                DTO_Product product = new DTO_Product(txtMaSanPham.Text, txtTenSanPham.Text, float.Parse(txtGia.Text), fileSavePath, int.Parse(cbTrangThai.Text), fileName);
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
                    picSanPham.Image = Image.FromFile(fileAddress);
                    fileName = Path.GetFileName(dlgopen.FileName);
                    string saveDirectory = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                    fileSavePath = saveDirectory + "\\Images\\" + fileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }
    }
}
