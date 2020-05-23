using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.subsistemas.biller
{
    public class BillingPayRequest
    {
        public long customerId { get; set; }

        public double amount { get; set; }

        public BillingPayRequest(long customerId,double amount)
        {
            this.customerId = customerId;
            this.amount = amount;
        }
    }
}
