using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    /// <summary>
    /// This class works with binary operations
    /// </summary>
    public static class BinaryOperations
    {
        #region Inserting number
        /// <summary>
        /// This method changes bits in first number by inserting bits of second number to the specified position.
        /// </summary>
        /// <param name="firstNumber">The argument accepts the first number</param>
        /// <param name="secondNumber">The argument accepts the second number</param>
        /// <param name="leftPosition">The argument accepts the position of left bit from which the change begins</param>
        /// <param name="rightPosition">The argument accepts the position of right bit on which the change finishes</param>
        /// <returns>This metod returns the result of inserting - the number of integer</returns>
        public static int BinaryNumbersOperation(int firstNumber, int secondNumber, int leftPosition, int rightPosition)
        {
            BitArray firstNumberBin = new BitArray(new int[] { firstNumber });
            BitArray secondNumberBin = new BitArray(new int[] { secondNumber });
            if (leftPosition > rightPosition)
                throw new IndexOutOfRangeException();
            int j = 0;
            for (int i = leftPosition; i <= rightPosition; i++)
            {
                firstNumberBin[i] = secondNumberBin[j];
            }
            int[] number = new int[1];
            firstNumberBin.CopyTo(number, 0);
            return number[0];
        }
        #endregion
    }
}
