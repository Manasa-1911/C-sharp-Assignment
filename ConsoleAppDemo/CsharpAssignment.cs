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
            int first;
            int second;
            string name;
            int age;
            Console.WriteLine("Enter first number");
            firstno = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second number");
            secondno = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Third number");
            thirdno = int.Parse(Console.ReadLine());
            multiply = firstno * secondno * thirdno;
            Console.WriteLine("The Multiplication of three nos are " + multiply);
            Console.WriteLine("-------------------------");
            Console.WriteLine("Second Question");
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

            Console.WriteLine("-------------------------");
            Console.WriteLine("Fourth Question");
            Console.WriteLine("Enter your name");
            name = Console.ReadLine();
            Console.WriteLine("The count of name is " +name.Length);

            Console.WriteLine("-------------------------");
            Console.WriteLine("Sixth Question");
            Console.WriteLine("The current date and time is: ");
            DateTime now = DateTime.Now;
            Console.WriteLine(now);

            Console.WriteLine("-------------------------");
            Console.WriteLine("Seventh Question");
            Console.WriteLine("Enter your age");
            age = int.Parse(Console.ReadLine());
            age = age + 10;
            Console.WriteLine("Age after 10 years is " +age);

            

        }
    }
}


