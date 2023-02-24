
// # Sample MSTest test case

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    namespace CalculatorConsoleApp
    {
        [TestClass]
        public class DivisionTests
        {
            [TestMethod]
            public void DivideByZero_ThrowsArithmeticException()
            {
                Division div = new Division();
                Assert.ThrowsException<DivideByZeroException>(
                    () => div.Divide(19, 0));
            }

            [TestMethod]
            public void Divide_DividesNumbersCorrectly()
            {
                Division div = new Division();
                Assert.AreEqual(2, div.Divide(4, 2));
            }
        }
    }