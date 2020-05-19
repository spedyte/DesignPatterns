using Proxy.Abstractos;
using Proxy.Concretos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy.Factory
{
    public class ServiceFactory
    {
        public static IProcessExecutor createProcessExecutor() {
            return new ProcessExecutorProxy();
        }
    }
}
