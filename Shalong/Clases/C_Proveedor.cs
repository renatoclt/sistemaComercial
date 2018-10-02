using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shalong.Conexion
{
    class C_Proveedor
    {
        int codigo;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        int codigoTipoLineaCredito;

        public int CodigoTipoLineaCredito
        {
            get { return codigoTipoLineaCredito; }
            set { codigoTipoLineaCredito = value; }
        }
        
        string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        string ruc;

        public string RUC
        {
            get { return ruc; }
            set { ruc = value; }
        }
        string direccion;

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        int telefono;

        public int Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        string paginaWeb;

        public string PaginaWeb
        {
            get { return paginaWeb; }
            set { paginaWeb = value; }
        }
        string cuentasSoles;

        public string CuentasSoles
        {
            get { return cuentasSoles; }
            set { cuentasSoles = value; }
        }
        string cuentaDolares;

        public string CuentaDolares
        {
            get { return cuentaDolares; }
            set { cuentaDolares = value; }
        }
        double montoPrestamo;

        public double MontoPrestamo
        {
            get { return montoPrestamo; }
            set { montoPrestamo = value; }
        }
    }
}
