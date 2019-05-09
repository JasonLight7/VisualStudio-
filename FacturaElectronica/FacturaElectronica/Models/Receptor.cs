using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FacturaElectronica.Models
{
    public class Receptor:Emisor
    {
        string IdentificacionExtranjero;

        public string IdentificacionExtranjeroPublico
        {
            get { return IdentificacionExtranjero; }
            set { IdentificacionExtranjero = value; }
        }


            public Receptor()
        {

        }
    }
}