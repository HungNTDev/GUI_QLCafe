using DAL_QLCafe;
using DTO_QLCafe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit_Tests.TableCF
{
    public class Delete
    {
        private DAL_TableCF tableDAL;
        private DTO_TableCF table;
        [SetUp]
        public void SetUp()
        {
            tableDAL = new DAL_TableCF();
            table = new DTO_TableCF
            {
                nameTable = "Bàn 31",
                statusTableCF = "0"
            };
        }

        [TestCase("B01", true, TestName = "TC14")]  // Xóa bàn hợp lệ
        [TestCase("", false, TestName = "TC15")]    // Không chọn bàn nào
        public void DeleteTable_Test(string idTable, bool expectedResult)
        {
            bool result = tableDAL.delete(idTable);  // Gọi trực tiếp từ DAL
            Assert.AreEqual(expectedResult, result, $"Test case thất bại với idTable = {idTable}");
        }
    }
}
