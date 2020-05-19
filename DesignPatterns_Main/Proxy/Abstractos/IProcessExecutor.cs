using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy.Abstractos
{
    public interface IProcessExecutor
    {
        /// <summary>
        /// Lol
        /// </summary>
        /// <exception cref="Exception">Thrown when <paramref name="idProcess"> 
        /// throws <c>an exception</c></exception>
        /// <remarks>Implementors, pretty please throw E if Process 
        /// throws an exceptionkthx</remarks>
        public void EjecuteProcess(int idProcess, string user, string password);
    }
}
