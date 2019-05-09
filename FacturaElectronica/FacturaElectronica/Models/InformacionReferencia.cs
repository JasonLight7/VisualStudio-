using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FacturaElectronica.Models
{
    public class InformacionReferencia
    {
        string TipoDoc;

        public string TipoDocPublico
        {
            get { return TipoDoc; }
            set { TipoDoc = value; }
        }
        string Numero;

        public string NumeroPublico
        {
            get { return Numero; }
            set { Numero = value; }
        }
        DateTime FechaEmision;

        public DateTime FechaEmisionPublico
        {
            get { return FechaEmision; }
            set { FechaEmision = value; }
        }
        string Codigo;

        public string CodigoPublico
        {
            get { return Codigo; }
            set { Codigo = value; }
        }
        string Razon;

        public string RazonPublico
        {
            get { return Razon; }
            set { Razon = value; }
        }
         public InformacionReferencia()
        {

        }
    }
}