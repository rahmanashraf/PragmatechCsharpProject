using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTestStudent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student std = new Student("RahmanAshrafov", "BM404", 27);
            std.GetBirthYear(std);
            Console.WriteLine(std.Fullname);
            Console.WriteLine(std.GroupNo);
            Console.WriteLine(std.Age);






        }
    }
}
