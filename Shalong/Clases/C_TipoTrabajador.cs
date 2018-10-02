using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shalong.Conexion
{
    class C_TipoTrabajador
    {
        int _codigo;

        public int Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        string _puesto;

        public string Puesto
        {
            get { return _puesto; }
            set { _puesto = value; }
        }
    }
}
