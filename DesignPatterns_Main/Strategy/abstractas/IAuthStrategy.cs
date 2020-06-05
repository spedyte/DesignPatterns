using Strategy.util;
using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace Strategy.abstractas
{
    public interface IAuthStrategy
    {
        public Principal authenticate(string user, string pwd);
    }
}
