using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1;
using Task2;
using Task3;

namespace TestingTasks1_3.CUI
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Testing Task1
            Console.WriteLine("Task 1");
            int[] arr = new int[] { 1, 2, 3, 4, 3, 2, 1 };
            Console.WriteLine(WorkingWithArrays.SearchIndex(arr));
            arr = new int[] { 1, 100, 50, -51, 1, 1 };
            Console.WriteLine(WorkingWithArrays.SearchIndex(arr));
            //arr = null;
            //Console.WriteLine(WorkingWithArrays.SearchIndex(arr));
            #endregion

            #region Testing Task2
            Console.WriteLine("Task 2");
            string a =null, b=null;
            //string a = "xyaabbbccccdefww";
            //string b = "++xxxxyyyyabklmopq";            
            //Console.WriteLine(WorkingWithString.StringConcat(a, b));
            a = "xyaabbbccccdefww";
            b = "xxxxyyyyabklmopq";
            Console.WriteLine(WorkingWithString.StringConcat(a, b));
            #endregion

            #region Testing Task3
            Console.WriteLine("Task 3");
            Console.WriteLine(BinaryOperations.BinaryNumbersOperation(8, 15, 0, 0));
            Console.WriteLine(BinaryOperations.BinaryNumbersOperation(0, 15, 0, 30));
            Console.WriteLine(BinaryOperations.BinaryNumbersOperation(-8, -15, 1, 4));
            Console.WriteLine(BinaryOperations.BinaryNumbersOperation(15, int.MaxValue, 3, 5));
            //Console.WriteLine(BinaryOperations.BinaryNumbersOperation(15, int.MaxValue, 5, 3));
            #endregion
        }
    }
}
