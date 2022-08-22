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
           int first;
           int second;
           Console.WriteLine("Enter first no");
           first = int.Parse(Console.ReadLine());
           Console.WriteLine("Enter Second no");
           second = int.Parse(Console.ReadLine());
           if (first < second)
           {
                Console.WriteLine("The small no is " + first);

           }
           else
                Console.WriteLine("The small no is " + second);
         }
     }
}