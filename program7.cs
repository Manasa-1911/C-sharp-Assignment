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
            int age;
            Console.WriteLine("Enter your age");
            age = int.Parse(Console.ReadLine());
            age = age + 10;
            Console.WriteLine("Age after 10 years is " +age);
        }
     }
}