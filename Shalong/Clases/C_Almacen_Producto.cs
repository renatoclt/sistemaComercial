using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shalong.Conexion
{
    class C_Almacen_Producto
    {
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

        int codigoProducto;

        public int CodigoProducto
        {
            get { return codigoProducto; }
            set { codigoProducto = value; }
        }

        string nombreProducto;

        public string NombreProducto
        {
            get { return nombreProducto; }
            set { nombreProducto = value; }
        }

        double cantidad;

        public double Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
    }
}
