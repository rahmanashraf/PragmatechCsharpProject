using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace value_referans
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 5;
            int sayi2 = sayi1;
            sayi1 = 7;
            sayi2 = sayi1;
            sayi2 = 6;
            Console.WriteLine(sayi1);
            Console.WriteLine(sayi2);
            string[] meyveler1 = {"alma","heyva","nar" };
            string[] meyveler2 = { "uzum", "saftali", "apelsin" };
            meyveler2 = meyveler1;
            meyveler2[0] = "kartof";

            Console.WriteLine(meyveler1[0]);
            Console.WriteLine(meyveler2[0]);
        }
    }
}
