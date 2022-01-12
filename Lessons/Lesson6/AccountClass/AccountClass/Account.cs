using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountClass
{
    internal class Account
    {
        public int No=0;
        public static int artim=0;
        public string Username;
        public string Password; 


        public Account(string usernm,string password)
        {
            Username = usernm;
            Password = password;
            artim++;
            No=artim;

        }

        public  string IsnameValid(string userka)
        {
            string result="basbayra";
            char[] userinadi = userka.ToCharArray();
            foreach (var herfler in userinadi)
            {
                if (!char.IsLetterOrDigit(herfler))
                {
                    
                }
                
            }
            return result;

        }
    }
}
