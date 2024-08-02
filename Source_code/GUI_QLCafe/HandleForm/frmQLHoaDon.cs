using BUS_QLCafe;
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

        private void btnRefesh_Click(object sender, System.EventArgs e)
        {
            LoadData();
        }

        private void dgvDSHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void LoadPage()
        {
            try
            {
                totalRows = busbill.ToTalBill();
                totalPages = (int)Math.Ceiling((double)totalRows / PageSize);
                lbTotalPage.Text = totalPages.ToString();

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
            currentPageIndex = totalPages;
            LoadPage();
            lbCurrentPage.Text = currentPageIndex.ToString();
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
                    //dgvDSHD.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sản phẩm", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void shapeLine_Click(object sender, EventArgs e)
        {

        }

        private void frmQLHoaDon_Load_1(object sender, EventArgs e)
        {
            LoadData();
            LoadPage();
            currentPageIndex = 1;
            lbCurrentPage.Text = currentPageIndex.ToString();
        }

        private void btnRefesh_Click_1(object sender, EventArgs e)
        {
            LoadPage();
        }
    }
}
