using DAL_QLCafe;
using DTO_QLCafe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit_Tests.TableCF
{
    public class Insert
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
        //Chạy test từng cái nha

        [TestCase("", "AB", true, TestName = "TC01")]
        [TestCase("", "Bàn số 1234567890123", true, TestName = "TC02")]
        [TestCase("", "", false, TestName = "TC03")]
        //[TestCase("", "Bàn số 123456789012345", false, TestName = "TC04")]
        //[TestCase("", "Bàn 05", true, TestName = "TC05")]
        //[TestCase("", "Bàn số 123456789012345", false, TestName = "TC06")]
        //[TestCase("", "Bàn@", false, TestName = "TC07")]
        //[TestCase("", "Bàn 08", true, TestName = "TC08")]
        //[TestCase("", "Bàn 09", true, TestName = "TC09")]
        public void InsertTable1_Test(string id, string name, bool expectedResult)
        {
            table.idTable = id;
            table.nameTable = name;

            bool result = tableDAL.insert(table);
            Assert.AreEqual(expectedResult, result);
        }

        //[TestCase("", "Bàn 10", "0", true, TestName = "TC10")]
        //[TestCase("", "Bàn@", "", false, TestName = "TC11")]
        //[TestCase("", "Bàn 12", "", true, TestName = "TC12")]
        //[TestCase("", "Bàn@", "0", false, TestName = "TC13")]
        public void InsertTable2_Test(string id, string name, string status, bool expectedResult)
        {
            table.idTable = id;
            table.nameTable = name;
            table.statusTableCF = status;

            bool result = tableDAL.insert(table);
            Assert.AreEqual(expectedResult, result);
        }

    }
}
