using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Account
{
     class Account:User
    {
        public Account(string Nm, string email, string pass) : base(Nm, email, pass)
        {
            
        }
        
        public override bool PasswordChecker()
        {
            bool symb = false;
            bool letdig = false;
            char currentchar;
            char currentchar2;
            if (!(this.Password.Length >= 8 && this.Password.Length <= 25))
            {
                return true;
            }
            string symbols = "!@#$%^&*()_-+=[{]};:<>|./?.";
            char[] simbolchar = symbols.ToCharArray();


            for (int j = 0; j < this.Password.Length; j++)
            {
                currentchar = this.Password[j];
                foreach (var simb in simbolchar)
                {
                    if (simb == currentchar)
                    {
                        symb = true;
                    }
                }
                if (symb)
                {
                    for (int i = 0; i < this.Password.Length; i++)
                    {
                        currentchar2 = this.Password[i];
                        if (char.IsUpper(currentchar2) && (char.IsLetterOrDigit(currentchar2)))
                        {
                            letdig = true;
                        }
                    }
                }
                if (letdig)
                {
                    Console.WriteLine("Daxil oldunuz");
                    return true;
                }
            }
            return letdig;

        }
        public override void FullName()
        {
            Console.WriteLine(Fullname + " " + Email);
        }


    }
}
