using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValyutaTask
{
    enum CurrenctType
    {
        AZNtoUSD , AZNtoEURO = 2, AZNtoTL = 3,USDtoAZN= 4,EUROtoAZN=5,TLtoAZN= 6
    }
    static class Exchanger
    {
        
        public static Dictionary<CurrenctType, double> money = new Dictionary<CurrenctType, double>();

        public static void Exchange(CurrenctType valyuta, double pul)
        {

            money.Add(valyuta, pul);
            double hesab = 0;
            if (valyuta == CurrenctType.AZNtoUSD)
            {
                hesab = pul * 1.7;
                
            }
            else if (valyuta == CurrenctType.AZNtoEURO)
            {
                hesab = pul * 2;
                
            }
            else if (valyuta == CurrenctType.AZNtoTL)
            {
                hesab= pul * 0.13;
                
            }

            else if (valyuta==CurrenctType.USDtoAZN)
            {
                hesab = pul / 1.7;
                Console.WriteLine($"Siz daxil etdiniz " + pul + " " + " azn " + hesab + " " + " Dollar edir");
            }
            else if (valyuta == CurrenctType.EUROtoAZN)
            {
                hesab = pul / 2;
                Console.WriteLine($"Siz daxil etdiniz " + pul + " " + " azn " + hesab + " " + " EURO edir");
            }
            else if (valyuta == CurrenctType.TLtoAZN)
            {
                hesab = pul / 0.13;
                Console.WriteLine($"Siz daxil etdiniz " + pul + " " + " azn " + hesab + " " + " Turk Lirasi edir");
            }

            if (valyuta == CurrenctType.AZNtoUSD|| valyuta == CurrenctType.AZNtoEURO|| valyuta == CurrenctType.AZNtoTL)
            {
                Console.WriteLine($"Emeliyatiniz uzre {pul} miqdarinda pul {hesab} azn edir");

            }
            money.Clear();

        }


    }

}
