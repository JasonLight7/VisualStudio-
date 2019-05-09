using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FacturaElectronica.Models
{
    public class Exoneracion
    {

        string TipoDocumento;

        public string TipoDocumentoPublico
        {
            get { return TipoDocumento; }
            set { TipoDocumento = value; }
        }
        string NumeroDocumento;

        public string NumeroDocumentoPublico
        {
            get { return NumeroDocumento; }
            set { NumeroDocumento = value; }
        }
        string NombreInstitucion;

        public string NombreInstitucionPublico
        {
            get { return NombreInstitucion; }
            set { NombreInstitucion = value; }
        }
        DateTime FechaEmision;

        public DateTime FechaEmisionPublico
        {
            get { return FechaEmision; }
            set { FechaEmision = value; }
        }
        string MontoImpuesto;

        public string MontoImpuestoPublico
        {
            get { return MontoImpuesto; }
            set { MontoImpuesto = value; }
        }
        string PorcentajeCompra;

        public string PorcentajeCompraPublico
        {
            get { return PorcentajeCompra; }
            set { PorcentajeCompra = value; }
        }

         public Exoneracion()
        {

        }
    }
}