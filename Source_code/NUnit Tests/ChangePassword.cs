using DAL_QLCafe;
using DTO_QLCafe;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit_Tests
{
    public class ChangePassword
    {
        private DAL_Staff staffDAL; // Giả định bạn có DAL cho quản lý mật khẩu  
        private string testStaffId;
        private string testEmail = "john.doe@example.com"; // Email thử nghiệm  
        private string initialPassword = "1234";
        private string newPassword = "123";

        [SetUp]
        public void Setup()
        {
            // Khởi tạo DAL  
            staffDAL = new DAL_Staff();
            testStaffId = "TEST_" + Guid.NewGuid().ToString("N").Substring(0, 5); // ID duy nhất  

            // Thêm một nhân viên mới để test  
            DTO_Staff staffDTO = new DTO_Staff
            {
                IdStaff = testStaffId,
                FullName = "John Doe",
                ImageStaff = "image.jpg",
                Email = testEmail,
                PasswordStaff = initialPassword,
                RoleStaff = "Manager",
                StatusStaff = 1
            };

            staffDAL.insert(staffDTO);
        }

        [Test]
        //Kiểm tra chức năng đổi mật khẩu khi mật khẩu cũ đúng.
        public void ChangePassword_ValidOldPassword_Success() 
        {
            bool result = staffDAL.UpdateMK(testEmail, initialPassword, newPassword); // Cập nhật mật khẩu  
            Assert.IsTrue(result, "Changing password failed with valid old password.");
        }

        [Test]
        //Kiểm tra trường hợp đổi mật khẩu với mật khẩu cũ sai.
        public void ChangePassword_InvalidOldPassword_Failure()
        {
            bool result = staffDAL.UpdateMK(testEmail, "wrongpassword", newPassword); // Cố gắng đổi mật khẩu với mật khẩu cũ sai  
            Assert.IsFalse(result, "Changing password should fail with invalid old password.");
        }

        [Test]
        //Kiểm tra chức năng lấy mật khẩu cũ và xác nhận nó đúng.
        public void CheckOldPassword_ValidPassword_ReturnData()
        {
            DataTable dt = staffDAL.layMK(testEmail); // Lấy mật khẩu cũ để kiểm tra  
            Assert.IsNotNull(dt, "DataTable should not be null.");
            Assert.IsTrue(dt.Rows.Count > 0, "Should return a row with the old password.");
            Assert.AreEqual(initialPassword, dt.Rows[0]["PasswordStaff"].ToString(), "Old password does not match.");
        }

        [Test]
        //Đảm bảo rằng không có kết quả được trả về cho email không tồn tại.
        public void CheckOldPassword_InvalidEmail_ReturnNoData()
        {
            DataTable dt = staffDAL.layMK("invalid.email@example.com");
            Assert.IsNotNull(dt, "DataTable should not be null.");
            Assert.AreEqual(0, dt.Rows.Count, "Should return no rows for invalid email.");
        }

        [TearDown]
        public void Cleanup()
        {
            staffDAL.delete(testEmail); // Dọn dẹp dữ liệu test  
        }
    }
}
