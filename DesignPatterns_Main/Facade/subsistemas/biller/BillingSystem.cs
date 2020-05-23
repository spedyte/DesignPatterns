using Facade.util;
using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.subsistemas.biller
{
    public class BillingSystem
    {
        public double queryCustomerBalance(long customerId)
        {
            Customer customer = OnmemoryDataBase.findCustomerById(customerId);
            return customer.balance;
        }

        public double pay(BillingPayRequest billingPay) { 
            Customer customer = OnmemoryDataBase.findCustomerById(billingPay.customerId);
            customer.balance= customer.balance - billingPay.amount;
            Console.WriteLine($"Pago aplicado al cliente: {customer.name} ," +
                $"El nuevo saldo es {customer.balance}");
            return customer.balance;//new Balance
        }
    }
}
