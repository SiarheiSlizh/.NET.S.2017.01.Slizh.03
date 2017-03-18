using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    /// <summary>
    /// This class works with strings
    /// </summary>
    public static class WorkingWithString
    {
        #region concatenating strings
        /// <summary>
        /// This method concatinates two strings Without repetition of symbols.
        /// </summary>
        /// <param name="firstString">This argument accepts the reference which point to first string</param>
        /// <param name="secondString">This argument accepts the reference which point to second string</param>
        /// <returns>This method returns the concatination of two strings</returns>
        public static string StringConcat(string firstString, string secondString)
        {
            if (Equals(firstString, null) || Equals(secondString, null)) 
                throw new ArgumentNullException();

            CheckStrings(firstString, secondString);

            char[] str = string.Concat(firstString, secondString).Distinct().ToArray();
            Array.Sort(str);
            return new string(str);
        }
        /// <summary>
        /// This method checks strings for validity
        /// </summary>
        /// <param name="firstString">This argument accepts the reference which point to first string</param>
        /// <param name="secondString">This argument accepts the reference which point to second string</param>
        static void CheckStrings(string firstString, string secondString)
        {
            int i = 0;
            while (i < firstString.Length && i < secondString.Length)
            {
                if (firstString[i] < 97 || firstString[i] > 122 || secondString[i] < 97 || secondString[i] > 122)
                    throw new ArgumentException("Strings have to consists of symbols a-z");
                i++;
            }
            while(i < firstString.Length)
            {
                if (firstString[i] < 97 || firstString[i] > 122)
                    throw new ArgumentException("Strings have to consists of symbols a-z");
                i++;
            }
            while (i < secondString.Length)
            {
                if (secondString[i] < 97 || secondString[i] > 122)
                    throw new ArgumentException("Strings have to consists of symbols a-z");
                i++;
            }
        }
        #endregion
    }
}