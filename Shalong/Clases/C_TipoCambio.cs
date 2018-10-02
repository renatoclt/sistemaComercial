using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shalong.Conexion
{
    class C_TipoCambio
    {
        DateTime fecha;

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        double valor;

        public double Valor
        {
            get { return valor; }
            set { valor = value; }
        }
        string observacion;

        public string Observacion
        {
            get { return observacion; }
            set { observacion = value; }
        }
        int codigo;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

    }
}
