using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_Register.Client
{
    internal class Users
    {
        public int Id { get; set; }
        public  string Name { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }    
        public string Email { get; set; }
        public DateTime date { get; set; }

        public Users()
        {
            Register registr = new Register();
            Random random = new Random();
            this.Id=random.Next(1,1000);
            this.Name = registr.RegisterName;
            this.Surname = registr.RegisterSurname;
            this.Email = registr.RegisterEmail;

            Random Rnd = new Random();
            StringBuilder StrBuild = new StringBuilder();
            for (int i = 0; i < 8; i++)
            {
                int ASCII = Rnd.Next(32, 127);
                char Karakter = Convert.ToChar(ASCII);
                StrBuild.Append(Karakter);
            }
            this.Password = StrBuild.ToString();
            this.date = DateTime.Now;
        }
        
    }
}
