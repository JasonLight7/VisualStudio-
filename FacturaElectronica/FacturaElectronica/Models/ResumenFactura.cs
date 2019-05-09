using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FacturaElectronica.Models
{
    public class ResumenFactura
    {

        string CodigoMoneda;

        public string CodigoMonedaPublico
        {
            get { return CodigoMoneda; }
            set { CodigoMoneda = value; }
        }
        string TipoCambio;

        public string TipoCambioPublico
        {
            get { return TipoCambio; }
            set { TipoCambio = value; }
        }
        string TotalServGravados;

        public string TotalServGravadosPublico
        {
            get { return TotalServGravados; }
            set { TotalServGravados = value; }
        }
        string TotalServExentos;

        public string TotalServExentosPublico
        {
            get { return TotalServExentos; }
            set { TotalServExentos = value; }
        }
        string TotalMercanciasGravadas;

        public string TotalMercanciasGravadasPublico
        {
            get { return TotalMercanciasGravadas; }
            set { TotalMercanciasGravadas = value; }
        }
        string TotalMercanciasExentas;

        public string TotalMercanciasExentasPublico
        {
            get { return TotalMercanciasExentas; }
            set { TotalMercanciasExentas = value; }
        }
        string TotalGravado;

        public string TotalGravadoPublico
        {
            get { return TotalGravado; }
            set { TotalGravado = value; }
        }
        string TotalExento;

        public string TotalExentoPublico
        {
            get { return TotalExento; }
            set { TotalExento = value; }
        }
        string TotalVenta;

        public string TotalVentaPublico
        {
            get { return TotalVenta; }
            set { TotalVenta = value; }
        }
        string TotalDescuentos;

        public string TotalDescuentosPublico
        {
            get { return TotalDescuentos; }
            set { TotalDescuentos = value; }
        }
        string TotalVentaNeta;

        public string TotalVentaNetaPublico
        {
            get { return TotalVentaNeta; }
            set { TotalVentaNeta = value; }
        }
        string TotalImpuesto;

        public string TotalImpuestoPublico
        {
            get { return TotalImpuesto; }
            set { TotalImpuesto = value; }
        }
        string TotalComprobante;

        public string TotalComprobantePublico
        {
            get { return TotalComprobante; }
            set { TotalComprobante = value; }
        }



         public ResumenFactura()
        {

        }
    }
}