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
    public partial class frmQLNhanVien : Form
    {
        public frmQLNhanVien()
        {
            InitializeComponent();
        }

        public void Nofication(string msg)
        {
            frmNotification notification = new frmNotification();
            //frmNotification.showNotfication(msg);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmAddNhanVien frmAddNhanVien = new frmAddNhanVien();
            frmAddNhanVien.ShowDialog();
        }

        private void dgvDanhSachNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvDanhSachNhanVien.CurrentCell.OwningColumn.Name == "dgvEdit")
            {
                frmAddNhanVien frmAddNhanVien = new frmAddNhanVien();
                frmAddNhanVien.ShowDialog();

                this.Nofication("Save successfully!");
            }
            if(dgvDanhSachNhanVien.CurrentCell.OwningColumn.Name == "dgvDel")
            {
                this.Nofication("Delete successfully!");
            }
        }
    }
}
