using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FacturaElectronica.Models
{
    public class Ubicacion
    {
        Int16 Provincias;

        public Int16 ProvinciasPublico
        {
            get { return Provincias; }
            set { Provincias = value; }
        }
        Int16 Canton;

        public Int16 CantonPublico
        {
            get { return Canton; }
            set { Canton = value; }
        }
        Int16 Distrito;

        public Int16 DistritoPublico
        {
            get { return Distrito; }
            set { Distrito = value; }
        }
        Int16 Barrio;

        public Int16 BarrioPublico
        {
            get { return Barrio; }
            set { Barrio = value; }
        }
        string OtrasSenas;

        public string OtrasSenasPublico
        {
            get { return OtrasSenas; }
            set { OtrasSenas = value; }
        }
         //El constructor esta vacio porque vamios a llenar los atributos hasta que se intancie la clase 
             public Ubicacion()
        {

        }

        
      

    }
}