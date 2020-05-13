using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.APIS.BankW
{
    public interface WBankCreditSenderListener
    {
        public void notifyCreditResult(WBankCreditApproveResult result);
    }
}
