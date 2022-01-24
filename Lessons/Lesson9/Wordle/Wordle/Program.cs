using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wordle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string herf = "";
            int x = 0;
            for (int i = 0; i < 6; i++)
            {
                string array = "kartof";
                Console.WriteLine("sozu daxil et");
                string soz = Console.ReadLine();
                if (soz.Length != 6)
                {
                    Console.WriteLine("Minimum 6 herfli soz daxil etmelisiniz: ");
                    continue;
                }
                else
                {
                    for (int j = 0; j < array.Length; j++)
                    {
                        


                        for (int d = 0; d < soz.Length; d++)
                        {
                            if (soz[j] == array[j])
                            {
                                herf += array[j];
                               
                            }

                            else if (soz[d] == array[j])
                            {
                                Console.WriteLine(soz[d] +" "+ "herfi var ama yeri duz deil");

                            }
                        }
                        x++;
                        if (herf != "")
                        {  
                            Console.WriteLine(x + "sirada" + " " + herf[0]);
                            herf = "";
                        }
                       
                    }
                    x = 0;
                }
                if (soz == array)
                {
                    Console.WriteLine("Tebrikler duz tapdiniz");
                    break;
                }

            }

        }
    }
}

