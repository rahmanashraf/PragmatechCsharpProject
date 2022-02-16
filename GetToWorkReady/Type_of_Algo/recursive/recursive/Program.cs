using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recursive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(F(1));
            int toplama = 0;
            for (int i = 0; i < 10; i++)
            {
                toplama += i+1;
                
            }
            Console.WriteLine(toplama);

        }
        public static int F(int x)
        {
            if (x==10)
            {
                return x;
            }
            else
            {
                return x + F(x + 1);
            }
            
        }
    }
}
