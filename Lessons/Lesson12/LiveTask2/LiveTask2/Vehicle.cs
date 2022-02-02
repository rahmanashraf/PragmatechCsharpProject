using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveTask2
{
    abstract class Vehicle
    {
        public string color;
        public string brand;
        public double millage;

        public Vehicle(string col,string brant,double mill)
        {
            color = col;
            brand = brant;  
            millage = mill; 

        }
        public virtual void ShowInfo()
        {
            Console.WriteLine(color+" rengli mashin"+brand+" markali"+" "+millage+" km yol getmisdir");

        }
        public abstract void Drive(double km);

    }
}
