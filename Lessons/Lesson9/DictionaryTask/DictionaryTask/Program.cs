using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryTask
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, string> olkeler = new Dictionary<string, string>();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Olke adnii daxil edin: ");
                string olkeadi = Console.ReadLine();
                Console.WriteLine("Paytaxt adnii daxil edin: ");
                string paytaxt = Console.ReadLine();
                olkeler.Add(olkeadi, paytaxt);

            }

            string input = "all";
            char yes = 'y';
            char no = 'n';
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Olke adni yaz paytaxt adini deyim: ");
                string pytxttap = Console.ReadLine();
                foreach (var item in olkeler)
                {
                    if (item.Key == pytxttap)
                    {
                        Console.WriteLine(item.Value);
                    }

                    else if (pytxttap == input)
                    {
                        Console.WriteLine(item.Value);
                    }
                }
                Console.WriteLine("Davam etmek isteyirsen:y/n ");
                char davam = Convert.ToChar(Console.ReadLine());
                if (davam == yes)
                {

                }

                else if (davam == no)
                {
                    Console.WriteLine("Eməliyyatınız sona yetmişdir. Bizi seçdiiyiniz üçün teşekkür edirik");
                    break;

                }
            }


        }
    }

}


