using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FacturaElectronica.Models
{
    public class Identificacion
    {

        string Tipo;

        public string TipoPublico
        {
            get { return Tipo; }
            set { Tipo = value; }
        }
        string Numero;

        public string NumeroPublico
        {
            get { return Numero; }
            set { Numero = value; }
        }


         public Identificacion()
        {

        }

    }
}




