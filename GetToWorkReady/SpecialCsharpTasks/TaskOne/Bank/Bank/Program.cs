using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MainCard mcard = new MainCard();
            
            Console.WriteLine("Esas kartinda neqeder mebleg olsun");
            double esasmebleg = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Neche gun vaxti olsun kartinin");
            int gun = Convert.ToInt32(Console.ReadLine());
            mcard.MaindCardAdd(esasmebleg, gun);
            Console.WriteLine("Hansi emeliyati elemey istierdiniz:\n1.Yeni virtualkartin elave olunmasi.\n2.VirtualKart silmek.\n3.Esas kartinin balansini oyren.\n4.Butun kartlari goster.\n5.Proqramdan cix");
            int cavab = Convert.ToInt32(Console.ReadLine());
            while (cavab < 5)
            {


                if (cavab == 1)
                {
                    Console.WriteLine("VirtualCardinin neqeedr icinde pul olsun");
                    double vrtmebleg = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("VirtualCardinin nece gun muddeti olsn");
                    int gunvirtual = Convert.ToInt32(Console.ReadLine());
                    VirtualCard vcard = new VirtualCard(vrtmebleg,gunvirtual);
                    VirtualCard.AddList(vcard);
                }
                else if (cavab == 2)
                {
                    
                    VirtualCard.RemoveList();
                }
                else if (cavab == 3)
                {
                    Console.WriteLine($"Sizin esas kartinizda movcud olan halhazirki balans { MainCard.Balansim}azn dir");
                }

                else if (cavab == 4)
                {
                    VirtualCard.ShowList();
                }
               

                Console.WriteLine("Hansi emeliyati elemey istierdiniz:\n1.Yeni virtualkartin elave olunmasi.\n2.VirtualKart silmek.\n3.Esas kartinin balansini oyren.\n4.Butun kartlari goster.\n5.Proqramdan cix");
                cavab = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Tesekkur edirik birat");





        }
    }
}
