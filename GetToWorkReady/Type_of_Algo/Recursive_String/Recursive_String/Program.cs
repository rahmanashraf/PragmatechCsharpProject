using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursive_Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int i, number, fact;
            //Console.WriteLine("Enter the Number");
            //number = Convert.ToInt32(Console.ReadLine());
            //fact = number;
            //for (i = number - 1; i >= 1; i--)
            //{
            //    fact = fact * i;
            //}
            //Console.WriteLine("\nVerilen adadin fakotoriali: " + fact);

            Console.WriteLine("Faktorailini tapmag istediyin ededi yaz !: ");
            int number=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Factorial(number));
        }
        public static int Factorial(int number)
        {
            if (number == 1)
                return 1;
            else
                return number * Factorial(number - 1);
        }

    }
}
