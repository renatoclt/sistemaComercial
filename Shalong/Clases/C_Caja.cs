using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shalong.Clases
{
    class C_Caja
    {
        double valorTipoCambio;

        public double ValorTipoCambio
        {
            get { return valorTipoCambio; }
            set { valorTipoCambio = value; }
        }
        string nombreCompleto;

        public string NombreCompleto
        {
            get { return nombreCompleto; }
            set { nombreCompleto = value; }
        }
        string nombreCaja;

        public string NombreCaja
        {
            get { return nombreCaja; }
            set { nombreCaja = value; }
        }
        int codigoCaja;

        public int CodigoCaja
        {
            get { return codigoCaja; }
            set { codigoCaja = value; }
        }
        int codigoNombreCaja;

        public int CodigoNombreCaja
        {
            get { return codigoNombreCaja; }
            set { codigoNombreCaja = value; }
        }
        int codigoAdministrador;

        public int CodigoAdministrador
        {
            get { return codigoAdministrador; }
            set { codigoAdministrador = value; }
        }
        int codigoDniUsuario;

        public int CodigoDniUsuario
        {
            get { return codigoDniUsuario; }
            set { codigoDniUsuario = value; }
        }

        int codigoTipoCambio;

        public int CodigoTipoCambio
        {
            get { return codigoTipoCambio; }
            set { codigoTipoCambio = value; }
        }

        DateTime fechaInicioCaja;

        public DateTime FechaInicioCaja
        {
            get { return fechaInicioCaja; }
            set { fechaInicioCaja = value; }
        }
        DateTime fechaFinalCaja;

        public DateTime FechaFinalCaja
        {
            get { return fechaFinalCaja; }
            set { fechaFinalCaja = value; }
        }
        double saldoInicial;

        public double SaldoInicial
        {
            get { return saldoInicial; }
            set { saldoInicial = value; }
        }
        double saldoFinal;

        public double SaldoFinal
        {
            get { return saldoFinal; }
            set { saldoFinal = value; }
        }
        string observacion;

        public string Observacion
        {
            get { return observacion; }
            set { observacion = value; }
        }
    }
}

