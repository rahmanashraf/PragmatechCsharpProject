using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test123
{
    internal class Class1
    {
        public string Name;
        public string Surname;

        public Class1(string usernames, string surnames)
        {
            Name = usernames;
            Surname = surnames;
        }

        public void FullName(string name, string surname)
        {
            Console.WriteLine(name + " " + surname);
        }
        public static void StaticliName(string names, string surnames)
        {
            Console.WriteLine(names + surnames);
        }
    }
}
