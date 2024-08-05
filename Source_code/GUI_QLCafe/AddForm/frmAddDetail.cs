using System;
using System.Windows.Forms;

namespace GUI_QLCafe
{
    public partial class frmAddDetail : Form
    {
        public frmAddDetail()
        {
            InitializeComponent();
        }

        public static int Status;
        public static int Amount;

        private void frmDetail_Load(object sender, EventArgs e)
        {
            if(frmMenuProduct.addStatus ==1 )
            {
                txtName.Text = frmMenuProduct.nameProduct;
            }else
            {
                txtName.Text = frmMenu.nameProduct;
            }
            txtName.Enabled = false;
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            Amount = Convert.ToInt32(nudAmount.Value.ToString());
            if (Amount < 1)
            {
                MessageBox.Show("Số lượng không hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Status = 1;
                this.Close();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lbName_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void nudAmount_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lbText0_Click(object sender, EventArgs e)
        {

        }
    }
}
