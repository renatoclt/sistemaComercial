using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shalong.Clases
{
    class C_Contraseña
    {
        DateTime fechaAuditoria;

        public DateTime FechaAuditoria
        {
            get { return fechaAuditoria; }
            set { fechaAuditoria = value; }
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
    }
}
