using BUS_QLCafe;
using System.Windows.Forms;

namespace GUI_QLCafe
{
    public partial class frmDoiMatKhau : Form
    {
        //string stremail; // nhận email từ frmMain
        BUS_Staff busStaff = new BUS_Staff();
        //frmDangNhap dn = new frmDangNhap();
        public frmDoiMatKhau() // thêm tham số string email vào
        {
            InitializeComponent();
            // stremail = email;
            // txtEmail.Text = stremail;
            // txtEmail.Enabled = false;
        }

        private void panelDoiMatKhau_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnChangePassword_Click(object sender, System.EventArgs e)
        {
            if (txtNewPassword.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mật khẩu mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNewPassword.Focus();
                return;
            }
            else if (txtOldPassword.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mật khẩu cũ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtOldPassword.Focus();
                return;
            }
            else if (txtRetypePassword.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập lại mật khẩu mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRetypePassword.Focus();
                return;
            }
            else
            {
                if (MessageBox.Show("Bạn chắc chắn muốn đổi mật khẩu", "Thông báo", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    string matkhaumoi = busStaff.encryption(txtNewPassword.Text);
                    string matkhaucu = busStaff.encryption(txtOldPassword.Text);

                    if (busStaff.updateNewMK(txtEmail.Text, matkhaucu, matkhaumoi))
                    {
                        MessageBox.Show("Cập nhật mật khẩu thành công, bạn cần phải đăng nhập lại");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu cũ không đúng, Cập nhật mật khẩu không thành công");
                        txtNewPassword.Text = null;
                        txtOldPassword.Text = null;
                        txtRetypePassword.Text = null;
                    }
                }
                else
                {
                    txtNewPassword.Text = null;
                    txtOldPassword.Text = null;
                    txtRetypePassword.Text = null;
                }
            }
        }

        private void chkShowPassword_CheckedChanged(object sender, System.EventArgs e)
        {
            if (chkShowPassword.Checked == true)
            {
                txtNewPassword.PasswordChar = '\0';
                txtOldPassword.PasswordChar = '\0';
                txtRetypePassword.PasswordChar = '\0';
            }
            else
            {
                txtNewPassword.PasswordChar = '*';
                txtOldPassword.PasswordChar = '*';
                txtRetypePassword.PasswordChar = '*';
            }
        }

        private void txtNewPassword_TextChanged(object sender, System.EventArgs e)
        {


        }

    }
}
