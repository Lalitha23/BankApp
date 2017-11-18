using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            ///reference, odject, instance of a class
            var account1 = new Account
            {
                EmailAddress = "test@acount.com",
                AccountType = TypeOfAccount.CD,
                AccountName = "Customer1"
        };

            account1.Deposit(178.5M);
            Console.WriteLine($"Account Balance: {account1.Balance}, Account Type: {account1.AccountType}, Email: {account1.EmailAddress}, Account Number: {account1.AccountNumber}");

            var account2 = new Account
            {
               EmailAddress = "test2@account.com",
               AccountType = TypeOfAccount.Checking,
        };

            account2.Deposit(100.5M);
            Console.WriteLine($"Account Balance: {account2.Balance}, Account Type: {account2.AccountType}, Email: {account2.EmailAddress}, Account Number: {account2.AccountNumber}");

        }
    }
}
