using Microsoft.VisualStudio.TestTools.UnitTesting;
using LearnMyCalculatorApp;

namespace LearnMyCalculatorApp.Tests
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void CalculatorNullTest()
        {
            var calculator = new Calculator();
            Assert.IsNotNull(calculator);
        }

        [TestMethod]
        public void AddTest()
        {
            var calculator = new Calculator();
            int actual = calculator.Add(1, 1);
            Assert.AreEqual(actual, 2);
        }

        [TestMethod]
        public void SubtractTest()
        {
            var calculator = new Calculator();
            int actual = calculator.Subtract(2, 1);
            Assert.AreEqual(actual, 1);
        }

        [TestMethod]
        public void MultiplyTest()
        {
            var calculator = new Calculator();
            int actual = calculator.Multiply(2, 1);
            Assert.AreEqual(actual, 2);
        }

        [TestMethod]
        public void DivideTest()
        {
            var calculator = new Calculator();
            var actual = calculator.Divide(2, 1);
            Assert.AreEqual(actual, 2);
        }

        [TestMethod]
        public void DivideByZeroTest()
        {
            var calculator = new Calculator();
            var actual = calculator.Divide(2, 0);
            Assert.IsNull(actual);
        }
    }
}
