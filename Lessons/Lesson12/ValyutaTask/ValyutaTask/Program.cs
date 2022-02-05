using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValyutaTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            begin:
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Yerine yetirmek istediyiniz mubadile novunu seciniz:" +
                "\n1.USD-AZN-1,70\n2.EURO-AZN-2,00\n3.TL-AZN-0,13\n4.AZN-USD-0,59\n5.AZN-EURO-0,50\n6.AZN-TL-7,98");

            int enteringmoneyType = Convert.ToInt32(Console.ReadLine());
            while (enteringmoneyType<6)
            {
                
                
                Console.WriteLine("Daxil etmek istediyiniz miqdari yazin: ");
                double changersum = Convert.ToDouble(Console.ReadLine());

                switch (enteringmoneyType)
                {
                    case 1:
                   Exchanger.Exchange(CurrenctType.AZNtoUSD, changersum);
                     break;
                    case 2:
                        Exchanger.Exchange(CurrenctType.AZNtoEURO,changersum);
                        break;
                    case 3:
                        Exchanger.Exchange(CurrenctType.AZNtoTL, changersum);
                        break;
                    case 4:
                        Exchanger.Exchange(CurrenctType.USDtoAZN, changersum);
                        break;
                    case 5:
                        Exchanger.Exchange(CurrenctType.EUROtoAZN, changersum);
                        break;
                    case 6:
                        Exchanger.Exchange(CurrenctType.TLtoAZN, changersum);
                        break;

                }
                //Console.BackgroundColor = ConsoleColor.DarkRed;
                //Console.WriteLine("Yerine yetirmek istediyiniz mubadile novunu seciniz:" +
                //    "\n1.USD-AZN\n2.EURO-AZN\n3.TL-AZN\n4.AZN-USD\n5.AZN-EURO\n6.AZN-TL ");
                //enteringmoneyType = Convert.ToInt32(Console.ReadLine());
                goto begin; 

            }
        }
    }
}
