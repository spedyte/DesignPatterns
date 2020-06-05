using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.util
{
    public class Principal
    {
        public string user { get; set; }
        public string rol { get; set; }

        public override string ToString()
        {
            return $"Principal (user= {user} -> rol= {rol} )";
        }
    }
}
