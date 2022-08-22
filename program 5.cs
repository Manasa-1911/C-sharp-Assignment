using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDemo
{
    internal class StringReplace
    {
        static void Main(string[] args)
        {
            Console.WriteLine(first_last("Manasa"));
        }
        public static string first_last(string s)
        {
            return s.Length > 1
            ? s.Substring(s.Length - 1) + s.Substring(1, s.Length - 2) + s.Substring(0, 1) : s;
        }
    }
}
