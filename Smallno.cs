using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDemo
{
    internal class smallno
    {
        public static void SmallNo(int firstno, int secondno,out int small)
        {
      
            if (firstno < secondno)
            {

                small = firstno;

            }
            else 
                small=secondno;
                
            }
                
        

        public static void Main()
        {
            int firstno, secondno, small;
            Console.WriteLine("Enter first no");
            firstno = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second no");
            secondno = int.Parse(Console.ReadLine());
            SmallNo(firstno,secondno,out small);
            Console.WriteLine($"The smallest no is {small}");
        }
    }

}
