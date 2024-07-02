using BUS_QLCafe;
using DTO_QLCafe;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Oauth2.v2;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.Data;
using System.IO;
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
        private void btnDN_Click(object sender, System.EventArgs e)
        {

            //frmMainQLBH.email = nv.EmailNV;

            staff = new DTO_Staff();
            busStaff = new BUS_Staff();

            staff.email = txtEmail.Text;
            staff.passwordStaff = busStaff.encryption(txtPassword.Text);

            if (busStaff.DangNhap(staff))
            {
                if (cknGhiNhoTK.Checked)
                {
                    Properties.Settings.Default.SavedEmail = txtEmail.Text;
                    Properties.Settings.Default.RememberEmail = true; // Lưu trạng thái của checkbox
                    Properties.Settings.Default.Save();
                }
                else
                {
                    Properties.Settings.Default.RememberEmail = false;
                }
                //frmMainQLBH mainForm = new frmMainQLBH();

                //login = true;

                DataTable dt = busStaff.VaiTro(staff.email);
                //frmMainQLBH.vaiTro = dt.Rows[0]["VaiTro"].ToString();//Lưu vai trò
                //frmMainQLBH.session = 1;
                //frmMainQLBH.email = nv.EmailNV;

                //frmMainQLBH.profile = vaitro;
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                MessageBox.Show("Đăng nhập thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (cknGhiNhoTK.Checked)
            {
                Properties.Settings.Default.SavedEmail = txtEmail.Text;
                Properties.Settings.Default.Save();
            }
            // Xóa email khỏi cài đặt nếu hộp kiểm nhớ email không được chọn
            else
            {
                Properties.Settings.Default.SavedEmail = string.Empty;
                Properties.Settings.Default.Save();
            }
        }

        private void btnDNGoogle_Click(object sender, System.EventArgs e)
        {
            UserCredential credential;


            //Tạo thư mục + file để lưu thông tin đăng nhập
            string credPath = "token.json";

            // Delete the stored credentials if they exist
            DeleteStoredCredentials();

            using (var stream = new FileStream("client_secrets.json", FileMode.Open, FileAccess.Read))
            {
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.FromStream(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
            }

            var oauth2Service = new Oauth2Service(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });

            //Lấy email
            var userInfo = oauth2Service.Userinfo.Get().Execute();

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

                    MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    MessageBox.Show("Đăng nhập thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
