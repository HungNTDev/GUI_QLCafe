﻿using BUS_QLCafe;
using DTO_QLCafe;
using GUI_QLCafe.ViewForm;
using System;
using System.Windows.Forms;

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

        public frmPayment()
        {
            InitializeComponent();
            btnTaoMa.Click += btnTaoMa_Click;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn chắc chắn muốn quay lại?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
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
                    float TotalSale = total - (total * voucher.PercentVoucher / 100);
                    lbTongHoaDon.Text = "Tổng hóa đơn: " +  total + " VND";
                    lbTongTien.Text = "Thành tiền: " + TotalSale + " VND";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult = MessageBox.Show("Bạn có muốn thanh toán??", "Thanh toán", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult == DialogResult.Yes)
                {
                    billDTO.IdTable = frmPOS.idTable;
                    billDTO.DateCheckOut = DateTime.Parse(DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToLongTimeString());
                    billDTO.IdPayment = cbPhuongThucTT.SelectedValue.ToString();
                    billDTO.IdVoucher = cbVoucher.SelectedText.ToString();
                    payment.Payment(billDTO);
                    MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void lbText_Click(object sender, EventArgs e)
        {

        }

        private void lbTongHoaDon_Click(object sender, EventArgs e)
        {

        }

        private void btnTaoMa_Click(object sender, EventArgs e)
        {
            try
            {
                string totalAmount = lbTongTien.Text.Replace("Thành tiền: ", "").Replace(" VND", "");
                frmQRCode qrCode = new frmQRCode(totalAmount);
                qrCode.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
