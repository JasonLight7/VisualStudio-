using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FacturaElectronica.Models
{
    public class TelefonoPadre
    {
        string CodigoPais;

        public string CodigoPaisPublico
        {
            get { return CodigoPais; }
            set { CodigoPais = value; }
        }

        string NumTelefono;

        public string NumTelefonoPublico
        {
            get { return NumTelefono; }
            set { NumTelefono = value; }
        }

          public TelefonoPadre()
        {

        }

    }
}