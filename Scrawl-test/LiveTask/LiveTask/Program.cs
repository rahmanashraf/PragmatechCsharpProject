using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student [] students = new Student[4];
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine("Adam adini daxil et: ");
                string adsan = Console.ReadLine();
                Console.WriteLine("soyadini daxil et: ");
                string makikosan = Console.ReadLine();
                Console.WriteLine("Yashi daxil et: ");
                int ages=Convert.ToInt32(Console.ReadLine());



                Student studentka = new Student(adsan,makikosan,ages);
                students[i]=studentka;
                
            }
            
            
        }
    }
}
