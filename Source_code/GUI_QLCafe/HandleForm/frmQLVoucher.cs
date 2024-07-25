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
    public partial class frmQLVoucher : Form
    {
        public frmQLVoucher()
        {
            InitializeComponent();
        }

        private void frmQLVoucher_Load(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmAddVoucher frmAddVoucher = new frmAddVoucher();
            frmAddVoucher.ShowDialog();
        }
    }
}
