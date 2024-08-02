using BUS_QLCafe;
using System;
using System.Data;
using System.Windows.Forms;
namespace GUI_QLCafe
{
    public partial class frmQLBan : Form
    {
        BUS_TableCF table = new BUS_TableCF();

        private const int PageSize = 10;
        private int currentPageIndex = 1;
        private int totalPages = 0;
        private int totalRows = 0;

        public frmQLBan()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddBan frmAddBan = new frmAddBan();
            frmAddBan.ShowDialog();
            LoadPage();
        }

        private void LoadData()
        {
            dgvDSBan.DataSource = table.get();
        }

        private void frmQLBan_Load(object sender, EventArgs e)
        {
            LoadPage();
            currentPageIndex = 1;
            lbCurrentPage.Text = currentPageIndex.ToString();
        }

        private void dgvDSBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDSBan.CurrentCell.OwningColumn.Name == "dgvSuaBan")
            {
                frmAddBan frmAddBan = new frmAddBan();
                frmAddBan.txtMaBan.Enabled = false;


                string maBan = Convert.ToString(dgvDSBan.CurrentRow.Cells["dgvMBan"].Value);
                frmAddBan.id = maBan;
                frmAddBan.txtMaBan.Text = maBan;
                frmAddBan.txtTenBan.Text = Convert.ToString(dgvDSBan.CurrentRow.Cells["dgvTBan"].Value);

                frmAddBan.ShowDialog();
                LoadPage();
            }
            if (dgvDSBan.CurrentCell.OwningColumn.Name == "dgvXoaBan")
            {
                string maBan = Convert.ToString(dgvDSBan.CurrentRow.Cells["dgvMBan"].Value);
                if (MessageBox.Show("Bạn chắc chắn  muốn xóa bàn?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (table.delete(maBan))
                    {
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadPage();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tk = txtTimKiem.Text;
            if (string.IsNullOrEmpty(tk))
            {
                MessageBox.Show("Vui lòng nhập nội dung cần tìm!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DataTable dt = table.search(tk);
                if (dt.Rows.Count > 0)
                {
                    dgvDSBan.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy bàn", " Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void LoadPage()
        {
            try
            {
                totalRows = table.get().Rows.Count;
                totalPages = (int)Math.Ceiling((double)totalRows / PageSize);
                lbTotalPage.Text = totalPages.ToString();
                lbTotalRows.Text = "Tổng số dòng: " + totalRows.ToString();

                DataTable dt = table.GetPage(currentPageIndex, PageSize);
                dgvDSBan.DataSource = dt;

                dgvDSBan.Refresh();
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

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            LoadPage();
            txtTimKiem.Clear();
        }
    }
}
