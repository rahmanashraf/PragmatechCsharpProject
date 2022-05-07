using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrongPasswordHACKERRANK
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///parol lazimdi 6 herfli olmaliid en azii
            ///bir xarakter bir lower bir upper olmalidi
            ///input parol olanda neche karakter eksiydise  dimelidi ama sirf uzunliga nisbeten nece xarakter catmir o yox
            ///umumietle nece dene sey yazsan duzelecey onu istiyir
            ///


            Console.WriteLine("Daxil et parol");
            string password = Console.ReadLine();
            if (CheckPassword(password))
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Basenko bayrenko");
            }




        }
        public static bool CheckPassword(string pass)
        {
            string special_characters = "!@#$%^&*()-+";
            bool result = false;
            bool birsert = false;
            bool ikisert = false;
            bool ucsert = false;
            bool dordsert = false;
            int error1 = 0;
            int error2 = 0;
            int error3=0;

            int size = pass.Length;

            for (int i = 0; i < pass.Length; i++)
            {
                if (pass.Length > 5)
                {
                    birsert = true;
                    if (Char.IsUpper(pass[i]))
                    {
                        ikisert = true;
                        error1++;
                    }
                 
                    if (ikisert)
                    {
                        for (int a = 0; a < special_characters.Length; a++)
                        {
                            if (special_characters[a] == pass[i])
                            {
                                ucsert = true;
                            }
                        }
                    }
                    if (ucsert)
                    {
                        if (Char.IsLower(pass[i]))
                        {
                           
                            dordsert = true;
                            
                        }

                    }
                }
                else
                {

                }

            }
            if (birsert && ikisert && ucsert && dordsert)
            {
                result = true ;
            }


            return result;

        }
    }
}
