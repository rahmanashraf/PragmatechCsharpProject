using Interface_Abstract_Demo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Abstract_Demo.Abstract
{
    public abstract class BaseInterface : ICustomerService, IEntities
    {
        public void Save(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
