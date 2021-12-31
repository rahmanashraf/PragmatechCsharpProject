using System;

namespace test2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("giris balini daxil et: ");
            int TelebeBali = Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine("imtahan balini daxil et: ");
            int ImtahanBali = Convert.ToInt32(Console.ReadLine());
            int Netice = TelebeBali + ImtahanBali;
            if (Netice >= 51)
            { 
                Console.WriteLine("Tebrikler Siz imtahani kecdiniz"); 
            }
            else 
            { 
                Console.WriteLine("Ged birazda hazirlas"); 
            }
                



        }
    }
}
