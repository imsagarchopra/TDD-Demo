using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void AddTwoNumbers_ValidNumbers_ReturnsTheResult()
        {
            //Arrange
            var v = new Calculator();

            //Act
            int result = v.AddTwoNumbers(1,3);

            //Assert
            Assert.AreEqual(4, result);

        }
    }
}
