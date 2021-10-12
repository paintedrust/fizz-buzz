using System;
using System.Collections.Generic;

namespace FizzBuzz
{
    class Program
    {
        private static readonly Dictionary<int, string> MyDictionary = new Dictionary<int, string>()
        {
            { 3, "Fizz" },
            { 5, "Buzz" },
            { 7, "Woof" }
        };


        static void Main(string[] args)
        {
            BasicFizzBuzz();
            FizzBuzzWithDictionary();
        }       

        private static void BasicFizzBuzz()
        {
            Console.WriteLine("Simple FizzBuzz\n---\n");
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static void FizzBuzzWithDictionary()
        {
            Console.WriteLine("\nFizzBuzz with values from Dictionary\n---\n");
            for (int i = 1; i <= 100; i++)
            {
                var str = "";

                foreach (KeyValuePair<int, string> entry in MyDictionary)
                {
                    str += i % entry.Key == 0 ? entry.Value : "";
                }

                str = str == "" ? i.ToString() : str;
                Console.WriteLine(str);
            }
        }

    }
}
