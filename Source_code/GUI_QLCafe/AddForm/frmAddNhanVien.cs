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
    public partial class frmAddNhanVien : Form
    {
        public frmAddNhanVien()
        {
            InitializeComponent();
        }

        public void Nofication(string msg, frmNotification.enumType type)
        {
            frmNotification notification = new frmNotification();   
            frmNotification.showNotfication(msg, type);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            this.Nofication("Save Successfull", frmNotification.enumType.Success);
        }
    }
}
