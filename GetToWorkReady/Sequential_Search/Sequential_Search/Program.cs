using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sequential_Search
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10]
            { 1, 2, 4, 11, 20, 28, 48, 84, 96, 106};
            int value = 20;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]==value)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine(-1);
                }
               

            }
    
        }
    }
    
   
}
