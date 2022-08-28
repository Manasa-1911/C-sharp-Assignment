using System;
namespace ConsoleAppDemo
{
    public class Secondlargest
    {
        public static void Main()
        {
            int n, i, j = 0, lar, seclar;
            int[] arr1 = new int[50];


            Console.Write("Input the size of array : ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} elements in the array :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element -> {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            lar = 0;

            for (i = 0; i < n; i++)
            {
                if (lar < arr1[i])
                {
                    lar = arr1[i];
                    j = i;
                } 
            }

            seclar = 0;
            for (i = 0; i < n; i++)
            {
                if (i == j)
                {
                    i++;
                    i--;
                }
                else
                {
                    if (seclar < arr1[i])
                    {
                        seclar = arr1[i];
                    }
                }
            }

            Console.Write("The Second largest element in the array is :  {0} \n\n", seclar);
        }
    }
}
