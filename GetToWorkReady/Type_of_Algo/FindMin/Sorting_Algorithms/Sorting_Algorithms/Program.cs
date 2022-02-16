using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int[] array = { 6, 1, 26, 4, 9, 2, 89, 3, 5 };
            int[] array2 = new int[array.Length];
            
            for (int i = 0; i < array.Length; i++)
            {
                int place = 0;
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        place = place + 1;
                    }
                    
                }
                array2[place] = array[i];
            }
            foreach (int item in array2)
            {
                Console.WriteLine(item);
            }   
            
        }
    }
}
