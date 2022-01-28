using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int max = 0;
            int[] reqem = { 5, 2, 3, 67, 8, 34, 12, 78, 213, 23, 161, 453,-18, 23, 151 };
            for (int i = 0; i < reqem.Length; i++)
            {
                for (int j = reqem.Length - 1; j > -1; j--)
                {
                    if (reqem[i] < reqem[j])
                    {
                        reqem[j] = reqem[i];
                    }
                }
                max = reqem[i];
            }
            Console.WriteLine(max);
        }
    }
}
