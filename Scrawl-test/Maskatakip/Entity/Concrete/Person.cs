using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    internal class Person
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }    
        public long PassportId { get; set; }
        public int DateOfBirthdayYear { get; set; } 
    }
}
