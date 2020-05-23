using Facade.abstractas;
using Facade.subsistemas.banco;
using Facade.subsistemas.biller;
using Facade.subsistemas.crm;
using Facade.subsistemas.email;
using Facade.util;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace Facade.concretos
{
    public class PayFacadeImple : IPaymentFacade
    {
        private BankSystem bankSystem = new BankSystem();
        private BillingSystem billingSystem = new BillingSystem();
        private CRMSystem crmSystem = new CRMSystem();
        private EmailSystem emailSystem = new EmailSystem();

        public PaymentResponse pay(PaymentRequest request)
        {
            Customer customer = crmSystem.findCustomer(request.CustomerId);

            if (customer == null)
            {
                throw new Exception("Cliente no existe");
            }
            else if (customer.status.Equals("Baja"))
            {
                throw new Exception("Cliente dado de baja");
            }

            //realizar el cobro a la tarjeta de credito
            TransferRequest transfer = new TransferRequest(request.Amount,request.CardNumber,request.CardNAme,
                request.CardExpdate,request.CardSecureNumber);
            string reference= bankSystem.transfer(transfer);

            //llamado al sistema de fatuiracion
            BillingPayRequest billingRequest = new BillingPayRequest(request.CustomerId, request.Amount);
            double newBalance= billingSystem.pay(billingRequest);

            //determinar nuevo status
            string newStatus = customer.status;
            if (newBalance <= 50)
            {
                OnmemoryDataBase.changeCustomerStatus(request.CustomerId, newStatus);
                newStatus = "Activo";
            }

            //mandamos el email
            Dictionary<string, string> parans = new Dictionary<string, string>();

            parans.Add("$name", customer.name);
            parans.Add("$ammount", customer.ammount.ToString());
            parans.Add("$newBalance", request.Amount.ToString());
            string number = request.CardNumber;
            string subfix = number.Substring(number.Length - 4, 4);
            parans.Add("$cardNumber", subfix);
            parans.Add("$reference", reference);
            parans.Add("$newStatus", newStatus);
            
            emailSystem.sendEmail(parans);

            PaymentResponse response = new PaymentResponse(reference,newBalance,newStatus);
            return response;


        }
    }
}
