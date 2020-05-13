using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.Adapters.Concretas
{
    public class BankCreditRequest
    {
        public string Customer { get; set; }
        public double Amount { get; set; }
    }
}
