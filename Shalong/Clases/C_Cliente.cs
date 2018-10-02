using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shalong.Clases
{
    class C_Cliente
    {
        string nombreCompleto;

        public string NombreCompleto
        {
            get { return nombre + " "+ apellido_paterno + " "+ apellido_materno; }
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

        string dni;

        public string Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        string apellido_paterno;

        public string Apellido_paterno
        {
            get { return apellido_paterno; }
            set { apellido_paterno = value; }
        }

        string apellido_materno;

        public string Apellido_materno
        {
            get { return apellido_materno; }
            set { apellido_materno = value; }
        }
    }
}
