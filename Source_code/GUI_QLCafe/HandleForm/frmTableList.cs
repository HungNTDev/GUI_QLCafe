using BUS_QLCafe;
using DTO_QLCafe;
using GUI_QLCafe.AddForm;
using Guna.UI2.WinForms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUI_QLCafe
{
    public partial class frmTableList : Form
    {
        BUS_TableCF busTB = new BUS_TableCF();
        BUS_Bill busBill = new BUS_Bill();
        BUS_Staff busStaff = new BUS_Staff();

        DTO_Bill billDTO = new DTO_Bill();

        frmMenu menu = new frmMenu();
        frmPayment pay = new frmPayment();
        frmSubtractAmount subtract = new frmSubtractAmount();

        public static string IdTable;

        public frmTableList()
        {
            InitializeComponent();
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

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTableList_Load(object sender, EventArgs e)
        {
            LoadTable();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            try
            {
                Guna2Button btn = (Guna2Button)sender;
                billDTO.idTable = btn.Tag.ToString();
                if (Convert.ToInt32(busTB.TableInfo(billDTO).Rows[0][3].ToString()) == 0)
                {
                    DialogResult pick = MessageBox.Show("Bạn muốn chọn bàn này?", "Chọn bàn", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (pick == DialogResult.Yes)
                    {
                        IdTable = btn.Tag.ToString();
                        IdTable = billDTO.idTable;
                        //getInfoBill();
                        //busBill.AddingBill(billDTO);
                        //busBill.AddingDetailBill(billDTO);
                        MessageBox.Show("Chọn món và Đặt bàn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Đặt bàn không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Bàn đã có người, vui lòng chọn bàn khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }


            }
            catch
            {

            }
        }
    }
}
