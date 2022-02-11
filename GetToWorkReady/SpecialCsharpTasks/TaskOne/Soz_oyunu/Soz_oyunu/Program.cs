using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;



namespace Soz_oyunu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string authors = "You can gain experience, if you are careful to avoid empty redundancy. Do not fall into the error of the artisan who boasts of twenty years experience in craft while in fact he has had only one year of experience twenty times. And never resent the advantage of experience your elders have. Recall that they have paid for this experience in the coin of life, and have emptied purse that cannot be refilled.";

            string[] spearator = { " ", ".", ", ", "-", };

            int count = 80;
            string[] words = authors.Split(spearator, count,
               StringSplitOptions.RemoveEmptyEntries);

            begin:

            Console.WriteLine("Yeni oyuna baslamag ucun 1 duymesini bas:");
            string cavab = Console.ReadLine();
            Console.WriteLine("Adinizi qeyd edin bro: ");
            Gaming.Name = Console.ReadLine();
            if (cavab == "1")
            {
                int num = 0;
                TimerCallback tm = new TimerCallback(Gaming.Count);
                Timer timer = new Timer(tm, num, 10000, 0);
                Gaming.Go(words);

            }
            else
            {
                goto begin;
            }



        }

    }
}
