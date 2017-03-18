using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task3;

namespace Task3TestsMSUnit
{
    [TestClass]
    public class BinaryOperationsTests
    {
        #region BinaryNumbersOperations
        [TestMethod]
        public void BinaryNumbersOperations_PositiveTest()
        {
            int first, second, leftPosition, rightPosition;
            first = 15;
            second = int.MaxValue;
            leftPosition = 3;
            rightPosition = 5;
       
            int expected = 63;
            int actual = BinaryOperations.BinaryNumbersOperation(first, second, leftPosition, rightPosition);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void BinaryNumbersOperations_LeftMoreRight_Exception()
        {
            int first, second, leftPosition, rightPosition;
            first = 8;
            second = 15;
            leftPosition = 7;
            rightPosition = 6;

            int actual = BinaryOperations.BinaryNumbersOperation(first, second, leftPosition, rightPosition);
        }
        #endregion
    }
}
