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

        public void Nofication(string msg)
        {
            frmNotification notification = new frmNotification();
            frmNotification.showNotfication(msg);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            this.Nofication("Save successfully!");

        }
    }
}
