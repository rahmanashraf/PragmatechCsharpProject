using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hozu
{
    enum Valyuta
    {
        AZN=1,USD=22,EURO=3
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CIbinde ne var");
            string kassa=Console.ReadLine();
            var a=Enum.GetValues(typeof(Valyuta));  
            Console.WriteLine(a);
        }
    }
}
