using BUS_QLCafe;
using DTO_QLCafe;
using System;
using System.Windows.Forms;

namespace GUI_QLCafe
{
    public partial class frmAddVoucher : Form
    {

        BUS_Voucher bus = new BUS_Voucher();
        public FormMode formMode { get; set; }

        public enum FormMode { Them, Sua }

        public string id = "";

        public frmAddVoucher()
        {
            InitializeComponent();
        }
        // phương thức này dùng để gọi Notfication khi thêm thành công
        public void Nofication(string msg, frmNotification.enumType type)
        {
            frmNotification notification = new frmNotification();
            frmNotification.showNotfication(msg, type);
        }
        // phương thức này dùng để gọi Notfication khi thêm thành công
        public void Message(string msg, frmNotification.enumType type)
        {
            frmNotification notification = new frmNotification();
            frmNotification.showNotfication(msg, type);
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            int phantram;
            bool isInt = int.TryParse(txtPhanTramKM.Text.Trim(), out phantram);

            // Kiểm tra các điều kiện
            if (string.IsNullOrWhiteSpace(txtMaKhuyenMai.Text))
            {
                MessageBox.Show("Vui lòng nhập mã khuyến mãi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaKhuyenMai.Focus();
                return;
            }
            else if (!isInt || phantram < 0 || string.IsNullOrWhiteSpace(txtPhanTramKM.Text))
            {
                MessageBox.Show("Vui lòng nhập phần trăm giảm hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhanTramKM.Focus();
                return;
            }
            else if (string.IsNullOrWhiteSpace(txtTenKhuyenMai.Text))
            {
                MessageBox.Show("Vui lòng nhập tên mã khuyến mãi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenKhuyenMai.Focus();
                return;
            }
            else if (cbTrangThai.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn trạng thái!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (txtMaKhuyenMai.Text != id && bus.KiemTraVoucher(txtMaKhuyenMai.Text))
            {
                MessageBox.Show("Mã khuyến mãi đã tồn tại trong hệ thống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaKhuyenMai.Focus();
                return;
            }
            else
            {
                int status = 0;

                if (cbTrangThai.SelectedIndex == 0)
                {
                    status = 1;
                }
                DTO_Voucher dto = new DTO_Voucher(txtMaKhuyenMai.Text, txtTenKhuyenMai.Text, int.Parse(txtPhanTramKM.Text), status);
                if (MessageBox.Show("Bạn chắc chắn lưu?", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (formMode == FormMode.Them)
                    {
                        if (bus.insert(dto))
                        {
                            MessageBox.Show("Thêm mã khuyến mãi thành công!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            this.Message("Thêm thất bại!", frmNotification.enumType.Failed);
                        }
                    }
                    else
                    {
                        dto.IdVoucher = id;
                        if (bus.update(dto))
                        {
                            MessageBox.Show("Cập nhật thành công!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            this.Message("Cập nhật thất bại!", frmNotification.enumType.Failed);
                        }
                    }
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddVoucher_Load(object sender, EventArgs e)
        {
            if (formMode == FormMode.Them)
            {
                lbHeaderText.Text = "THÊM KHUYẾN MÃI";
            }
            if (formMode == FormMode.Sua)
            {
                lbHeaderText.Text = "CẬP NHẬT THÔNG TIN KHUYẾN MÃI";
            }
        }
    }
}
