using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDemo
{
    internal class Negativenumbers
    {
        public static void Main()
        {
            int[] arr = { 1,-3,4,6,-8,-10 };
            int i, n;
            n = arr.Length;
            for (i = 0; i < n; i++)
            {
                if (arr[i] < 0)
                {
                    Console.Write($"{arr[i]}");
                }

            }
        }
    }
}