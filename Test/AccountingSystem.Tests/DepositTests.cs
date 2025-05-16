using Microsoft.VisualStudio.TestTools.UnitTesting;
using AccountingSystem;

namespace AccountingSystem.Tests
{
    [TestClass]
    public class DepositTests
    {
        [TestMethod]
        public void Deposit_PositiveAmount_IncreasesBalance()
        {
            var account = new CheckingAccount(1, 1000m);
            account.Deposit(500m);
            Assert.AreEqual(1500m, GetBalance(account));
        }

        private decimal GetBalance(Account account)
        {
            var prop = typeof(Account).GetProperty("Balance", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic |
              System.Reflection.BindingFlags.Public);

            return (decimal)prop.GetValue(account)!;
        }
    }
}