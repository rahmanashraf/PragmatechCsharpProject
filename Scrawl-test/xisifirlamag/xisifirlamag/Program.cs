using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xisifirlamag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0;

            for (int i = 0; i < 3; i++)
            {

                Console.WriteLine("3duz cavab veren udur");
                Console.WriteLine("cavabini yaz");
                string cavab1 = Console.ReadLine();
                Console.WriteLine("cavabini yaz");
                string cavab2 = Console.ReadLine();
                Console.WriteLine("cavabini yaz");
                string cavab3 = Console.ReadLine();

                if (cavab1 == "salam")
                {
                    x++;
                    Console.WriteLine("1ci cavab duzdu sizin baliniz" + " " + x);
                }
                if (cavab2 == "sagol")
                {
                    x++;
                    Console.WriteLine("2ci cavab duzdu sizin baliniz" + " " + x);

                }
                if (cavab3 == "sagole")
                {
                    x++;
                    Console.WriteLine("3ci cavab duzdu sizin baliniz" + " " + x);

                }

                Console.WriteLine("sizin toplam baliniz"+" "+x);
                x = 0;
            }
        }
    }
}