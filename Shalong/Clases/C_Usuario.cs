using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shalong.Clases
{
    class C_Usuario
    {
        int dni;

        public int Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        int codigoTipoTrabajador;

        public int CodigoTipoTrabajador
        {
            get { return codigoTipoTrabajador; }
            set { codigoTipoTrabajador = value; }
        }

        string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        string nombreCompleto;

        public string NombreCompleto
        {
            get { return nombre + " " + apellidoPaterno + " " + apellidoMaterno; }
            set { nombreCompleto = value; }
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

        DateTime fechaNacimiento;

        public DateTime FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }

        string lugarNacimiento;

        public string LugarNacimiento
        {
            get { return lugarNacimiento; }
            set { lugarNacimiento = value; }
        }

        string direccion;

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        DateTime fechaInicio;

        public DateTime FechaInicio
        {
            get { return fechaInicio; }
            set { fechaInicio = value; }
        }

        string telefono;

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        int compañia;

        public int Compañia
        {
            get { return compañia; }
            set { compañia = value; }
        }
    }
}
