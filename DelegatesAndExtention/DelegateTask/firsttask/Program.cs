using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firsttask
{

    internal class Program
    {
        public delegate bool StringFilterDelegate(string ls);
        public static List<string> lst = new List<string>() { "Salam", "sagol", "neteRsen", "Xiyaristan", "abdulla" };
        public static void Main(string[] args)
        {

            var listim1 =StringFilter(x=>x.Length>5);
            foreach (var item in listim1)
            {
                //Console.WriteLine(item);
            }
            var listim2 = StringFilter(x =>x.IndexOf(0));
            foreach (var item in listim2)
            {
                Console.WriteLine(item);
            }


            var listim3 = StringFilter(x => Char.IsUpper(x,0));
            foreach (var item in listim3)
            {
                //Console.WriteLine(item);
            }

            
                // Funksiya aşağıdakı əməlyatları yerinə yetirə bilməlidir
                // List daxilindəki sözlərdən hərf sayı 5-dən böyük olanlar
                // Daxilində ən az bir ədəd böyük hərf olanlar
                // Baş hərfi böyük olanlar
                // Daxilində ə hərfi olanlar
            
        }
        public static List<string> StringFilter(StringFilterDelegate del)
        {
            var listim = new List<string>();
            foreach (var item in lst)
            {
                if (del(item))
                {
                    listim.Add(item);
                }
            }
            return listim;
        }

    }
}
