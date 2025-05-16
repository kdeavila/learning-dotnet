using Microsoft.VisualStudio.TestTools.UnitTesting;
using AccountingSystem;

namespace AccountingSystem.Tests
{
    [TestClass]
    public class CheckingAccountTest
    {
        private decimal GetBalance(Account account)
        {
            var prop = typeof(Account).GetProperty("Balance", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic |
              System.Reflection.BindingFlags.Public);

            return (decimal)prop.GetValue(account)!;
        }

        [TestMethod]
        public void Deposit_PositiveAmount_IncreasesBalance()
        {
            var account = new CheckingAccount(1, 1000m);
            account.Deposit(500m);
            Assert.AreEqual(1500m, GetBalance(account));
        }

        [TestMethod]
        public void Deposit_NegativeAmount_DoesNotChangeBalance()
        {
            var account = new CheckingAccount(1, 1000m);
            var sw = new StringWriter();
            Console.SetOut(sw);
            account.Deposit(-500m);
            Assert.AreEqual(1000m, GetBalance(account));
            StringAssert.Contains(sw.ToString(), "Deposit amount must be positive.");
        }

        [TestMethod]
        public void Transfer_ValidAmount_UpdatesBoth()
        {
            var sourceAccount = new CheckingAccount(1, 1000m);
            var targetAccount = new CheckingAccount(2, 500m);
            sourceAccount.Transfer(targetAccount, 300m);
            Assert.AreEqual(700m, GetBalance(sourceAccount));
            Assert.AreEqual(800m, GetBalance(targetAccount));
        }

        [TestMethod]
        public void Transfer_TooLargeAmount_NoChange()
        {
            var sourceAccount = new CheckingAccount(1, 1000m);
            var targetAccount = new CheckingAccount(2, 500m);
            sourceAccount.Transfer(targetAccount, 1200m);
            Assert.AreEqual(1000m, GetBalance(sourceAccount));
            Assert.AreEqual(500m, GetBalance(targetAccount));
        }

        [DataTestMethod]
        [DataRow(100,0.10,10.0)]
        [DataRow(50,0.05,2.5)]
        public void CalculateInterest_CorrectRate(double initialBalance, double rate, double expectedInterest)
        {
            var account = new CheckingAccount(1, (decimal)initialBalance);
            var interest = account.CalculateInterest((decimal)rate);
            Assert.AreEqual((decimal)expectedInterest, interest, 0.0001m);
        }
    }

    [TestClass]
    public class PremiumAccountTests
    {
        [TestMethod]
        public void CalculateInterest_Rate10Percent_Returns11() { 
            var acct = new PremiumAccount(1, 100m);
            var interest = acct.CalculateInterest(0.10m);
            Assert.AreEqual(11m, interest, 0.0001m);
        }

        [TestMethod]
        public void CalculateInterest_Rate5Percent_Returns9()
        {
            var acct = new PremiumAccount(1, 150m);
            var interest = acct.CalculateInterest(0.05m);
            Assert.AreEqual(9m, interest, 0.0001m);
        }
    }
}