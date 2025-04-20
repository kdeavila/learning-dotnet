Console.WriteLine("Welcome to the Accounting System!");

CheckingAccount checkingAccount = new CheckingAccount(100, 0);
PremiumAccount premiumAccount = new PremiumAccount(200, 0);

checkingAccount.PrintBalance();
premiumAccount.PrintBalance();

checkingAccount.Deposit(2000);
premiumAccount.Deposit(6000);

checkingAccount.PrintBalance();
premiumAccount.PrintBalance();

premiumAccount.Transfer(checkingAccount, 2000);

checkingAccount.PrintBalance();
premiumAccount.PrintBalance();

Console.WriteLine($"Account1 interest: {checkingAccount.CalculateInterest(0.03m)}");
Console.WriteLine($"Account2 interest: {premiumAccount.CalculateInterest(0.03m)}");

checkingAccount.PrintBalance();
premiumAccount.PrintBalance();

public class Account
{
    public int Id { get; set; }
    protected decimal Balance { get; set; }

    public Account(int id, decimal balance)
    {
        Id = id;
        Balance = balance;
    }

    public void Deposit(decimal mount)
    {
        if (mount > 0)
        {
            Balance += mount;
        }
        else
        {
            Console.WriteLine("Deposit amount must be positive.");
        }
    }

    public void Transfer(Account toAccount, decimal mount)
    {
        if (mount > 0 && Balance >= mount)
        {
            Balance -= mount;
            toAccount.Deposit(mount);
        }
        else
        {
            Console.WriteLine("Transfer amount must be positive and less than or equal to the balance.");
        }
    }

    public virtual decimal CalculateInterest(decimal interestValue)
    {
        decimal interest = Balance * interestValue;
        Balance += interest;

        return interest;
    }

    public void PrintBalance()
    {
        Console.WriteLine($"Account ID: {Id}, Balance: {Balance}");
    }
}

public class CheckingAccount : Account
{
    public CheckingAccount(int id, decimal balance) : base(id, balance) { }
}

public class PremiumAccount : Account
{
    public PremiumAccount(int id, decimal balance) : base(id, balance) { }

    public override decimal CalculateInterest(decimal interestValue)
    {
        decimal interest = Balance * (interestValue + 0.01m);
        Balance += interest;

        return interest;
    }
}