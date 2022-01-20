using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeferanAptek
{
    internal class Aptek
    {
        public object Name;
        public object Count;

        public Aptek(object ad, object say)
        {
            Name = ad;
            Count = say;    
        }
        //public static void Add(string dermanname, int saydrm, Aptek[] list)
        //{
        //    int x = 0;
        //    foreach (var derman in list)
        //    {
        //        if (derman.Name == dermanname)
        //        {
        //            x = derman.Count + saydrm;
        //        }
        //    }
        //    Console.WriteLine(x);
        //}

    }
}
