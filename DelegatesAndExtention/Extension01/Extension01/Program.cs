using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1800, 13, 10, 41, 53, 616, 71, 86, 99, 1670 };

            //Console.WriteLine(list.ELementtopla());

            //foreach (var item in list.Randomindex())
            //{
            //    Console.WriteLine(item);
            //}
            Console.WriteLine(list.EnboyuknenEnkicikferqi());

        }

    }
    static class Elementlerleis
    {
        public static int ELementtopla(this List<int> listim)
        {
            int a = 0;
            for (int i = 0; i < listim.Count; i++)
            {
                a += listim[i];
            }
            return a;
        }
        public static List<int> Randomindex(this List<int> listim)
        {
            List<int> taptazalist = new List<int>();
            Random random = new Random();
            taptazalist.Add(listim[random.Next(listim.Count)]);
            taptazalist.Add(listim[random.Next(listim.Count)]);
            taptazalist.Add(listim[random.Next(listim.Count)]);
            taptazalist.Add(listim[random.Next(listim.Count)]);
            taptazalist.Add(listim[random.Next(listim.Count)]);
            taptazalist.Add(listim[random.Next(listim.Count)]);
            taptazalist.Add(listim[random.Next(listim.Count)]);
            taptazalist.Add(listim[random.Next(listim.Count)]);
            taptazalist.Add(listim[random.Next(listim.Count)]);
            taptazalist.Add(listim[random.Next(listim.Count)]);
            return taptazalist;

        }
        public static int EnboyuknenEnkicikferqi(this List<int> listim)
        {
            int biggest = 0;
            int lowest = listim[0];

            foreach (var big in listim)
            {
                if (big > biggest)
                {
                    biggest = big;
                }
            }


            for (int i = 1; i < listim.Count; i++)
            {
                if (listim[i] < lowest)
                {
                    lowest = listim[i];
                }
            }
            return biggest-lowest;
        }



    }

}



