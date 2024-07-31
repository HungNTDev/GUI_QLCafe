using BUS_QLCafe;
using System.Windows.Forms;

namespace GUI_QLCafe
{
    public partial class frmDoiMatKhau : Form
    {
        string stremail; // nhận email từ frmMain
        BUS_Staff busStaff = new BUS_Staff();
        //frmDangNhap dn = new frmDangNhap();


        private frmMainQLCF mainForm;
        public frmDoiMatKhau(string email, frmMainQLCF mainForm) // thêm tham số string email vào
        {
            InitializeComponent();
            stremail = email;
            txtEmail.Text = stremail;
            txtEmail.Enabled = false;
            this.mainForm = mainForm;
        }

        private void panelDoiMatKhau_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnChangePassword_Click(object sender, System.EventArgs e)
        {
            if (txtNewPassword.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mật khẩu mới", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNewPassword.Focus();
                return;
            }
            else if (txtOldPassword.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mật khẩu cũ", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtOldPassword.Focus();
                return;
            }
            else if (txtRetypePassword.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập lại mật khẩu mới", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRetypePassword.Focus();
                return;
            }
            else
            {
                if (MessageBox.Show("Bạn chắc chắn muốn đổi mật khẩu", "Thông báo", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string matkhaumoi = busStaff.encryption(txtNewPassword.Text);
                    string matkhaucu = busStaff.encryption(txtOldPassword.Text);

                    if (busStaff.updateNewMK(txtEmail.Text, matkhaucu, matkhaumoi))
                    {
                        MessageBox.Show("Cập nhật mật khẩu thành công, bạn cần phải đăng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.Close();
                        // Call checkStatus on the main form
                        if (this.mainForm != null)
                        {
                            this.mainForm.reLogin();
                        }

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

        //Phương thức kiểm tra độ mạnh của mật khẩu
        public string CheckPasswordStrength(string password)
        {
            int score = 0;

            if (password.Length > 8)
            {
                score++;
            }
            if (System.Text.RegularExpressions.Regex.IsMatch(password, @"[A-Z]"))
            {
                score++;
            }
            if (System.Text.RegularExpressions.Regex.IsMatch(password, @"[a-z]"))
            {
                score++;
            }
            if (System.Text.RegularExpressions.Regex.IsMatch(password, @"[0-9]"))
            {
                score++;
            }
            if (System.Text.RegularExpressions.Regex.IsMatch(password, @"[@]"))
            {
                score++;
            }

            switch (score)
            {
                default:
                    return "Mật khẩu rất yếu";
                case 1:
                    return "Mật khẩu yếu";
                case 2:
                    return "Mật khẩu trung bình";
                case 3:
                    return "Mật khẩu mạnh";
                case 4:
                    return "Mật khẩu rất mạnh";
            }
        }

        private void txtNewPassword_TextChanged(object sender, System.EventArgs e)
        {
            //string password = txtNewPassword.Text;
            //string strength = CheckPasswordStrength(password);
            //lbPasswordStrength.Text = strength;

            //switch (strength)
            //{
            //    default:
            //        lbPasswordStrength.ForeColor = Color.Red;
            //        break;
            //    case "Mật khẩu yếu":
            //        lbPasswordStrength.ForeColor = Color.Red;
            //        break;
            //    case "Mật khẩu trung bình":
            //        lbPasswordStrength.ForeColor = Color.Orange;
            //        break;
            //    case "Mật khẩu mạnh":
            //        lbPasswordStrength.ForeColor = Color.LightGreen;
            //        break;
            //    case "Mật khẩu rất mạnh":
            //        lbPasswordStrength.ForeColor = Color.Green;
            //        break;
            //}
        }

        private void cbClose_Click(object sender, System.EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dl == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
