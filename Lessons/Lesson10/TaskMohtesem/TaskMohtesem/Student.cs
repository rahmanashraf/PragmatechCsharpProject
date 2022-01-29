using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskMohtesem
{
    internal class Student
    {
        public int No;
        public int Plusser = 1;
        public string Name;
        public string Surname;

        public Student(string name,string surname)
        {
            Name = name;
            Surname = surname;          
            No = Plusser++;
        }
    }
}
