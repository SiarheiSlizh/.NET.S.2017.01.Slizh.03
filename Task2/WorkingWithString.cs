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
        /// <returns>The concatination of two strings</returns>
        public static string StringConcat(string firstString, string secondString)
        {
            if (Equals(firstString, null) || Equals(secondString, null)) 
                throw new ArgumentNullException();

            if (!firstString.IsAmericanSymbolsToLower() || !secondString.IsAmericanSymbolsToLower())
                throw new ArgumentException();

            char[] str = string.Concat(firstString, secondString).Distinct().ToArray();
            Array.Sort(str);
            return new string(str);
        }

        /// <summary>
        /// This method checks strings for validity
        /// </summary>
        /// <param name="str">String in which is checked wether it contains american symbols.</param>
        /// <returns>True if string contains symbols in range of a-z else false.</returns>
        static bool IsAmericanSymbolsToLower(this string str)
        {
            int i = 0;
           
            while (i < str.Length)
            {
                if (str[i] < 97 || str[i] > 122)
                    return false;
                i++;
            }
            return true;
        }
        #endregion
    }
}