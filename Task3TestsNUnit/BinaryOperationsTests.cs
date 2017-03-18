using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3;

namespace Task3TestsNUnit
{
    [TestFixture]
    public class BinaryOperationsTests
    {
        #region BinaryNumbersOperation
        [TestCase(8,15,0,0,ExpectedResult = 9)]
        [TestCase(0, 15, 30, 30, ExpectedResult = 1073741824)]
        [TestCase(0, 15, 0, 30, ExpectedResult = 2147483647)]
        [TestCase(int.MaxValue, int.MaxValue, 3, 5, ExpectedResult = int.MaxValue)]
        [TestCase(15, int.MaxValue, 3, 5, ExpectedResult = 63)]
        [TestCase(15, 15, 1, 3, ExpectedResult = 15)]
        [TestCase(15, 15, 1, 4, ExpectedResult = 31)]
        [TestCase(15, -15, 0, 4, ExpectedResult = 31)]
        [TestCase(15, -15, 1, 4, ExpectedResult = 31)]
        [TestCase(-8, -15, 1, 4, ExpectedResult = -2)]
        public int BinaryNumbersOperation_PositiveTest(int first, int second, int leftPosition, int rightPosition)
        {
            return BinaryOperations.BinaryNumbersOperation(first, second, leftPosition, rightPosition);
        }


        [TestCase(8, 15, -1, 5)]
        [TestCase(8, 15, -5, -1)]
        [TestCase(8, 15, 32, 34)]
        public void BinaryNumbersOperation_ThrowsArgumentOutOfRangeException(int first, int second, int leftPosition, int rightPosition)
        {
            Assert.Throws<ArgumentOutOfRangeException>(
                () => BinaryOperations.BinaryNumbersOperation(first, second, leftPosition, rightPosition));
        }

        [TestCase(8, 15, 5, -1)]
        [TestCase(8, 15, 32, 5)]
        public void BinaryNumbersOperation_TrowsArgumentException(int first, int second, int leftPosition, int rightPosition)
        {
            Assert.Throws<ArgumentException>(
                () => BinaryOperations.BinaryNumbersOperation(first, second, leftPosition, rightPosition));
        }
        #endregion
    }
}