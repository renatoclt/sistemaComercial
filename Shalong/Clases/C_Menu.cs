using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shalong.Clases
{
    class C_Menu
    {
        int codigoMenu;

        public int CodigoMenu
        {
            get { return codigoMenu; }
            set { codigoMenu = value; }
        }
        string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        int codigoPadre;

        public int CodigoPadre
        {
            get { return codigoPadre; }
            set { codigoPadre = value; }
        }

        byte[] image;

        public byte[] Image
        {
            get { return image; }
            set { image = value; }
        }
        string formulario;

        public string Formulario
        {
            get { return formulario; }
            set { formulario = value; }
        }

        bool habilitado;

        public bool Habilitado
        {
            get { return habilitado; }
            set { habilitado = value; }
        }
    }
}
