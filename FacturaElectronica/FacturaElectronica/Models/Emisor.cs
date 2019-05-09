using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;



namespace FacturaElectronica.Models
{
    public class Emisor
    {
        string Nombre; // Declaramos el atributo nombre de la clase emisor

        public string NombrePublico // 
        {
            get { return Nombre; }
            set { Nombre = value; }
        }
        string NombreComercial;

        public string NombreComercialPublico
        {
            get { return NombreComercial; }
            set { NombreComercial = value; }
        }
        string CorreoElectronico;

        public string CorreoElectronicoPublico
        {
            get { return CorreoElectronico; }
            set { CorreoElectronico = value; }
        }

        Ubicacion Ubicacion;

        public Ubicacion UbicacionPublico
        {
            get { return Ubicacion; }
            set { Ubicacion = value; }
        }
        Identificacion Identificacion;

        public Identificacion IdentificacionPublico
        {
            get { return Identificacion; }
            set { Identificacion = value; }
        }
        Telefono Telefono;

        public Telefono TelefonoPublico
        {
            get { return Telefono; }
            set { Telefono = value; }
        }
        Fax Fax;

        public Fax FaxPublico
        {
            get { return Fax; }
            set { Fax = value; }
        }
           public Emisor()
        {

        }
    }
}
