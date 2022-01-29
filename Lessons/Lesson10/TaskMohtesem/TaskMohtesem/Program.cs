using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskMohtesem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" Bunlardan birini sec:  \n 1- yeni telebe yarat \n 2 - yeni qrup yarat \n 3 - telebenin siyahisini goster \n 4 - qruplarin siyahisini goster \n 5 - qrupa telebe elave et \n 6 - secilmis qrupdaki telebeleri goster \n 7 - sistemden cix");

            string secim = Console.ReadLine();
            School school = new School();
            Student studentka = new Student("Aysel", "Mustafayeva");
            Group grup = new Group("K172", 8);
            while (secim != "7")
            {
                if (secim == "1")
                {
                    Console.WriteLine(" Studentin Adini daxil et: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Familiyasini daxil et: ");
                    string surname = Console.ReadLine();
                    studentka = new Student(name, surname);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Telebeni yeni qrupa daxil etmek isteyirsense Yeni qrup yaradib 2 bas, \n eger qrup onceden yaratdigin qrup idise 5 bas");
                    Console.ForegroundColor = ConsoleColor.White;

                }
                else if (secim == "2")
                {
                    Console.WriteLine("Grupun adini daxil et: ");
                    string grupname = Console.ReadLine();
                    Console.WriteLine("Qrupun sayini daxil et: ");
                    int count = Convert.ToInt32(Console.ReadLine());
                    grup = new Group(grupname, count);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Evvel yaratdiqin studentkai daxil etmek istiyirsen?(Y/N)");
                    Console.ForegroundColor = ConsoleColor.White;
                    string secim2 = Console.ReadLine();
                    if (secim2 == "Y")
                    {
                        grup.AddStudent(studentka);
                    }
                    school.GrupudaxilEden(grup);
                }
                else if (secim == "3")
                {
                    school.ShagirdleriGoster();
                }
                else if (secim == "4")
                {
                    school.GruplariGostermek();
                }
                else if (secim == "5")
                {
                    Console.WriteLine("Olan qrupun adini daxil et:  ");
                    string ad = Console.ReadLine();
                    Console.WriteLine("Daha evvel yaraddigin studenti elave etmek isteyirsense 1, /n Teze student yaradacagsansa 2ni bas");
                    string daxilete = Console.ReadLine();
                    if (daxilete == "1")
                    {
                        school.Elaveetme(ad, studentka);
                    }
                    else
                    {
                        Console.WriteLine(" Studentin Adini daxil et: ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Familiyasini daxil et: ");
                        string surname = Console.ReadLine();
                        studentka = new Student(name, surname);
                        school.Elaveetme(ad, studentka);
                    }
                }
                else if (secim == "6")
                {
                    Console.WriteLine("Grupun adini daxil et: ");
                    string adi = Console.ReadLine();
                    school.Shagirdcixarmaq2(adi);
                }
                Console.WriteLine(" Bunlardan birini sec:  \n 1- yeni telebe yarat \n 2 - yeni qrup yarat \n 3 - telebenin siyahisini goster \n 4 - qruplarin siyahisini goster \n 5 - qrupa telebe elave et \n 6 - secilmis qrupdaki telebeleri goster \n 7 - sistemden cix");
                secim = Console.ReadLine();
            }
        }

    





