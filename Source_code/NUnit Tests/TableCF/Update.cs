using DAL_QLCafe;
using DTO_QLCafe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit_Tests.TableCF
{
    public class Update
    {
        private DAL_TableCF tableDAL;
        private DTO_TableCF table;
        [SetUp]
        public void SetUp()
        {
            tableDAL = new DAL_TableCF();
            table = new DTO_TableCF
            {
                idTable = "B31",
                nameTable = "Bàn 31"
            };
        }


        [TestCase("B01", "AB", "Trống", true, TestName = "TC16")]  // Tên bàn gần giới hạn dưới
        [TestCase("B02", "Bàn số 1234567890123", "Trống", true, TestName = "TC17")]  // Tên bàn gần giới hạn trên
        [TestCase("B03", "A", "Trống", false, TestName = "TC18")]  // Tên bàn ngắn hơn giới hạn dưới
        [TestCase("B04", "Bàn số 123456789012345", "Trống", false, TestName = "TC19")]  // Tên bàn dài hơn giới hạn trên
        //[TestCase("B05", "AB", "Trống", true, TestName = "TC20")]  // Tên bàn hợp lệ
        //[TestCase("B06", "Bàn số 123456789012345", "Trống", false, TestName = "TC21")]  // Tên bàn không hợp lệ
        //[TestCase("B07", "Bàn@", "Trống", false, TestName = "TC22")]  // Tên bàn chứa ký tự đặc biệt
        //[TestCase("B08", "Bàn 1", "Trống", true, TestName = "TC23")]  // Trạng thái hợp lệ: "Trống"
        //[TestCase("B09", "Bàn 2", "Đang sử dụng", true, TestName = "TC24")]  // Trạng thái hợp lệ: "Đang sử dụng"
        //[TestCase("B10", "AB", "abcxyz", false, TestName = "TC25")]  // Trạng thái không hợp lệ
        //[TestCase("B11", "Bàn@", "Trống", false, TestName = "TC26")]  // Tên bàn không hợp lệ, trạng thái hợp lệ
        //[TestCase("B12", "", "Trống", false, TestName = "TC27")]  // Tên bàn rỗng, trạng thái hợp lệ
        //[TestCase("", "Bàn 1", "Trống", false, TestName = "TC28")]  // Không chọn bàn (id rỗng)
        public void UpdateTable_Test(string idTable, string name, string status, bool expectedResult)
        {
            // Gán dữ liệu cho DTO
            table.idTable = idTable;
            table.nameTable = name;
            table.statusTableCF = status;

            // Gọi phương thức update thực tế từ DAL
            bool result = tableDAL.update(table);

            // Kiểm tra kết quả mong đợi
            Assert.AreEqual(expectedResult, result, $"Test case thất bại với idTable = {idTable}, nameTable = {name}, status = {status}");
        }
    }
}
