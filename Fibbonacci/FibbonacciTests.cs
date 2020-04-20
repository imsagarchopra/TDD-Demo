using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fibbonacci
{
    [TestClass]
    public class FibbonacciTests
    {
        [DataTestMethod]
        [DataRow(0,0)]
        [DataRow(1, 1)]
        [DataRow(1, 2)]
        [DataRow(2, 3)]
        [DataRow(3,4)]
        public void GetFibbonacci_PositiveInteger_ReturnsFibbonaci(int expected , int index)
        {
            //Arrange
            var v = new Fibbonacci();

            //Act
            int result = v.GetFibbonacci(index);

            //Assert
            Assert.AreEqual(expected, result);
            
        }
    }
}
