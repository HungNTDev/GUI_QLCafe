using BUS_QLCafe;
using DTO_QLCafe;
using System;
using System.Windows.Forms;

namespace GUI_QLCafe
{
    public partial class frmAddBan : Form
    {

        BUS_TableCF table = new BUS_TableCF();


        public frmAddBan()
        {
            InitializeComponent();
        }

        private void frmAddBan_Load(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            if (dl == DialogResult.OK)
            {
                this.Close();
            }
        }
        public string id = "";
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaBan.Text))
            {
                MessageBox.Show("Vui lòng nhập mã bàn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txtTenBan.Text))
            {
                MessageBox.Show("Vui lòng nhập tên bàn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DTO_TableCF tl = new DTO_TableCF
                (
                       txtMaBan.Text,
                       txtTenBan.Text
                );

                if (string.IsNullOrEmpty(id))
                {
                    DialogResult dl = MessageBox.Show("Bạn có muốn lưu không?", "Thông báo",
                   MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (dl == DialogResult.OK)
                    {
                        if (table.insert(tl))
                        {
                            MessageBox.Show("Thêm bàn thành công", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Thêm bàn thất bại", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    tl.IdTable = id;
                    if (table.update(tl))
                    {
                        MessageBox.Show("Cap nhap thanh cong", "Thong bao",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Cap nhap that bai", "Thong bao",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message);
            }
        }

        private void gbTrangThai_Click(object sender, EventArgs e)
        {

        }

        private void rdoHoatDong_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
