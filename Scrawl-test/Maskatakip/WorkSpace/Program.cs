// See https://aka.ms/new-console-template for more information

using Business.Concrete;
using Entity.Concrete;

Person person = new Person();
person.PassportId = 123;
person.FirstName = "ENGİN";
person.LastName = "DEMİROĞ";
person.DateOfBirthdayYear = 1985;

PttManager pttmanager = new PttManager(new PersonManager());
pttmanager.GiveMask(person);
Console.ReadLine();
