using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskMohtesem
{
    internal class Group
    {
        public int No = 100;
        private int Capacity;
        public string Name;
        public List <Student> students ;

        public Group(string name,int capas)
        {
            students = new List<Student>();
            Name = name;
            No++;
            Capacity = capas;
        }

        public void AddStudent(Student user)
        {
            students.Add(user);
        }
        public void Cixartmaq()
        {
            foreach (var item in students)
            {
                Console.WriteLine(item.No + " " + item.Name + " " + item.Surname);
            }
        }

    }
}
