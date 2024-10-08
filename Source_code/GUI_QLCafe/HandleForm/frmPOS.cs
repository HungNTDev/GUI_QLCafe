﻿using BUS_QLCafe;
using DTO_QLCafe;
using GUI_QLCafe.AddForm;
using Guna.UI2.WinForms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUI_QLCafe
{
    public partial class frmPOS : Form
    {
        BUS_TableCF busTB = new BUS_TableCF();
        BUS_Bill busBill = new BUS_Bill();
        BUS_Staff busStaff = new BUS_Staff();

        DTO_Bill billDTO = new DTO_Bill();

        frmMenu menu = new frmMenu();
        frmPayment pay = new frmPayment();
        frmSubtractAmount subtract = new frmSubtractAmount();
        frmAddDetail detail = new frmAddDetail();

        public static string NameTable;
        public static string idTable;
        public static string dateCheckIn;
        public static string nameProduct;
        public string idProduct;
        public int amount;
        public int amountProduct;


        public frmPOS()
        {
            InitializeComponent();
            LoadTable();
        }

        private void ResetBill()
        {
            lvHoaDon.Items.Clear();
            lbTenBan.Text = "Tên : " + busTB.TableInfo(billDTO).Rows[0][1].ToString();
            idTable = billDTO.IdTable;
            lbThuNgan.Text = "Thu ngân : ";
            lbGioVao.Text = "Giờ vào : ";
            lbThanhTien.Text = "Thành tiền : ";
            //btnThanhToan.Enabled = false;
        }

        private void showBill(string id)
        {
            try
            {
                billDTO.idTable = id;
                if (busBill.BillInfo(billDTO).Rows.Count > 0)
                {
                    lvHoaDon.Items.Clear();
                    lbTenBan.Text = "Tên : " + busTB.TableInfo(billDTO).Rows[0][1].ToString();
                    lbThuNgan.Text = "Thu ngân : " + busStaff.StaffInfo(frmMainQLCF.email).Rows[0][2].ToString();
                    lbGioVao.Text = "Giờ vào : " + busBill.BillInfo(billDTO).Rows[0][4].ToString();
                    dateCheckIn = lbGioVao.Text;
                    float total = 0;
                    for (int i = 0; i < busBill.BillInfo(billDTO).Rows.Count; i++)
                    {
                        ListViewItem item = new ListViewItem(busBill.BillInfo(billDTO).Rows[i][0].ToString());
                        item.SubItems.Add(busBill.BillInfo(billDTO).Rows[i][1].ToString());
                        item.SubItems.Add(busBill.BillInfo(billDTO).Rows[i][2].ToString());
                        item.SubItems.Add(busBill.BillInfo(billDTO).Rows[i][3].ToString() + " VND");
                        item.SubItems.Add(busBill.BillInfo(billDTO).Rows[i][7].ToString());
                        lvHoaDon.Items.Add(item);
                        total = total + (float)Convert.ToDouble(busBill.BillInfo(billDTO).Rows[i][3].ToString());
                    }
                    lbThanhTien.Text = "Thành tiền: " + total + " VND";
                }
                else
                {
                    ResetBill();
                }
                btnXoaMon.Enabled = false;
                btnXoaSoLuong.Enabled = false;
                btnPlus.Enabled = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        private void LoadTable()
        {
            flpTable.Controls.Clear();
            for (int i = 0; i < busTB.TableList().Rows.Count; i++)
            {
                Guna2Button btn = new Guna2Button();
                btn.Margin = new Padding(10);
                btn.Width = 100;
                btn.Height = 90;
                btn.BorderThickness = 2;
                btn.BorderColor = Color.White;
                btn.BorderRadius = 5;
                btn.FillColor = Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
                btn.ForeColor = Color.White;
                btn.Font = new Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btn.HoverState.FillColor = Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(85)))), ((int)(((byte)(126)))));
                btn.HoverState.ForeColor = Color.White;
                btn.HoverState.BorderColor = Color.Transparent;
                flpTable.AutoScroll = true;
                //btn.Text = busTB.TableList().Rows[i][1].ToString() + Environment.NewLine + busTB.TableList().Rows[i][2].ToString();
                btn.Click += btn_Click;
                btn.Tag = busTB.TableList().Rows[i][0].ToString();
                if (busTB.TableList().Rows[i][3].ToString() == "0")
                {
                    btn.Text = busTB.TableList().Rows[i][1].ToString() + Environment.NewLine + "Trống";
                }
                else
                {
                    btn.Text = busTB.TableList().Rows[i][1].ToString() + Environment.NewLine + "Có người";
                    btn.BorderColor = Color.Gray;
                    btn.BackColor = Color.WhiteSmoke;
                    btn.FillColor = Color.LightBlue;
                    btn.ForeColor = Color.Black;
                }
                flpTable.Controls.Add(btn);
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Guna2Button btn = (Guna2Button)sender;
            billDTO.idTable = btn.Tag.ToString();
            idTable = billDTO.idTable;
            NameTable = busTB.TableInfo(billDTO).Rows[0][1].ToString();
            if (Convert.ToInt32(busTB.TableInfo(billDTO).Rows[0][3]) == 0)
            {
                NameTable = busTB.TableInfo(billDTO).Rows[0][1].ToString();
                ResetBill();
                menu.ShowDialog();
                if (Convert.ToInt32(busTB.TableInfo(billDTO).Rows[0][3]) != 0)
                {
                    btnThemMon.Enabled = true;
                    btnThanhToan.Enabled = true;
                }
                LoadTable();
                showBill(idTable);
            }
            else
            {
                btnThanhToan.Enabled = true;
                btnThemMon.Enabled = true;
                showBill(idTable);
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            pay.ShowDialog();
            LoadTable();
            ResetBill();
        }

        private void btnThemMon_Click(object sender, EventArgs e)
        {
            NameTable = busTB.TableInfo(billDTO).Rows[0][1].ToString();
            idTable = busTB.TableInfo(billDTO).Rows[0][0].ToString();
            menu.ShowDialog();
            showBill(idTable);
        }

        private void btnXoaMon_Click(object sender, EventArgs e)
        {
            DialogResult del = MessageBox.Show("Bạn có muốn xóa sản phẩm vừa chọn?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (del == DialogResult.Yes)
            {
                lvHoaDon.Items.Remove(lvHoaDon.SelectedItems[0]);
                billDTO.idProduct = idProduct;
                billDTO.idTable = idTable;
                //busBill.DelProductFromBill(billDTO);
                lvHoaDon.Update();
                showBill(idTable);
            }
        }

        private void lvHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvHoaDon.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvHoaDon.SelectedItems[0];

                if (selectedItem.SubItems.Count > 4)
                {
                    idProduct = selectedItem.SubItems[4].Text;
                    nameProduct = selectedItem.SubItems[0].Text;
                    amountProduct = Convert.ToInt32(selectedItem.SubItems[1].Text);
                }

                if (selectedItem.SubItems.Count > 0)
                {
                    nameProduct = selectedItem.SubItems[0].Text;
                }

                if (Convert.ToInt32(selectedItem.SubItems[1].Text) == 1)
                {
                    btnXoaSoLuong.Enabled = false;
                    btnXoaMon.Enabled = true;
                    btnPlus.Enabled = true;
                }
                else
                {
                    btnXoaMon.Enabled = true;
                    btnXoaSoLuong.Enabled = true;
                    btnPlus.Enabled = true;
                }
            }
        }

        private void btnXoaSoLuong_Click(object sender, EventArgs e)
        {
            subtract.ShowDialog();
            //if (frmSubtractAmount.MinusStatus == 1)
            //{
            //    amount = frmSubtractAmount.Amount;
            //    billDTO.idProduct = idProduct;
            //    billDTO.idTable = idTable;
            //    busBill.UpdateProductInBill(billDTO, amount);
            //}
            if (amountProduct > frmSubtractAmount.Amount)
            {
                if (frmSubtractAmount.MinusStatus == 1)
                {
                    amount = frmSubtractAmount.Amount;
                    billDTO.idProduct = idProduct;
                    billDTO.idTable = idTable;
                    busBill.UpdateProductInBill(billDTO, amount);
                }
            }
            else
            {
                MessageBox.Show("Số lượng giảm lớn hơn hoặc bằng số lượng hóa đơn đang có!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            lvHoaDon.Update();
            showBill(idTable);
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            detail.ShowDialog();
            if (frmAddDetail.Status == 1)
            {
                amount = frmAddDetail.Amount;
                billDTO.idProduct = idProduct;
                billDTO.idTable = idTable;
                busBill.AddProductInBill(billDTO, amount);
            }
            lvHoaDon.Update();
            showBill(idTable);
        }

        private void frmPOS_Load(object sender, EventArgs e)
        {
            btnXoaMon.Enabled = false;
            btnXoaSoLuong.Enabled = false;
            btnThanhToan.Enabled = false;
            btnThemMon.Enabled = false;
            btnPlus.Enabled = false;
        }





    }
}