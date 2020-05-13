using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.APIS.BankX
{
    public class XbankCreditResponse
    {
        public bool Approval { get; set; }

        public bool isApproval() {
            return this.Approval;
        }

        public void setApproval(bool approval) {
            this.Approval = approval;
        }
    }
}
