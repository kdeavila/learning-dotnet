Account account = new Account("John Doe");
Account demoAccount = new Account("John Doe", 20);

Console.WriteLine($"Account Owner: {account.Owner}, Balance: {account.Balance}");
Console.WriteLine($"Demo Account Owner: {demoAccount.Owner}, Balance: {demoAccount.Balance}");

public class Account
{
    public string Owner { get; set; }
    public int Balance { get; set; }

    public Account(string owner)
    {
        Owner = owner;
        Balance = 0;
    }

    public Account(string owner, int balance)
    {
        Owner = owner;
        Balance = balance;
    }
}