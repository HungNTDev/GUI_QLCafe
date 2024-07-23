﻿using BUS_QLCafe;
using System;
using System.IO;
using System.Windows.Forms;
using TheArtOfDevHtmlRenderer.Adapters;
using System.Drawing;
using System.Data.Common;

namespace GUI_QLCafe
{
    public partial class frmQLNhanVien : Form
    {
        public frmQLNhanVien()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmAddNhanVien frmAddNV = new frmAddNhanVien("","luu", null, null, 0, 0, null, "");
            frmAddNV.ShowDialog();
            Reload();
        }
        BUS_Staff busNhanVien = new BUS_Staff();
        private int status = 1;

        private void LoadGridView_NhanVien()
        {
            cboStatus.SelectedIndex = 1-status;
            dgvDanhSachNhanVien.DataSource = busNhanVien.get(status);
        }

        public void Reload()
        {
            LoadGridView_NhanVien();
        }
        private void frmQLNhanVien_Load(object sender, EventArgs e)
        {
            Reload();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string column = "";
            if (txtTimKiem.Text.Trim().Length == 0)
            {
                Notification("Nhập nội dung cần tìm!", frmNotification.enumType.Failed);
                return;
            }

            if (cboTim.SelectedIndex == -1)
            {
                column = "rong";
            }
            else
            {
                switch (cboTim.SelectedIndex)
                {
                    case 0:
                        column = "IdStaff";
                        break;
                    case 1:
                        column = "Email";
                        break;
                    case 2:
                        column = "FullName";
                        break;
                    case 3:
                        column = "RoleStaff";
                        break;
                }
            }

            dgvDanhSachNhanVien.DataSource = busNhanVien.search(column, txtTimKiem.Text, status);
            
        }
        private string saveDirectory;
        private string relativePath;
        private void dgvDanhSachNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Lấy vị trí lưu

            saveDirectory = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
            if (dgvDanhSachNhanVien.Rows.Count > 0)
            {
                txtTen.Enabled = true;
                txtEmail.Enabled = true;
                gbTrangThai.Enabled = true;
                gbVaiTro.Enabled = true;


                txtTen.Text = dgvDanhSachNhanVien.CurrentRow.Cells["FullName"].Value.ToString();
                txtEmail.Text = dgvDanhSachNhanVien.CurrentRow.Cells["Email"].Value.ToString();
                txtDuongDan.Text = dgvDanhSachNhanVien.CurrentRow.Cells["ImageStaff"].Value.ToString();

                if (int.Parse(dgvDanhSachNhanVien.CurrentRow.Cells["RoleStaff"].Value.ToString()) == 1)
                {
                    rdoQuanTri.Checked = true;
                }
                else
                {
                    rdoNhanVien.Checked = true;
                }

                if (int.Parse(dgvDanhSachNhanVien.CurrentRow.Cells["StatusStaff"].Value.ToString()) == 1)
                {
                    rdoHoatDong.Checked = true;
                }
                else
                {
                    rdoNgungHoatDong.Checked = true;
                }

                relativePath = dgvDanhSachNhanVien.CurrentRow.Cells["ImageStaff"].Value.ToString();
                string imagePath = Path.Combine(saveDirectory, relativePath.TrimStart('\\')); // Chuyển đổi thành đường dẫn tuyệt đối


                //Nếu file đã tồn tại thì gửi ảnh lên picture box
                if (File.Exists(imagePath))
                {
                    picNhanVien.Image = Image.FromFile(imagePath);
                }
                else
                {
                    messageDialog.Show("Hình ảnh không tồn tại: " + imagePath, "Thông báo");
                    return;
                }
                selected = true;
            }
            else
            {
                messageDialog.Show("Bảng trống", "Thông Báo");
            }
        }
        // phương thức này dùng để gọi Notfication khi thêm thành công
        public void Notification(string msg, frmNotification.enumType type)
        {
            frmNotification notification = new frmNotification();
            frmNotification.showNotfication(msg, type);
        }
        private bool selected;
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (selected)
            {
                string id = dgvDanhSachNhanVien.CurrentRow.Cells["IdStaff"].Value.ToString();
                string email = dgvDanhSachNhanVien.CurrentRow.Cells["Email"].Value.ToString();
                string fullname = dgvDanhSachNhanVien.CurrentRow.Cells["FullName"].Value.ToString();
                int role = int.Parse(dgvDanhSachNhanVien.CurrentRow.Cells["RoleStaff"].Value.ToString());
                int status = int.Parse(dgvDanhSachNhanVien.CurrentRow.Cells["StatusStaff"].Value.ToString());
                string image = dgvDanhSachNhanVien.CurrentRow.Cells["ImageStaff"].Value.ToString();

                frmAddNhanVien frmAddNV = new frmAddNhanVien(id, "sua", email, fullname, role, status, image, saveDirectory);
                frmAddNV.ShowDialog();
                Reload();
            }
            else
            {
                Notification("Vui lòng chọn nhân viên cần sửa!", frmNotification.enumType.Failed);
                return;
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtEmail.Clear();
            txtTen.Clear();
            txtTimKiem.Clear();
            txtDuongDan.Clear();
            picNhanVien.Image = null;
            rdoHoatDong.Checked = false;
            rdoNgungHoatDong.Checked = false;
            rdoNhanVien.Checked = false;
            rdoQuanTri.Checked = false;

            LoadGridView_NhanVien();
        }

        private void cboTim_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTim.SelectedItem != null)
            {
                txtTimKiem.PlaceholderText = $"Nhập {cboTim.SelectedItem.ToString().Substring(0,1).ToLower()}" +
                    $"{cboTim.SelectedItem.ToString().Substring(1)} cần tìm";
            }
        }

        private void cboStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtEmail.Clear();
            txtTen.Clear();
            txtTimKiem.Clear();
            txtDuongDan.Clear();
            picNhanVien.Image = null;
            rdoHoatDong.Checked = false;
            rdoNgungHoatDong.Checked = false;
            rdoNhanVien.Checked = false;
            rdoQuanTri.Checked = false;

            if (cboStatus.SelectedItem != null)
            {
                switch (cboStatus.SelectedIndex)
                {
                    case 0:
                        status = 1;
                        break;
                    case 1:
                        status = 0;
                        break;
                }
                dgvDanhSachNhanVien.DataSource = busNhanVien.get(status);
            }
        }
    }
}
