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

        [Test]
        public void GenerateStatement()
        {
            Customer customer1 = new Customer("johan");

            Savings savingsAccount1 = customer1.CreateSavingsAccount();
            savingsAccount1.Deposit(100m);
            savingsAccount1.Deposit(150m);

            Statement statement1 = new Statement(savingsAccount1);

            string printedStatement = statement1.GenerateStatement();


            Assert.That(printedStatement.Contains("Total balance: 250"));


        }

        [Test]
        public void DepositingMoneyShouldMakeBalanceGoUp()
        {
            Customer customer1 = new Customer("johan");
            Savings savingsAccount1 = customer1.CreateSavingsAccount();

            savingsAccount1.Deposit(100m);
            savingsAccount1.Deposit(150m);

            Assert.That(savingsAccount1.Balance, Is.EqualTo(250m));
        }

        [Test]
        public void WithdrawingMoneyShouldMakeBalanceGoDown()
        {
            Customer customer1 = new Customer("johan");
            Savings savingsAccount1 = customer1.CreateSavingsAccount();

            savingsAccount1.Deposit(100m);
            savingsAccount1.Deposit(150m);

            savingsAccount1.Withdraw(25m);

            Assert.That(savingsAccount1.Balance, Is.EqualTo(225m));
        }

        

    }
}