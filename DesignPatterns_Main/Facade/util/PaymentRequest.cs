using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.util
{
    public class PaymentRequest
    {
        private long customerId;
        private double amount;
        private string cardNumber;
        private string cardNAme;
        private string cardExpdate;
        private string cardSecureNumber;

        public long CustomerId { get => customerId; set => customerId = value; }
        public double Amount { get => amount; set => amount = value; }
        public string CardNumber { get => cardNumber; set => cardNumber = value; }
        public string CardNAme { get => cardNAme; set => cardNAme = value; }
        public string CardExpdate { get => cardExpdate; set => cardExpdate = value; }
        public string CardSecureNumber { get => cardSecureNumber; set => cardSecureNumber = value; }

        public PaymentRequest(long customerId, double amount, string cardNumber, 
            string cardNAme, string cardExpdate, string cardSecureNumber)
        {
            this.customerId = customerId;
            this.amount = amount;
            this.cardNumber = cardNumber;
            this.cardNAme = cardNAme;
            this.cardExpdate = cardExpdate;
            this.cardSecureNumber = cardSecureNumber;
        }
    }
}
