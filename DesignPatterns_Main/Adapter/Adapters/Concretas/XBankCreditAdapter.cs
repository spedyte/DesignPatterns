using Adapter.Adapters.Abstractas;
using Adapter.APIS.BankX;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.Adapters.Concretas
{
    public class XBankCreditAdapter : IBankAdapter
    {
        public BankCreditResponse sendCreditRequest(BankCreditRequest request)
        {
            XBankCreditAPI api = new XBankCreditAPI();

            XBankCreditRequest xRequest = new XBankCreditRequest();
            xRequest.setCustomerName(request.Customer);
            xRequest.setRequestAmount(request.Amount);

            XbankCreditResponse xResponse= api.sendCreditRequest(xRequest);
            BankCreditResponse response = new BankCreditResponse();

            response.Approved = xResponse.isApproval();

            return response;
        }

    }
}
