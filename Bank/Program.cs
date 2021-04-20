using System;
using Classes;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("<name>", 1000);
            account.MakeWithdrawl(500, DateTime.Now, "Rent payment");
            Console.WriteLine($"Account {account.AccountNumber} was created for {account.Owner} with {account.Balance} initial balance");
        }
    }
}
