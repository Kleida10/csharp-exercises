using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 1, 2, 3, 5, 8 };

            foreach (int i in numbers)
                Console.WriteLine(i);
          }
    }
}
