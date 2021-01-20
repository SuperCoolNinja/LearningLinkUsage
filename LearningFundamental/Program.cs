using System;
using System.Collections.Generic;
using System.Linq; //Link added.

namespace LearningFundamental
{
    class Program
    {
        static void Main(string[] args)
        {
            //Table :
            var myTable = new List<int>() { 50, 60, 90, 30, 150};
            NumberPair(myTable);
        }

        //Even number
        public static void NumberPair(List<int> number)
        {
            var numberPair = number.Where(x => x % 2 == 0);
            foreach (var i in numberPair)
            {
                Console.WriteLine(i);
            }
        }

        //Odd number
        public static void NumberImPair(List<int> number)
        {
            var numberInPair = number.Where(x => x % 1 == 0);
            foreach(var i in numberInPair)
            {
                Console.WriteLine(i);
            }
        }

        //Increasing number
        public static void ClassementParOrdre(List<int> number)
        {
            var myNumber = number.OrderByDescending(x => x);
            foreach(var i in myNumber)
            {
                Console.WriteLine(i);
            }
        }

        //Decreasing number
        public static void DeclassementNumber(List<int> number)
        {
            var myNumber = number.OrderBy(x => x);
            foreach(var i in myNumber)
            {
                Console.WriteLine(i);
            }
        }
    }
}
