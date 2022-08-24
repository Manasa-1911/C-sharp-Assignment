using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDemo
{
    internal class array
    {
        public static void Main()
        {
            string key;
            string[] values = { "Manasa", "Chandana", "Ananya", "Priyanka", "Sandhya" };
            Console.WriteLine(values.Count());
            foreach(string name in values)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("What name do u want to search");
            key = Console.ReadLine();
            if (values.Contains(key))
            {
                Console.WriteLine($"{key} is present in the list");

            }
            else
                Console.WriteLine($"{key} is not present in the list");
        }
    }
}
