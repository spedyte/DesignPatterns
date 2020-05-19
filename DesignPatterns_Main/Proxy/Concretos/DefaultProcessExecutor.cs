using Proxy.Abstractos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy.Concretos
{
    public class DefaultProcessExecutor : IProcessExecutor
    {
        public void EjecuteProcess(int idProcess, string user, string password)
        {
            Console.WriteLine("Proceso ejecutado");
        }
    }
}
