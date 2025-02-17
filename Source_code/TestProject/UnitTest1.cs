using DAL_QLCafe;
using DTO_QLCafe;
using NUnit.Framework; // Add this using directive

namespace TestProject
{
    public class Tests
    {
        private DAL_Staff staffDAL;
        private string testStaffId;

        [SetUp]
        public void Setup()
        {
            staffDAL = new DAL_Staff();
            testStaffId = "TEST_" + Guid.NewGuid().ToString("N").Substring(0, 5); // Unique ID
        }

        [Test]
        public void AddStaff()
        {
            DTO_Staff staffDTO = new DTO_Staff
            {
                IdStaff = testStaffId,
                FullName = "John Doe",
                ImageStaff = "image.jpg",
                Email = "john.doe@example.com",
                PasswordStaff = "password123",
                RoleStaff = "Manager",
                StatusStaff = 1
            };

            bool result = staffDAL.insert(staffDTO);
            Assert.That(result, Is.True, "Adding staff failed.");
        }

        [Test]
        public void UpdateStaff()
        {
            DTO_Staff staffDTO = new DTO_Staff
            {
                IdStaff = testStaffId,  // Same ID as the added staff
                FullName = "John Updated",
                ImageStaff = "image.jpg",
                Email = "john.updated@example.com",
                PasswordStaff = "newpassword",
                RoleStaff = "Admin",
                StatusStaff = 1
            };

            bool insertResult = staffDAL.insert(staffDTO);
            Assert.That(insertResult, Is.True, "Adding staff before update failed.");

            bool updateResult = staffDAL.update(staffDTO, testStaffId); // Use correct ID
            Assert.That(updateResult, Is.True, "Updating staff failed.");
        }

        //[Test]
        //public void DeleteStaff()
        //{
        //    DTO_Staff staffDTO = new DTO_Staff
        //    {
        //        IdStaff = testStaffId,
        //        FullName = "John Doe",
        //        ImageStaff = "image.jpg",
        //        Email = "john.doe@example.com",
        //        PasswordStaff = "password123",
        //        RoleStaff = "Manager",
        //        StatusStaff = 1
        //    };

        //    bool insertResult = staffDAL.insert(staffDTO);
        //    Assert.That(insertResult, Is.True, "Adding staff before delete failed.");

        //    bool deleteResult = staffDAL.delete(testStaffId);
        //    Assert.That(deleteResult, Is.True, "Deleting staff failed.");
        //}

        //[Test]
        //public void SearchStaff()
        //{
        //    DataTable results = staffDAL.search("Thanh");
        //    Assert.That(results, Is.Not.Null, "Search returned null.");
        //    Assert.That(results.Rows.Count, Is.GreaterThan(0), "Search returned no results.");
        //}

        //[TearDown]
        //public void Cleanup()
        //{
        //    staffDAL.delete(testStaffId); // Cleanup test data
        //}
    }
}
