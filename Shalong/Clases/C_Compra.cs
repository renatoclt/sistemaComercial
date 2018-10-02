using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shalong.Clases
{
    class C_Compra
    {
        string nombreMoneda;

        public string NombreMoneda
        {
            get { return nombreMoneda; }
            set { nombreMoneda = value; }
        }
        string nombreDocumento;

        public string NombreDocumento
        {
            get { return nombreDocumento; }
            set { nombreDocumento = value; }
        }
        string nombreProveedor;

        public string NombreProveedor
        {
            get { return nombreProveedor; }
            set { nombreProveedor = value; }
        }
        double valorTipoCambio;

        public double ValorTipoCambio
        {
            get { return valorTipoCambio; }
            set { valorTipoCambio = value; }
        }
        int codigo;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        int codigoProveedor;

        public int CodigoProveedor
        {
            get { return codigoProveedor; }
            set { codigoProveedor = value; }
        }
        int codigoTipoCambio;

        public int CodigoTipoCambio
        {
            get { return codigoTipoCambio; }
            set { codigoTipoCambio = value; }
        }
        int codigoTipoDocumento;

        public int CodigoTipoDocumento
        {
            get { return codigoTipoDocumento; }
            set { codigoTipoDocumento = value; }
        }
        int codigoMoneda;

        public int CodigoMoneda
        {
            get { return codigoMoneda; }
            set { codigoMoneda = value; }
        }
        DateTime fechaCompra;

        public DateTime FechaCompra
        {
            get { return fechaCompra; }
            set { fechaCompra = value; }
        }
        double montoTotal;

        public double MontoTotal
        {
            get { return montoTotal; }
            set { montoTotal = value; }
        }
        string numeroDocumento;

        public string NumeroDocumento
        {
            get { return numeroDocumento; }
            set { numeroDocumento = value; }
        }
    }
}
