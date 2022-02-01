using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Account
{
    abstract class User
    {
        public string Fullname;
        public string Email;
        public string Password;

        public User(string Nm,string email,string pass)
        {
            Fullname = Nm;
            Email = email;  
            Password = pass;
        }


        public abstract bool PasswordChecker();
        

        
        public virtual void FullName()
        {
            Console.WriteLine(Fullname+" "+Email);
        }

    }
}
