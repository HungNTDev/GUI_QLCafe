using BUS_QLCafe;
using DTO_QLCafe;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Oauth2.v2;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.Data;
using System.IO;
using System.Net.Mail;
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
                txtEmail.Clear();
                chkGhiNhoTK.Checked = false;
            }
        }
        //Xóa tài khoản đã chọn lần trước để đăng nhập
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
                //frmMainQLBH mainForm = new frmMainQLBH();

                //login = true;

                DataTable dt = busStaff.VaiTro(staff.email);
                frmMainQLCF.role = dt.Rows[0]["VaiTro"].ToString();//Lưu vai trò
                //frmMainQLBH.session = 1;
                //frmMainQLBH.email = nv.EmailNV;

                //frmMainQLBH.profile = vaitro;

                //MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //foreach (Form form in Application.OpenForms)
                //{
                //    if (form is frmMainQLBH)
                //    {
                //        ((frmMainQLBH)form).HienMenu();
                //        break;
                //    }
                //}

                this.Close();
            }
            else
            {
                messageDialog.Show("Email hoặc mật khẩu không đúng!", "Thông báo");
                txtPassword.Clear();
                txtPassword.Focus();
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
                    DataTable dt = busStaff.VaiTro(staff.email);
                    //frmMainQLBH.vaiTro = dt.Rows[0]["VaiTro"].ToString();
                    //frmMainQLBH.session = 1;
                    //frmMainQLBH.email = nv.EmailNV;

                    //messageDialog.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //foreach (Form form in Application.OpenForms)
                    //{
                    //    if (form is frmMainQLBH)
                    //    {
                    //        ((frmMainQLBH)form).HienMenu();
                    //        break;
                    //    }
                    //}
                    this.Close();
                }
                else
                {
                    messageDialog.Show("Đăng nhập thất bại!", "Thông báo");
                }
            }
        }

        private void panelDangNhap_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
