using System;
namespace ConsoleAppDemo
{
    internal class Duplicate
    {
        public static void Main()
        {  
            int[] items = { 1,2,3,4,5,2,4,8};  
            int n = items.Length;  
  
            Console.WriteLine("Unique array elements are: ");  
  
            for(int i=0; i<n;i++)  
            {  
                bool Same = false;  
                for(int j=0;j<i;j++)  
                {  
                    if(items[i] == items[j])  
                    {  
                        Same = true;  
                        break;  
                    }  
                }  
  
                if(!Same)  
                {  
                    Console.WriteLine(items[i]);  
                      
                }  
            } 
        } 
    }
} 
  
