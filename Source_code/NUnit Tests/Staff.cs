using DAL_QLCafe;
using DTO_QLCafe;
using System.Data;

namespace NUnit_Tests
{
    public class Staff
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
            Assert.IsTrue(result, "Adding staff failed.");
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
            Assert.IsTrue(insertResult, "Adding staff before update failed.");

            bool updateResult = staffDAL.update(staffDTO, testStaffId); // Use correct ID
            Assert.IsTrue(updateResult, "Updating staff failed.");
        }
        [Test]
        public void S01_SearchStaff()
        {
            DataTable results = staffDAL.search("John Doe");
            Assert.IsNotNull(results, "Search returned null.");
            Assert.IsTrue(results.Rows.Count > 0, "Search returned no results.");
        }
        [Test]
        public void S02_DeleteStaff()
        {
            DTO_Staff staffDTO = new DTO_Staff
            {
                IdStaff = testStaffId,
                FullName = "John Updated",
                ImageStaff = "image.jpg",
                Email = "john.doe@example.com",
                PasswordStaff = "password123",
                RoleStaff = "Manager",
                StatusStaff = 1
            };

            bool insertResult = staffDAL.insert(staffDTO);
            Assert.IsTrue(insertResult, "Adding staff before delete failed.");

            bool deleteResult = staffDAL.delete(staffDTO.FullName);
            Assert.IsTrue(deleteResult, "Deleting staff failed.");
        }

        

        [TearDown]
        public void Cleanup()
        {
            staffDAL.delete(testStaffId); // Cleanup test data
        }
    }
}