using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterCard
{
    internal class Program
    {
        static void Main(string[] args)
        {


            

            Console.WriteLine("Esas kartinda neqeder mebleg olsun");
            int esasmebleg = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Neche gun vaxti olsun kartinin");
            double gun=Convert.ToDouble(Console.ReadLine());
            Card card1 = new Card(esasmebleg, gun);
            //List<Card> cardlist = new List<Card>();    
            //Console.WriteLine(Card.Money + " " + Card.CardNo + " " + Card.date);
            Console.WriteLine("Hansi emeliyati elemey istierdiniz:\n1.Yeni virtualkartin elave olunmasi.\n2.VirtualKart silmek.\n3.Esas kartinin balansini oyren.\n4.Butun kartlari goster.\n5.Proqramdan cix");
            int cavab = Convert.ToInt32(Console.ReadLine());
            while (cavab<5)
            {


                if (cavab == 1)
                {
                    Console.WriteLine("Esas kartinda neqeder mebleg olsun");
                    int vrtmebleg = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Neche gun vaxti olsun kartinin");
                    double gunvirtual = Convert.ToDouble(Console.ReadLine());
                    card1.AddVirtualCard(vrtmebleg, gunvirtual);
                    card1.AddList(card1);
                }
                else if (cavab == 2)
                {
                    card1.RemoveList(card1);
                }
                else if (cavab == 3)
                {
                    card1.ShowMainMoney();
                }

                else if (cavab == 4)
                {
                    card1.ShowCardList();
                }

                Console.WriteLine("Hansi emeliyati elemey istierdiniz:\n1.Yeni virtualkartin elave olunmasi.\n2.VirtualKart silmek.\n3.Esas kartinin balansini oyren.\n4.Butun kartlari goster.\n5.Proqramdan cix");
                cavab = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Tesekkur edirik birat");




        }
    }
}
