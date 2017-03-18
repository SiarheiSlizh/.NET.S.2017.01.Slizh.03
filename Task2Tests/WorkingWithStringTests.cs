using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2;

namespace Task2Tests
{
    [TestFixture]
    public class WorkingWithStringTests
    {
        #region StringConcat
        [TestCase("fanuirf","fhuiul",ExpectedResult = "afhilnru")]
        [TestCase("ggggfa","",ExpectedResult = "afg")]
        [TestCase("po","ni",ExpectedResult = "inop")]
        public string StringConcat_PositiveTest(string firstString, string secondString)
        {
            return WorkingWithString.StringConcat(firstString, secondString);
        }
        
        [TestCase(null,"derfer")]
        [TestCase("lsfs",null)]
        [TestCase(null,null)]
        public void StringConcat_ArgumentNullException(string firstString, string secondString)
        {
            Assert.Throws<ArgumentNullException>(() => WorkingWithString.StringConcat(firstString, secondString));
        }

        [TestCase("sdfsdf0","ds")]
        [TestCase(")","")]
        [TestCase("Afsf","fre")]
        public void CheckStrings_ArgumentException(string firstString, string secondString)
        {
            Assert.Throws<ArgumentException>(() => WorkingWithString.StringConcat(firstString, secondString));
        }
        #endregion
    }
}
