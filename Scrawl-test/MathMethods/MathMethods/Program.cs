using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;  
            int c = 3;              
            int d = 4;
            int e = 5;
            int menfi = -5;
            double g = 1.5;
            double f = 2;
            double t = 3;
            double y = 4;
            double z = 5;
            decimal sayi1 = 10.015M;
            int bolunen = 100;
            int bolen = 50;
            
            

            double mutlakDeger = Math.Abs(g);//mutleq deyeri return verir ama bilmedim nedi pff
            //Console.WriteLine(mutlakDeger);
            long sonuc = Math.BigMul(e,b);//iki int ededi birbirine vurmagcun meto
            //Console.WriteLine(sonuc);
            decimal sonuc1 = Math.Ceiling(sayi1);//en yaxin yukselenine qaldirir 1.1 i 2 edir 2.5 i 3 edir bele
            //Console.WriteLine(sonuc1);
            int bolum = Math.DivRem(bolunen, bolen, out int kalan); //iki ededi birbirne bolur amma qalan qaliq varsa eger ucuncu edede elave edir
            //Console.WriteLine(bolum);
            int maksimum = Math.Max(b,c); //verilen iki reqemnen BOYUK olanini run edir
            int minimum = Math.Min(b, c); //verilen iki reqemnen KICIK olanini run edir
            //Console.WriteLine(maksimum);
            //Console.WriteLine(minimum);
            double kvadratayukselt = Math.Pow(f, t); //verilen birinci ededi ikinci edede yukseldir.kvadratkimi..birinci ededi ikinci ededde gosterilen qeder ozune vurma tipinde
            //Console.WriteLine(kvadratayukselt);
            double yuvarlanmis = Math.Round(g);   //verilen double ededi en yaxin tam sayiya beraberlesdirir meselen 1.4 e qeder 1e 1.5 dise 2 e yukseldir
            //Console.WriteLine(yuvarlanmis);
            int menfimusbettap=Math.Sign(menfi);   //parametr verilen eded musbetdise=1 menfidise=-1 0disa = 0 return edir;
            //Console.WriteLine(menfimusbettap);
            double karekok = Math.Sqrt(y);    //doubleni kok altina alir
            //Console.WriteLine(karekok);
        }
    }
}
