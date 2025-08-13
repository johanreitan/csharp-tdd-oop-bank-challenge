using Boolean.CSharp.Main;
using Boolean.CSharp.Main.Concrete;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Boolean.CSharp.Main.Enums;

namespace Boolean.CSharp.Test
{
    [TestFixture]
    public class ExtensionTests
    {
        private Extension _extension;
        public ExtensionTests()
        {
            _extension = new Extension();
        }



        [Test]
        public void ChangingOverdraftLimit()
        {
            Customer customer1 = new Customer("johan");
            Savings savingsAccount1 = customer1.CreateSavingsAccount();

            savingsAccount1.ChangeOverdraftLimit(2000);

            Assert.That(savingsAccount1.OverdraftLimit, Is.EqualTo(2000));
        }


        [Test]
        public void GetAccountBalance()
        {
            Customer customer1 = new Customer("johan", Enums.Branch.Manchester);
            Savings savingsAccount1 = customer1.CreateSavingsAccount();

            savingsAccount1.Deposit(100m);
            savingsAccount1.Withdraw(50m);
            savingsAccount1.Deposit(1000m);

            Assert.That(savingsAccount1.Balance, Is.EqualTo(1050m));
        }


        [Test]
        public void AccountIsConnectedToBranch()
        {
            Customer customer1 = new Customer("johan");
            Savings savingsAccount1 = customer1.CreateSavingsAccount();

      

            Assert.That(savingsAccount1.Branch, Is.EqualTo(Branch.Manchester));
        }

        [Test]
        public void AccountCanBeTransferredToNewBranch()
        {
            Customer customer1 = new Customer("johan");
            Savings savingsAccount1 = customer1.CreateSavingsAccount();
            savingsAccount1.ChangeBranch(Branch.London);


            Assert.That(savingsAccount1.Branch, Is.EqualTo(Branch.London));
        }
    }
}
