using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
  

        static void Main(string[] args)
        {
            begin:
            CashRegister crg = new CashRegister(1000);
            
            Console.WriteLine("XOsgelmisiniz nese alirsizsa 1e basin almirsinizsa ozunuz basin");
            string otvet=Console.ReadLine();
            while (otvet=="1")
            {  
            Console.WriteLine("kassandaki pul nedi:");
            Console.WriteLine("1.AZN" +" "+"2.USD" + " " + "3.EURO");
            string kassa=Console.ReadLine();
            Console.WriteLine("xerclieceyin  pul nedi:");
            Console.WriteLine("1.AZN" + " " + "2.USD" + " " + "3.EURO");
            string userpulu = Console.ReadLine();
            Console.WriteLine("neqeder xerclemek isteyirsen lox: ");
            int mebleg=Convert.ToInt32(Console.ReadLine());
            crg.currency = (Currency)Enum.Parse(typeof(Currency), kassa);
            Console.WriteLine("Kassanizdaki baslangic deyeri: " + crg.TotalAmount + crg.currency);
            crg.AddSale(userpulu, mebleg);
            goto begin;

            }
        }
    }
}
