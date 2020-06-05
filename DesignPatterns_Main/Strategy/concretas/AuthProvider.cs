using Strategy.abstractas;
using Strategy.util;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.concretas
{
    public class AuthProvider
    {
        private IAuthStrategy strategy;

        public AuthProvider(IAuthStrategy strategy)
        {
            this.strategy = strategy;
        }

        public void setAuthStrategy(IAuthStrategy strategy) {
            this.strategy = strategy;
        }

        public Principal authenticate(string user, string pwd)
        {
            return strategy.authenticate(user, pwd);
        }
    }
}
