using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveTask2
{
    internal class Bycle:Vehicle
    {
        public Bycle(string color,string brand,double millage):base(color,brand,millage)
        {

        }
        public override void Drive(double km)
        {
            Console.WriteLine("MIllage neqede ureyin istir sur benzin sohbeti yoxdu"+millage);
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
        }

    }
}
