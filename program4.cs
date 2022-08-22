using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDemo
{
    internal class CsharpAssignment
    {
        public static void Main()
        {
            string name;
            Console.WriteLine("Enter your name");
            name = Console.ReadLine();
            Console.WriteLine("The count of name is " +name.Length);
        }
    }
}
