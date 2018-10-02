using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shalong.Clases
{
    class C_TipoPago
    {
        int codigo;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        double cantidad;

        public double Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
        string cantidadString;

        public string CantidadString
        {
            get { return String.Format("{0:0.00}", Cantidad); }
            set { cantidadString = value; }
        }


    }
}
