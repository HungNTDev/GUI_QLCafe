using BUS_QLCafe;
using Guna.UI2.WinForms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUI_QLCafe
{
    public partial class frmHoaDon : Form
    {
        BUS_TableCF busTB = new BUS_TableCF();

        public frmHoaDon()
        {
            InitializeComponent();
            LoadTable();
        }

        private void LoadTable()
        {
            //flpTable.Controls.Clear();
            for (int i = 0; i < busTB.TableList().Rows.Count; i++)
            {
                Guna2Button btn = new Guna2Button();
                btn.Width = 100;
                btn.Height = 90;
                btn.BorderThickness = 1;
                btn.BorderRadius = 2;
                btn.FillColor = Color.White;
                btn.ForeColor = Color.Black;
                //btn.Text = busTB.TableList().Rows[i][1].ToString() + Environment.NewLine + busTB.TableList().Rows[i][2].ToString();
                //btn.Click += btn_Click;
                btn.Tag = busTB.TableList().Rows[i][0].ToString();
                if (busTB.TableList().Rows[i][2].ToString() == "0")
                {
                    btn.Text = busTB.TableList().Rows[i][1].ToString() + Environment.NewLine + "Trống";
                    btn.BackColor = Color.White;
                }
                else
                {
                    btn.BackColor = Color.AntiqueWhite;
                }
                //flpTable.Controls.Add(btn);
            }
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {

        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {

        }

        private void btnThemMon_Click(object sender, EventArgs e)
        {

        }

        private void btnBan_Click(object sender, EventArgs e)
        {

        }
    }
}
