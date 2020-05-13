using System;
using System.Collections.Generic;
using System.Net.Cache;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading;

namespace Adapter.APIS.BankW
{
    public class WBankCreditSender
    {
        private WBankCreditApprove request;
        private WBankCreditSenderListener listener;

        public void sendCreditForValidate(WBankCreditApprove request, WBankCreditSenderListener listener )
        {
            this.request = request;
            this.listener = listener;
            Thread newThread = new Thread(new ThreadStart(Run));
            newThread.Start();
        }

        public void Run()
        {
            Console.WriteLine("WBank recibio su peticion de solicitud de credito...sea paciente");
            WBankCreditApproveResult response = new WBankCreditApproveResult();
            
            if (this.request.Credit <= 1500)
            {
                response.Approved="Y";
            }
            else
            {
                response.Approved = "N";
                try
                {
                    Thread.Sleep(1000 * 30);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.StackTrace.ToString());
                    throw ex;
                }
                this.listener.notifyCreditResult(response);
            }
        }
    }
}
