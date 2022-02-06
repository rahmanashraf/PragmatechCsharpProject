using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetterSetter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student std=new Student();
            //std.Setkilo(-50);
            std.Kilo = -50;
            Console.WriteLine(std.Kilo);
        }
    }
}
