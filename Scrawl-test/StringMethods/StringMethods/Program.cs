using System;


namespace StringMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 5;  
            Console.WriteLine(topla(ref a, ref b));
            Console.WriteLine(cix(ref a, ref b));
            Console.WriteLine(vur(ref a, ref b));
            Console.WriteLine(bol(ref a, ref b));



        }
        public static int topla(ref int input, ref int input2) {
            int sum=input+input2;
            return sum;   
            
        }
        public static int cix(ref int input, ref int input2)
        {
            int ferq = input - input2;
            return ferq;

        }
        public static int vur(ref int input, ref int input2)
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
