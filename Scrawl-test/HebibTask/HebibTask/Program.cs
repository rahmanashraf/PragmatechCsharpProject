using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HebibTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int [] array = {10,20,50,100};
            int boyuk=0;
            foreach (var arr in array)
            {
                foreach (var item in array)
                {
                    if (arr > item)
                    {
                        Console.WriteLine(arr);
                    }
                    else
                    {
                        boyuk = item;
                    }
                }
                Console.WriteLine("En boyuk reqem budur" + " " + boyuk);

            }
            
            //Console.WriteLine("Cekmek istediyiniz pulu daxil edin");
            //int gelenpul = Convert.ToInt32(Console.ReadLine());

        }
    }
}
