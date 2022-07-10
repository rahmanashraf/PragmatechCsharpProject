using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            int qadin = (102*15)+(77*15)+(67*15)+(48*15)+(33*15)+(20*15)+1080;
            int kisiler = (500 / 30 * 76);
            int cavab = qadin + kisiler;
            
            Console.WriteLine(cavab);
            Console.ReadLine();

        }
    }
}
