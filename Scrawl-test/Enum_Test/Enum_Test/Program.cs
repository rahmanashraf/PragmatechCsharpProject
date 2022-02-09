using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_Test
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            RegisterCash.carivalyuta.Add(Valyuta.AZN, 1);
            RegisterCash.carivalyuta.Add(Valyuta.USD, 1.70);
            RegisterCash.carivalyuta.Add(Valyuta.EURO, 2);
            RegisterCash.carivalyuta.Add(Valyuta.TL, 0.125);

            
        }
    }
}
