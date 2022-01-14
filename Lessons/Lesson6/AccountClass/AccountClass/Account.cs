using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountClass
{
    internal class Account
    {
        public int No;
        public string Username;
        public string Password;


        public Account(string usernm, string password)
        {
            Username = usernm;
            Password = password;
            No = 1;
        }

        public bool IsnameValid(string userka)
        {

            char[] userinadi = userka.ToCharArray();
            foreach (var herfler in userinadi)
            {
                if (!char.IsLetterOrDigit(herfler))
                {
                    return false;
                }

            }
            return true;

        }
        public bool IspasswordValid(string pass)
        {
            bool symb = false;
            bool letdig = false;
            int min = 8;
            int max = 25;
            char currentchar;
            char currentchar2;


            if (!(pass.Length >= min && pass.Length <= max))
            {
                return true;
            }
            string symbols = "!@#$%^&*()_-+=[{]};:<>|./?.";
            char[] simbolchar = symbols.ToCharArray();


            for (int j = 0; j < pass.Length; j++)
            {
                currentchar = pass[j];
                foreach (var simb in simbolchar)
                {
                    if (simb == currentchar)
                    {
                        symb = true;
                    }
                }
                if (symb)
                {
                    for (int i = 0; i < pass.Length; i++)
                    {
                        

                        currentchar2 = pass[i];
                        if (char.IsUpper(currentchar2) && (char.IsLetterOrDigit(currentchar2)))
                        {
                            letdig = true;
                        }
                    }
                }
                if (letdig)
                {
                    Console.WriteLine("xosgelmisinz");
                    return true;
                }
            }
            return letdig;

        }

    }
}


