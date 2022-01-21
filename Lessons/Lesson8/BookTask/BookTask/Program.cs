using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Book [] books=new Book[2];
            
            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine("Kitabin adini daxil edin: ");
                string kitabadi=Console.ReadLine();
                if (kitabadi.Length < 3)
                {
                    
                    Console.WriteLine("Kitabin adi 3 herfden cox olmalidir qaqash");
                    Console.WriteLine("Kitabin adini yeniden daxil edin: ");
                    string kitaba = Console.ReadLine();
                    kitabadi = kitaba;

                }
                Console.WriteLine("Kitab neche sehifeden ibaretdir: ");
                int kitabsehifesi=Convert.ToInt32(Console.ReadLine());
                if ( kitabsehifesi < 10)
                {
                    Console.WriteLine("Kitabin sehifesi 10 sehifeden cox olmalidir qaqash");
                    Console.WriteLine("Kitabin sayini yeniden daxil edin: ");
                    int vereqsayi = Convert.ToInt32(Console.ReadLine());
                    kitabsehifesi =vereqsayi;

                }
                Console.WriteLine("Kitab neche eded daxil olunur: ");
                int kitabededi = Convert.ToInt32(Console.ReadLine());

                Book kitabxana=new Book(kitabadi,kitabsehifesi,kitabededi);
                books[i]=kitabxana;

                


            }
            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine("Kitab adi:"+" " + books[i].Name + " "+ "sehifesayi:" + " " + books[i].Page + " " + "kitab sayi:" + " " + books[i].Count);
            }

            
        }
}
}
