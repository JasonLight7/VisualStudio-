using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FacturaElectronica.Models
{
    public class Otros
    {
        OtroTexto OtroTexto;

        public OtroTexto OtroTextoPublico
        {
            get { return OtroTexto; }
            set { OtroTexto = value; }
        }
        OtroContenido OtroContenido;

        public OtroContenido OtroContenidoPublico
        {
            get { return OtroContenido; }
            set { OtroContenido = value; }
        }

          public Otros()
        {

        }
    }
}