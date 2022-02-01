using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Account
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account user = new Account("elmar","elmar@gmail.com","Aydan12345#");
            user.PasswordChecker();
            user.FullName();
        }
    }
}
