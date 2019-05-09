using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FacturaElectronica.Models
{
    public class Impuesto
    {

        string Codigo;

        public string CodigoPublico
        {
            get { return Codigo; }
            set { Codigo = value; }
        }
        string Tarifa;

        public string TarifaPublico
        {
            get { return Tarifa; }
            set { Tarifa = value; }
        }
        string Monto;

        public string MontoPublico
        {
            get { return Monto; }
            set { Monto = value; }
        }
        Exoneracion Exoneracion;

        public Exoneracion ExoneracionPublico
        {
            get { return Exoneracion; }
            set { Exoneracion = value; }
        }

           public Impuesto()
        {

        }
    }
}