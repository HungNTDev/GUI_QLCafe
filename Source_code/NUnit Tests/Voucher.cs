using DAL_QLCafe;
using DTO_QLCafe;
using System.Data;

namespace NUnit_Tests
{
    public class Voucher
    {
        private DAL_Voucher voucherDAL;

        [SetUp]
        public void Setup()
        {
            voucherDAL = new DAL_Voucher();
        }

        [Test]
        public void AddVoucher()
        {
            DTO_Voucher voucherDTO = new DTO_Voucher
            {
                IdVoucher = "V001",
                NameVoucher = "Voucher 1",
                PercentVoucher = 10,
                StatusVoucher = 1
            };

            bool result = voucherDAL.insert(voucherDTO);
            Assert.IsTrue(result);
        }

        [Test]
        public void UpdateVoucher()
        {
            DTO_Voucher voucherDTO = new DTO_Voucher
            {
                IdVoucher = "V001",
                NameVoucher = "Voucher 1",
                PercentVoucher = 10,
                StatusVoucher = 1
            };

            bool result = voucherDAL.update(voucherDTO);
            Assert.IsTrue(result);
        }

        [Test]
        public void DeleteVoucher()
        {
            bool result = voucherDAL.delete("V001");
            Assert.IsTrue(result);
        }

        [Test]
        public void SearchVoucher()
        {
            DataTable results = voucherDAL.search("Voucher 1");
            Assert.IsNotNull(results);
        }
    }
}