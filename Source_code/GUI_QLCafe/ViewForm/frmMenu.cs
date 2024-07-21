using BUS_QLCafe;
using DTO_QLCafe;
using Guna.UI2.WinForms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUI_QLCafe
{
    public partial class frmMenu : Form
    {
        DTO_Bill billDTO = new DTO_Bill();
        DTO_Product productDTO = new DTO_Product();
        BUS_Product productBUS = new BUS_Product();

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
                //btn.Click += btn_Click;
                btn.BorderThickness = 1;
                btn.BorderRadius = 2;
                btn.Text = productBUS.LoadMenu(productDTO).Rows[i][1].ToString() + Environment.NewLine + productBUS.LoadMenu(productDTO).Rows[i][2].ToString() + " VND";
                btn.Font = new Font(btn.Font.FontFamily, 15);
                btn.Image = Image.FromFile(saveDirectory + productBUS.LoadMenu(productDTO).Rows[i][3].ToString());
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

        private void btnDel_Click(object sender, EventArgs e)
        {

        }

        private void paneText_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tp_NuocEp_Click(object sender, EventArgs e)
        {

        }


    }
}
