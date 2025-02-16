using DAL_QLCafe;
using DTO_QLCafe;
using System.Data;

namespace NUnit_Tests
{
    public class Staff
    {
        private DAL_Staff staffDAL;
        [SetUp]
        public void Setup()
        {
            staffDAL = new DAL_Staff();
        }

        [Test]
        public void AddStaff()
        {
            DTO_Staff staffDTO = new DTO_Staff
            {
                IdStaff = "S001",
                FullName = "John Doe",
                ImageStaff = "image.jpg",
                Email = "john.doe@example.com",
                PasswordStaff = "password123",
                RoleStaff = "Manager",
                StatusStaff = 1
            };

            bool result = staffDAL.insert(staffDTO);
            Assert.IsTrue(result);
        }

        [Test]
        public void UpdateStaff()
        {
            DTO_Staff staffDTO = new DTO_Staff
            {
                IdStaff = "S001",
                FullName = "John Doe",
                ImageStaff = "image.jpg",
                Email = "john.doe@example.com",
                PasswordStaff = "password123",
                RoleStaff = "Manager",
                StatusStaff = 1
            };

            bool result = staffDAL.update(staffDTO, "NV001");
            Assert.IsTrue(result);
        }

        [Test]
        public void DeleteStaff()
        {
            bool result = staffDAL.delete("NV001");
            Assert.IsTrue(result);
        }

        [Test]
        public void SearchStaff()
        {
            DataTable results = staffDAL.search("Thanh");
            Assert.IsNotNull(results);
        }
    }
}