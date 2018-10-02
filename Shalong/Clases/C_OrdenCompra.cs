using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shalong.Clases
{
    class C_OrdenCompra
    {
        public C_OrdenCompra()
        {
        }
        int codigo;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        int codigoDniUsuario;

        public int CodigoDniUsuario
        {
            get { return codigoDniUsuario; }
            set { codigoDniUsuario = value; }
        }

        int codigoProveedor;

        public int CodigoProveedor
        {
            get { return codigoProveedor; }
            set { codigoProveedor = value; }
        }

        string referenciaOrdenCompra;

        public string ReferenciaOrdenCompra
        {
            get { return referenciaOrdenCompra; }
            set { referenciaOrdenCompra = value; }
        }

        string numeroDocumento;

        public string NumeroDocumento
        {
            get { return numeroDocumento; }
            set { numeroDocumento = value; }
        }

        string ruc;

        public string Ruc
        {
            get { return ruc; }
            set { ruc = value; }
        }
        string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        int codigoBarras;

        public int CodigoBarras
        {
            get { return codigoBarras; }
            set { codigoBarras = value; }
        }

        DateTime fecha;

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
    }
}