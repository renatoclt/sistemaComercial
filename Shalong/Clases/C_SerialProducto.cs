using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shalong.Clases
{
    class C_SerialProducto
    {
        string serial;

        public string Serial
        {
            get { return serial; }
            set { serial = value; }
        }
        int codigoSerie;

        public int CodigoSerie
        {
            get { return codigoSerie; }
            set { codigoSerie = value; }
        }

        int codigoBarras;

        public int CodigoBarras
        {
            get { return codigoBarras; }
            set { codigoBarras = value; }
        }
        int codigoCompra;

        public int CodigoCompra
        {
            get { return codigoCompra; }
            set { codigoCompra = value; }
        }
    }
}
