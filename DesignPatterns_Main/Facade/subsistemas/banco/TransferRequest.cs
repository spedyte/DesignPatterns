namespace Facade.subsistemas.banco
{
    public class TransferRequest
    {
        public double amount { get; set; }
        public string cardNumber { get; set; }

        public string cardName { get; set; }

        public string cardExpDate { get; set; }

        public string cardSecureNumber { get; set; }

        public TransferRequest(double amount, string cardNumber,string cardName,string cardExpDate,
            string cardSecureNumber)
        {
            this.amount = amount;
            this.cardNumber = cardNumber;
            this.cardName = cardName;
            this.cardExpDate = cardExpDate;
            this.cardSecureNumber = cardSecureNumber;
        }
    }
}
