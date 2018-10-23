using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shalong.Clases
{
    class C_OrdenCompraDetalle
    {
        double costoTotal;
        public C_OrdenCompraDetalle()
        {
        }
        public double CostoTotal
        {
            get { return costoTotal; }
            set { costoTotal = value; }
        }
        double costoUnitario;

        public double CostoUnitario
        {
            get { return costoUnitario; }
            set { costoUnitario = value; }
        }
        int unidad;

        public int Unidad
        {
            get { return unidad; }
            set { unidad = value; }
        }
        int codigoOrdenCompra;

        public int CodigoOrdenCompra
        {
            get { return codigoOrdenCompra; }
            set { codigoOrdenCompra = value; }
        }


        string codigoBarras;

        public string CodigoBarras
        {
            get { return codigoBarras; }
            set { codigoBarras = value; }
        }

        string cantidad;

        public string Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }


        string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
    }
}
