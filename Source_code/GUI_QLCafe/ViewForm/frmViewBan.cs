using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLCafe.ViewForm
{
    public partial class frmViewBan : Form
    {
        public frmViewBan()
        {
            InitializeComponent();
        }

        public void HienThi()
        {
            txtMaBan.Enabled = false;
            txtTenBan.Enabled = false;  
        }

        public void SetTableInfo(string maBan, string tenBan)
        {
            txtTenBan.Text = maBan;
            txtMaBan.Text = tenBan; 
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmViewBan_Load(object sender, EventArgs e)
        {
            HienThi();
        }
    }
}
