using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_Test
{
    enum Valyuta
    {
        AZN = 1,
        USD = 2,
        EURO = 3,
        TL = 4

    }
    class RegisterCash
    {
        private static double TotalAmount;
        private static int TotalSalesCount = 0;
        private static Valyuta valyuta;

        // ============= Data Base Sale
        public static Dictionary<Valyuta, double> userinpulu = new Dictionary<Valyuta, double>();
        // =========== Data Base Currency Value
        public static Dictionary<Valyuta, double> carivalyuta = new Dictionary<Valyuta, double>();

        public void SelectedOption()
        {
            Console.WriteLine("Cari valyutanizi secin: ");
            Console.WriteLine(" USD : 1 ");
            Console.WriteLine(" TL :  2 ");
            Console.WriteLine(" ERO : 3 ");
            Console.WriteLine(" AZN : 4 ");
        }



    }
}
