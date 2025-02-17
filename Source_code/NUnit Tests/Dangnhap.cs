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
        public class Dangnhap
        {
            private DAL_Staff loginDAL;

            [SetUp]
            public void Setup()
            {
                loginDAL = new DAL_Staff();
            }

            [Test]
            public void LoginWithEmptyEmail()
            {
                DTO_Staff loginDTO = new DTO_Staff
                {
                    Email = "",
                    passwordStaff = "1234"
                };

                bool result = loginDAL.dangNhap(loginDTO);
                Assert.IsFalse(result, "Login should fail when email is empty.");
            }

            [Test]
            public void LoginWithEmptyPassword()
            {
                DTO_Staff loginDTO = new DTO_Staff
                {
                    Email = "hungntps38090@gmail.com",
                    passwordStaff = ""
                };

                bool result = loginDAL.dangNhap(loginDTO);
                Assert.IsFalse(result, "Login should fail when password is empty.");
            }

            [Test]
            public void LoginWithEmptyEmailAndPassword()
            {
                DTO_Staff loginDTO = new DTO_Staff
                {
                    Email = "",
                    passwordStaff = ""
                };

                bool result = loginDAL.dangNhap(loginDTO);
                Assert.IsFalse(result, "Login should fail when both email and password are empty.");
            }

            [Test]
            public void LoginSuccessfully()
            {
                BUS_Staff busStaff = new BUS_Staff();
                DTO_Staff loginDTO = new DTO_Staff
                {
                    Email = "hungntps38090@gmail.com",
                    passwordStaff = busStaff.encryption("123456")
                };

                bool result = loginDAL.dangNhap(loginDTO);
                Console.WriteLine($"Kết quả đăng nhập: {result}");
                Assert.IsTrue(result, "Login should succeed with valid email and password.");
            }

            [TearDown]
            public void Cleanup()
            {
                // No cleanup needed for login tests
            }
        }
    }
