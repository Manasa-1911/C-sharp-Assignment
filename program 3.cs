using System;
using System Collections Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDemo
{
   internal class vowels
   {
      public static void Main()
      {
            string s;
            int i, len, vowel_count, cons_count;
            s = "Sonata Software";
            vowel_count = 0;
            cons_count = 0;
            len = s.Length;
            for (i = 0; i < len; i++)
            {
                if (s[i] == 'a' || s[i] == 'e' || s[i] == 'i' || s[i] == 'o' || s[i] == 'u' || s[i] == 'A' || s[i] == 'E' || s[i] == 'I' || s[i] == 'O' || s[i] == 'U')
                {
                    vowel_count++;
                }
                else
                {
                    cons_count++;
                }
            }
            Console.Write("Vowels in the string: {0}\n", vowel_count);
        }
    }
}
