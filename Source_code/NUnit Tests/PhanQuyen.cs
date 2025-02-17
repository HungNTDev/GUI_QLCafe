using BUS_QLCafe;
using DAL_QLCafe;
using DTO_QLCafe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit_Tests
{
    public class PhanQuyen
    {
        private DAL_Staff loginDAL;

        [SetUp]
        public void Setup()
        {
            loginDAL = new DAL_Staff();
        }


        [Test]
        public void Login_With_AdminRole()
        {
            BUS_Staff busStaff = new BUS_Staff();
            DTO_Staff loginDTO = new DTO_Staff
            {
                email = "dthanhnd999@gmail.com",
                passwordStaff = busStaff.encryption("thanh999")
            };

            bool result = loginDAL.dangNhap(loginDTO);
            Console.WriteLine($"Kết quả đăng nhập: {result}");
            Assert.IsTrue(result, "Login should succeed with valid email and password.");
        }

        [Test]
        public void Login_Without_StaffRole()
        {
            BUS_Staff busStaff = new BUS_Staff();
            DTO_Staff loginDTO = new DTO_Staff
            {
                email = "duythanhstaff122@gmail.com",
                passwordStaff = busStaff.encryption("Duythanh12205@")
            };

            bool result = loginDAL.dangNhap(loginDTO);
            Console.WriteLine($"Kết quả đăng nhập: {result}");
            Assert.IsTrue(result, "Login should succeed with valid email and password.");
        }
    }
}
