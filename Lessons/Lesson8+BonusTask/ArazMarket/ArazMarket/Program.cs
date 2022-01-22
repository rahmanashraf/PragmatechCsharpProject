using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArazMarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double birmal = 0;
            double yekunmal = 0;
            int endrmqiymet=0;
            double endirimlisay = 0;
            string[] endirimlimehsul = { "pendir", "nutella", "kola" };
            Veyseloglu[] market = new Veyseloglu[1];
            for (int i = 0; i < market.Length; i++)
            {
                Console.WriteLine("Mehsulu daxil et: ");
                string mehsul=Console.ReadLine();
                for (int k = 0; k < endirimlimehsul.Length; k++)
                {
                    if (mehsul == endirimlimehsul[k])
                    {
                        Console.WriteLine("Endirimli mehsul siz 50%endirim qazandiniz");
                        endrmqiymet = 2;
                    }
                }
                Console.WriteLine("Neche eded ve ya kq miqdarini goster: ");
                double say = Convert.ToDouble(Console.ReadLine());
                for (int k = 0; k < endirimlimehsul.Length; k++)
                {
                    if (mehsul == endirimlimehsul[k])
                    {
                        endirimlisay = say / endrmqiymet;
                        say = endirimlisay;
                    }
                }
                Console.WriteLine("Qiymeti daxil et: ");
                double qiymeti = Convert.ToDouble(Console.ReadLine());
                Veyseloglu yekun = new Veyseloglu(mehsul, qiymeti, say);
                market[i] = yekun;


                Console.WriteLine("Bitdise bitdi de: ");
                string finish = Console.ReadLine();
                if (finish=="bitdi")
                {
                    
                    for (int j = 0; j < market.Length; j++)
                    {
                        birmal = market[j].sayi * market[j].Qiymet;
                        yekunmal += birmal;                             
                    }
                    Console.WriteLine("Musterinin etdiyi odenis: ");
                    double odenis = Convert.ToDouble(Console.ReadLine());
                    if (odenis<yekunmal)
                    {
                        Console.WriteLine("Vetendas pulun eksikdi bu nedir?"+" "+(yekunmal-odenis)+" "+"Azn catismir pulunuzda");
                        Console.WriteLine("Duzelt gorum ay gede bunun ustunu: ");
                        double odenis2 = Convert.ToDouble(Console.ReadLine());
                        if (odenis2==(yekunmal-odenis))
                        {
                            Console.WriteLine("Aysagol agilli balaa di yeri ged uch: ");
                            Console.WriteLine(DateTime.Now);

                        }


                    }
                    else
                    {
                        double zdaci = odenis - yekunmal;
                        Console.WriteLine("Buyurun qardash buda sizin qaliq pulunuz:" + " " + zdaci + " " + "Azn");
                        Console.WriteLine(DateTime.Now);
                    }
                    

                }
                else
                {
                    Array.Resize(ref market, market.Length+1);
                }

            }
            
        }
    }
}
