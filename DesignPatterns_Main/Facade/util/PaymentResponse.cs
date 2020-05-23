using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.util
{
    public class PaymentResponse
    {
        private string payReference;
        private double newBalance;
        private string newStatus;

        public string PayReference { get => payReference; set => payReference = value; }
        public double NewBalance { get => newBalance; set => newBalance = value; }
        public string NewStatus { get => newStatus; set => newStatus = value; }

        public PaymentResponse(string confirmNumber,double newBalance,string newStatus)
        {
            this.payReference = confirmNumber;
            this.newBalance = newBalance;
            this.newStatus = newStatus;
        }
    }
}
