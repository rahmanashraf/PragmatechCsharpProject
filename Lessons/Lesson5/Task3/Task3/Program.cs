﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task Student class-i yaradin: Fullname GroupNo Age Student classi ucun GetBirthYear() metodunu yazin.
            //Bu metod Studentin dogum ilini geri qaytarir Student Arrayi yaradin.
            //Qrup nomresini daxil etmekle bir qrupda nece telebenin oxudugunu check eden method yazin.
            //(2ci parametr kimi array daxil edeceksiz) ps:Student yaradilarken butun deyerlerin verilmesi mecburidir;

            Student [] students =new Student[3];
            for (int i = 0; i < students.Length; i++)
            {


                Console.WriteLine("Adi daxil et: ");
                string ad = Console.ReadLine();

                Console.WriteLine("Qrupu  daxil et: ");
                string qrup = Console.ReadLine();

                Console.WriteLine("Yasi  daxil et: ");
                int dogumtarixi = Convert.ToInt32(Console.ReadLine());
                
                Student std = new Student(ad, qrup, dogumtarixi);
                std.GroupName = qrup;
                std.GetBirthYear(std);
               

                students[i] = std;

                foreach (var item in students)
                {
                    Console.WriteLine(item.Name+" "+item.GroupName+" "+item.GetBirthYear(std));
                }
                



                
                

               


        }
        }
    }
}
