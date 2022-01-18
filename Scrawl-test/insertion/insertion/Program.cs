using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insertion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InsertionSort(4, 5, 7, 1, 2, 4, 6, 8, 9, 4, 3, 25, 3423);
        }
        public static void InsertionSort(params int[] input)
        {
 

            for (int i = 0; i < input.Count(); i++)
            {
                var item = input[i];
                var currentIndex = i;

                while (currentIndex > 0 && input[currentIndex - 1] > item)
                {
                    input[currentIndex] = input[currentIndex - 1];
                    currentIndex--;
                }

                input[currentIndex] = item;

                Console.WriteLine(  item);

            }

        }
    }
}
