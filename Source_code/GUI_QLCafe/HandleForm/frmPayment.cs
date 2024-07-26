using BUS_QLCafe;
using System;
using System.Windows.Forms;

namespace GUI_QLCafe
{
    public partial class frmPayment : Form
    {
        BUS_Bill bill = new BUS_Bill();
        public frmPayment()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn chắc chắn muốn quay lại?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dl == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void ShowVoucher()
        {
            try
            {
                cbVoucher.DataSource = bill.ShowVoucher();
                cbVoucher.DisplayMember = "NameVoucher";
                cbVoucher.ValueMember = "PercentVoucher";
            }
            catch (Exception) { }
        }

        private void ShowPayment()
        {
            try
            {
                cbPhuongThucTT.DataSource = bill.ShowPayment();
                cbPhuongThucTT.DisplayMember = "TypePayment";
                cbPhuongThucTT.ValueMember = "IdPayment";
            }
            catch (Exception) { }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {

        }

        private void lvHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmPayment_Load(object sender, EventArgs e)
        {
            ShowPayment();
            ShowVoucher();
        }
    }
}
