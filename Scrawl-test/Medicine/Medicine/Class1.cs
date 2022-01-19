using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medicine
{
    internal class Class1
    {
        public string Name;
        public int Price=0;
        public int Count;
        

        public Class1(string medname, int medprice)
        {
         Name = medname;
         Price = medprice;
         
            if (Price<0)
            {
                Console.WriteLine("0dan kiciy ola bilmez");
            }
            if (Count<0)
            {
                Console.WriteLine("0dan boyuy olmalidir");
            }

        }
        

    }
}
