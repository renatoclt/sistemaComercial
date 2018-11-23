using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shalong.Clases
{
    class C_Kardex
    {
        DateTime fecha;

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        string numeroDocumento;

        public string NumeroDocumento
        {
            get { return numeroDocumento; }
            set { numeroDocumento = value; }
        }

        double total;

        public double Total
        {
            get { return total; }
            set { total = value; }
        }

        double ingreso;

        public double Ingreso
        {
            get { return ingreso; }
            set { ingreso = value; }
        }

        double egreso;

        public double Egreso
        {
            get { return egreso; }
            set { egreso = value; }
        }

        string codigo;


        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
    }
}
