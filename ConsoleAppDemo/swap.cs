using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDemo
{
    internal class swap
    {
        public static void SwapNo(ref int firstno, ref int secondno)
        {
            int temp;
            temp = firstno;
            firstno = secondno;
            secondno = temp;
        }

        public static void Main()
        {
            int firstno = 5;
            int secondno = 10;
            Console.WriteLine($"Before Swapping a={firstno},b={secondno}");
            SwapNo(ref firstno, ref secondno);
            Console.WriteLine($"After Swapping a={firstno},b={secondno}");
        }
    }
}
