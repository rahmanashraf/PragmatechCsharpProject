using System;


namespace StringMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 5;  
            Console.WriteLine(Topla(ref a, ref b));
            Console.WriteLine(Chix(ref a, ref b));
            Console.WriteLine(Vur(ref a, ref b));
            Console.WriteLine(bol(ref a, ref b));



        }
        public static int Topla(ref int input, ref int input2) {
            int sum=input+input2;
            return sum;   
            
        }
        public static int Chix(ref int input, ref int input2)
        {
            int ferq = input - input2;
            return ferq;

        }
        public static int Vur(ref int input, ref int input2)
        {
            int hasil = input * input2;
            return hasil;

        }
        public static int bol(ref int input, ref int input2)
        {
            int bolgu = input / input2;
            return bolgu;

        }

    }
}
