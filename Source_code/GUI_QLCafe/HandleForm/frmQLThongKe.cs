using BUS_QLCafe;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLCafe.HandleForm
{
    public partial class frmQLThongKe : Form
    {
        BUS_Bill busStatistic = new BUS_Bill();

        private const int PageSize = 10;
        private int currentPageIndex = 1;
        private int totalPages = 0;
        private int totalRows = 0;
        bool kiemTraData = false;

        public frmQLThongKe()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            dgvDanhSachThongKe.DataSource = busStatistic.GetDetailStatistic();
            decimal tongDoanhThu = TinhTongDoanhThu();
            lbTongDoanhThu.Text = "Tổng doanh thu: " + tongDoanhThu.ToString() + " VND";
        }

        private void LoadPage()
        {
            try
            {
                totalRows = busStatistic.GetTotalStatisticCount();
                totalPages = (int)Math.Ceiling((double)totalRows / PageSize);
                lbTotalPage.Text = totalPages.ToString();
                lbTotalRows.Text = "Tổng số dòng: " + totalRows.ToString();

                DataTable dt = busStatistic.GetPagedStatistic(currentPageIndex, PageSize);
                dgvDanhSachThongKe.DataSource = dt;
                dgvDanhSachThongKe.Refresh();

                kiemTraData = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void LoadAllData()
        {
            try
            {
                LoadData();
                kiemTraData = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void frmQLThongKe_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadPage();
            currentPageIndex = 1;
            lbCurrentPage.Text = currentPageIndex.ToString();
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string timKiem = txtTimKiem.Text;
            if (string.IsNullOrEmpty(timKiem))
            {
                MessageBox.Show("Vui lòng nhập nội dung cần tìm!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DataTable dt = busStatistic.SearchStatistic(timKiem);
                if (dt.Rows.Count > 0)
                {
                    dgvDanhSachThongKe.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy!", " Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
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

        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            currentPageIndex = 1;
            LoadPage();
            lbCurrentPage.Text = currentPageIndex.ToString();
        }

        private void btnLastPage_Click(object sender, EventArgs e)
        {
            currentPageIndex = totalPages;
            LoadPage();
            lbCurrentPage.Text = currentPageIndex.ToString();
        }

        public void ExportFile(DataTable dataTable, string sheetName, string title)
        {
            Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbooks oBooks;
            Microsoft.Office.Interop.Excel.Sheets oSheets;
            Microsoft.Office.Interop.Excel.Workbook oBook;
            Microsoft.Office.Interop.Excel.Worksheet oSheet;

            //Tạo mới một Excel WorkBook 
            oExcel.Visible = true;
            oExcel.DisplayAlerts = false;
            oExcel.Application.SheetsInNewWorkbook = 1;
            oBooks = oExcel.Workbooks;
            oBook = (Microsoft.Office.Interop.Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));
            oSheets = oBook.Worksheets;
            oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);
            oSheet.Name = sheetName;

            // Tạo phần Tiêu đề
            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "C1");
            head.MergeCells = true;
            head.Value2 = title;
            head.Font.Bold = true;
            head.Font.Name = "Times New Roman";
            head.Font.Size = 20;
            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Tạo tiêu đề cột 
            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");
            cl1.Value2 = "Tên sản phẩm";
            cl1.ColumnWidth = 25;

            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");
            cl2.Value2 = "Số lượng";
            cl2.ColumnWidth = 25.0;

            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");
            cl3.Value2 = "Tổng tiền (VND)";
            cl3.ColumnWidth = 20;

            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "C3");
            rowHead.Font.Bold = true;

            // Kẻ viền
            rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

            // Thiết lập màu nền
            rowHead.Interior.ColorIndex = 6;
            rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Tạo mảng theo datatable
            object[,] arr = new object[dataTable.Rows.Count, dataTable.Columns.Count];

            //Chuyển dữ liệu từ DataTable vào mảng đối tượng
            for (int row = 0; row < dataTable.Rows.Count; row++)
            {
                DataRow dataRow = dataTable.Rows[row];

                for (int col = 0; col < dataTable.Columns.Count; col++)
                {
                    arr[row, col] = dataRow[col];
                }
            }

            //Thiết lập vùng điền dữ liệu
            int rowStart = 4;
            int columnStart = 1;
            int rowEnd = rowStart + dataTable.Rows.Count - 1;
            int columnEnd = dataTable.Columns.Count;

            // Ô bắt đầu điền dữ liệu
            Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, columnStart];

            // Ô kết thúc điền dữ liệu
            Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];

            // Lấy về vùng điền dữ liệu
            Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(c1, c2);

            //Điền dữ liệu vào vùng đã thiết lập
            range.Value2 = arr;

            // Kẻ viền
            range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

            //Căn giữa cả bảng 
            oSheet.get_Range(c1, c2).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
        }

        private decimal TinhTongDoanhThu()
        {
            decimal tongDoanhThu = 0;

            foreach(DataGridViewRow dgvRow in dgvDanhSachThongKe.Rows)
            {
                if (dgvRow.Cells["Tổng tiền  (VND)"].Value != null && decimal.TryParse(dgvRow.Cells["Tổng tiền  (VND)"].Value.ToString(), out decimal total))
                {
                    tongDoanhThu += total;  
                }
            }
            return tongDoanhThu;
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (!kiemTraData)
            {
                DialogResult dl1 = MessageBox.Show("Bạn cần tải lại dữ liệu trước khi xuất file.\nBạn có muốn tải tất cả dữ liệu không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dl1 == DialogResult.Yes)
                {
                    LoadAllData();
                }
                else
                {
                    return;
                }
            }

            DialogResult dl2 = MessageBox.Show("Bạn có muốn xuất thống kê ra file?", "Thông báo", 
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(dl2 == DialogResult.OK)
            {
                DataTable dataTable = new DataTable();

                DataColumn col1 = new DataColumn("NameProduct");
                DataColumn col2 = new DataColumn("Amount");
                DataColumn col3 = new DataColumn("TotalPrice");

                dataTable.Columns.Add(col1);
                dataTable.Columns.Add(col2);
                dataTable.Columns.Add(col3);

                foreach (DataGridViewRow dgvRow in dgvDanhSachThongKe.Rows)
                {
                    DataRow dataRow = dataTable.NewRow();

                    dataRow[0] = dgvRow.Cells[0].Value;
                    dataRow[1] = dgvRow.Cells[1].Value;
                    dataRow[2] = dgvRow.Cells[2].Value;

                    dataTable.Rows.Add(dataRow);
                }

                ExportFile(dataTable, "Danh sách", "DANH SÁCH THỐNG KÊ DOANH THU");
            }
        }
    }
}
