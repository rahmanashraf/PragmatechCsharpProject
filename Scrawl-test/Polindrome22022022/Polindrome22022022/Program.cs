using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polindrome22022022
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //DateTime baslangic = new DateTime(1995, 12, 31);

            //DateTime bitis = new DateTime(2050, 12, 31);
            //string startdate=baslangic.ToString("dd''MM''yyyy");
            //string lastdate=bitis.ToString("dd''MM''yyyy");





            for (int o = 1; o < 100; o++)
            {

                string items = DateTime.Today.AddDays(o).ToString("dd''MM''yyyy");
                if (Polindrome(items))
                {
                    Console.WriteLine(items);
                }

            }

        }
        public static bool Polindrome(string para)
        {
            char[] sozyigini = para.ToCharArray();
            char[] sozyigini2 = para.ToCharArray();
            string soz = "";
            string soz2 = "";
            bool result = true;
            for (int i = sozyigini.Length - 1; i > -1; i--)
            {
                soz += sozyigini[i];
            }
            for (int i = 0; i < sozyigini2.Length; i++)
            {
                soz2 += sozyigini2[i];
            }
            if (soz2 == soz)
            {
                return result;
            }
            return false;
        }
    }
}
