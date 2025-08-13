using Boolean.CSharp.Main;
using Boolean.CSharp.Main.Concrete;
using NUnit.Framework;

namespace Boolean.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {
        private Core _core;

        public CoreTests()
        {
            _core = new Core();

        }

        [Test]
        public void CreatingACurrentAccount()
        {
            Customer customer1 = new Customer("johan");

            Current currentAccount1 = customer1.CreateCurrentAccount();

            Assert.That(currentAccount1.AccountOwner.Id, Is.EqualTo(customer1.Id));
        }

        [Test]
        public void CreatingASavingsAccount()
        {
            Customer customer1 = new Customer("johan");

            Savings savingsAccount1 = customer1.CreateSavingsAccount();

            Assert.That(savingsAccount1.AccountOwner.Id, Is.EqualTo(customer1.Id));
        }

    }
}