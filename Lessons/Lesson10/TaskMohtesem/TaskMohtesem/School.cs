using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskMohtesem
{
    internal class School
    {
        List<Group> mekteb = new List<Group>();
        public void GrupudaxilEden(Group grup)
        {
            mekteb.Add(grup);
        }
        public void GruplariGostermek()
        {
            foreach (var grups in mekteb)
            {
                Console.WriteLine(grups.No + " " + grups.Name);
            }
        }

        public void ShagirdleriGoster()
        {
            foreach (var grups in mekteb)
            {
                grups.Cixartmaq();
            }
        }
        public void Elaveetme(string name, Student user)
        {
            foreach (var gruplar in mekteb)
            {
                if (gruplar.Name == name)
                {
                    gruplar.AddStudent(user);
                }
            }
        }
        public void Shagirdcixarmaq2(string namegrup)
        {
            foreach (var gruplar in mekteb)
            {
                if (gruplar.Name == namegrup)
                {
                    gruplar.Cixartmaq();
                }
            }
        }
    }
}
