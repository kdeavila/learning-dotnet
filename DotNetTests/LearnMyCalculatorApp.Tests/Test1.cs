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
    }
}
