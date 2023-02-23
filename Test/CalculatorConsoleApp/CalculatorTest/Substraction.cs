
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorConsoleApp.Tests
{
    [TestClass]
    public class SubstractionTests
    {
        [TestMethod]
        public void Substract_ForPositiveResult_ReturnPositiveNumber()
        {
            // Arrange 
            int a = 5;
            int b = 4;
            int expected = 1;
            var substraction = new Substraction();

            // Act 
            int actual = substraction.Substract(a, b);

            // Assert 
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void Substract_ForNegativeResult_ReturnNegativeNumber()
        {
            // Arrange 
            int a = 4;
            int b = 5;
            int expected = -1;
            var substraction = new Substraction();

            // Act 
            int actual = substraction.Substract(a, b);

            // Assert 
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Substract_ForZeroResult_ReturnZeroNumber()
        {
            // Arrange 
            int a = 5;
            int b = 5;
            int expected = 0;
            var substraction = new Substraction();

            // Act 
            int actual = substraction.Substract(a, b);

            // Assert 
            Assert.AreEqual(expected, actual);
        }
    }
}