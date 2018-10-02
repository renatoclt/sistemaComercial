using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shalong.Clases
{
    class C_Credito
    {
        int codigoTipoPago;

        public int CodigoTipoPago
        {
            get { return codigoTipoPago; }
            set { codigoTipoPago = value; }
        }
        DateTime fechaProxPago;

        public DateTime FechaProxPago
        {
            get { return fechaProxPago; }
            set { fechaProxPago = value; }
        }
        int codigoProveedor;

        public int CodigoProveedor
        {
            get { return codigoProveedor; }
            set { codigoProveedor = value; }
        }
        int codigoTipoCaja;

        public int CodigoTipoCaja
        {
            get { return codigoTipoCaja; }
            set { codigoTipoCaja = value; }
        }
        int codigoCaja;

        public int CodigoCaja
        {
            get { return codigoCaja; }
            set { codigoCaja = value; }
        }
        int codigoCredito;

        public int CodigoCredito
        {
            get { return codigoCredito; }
            set { codigoCredito = value; }
        }
        int codigo;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        int codigoVenta;

        public int CodigoVenta
        {
            get { return codigoVenta; }
            set { codigoVenta = value; }
        }

        int codigoCompra;

        public int CodigoCompra
        {
            get { return codigoCompra; }
            set { codigoCompra = value; }
        }

        string numeroDocumento;

        public string NumeroDocumento
        {
            get { return numeroDocumento; }
            set { numeroDocumento = value; }
        }
        string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        double totalDeuda;

        public double TotalDeuda
        {
            get { return totalDeuda; }
            set { totalDeuda = value; }
        }

        string totalDeudaString;

        public string TotalDeudaString
        {
            get { return String.Format("{0:0.00}", totalDeuda); }
            set { totalDeudaString = value; }
        }


        double monto;

        public double Monto
        {
            get { return monto; }
            set { monto = value; }
        }


        string montoString;

        public string MontoString
        {
            get { return String.Format("{0:0.00}", monto); }
            set { montoString = value; }
        }

        string deudaString;

        public string DeudaString
        {
            get { return String.Format("{0:0.00}",deuda); }
            set { deudaString = value; }
        }
        double deuda;
        public double Deuda
        {
            get { return deuda; }
            set { deuda = value; }
        }
        DateTime fecha;

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        int codigoTrabajador;

        public int CodigoTrabajador
        {
            get { return codigoTrabajador; }
            set { codigoTrabajador = value; }
        }
    }
}
