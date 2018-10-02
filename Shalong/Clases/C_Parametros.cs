using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shalong.Clases
{
    public class C_Parametros
    {
        int codigoProveedor;

        public int CodigoProveedor
        {
            get { return codigoProveedor; }
            set { codigoProveedor = value; }
        }
        bool ok;

        public bool Ok
        {
            get { return ok; }
            set { ok = value; }
        }
        int codigoUsuario;

        public int CodigoUsuario
        {
            get { return codigoUsuario; }
            set { codigoUsuario = value; }
        }

        int dniUsuario;

        public int DniUsuario
        {
            get { return dniUsuario; }
            set { dniUsuario = value; }
        }

        int codigoCaja;

        public int CodigoCaja
        {
            get { return codigoCaja; }
            set { codigoCaja = value; }
        }

        double valorDolar;

        public double ValorDolar
        {
            get { return valorDolar; }
            set { valorDolar = value; }
        }

        int codigoDolar;

        public int CodigoDolar
        {
            get { return codigoDolar; }
            set { codigoDolar = value; }
        }

        string tipoTrabajador;

        public string TipoTrabajador
        {
            get { return tipoTrabajador; }
            set { tipoTrabajador = value; }
        }

        bool estadoCaja;

        public bool EstadoCaja
        {
            get { return estadoCaja; }
            set { estadoCaja = value; }
        }

        int codigoAlmacen;

        public int CodigoAlmacen
        {
            get { return codigoAlmacen; }
            set { codigoAlmacen = value; }
        }
        string nombreAlmacen;

        public string NombreAlmacen
        {
            get { return nombreAlmacen; }
            set { nombreAlmacen = value; }
        }
    }
}
