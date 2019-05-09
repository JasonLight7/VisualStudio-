using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FacturaElectronica.Models
{
    public class OtroTexto
    {
        string Codigo;

        public string CodigoPublico
        {
            get { return Codigo; }
            set { Codigo = value; }
        }
          public OtroTexto()
        {

        }
    }
}