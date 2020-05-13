using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.APIS.BankX
{
    public class XBankCreditAPI
    {
        public XbankCreditResponse sendCreditRequest(XBankCreditRequest request)
        {
            XbankCreditResponse response = new XbankCreditResponse();
            if (request.getRequestAmount() <= 5000)
            {
                response.Approval=true;
            }
            else
            {
                response.Approval = false;
            }
            return response;
        }
    }
}
