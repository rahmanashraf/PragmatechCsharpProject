using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medicine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1[] mehsullar = new Class1[1];
            for (int i = 0; i < mehsullar.Length; i++)
            {


                Console.WriteLine("Adi daxil et: ");
                string ad = Console.ReadLine();

                Console.WriteLine("Qiymeti daxil et ");
                int qiymet = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Sayi daxil et: ");
                int say = Convert.ToInt32(Console.ReadLine());

                Class1 std = new Class1(ad, qiymet);
                


                mehsullar[i] = std;

            }
            Console.WriteLine("Mehsulun adini daxil et: ");
            string mehsuladi = Console.ReadLine();
            Console.WriteLine("Sayi daxil et: ");
            int sayini = Convert.ToInt32(Console.ReadLine());
            Sell(mehsuladi, sayini,mehsullar);
        }
        public static void Sell(string mhsladi,int sayi, Class1[] list)
        {

            int x = 0;
            
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i].Name == mhsladi)
                {
                    x = list[i].Count;
                }
            }
            Console.WriteLine(x);
        }
    }
}