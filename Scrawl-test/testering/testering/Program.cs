using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testering
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> reqem=new List<int>() { 1,2,3,4,5,6,7,8,9,10};
            foreach (var item in reqem)
            {
                if (item>4)
                {
                    reqem.Remove(item);
                }
            }
        }
    }
}
