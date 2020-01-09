using System;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                double radius;
                string input;

                Console.WriteLine("What is the radius?: ");
                input = Console.ReadLine();

                radius = double.Parse(input);
                if (radius < 0)
                {
                    Console.WriteLine("Incorrect number. Please input a positive number.");
                }
                else
                {
                    double area = 3.14 * radius * radius;
                    Console.WriteLine("The area of a circle with radius " + radius + " is " + area);
                    break;
                }

            }
            

               
        }
    }
}
