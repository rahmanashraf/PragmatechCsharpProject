using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterCard
{
    internal class Card
    {
        private long cardno;
        public long CardNo
        {
            get
            {
                return cardno;
            }
            set
            {
                Random rnd = new Random();
                string cardNumber = string.Empty;

                for (int i = 0; i < 16; i++)
                {
                    cardNumber += rnd.Next((int)value, 9).ToString();
                }
                value = long.Parse(cardNumber);
                cardno = value;
            }

        }
        private  int money;
        public  int Money
        {
            get
            {
                return money;
            }
            set
            {
                money =value;
            }

        }

        public DateTime data = DateTime.Now;
        public List<int> list=new List<int>();    

        public Card(long reqem,int mebleg,int days)
        {
            cardno = reqem;
            money = mebleg;
            data=DateTime.Now.AddDays(days);
            Console.WriteLine("Bu menim konstruktordan gelen ilk kartimdi"+ "\n16 reqemli sifre "+cardno+" "+"\nBalans"+money+"azn "+"\nBitme tarixi"+" "+data);
        }

        public void AddVirtualCard()
        {
            Random rndm = new Random();
            for (int i = 0; i < 5; i++)
            {
                CardNo = i;
                Money = rndm.Next(i, 200);
                Console.WriteLine(CardNo+" "+ Money);
            }
        }


    }
}
