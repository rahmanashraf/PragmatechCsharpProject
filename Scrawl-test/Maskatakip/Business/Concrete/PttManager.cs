using Business.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PttManager : ISupplier
    {
        private IApplicantService _applicanservice;
        public PttManager(IApplicantService applicantservice)
        {
            _applicanservice = applicantservice;
        }
        public void GiveMask(Person person)
        {
            if (_applicanservice.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + "a maska verildi");
            }
            else
            {
                Console.WriteLine(person.FirstName + "a zad maska zad dusmur");
            }
        }
    }
}
