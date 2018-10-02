using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shalong.Clases
{
    class C_CompraDetalle
    {
        int unidad;

        public int Unidad
        {
            get { return unidad; }
            set { unidad = value; }
        }
        int codigoUnidad;

        public int CodigoUnidad
        {
            get { return codigoUnidad; }
            set { codigoUnidad = value; }
        }
        int codigoCompraDetalle;

        public int CodigoCompraDetalle
        {
            get { return codigoCompraDetalle; }
            set { codigoCompraDetalle = value; }
        }
        int codigoCompra;

        public int CodigoCompra
        {
            get { return codigoCompra; }
            set { codigoCompra = value; }
        }
        int codigoProducto;

        public int CodigoProducto
        {
            get { return codigoProducto; }
            set { codigoProducto = value; }
        }
        double costoUnitario;

        public double CostoUnitario
        {
            get { return costoUnitario; }
            set { costoUnitario = value; }
        }
        double costoTotal;

        public double CostoTotal
        {
            get { return costoTotal; }
            set { costoTotal = value; }
        }
        double cantidad;

        public double Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
        /* int cantidad;

         public int Cantidad
         {
             get { return cantidad; }
             set { cantidad = value; }
         }*/

        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        int codigo_credito;

        public int Codigo_credito
        {
            get { return codigo_credito; }
            set { codigo_credito = value; }
        }

        int codigoBarras;

        public int CodigoBarras
        {
            get { return codigoBarras; }
            set { codigoBarras = value; }
        }
    }
}
