﻿using BUS_QLCafe;
using DTO_QLCafe;
using System;
using System.Data;
using System.Windows.Forms;
namespace GUI_QLCafe
{
    public partial class frmAddBan : Form
    {
        BUS_TableCF table = new BUS_TableCF();

        public FormMode formMode { get; set; }

        public enum FormMode { Them, Sua }

        public string currentTenBan;
        public frmAddBan()
        {
            InitializeComponent();
        }

        private void frmAddBan_Load(object sender, EventArgs e)
        {

            txtMaBan.Enabled = false;

            if (formMode == FormMode.Them)
            {
                string Next = "";
                DataTable dt = table.getIdTable(out Next);
                txtMaBan.Text = Next;
                lbHeaderText.Text = "THÊM THÔNG TIN BÀN";
            }
            if (formMode == FormMode.Sua)
            {
                lbHeaderText.Text = "CẬP NHẬT BÀN";
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dl == DialogResult.OK)
            {
                this.Close();
            }
        }

        public string id = "";
        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            string trangthai = rdoCo.Checked ? "Hoạt Động" : "Ngưng Hoạt Động";

            if (string.IsNullOrEmpty(txtTenBan.Text))
            {
                MessageBox.Show("Vui lòng nhập tên bàn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenBan.Focus();
                return;
            }

            if (!rdoCo.Checked && !rdoKhong.Checked)
            {
                MessageBox.Show("Vui lòng chọn trạng thái!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (txtTenBan.Text != currentTenBan && table.KiemTra(txtTenBan.Text))
            {
                MessageBox.Show("Tên bàn đã tồn tại trong hệ thống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenBan.Focus();
                return;
            }
            try
            {
                DTO_TableCF tl = new DTO_TableCF
                (

                       txtTenBan.Text,
                       trangthai
                );

                if (formMode == FormMode.Them)
                {
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
                }
                else
                {

                    tl.IdTable = id;
                    if (table.update(tl))
                    {
                        MessageBox.Show("Cập nhật thành công", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thất bại", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message);
            }
        }
    }
}
