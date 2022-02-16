using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindSameNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int say =0;
            int e=0;    
            int[] array1 = { 42, 23, 15, 7, 16, 2 };
            int[] array2 = { 41, 23, 12, 7, 12, 25 };

            for (int i = 0; i < array1.Length; i++)
            {
                for (int j = 0; j < array2.Length; j++)
                {
                    if (array1[i]==array2[j])
                    {
                        e=array2[i];
                        Console.WriteLine(e + "reqemi her iki arrayda da movcuddur");

                        say++;
                    }
                }

            }
            Console.WriteLine("iki arrayin"+say+" "+ "sayida ortag reqemi var");

        }
    }
}
