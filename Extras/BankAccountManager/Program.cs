using System;
using BankAccountManager;

namespace BankAccountManager;

public class Program
{
    public static void Main(string[] args)
    {
        Account myAccount = new Account("123456789");

        Console.WriteLine($"Welcome to the Bank Account Manager!");
        Console.WriteLine($"Account Number: {myAccount.GetAccountNumber()}");
        Console.WriteLine($"Initial Balance: {myAccount.GetBalance():C}");

        Console.WriteLine("\nDepositing $100.00...");
        myAccount.Deposit(100.00m);
        Console.WriteLine($"New Balance: {myAccount.GetBalance():C}");

        Console.WriteLine("\nWithdrawing $50.00...");
        myAccount.Withdraw(50.00m);
        Console.WriteLine($"New Balance: {myAccount.GetBalance():C}");

        Console.WriteLine("\nWithdrawing $200.00 (should not work)...");
        myAccount.Withdraw(200.00m);
        Console.WriteLine($"New Balance: {myAccount.GetBalance():C}");

        Console.WriteLine("\nFinal Balance: {myAccount.GetBalance():C}");
    }
}
