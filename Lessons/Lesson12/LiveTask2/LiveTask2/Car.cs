using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveTask2
{
    internal class Car:Vehicle
    {
        //Drive metodu car uzerinde istifade olunduqda birinci var lan benzin miqdari ile bu mesfeninin gedilib gedile bilmeyeceyi yoxlanmalidir, 
        //daha sonra eger gedirle bilerse benzin azalmali ve millage artmalidir.Bycle classinda ise Drive olunduqda millage artmalidir
        public double FuelCapacity;
        public double CurrentFuel;
        public double FuelFor1km;

        public Car(double fuelcap,double current,double fuelfo,string color,string brant,double millage) :base(color,brant,millage)
        {
            FuelCapacity = fuelcap;
            CurrentFuel = current;
            FuelFor1km = fuelfo;
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
        }
        public override void Drive(double km)
        {
            double gedenbenzin = km * FuelFor1km;
            if (gedenbenzin>CurrentFuel)
            {
                double artig = gedenbenzin - CurrentFuel;

                Console.WriteLine("bu "+km+" "+"yolu gede bilmek ucun"+artig+" "+"litr benzin vurmalisiniz");
            }
            if (gedenbenzin==CurrentFuel)
            {
                Console.WriteLine("rahatdignan gede bilersiz ama baxinda qayidanda benzin lazim olacag yeene brat!");
            }
            if (gedenbenzin<CurrentFuel)
            {
                double qaliq = CurrentFuel - gedenbenzin;
                double qaliqyol = qaliq / FuelFor1km;
                Console.WriteLine(qaliq+" litr"+" "+"benzininiz qaldi siz bu benzin ile "+qaliqyol+" "+"km daha gede bilersiniz");
            }
        }
    }
}
