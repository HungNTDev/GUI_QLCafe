using BUS_QLCafe;
using System;
using System.Windows.Forms;
using ZXing.Common;
using ZXing.QrCode.Internal;
using ZXing.Rendering;
using ZXing;
using System.Drawing.Drawing2D;
using System.Drawing;
using DTO_QLCafe;

namespace GUI_QLCafe.ViewForm
{
    public partial class frmQRCode : Form
    {
        BUS_Bill busBill = new BUS_Bill();
        DTO_Bill billDTO;
        private string totalAmount;
        Timer timer;
        int i = 120;

        public frmQRCode(string totalAmount, DTO_Bill billDTO)
        {
            InitializeComponent();
            this.totalAmount = totalAmount; 
            this.billDTO = billDTO;
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
            HienThiMaQR();
        }

        private void btnThanhToanKhac_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có muốn chọn loại thanh toán khác?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dl == DialogResult.OK)
            {
                this.Close();
            }
        }

        public Image resizeImage(Image image, int new_height, int new_width)
        {
            Bitmap new_image = new Bitmap(new_width, new_height);
            Graphics g = Graphics.FromImage((Image)new_image);
            g.InterpolationMode = InterpolationMode.High;
            g.DrawImage(image, 0, 0, new_width, new_height);
            return new_image;
        }

        private void HienThiMaQR()
        {
            string ten = "Lý Bảo Hoàng";
            string so = "0836753008";
            string thanhTien = busBill.BillInfo(billDTO).Rows[0][3].ToString();
            string qrText = $"2|99|{so.Trim()}|{ten.Trim()}|0|0|{thanhTien}";
            BarcodeWriter writer = new BarcodeWriter();
            EncodingOptions encodingOptions = new EncodingOptions()
            {
                Width = 250,
                Height = 250,
                Margin = 1,
                PureBarcode = false
            };
            encodingOptions.Hints.Add(EncodeHintType.ERROR_CORRECTION, ErrorCorrectionLevel.H);
            writer.Renderer = new BitmapRenderer();
            writer.Options = encodingOptions;
            writer.Format = BarcodeFormat.QR_CODE;
            Bitmap bitmap = writer.Write(qrText);
            Bitmap logo = resizeImage(Properties.Resources.logo_momo, 20, 20) as Bitmap;
            Graphics g = Graphics.FromImage(bitmap);
            g.DrawImage(logo, new Point((bitmap.Width - logo.Width) / 2, (bitmap.Height - logo.Height) / 2));
            picMoMo.Image = bitmap;
        }
    }
}
