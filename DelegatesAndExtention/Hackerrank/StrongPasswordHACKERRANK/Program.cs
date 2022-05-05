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

            string special_characters = "!@#$%^&*()-+"; 
            Console.WriteLine("Daxil et parol");
            string password=Console.ReadLine();

            if (!string.IsNullOrEmpty(password)&&password.Length>5)
            {
                Console.WriteLine("daxil olduz");

            }
            else
            {

            }


        }
    }
}
