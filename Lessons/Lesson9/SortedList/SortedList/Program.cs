using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedList
{
    internal class Program
    {
        static void Main(string[] args)
        {



            HashSet<int> ededler = new HashSet<int>();
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("daxil ele:: ");
                int reqem = Convert.ToInt32(Console.ReadLine());


                ededler.Add(reqem);
               
            }
            List<int> list1 = new List<int>();
 

            foreach (var item in ededler)
            {
                list1.Add(item);
                list1.Sort();
 
            }
            //foreach (var items in list1)
            //{

            //    Console.WriteLine((x+1)+"ci array elementi"+" "+items);
            //}
            Console.WriteLine("Hashsetle unique, List ile sort olunmus arrayimizin daxili bu sekilde formalasmisdir: ");
            for (int i = 0; i < list1.Count; i++)
            {
                
                Console.WriteLine((i+1)+"ci elementi:"+" "+ list1[i]);
            }


        }
    }
}
