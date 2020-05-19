using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy.Servicios
{
    public class SecurityService
    {
        public bool authorizacion(string user, string password)
        {
            if (user.Equals("userAutorizado") && password.Equals("1234"))
            {
                Console.WriteLine($"Usuario {user} ES autorizado");
                return true;
            }
            else
            {
                Console.WriteLine($"Usuario {user} NO autorizado");
                return false;
            }
        }
    }
}
