using Adapter.Adapters.Concretas;
using System;

namespace Adapter
{
    public  class AdapterMain
    {
        public AdapterMain()
        {
            /*
          TIPO  DE PATRON: Estructural (Tipo de patron utilizado )

          OBJETIVO :: Es utilizado cuando se tiene interfaces de software incompatibles que tiene funcionalidad muy similar,
                        se ADAPTAN para que trabajen juntas para alcanzar un objetivo en comun.SE crea una interfaz intermedia
                        entre el cliente y el COMPONENTE ADAPTADO.

          TIPS: Cuando se tienen sistemas legados de antaño o cuando la respuesta de la fuente es incompatbible con el cliente.
                Cuando buscamos HOMOGENEIZAR la forma de trabajar con interfaces incompatbibles mediante una INTERZ COMUN

          ESCENARIO: Tenemos un sistema encargado de realizar prestamos personales por medio de 2 bancos (BancoX y BancoW)
                    CAda banco tiene sus propias APIs para comunicarse con ellos. El BancoX tiene una interfaz Sincrona
                    y el BancoW tiene una interfaz Asincrona y los tipos de datos en cada API son diferentes

          IMPLEMENTACION: La implementacion del patron se llama desde la clase  ..... XBankCreditAdapter y WBankCreditAdapter
         */
        }

        public void Run()
        {

            BankCreditRequest request = new BankCreditRequest() {Amount=2000,Customer="John Lewis" };

            XBankCreditAdapter xBank = new XBankCreditAdapter();
            BankCreditResponse response= xBank.sendCreditRequest(request);
            Console.WriteLine($"Banco X aprobo el credito? R :::  => {response.Approved}");

            WBankCreditAdapter wBank = new WBankCreditAdapter();
            BankCreditResponse yResponse = wBank.sendCreditRequest(request);
            Console.WriteLine($"Banco W aprobo el credito? R :::  => {yResponse.Approved}");
                        
        }
    }
}
