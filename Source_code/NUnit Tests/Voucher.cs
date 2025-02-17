using DAL_QLCafe;
using DTO_QLCafe;
using NUnit.Framework;
using System;
using System.Data;

namespace NUnit_Tests
{
    public class VoucherTests
    {
        private DAL_Voucher voucherDAL;
        private string testVoucherId;

        [SetUp]
        public void Setup()
        {
            voucherDAL = new DAL_Voucher();
            testVoucherId = "V" + Guid.NewGuid().ToString("N").Substring(0, 5); // Unique ID
        }

        [Test]
        public void AddVoucher()
        {
            DTO_Voucher voucherDTO = new DTO_Voucher
            {
                IdVoucher = testVoucherId,
                NameVoucher = "Test Voucher",
                PercentVoucher = 15,
                StatusVoucher = 1
            };

            bool result = voucherDAL.insert(voucherDTO);
            Assert.IsTrue(result, "Adding voucher failed.");
        }

        [Test]
        public void UpdateVoucher()
        {
            // Insert before updating to ensure it exists
            DTO_Voucher voucherDTO = new DTO_Voucher
            {
                IdVoucher = testVoucherId,
                NameVoucher = "Initial Voucher",
                PercentVoucher = 10,
                StatusVoucher = 1
            };
            Assert.IsTrue(voucherDAL.insert(voucherDTO), "Pre-insert failed.");

            // Update the voucher
            voucherDTO.NameVoucher = "Updated Voucher";
            voucherDTO.PercentVoucher = 20;

            bool result = voucherDAL.update(voucherDTO);
            Assert.IsTrue(result, "Updating voucher failed.");
        }

        [Test]
        public void DeleteVoucher()
        {
            // Insert before deleting
            DTO_Voucher voucherDTO = new DTO_Voucher
            {
                IdVoucher = testVoucherId,
                NameVoucher = "Voucher to Delete",
                PercentVoucher = 10,
                StatusVoucher = 1
            };
            Assert.IsTrue(voucherDAL.insert(voucherDTO), "Pre-insert failed.");

            bool result = voucherDAL.delete(testVoucherId);
            Assert.IsTrue(result, "Deleting voucher failed.");
        }

        [Test]
        public void SearchVoucher()
        {
            // Insert before searching
            DTO_Voucher voucherDTO = new DTO_Voucher
            {
                IdVoucher = testVoucherId,
                NameVoucher = "Searchable Voucher",
                PercentVoucher = 10,
                StatusVoucher = 1
            };
            Assert.IsTrue(voucherDAL.insert(voucherDTO), "Pre-insert failed.");

            DataTable results = voucherDAL.search("Searchable Voucher");
            Assert.IsNotNull(results, "Search returned null.");
            Assert.That(results.Rows.Count, Is.GreaterThan(0), "Search returned no results.");
        }

        [TearDown]
        public void Cleanup()
        {
            voucherDAL.delete(testVoucherId); // Cleanup test data
        }
    }
}
