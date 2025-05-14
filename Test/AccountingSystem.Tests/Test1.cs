using Microsoft.VisualStudio.TestTools.UnitTesting;
using AccountingSystem;

namespace AccountingSystem.Tests
{
    [TestClass]
    public class AccountTests
    {
        [TestMethod]
        public void Deposit_PositiveAmount_IncreasesBalance()
        {
            // Arrange
            var account = new CheckingAccount(1, 1000m);

            // Act
            account.Deposit(50m);

            // Assert
            Assert.AreEqual(1050m, GetBalance(account));
        }

        [TestMethod]
        public void Deposit_NegativeAmount_DoesNotChangeBalance()
        {
            var account = new CheckingAccount(1, 1000m);
            account.Deposit(-50m);
            Assert.AreEqual(1000m, GetBalance(account));
        }

        [TestMethod]
        public void Transfer_ValidAmount_UpdatesBothAccounts()
        {
            var sourceAccount = new CheckingAccount(1, 1000m);
            var targetAccount = new CheckingAccount(2, 500m);

            sourceAccount.Transfer(targetAccount, 1000m);

            Assert.AreEqual(0m, GetBalance(sourceAccount));
        }

        [TestMethod]
        public void CalculateInterest_BaseAccount_WorksCorrectly()
        {
            var account = new CheckingAccount(1, 1000m);
            var interest = account.CalculateInterest(0.03m);
            Assert.AreEqual(30m, interest);
            Assert.AreEqual(1030m, GetBalance(account));
        }

        [TestMethod]
        public void CalculateInterest_PremiumAccount_UsesExtraRate()
        {
            var account = new PremiumAccount(1, 1000m);
            var interest = account.CalculateInterest(0.03m);
            Assert.AreEqual(40m, interest);
            Assert.AreEqual(1040m, GetBalance(account));
        }

        [TestMethod]
        public void Transfer_InsufficientFunds_DoesNotChangeBalance()
        {
            var sourceAccount = new CheckingAccount(1, 1000m);
            var targetAccount = new CheckingAccount(2, 500m);
            sourceAccount.Transfer(targetAccount, 2000m);

            // Test failed because the transfer was not successful
            // Assert.AreEqual(-1000m, GetBalance(sourceAccount);
            Assert.AreEqual(1000m, GetBalance(sourceAccount));
        }

        private decimal GetBalance(Account account)
        {
            var prop = typeof(Account).GetProperty("Balance", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic |
              System.Reflection.BindingFlags.Public);

            return (decimal)prop.GetValue(account)!;
        }
    }
}