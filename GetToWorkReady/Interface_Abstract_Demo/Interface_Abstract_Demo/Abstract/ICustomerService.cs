using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interface_Abstract_Demo.Entities;

namespace Interface_Abstract_Demo.Abstract
{
    public interface ICustomerService
    {
        void Save(Customer customer);
    }
}
