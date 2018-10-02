using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shalong.Clases
{
    class C_VentaDetalle
    {
        int codigoVentaArticulo;

        public int CodigoVentaArticulo
        {
            get { return codigoVentaArticulo; }
            set { codigoVentaArticulo = value; }
        }

        int codigoVenta;

        public int CodigoVenta
        {
            get { return codigoVenta; }
            set { codigoVenta = value; }
        }

        int codigoBarras;

        public int CodigoBarras
        {
            get { return codigoBarras; }
            set { codigoBarras = value; }
        }

        double cantidad;

        public double Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        int codigoTipoPrecio;

        public int CodigoTipoPrecio
        {
            get { return codigoTipoPrecio; }
            set { codigoTipoPrecio = value; }
        }

        double precio;

        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        double precioTotal;

        public double PrecioTotal
        {
            get { return precioTotal; }
            set { precioTotal = value; }
        }

        double descuento;

        public double Descuento
        {
            get { return descuento; }
            set { descuento = value; }
        }

        string garantia;

        public string Garantia
        {
            get { return garantia; }
            set { garantia = value; }
        }




    }
}
