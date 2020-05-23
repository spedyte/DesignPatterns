using Facade.util;
using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.abstractas
{
    public interface IPaymentFacade
    {
        public PaymentResponse pay(PaymentRequest request);

    }
}
