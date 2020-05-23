using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Facade.util
{
    public static class OnmemoryDataBase
    {
        private static Dictionary<long, Customer> CUSTOMER_MAP = new Dictionary<long, Customer>();
        private static Dictionary<string, Card> CARD_BINS = new Dictionary<string, Card>();

        static OnmemoryDataBase()
        {
            CUSTOMER_MAP.Add(1, new Customer() { ammount = 500, balance = 500, customerId = 1, name = "Oscar Blancarte", status = "Alta" });
            CUSTOMER_MAP.Add(2, new Customer() { ammount = 300, balance = 300, customerId = 2, name = "Juan Blancarte", status = "Suspendido" });
            CUSTOMER_MAP.Add(3, new Customer() { ammount = 100, balance = 100, customerId = 3, name = "Guilon Blancarte", status = "Activo" });
            CUSTOMER_MAP.Add(4, new Customer() { ammount = 100, balance = 100, customerId = 4, name = "Luis Blancarte", status = "Baja" });


            CARD_BINS.Add("123", new Card("123","VISA","Credito"));
            CARD_BINS.Add("234", new Card("123", "MASTERCARD", "Credito"));
            CARD_BINS.Add("345", new Card("345", "AMEX", "Credito"));

        }

        public static Customer findCustomerById(long id)
        {
            return CUSTOMER_MAP.GetValueOrDefault(id);
        }

        public static string getCardCompany(string companyPPrefix)
        {
            return CARD_BINS.GetValueOrDefault(companyPPrefix).binName;
        }

        public static void changeCustomerStatus(long customerID, string newStatus)
        {
            CUSTOMER_MAP.GetValueOrDefault(customerID).status = newStatus;
        }

        public static bool validateCardBins(string cardNumberPreFix)
        {
            return CARD_BINS.ContainsKey(cardNumberPreFix);
        }
    }
}
