using System;

namespace RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            int sideA;
            int sideB;
            string input1;
            string input2;
           
            Console.WriteLine("What are the dimensions of the rectangle?: ");
           
            input1 = Console.ReadLine();
            sideA = int.Parse(input1);
            
            input2 = Console.ReadLine();
            sideB = int.Parse(input2);
            
            int area = sideA * sideB;
            
            Console.WriteLine("The area of the rectangle is: " + area);
        }
    }
}
