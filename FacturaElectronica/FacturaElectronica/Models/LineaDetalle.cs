using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FacturaElectronica.Models
{
    public class LineaDetalle
    {

        string NumeroLinea;

        public string NumeroLineaPublico
        {
            get { return NumeroLinea; }
            set { NumeroLinea = value; }
        }
        Codigo Codigo;

        public Codigo CodigoPublico
        {
            get { return Codigo; }
            set { Codigo = value; }
        }
        string Cantidad;

        public string CantidadPublico
        {
            get { return Cantidad; }
            set { Cantidad = value; }
        }
        string UnidadMedida;

        public string UnidadMedidaPublico
        {
            get { return UnidadMedida; }
            set { UnidadMedida = value; }
        }
        string UnidadMedidaComercial;

        public string UnidadMedidaComercialPublico
        {
            get { return UnidadMedidaComercial; }
            set { UnidadMedidaComercial = value; }
        }
        string Detalle;

        public string DetallePublico
        {
            get { return Detalle; }
            set { Detalle = value; }
        }
        string PrecioUnitario;

        public string PrecioUnitarioPublico
        {
            get { return PrecioUnitario; }
            set { PrecioUnitario = value; }
        }
        string MontoTotal;

        public string MontoTotalPublico
        {
            get { return MontoTotal; }
            set { MontoTotal = value; }
        }
        string MontoDescuento;

        public string MontoDescuentoPublico
        {
            get { return MontoDescuento; }
            set { MontoDescuento = value; }
        }
        string NaturalezaDescuento;

        public string NaturalezaDescuentoPublico
        {
            get { return NaturalezaDescuento; }
            set { NaturalezaDescuento = value; }
        }
        string SubTotal;

        public string SubTotalPublico
        {
            get { return SubTotal; }
            set { SubTotal = value; }
        }
        Impuesto Impuesto;

        public Impuesto ImpuestoPublico
        {
            get { return Impuesto; }
            set { Impuesto = value; }
        }
        string MontoTotalLinea;

        public string MontoTotalLineaPublico
        {
            get { return MontoTotalLinea; }
            set { MontoTotalLinea = value; }
        }
          public LineaDetalle()
        {

        }
    }
}