using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FacturaElectronica.Models
{
    public class Factura
    {
        string Clave;

        public string ClavePublico
        {
            get { return Clave; }
            set { Clave = value; }
        }
        string NumeroConsecutivo;

        public string NumeroConsecutivoPublico
        {
            get { return NumeroConsecutivo; }
            set { NumeroConsecutivo = value; }
        }
        DateTime FechaEmision;

        public DateTime FechaEmisionPublico
        {
            get { return FechaEmision; }
            set { FechaEmision = value; }
        }
        Emisor Emisor;

        public Emisor EmisorPublico
        {
            get { return Emisor; }
            set { Emisor = value; }
        }
        Receptor Receptor;

        public Receptor ReceptorPublico
        {
            get { return Receptor; }
            set { Receptor = value; }
        }
        string CondicionVenta;

        public string CondicionVentaPublico
        {
            get { return CondicionVenta; }
            set { CondicionVenta = value; }
        }
        string PlazaCredito;

        public string PlazaCreditoPublico
        {
            get { return PlazaCredito; }
            set { PlazaCredito = value; }
        }
        string MedioPago;

        public string MedioPagoPublico
        {
            get { return MedioPago; }
            set { MedioPago = value; }
        }
        ResumenFactura ResumenFactura;

        public ResumenFactura ResumenFacturaPublico
        {
            get { return ResumenFactura; }
            set { ResumenFactura = value; }
        }
        InformacionReferencia InformacionReferencia;

        public InformacionReferencia InformacionReferenciaPublico
        {
            get { return InformacionReferencia; }
            set { InformacionReferencia = value; }
        }
        Normativa Normativa;

        public Normativa NormativaPublico
        {
            get { return Normativa; }
            set { Normativa = value; }
        }
        Otros Otros;

        public Otros OtrosPublico
        {
            get { return Otros; }
            set { Otros = value; }
        }


        List<LineaDetalle> DetalleServicio;
          public Factura()
        {

        }
    }
}