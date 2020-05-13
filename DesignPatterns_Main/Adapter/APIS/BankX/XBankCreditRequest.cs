using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.APIS.BankX
{
    public class XBankCreditRequest
    {
        private string CustomerName { get; set; }
        private double requestAmount { get; set; }

        public string getrCustomerName() {
            return CustomerName;
        }

        public void setCustomerName(string customerName)
        {
            this.CustomerName = customerName;
        }

        public double getRequestAmount() 
        {
            return this.requestAmount;
        }

        public void setRequestAmount(double amount)
        {
            this.requestAmount=amount;
        }
    }
}
