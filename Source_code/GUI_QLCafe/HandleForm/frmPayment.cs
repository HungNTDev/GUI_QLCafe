using BUS_QLCafe;
using DTO_QLCafe;
using GUI_QLCafe.ViewForm;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using ZedGraph;
using ZXing;
using ZXing.Common;
using ZXing.QrCode.Internal;
using ZXing.Rendering;
namespace GUI_QLCafe
{
    public partial class frmPayment : Form
    {
        BUS_Payment payment = new BUS_Payment();
        BUS_Bill busBill = new BUS_Bill();
        BUS_TableCF busTB = new BUS_TableCF();
        BUS_Staff busStaff = new BUS_Staff();

        DTO_Voucher voucher = new DTO_Voucher();
        DTO_Bill billDTO = new DTO_Bill();

        public float TotalBill;
        public frmPayment()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn chắc chắn muốn quay lại?",
                "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dl == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void frmPayment_Load(object sender, EventArgs e)
        {
            lbGioRa.Text = "Giờ ra: " + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToLongTimeString();
            lbGioVao.Text = frmPOS.dateCheckIn.ToString();
            string idTable = frmPOS.idTable;
            showBill(idTable);
            ListVoucher();
            ListPayment();
        }

        private void ListPayment()
        {
            try
            {
                cbPhuongThucTT.DataSource = payment.ListPayment();
                cbPhuongThucTT.DisplayMember = "TypePayment";
                cbPhuongThucTT.ValueMember = "IdPayment";
            }
            catch { }
        }

        private void ListVoucher()
        {
            try
            {
                cbVoucher.DataSource = payment.ListVoucher();
                cbVoucher.DisplayMember = "IdVoucher";
                cbVoucher.ValueMember = "PercentVoucher";
            }
            catch { }
        }

        private void showBill(string idTable)
        {
            try
            {
                billDTO.idTable = idTable;
                if (busBill.BillInfo(billDTO).Rows.Count > 0)
                {
                    lvHoaDon.Items.Clear();
                    lbTen.Text = "Tên : " + busTB.TableInfo(billDTO).Rows[0][1].ToString();
                    lbThuNgan.Text = "Thu ngân : " + busStaff.StaffInfo(frmMainQLCF.email).Rows[0][2].ToString();
                    lbGioVao.Text = "Giờ vào : " + busBill.BillInfo(billDTO).Rows[0][4].ToString();
                    //dateCheckIn = lbGioVao.Text;
                    float total = 0;
                    for (int i = 0; i < busBill.BillInfo(billDTO).Rows.Count; i++)
                    {
                        ListViewItem item = new ListViewItem(busBill.BillInfo(billDTO).Rows[i][0].ToString());
                        item.SubItems.Add(busBill.BillInfo(billDTO).Rows[i][1].ToString());
                        item.SubItems.Add(busBill.BillInfo(billDTO).Rows[i][2].ToString());
                        item.SubItems.Add(busBill.BillInfo(billDTO).Rows[i][3].ToString() + " VND");
                        lvHoaDon.Items.Add(item);
                        total = total + (float)Convert.ToDouble(busBill.BillInfo(billDTO).Rows[i][3].ToString());
                    }
                    TotalBill = total - (total * voucher.PercentVoucher / 100);
                    lbTongHoaDon.Text = "Tổng hóa đơn: "  + total + " VND";
                    lbTongTien.Text = "Thành tiền: " + TotalBill + " VND";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        void getStatistic()
        {
            try
            {
                billDTO.IdTable = frmPOS.idTable;
                billDTO.IdBill = Convert.ToInt32(busBill.BillInfo(billDTO).Rows[0][5].ToString());
                billDTO.TotalPrice = TotalBill;
                billDTO.NameStaff = busStaff.StaffInfo(frmMainQLCF.email).Rows[0][2].ToString().Trim();
                string CheckOut = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                billDTO.DateCheckOut = DateTime.ParseExact(CheckOut, "dd/MM/yyyy HH:mm:ss", null);
                string CheckIn = DateTime.Parse(busBill.BillInfo(billDTO).Rows[0][4].ToString()).ToString("dd/MM/yyyy HH:mm:ss");
                billDTO.DateCheckIn = DateTime.ParseExact(CheckIn, "dd/MM/yyyy HH:mm:ss", null);
                billDTO.NamePayment = cbPhuongThucTT.Text.Trim();
                billDTO.NameTable = busTB.TableInfo(billDTO).Rows[0][1].ToString();
                billDTO.IdVoucher = cbVoucher.SelectedText.ToString();
                billDTO.IdPayment = cbPhuongThucTT.SelectedValue.ToString();
            }
            catch (Exception) { }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult = MessageBox.Show("Bạn có muốn thanh toán??", "Thanh toán",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult == DialogResult.Yes)
                {
                    getStatistic();
                    busBill.AddStatistic(billDTO, voucher);

                    for (int i = 0; i < busBill.BillInfo(billDTO).Rows.Count; i++)
                    {
                        billDTO.NameProduct = busBill.BillInfo(billDTO).Rows[i][0].ToString();
                        billDTO.Amount = Convert.ToInt32(busBill.BillInfo(billDTO).Rows[i][1].ToString());
                        billDTO.Price = (float)Convert.ToDouble(busBill.BillInfo(billDTO).Rows[i][2].ToString());
                        billDTO.totalPrice = (float)Convert.ToDouble(busBill.BillInfo(billDTO).Rows[i][3].ToString());
                        busBill.AddDetailStatistic(billDTO);
                    }

                    payment.Payment(billDTO);

                    string chonPhuongThucTT = cbPhuongThucTT.Text;

                    if (chonPhuongThucTT.Contains("MOMO"))
                    {
                        MessageBox.Show("Thanh toán MoMo thành công!", "Thông báo",
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thanh toán tiền mặt thành công!", "Thông báo",
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    }

                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbVoucher_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (cbVoucher.SelectedText == "#NULL")
                {
                    lbVoucher.Text = "(0%)";
                }
                else if (cbVoucher.SelectedText == "SALE7.5%")
                {
                    lbVoucher.Text = "(7.5%)";
                }
                else if (cbVoucher.SelectedText == "SALE10%")
                {
                    lbVoucher.Text = "(10%)";
                }

                voucher.PercentVoucher = (int)Convert.ToDouble(cbVoucher.SelectedValue.ToString());
                string idTable = frmPOS.idTable;
                showBill(idTable);
            }
            catch (Exception) { }
        }


        public Image resizeImage(Image image, int new_height, int new_width)
        {
            Bitmap new_image = new Bitmap(new_width, new_height);
            Graphics g = Graphics.FromImage((Image)new_image);
            g.InterpolationMode = InterpolationMode.High;
            g.DrawImage(image, 0, 0, new_width, new_height);
            return new_image;
        }

        private void cbPhuongThucTT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPhuongThucTT.Text == "MOMO")
            {
                btnTaoQR.Visible = true;
                picMoMo.Visible = true;
            }
            else if (cbPhuongThucTT.Text == "Tiền Mặt")
            {
                btnTaoQR.Visible = false;
                picMoMo.Visible = false;
            }
        }

        private void btnTaoQR_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    string totalAmount = lbTongTien.Text.Replace("Thành tiền: ", "").Replace(" VND", "");
            //    frmQRCode qrCode = new frmQRCode(totalAmount, billDTO);
            //    qrCode.Show();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

            string ten = "Lý Bảo Hoàng";
            string so = "0836753008";

            var qrcode_text = $"2|99|{so.Trim()}|{ten.Trim()}|0|0|{busBill.BillInfo(billDTO).Rows[0][3].ToString()}";
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
            Bitmap bitmap = writer.Write(qrcode_text);
            Bitmap logo = resizeImage(Properties.Resources.logo_momo, 20, 20) as Bitmap;
            Graphics g = Graphics.FromImage(bitmap);
            g.DrawImage(logo, new Point((bitmap.Width - logo.Width) / 2, (bitmap.Height - logo.Height) / 2));
            picMoMo.Image = bitmap;
        }

        private void cbPhuongThucTT_SelectedValueChanged(object sender, EventArgs e)
        {

        }
    }
}
