using System;

namespace MilesPerGallon
{
    class Program
    {
        static void Main(string[] args)
        {
            double miles;
            double gallons;
            string input;

            Console.WriteLine("How many miles did you drive?: ");
            input = Console.ReadLine();
            miles = double.Parse(input);

            Console.WriteLine("How many gallons of gas did you consume?: ");
            input = Console.ReadLine();
            gallons = double.Parse(input);

            double milesPerGallon = miles / gallons;

            Console.WriteLine("You did: " + milesPerGallon + " miles per gallon");

        }
    }
}
