using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shalong.Clases
{
    class C_BilletajeCaja
    {
        int codigoCaja;

        public int CodigoCaja
        {
            get { return codigoCaja; }
            set { codigoCaja = value; }
        }
        int codigoBilletaje;

        public int CodigoBilletaje
        {
            get { return codigoBilletaje; }
            set { codigoBilletaje = value; }
        }
        int cantidad;

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
        int accion;

        public int Accion
        {
            get { return accion; }
            set { accion = value; }
        }
    }
}
