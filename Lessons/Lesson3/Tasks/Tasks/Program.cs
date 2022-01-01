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
            //Quize hazirlasin
            string soz = "kartowka";

            Console.WriteLine(SUBstringo(soz,1,5));
            Console.WriteLine(Reverse(soz));
        }
        public static string SUBstringo(string soz,int index,int finish)
        {
            string yenisoz = "";

            for (int i = index; i < finish ; i++)
            {
                yenisoz+=soz[i];
            }
            return yenisoz;
            
        }
        public static string Reverse(string ters)
        {
            char[] sozyigini=ters.ToCharArray();    
            string soz = "";
            for (int i = sozyigini.Length - 1; i > sozyigini[0]; i--)
            {
                soz += ters[i];
            }
            return ters;
        }
        
    }
}
