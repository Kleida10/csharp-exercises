using System;
using System.Collections.Generic;
using System.Linq;

namespace CountingChars
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin." +
                 "Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat.Donec sit amet suscipit metus, " +
                 "non lobortis massa.Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. " +
                 "Donec nec velit non ligula efficitur luctus.";
           
            // Console.WriteLine("What is your text?: ");
            //string text = Console.ReadLine();

            //string text = System.IO.File.ReadAllText(@"C:\Users\kleida\Desktop\NewTextDocument.txt");

         Dictionary<char, int> charCount = new Dictionary<char, int>();

            foreach (char c in text.ToLower())
                if (char.IsLetter(c))
                {
                    if (charCount.ContainsKey(c))
                    {
                        charCount[c]++;
                    }
                    else
                    {
                        charCount.Add(c, 1);
                    }
                }
            foreach (char c in charCount.Keys)
                Console.WriteLine(c + ": " + charCount[c].ToString());
           
        }
    }
}
