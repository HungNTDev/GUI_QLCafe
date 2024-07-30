using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLCafe
{
    public partial class frmAddVoucher : Form
    {
        public frmAddVoucher()
        {
            InitializeComponent();
        }

        public FormMode formMode { get; set; }

        public enum FormMode { Them, Sua }

        // phương thức này dùng để gọi Notfication khi thêm thành công
        public void Nofication(string msg, frmNotification.enumType type)
        {
            frmNotification notification = new frmNotification();
            frmNotification.showNotfication(msg, type);
        }

        private void frmAddVoucher_Load(object sender, EventArgs e)
        {
            if (formMode == FormMode.Them)
            {
                lbHeaderText.Text = "THÊM THÔNG TIN SẢN PHẨM";
            }
            if (formMode == FormMode.Sua)
            {
                lbHeaderText.Text = "CẬP NHẬT THÔNG TIN SẢN PHẨM";
            }
        }
    }
}
