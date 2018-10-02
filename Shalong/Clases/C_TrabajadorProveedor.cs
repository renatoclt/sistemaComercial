using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shalong.Clases
{
    class C_TrabajadorProveedor
    {
        string nombreCompletoTrabajador;

        public string NombreCompletoTrabajador
        {
            get { return nombre + " " + apellidoPaterno + " " + apellidoMaterno; }
            set { nombreCompletoTrabajador = value; }
        }
        int codigoTrabajadorProveedor;

        public int CodigoTrabajadorProveedor
        {
            get { return codigoTrabajadorProveedor; }
            set { codigoTrabajadorProveedor = value; }
        }
        int codigoProveedor;

        public int CodigoProveedor
        {
            get { return codigoProveedor; }
            set { codigoProveedor = value; }
        }
        string celular;

        public string Celular
        {
            get { return celular; }
            set { celular = value; }
        }
        string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        string apellidoPaterno;

        public string ApellidoPaterno
        {
            get { return apellidoPaterno; }
            set { apellidoPaterno = value; }
        }
        string apellidoMaterno;

        public string ApellidoMaterno
        {
            get { return apellidoMaterno; }
            set { apellidoMaterno = value; }
        }
    }
}
