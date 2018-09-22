using System;
using System.Collections.Generic;

namespace myApp
{
    class Program
    {
        // Start test delegate:
        public delegate string HelloName(string name);

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World, start testing Blazor");

            var names = new List<string> { "Arno", "Jacq", "Jen" };
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }

            TestDelegate(names);           
        }

        static void TestDelegate(List<string> names)
        {
            string firstName, secondName;

            HelloName delInstHelloName = PrintName;
            firstName = delInstHelloName(names[0]);
            secondName = delInstHelloName(names[1]);

            Console.WriteLine($"Hallo: {firstName.ToString()} and {secondName.ToString()}");
        }

        static string PrintName(string name)
        {
            return name.ToUpper();
        }


    }
}

