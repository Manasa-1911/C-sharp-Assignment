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
            int firstno;
            int secondno;
            int thirdno;
            int multiply;
            Console.WriteLine("Enter first number");
            firstno = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second number");
            secondno = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Third number");
            thirdno = int.Parse(Console.ReadLine());
            multiply = firstno * secondno * thirdno;
            Console.WriteLine("The Multiplication of three nos are " + multiply);
        }
    }
}