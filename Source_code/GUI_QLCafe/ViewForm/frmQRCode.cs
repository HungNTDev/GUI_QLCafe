using System;
using System.Windows.Forms;

namespace GUI_QLCafe.ViewForm
{
    public partial class frmQRCode : Form
    {
        private string totalAmount;
        Timer timer;
        int i = 120;

        public frmQRCode(string totalAmount)
        {
            InitializeComponent();
            timer = new Timer();
            timer.Tick += timer_Tick;
            timer.Interval = 1000;
            lbTongTien.Text = "Số tiền cần phải thanh toán: " + totalAmount + " VND";
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (i > 0)
            {
                i--;
                lbThoiGian.Text = "Thời gian thanh toán còn lại: " + i.ToString();
            }
            else
            {
                timer.Stop();
                MessageBox.Show("Hết thời gian thanh toán.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void frmQRCode_Load(object sender, EventArgs e)
        {
            timer.Enabled = !timer.Enabled;
        }

        private void btnThanhToanKhac_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có muốn chọn loại thanh toán khác?", "Thông báo",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dl == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
