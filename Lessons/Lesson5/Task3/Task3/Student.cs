using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Student
    {
        public string Name;
        public string GroupName;
        public int Age;

        public Student(string fullname, string qrupno, int age)
        {
            Name = fullname;
            GroupName = qrupno;
            Age = age;
        }

        public int GetBirthYear(Student student)
        {
            int year = DateTime.Now.Year - student.Age;
            return year;
        }

    }
}
