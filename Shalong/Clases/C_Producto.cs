using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shalong.Conexion
{
    class C_Producto
    {
        int codigoBarras;

        public int CodigoBarras
        {
            get { return codigoBarras; }
            set { codigoBarras = value; }
        }
        int codigoMarca;

        public int CodigoMarca
        {
            get { return codigoMarca; }
            set { codigoMarca = value; }
        }
        int codigoFamilia;

        public int CodigoFamilia
        {
            get { return codigoFamilia; }
            set { codigoFamilia = value; }
        }
        int codigoCategoria;

        public int CodigoCategoria
        {
            get { return codigoCategoria; }
            set { codigoCategoria = value; }
        }
        int codigoUnidad;

        public int CodigoUnidad
        {
            get { return codigoUnidad; }
            set { codigoUnidad = value; }
        }
        string tiempoGarantia;

        public string TiempoGarantia
        {
            get { return tiempoGarantia; }
            set { tiempoGarantia = value; }
        }
        string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        int codigoAdministrador;

        public int CodigoAdministrador
        {
            get { return codigoAdministrador; }
            set { codigoAdministrador = value; }
        }
        string observacion;

        public string Observacion
        {
            get { return observacion; }
            set { observacion = value; }
        }

        private string nombreUnidad;

    

public string NombreUnidad
{
  get { return nombreUnidad; }
  set { nombreUnidad = value; }
}}
}
