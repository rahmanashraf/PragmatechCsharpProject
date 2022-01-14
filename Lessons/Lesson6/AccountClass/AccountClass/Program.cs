using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account[] accarray = new Account[3];
            for (int i = 0; i < accarray.Length; i++)
            {
                Console.WriteLine("Usernameni daxil edin: ");
                string username = Console.ReadLine();
                Console.WriteLine("Passwordu daxil edin: ");
                string password = Console.ReadLine();

                
                Account acc = new Account(username, password);
                acc.No = i;

                acc.IsnameValid(username);
                acc.IspasswordValid(password);
                accarray[i] = acc;
            }

        } 
        
    }
}
