﻿using BUS_QLCafe;
using DTO_QLCafe;
using Guna.UI2.WinForms;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GUI_QLCafe
{
    public partial class frmMenu : Form
    {
        DTO_Bill billDTO = new DTO_Bill();
        DTO_Product productDTO = new DTO_Product();
        DTO_DetailBill detailBillDTO = new DTO_DetailBill();

        BUS_Product productBUS = new BUS_Product();
        BUS_TableCF busTB = new BUS_TableCF();
        BUS_Staff busStaff = new BUS_Staff();
        BUS_Bill busBill = new BUS_Bill();
        BUS_DetailBill busDetailBill = new BUS_DetailBill();

        public string categoryID = "";
        public static string nameProduct;

        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            lbNameTable.Text = "Tên bàn: " + frmPOS.NameTable;
            billDTO.idTable = frmPOS.idTable;
            LoadMenu("CFE");
            ListOrder();
        }

        void ListOrder()
        {
            ListOrder_dgv.Rows.Clear();
            ListOrder_dgv.Columns.Clear();
            ListOrder_dgv.Columns.Add("Name", "Tên món");
            ListOrder_dgv.Columns.Add("Amount", "Số lượng");
            ListOrder_dgv.Columns.Add("Price", "Giá");
            ListOrder_dgv.Columns.Add("IdProduct", "Id Product");
            ListOrder_dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ListOrder_dgv.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ListOrder_dgv.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ListOrder_dgv.Columns[3].Visible = false;
        }

        private void LoadMenu(string categoryID)
        {
            string saveDirectory = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));

            flp_CaPhe.Controls.Clear();
            flp_NuocEp.Controls.Clear();
            flp_SinhTo.Controls.Clear();
            flp_Tra.Controls.Clear();
            productDTO.idPT = categoryID;
            for (int i = 0; i < productBUS.LoadMenu(productDTO).Rows.Count; i++)
            {
                Guna2Button btn = new Guna2Button();
                //Button btn = new Button();
                btn.Width = 280;
                btn.Height = 100;
                btn.FillColor = Color.White;
                btn.ForeColor = Color.Black;
                btn.Click += btn_Click;
                btn.BorderThickness = 1;
                btn.BorderRadius = 2;
                btn.Text = productBUS.LoadMenu(productDTO).Rows[i][1].ToString() + Environment.NewLine +
                    productBUS.LoadMenu(productDTO).Rows[i][2].ToString() + " VND";
                btn.Font = new Font(btn.Font.FontFamily, 15);

                try
                {

                    string filename = productBUS.LoadMenu(productDTO).Rows[i][3].ToString();

                    string imagepath = Path.Combine(saveDirectory, filename);

                    Console.WriteLine(imagepath);


                    btn.Image = Image.FromFile(imagepath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi " + ex.Message);
                }

                btn.ImageSize = new Size(75, 75);
                btn.ImageAlign = HorizontalAlignment.Left;
                btn.TextAlign = HorizontalAlignment.Right;
                btn.Tag = productBUS.LoadMenu(productDTO).Rows[i][0].ToString();

                if (categoryID == "CFE")
                {
                    flp_CaPhe.Controls.Add(btn);
                }
                else if (categoryID == "JUC")
                {
                    flp_NuocEp.Controls.Add(btn);
                }
                else if (categoryID == "STO")
                {
                    flp_SinhTo.Controls.Add(btn);
                }
                else if (categoryID == "TEA")
                {
                    flp_Tra.Controls.Add(btn);
                }
            }
        }
        private void tc_Menu_Click(object sender, EventArgs e)
        {
            categoryID = tc_Menu.SelectedTab.Name.ToString();
            LoadMenu(categoryID);
        }

        private void btn_Click(object sender, EventArgs e)
        {
            frmAddDetail detail = new frmAddDetail();
            Guna2Button btn = (Guna2Button)sender;
            productDTO.IdProduct = btn.Tag.ToString();
            nameProduct = productBUS.TagProduct(productDTO).Rows[0][0].ToString();
            detail.ShowDialog();
            if (frmAddDetail.Status == 1)
            {
                for (int i = 0; i < ListOrder_dgv.Rows.Count; i++)
                {
                    if (ListOrder_dgv.Rows[i].Cells[0].Value == null)
                    {
                        frmAddDetail.Status = 1;
                    }
                    else if (nameProduct == ListOrder_dgv.Rows[i].Cells[0].Value.ToString())
                    {
                        ListOrder_dgv.Rows[i].Cells[1].Value = Convert.ToInt32(ListOrder_dgv.Rows[i].Cells[1].Value.ToString()) + frmAddDetail.Amount;
                        ListOrder_dgv.Rows[i].Cells[2].Value = (float)Convert.ToDouble(productBUS.TagProduct(productDTO).Rows[0][1].ToString()) * Convert.ToInt32(ListOrder_dgv.Rows[i].Cells[1].Value);
                        ListOrder_dgv.Update();
                        frmAddDetail.Status = 0;
                        break;
                    }
                }
                if (frmAddDetail.Status == 1)
                {
                    DataGridViewRow row = (DataGridViewRow)ListOrder_dgv.Rows[0].Clone();
                    row.Cells[0].Value = productBUS.TagProduct(productDTO).Rows[0][0].ToString();
                    row.Cells[1].Value = frmAddDetail.Amount;
                    row.Cells[2].Value = (float)Convert.ToDouble(productBUS.TagProduct(productDTO).Rows[0][1].ToString()) * frmAddDetail.Amount;
                    row.Cells[3].Value = productDTO.idProduct;
                    ListOrder_dgv.Rows.Add(row);
                    frmAddDetail.Status = 0;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(busTB.TableInfo(billDTO).Rows[0][2].ToString()) == 0)
                {
                    billDTO.IdTable = busTB.TableInfo(billDTO).Rows[0][0].ToString();
                    billDTO.IdStaff = busStaff.get(1).Rows[0][0].ToString();
                    busBill.AddingBill(billDTO);
                    for (int i = 0; i < ListOrder_dgv.Rows.Count - 1; i++)
                    {
                        detailBillDTO.idBill = frmPOS.idTable;
                        detailBillDTO.Amount = Convert.ToInt32(ListOrder_dgv.Rows[i].Cells[1].Value.ToString());
                        detailBillDTO.Price = (float)Convert.ToDouble(ListOrder_dgv.Rows[i].Cells[2].Value.ToString()) / detailBillDTO.Amount;
                        detailBillDTO.IdProduct = ListOrder_dgv.Rows[i].Cells[3].Value.ToString();
                        detailBillDTO.TotalPrice = detailBillDTO.Price * detailBillDTO.Amount;
                        busDetailBill.AddingDetailBill(detailBillDTO);
                        //Count += bill.Amount;
                    }
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else if (ListOrder_dgv.Rows.Count == 1)
                {
                    MessageBox.Show("Bạn chưa chọn món", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //else
                //{
                //    for (int i = 0; i < ListOrder_dgv.Rows.Count - 1; i++)
                //    {

                //    }
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (ListOrder_dgv.SelectedRows.Count > 0)
                {
                    ListOrder_dgv.Rows.RemoveAt(ListOrder_dgv.SelectedRows[0].Index);
                }
            }
            catch
            { }
        }

        private void paneText_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tp_NuocEp_Click(object sender, EventArgs e)
        {

        }




    }
}