using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shalong.Conexion
{
    class C_TipoLineaCredito
    {
        string nombreLineaCredito;

        public string NombreLineaCredito
        {
            get { return nombreCompleto + " " + detalle; }
            set { nombreLineaCredito = value; }
        }
        string nombreCompleto;

        public string NombreCompleto
        {
            get { return nombreCompleto; }
            set { nombreCompleto = value; }
        }
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
        string detalle;

        public string Detalle
        {
            get { return detalle; }
            set { detalle = value; }
        }
    }
}
