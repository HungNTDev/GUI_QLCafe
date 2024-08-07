using BUS_QLCafe;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Printing;

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

        private void frmQLHoaDon_Load(object sender, EventArgs e)
        {
            LoadData();
            AddButtonColumns();
        }

        public void LoadData()
        {
            dgvDSHD.DataSource = busbill.get();
        }

        private void btnRefesh_Click(object sender, System.EventArgs e)
        {
            txtTimKiem.Clear();
            LoadData();
        }
        private void LoadPage()
        {
            try
            {
                totalRows = busbill.ToTalBill();
                totalPages = (int)Math.Ceiling((double)totalRows / PageSize);
                //lbTotalPage.Text = totalPages.ToString();

                DataTable dt = busbill.GetPagedBill(currentPageIndex, PageSize);
                dgvDSHD.DataSource = dt;

                dgvDSHD.Refresh();
                //lbTotalRows.Text = "Tổng số dòng: " + totalRows.ToString();
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
                    dgvDSHD.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy hóa đơn", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


        private void btnRefesh_Click_1(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            LoadData();
        }

        private void AddButtonColumns()
        {
            DataGridViewButtonColumn printColumn = new DataGridViewButtonColumn();
            printColumn.Name = "Print";
            printColumn.HeaderText = "";
            printColumn.Text = "In hóa đơn";
            printColumn.UseColumnTextForButtonValue = true;
            dgvDSHD.Columns.Add(printColumn);

            dgvDSHD.CellContentClick += dgvDSHD_CellContentClick;
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            DataTable billDetails = busbill.GetBillById(currentIdBill);

            Font font = new Font("Arial", 12);
            float fontHeight = font.GetHeight();
            int startX = 10;
            int startY = 10;
            int offset = 40;

            e.Graphics.DrawString("HÓA ĐƠN THANH TOÁN", new Font("Arial", 35, FontStyle.Bold), Brushes.Black, new Point(155,20));
            startY += 65;
            e.Graphics.DrawString("_______________________________________________________________________________________", font, Brushes.Black, startX, startY);
            startY += 30;
            e.Graphics.DrawString("Tên bàn", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, startX + 10, startY);
            e.Graphics.DrawString("Tên sản phẩm", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, startX + 120, startY);
            e.Graphics.DrawString("SL", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, startX + 320, startY);
            e.Graphics.DrawString("Đơn giá", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, startX + 400, startY);
            e.Graphics.DrawString("Thành tiền (VND)", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, startX + 550, startY);
            startY += 30;
            e.Graphics.DrawString("______________________________________________________________________________________", font, Brushes.Black, startX, startY);
            startY += 10;

            foreach (DataRow row in billDetails.Rows)
            {
                string table = row["Tên bàn"].ToString();
                string product = row["Tên sản phẩm"].ToString();
                string amount = row["Số lượng"].ToString();
                string price = row["Đơn giá"].ToString();
                string totalprice = row["Thành tiền(VND)"].ToString();


                e.Graphics.DrawString(table, new Font("Arial", 16, FontStyle.Bold), Brushes.Black, startX + 10, startY + offset);
                e.Graphics.DrawString(product, new Font("Arial", 16, FontStyle.Bold), Brushes.Black, startX + 120, startY + offset);
                e.Graphics.DrawString(amount, new Font("Arial", 16, FontStyle.Bold), Brushes.Black, startX + 320, startY + offset);
                e.Graphics.DrawString(price, new Font("Arial", 16, FontStyle.Bold), Brushes.Black, startX + 400, startY + offset);
                e.Graphics.DrawString(totalprice, new Font("Arial", 16, FontStyle.Bold), Brushes.Black, startX + 550, startY + offset);
                
                offset += (int)fontHeight + 10;
            }

            string totalAmount = billDetails.Compute("SUM([Tổng tiền(VND)])", string.Empty).ToString();
            startY += offset + 20;
            e.Graphics.DrawString("______________________________________________________________________________________", font, Brushes.Black, startX, startY);
            startY += 20;
            e.Graphics.DrawString($"Tổng tiền: {totalAmount} VND", new Font("Arial", 25, FontStyle.Bold), Brushes.Black, startX + 350, startY + offset);
        }

        private PrintDocument PrintDocument;
        private string currentIdBill;
        private void PrintBill(string idBill)
        {
            currentIdBill = idBill;
            printDocument = new PrintDocument();
            printDocument.PrintPage += printDocument_PrintPage;
            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog
            {
                Document = printDocument,   
                Width = 800,
                Height = 600
            };

            printPreviewDialog.ShowDialog();    
        }

        private void dgvDSHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0 && dgvDSHD.Columns[e.ColumnIndex].Name == "Print")
            {
                string idBill = dgvDSHD.Rows[e.RowIndex].Cells["Mã hóa đơn"].Value.ToString();
                PrintBill(idBill); ;
            }
        }

    }
}
