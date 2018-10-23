using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shalong.Conexion
{
    class C_ProductoPrecio
    {
        int codigoTipoPrecio;

        public int CodigoTipoPrecio
        {
            get { return codigoTipoPrecio; }
            set { codigoTipoPrecio = value; }
        }
        string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        string codigoBarras;

        public string CodigoBarras
        {
            get { return codigoBarras; }
            set { codigoBarras = value; }
        }

        double precio;

        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }
    }
}
