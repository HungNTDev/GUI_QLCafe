using DAL_QLCafe;
using DTO_QLCafe;
using Newtonsoft.Json.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit_Tests
{
    public class ForgotPassword
    {
        private DAL_Staff loginDAL;

        [SetUp]
        public void Setup()
        {
            loginDAL = new DAL_Staff();
        }

        [Test]
        public void ForgotPassword_ReturnTrue_IfEmailExist()
        {
            DTO_Staff loginDTO = new DTO_Staff { Email = "dthanhnd999@gmail.com" };

            bool result = loginDAL.quenMK(loginDTO.email);
            Assert.IsTrue(result, "Email có tồn tại nhưng phương thức trả về false.");
        }

        [Test]
        public void ForgotPassword_ReturnFalse_IfEmailEmpty()
        {
            DTO_Staff loginDTO = new DTO_Staff { Email = "" };

            bool result = loginDAL.quenMK(loginDTO.email);
            Assert.IsFalse(result, "Email rỗng nhưng phương thức lại trả về true");
        }
    }
}
