using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shalong.Clases
{
    class C_CreditoTrabajador
    {
        int codigo;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        int codigoUsuario;

        public int CodigoUsuario
        {
            get { return codigoUsuario; }
            set { codigoUsuario = value; }
        }
        int codigoTipoPago;

        public int CodigoTipoPago
        {
            get { return codigoTipoPago; }
            set { codigoTipoPago = value; }
        }

        int codigoTipoDocumento;

        public int CodigoTipoDocumento
        {
            get { return codigoTipoDocumento; }
            set { codigoTipoDocumento = value; }
        }
        int codigoCaja;

        public int CodigoCaja
        {
            get { return codigoCaja; }
            set { codigoCaja = value; }
        }

        DateTime fechaPrestamo;

        public DateTime FechaPrestamo
        {
            get { return fechaPrestamo; }
            set { fechaPrestamo = value; }
        }
        double montoPrestamo;

        public double MontoPrestamo
        {
            get { return montoPrestamo; }
            set { montoPrestamo = value; }
        }
        string numeroDocumento;

        public string NumeroDocumento
        {
            get { return numeroDocumento; }
            set { numeroDocumento = value; }
        }
        string observacion;

        public string Observacion
        {
            get { return observacion; }
            set { observacion = value; }
        }
    }
}
