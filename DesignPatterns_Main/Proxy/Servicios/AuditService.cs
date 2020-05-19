using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy.Servicios
{
    public class AuditService
    {
        public void auditserviceUsed(string user, string service)
        {
            Console.WriteLine($" {user} utilizó el servicio => {service} -  " +
                $"a las {DateTime.Now.ToString("dd/MM//yy hh:mm:ss")}");
        }
    }
}
