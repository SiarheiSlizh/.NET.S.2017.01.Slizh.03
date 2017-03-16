using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    /// <summary>
    /// This class works with arrays
    /// </summary>
    public static class WorkingWithArrays
    {
        #region Search index between two parts of arrays which have the same sum of elements
        /// <summary>
        /// This method finds the index of array where the sum of elements from left part is the same as right part.
        /// </summary>
        /// <param name="arr">The argument accepts the array of integer.</param>
        /// <returns>This method returns index or value '-1' in case index is not found.</returns>
        public static int SearchIndex(int[] arr)
        {
            if (Equals(arr, null)) 
                throw new ArgumentNullException("Reference doesn't point to array");
            if (arr.Length < 3 || arr.Length > 1000) return -1;
            int sum, sumLeft;
            sum = sumLeft = 0;
            for (int i = 0; i < arr.Length; i++)
                sum += arr[i];
            for (int i = 1; i < arr.Length - 1; i++)
            {
                sumLeft += arr[i - 1];
                if (sumLeft.Equals((sum - arr[i]) / 2)) return i;
            }
            return -1;
        }
        #endregion
    }
}
