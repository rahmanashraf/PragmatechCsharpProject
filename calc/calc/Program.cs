using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Yerine yetrmek istediyiniz emeliyatin reqemini qeyd edin:");
            Console.WriteLine("1.Toplama 2.Cixma 3.Vurma 4.Bolme");
            string choose = Console.ReadLine();

            switch (choose)
            {
                case "1":
                    Console.WriteLine("Birinci ededi secin: ");
                    int ilk = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ikinci ededi secin: ");
                    int ikinci = Convert.ToInt32(Console.ReadLine());
                    int cavab = Topla(ilk, ikinci);
                    Console.WriteLine(cavab);

                case "2":
                    Console.WriteLine("Birinci ededi secin: ");
                    int ilki = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ikinci ededi secin: ");
                    int ikinc = Convert.ToInt32(Console.ReadLine());
                    int cavabi = Cix(ilki, ikinc);
                    Console.WriteLine(cavabi);







            }}
        
            public static int Topla(int first, int sec)
            {
                int netice = first + sec;
                return netice;
            } }
            public static int Cix(int first, int sec)
            {
                int netice = first + sec;
                return netice;
            }
            public static int vur(int first, int sec)
            {
                int netice = first + sec;
                return netice;
            }
            public static int bol(int first, int sec)
            {
                int netice = first + sec;
                return netice;
            }
        }
    } }
