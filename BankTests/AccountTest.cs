using NUnit.Framework;
using Bank;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Account account = new Bank.Account();
            Assert.AreEqual(account.numberOne(), 1);
        }
    }
}
