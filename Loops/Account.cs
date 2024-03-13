using System;
using Classes;

class Account
{
    static void Main(string[] args)
    {
        var account = new BankAccount("abc", 500);
        Console.WriteLine($"Account has been created with {account.Number} for {account.Owner} with {account.Balance}");
        account.MakeWithdrawal(100, DateTime.Now, "test");
        Console.WriteLine($"Account balance {account.Balance}");
        account.MakeWithdrawal(50, DateTime.Now, "game");
Console.WriteLine($"Account balance {account.Balance}");

        Console.WriteLine(account.GetAccountHistory());

        // Test that the initial balances must be positive.
//BankAccount invalidAccount;
try
{
    var invalidAccount = new BankAccount("invalid", -55);
}
catch (ArgumentOutOfRangeException e)
{
    Console.WriteLine("Exception caught creating account with negative balance");
    //Console.WriteLine(e.ToString());
    
}

    }
}