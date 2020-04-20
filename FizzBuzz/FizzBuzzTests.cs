using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz
{
    [TestClass]
    public class FizzBuzzTests
    {
        [DataTestMethod]
        [DataRow("Fizz",3)]
        [DataRow("Fizz", 6)]
        [DataRow("Buzz", 5)]
        [DataRow("Buzz", 10)]
        [DataRow("", 7)]
        [DataRow("FizzBuzz", 15)]
        public void FizzBuzz_PositiveInteger_ReturnsValidString(string expected , int n)
        {
            //Arrange
            FizzBuzz v = new FizzBuzz();

            //Act
            string result = v.GetFizzBuzz(n);

            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
