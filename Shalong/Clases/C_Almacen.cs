﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shalong.Conexion
{
    class C_Almacen
    {
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
        int codigoTipoAlmacen;

        public int CodigoTipoAlmacen
        {
            get { return codigoTipoAlmacen; }
            set { codigoTipoAlmacen = value; }
        }
    }
}