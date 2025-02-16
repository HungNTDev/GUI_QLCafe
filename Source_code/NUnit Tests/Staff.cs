using DAL_QLCafe;

namespace NUnit_Tests
{
    public class Staff
    {
        private DAL_Staff staff;
        [SetUp]
        public void Setup()
        {
            staff = new DAL_Staff();
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}