using Strategy.abstractas;
using Strategy.util;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.concretas
{
    public class OnMemoryAuthstrategy : IAuthStrategy
    {
        public Principal authenticate(string user, string pwd)
        {
            var userDB =OnMemoryDataBase.findUserById(user);

            if (userDB == null)
                return null;
            else if (!userDB.pwd.Equals(pwd))
                return null;
            else
                return new Principal() { user=user, rol=userDB.rol};
        }
    }
}
