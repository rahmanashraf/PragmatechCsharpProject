using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interface_Abstract_Demo.Abstract;
using Interface_Abstract_Demo.Entities;

namespace Interface_Abstract_Demo.Concrete
{
    public class Starbucks : ICustomerService
    {
        public void Save(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
