using BUS_QLCafe;
using DTO_QLCafe;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Oauth2.v2;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using Guna.UI2.WinForms;
using System;
using System.Data;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace GUI_QLCafe
{
    public partial class frmDangNhap : Form
    {

        public int role { get; set; }
        public int status { get; set; }

        static string[] Scopes = { Oauth2Service.Scope.UserinfoEmail };
        static string ApplicationName = "QuanLyQuanCaPhe";

        DTO_Staff staff;
        BUS_Staff busStaff;

        public frmDangNhap()
        {
            InitializeComponent();
            DeleteStoredCredentials();
            this.Load += new System.EventHandler(this.frmDangNhap_Load); // Gắn sự kiện Load
        }
        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            // Kiểm tra xem có email đã được lưu không
            if (Properties.Settings.Default.RememberEmail)
            {
                txtEmail.Text = Properties.Settings.Default.SavedEmail;
                chkGhiNhoTK.Checked = true;
            }
            else
            {
                chkGhiNhoTK.Checked = false;
            }

        }
        //Xóa tài khoản đã chọn lần trước để đăng nhập

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
        private void btnDN_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text.Trim().Length == 0)
            {
                messageDialog.Show("Vui lòng nhập email!", "Thông báo");
                txtEmail.Focus();
                return;
            }
            else if (!IsValid(txtEmail.Text.Trim()))
            {
                messageDialog.Show("Vui lòng nhập đúng định dạng email!", "Thông báo");
                txtEmail.Focus();
                return;
            }
            else if (txtPassword.Text.Trim().Length == 0)
            {
                messageDialog.Show("Vui lòng nhập mật khẩu!", "Thông báo");
                txtPassword.Focus();
                return;
            }
            else
            {
                //frmMainQLBH.email = nv.EmailNV;

                staff = new DTO_Staff();
                busStaff = new BUS_Staff();

                staff.email = txtEmail.Text;
                staff.passwordStaff = busStaff.encryption(txtPassword.Text);

                if (busStaff.DangNhap(staff))
                {
                    if (chkGhiNhoTK.Checked)
                    {
                        Properties.Settings.Default.SavedEmail = txtEmail.Text;
                        Properties.Settings.Default.RememberEmail = true; // Lưu trạng thái của checkbox
                    }
                    else
                    {
                        Properties.Settings.Default.SavedEmail = string.Empty; // Xóa email khi không ghi nhớ
                        Properties.Settings.Default.RememberEmail = false; // Lưu trạng thái của checkbox
                    }
                    Properties.Settings.Default.Save();

                    frmMainQLCF mainform = new frmMainQLCF();
                    frmLoading frmLoading = new frmLoading();

                    DataTable dt = busStaff.VaiTro(staff.email);
                    frmMainQLCF.role = dt.Rows[0]["roleStaff"].ToString();
                    frmMainQLCF.session = 1;
                    frmMainQLCF.email = staff.email;

                    frmLoading.Show();

                    //foreach (Form form in Application.OpenForms)
                    //{
                    //    if (form is frmMainQLCF)
                    //    {
                    //        ((frmMainQLCF)form).PhanQuyen();
                    //        break;
                    //    }
                    //}

                    this.Hide();
                }
                else
                {
                    messageDialog.Show("Đăng nhập thất bại!", "Thông báo");
                    txtPassword.Clear();
                    txtPassword.Focus();
                    return;
                }
            }
            
        }

        private void picHiddenPassWord_Click(object sender, System.EventArgs e)
        {
            // Show password nếu người dùng click vào icon ẩn pass
            if (txtPassword.PasswordChar == '*')
            {
                picShowPassWord.BringToFront();
                txtPassword.PasswordChar = '\0';
            }
        }

        private void picShowPassWord_Click(object sender, System.EventArgs e)
        {  // Ẩn password nếu người dùng click vào icon show pass
            if (txtPassword.PasswordChar == '\0')
            {
                picHiddenPassWord.BringToFront();
                txtPassword.PasswordChar = '*';
            }
        }

        private void chkGhiNhoTK_CheckedChanged(object sender, System.EventArgs e)
        {
            //Lưu email
            if (chkGhiNhoTK.Checked)
            {
                Properties.Settings.Default.SavedEmail = txtEmail.Text;
                Properties.Settings.Default.RememberEmail = true;
            }
            else
            {
                Properties.Settings.Default.SavedEmail = string.Empty;
                Properties.Settings.Default.RememberEmail = false;
            }
            Properties.Settings.Default.Save();
        }


        //Đăng nhập bàng Google Account
        private void DeleteStoredCredentials()
        {
            string credPath = "token.json";

            if (Directory.Exists(credPath))
            {
                // It's a directory, so delete its contents and then the directory
                Directory.Delete(credPath, true);
            }
            else if (File.Exists(credPath))
            {
                // It's a file, so delete it
                File.Delete(credPath);
            }
            else
            {
            }
        }
        private async void btnDNGoogle_Click(object sender, System.EventArgs e)
        {
            UserCredential credential;

            // Path to the client_secrets.json file in the output directory
            string credPath = Path.Combine(Application.StartupPath, "Resources", "client_secrets.json");
            string tokenPath = Path.Combine(Application.StartupPath, "token.json");

            // Delete the stored credentials if they exist
            DeleteStoredCredentials();

            using (var stream = new FileStream(credPath, FileMode.Open, FileAccess.Read))
            {
                credential = await GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.FromStream(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(tokenPath, true));
            }

            var oauth2Service = new Oauth2Service(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });

            // Get email
            var userInfo = await oauth2Service.Userinfo.Get().ExecuteAsync();

            if (userInfo != null && !string.IsNullOrEmpty(userInfo.Email))
            {
                // Check if the email exists in your database
                staff = new DTO_Staff();
                busStaff = new BUS_Staff();

                staff.email = userInfo.Email;

                if (busStaff.KiemTraEmail(staff.email)) // Adjust this method to check only the email if necessary
                {

                    if (chkGhiNhoTK.Checked)
                    {
                        Properties.Settings.Default.SavedEmail = txtEmail.Text;
                        Properties.Settings.Default.RememberEmail = true; // Lưu trạng thái của checkbox
                    }
                    else
                    {
                        Properties.Settings.Default.SavedEmail = string.Empty; // Xóa email khi không ghi nhớ
                        Properties.Settings.Default.RememberEmail = false; // Lưu trạng thái của checkbox
                    }
                    Properties.Settings.Default.Save();

                    frmMainQLCF mainform = new frmMainQLCF();


                    DataTable dt = busStaff.VaiTro(staff.email);
                    frmMainQLCF.role = dt.Rows[0]["roleStaff"].ToString();
                    frmMainQLCF.session = 1;
                    frmMainQLCF.email = staff.email;

                    mainform.Show();

                    foreach (Form form in Application.OpenForms)
                    {
                        if (form is frmMainQLCF)
                        {
                            ((frmMainQLCF)form).PhanQuyen();
                            break;
                        }
                    }
                    this.Hide();
                }
                else
                {
                    messageDialog.Show("Đăng nhập thất bại!", "Thông báo");
                }
            }
        }




        private void cbClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private string TaoMK()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(RandomString(4, true));
            builder.Append(RandomNumber(1000, 9999));
            builder.Append(RandomString(2, false));

            string matKhau = builder.ToString();

            return matKhau;
        }
        private void lkQuenMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Guna2MessageDialog xacNhan = new Guna2MessageDialog();
            xacNhan.Buttons = MessageDialogButtons.OKCancel;
            xacNhan.Parent = this;

            if (DialogResult.Yes == xacNhan.Show("Bạn muốn sử dụng tính năng quên mật khẩu?", "Thông Báo"))
            {
                busStaff = new BUS_Staff();
                if (txtEmail.Text.Trim().Length == 0)
                {
                    messageDialog.Show("Vui lòng nhập email!", "Thông báo");
                    txtEmail.Focus();
                    return;
                }
                else if (!IsValid(txtEmail.Text))
                {
                    messageDialog.Show("Vui lòng nhập đúng định dạng email!", "Thông báo");
                    txtEmail.Focus();
                    return;
                }
                else if (!busStaff.KiemTraEmail(txtEmail.Text))
                {
                    messageDialog.Show("Email không tồn tại trong hệ thống!", "Thông báo");
                    txtEmail.Focus();
                    return;
                }
                else
                {
                    //frmQuenMatKhau frmQuenMatKhau = new frmQuenMatKhau(txtEmail.Text);
                    //frmQuenMatKhau.ShowDialog();


                    string EmailNV = txtEmail.Text;
                    string MatKhauMoi = busStaff.encryption(TaoMK());

                    if (busStaff.CapNhatMK(EmailNV, MatKhauMoi))//cap nhat mat khau thanh cong
                    {

                        SendMail(txtEmail.Text, TaoMK());
                        messageDialog.Show("Mật khẩu mới đã được gửi về email!", "Thông báo");
                    }
                }
            }
            else
            {
                return;
            }

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

        private void panelDangNhap_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
