using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task
            //Asagida qeyd etdiyim algoritimleri ozunuz yazin, c#da hazir yazilmis methodlardan istifade etmeyin
            //1)String Substring methodunun algorithmini qurun;
            //2)Reverse methodunun algoritmi qurun : input: hello, output: olleh
            //3)Verilmis sozun palindrome oldugunu yoxlayan algoritm mes: input: ana, output: ana(soldan ve sagdan eyni oxunur)
            //4)Remove duplikat olan herfleri silen algoritmini yazin input: csharpcorner, output: csharpone c
            //5)5 ədədin orta qiymətinin tapılması algoritmi qurun;
            //6)Düzbucaqlının sahə və perimetrini tapan algoritmi qurun;
            //7)Daxil edilən ədədin vurma cədvəlini yazdiran algoritmi qurun;
            //8)1 le verilmis eded arasinda kvadratlari cemi algoritmini qurun;
            //9)0 la verilmiş ədəd arasındaki ədədlərin hasili ilə cəminin fərqini hesablayan algoritmi qurun;
            //10) Optional Sozler arasindaki bosluqlari silen bir method yazmaq. Meselen: "salam menim adim Minadir"
            //Quize hazirlasin
            //string soz = "kartowka";
            //string soz2 = "tarat";
            //string soz3 = "csharpcorner";


            //Console.WriteLine(SUBstringo(soz,1,5));
            //Console.WriteLine(Reverse(soz));
            //Console.WriteLine(Polindrome(soz2));
            //Console.WriteLine(Dublicate(soz3));
            //Console.WriteLine(OrtaQiymet(3,4,5,10,8));
            //Console.WriteLine(DuzbucaqliSAhe(5,6));
            //Console.WriteLine(DuzbucaqliPerimetr(5, 6));
            //VurmaCedveli(4);
            //birile(5);
            //sifirile(5);
            //Optional("netersen brat ne var ne yox");
            //string salam = "ejdaha";
            //Console.WriteLine(salam.Replace("ejdaha", "bratan")); 

        }
        public static string SUBstringo(string soz, int index, int finish)
        {
            string yenisoz = "";

            for (int i = index; i < finish; i++)
            {
                yenisoz += soz[i];
            }
            return yenisoz;

        }
        public static string Reverse(string ters)
        {
            char[] sozyigini = ters.ToCharArray();
            string soz = "";
            for (int i = sozyigini.Length - 1; i > -1; i--)
            {
                soz += sozyigini[i];
            }
            return soz;
        }
        public static bool Polindrome(string para)
        {
            char[] sozyigini = para.ToCharArray();
            char[] sozyigini2 = para.ToCharArray();
            string soz = "";
            string soz2 = "";
            bool result = true;
            for (int i = sozyigini.Length - 1; i > -1; i--)
            {
                soz += sozyigini[i];
            }
            for (int i = 0; i < sozyigini2.Length; i++)
            {
                soz2 += sozyigini2[i];
            }
            if (soz2 == soz)
            {
                return result;
            }
            return false;
        }
        public static string Dublicate(string soz)
        {
            char[] sozyigini = soz.ToCharArray();
            string tezesoz = "";
            for (int i = 0; i < sozyigini.Length; i++)
            {

                if (!tezesoz.Contains(sozyigini[i]))
                {
                    tezesoz += sozyigini[i];
                }

            }
            return tezesoz;


        }
        public static int OrtaQiymet(int reqem1, int reqem2, int reqem3, int reqem4, int reqem5)
        {
            int result = reqem1 + reqem2 + reqem3 + reqem4 + reqem5;
            return result / 5;
        }
        public static int DuzbucaqliSAhe(int en, int uzun)
        {

            int sahesi = en * uzun;
            return sahesi;

        }
        public static int DuzbucaqliPerimetr(int en, int uzun)
        {

            int perimetr = 2 * (en + uzun);
            return perimetr;

        }
        public static void VurmaCedveli(int eded)
        {
            int reqem = 1;

            for (int i = reqem; i < 10; i++)
            {
                Console.WriteLine(eded + "*" + i);
            }


        }
        public static void birile(int kvadrat)
        {
            int a = 0;
            int cem = 0;
            for (int i = 1; i <= kvadrat; i++)
            {
                a= (i*i);
                cem+=a;
                
            }
            Console.WriteLine(cem);
        }
        public static void sifirile(int eded)
        {
            int top = 0;
            int has = 1;
            int toplama = 0;
            for (int i = 1; i <= eded; i++)
            {
                top+= i;
                has *= i;
                toplama = has-top;
                
                
            }
            Console.WriteLine(toplama);
        }

        public static void Optional(string soz)
        {
            Console.WriteLine(soz.Replace(" ", ""));
        }

        public static string Replaced(string data1, string data2)
        {
            string bos = data1;
            for (int i = bos.Length; i < bos.Length; i++)
            {
                if (data1==data2)
                {
                    bos += data2;
                }
            }
            return bos;

        }

    }
}
