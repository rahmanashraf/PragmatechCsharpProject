using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            for (int i = 0; i < 10; i++)
            {

                Console.WriteLine(Fib(i));
            }
            

        }
        public static int Fib(int x)
        {
            if (x == 0)
            {
                return 1;
            }
            if (x==1)
            {
                return 1;
            }
            return Fib(x-1)+Fib(x-2);
        }
    }
}
