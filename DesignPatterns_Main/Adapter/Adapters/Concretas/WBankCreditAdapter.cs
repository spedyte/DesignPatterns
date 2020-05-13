using Adapter.Adapters.Abstractas;
using Adapter.APIS.BankW;
using Adapter.APIS.BankX;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading;

namespace Adapter.Adapters.Concretas
{
    public class WBankCreditAdapter : IBankAdapter,WBankCreditSenderListener
    {
        private WBankCreditApproveResult wResult;
        public void notifyCreditResult(WBankCreditApproveResult result)
        {
            this.wResult = result; 
        }

        public BankCreditResponse sendCreditRequest(BankCreditRequest request)
        {
            WBankCreditSender api = new WBankCreditSender();

            WBankCreditApprove wRequest = new WBankCreditApprove();

            wRequest.Credit = (float)request.Amount;
            wRequest.Name = request.Customer;

            api.sendCreditForValidate(wRequest, this); //nos llama aquien una vez que termina la respuesta asincrona

            do {
                try
                {
                    Thread.Sleep(10000);
                    Console.WriteLine("Bank W waiting for response");
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            } while (wResult==null);

            BankCreditResponse response = new BankCreditResponse();
            response.Approved = wResult.Approved.ToLower().Equals("y");
            return response;
        }
    }
}
