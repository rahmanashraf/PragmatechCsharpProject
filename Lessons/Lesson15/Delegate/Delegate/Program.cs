using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    internal class Program
    {
        public delegate void Reqemtap(List<int>nums);
        public delegate int Hellet(int a, int n);
        static void Main(string[] args)
        {
            List<int> numbers=new List<int> { 5,151,121,655,12,156,122,2,6,3,88,74,232,765,43,62,72,874,345,31};
            Reqemtap test=new Reqemtap(Tekreqemler);
            Hellet hellet = new Hellet(Topla);
            hellet += Cix;
            hellet += Vur;
            hellet += Bol;  
            //Lambda ile geri donus>
            hellet += (int a, int b) =>
            {
                Console.WriteLine("Lambda ile Bolundu");
                return a / b;
            };
            System.Delegate[] deleg = hellet.GetInvocationList();
            for (int i = 0; i < deleg.Length; i++)
            {
                int cavab=((Hellet)deleg[i]).Invoke(100, 20);
                Console.WriteLine(cavab);
            }


            test += Cutreqemler;
            test += Beshetambolunen;
            test(numbers);


        }
        
        static void Tekreqemler(List<int>list)
        {
            Console.WriteLine("Listdeki tek reqemler bunlardir");
            Console.WriteLine("--------------------------------");
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i]%2==1)
                {

                    Console.WriteLine(list[i]);
                }
                
            }
            
        }
        static void Cutreqemler(List<int> list)
        {
            Console.WriteLine("Listdeki cut reqemler bunlardir");
            Console.WriteLine("--------------------------------");
            for (int i = 0; i < list.Count; i++)
            {
         
                if (list[i] % 2 == 0)
                {
                    Console.WriteLine(list[i]);
                }

            }

        }
        static void Beshetambolunen(List<int> list)
        {
            Console.WriteLine("Listdeki bewebolunen reqemler bunlardir");
            Console.WriteLine("--------------------------------");
            for (int i = 0; i < list.Count; i++)
            {

                if (list[i] % 5 == 0)
                {
                    Console.WriteLine(list[i]);
                }

            }

        }
        public static int Topla(int a,int b)
        {
            return a + b;
        }
        public static int Cix(int a, int b)
        {
            return a - b;
        }
        public static int Vur(int a, int b)
        {
            return a * b;
        }
        public static int Bol(int a, int b)
        {
            return a / b;
        }

    }
}
