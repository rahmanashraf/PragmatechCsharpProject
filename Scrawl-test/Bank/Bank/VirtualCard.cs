using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class VirtualCard
    {
        List <VirtualCard> cardlist = new List<VirtualCard>();
        string Cardno;
        DateTime Date;
        double Balans;
        public void AddVirtualCard(double mebleg,int gun)
        {
            Random random = new Random();
            for (int i = 0; i < 16; i++)
            {
                Cardno += random.Next(0, 10).ToString();
            }
            Console.WriteLine("kart hazirdi nomresi"+" "+Cardno);

            if (mebleg<MainCard.Balansim)
            {
                if (MainCard.Datem>Date)
                {
                    MainCard.Balansim = MainCard.Balansim - mebleg;
                    Balans = mebleg;
                    Date = DateTime.Now.AddDays(gun);
                }
                else
                {
                    Console.WriteLine("Virtualin tarixi esasdan uzun ola bilmez");
                }
            }
            else
            {
                Console.WriteLine("Virtualin Balansi Main balansdan cox ol abilmez(");
            }

        }
        public void Addlist(VirtualCard card)
        {
            if (cardlist.Count<=5)
            {
                cardlist.Add(card);
                Cardno = "";
                
            }
            else
            {
                Console.WriteLine("Kart limitiniz dolmusdur bundan artiq kart yarada bilmersiniz");
            }
        }
        public void RemoveList()
        {
            if (cardlist.Count==0)
            {
                Console.WriteLine("Silinesi kartiniz yoxdur");
            }
            else
            {
                Console.WriteLine("Halhazirda bu kartlariniz movcuddur: ");
            for (int i = 0; i < cardlist.Count; i++)
            {
                int sirasayi = i + 1;
                Console.WriteLine($"{sirasayi}nomreli kartiniz \n KartNomresi: {cardlist[i].Cardno} \n Bitme tarixi: {cardlist[i].Date} \n Balansi: {cardlist[i].Balans}");

            }
            Console.WriteLine("Nechenci karti silmek istediyini yaz");
            int indexim = Convert.ToInt32(Console.ReadLine());
            MainCard.Balansim = MainCard.Balansim + cardlist[indexim-1].Balans;
            cardlist.RemoveAt(indexim);
            }
            
        }
        public void ShowList()
        {
            if (cardlist.Count == 0)
            {
                Console.WriteLine("Siz hele kart elave etmemisiniz");

            }
            else
            {
                for (int i = 0; i < cardlist.Count; i++)
                {
                    int sirasayi = i + 1;
                    Console.WriteLine($"{sirasayi}nomreli kartiniz \n KartNomresi: {cardlist[i].Cardno} \n Bitme tarixi: {cardlist[i].Date} \n Balansi: {cardlist[i].Balans}");

                }
            }
        }

        
    }
}
