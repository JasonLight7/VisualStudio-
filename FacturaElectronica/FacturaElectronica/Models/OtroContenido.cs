using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FacturaElectronica.Models
{
    public class OtroContenido
    {
        string Codigo;

        public string CodigoPublico
        {
            get { return Codigo; }
            set { Codigo = value; }
        }
          public OtroContenido()
        {

        }
    }
}