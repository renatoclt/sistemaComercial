using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shalong.Clases
{
    class C_Pago
    {
        string nombreTrabajador;

        public string NombreTrabajador
        {
            get { return nombreTrabajador; }
            set { nombreTrabajador = value; }
        }
        string nombreCliente;

        public string NombreCliente
        {
            get { return nombreCliente; }
            set { nombreCliente = value; }
        }
        string nombreMoneda;

        public string NombreMoneda
        {
            get { return nombreMoneda; }
            set { nombreMoneda = value; }
        }
        string nombreCaja;

        public string NombreCaja
        {
            get { return nombreCaja; }
            set { nombreCaja = value; }
        }
        string nombreTipoPago;

        public string NombreTipoPago
        {
            get { return nombreTipoPago; }
            set { nombreTipoPago = value; }
        }
        string nombreProveedor;

        public string NombreProveedor
        {
            get { return nombreProveedor; }
            set { nombreProveedor = value; }
        }
        string numDocumento;

        public string NumDocumento
        {
            get { return numDocumento; }
            set { numDocumento = value; }
        }
        int codigoPago;

        public int CodigoPago
        {
            get { return codigoPago; }
            set { codigoPago = value; }
        }

        int codigoTipoPago;

        public int CodigoTipoPago
        {
            get { return codigoTipoPago; }
            set { codigoTipoPago = value; }
        }

        int codigoCompra;

        public int CodigoCompra
        {
            get { return codigoCompra; }
            set { codigoCompra = value; }
        }

        int codigoVenta;

        public int CodigoVenta
        {
            get { return codigoVenta; }
            set { codigoVenta = value; }
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

        double montoPagar;

        public double MontoPagar
        {
            get { return montoPagar; }
            set { montoPagar = value; }
        }

        /*   string montoPagarString;

           public string MontoPagarString
           {
               get { return String.Format("{0:0.00}", montoPagar); }
               set { montoPagarString = value; }
           }*/

        DateTime fechaPago;

        public DateTime FechaPago
        {
            get { return fechaPago; }
            set { fechaPago = value; }
        }

        string numCuenta;

        public string NumCuenta
        {
            get { return numCuenta; }
            set { numCuenta = value; }
        }



        string entidadBancaria;

        public string EntidadBancaria
        {
            get { return entidadBancaria; }
            set { entidadBancaria = value; }
        }

        string numVoucher;

        public string NumVoucher
        {
            get { return numVoucher; }
            set { numVoucher = value; }
        }
    }
}
