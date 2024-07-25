﻿using BUS_QLCafe;
using DTO_QLCafe;
using Guna.UI2.WinForms;
using System;
using System.Drawing;
using System.Windows.Forms;
using ZedGraph;

namespace GUI_QLCafe
{
    public partial class frmPOS : Form
    {
        BUS_TableCF busTB = new BUS_TableCF();
        BUS_Bill busBill = new BUS_Bill();
        BUS_Staff busStaff = new BUS_Staff();

        DTO_Bill billDTO = new DTO_Bill();
        frmMenu menu = new frmMenu();

        public static string NameTable;
        public static string idTable;


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
                    lbThuNgan.Text = "Thu ngân : " + busStaff.get(1).Rows[0][2].ToString();
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
                    lbThanhTien.Text = "Thành tiền: " + total + " VND";
                }
                else
                {
                    ResetBill();
                }
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
                if (busTB.TableList().Rows[i][2].ToString() == "0")
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
            if (Convert.ToInt32(busTB.TableInfo(billDTO).Rows[0][2]) == 0)
            {
                NameTable = busTB.TableInfo(billDTO).Rows[0][1].ToString();
                ResetBill();
                menu.ShowDialog();
                if (Convert.ToInt32(busTB.TableInfo(billDTO).Rows[0][2]) != 0)
                {
                    btnThemMon.Enabled = true;
                }
                LoadTable();
                showBill(idTable);
            }
            else
            {
                btnThemMon.Enabled = true;
                showBill(idTable);
            }

        }

        private void flpTable_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}