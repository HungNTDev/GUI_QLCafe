using BUS_QLCafe;
using DTO_QLCafe;
using System.Data;
using System.Windows.Forms;

namespace GUI_QLCafe
{
    public partial class frmDangNhap : Form
    {

        public int role { get; set; }
        public int status { get; set; }

        DTO_Staff staff;
        BUS_Staff busStaff;

        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDN_Click(object sender, System.EventArgs e)
        {

            //frmMainQLBH.email = nv.EmailNV;

            staff = new DTO_Staff();

            staff.email = txtEmail.Text;
            staff.passwordStaff = txtPassword.Text;

            if (busStaff.DangNhap(staff))
            {
                if (chkGhiNhoTK.Checked)
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
    }
}
