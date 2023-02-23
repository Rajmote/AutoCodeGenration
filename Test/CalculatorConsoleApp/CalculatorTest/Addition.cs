

            using Microsoft.VisualStudio.TestTools.UnitTesting;
            using CalculatorConsoleApp;

            namespace CalculatorConsoleAppTest
            {
                 [TestClass]
                 public class AdditionTest
                 {
                     Addition _Addition = new Addition();

                     [TestMethod]
                     public void Test_Add_Two_Numbers() 
                     {
                         //Arrange
                         int a = 5;
                         int b = 5;

                         //Act 
                         var result = _Addition.Add(a,b);

                         //Assert
                         Assert.AreEqual(result, 10);
                     }

                     [TestMethod]
                     public void Test_Add_Two_Numbers_Expect_Negative_Number() 
                     {
                         //Arrange
                         int a = -2;
                         int b = -3;

                         //Act 
                         var result = _Addition.Add(a,b);

                         //Assert
                         Assert.AreEqual(result, -5);
                     }

                     [TestMethod]
                     public void Test_Add_Two_Numbers_Expect_Positive_Number() 
                     {
                         //Arrange
                         int a = 2;
                         int b = 3;

                         //Act 
                         var result = _Addition.Add(a,b);

                         //Assert
                         Assert.AreEqual(result, 5);
                     }

                     [TestMethod]
                     public void Test_Add_Two_Numbers_Expect_Zero() 
                     {
                         //Arrange
                         int a = 2;
                         int b = -2;

                         //Act 
                         var result = _Addition.Add(a,b);

                         //Assert
                         Assert.AreEqual(result, 0);
                     }
                 }
            }