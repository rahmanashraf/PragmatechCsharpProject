using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveTask2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car masin = new Car(100, 80, 1,"qirmizi", "mersedes", 100);

            masin.ShowInfo();
            masin.Drive(80);

        }
    }
}
