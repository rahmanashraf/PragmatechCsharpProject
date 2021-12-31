using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace terminal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //balans goster
            //pul cixar
            //balans artir
            //cixis ele
            //error ver
            int balans = 1000;

            Console.WriteLine("ne etmek istediyini daxil et");
            string emel = Console.ReadLine();
              

            switch(emel)
            {
                case "1"
              
            :   Console.WriteLine("Balansiniz " + balans+" azndir");
                break;

                case "2":

                    Console.WriteLine("Neqeder cekmek isteyirdiniz: ");
                    int cekmekistediyin=Convert.ToInt32(Console.ReadLine());
                    if (cekmekistediyin < balans)
                    {
                        Console.WriteLine(cekmekistediyin + " azn mebleginde pul balansinizdan cekildi");
                        Console.WriteLine(balans - cekmekistediyin + " " + "azn balansiniz qaldi");
                    }
                    else
                    {
                        Console.WriteLine("Balansinizda cekmek istediyiniz qeder vesait yoxdur");
                        break;
                    }

                    break;

                case "3":
                    Console.WriteLine("balansiniza neqeder artirmag isteyirsiniz ");
                    int balansartirdig=Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("balansiniz artirildi ve halhazirki balansiniz " + (balans + balansartirdig) +" azndir");

                    break;

                case "4":
                    Console.WriteLine("Xidmetimizden istifade etdiyiniz ucun tesekkur edirik...");
                    break;

                    
                default: 
                    Console.WriteLine("duzgun reqem yaz");
                    break;

            }
            

        }
    }
}
