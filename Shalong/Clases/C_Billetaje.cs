using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shalong.Clases
{
    class C_Billetaje
    {
        int codigo;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        string denominacion;

        public string Denominacion
        {
            get { return denominacion; }
            set { denominacion = value; }
        }

        double valor;

        public double Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        double cantidad;

        public double Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
    }
}
