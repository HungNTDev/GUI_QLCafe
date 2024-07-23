using BUS_QLCafe;
using System;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;

namespace GUI_QLCafe
{
    public partial class frmQuenMatKhau : Form
    {
        public frmQuenMatKhau(string email)
        {
            InitializeComponent();
            this.email = email;
        }
        private string email;
        BUS_Staff busNV = new BUS_Staff();
        string matKhau;
        //string maXacNhan;
        private void btnGui_Click(object sender, EventArgs e)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(RandomString(4, true));
            builder.Append(RandomNumber(1000, 9999));
            builder.Append(RandomString(2, false));

            matKhau = builder.ToString();

            SendMail(txtEmail.Text, matKhau);

            busNV.CapNhatMK(txtEmail.Text, matKhau);

            messageDialog.Show($"Mật khẩu mới đã được gửi về {txtEmail.Text}!", "Thông báo");
                
        }
        public string RandomString(int size, bool lowerCase)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }

            if (lowerCase)
            {
                return builder.ToString().ToLower();
            }
            return builder.ToString();
        }

        //Tao so ngau nhien
        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        public void SendMail(string email, string maxacnhan)
        {
            //Now we must create a new Smtp client to send our email.
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587); //smtp.gmail.com // For Gmail //Authentication.
                                                                       //This is where the valid email account comes into play. You must have a valid email //account (with password) to give our program a place to send the mail from.
            NetworkCredential cred = new NetworkCredential("baotncps40789@gmail.com", "jflb jhdg dqht lwra");
            //To send an email we must first create a new mailMessage (an email) to send. 
            MailMessage Msg = new MailMessage();
            // Sender e-mail address.
            Msg.From = new MailAddress("baotncps40789@gmail.com"); //Nothing But Above Credentials or your credentials (*******@gmail.com) // Recipient e-mail address.
            Msg.To.Add(email);
            // Assign the subject of our message.
            Msg.Subject = "Anh/chị đã sử dụng tính năng quên mật khẩu";
            // Create the content (body) of our message.
            Msg.Body = "Chào anh/chị. Mật khẩu mới là: " + maxacnhan;
            // Send our account login details to the client.
            client.Credentials = cred;
            //Enabling SSL (Secure Sockets Layer, encyription) is reqiured by most email providers to send mail
            client.EnableSsl = true;
            client.Send(Msg); // Send our email.

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            //if (txtEmail.Text.Trim().Length == 0)
            //{
            //    messageDialog.Show("Hãy nhập email", "Thông báo");
            //    txtEmail.Focus();
            //    return;
            //}
            //else if (txtNewPassword.Text.Trim().Length == 0)
            //{
            //    messageDialog.Show("Hãy nhập mật khẩu mới", "Thông báo");
            //    txtNewPassword.Focus();
            //    return;
            //}
            //else if (txtNewPassword.Text.Trim().Length < 8)
            //{
            //    messageDialog.Show("Mật khẩu mới phải dài hơn 8 kí tự", "Thông báo");
            //    txtNewPassword.Focus();
            //    return;
            //}
            //else if (txtRetypePassword.Text.Trim().Length == 0)
            //{
            //    messageDialog.Show("Hãy nhập lại mật khẩu mới", "Thông báo");
            //    txtRetypePassword.Focus();
            //    return;
            //}
            //else if (txtMaXacNhan.Text.Trim().Length == 0)
            //{
            //    messageDialog.Show("Hãy nhập mã xác nhận!", "Thông báo");
            //    txtMaXacNhan.Focus();
            //    return;
            //}
            //else
            //{
            //    if (txtMaXacNhan.Text != maXacNhan)
            //    {
            //        messageDialog.Show("Mã xác nhận không chính xác", "Thông báo");
            //        txtMaXacNhan.Focus();
            //        return;
            //    }
            //    else if (txtNewPassword.Text != txtRetypePassword.Text)
            //    {
            //        messageDialog.Show("Mật khẩu không giống nhau", "Thông báo");
            //        txtRetypePassword.Focus();
            //        return;
            //    }
            //    else
            //    {
            //        BUS_Staff busNhanVien = new BUS_Staff();
            //        string EmailNV = txtEmail.Text;
            //        string MatKhauMoi = busNhanVien.encryption(txtNewPassword.Text);

            //        if (busNhanVien.CapNhatMK(EmailNV, MatKhauMoi))//cap nhat mat khau thanh cong
            //        {
            //            messageDialog.Show("Cập nhật mật khẩu thành công", "Thông báo");

            //            maXacNhan = null;

            //            txtEmail.Clear();
            //            txtMaXacNhan.Clear();
            //            txtNewPassword.Clear();
            //            txtRetypePassword.Clear();
            //        }
            //        else
            //        {
            //            messageDialog.Show("Cập nhật mật khẩu thất bại!", "Thông báo");
            //        }
            //    }
            //}
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked == true)
            {
                txtNewPassword.PasswordChar = '\0';
                txtRetypePassword.PasswordChar = '\0';
            }
            else
            {
                txtNewPassword.PasswordChar = '*';
                txtRetypePassword.PasswordChar = '*';
            }
        }
    }
}
