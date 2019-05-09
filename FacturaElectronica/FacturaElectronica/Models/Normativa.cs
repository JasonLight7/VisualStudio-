using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FacturaElectronica.Models
{
    public class Normativa
    {
        string NumeroResolucion;

        public string NumeroResolucionPublico
        {
            get { return NumeroResolucion; }
            set { NumeroResolucion = value; }
        }
        DateTime FechaResolucion;

        public DateTime FechaResolucionPublico
        {
            get { return FechaResolucion; }
            set { FechaResolucion = value; }
        }
        public Normativa()
        {

        }
    }
}