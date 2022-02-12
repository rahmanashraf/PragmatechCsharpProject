using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterCard
{
    class Card
    {
        List <Card>cartlist=new List <Card> (); 
        private static string cardno;
        public static string CardNo
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
                    cardNumber += rnd.Next(0, 10).ToString();
                }
                value = cardNumber;
                cardno = value;
            }

        }
        private static int money;
        public static int Money
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
        public static DateTime date=DateTime.Now;

        string virtualkartkodu;
        int virtualkartpulu;
        DateTime virtualbitmetarixi=DateTime.Now;
        
        public Card(int moneyi,double gun)
        {
            CardNo = " ";
            Money = moneyi;
            date=date.AddDays(gun);
        }
        public void AddVirtualCard(int mebleg,double gun)
        {
            if (mebleg<money-4)
            {
                if (date>=virtualbitmetarixi.AddDays(gun))
                {
                    virtualbitmetarixi = virtualbitmetarixi.AddDays(gun);
                    Money=money - mebleg;
                    virtualkartpulu = mebleg;
                    Random rndm = new Random();
                    for (int i = 0; i < 16; i++)
                    {
                        virtualkartkodu += rndm.Next(10);
                    }
                    
                }
                else
                {
                    Console.WriteLine("bitme tarixi main carddan gec ola bilmez");
                }
            }
            else
            {
                Console.WriteLine("Virtual kartin pulu esas meblegi kecmemelidi");
            }
            
        }
        public void AddList(Card cart)
        {
            cartlist.Add(cart);
        }
        public void ShowCardList()
        {
            for (int i = 0; i < cartlist.Count; i++)
            {
                
            }

        }
        public void RemoveList(Card cart)
        {
            cartlist.Remove(cart);
        }

        public void ShowMainMoney()
        {
            Console.WriteLine(money);
        }

       


    }
}
