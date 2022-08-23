using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDemo
{
    internal class Multiplication
    {
        public static int multiply(int firstno,int secondno,int thirdno)
        {
            return firstno * secondno * thirdno;
        }
        public static void Main()
        {
            int first, second, third;
            Console.WriteLine("Enter first number");
            first = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second number");
            second = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Third number");
            third = int.Parse(Console.ReadLine());
            int mulof3nos = multiply(first, second, third);
            Console.WriteLine($"The Multiplication of three nos are {mulof3nos}");
        }
        
        
    }
}