using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firsttask
{
    delegate void StringFilterDelegate(string str);
    internal class Program
    {
        
        static void Main(string[] args)
        {

            List<string> list = new List<string>() { "salam", "sagol", "netersen", "xiyaristan", "abdulla" };
            StringFilter("soz", StringFilterDelegate del);
                // Funksiya aşağıdakı əməlyatları yerinə yetirə bilməlidir
                // List daxilindəki sözlərdən hərf sayı 5-dən böyük olanlar
                // Daxilində ən az bir ədəd böyük hərf olanlar
                // Baş hərfi böyük olanlar
                // Daxilində ə hərfi olanlar
            
        }
        public List<string> StringFilter(string ls, StringFilterDelegate del)
        {
            return del;
        }
    }
}
