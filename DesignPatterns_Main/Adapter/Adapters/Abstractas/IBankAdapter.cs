using Adapter.Adapters.Concretas;
using Adapter.APIS.BankX;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.Adapters.Abstractas
{
    public interface IBankAdapter
    {
        public BankCreditResponse sendCreditRequest(BankCreditRequest request);
    }
}
