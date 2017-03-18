using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1;

namespace Task1Tests
{
    [TestFixture]
    public class WorkingWithArraysTests
    {
        #region SearchIndex
        [TestCase(new int[] { 1, 2, 3, 4, 3, 2, 1 }, ExpectedResult = 3)]
        [TestCase(new int[] { 1, 100, 50, -51, 1, 1 }, ExpectedResult = 1)]
        public int SearchIndex_PositiveTest(int[] arr)
        {
            return WorkingWithArrays.SearchIndex(arr);
        }


        [TestCase(new int[] { 1, 2 }, ExpectedResult = -1)]
        [TestCase(new int[] { 1, 100, 50, -51, 1, 1, 20 }, ExpectedResult = -1)]
        public int SearchIndex_NegativeTest(int[] arr)
        {
            return WorkingWithArrays.SearchIndex(arr);
        }


        [TestCase(null)]
        public void SearchIndex_ArgumentNullException(int[] arr)
        {
            Assert.Throws<ArgumentNullException>(() => WorkingWithArrays.SearchIndex(arr));
        }
        #endregion
    }
}
