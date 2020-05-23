using Facade.util;
using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.subsistemas.banco
{
    public class BankSystem
    {
        public string transfer(TransferRequest request)
        {
            string cardNumberPreFix = request.cardNumber.Substring(0,3);
            if(!OnmemoryDataBase.validateCardBins(cardNumberPreFix))
            {
                throw new Exception("Tarjeta invalida");    
            }

            string cardCompany = OnmemoryDataBase.getCardCompany(cardNumberPreFix);
            if ("AMEX".Equals(cardCompany) && request.cardNumber.Length !=15)
            {
                throw new Exception("El numero de tarjeta es invalido");
            }
            else if (("VISA".Equals(cardCompany) || "MASTERCARD".Equals(cardCompany)) && request.cardNumber.Length != 16)
            {
                throw new Exception("El numero de la tarjeta es invalido");
            }
            string number = request.cardNumber;
            string cardNumberSubfix= number.Substring(number.Length-4,4);
            Console.WriteLine($"Se ha realizado un cargo al cliente {request.cardName} {Environment.NewLine}" +
                $"\t por el monto de {request.amount}  a la tarjeta con terminacion {cardNumberSubfix}");

            return System.Guid.NewGuid().ToString();

        }
    }
}
