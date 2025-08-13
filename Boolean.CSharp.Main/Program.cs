
using Boolean.CSharp.Main;
using Boolean.CSharp.Main.Abstract;
using Boolean.CSharp.Main.Concrete;
using System.Text;
using System.Transactions;

Customer customer1 = new Customer("Johan Reitan");
customer1.CreateCurrentAccount();
Account savingsAccount1 = new Savings(customer1);
savingsAccount1.Deposit(100m);
savingsAccount1.Deposit(100m);
savingsAccount1.Deposit(100m);
savingsAccount1.Deposit(100m);

savingsAccount1.Withdraw(250m);
savingsAccount1.Deposit(50m);

Statement statement = new Statement(savingsAccount1);
Console.WriteLine(statement.GenerateStatement());



Console.WriteLine(savingsAccount1.Transactions.Count);
Console.WriteLine(savingsAccount1.Balance);

Console.WriteLine();


