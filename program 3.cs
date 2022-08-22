using System;
using System Collections Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
   internal class assgn4
   {
      public static void Main()
      {
           int a=0,count=1;
           string s="Sonata Software";
           while(a<=s.Length-1)
           {
               if(s[a]==' '|| s[a]=='\n'||s[a]=='\t')
               {
                   count++;
               }
                 a++;
           }
            Console.WriteLine("Number of vowels in the string={0}\n",count);
       }
    }
}