using System;

public class BankAccount
{
    // Private fields to store account details
    private string accountNumber;
    private string accountHolder;
    private decimal balance;

    // Constructor to initialize the account details
    public BankAccount(string accountNumber, string accountHolder, decimal initialBalance)
    {
        this.accountNumber = accountNumber;
        this.accountHolder = accountHolder;
        balance = initialBalance;
    }

    // Public method to deposit money into the account
    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine($"Deposited: {amount:C}. Current balance: {balance:C}"); // :C format specifier
        }
        else
        {
            Console.WriteLine("Invalid amount for deposit.");
        }
    }

    // Public method to withdraw money from the account
    public void Withdraw(decimal amount)
    {
        if (amount > 0 && amount <= balance)
        {
            balance -= amount;
            Console.WriteLine($"Withdrawn: {amount:C}. Current balance: {balance:C}");
        }
        else
        {
            Console.WriteLine("Insufficient funds or invalid amount for withdrawal.");
        }
    }

    // Public method to display account details
    public void DisplayAccountInfo()
    {
        Console.WriteLine($"Account Number: {accountNumber}");
        Console.WriteLine($"Account Holder: {accountHolder}");
        Console.WriteLine($"Current Balance: {balance:C}");
    }
}

public class Program
{
    public static void Main()
    {
        // Create a new bank account
        BankAccount myAccount = new BankAccount("123456789", "Suman Khadka", 1000.0m);

        // Deposit and withdraw money
        myAccount.Deposit(500.0m);
        myAccount.Withdraw(200.0m);

        // Display account information
        myAccount.DisplayAccountInfo();
        Console.ReadLine();
    }
}
