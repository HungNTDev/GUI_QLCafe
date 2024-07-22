using System;
using System.Windows.Forms;

namespace GUI_QLCafe
{
    public partial class frmQLBan : Form
    {
        public frmQLBan()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddBan frmAddBan = new frmAddBan();
            frmAddBan.ShowDialog();
        }

        private void dgvDanhSachNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmQLBan_Load(object sender, EventArgs e)
        {

        }
    }
}
