using System;
using System.Net.Mail;
using System.Windows.Forms;

namespace GUI_QLCafe
{
    public partial class frmAddNhanVien : Form
    {
        public frmAddNhanVien()
        {
            InitializeComponent();
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
            int role = 0; //vai tro nhan vien
            if (rdoQuanTri.Checked)
            {
                role = 1;
            }
            int tinhtrang = 0; //ngung hoat dong
            if (rdoHoatDong.Checked)
            {
                tinhtrang = 1;
            }
            if (txtEmail.Text.Trim().Length == 0)
            {
                messageDialog.Show("Vui lòng nhập email!", "Thông báo");
            }
            else if (!IsValid(txtEmail.Text.Trim()))
            {
                messageDialog.Show("Vui lòng nhập đúng định dạng email!", "Thông báo");
            }
            else if (txtTenNhanVien.Text.Trim().Length == 0)
            {
                messageDialog.Show("Vui lòng nhập tên nhân viên!", "Thông báo");
            }
            else if (rdoHoatDong.Checked == false && rdoNgungHoatDong.Checked == false)
            {
                messageDialog.Show("Vui lòng chọn trạng thái!", "Thông báo");
            }
            else if (rdoQuanTri.Checked == false && rdoNhanVien.Checked == false)
            {
                messageDialog.Show("Vui lòng chọn vai trò!", "Thông báo");
            }

            // Nếu thêm nhân viên thành công thì hiện cái Nofication lên không thì ngược lại
            //if()
            //{
            //    this.Nofication("Thêm thành công!", frmNotification.enumType.Success);
            //}
            //else
            //{
            //    this.Nofication("Thêm thất bại :(", frmNotification.enumType.Failed);
            //}

        }

        private void frmAddNhanVien_Load(object sender, EventArgs e)
        {

        }
    }
}
