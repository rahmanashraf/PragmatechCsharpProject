using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTestStudent
{
    public class Student
    {
        public string Fullname;
        public string GroupNo;
        public int Age;

        public Student(string fullname,string qrupno,int age)
        {
            Fullname = fullname;
            GroupNo = qrupno;
            Age = age;  
        }
        public void GetBirthYear(Student student)
        {
            int year=DateTime.Now.Year - student.Age;
            Console.WriteLine(year);
        }
    }

}
