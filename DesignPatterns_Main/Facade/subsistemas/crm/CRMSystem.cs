using Facade.util;
using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.subsistemas.crm
{
    public class CRMSystem
    {
        public Customer findCustomer(long customerId) {
            return OnmemoryDataBase.findCustomerById(customerId);
        }
    }
}
