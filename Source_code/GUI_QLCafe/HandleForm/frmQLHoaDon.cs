﻿using BUS_QLCafe;
using System;
using System.Data;
using System.Windows.Forms;

namespace GUI_QLCafe
{
    public partial class frmQLHoaDon : Form
    {
        BUS_Bill busbill = new BUS_Bill();
        private const int PageSize = 10;
        private int currentPageIndex = 1;
        private int totalPages = 0;
        private int totalRows = 0;
        public frmQLHoaDon()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            dgvDSHD.DataSource = busbill.get();
        }

        private void frmQLHoaDon_Load(object sender, System.EventArgs e)
        {
            LoadData();
            LoadPage();
            currentPageIndex = 1;
            lbCurrentPage.Text = currentPageIndex.ToString();
        }

        private void btnRefesh_Click(object sender, System.EventArgs e)
        {
            LoadData();
        }

        private void dgvDSHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string mabill = Convert.ToString((dgvDSHD.CurrentRow.Cells["IdBill"].Value));
            if (MessageBox.Show("Bạn chắc chắn muốn xóa hóa đơn?", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                if (busbill.delete(mabill))
                {
                    MessageBox.Show("Xóa thành công", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadPage()
        {
            try
            {
                totalRows = busbill.ToTalBill();
                totalPages = (int)Math.Ceiling((double)totalRows / PageSize);
                lbTotalPage.Text = totalPages.ToString();
                lbTotalRows.Text = "Tổng số dự án: " + totalRows.ToString();

                DataTable dt = busbill.GetPagedBill(currentPageIndex, PageSize);
                dgvDSHD.DataSource = dt;

                dgvDSHD.Refresh();
                lbTotalRows.Text = "Tổng số dòng: " + totalRows.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            currentPageIndex = 1;
            LoadPage();
            lbCurrentPage.Text = currentPageIndex.ToString();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (currentPageIndex > 1)
            {
                currentPageIndex--;
                LoadPage();
                lbCurrentPage.Text = currentPageIndex.ToString();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentPageIndex < totalPages)
            {
                currentPageIndex++;
                LoadPage();
                lbCurrentPage.Text = currentPageIndex.ToString();
            }
        }

        private void btnLastPage_Click(object sender, EventArgs e)
        {
            if (currentPageIndex < totalPages)
            {
                currentPageIndex++;
                LoadPage();
                lbCurrentPage.Text = currentPageIndex.ToString();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string sp = txtTimKiem.Text;
            if (string.IsNullOrEmpty(sp))
            {
                MessageBox.Show("Vui lòng nhập nội dung cần tìm!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DataTable dt = busbill.search(sp);
                if (dt.Rows.Count > 0)
                {
                    dgvDSHD.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy hóa đơn", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
