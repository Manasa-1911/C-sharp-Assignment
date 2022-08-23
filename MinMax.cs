using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDemo
{
    internal class minmax
    {
        public static void Main()
        {
            int[] array = { 20, 15, 45, 30 };
            Console.WriteLine($"The Max no in a array is {array.Max()}");
            Console.WriteLine($"The Minimum no in a given array is {array.Min()}");
        }
    }
}