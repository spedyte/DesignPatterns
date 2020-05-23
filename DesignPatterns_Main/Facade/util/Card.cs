using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.util
{
    public class Card
    {
        public string binId { get; set; }
        public string binName { get; set; }

        public string TipoTarjeta { get; set; }

        public Card(string binId, string binName, string tipoTarjeta)
        {
            this.binId = binId;
            this.binName = binName;
            TipoTarjeta = tipoTarjeta;
        }
    }
}
