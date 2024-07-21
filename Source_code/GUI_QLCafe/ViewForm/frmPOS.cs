using BUS_QLCafe;
using DTO_QLCafe;
using Guna.UI2.WinForms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUI_QLCafe
{
    public partial class frmPOS : Form
    {
        BUS_TableCF busTB = new BUS_TableCF();
        DTO_Bill billDTO = new DTO_Bill();
        frmMenu menu = new frmMenu();

        public static string NameTable;
        public static string idTable;


        public frmPOS()
        {
            InitializeComponent();
            LoadTable();
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
                    btn.BorderColor = Color.Gray;
                    btn.BackColor = Color.WhiteSmoke;
                    btn.ForeColor = Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
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
            menu.ShowDialog();
        }

        private void flpTable_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
