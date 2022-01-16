using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test123
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 cls = new Class1("Rehman", "AShrafov");

            cls.FullName("rehman", "esrefov");
            Class1.StaticliName("elmar", "memmedov");
        }
    }
}
