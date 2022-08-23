using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDemo
{
    internal class inputnumber
    {
        public static int SumOfNo(int num)
        {
            int sum = 0;
            while (num != 0)
            {
                sum += num % 10;
                num = num / 10;
            }
            return sum;
        }
        public static int ReverseNo(int n)
        {
            int reverse = 0, remainder;
            while (n != 0)
            {
                remainder = n % 10;
                reverse = reverse * 10 + remainder;
                n /= 10;
            }
            return reverse;
        }
        public static void Main()
        {
                int number;
                Console.WriteLine("Enter a number");
                number = int.Parse(Console.ReadLine());
                int sum = SumOfNo(number);
                Console.WriteLine($"Sum of numbers are {sum}");
                int rev = ReverseNo(number);
                Console.WriteLine($"Reverse of a number is {rev}");
         }
     }
}
