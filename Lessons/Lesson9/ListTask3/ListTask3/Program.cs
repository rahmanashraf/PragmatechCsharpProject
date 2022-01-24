using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListTask3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> listim = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("eded daxil et: ");
                int reqem1 = Convert.ToInt32(Console.ReadLine());
                listim.Add(reqem1);
            }
            listim.Reverse(0, 5);
            foreach (var item in listim)
            {
                Console.WriteLine(item);
            }
        }
    }
}
