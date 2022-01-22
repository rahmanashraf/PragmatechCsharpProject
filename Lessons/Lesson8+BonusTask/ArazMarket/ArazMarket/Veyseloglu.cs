using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArazMarket
{
    internal class Veyseloglu
    {
        public string Mehsul;
        public double Qiymet;
        public double sayi;

        public Veyseloglu(string mehsul,double qiymet,double eded)
        {
            Mehsul = mehsul;
            Qiymet = qiymet;
            sayi = eded;    
        }
    }
}
