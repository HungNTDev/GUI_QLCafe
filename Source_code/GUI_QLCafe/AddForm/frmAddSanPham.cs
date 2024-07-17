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

        public void Nofication(string msg)
        {
            frmNotification notification = new frmNotification();
            //frmNotification.showNotfication(msg);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            float gia;
            bool isInt = float.TryParse(txtGia.Text.Trim(), out gia);
            if (txtMaSanPham.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaSanPham.Focus();
                return;
            }
            else if (txtTenSanPham.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenSanPham.Focus();
                return;
            }
            else if (!isInt || float.Parse(txtGia.Text) <= 0)
            {
                MessageBox.Show("Gia sẽ số ngữc nhất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGia.Focus();
                return;
            }
            else if (cbTrangThai.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lý chọn trang thái sẽ chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbTrangThai.Focus();
                return;
            }
            else
            {
                DTO_Product product = new DTO_Product(txtMaSanPham.Text, txtTenSanPham.Text, float.Parse(txtGia.Text), fileSavePath, int.Parse(cbTrangThai.Text), fileName);
                if (busproduct.insert(product))
                {
                    MessageBox.Show("Thêm sản phẩm thành công");
                    File.Copy(fileAddress, fileSavePath, true);
                    this.Nofication("Save successfully!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm sản phẩm thất bại");
                    this.Nofication("Save failed!");
                }
            }
        }

        private void frmAddSanPham_Load(object sender, EventArgs e)
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
