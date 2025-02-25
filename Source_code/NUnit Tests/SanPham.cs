using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QLCafe;
using DTO_QLCafe;
using System.Data;


namespace NUnit_Tests
{
    public class SanPham
    {
        private DAL_Product productDAL;
        private string testIdProduct;

        [SetUp]
        public void Setup()
        {
            productDAL = new DAL_Product();
            testIdProduct = "TEST_" + Guid.NewGuid().ToString("N").Substring(0, 5); // Unique ID
        }

        [Test]
        public void AddProduct()
        {
            DTO_Product productDTO = new DTO_Product
            {
                IdProduct = testIdProduct,
                NameProduct = "san pham 1",
                Price = 13000f,
                StatusProduct = 1,
                ImageProduct = "baohoang.png",
                IdPT = "CFE"
            };

            bool result = productDAL.insert(productDTO);
            Assert.IsTrue(result, "Adding product failed.");
        }

        [Test]
        public void UpdateProduct()
        {
            // Insert before updating to ensure it exists
            DTO_Product productDTO = new DTO_Product
            {
                IdProduct = testIdProduct,
                NameProduct = "san pham 1",
                Price = 13000f,
                StatusProduct = 1,
                ImageProduct = "baohoang.png",
                IdPT = "CFE"
            };
            Assert.IsTrue(productDAL.insert(productDTO), "Pre-insert failed.");

            // Update the product
            productDTO.NameProduct = "update san pham 1";

            bool result = productDAL.update(productDTO);
            Assert.IsTrue(result, "Updating product failed.");
        }

        [Test]
        public void DeleteProduct()
        {
            DTO_Product productDTO = new DTO_Product
            {
                IdProduct = testIdProduct,
                NameProduct = "san pham 1",
                Price = 13000f,
                StatusProduct = 1,
                ImageProduct = "baohoang.png",
                IdPT = "CFE"
            };
            Assert.IsTrue(productDAL.insert(productDTO), "Pre-insert failed.");

            bool result = productDAL.delete(testIdProduct);
            Assert.IsTrue(result, "Deleting voucher failed.");
        }

        [Test]
        public void SearchProduct()
        {
            DTO_Product productDTO = new DTO_Product
            {
                IdProduct = testIdProduct,
                NameProduct = "san pham 1",
                Price = 13000f,
                StatusProduct = 1,
                ImageProduct = "baohoang.png",
                IdPT = "CFE"
            };
            Assert.IsTrue(productDAL.insert(productDTO), "Pre-insert failed.");

            DataTable results = productDAL.search("san pham 1");
            Assert.IsNotNull(results, "Search returned null.");
            Assert.That(results.Rows.Count, Is.GreaterThan(0), "Search returned no results.");
        }

        [TearDown]
        public void Cleanup()
        {
            productDAL.delete(testIdProduct); // Cleanup test data
        }
    }
}
