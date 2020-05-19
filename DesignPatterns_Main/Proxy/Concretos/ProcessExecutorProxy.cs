using Proxy.Abstractos;
using Proxy.Servicios;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy.Concretos
{
    public class ProcessExecutorProxy : IProcessExecutor
    {
        public void EjecuteProcess(int idProcess, string user, string password)
        {
            //accion previa
            SecurityService security = new SecurityService();
            bool autenthicated =security.authorizacion(user,password);
            if (!autenthicated) {
                throw new Exception("Autorizacion denegada");
            }

            //llamada al servicio real
            DefaultProcessExecutor process = new DefaultProcessExecutor();
            process.EjecuteProcess(idProcess,user,password);

            //accion posterior
            AuditService sudit = new AuditService();
            sudit.auditserviceUsed(user,nameof(DefaultProcessExecutor));
        }
    }
}
