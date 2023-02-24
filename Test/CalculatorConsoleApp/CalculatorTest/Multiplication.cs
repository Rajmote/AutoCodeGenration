
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MultiplicationUnitTest
{
    [TestClass]
    public class MultiplicationUnitTest
    {
        [TestMethod]
        public void Multiply_10And10_Returns100()
        {
            //Arrange
            var mul = new CalculatorConsoleApp.Multiplication();
            int num1 = 10;
            int num2 = 10;
            int expectedResult = 100;

            //Act
            int actualResult = mul.Multiply(num1, num2);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Multiply_3And5_Returns15()
        {
            //Arrange
            var mul = new CalculatorConsoleApp.Multiplication();
            int num1 = 3;
            int num2 = 5;
            int expectedResult = 15;

            //Act
            int actualResult = mul.Multiply(num1, num2);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}