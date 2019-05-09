using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FacturaElectronica.Models
{
    public class Codigo
    {
        string Tipo;

        public string TipoPublico
        {
            get { return Tipo; }
            set { Tipo = value; }
        }
        string Codigo;

        public string CodigoPublico
        {
            get { return Codigo; }
            set { Codigo = value; }
        }
          public Codigo()
        {

        }
    }
}