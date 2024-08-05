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
            dgvDanhSachThongKe.DataSource = busStatistic.GetStatistic();   
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
            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "I1");
            head.MergeCells = true;
            head.Value2 = title;
            head.Font.Bold = true;
            head.Font.Name = "Times New Roman";
            head.Font.Size = 20;
            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Tạo tiêu đề cột 
            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");
            cl1.Value2 = "Mã thống kê";
            cl1.ColumnWidth = 12;

            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");
            cl2.Value2 = "Mã hóa đơn";
            cl2.ColumnWidth = 25.0;

            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");
            cl3.Value2 = "Khuyến mãi(%)";
            cl3.ColumnWidth = 18;

            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");
            cl4.Value2 = "Tổng tiền";
            cl4.ColumnWidth = 13.0;

            Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");
            cl5.Value2 = "Tên nhân viên";
            cl5.ColumnWidth = 20.5;

            Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F3", "F3");
            cl6.Value2 = "Giờ vào";
            cl6.ColumnWidth = 20.5;

            Microsoft.Office.Interop.Excel.Range cl7 = oSheet.get_Range("G3", "G3");
            cl7.Value2 = "Giờ ra";
            cl7.ColumnWidth = 20.5;

            Microsoft.Office.Interop.Excel.Range cl8 = oSheet.get_Range("H3", "H3");
            cl8.Value2 = "Phương thức TT";
            cl8.ColumnWidth = 20.5;

            Microsoft.Office.Interop.Excel.Range cl9 = oSheet.get_Range("I3", "I3");
            cl9.Value2 = "Tên bàn";
            cl9.ColumnWidth = 20.5;

            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "I3");
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

                DataColumn col1 = new DataColumn("IdStatistic");
                DataColumn col2 = new DataColumn("IdBill");
                DataColumn col3 = new DataColumn("PercentVoucher");
                DataColumn col4 = new DataColumn("Total");
                DataColumn col5 = new DataColumn("NameStaff");
                DataColumn col6 = new DataColumn("CheckIn");
                DataColumn col7 = new DataColumn("CheckOut");
                DataColumn col8 = new DataColumn("NamePayment");
                DataColumn col9 = new DataColumn("NameTable");

                dataTable.Columns.Add(col1);
                dataTable.Columns.Add(col2);
                dataTable.Columns.Add(col3);
                dataTable.Columns.Add(col4);
                dataTable.Columns.Add(col5);
                dataTable.Columns.Add(col6);
                dataTable.Columns.Add(col7);
                dataTable.Columns.Add(col8);
                dataTable.Columns.Add(col9);

                foreach (DataGridViewRow dgvrRow in dgvDanhSachThongKe.Rows)
                {
                    DataRow dataRow = dataTable.NewRow();

                    dataRow[0] = dgvrRow.Cells[0].Value;
                    dataRow[1] = dgvrRow.Cells[1].Value;
                    dataRow[2] = dgvrRow.Cells[2].Value;
                    dataRow[3] = dgvrRow.Cells[3].Value;
                    dataRow[4] = dgvrRow.Cells[4].Value;
                    dataRow[5] = dgvrRow.Cells[5].Value;
                    dataRow[6] = dgvrRow.Cells[6].Value;
                    dataRow[7] = dgvrRow.Cells[7].Value;
                    dataRow[8] = dgvrRow.Cells[8].Value;

                    dataTable.Rows.Add(dataRow);
                }

                ExportFile(dataTable, "Danh sách", "DANH SÁCH THỐNG KÊ HÓA ĐƠN");
            }
        }
    }
}
