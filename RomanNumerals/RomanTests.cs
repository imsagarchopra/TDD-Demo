using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RomanNumerals
{
    [TestClass]
    public class RomanTests
    {
        [DataTestMethod]
        [DataRow(1,"I")]
        [DataRow(2, "II")]
        [DataRow(4, "IV")]
        [DataRow(5, "V")]
        [DataRow(6, "VI")]
        [DataRow(10, "X")]
        [DataRow(9, "IX")]
        [DataRow(13, "XIII")]
        public void RomanParse_RomanString_ReturnsInteger(int expected , string r)
        {
            //Arrange
            Roman v = new Roman();

            //Act
            int result = v.RomanParse(r);

            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
