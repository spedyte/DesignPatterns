using Strategy.abstractas;
using Strategy.util;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.concretas
{
    public class XMLAuthStrategy : IAuthStrategy
    {
        public Principal authenticate(string user, string pwd)
        {
            var rol = XMLUserUtil.getRolByPrincipal(user, pwd);
            if (rol == null)
                return null;
            else
                return new Principal() { rol=rol,user=user};
        }
    }
}
