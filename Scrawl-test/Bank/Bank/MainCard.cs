using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
     class MainCard
    {
        public static double Balansim;
        public static string Cardomr;
        public static DateTime Datem;

        public void MaindCardAdd(double balans,int gun)
        {
            Random random = new Random();
            for (int i = 0; i < 16; i++)
            {
                Cardomr += random.Next(0, 10).ToString();
            }
            Balansim = balans;
            Datem = DateTime.Now.AddDays(gun);

            Console.WriteLine($"Main Card Yaradildi! Cardno: {Cardomr} Bitme tarixi: {Datem} Balans {Balansim}");
        }
      


        
    }
}
