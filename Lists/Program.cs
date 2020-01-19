using System;
using System.Collections.Generic;
using System.Linq;

namespace Lists
{
    class Program
    {
        static int SumOfEvens(int[] integers)
        {
            int result = 0;

            foreach (int i in integers)
                if (i % 2 == 0)
                    {
                    result += i;
                }
                return result;
        }
        static void Main(string[] args)
        {
            //declare the list new List();
            int [] myList = {2, 5, 8, 7, 13, 16, 6, 4, 19, 22};
            Console.WriteLine(SumOfEvens(myList));
        }
    }
}
