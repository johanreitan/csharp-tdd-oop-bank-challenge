
using Boolean.CSharp.Main.Abstract;
using Boolean.CSharp.Main.Concrete;

Customer customer1 = new Customer("Johan Reitan");
customer1.CreateCurrentAccount();
Account savingsAccount1 = new Savings(customer1);
savingsAccount1.Deposit(100m);

Console.WriteLine(savingsAccount1.Transactions.Count);

