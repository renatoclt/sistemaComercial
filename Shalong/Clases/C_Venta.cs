using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shalong.Clases
{
    class C_Venta
    {

        string numeroDocumento;

        public string NumeroDocumento
        {
            get { return numeroDocumento; }
            set { numeroDocumento = value; }
        }
        string nombreEmpresa;

        public string NombreEmpresa
        {
            get { return nombreEmpresa; }
            set { nombreEmpresa = value; }
        }
        string nombreCliente;

        public string NombreCliente
        {
            get { return nombreCliente; }
            set { nombreCliente = value; }
        }
        string nombreTipoPago;

        public string NombreTipoPago
        {
            get { return nombreTipoPago; }
            set { nombreTipoPago = value; }
        }
        string nombreDocumento;

        public string NombreDocumento
        {
            get { return nombreDocumento; }
            set { nombreDocumento = value; }
        }
        string nombreCaja;

        public string NombreCaja
        {
            get { return nombreCaja; }
            set { nombreCaja = value; }
        }
        int codigo;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        int codigoCaja;

        public int CodigoCaja
        {
            get { return codigoCaja; }
            set { codigoCaja = value; }
        }

        int codigoTipoDocumento;

        public int CodigoTipoDocumento
        {
            get { return codigoTipoDocumento; }
            set { codigoTipoDocumento = value; }
        }

        int codigoTipoPago;

        public int CodigoTipoPago
        {
            get { return codigoTipoPago; }
            set { codigoTipoPago = value; }
        }

        int codigoCliente;

        public int CodigoCliente
        {
            get { return codigoCliente; }
            set { codigoCliente = value; }
        }

        int codigoEmpresa;

        public int CodigoEmpresa
        {
            get { return codigoEmpresa; }
            set { codigoEmpresa = value; }
        }

        string numeroDocumentoVenta;

        public string NumeroDocumentoVenta
        {
            get { return numeroDocumentoVenta; }
            set { numeroDocumentoVenta = value; }
        }

        double totalVenta;

        public double TotalVenta
        {
            get { return totalVenta; }
            set { totalVenta = value; }
        }
        DateTime fechaVenta;

        public DateTime FechaVenta
        {
            get { return fechaVenta; }
            set { fechaVenta = value; }
        }
    }
}
