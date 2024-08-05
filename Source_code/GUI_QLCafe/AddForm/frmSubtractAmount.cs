using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLCafe.AddForm
{
    public partial class frmSubtractAmount : Form
    {
        public static int MinusStatus = 0;
        public static int Amount;

        public frmSubtractAmount()
        {
            InitializeComponent();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            Amount = Convert.ToInt32(nudAmount.Value.ToString());
            if(Amount < 1)
            {
                MessageBox.Show("Số lượng không hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }else
            {
                MinusStatus = 1;
            }
            this.Close();
        }

        private void frmSubtractAmount_Load(object sender, EventArgs e)
        {
            txtName.Text = frmPOS.nameProduct;
            txtName.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(exit == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
