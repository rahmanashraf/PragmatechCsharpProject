using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;


namespace Soz_oyunu
{
    internal class Program
    {
        private static int x = 120;

        static void Main(string[] args)
        {
            string authors = "You can gain experience, if you are careful to avoid empty redundancy. Do not fall into the error of the artisan who boasts of twenty years experience in craft while in fact he has had only one year of experience twenty times. And never resent the advantage of experience your elders have. Recall that they have paid for this experience in the coin of life, and have emptied a purse that cannot be refilled.";


            string[] words = authors.Split(' ', ',', '.', '"');

            //Random random = new Random();
            
            Timer time = new Timer(5000); //to milliseconds
            time.Enabled = true;
            time.Elapsed += new ElapsedEventHandler(MyHandler);

            time.Start();
            Console.WriteLine("soz yaz");
            string sozyaz = Console.ReadLine();
            Console.WriteLine(sozyaz);
            time.Start();

           
        




        //Timering(words,random);



        
            //timer.Interval = 1000;
            //timer.Elapsed += Timer_Elapsed;
            //RandomFind(words);
            //timer.Start();

}
        private static void MyHandler(object e, ElapsedEventArgs args)
        {
            var timer = (Timer)e;
            Console.WriteLine("vaxt bitdi");
            timer.Stop();
        }



        //private static void Timering(string []words,Random random)
        //{

        //    for (int i = 10; i >= 0; i--)
        //    {


        //        Thread.Sleep(1000);
        //        Console.WriteLine(i);
        //if (i == 0)
        //{

        //Console.WriteLine(i);
        //int osoz = random.Next(words.Length);
        //int result = 0;
        //string duz_soz = words[osoz] + " " + words[osoz + 1];
        //string ilksoz = words[osoz];
        //string sonsoz = words[osoz + 1];
        ////Console.WriteLine(duz_soz);
        //Console.WriteLine(duz_soz + " bax ama elebele yoxlamagcundu");
        //Console.WriteLine(ilksoz + "______");
        ////Console.WriteLine(sonsoz);

        //Console.WriteLine("ikinci sozu tap:");
        //string cavab1 = Console.ReadLine();
        //if (cavab1 == sonsoz)
        //{
        //    result += 6;
        //}
        //Console.WriteLine("yekun baliniz" + result);


        //}
        //else
        //{
        //    Console.WriteLine(i + " " + "saniyeniz qaldi ve muddetiniz basha catdi normalda bu hisse de sizin neticeleriniz olacag");
        //}



        //public static void RandomFind(string [] array)
        //{



        //}
    }
}
