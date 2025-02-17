using DAL_QLCafe;
using DTO_QLCafe;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit_Tests.TableCF
{
    public class Search
    {
        private DAL_TableCF tableDAL;
        private DTO_TableCF table;
        [SetUp]
        public void SetUp()
        {
            tableDAL = new DAL_TableCF();
            table = new DTO_TableCF();
        }

        [TestCase("AB", true, TestName = "TC29")]  // Tên bàn có độ dài gần giới hạn dưới
        [TestCase("Bàn số 1234567890123", true, TestName = "TC30")]  // Tên bàn có độ dài gần giới hạn trên
        [TestCase("A", false, TestName = "TC31")]  // Tên bàn ngắn hơn giới hạn dưới
        [TestCase("Bàn số 123456789012345", false, TestName = "TC32")]  // Tên bàn dài hơn giới hạn trên
        [TestCase("AB", true, TestName = "TC33")]  // Tên bàn hợp lệ
        [TestCase("Bàn số 123456789012345", false, TestName = "TC34")]  // Tên bàn không hợp lệ
        [TestCase("Bàn@", false, TestName = "TC35")]  // Tên bàn chứa ký tự đặc biệt
        [TestCase("", false, TestName = "TC36")]  // Bấm nút tìm kiếm nhưng chưa nhập tên bàn
        public void SearchTable_Test(string nameTable, bool expectedResult)
        {
            // Gọi phương thức search() trong DAL (trả về DataTable)
            DataTable dt = tableDAL.search(nameTable);

            // Kiểm tra xem DataTable có chứa dữ liệu không
            bool actualResult = dt != null && dt.Rows.Count > 0;

            // So sánh kết quả mong đợi
            Assert.AreEqual(expectedResult, actualResult, $"Test case thất bại với nameTable = {nameTable}");
        }
    }
}
