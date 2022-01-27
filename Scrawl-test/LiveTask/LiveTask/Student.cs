using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveTask
{
    internal class Student
    {
        public string Name;
        public string Surname;
        public int Age;
        public int Count=0;
        public static int Plusser;

        public Student(string names,string surnames,int ages)
        {
           Name = names;    
           Surname = surnames;
           Age = ages;
           Plusser++;
           Count = Plusser;
           Console.WriteLine($"{Count}nci adam qeydiyatdan kecdi ");

        }
    }
}
