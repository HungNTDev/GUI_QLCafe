using DAL_QLCafe;
using DTO_QLCafe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace NUnit_Tests
{
    public class ChangePasswordTests
    {
        private DAL_Staff staffDAL;

        [SetUp]
        public void Setup()
        {
            staffDAL = new DAL_Staff();
        }

        [Test]
        public void ChangePasswordWithEmptyOldPassword()
        {
           
            bool result = staffDAL.UpdateMK("hungntps38090@gmail.com", "", "123");
            Assert.IsFalse(result, "Change password should fail when old password is empty.");
        }

        [Test]
        public void ChangePasswordWithEmptyNewPassword()
        {
            bool result = staffDAL.UpdateMK("hungntps38090@gmail.com", "1234", "");
            Assert.IsFalse(result, "Change password should fail when new password is empty.");
        }

        [Test]
        public void ChangePasswordWithIncorrectOldPassword()
        {
            bool result = staffDAL.UpdateMK("hungntps38090@gmail.com", "123", "1234");
            Assert.IsFalse(result, "Change password should fail when old password is incorrect.");
        }

        [Test]
        public void ChangePasswordSuccessfully()
        {
            bool result = staffDAL.UpdateMK("hungntps38090@gmail.com", "1234", "123456");
            Assert.IsTrue(result, "Change password should succeed with correct old password and valid new password.");
        }

        [TearDown]
        public void Cleanup()
        {
            // No cleanup needed for change password tests
        }
    }
}
