using Npgsql;
using NpgsqlTypes;
using Shalong.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Shalong.Conexion
{
    class Shalong_Service : Interface_Shalong
    {
        string cadenaConexion = "Server= localhost; port = 5432 ;User Id=postgres;Password=root;Database=gestion_ventas";
        //cadena para subir 
        //string cadenaConexion = "Server= localhost; port = 5432 ;User Id=postgres;Password=admin;Database=gestion_ventas";

        // FUNCIONES DE INGRESO, MODIFICACION Y ELIMNACION

        public bool Almacen(int accion,C_Almacen objetoAlmacen)
        {
            bool res = false;
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SPR_ALMACEN ", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("_ACCION", accion);
                cmd.Parameters.AddWithValue("_CODIGO_TIPO_ALMACEN",objetoAlmacen.CodigoTipoAlmacen);
                cmd.Parameters.AddWithValue("_NOMBRE", objetoAlmacen.Nombre);
                cmd.Parameters.AddWithValue("_CODIGO_ALMACEN", objetoAlmacen.Codigo);
                cmd.Parameters.Add(new NpgsqlParameter(":resultado", NpgsqlDbType.Text)).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                res = (bool)cmd.Parameters[":resultado"].Value;
            }
            catch (Exception )
            {
                return false;
            }
            finally
            {
                cnn.Close();
            }
            return res;
        }
        public bool IngresoAuditoria(int accion, C_Contraseña objetoContraseña)
        {
            bool res = false;
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("spr_ingresoauditoria ", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("_ACCION", accion);
                cmd.Parameters.AddWithValue("NOW()", objetoContraseña.FechaAuditoria);
                cmd.Parameters.AddWithValue("_CODIGO_ADMINISTRADOR", objetoContraseña.CodigoAdministrador);
                cmd.Parameters.AddWithValue("_OBSERVACION", objetoContraseña.Observacion);
                cmd.Parameters.Add(new NpgsqlParameter(":resultado", NpgsqlDbType.Text)).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                res = (bool)cmd.Parameters[":resultado"].Value;
            }
            catch (Exception )
            {
                return false;
            }
            finally
            {
                cnn.Close();
            }
            return res;
        }
        public bool AlmacenProducto(int accion, int codigoAlmacen, string codigoProducto, double cantidad)
        {
            bool res = false;
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SPR_ALMACEN_PRODUCTOS", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("_ACCION", accion);
                cmd.Parameters.AddWithValue("_CODIGO_BARRAS", codigoProducto);
                cmd.Parameters.AddWithValue("_CODIGO_ALMACEN", codigoAlmacen);
                cmd.Parameters.AddWithValue("_STOCK", cantidad);
                cmd.Parameters.Add(new NpgsqlParameter(":resultado", NpgsqlDbType.Text)).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                res = (bool)cmd.Parameters[":resultado"].Value;
            }
            catch (Exception )
            {
                return false;
            }
            finally
            {
                cnn.Close();
            }
            return res;
        }
        public bool BilletajeCajaGuardar(C_BilletajeCaja objetoBilletaje)
        {
            bool res = false;
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("Spr_BilletajeCaja", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("_codigocaja", objetoBilletaje.CodigoCaja);
                cmd.Parameters.AddWithValue("_codigobilletaje", objetoBilletaje.CodigoBilletaje);
                cmd.Parameters.AddWithValue("_cantidad", objetoBilletaje.Cantidad);
                cmd.Parameters.AddWithValue("_accion", objetoBilletaje.Accion);
                cmd.Parameters.Add(new NpgsqlParameter(":resultado", NpgsqlDbType.Text)).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                res = (bool)cmd.Parameters[":resultado"].Value;
            }
            catch (Exception )
            {
                return false;
            }
            finally
            {
                cnn.Close();
            }
            return res;
        }
        public bool Caja(int accion, C_Caja objetoCaja)
        {
            bool res = false;
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("spr_caja", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("_accion", accion);
                cmd.Parameters.AddWithValue("_codigo_nombre_caja", objetoCaja.CodigoNombreCaja);
                cmd.Parameters.AddWithValue("_codigo_dni_usuario", objetoCaja.CodigoDniUsuario);
                cmd.Parameters.AddWithValue("_codigo_tipo_cambio", objetoCaja.CodigoTipoCambio);
                cmd.Parameters.AddWithValue("_saldo_inicial", objetoCaja.SaldoInicial);
                cmd.Parameters.AddWithValue("_saldo_final", objetoCaja.SaldoFinal);
                cmd.Parameters.AddWithValue("_codigo_administrador", objetoCaja.CodigoAdministrador);
                cmd.Parameters.AddWithValue("_observacion", objetoCaja.Observacion);
                cmd.Parameters.AddWithValue("_codigo_caja", objetoCaja.CodigoCaja);
                cmd.Parameters.Add(new NpgsqlParameter(":resultado", NpgsqlDbType.Text)).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                res = (bool)cmd.Parameters[":resultado"].Value;
                cnn.Close();
            }
            catch (Exception )
            {
                return false;
            }
            finally
            {
                cnn.Close();
            }
            return res;
        }
        public bool CajaCerrar(C_Caja objetoCaja)
        {
            bool res = false;
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("spr_cajaCerrar", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("_saldo_final", objetoCaja.SaldoFinal);
                cmd.Parameters.AddWithValue("_codigo_caja", objetoCaja.CodigoCaja);
                cmd.Parameters.Add(new NpgsqlParameter(":resultado", NpgsqlDbType.Text)).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                res = (bool)cmd.Parameters[":resultado"].Value;
            }
            catch (Exception )
            {
                return false;
            }
            finally
            {
                cnn.Close();
            }
            return res;
        }
        public int CajaCodigo(int codigoDniUsuario)
        {
            int res = 0;
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("Spr_CajaCodigo", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("_codigo_dni_usuario", codigoDniUsuario);
                cmd.Parameters.Add(new NpgsqlParameter(":resultado", NpgsqlDbType.Text)).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                res = (int)cmd.Parameters[":resultado"].Value;
            }
            catch (Exception )
            {
                return 0;
            }
            finally
            {
                cnn.Close();
            }
            return res;
        }
        public bool CajaAbierta(int codigoDniUsuario)
        {
            bool res = false;
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("spr_cajaAbierta", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("_codigo_dni_usuario", codigoDniUsuario);
                cmd.Parameters.Add(new NpgsqlParameter(":resultado", NpgsqlDbType.Text)).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                res = (bool)cmd.Parameters[":resultado"].Value;
            }
            catch (Exception )
            {
                return false;
            }
            finally
            {
                cnn.Close();
            }
            return res;
        }
        public double CajaEgresos(int codigoCaja)
        {
            double res = 0;
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("spr_EgresosDia", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("_codigoCaja", codigoCaja);
                cmd.Parameters.Add(new NpgsqlParameter(":resultado", NpgsqlDbType.Text)).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                res = (double)cmd.Parameters[":resultado"].Value;
            }
            catch (Exception )
            {
                return 0;
            }
            finally
            {
                cnn.Close();
            }
            return res;
        }
        public double CajaEfectivo(int codigoCaja)
        {
            double res = 0;
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("spr_EfectivoDia", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("_codigoCaja", codigoCaja);
                cmd.Parameters.Add(new NpgsqlParameter(":resultado", NpgsqlDbType.Text)).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                res = (double)cmd.Parameters[":resultado"].Value;
            }
            catch (Exception )
            {
                return 0;
            }
            finally
            {
                cnn.Close();
            }
            return res;
        }
        public double CajaIngresos(int codigoCaja)
        {
            double res = 0;
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("spr_IngresosDia", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("_codigoCaja", codigoCaja);
                cmd.Parameters.Add(new NpgsqlParameter(":resultado", NpgsqlDbType.Text)).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                res = (double)cmd.Parameters[":resultado"].Value;
            }
            catch (Exception )
            {
                return 0;
            }
            finally
            {
                cnn.Close();
            }
            return res;
        }
        public int CajaUltima(int codigoNombreCaja)
        {
            int res = 0;
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("Spr_CajaUltima", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("_NombreCaja", codigoNombreCaja);
                cmd.Parameters.Add(new NpgsqlParameter(":resultado", NpgsqlDbType.Text)).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                res = (int)cmd.Parameters[":resultado"].Value;
            }
            catch (Exception )
            {
                return 0;
            }
            finally
            {
                cnn.Close();
            }
            return res;
        }
        public bool Categoria(int accion, C_Categoria objetoCategoria)
        {
            bool res = false;
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SPR_CATEGORIA ", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("_ACCION", accion);
                cmd.Parameters.AddWithValue("_NOMBRE", objetoCategoria.Nombre);
                cmd.Parameters.AddWithValue("_CODIGO_CATEGORIA", objetoCategoria.Codigo);
                cmd.Parameters.Add(new NpgsqlParameter(":resultado", NpgsqlDbType.Text)).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                res = (bool)cmd.Parameters[":resultado"].Value;
            }
            catch (Exception )
            {
                return false;
            }
            finally
            {
                cnn.Close();
            }
            return res;
        }
        public bool Compra(int accion, C_Compra objetoCompra)
        {
            bool res = false;
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("Spr_Compra", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("_ACCION", accion);
                cmd.Parameters.AddWithValue("_codigo_proveedor", objetoCompra.CodigoProveedor);
                cmd.Parameters.AddWithValue("_codigo_tipo_cambio", objetoCompra.CodigoTipoCambio);
                cmd.Parameters.AddWithValue("_codigo_moneda", objetoCompra.CodigoMoneda);
                cmd.Parameters.AddWithValue("_codigo_tipo_documento", objetoCompra.CodigoTipoDocumento);
                cmd.Parameters.AddWithValue("_fecha_compra", objetoCompra.FechaCompra);
                cmd.Parameters.AddWithValue("_monto_total_compra", objetoCompra.MontoTotal);
                cmd.Parameters.AddWithValue("_numero_documento", objetoCompra.NumeroDocumento);
                cmd.Parameters.AddWithValue("_codigocompra", objetoCompra.Codigo);
                cmd.Parameters.Add(new NpgsqlParameter(":resultado", NpgsqlDbType.Text)).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                res = (bool)cmd.Parameters[":resultado"].Value;
            }
            catch (Exception )
            {
                return false;
            }
            finally
            {
                cnn.Close();
            }
            return res;
        }
        public int CompraCodigo(C_Compra objetoCompra)
        {
            int res = 0;
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("Spr_CompraCodigo", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("_codigo_proveedor", objetoCompra.CodigoProveedor);
                cmd.Parameters.AddWithValue("_numero_documento", objetoCompra.NumeroDocumento);
                cmd.Parameters.Add(new NpgsqlParameter(":resultado", NpgsqlDbType.Text)).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                res = (int)cmd.Parameters[":resultado"].Value;
            }
            catch (Exception )
            {
                return 0;
            }
            finally
            {
                cnn.Close();
            }
            return res;
        }
        public bool CompraDetalle(int accion, C_CompraDetalle objetoCompraDetalle)
        {
            bool res = false;
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("Spr_CompraDetalle", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("_accion", accion);
                cmd.Parameters.AddWithValue("_codigoCompra", objetoCompraDetalle.CodigoCompra);
                cmd.Parameters.AddWithValue("_codigoProducto", objetoCompraDetalle.CodigoProducto);
                cmd.Parameters.AddWithValue("_costoUnitario", objetoCompraDetalle.CostoUnitario);
                cmd.Parameters.AddWithValue("_costoTotal", objetoCompraDetalle.CostoTotal);
                cmd.Parameters.AddWithValue("_codigounidad", objetoCompraDetalle.CodigoUnidad);
                cmd.Parameters.AddWithValue("_cantidad", objetoCompraDetalle.Cantidad);
                cmd.Parameters.Add(new NpgsqlParameter(":resultado", NpgsqlDbType.Text)).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                res = (bool)cmd.Parameters[":resultado"].Value;
            }
            catch (Exception )
            {
                return false;
            }
            finally
            {
                cnn.Close();
            }
            return res;
        }
        public bool CompraSerial(int accion, C_SerialProducto objetoSerialProducto)
        {
            bool res = false;
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("spr_compraserial", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("_accion", accion);
                cmd.Parameters.AddWithValue("_codigo_serie", objetoSerialProducto.Serial);
                cmd.Parameters.AddWithValue("_codigo_barras", objetoSerialProducto.CodigoBarras);
                cmd.Parameters.AddWithValue("_codigo_compra", objetoSerialProducto.CodigoCompra);
                cmd.Parameters.Add(new NpgsqlParameter(":resultado", NpgsqlDbType.Text)).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                res = (bool)cmd.Parameters[":resultado"].Value;
            }
            catch (Exception )
            {
                return false;
            }
            finally
            {
                cnn.Close();
            }
            return res;
        }
        public bool CodigoSerial(int accion, C_CodigoSerial objetoCodigoSerial)
        {
            bool res = false;
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("spr_codigo_serial", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("_ACCION", accion);
                cmd.Parameters.AddWithValue("_codigo_serial", objetoCodigoSerial.CodigoSerial);
                cmd.Parameters.AddWithValue("_codigo_venta", objetoCodigoSerial.CodigoVenta);
                cmd.Parameters.AddWithValue("_garantia", objetoCodigoSerial.Garantia);
                cmd.Parameters.Add(new NpgsqlParameter(":resultado", NpgsqlDbType.Text)).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                res = (bool)cmd.Parameters[":resultado"].Value;
            }
            catch (Exception )
            {
                return false;
            }
            finally
            {
                cnn.Close();
            }
            return res;
        }
        public bool CreditoTrabajador(int accion, C_CreditoTrabajador objetoCredito)
        {
            bool res = false;
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("spr_creditotrabajador", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("_accion", accion);
                cmd.Parameters.AddWithValue("_codigo_usuario", objetoCredito.CodigoUsuario);
                cmd.Parameters.AddWithValue("_CODIGO_TIPOPAGO", objetoCredito.CodigoTipoPago);
                cmd.Parameters.AddWithValue("_codigo_caja", objetoCredito.CodigoCaja);
                cmd.Parameters.AddWithValue("_codigo_tipo_documento", objetoCredito.CodigoTipoDocumento);
                cmd.Parameters.AddWithValue("_fecha_prestamo", objetoCredito.FechaPrestamo);
                cmd.Parameters.AddWithValue("_monto_total_prestamo", objetoCredito.MontoPrestamo);
                cmd.Parameters.AddWithValue("_numero_documento", objetoCredito.NumeroDocumento);
                cmd.Parameters.AddWithValue("_observacion", objetoCredito.Observacion);
                cmd.Parameters.AddWithValue("_codigocompra", objetoCredito.Codigo);
                cmd.Parameters.Add(new NpgsqlParameter(":resultado", NpgsqlDbType.Text)).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                res = (bool)cmd.Parameters[":resultado"].Value;
            }
            catch (Exception )
            {
                return false;
            }
            finally
            {
                cnn.Close();
            }
            return res;
        }
        public bool Familia(int accion, C_Familia objetoFamilia)
        {
            bool res = false;
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {

                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SPR_FAMILIA", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("_ACCION", accion);
                cmd.Parameters.AddWithValue("_NOMBRE", objetoFamilia.Nombre);
                cmd.Parameters.AddWithValue("_CODIGO_FAMILIA", objetoFamilia.Codigo);
                cmd.Parameters.Add(new NpgsqlParameter(":resultado", NpgsqlDbType.Text)).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                res = (bool)cmd.Parameters[":resultado"].Value;

            }
            catch (Exception )
            {
                return false;
            }
            finally
            {
                cnn.Close();
            }
            return res;
        }
        public bool Compañia(int codigo)
        {
            bool res = false;
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("spr_compañia", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("_codigo", codigo);
                cmd.Parameters.Add(new NpgsqlParameter(":resultado", NpgsqlDbType.Text)).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                res = (bool)cmd.Parameters[":resultado"].Value;

            }
            catch (Exception )
            {
                return false;
            }
            finally
            {
                cnn.Close();
            }
            return res;
        }
        public bool Login(int dni, string password)
        {
            bool res = false;
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {

                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("Spr_Login", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("_ACCION", dni);
                cmd.Parameters.AddWithValue("_NOMBRE", password);
                cmd.Parameters.Add(new NpgsqlParameter(":resultado", NpgsqlDbType.Text)).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                res = (bool)cmd.Parameters[":resultado"].Value;

            }
            catch (Exception )
            {
                return false;
            }
            finally
            {
                cnn.Close();
            }
            return res;
        }
        public bool Marca(int accion, C_Marca objetoMarca)
        {
            bool res = false;
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {

                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SPR_MARCA", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("_ACCION", accion);
                cmd.Parameters.AddWithValue("_NOMBRE", objetoMarca.Nombre);
                cmd.Parameters.AddWithValue("_CODIGO_MARCA", objetoMarca.Codigo);
                cmd.Parameters.Add(new NpgsqlParameter(":resultado", NpgsqlDbType.Text)).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                res = (bool)cmd.Parameters[":resultado"].Value;

            }
            catch (Exception )
            {
                return false;
            }
            finally
            {
                cnn.Close();
            }
            return res;
        }
        public bool NombreCaja(int accion, string nombre, int almacen, int codigo)
        {
            bool res = false;
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SPR_NOMBRE_CAJA", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("_ACCION", accion);
                cmd.Parameters.AddWithValue("_NOMBRE", nombre);
                cmd.Parameters.AddWithValue("_ALMACEN", almacen);
                cmd.Parameters.AddWithValue("_CODIGO_CAJA", codigo);
                cmd.Parameters.Add(new NpgsqlParameter(":resultado", NpgsqlDbType.Text)).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                res = (bool)cmd.Parameters[":resultado"].Value;
            }
            catch (Exception )
            {
                return false;
            }
            finally
            {
                cnn.Close();
            }
            return res;
        }
        public bool Cliente(int accion, C_Cliente objetoCliente)
        {
            bool res = false;
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SPR_CLIENTE", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("_ACCION", accion);
                cmd.Parameters.AddWithValue("_DNI", objetoCliente.Dni);
                cmd.Parameters.AddWithValue("_NOMBRE", objetoCliente.Nombre);
                cmd.Parameters.AddWithValue("_APELLIDO_PATERNO", objetoCliente.Apellido_paterno);
                cmd.Parameters.AddWithValue("_APELLIDO_MATERNO", objetoCliente.Apellido_materno);
                cmd.Parameters.AddWithValue("_CODIGO_CLIENTE", objetoCliente.Codigo);

                cmd.Parameters.Add(new NpgsqlParameter(":resultado", NpgsqlDbType.Text)).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                res = (bool)cmd.Parameters[":resultado"].Value;
            }
            catch (Exception )
            {
                return false;
            }
            finally
            {
                cnn.Close();
            }
            return res;
        }
        public bool Empresa(int accion, C_Empresa objetoEmpresa)
        {
            bool res = false;
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SPR_EMPRESA", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("_ACCION", accion);
                cmd.Parameters.AddWithValue("_RUC", objetoEmpresa.Ruc);
                cmd.Parameters.AddWithValue("_NOMBRE", objetoEmpresa.Nombre);
                cmd.Parameters.AddWithValue("_DIRECCION", objetoEmpresa.Direccion);
                cmd.Parameters.AddWithValue("_TELEFONO", objetoEmpresa.Telefono);
                cmd.Parameters.AddWithValue("_CODIGO_EMPRESA", objetoEmpresa.Codigo);
                cmd.Parameters.Add(new NpgsqlParameter(":resultado", NpgsqlDbType.Text)).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                res = (bool)cmd.Parameters[":resultado"].Value;
            }
            catch (Exception )
            {
                return false;
            }
            finally
            {
                cnn.Close();
            }
            return res;


        }
        public bool Pago(int accion, C_Pago objetoPago)
        {
            bool res = false;
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SPR_PAGO", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("_ACCION", accion);
                cmd.Parameters.AddWithValue("_CODIGO_TIPO_PAGO", objetoPago.CodigoTipoPago);
                cmd.Parameters.AddWithValue("_CODIGO_CAJA", objetoPago.CodigoCaja);
                cmd.Parameters.AddWithValue("_CODIGO_CREDITO", objetoPago.CodigoCredito);
                cmd.Parameters.AddWithValue("_MONTO_PAGAR", objetoPago.MontoPagar);
                cmd.Parameters.AddWithValue("_NUM_CUENTA", objetoPago.NumCuenta);
                cmd.Parameters.AddWithValue("_ENTIDAD_BANCARIA", objetoPago.EntidadBancaria);
                cmd.Parameters.AddWithValue("_NUM_VOUCHER", objetoPago.NumVoucher);
                cmd.Parameters.AddWithValue("_FECHA_PROX_PAGO", objetoPago.FechaPago);
                cmd.Parameters.AddWithValue("_CODIGO_PAGO", objetoPago.CodigoPago);

                cmd.Parameters.Add(new NpgsqlParameter(":resultado", NpgsqlDbType.Text)).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                res = (bool)cmd.Parameters[":resultado"].Value;

            }
            catch (Exception )
            {
                return false;
            }
            finally
            {
                cnn.Close();
            }
            return res;

        }
        public bool Producto(int accion, C_Producto objetoProducto)
        {
            bool res = false;
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SPR_PRODUCTOS", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("_ACCION", accion);
                cmd.Parameters.AddWithValue("_CODIGO_BARRAS", objetoProducto.CodigoBarras);
                cmd.Parameters.AddWithValue("_CODIGO_MARCA", objetoProducto.CodigoMarca);
                cmd.Parameters.AddWithValue("_CODIGO_FAMILIA", objetoProducto.CodigoFamilia);
                cmd.Parameters.AddWithValue("_CODIGO_CATEGORIA", objetoProducto.CodigoCategoria);
                cmd.Parameters.AddWithValue("_CODIGO_UNIDAD", objetoProducto.CodigoUnidad);
                cmd.Parameters.AddWithValue("_TIEMPO_GARANTIA", objetoProducto.TiempoGarantia);
                cmd.Parameters.AddWithValue("_NOMBRE", objetoProducto.Nombre);
                cmd.Parameters.AddWithValue("_OBSERVACIONES", objetoProducto.Observacion);
                cmd.Parameters.AddWithValue("_CODIGO_DNI_USUARIO", objetoProducto.CodigoAdministrador);

                cmd.Parameters.Add(new NpgsqlParameter(":resultado", NpgsqlDbType.Text)).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                res = (bool)cmd.Parameters[":resultado"].Value;

            }
            catch (Exception )
            {
                return false;
            }
            finally
            {
                cnn.Close();
            }
            return res;
        }
        public bool ProductoExistente(string codigoBarras)
        {
            bool res = false;
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SPR_ProductoExitente", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("_CODIGO_BARRAS", codigoBarras);
                cmd.Parameters.Add(new NpgsqlParameter(":resultado", NpgsqlDbType.Text)).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                res = (bool)cmd.Parameters[":resultado"].Value;
            }
            catch (Exception )
            {
                return false;
            }
            finally
            {
                cnn.Close();
            }
            return res;
        }
        public bool ProductoPrecio(int accion, int codigoTipoPrecio, string codigoBarras, double precio)
        {
            bool res = false;
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SPR_PRODUCTO_PRECIO", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("_ACCION", accion);
                cmd.Parameters.AddWithValue("_CODIGO_TIPO_PRECIO", codigoTipoPrecio);
                cmd.Parameters.AddWithValue("_CODIGO_BARRAS", codigoBarras);
                cmd.Parameters.AddWithValue("_PRECIO", precio);
                cmd.Parameters.Add(new NpgsqlParameter(":resultado", NpgsqlDbType.Text)).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                res = (bool)cmd.Parameters[":resultado"].Value;
            }
            catch (Exception )
            {
                return false;
            }
            finally
            {
                cnn.Close();
            }
            return res;
        }
        public double ProductoPrecioValor(int codigoTipoPrecio, string codigoBarras)
        {
            double res = 0.0;
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("Spr_ProductoValorPrecio", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("_CODIGO_TIPO_PRECIO", codigoTipoPrecio);
                cmd.Parameters.AddWithValue("_CODIGO_BARRAS", codigoBarras);
                cmd.Parameters.Add(new NpgsqlParameter(":resultado", NpgsqlDbType.Text)).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                res = (double)cmd.Parameters[":resultado"].Value;
            }
            catch (Exception )
            {
                return 0;
            }
            finally
            {
                cnn.Close();
            }
            return res;
        }
        public bool Proveedor(int accion, C_Proveedor oProveedor)
        {
            bool res = false;
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {                
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SPR_PROVEEDORES", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("_ACCION", accion);
                cmd.Parameters.AddWithValue("_CODIGO_TIPOS_LINEA_DE_CREDITO", oProveedor.CodigoTipoLineaCredito);
                cmd.Parameters.AddWithValue("_RUC", oProveedor.RUC);
                cmd.Parameters.AddWithValue("_MONTO_MAXIMO_PRESTAMO", oProveedor.MontoPrestamo);
                cmd.Parameters.AddWithValue("_CUENTA_AHORROS_SOLES", oProveedor.CuentasSoles);
                cmd.Parameters.AddWithValue("_CUENTA_AHORROS_DOLARES", oProveedor.CuentaDolares);
                cmd.Parameters.AddWithValue("_PAGINA_WEB", oProveedor.PaginaWeb);
                cmd.Parameters.AddWithValue("_TELEFONO", oProveedor.Telefono);
                cmd.Parameters.AddWithValue("_DIRECCION", oProveedor.Direccion);
                cmd.Parameters.AddWithValue("_NOMBRE", oProveedor.Nombre);
                cmd.Parameters.AddWithValue("_CODIGO_PROVEEDOR", oProveedor.Codigo);
                cmd.Parameters.Add(new NpgsqlParameter(":resultado", NpgsqlDbType.Text)).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                res = (bool)cmd.Parameters[":resultado"].Value;
            }
            catch (Exception )
            {
                return false;
            }
            finally
            {
                cnn.Close();
            }
            return res;
        }
        public bool TipoAlmacen(int accion, C_TipoAlmacen objetoTipoAlmacen)
        {
            bool res = false;
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SPR_TIPO_ALMACEN", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("_ACCION", accion);
                cmd.Parameters.AddWithValue("_NOMBRE", objetoTipoAlmacen.Nombre);
                cmd.Parameters.AddWithValue("_CODIGO_TIPO_ALMACEN", objetoTipoAlmacen.Codigo);
                cmd.Parameters.Add(new NpgsqlParameter(":resultado", NpgsqlDbType.Text)).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                res = (bool)cmd.Parameters[":resultado"].Value;
            }
            catch (Exception )
            {
                return false;
            }
            finally
            {
                cnn.Close();
            }
            return res;
        }
        public bool TipoCambio(int accion, C_TipoCambio objetoTipoCambio)
        {
            bool res = false;
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {

                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SPR_TIPO_CAMBIO", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("_ACCION", accion);
                cmd.Parameters.AddWithValue("_FECHA", objetoTipoCambio.Fecha);
                cmd.Parameters.AddWithValue("_VALOR", objetoTipoCambio.Valor);
                cmd.Parameters.AddWithValue("_OBSERVACION", objetoTipoCambio.Observacion);
                cmd.Parameters.AddWithValue("_CODIGO_DNI_USUARIO", objetoTipoCambio.Codigo);
                cmd.Parameters.Add(new NpgsqlParameter(":resultado", NpgsqlDbType.Text)).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                res = (bool)cmd.Parameters[":resultado"].Value;

            }
            catch (Exception )
            {
                return false;
            }
            finally
            {
                cnn.Close();
            }
            return res;
        }
        public int TipoCambioCodigo()
        {
            int res = 0;
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {

                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("Spr_TipoCambioCodigo", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.Add(new NpgsqlParameter(":resultado", NpgsqlDbType.Text)).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                res = (int)cmd.Parameters[":resultado"].Value;
            }
            catch (Exception e)
            {
                return 1;
            }
            finally
            {
                cnn.Close();
            }
            return res;
        }
        public double VerificarCantidad(string codigo_barras, int almacen, double cantidad)
        {
            double res = 0;
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {

                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("Spr_VerificarCantidad", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("_codigoBarras", codigo_barras);
                cmd.Parameters.AddWithValue("_almacen", almacen);
                cmd.Parameters.AddWithValue("_cantidad", cantidad);
                cmd.Parameters.Add(new NpgsqlParameter(":resultado", NpgsqlDbType.Text)).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                res = (double)cmd.Parameters[":resultado"].Value;
            }
            catch (Exception e)
            {
                return -1;
            }
            finally
            {
                cnn.Close();
            }
            return res;
        }
        public double TipoCambioDiario()
        {
            Double res = 0.0;
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {

                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("Spr_TipoCambioDiario", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.Add(new NpgsqlParameter(":resultado", NpgsqlDbType.Text)).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                res = (Double)cmd.Parameters[":resultado"].Value;
            }
            catch (Exception)
            {
                return 0.0;
            }
            finally
            {
                cnn.Close();
            }
            return res;
        }
        public bool TipoPago(int accion, C_TipoPago objetoTipoPago)
        {
            bool res = false;
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {

                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SPR_TIPO_PAGO", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("_ACCION", accion);
                cmd.Parameters.AddWithValue("_NOMBRE", objetoTipoPago.Nombre);
                cmd.Parameters.AddWithValue("_CODIGO_TIPO_CAMBIO", objetoTipoPago.Codigo);
                cmd.Parameters.Add(new NpgsqlParameter(":resultado", NpgsqlDbType.Text)).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                res = (bool)cmd.Parameters[":resultado"].Value;

            }
            catch (Exception )
            {
                return false;
            }
            finally
            {
                cnn.Close();
            }
            return res;

        }
        public bool TipoDocumento(int accion, C_TipoDocumento objetoTipoDocumento)
        {
            bool res = false;
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {

                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SPR_TIPO_DOCUMENTO", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("_ACCION", accion);
                cmd.Parameters.AddWithValue("_NOMBRE_DOCUMENTO", objetoTipoDocumento.Nombre);
                cmd.Parameters.AddWithValue("_CODIGO_TIPO_DOCUMENTO", objetoTipoDocumento.Codigo);
                cmd.Parameters.Add(new NpgsqlParameter(":resultado", NpgsqlDbType.Text)).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                res = (bool)cmd.Parameters[":resultado"].Value;

            }
            catch (Exception )
            {
                return false;
            }
            finally
            {
                cnn.Close();
            }
            return res;


        }
        public bool TipoLineaCredito(int accion, C_TipoLineaCredito objetoLineaCredito)
        {
            bool res = false;
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SPR_TIPO_LINEA_DE_CREDITO", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("_ACCION", accion);
                cmd.Parameters.AddWithValue("_NOMBRE", objetoLineaCredito.Nombre);
                cmd.Parameters.AddWithValue("_DETALLE", objetoLineaCredito.Detalle);
                cmd.Parameters.AddWithValue("_NOMBRE_COMPLETO", objetoLineaCredito.NombreCompleto);
                cmd.Parameters.AddWithValue("_CODIGO_TIPOS_LINEA_DE_CREDITO", objetoLineaCredito.Codigo);
                cmd.Parameters.Add(new NpgsqlParameter(":resultado", NpgsqlDbType.Text)).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                res = (bool)cmd.Parameters[":resultado"].Value;
            }
            catch (Exception )
            {
                return false;
            }
            finally
            {
                cnn.Close();
            }
            return res;
        }
        public bool TipoPrecio(int accion, C_TipoPrecio objetoTipoPrecio)
        {
            bool res = false;
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SPR_TIPO_PRECIO", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("_ACCION", accion);
                cmd.Parameters.AddWithValue("_NOMBRE", objetoTipoPrecio.Nombre);
                cmd.Parameters.AddWithValue("_CODIGO_TIPO_PRECIO", objetoTipoPrecio.Codigo);
                cmd.Parameters.Add(new NpgsqlParameter(":resultado", NpgsqlDbType.Text)).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                res = (bool)cmd.Parameters[":resultado"].Value;
            }
            catch (Exception )
            {
                return false;
            }
            finally
            {
                cnn.Close();
            }
            return res;
        }
        public bool TipoTrabajador(int accion, C_TipoTrabajador objetoTipoTrabajador)
        {
            bool res = false;
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SPR_TIPO_TRABAJADOR", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("_ACCION", accion);
                cmd.Parameters.AddWithValue("_PUESTO", objetoTipoTrabajador.Puesto);
                cmd.Parameters.AddWithValue("_CODIGO", objetoTipoTrabajador.Codigo);
                cmd.Parameters.Add(new NpgsqlParameter(":resultado", NpgsqlDbType.Text)).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                res = (bool)cmd.Parameters[":resultado"].Value;
            }
            catch (Exception )
            {
                return false;
            }
            finally
            {
                cnn.Close();
            }
            return res;
        }
        public bool Unidad(int accion, C_Unidad objetoUnidad)
        {
            bool res = false;
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SPR_UNIDAD", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("_ACCION", accion);
                cmd.Parameters.AddWithValue("_NOMBRE", objetoUnidad.Nombre);
                cmd.Parameters.AddWithValue("_SIMBOLO", objetoUnidad.Simbolo);
                cmd.Parameters.AddWithValue("_CODIGO", objetoUnidad.Codigo);
                cmd.Parameters.Add(new NpgsqlParameter(":resultado", NpgsqlDbType.Text)).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                res = (bool)cmd.Parameters[":resultado"].Value;
            }
            catch (Exception )
            {
                return false;
            }
            finally
            {
                cnn.Close();
            }
            return res;
        }
        public bool UnidadEquivalencias(int accion, C_UnidadEquivalencias objetoUnidad)
        {
            bool res = false;
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("spr_unidadEquivalencias", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("_ACCION", accion);
                cmd.Parameters.AddWithValue("_unidadpadre", objetoUnidad.CodigoPadre);
                cmd.Parameters.AddWithValue("_unidadhijo", objetoUnidad.CodigoHijo);
                cmd.Parameters.AddWithValue("_cantidadpadre", objetoUnidad.CantidadPadre);
                cmd.Parameters.AddWithValue("_cantidadhijo", objetoUnidad.CantidadHijo);
                cmd.Parameters.Add(new NpgsqlParameter(":resultado", NpgsqlDbType.Text)).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                res = (bool)cmd.Parameters[":resultado"].Value;
            }
            catch (Exception )
            {
                return false;
            }
            finally
            {
                cnn.Close();
            }
            return res;
        }
        public bool Usuario(int accion, C_Usuario objetoUsuario)
        {
            bool res = false;
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SPR_USUARIO", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("_ACCION", accion);
                cmd.Parameters.AddWithValue("_CODIGO_DNI_USUARIO", objetoUsuario.Dni);
                cmd.Parameters.AddWithValue("_CODIGO_TIPO_TRABAJADOR", objetoUsuario.CodigoTipoTrabajador);
                cmd.Parameters.AddWithValue("_PASSWOR", objetoUsuario.Password);
                cmd.Parameters.AddWithValue("_E_MAIL", objetoUsuario.Email);
                cmd.Parameters.AddWithValue("_NOMBRE_USUARIO", objetoUsuario.Nombre);
                cmd.Parameters.AddWithValue("_APELLIDO_PATERNO", objetoUsuario.ApellidoPaterno);
                cmd.Parameters.AddWithValue("_APELLIDO_MATERNO", objetoUsuario.ApellidoMaterno);
                cmd.Parameters.AddWithValue("_FECHA_NACIMIENTO", objetoUsuario.FechaNacimiento.Date);
                cmd.Parameters.AddWithValue("_LUGAR_NACIMIENTO", objetoUsuario.LugarNacimiento);
                cmd.Parameters.AddWithValue("_DIRECCION", objetoUsuario.Direccion);
                cmd.Parameters.AddWithValue("_FECHA_INICIO", objetoUsuario.FechaInicio.Date);
                cmd.Parameters.AddWithValue("_TELEFONO", objetoUsuario.Telefono);
                cmd.Parameters.Add(new NpgsqlParameter(":resultado", NpgsqlDbType.Text)).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                res = (bool)cmd.Parameters[":resultado"].Value;
            }
            catch (Exception )
            {
                return false;
            }
            finally
            {
                cnn.Close();
            }
            return res;
        }
        public bool Ventas(int accion, C_Venta objetoVenta)
        {
            bool res = false;
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SPR_VENTAS", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("_ACCION", accion);
                cmd.Parameters.AddWithValue("_CODIGO_CAJA", objetoVenta.CodigoCaja);
                cmd.Parameters.AddWithValue("_CODIGO_TIPO_DOCUMENTO", objetoVenta.CodigoTipoDocumento);
                cmd.Parameters.AddWithValue("_CODIGO_TIPO_PAGO", objetoVenta.CodigoTipoPago);
                cmd.Parameters.AddWithValue("_CODIGO_CLIENTE", objetoVenta.CodigoCliente);
                cmd.Parameters.AddWithValue("_CODIGO_EMPRESA", objetoVenta.CodigoEmpresa);
                cmd.Parameters.AddWithValue("_NUMERO_DOCUMENTO_VENTA", objetoVenta.NumeroDocumentoVenta);
                cmd.Parameters.AddWithValue("_TOTAL_VENTA", objetoVenta.TotalVenta);
                cmd.Parameters.AddWithValue("_CODIGO_VENTA", objetoVenta.Codigo);
                cmd.Parameters.Add(new NpgsqlParameter(":resultado", NpgsqlDbType.Text)).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                res = (bool)cmd.Parameters[":resultado"].Value;
            }
            catch (Exception )
            {
                return false;
            }
            finally
            {
                cnn.Close();
            }
            return res;

        }
        public int VentasCodigo(C_Venta objetoVenta)
        {
            int res = 0;
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SPR_CODIGO_VENTA", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("_NUMERO_DOCUMENTO_VENTA", objetoVenta.NumeroDocumentoVenta);
                cmd.Parameters.Add(new NpgsqlParameter(":resultado", NpgsqlDbType.Text)).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                res = (int)cmd.Parameters[":resultado"].Value;
            }
            catch (Exception )
            {
                return 0;
            }
            finally
            {
                cnn.Close();
            }
            return res;

        }
        public bool VentaDetalle(int accion, C_VentaDetalle objetoVentaDetalle)
        {
            bool res = false;
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SPR_DETALLE_VENTA", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("_ACCION", accion);
                cmd.Parameters.AddWithValue("_CODIGO_VENTA", objetoVentaDetalle.CodigoVenta);
                cmd.Parameters.AddWithValue("_CODIGO_BARRAS", objetoVentaDetalle.CodigoBarras);
                cmd.Parameters.AddWithValue("_CANTIDAD", objetoVentaDetalle.Cantidad);
                cmd.Parameters.AddWithValue("_TIPO_PRECIO", objetoVentaDetalle.CodigoTipoPrecio);
                cmd.Parameters.AddWithValue("_PRECIO", objetoVentaDetalle.Precio);
                cmd.Parameters.AddWithValue("_PRECIO_TOTAL", objetoVentaDetalle.PrecioTotal);
                cmd.Parameters.AddWithValue("_DESCUENTO", objetoVentaDetalle.Descuento);
                cmd.Parameters.AddWithValue("_GARANTIA", objetoVentaDetalle.Garantia);
                cmd.Parameters.AddWithValue("_CODIGO_VENTA_ARTICULOS", objetoVentaDetalle.CodigoVentaArticulo);
                cmd.Parameters.Add(new NpgsqlParameter(":resultado", NpgsqlDbType.Text)).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                res = (bool)cmd.Parameters[":resultado"].Value;
            }
            catch (Exception )
            {
                return false;
            }
            finally
            {
                cnn.Close();
            }
            return res;

        }
        public bool OrdenCompra(int accion, C_OrdenCompra objetoOrdenCompra)
        {
            bool res = false;
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SPR_ORDEN_DE_COMPRA", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("_ACCION", accion);
                cmd.Parameters.AddWithValue("_CODIGO_DNI_USUARIO", objetoOrdenCompra.CodigoDniUsuario);
                cmd.Parameters.AddWithValue("_CODIGO_PROVEEDOR", objetoOrdenCompra.CodigoProveedor);
                cmd.Parameters.AddWithValue("_REFERENCIA_ORDEN_COMPRA", objetoOrdenCompra.ReferenciaOrdenCompra);
                cmd.Parameters.AddWithValue("_NUM_DOCUMENTO", objetoOrdenCompra.NumeroDocumento);
                cmd.Parameters.AddWithValue("_CODIGO_ORDEN_DE_COMPRA", objetoOrdenCompra.Codigo);
                cmd.Parameters.Add(new NpgsqlParameter(":resultado", NpgsqlDbType.Text)).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                res = (bool)cmd.Parameters[":resultado"].Value;
            }
            catch (Exception )
            {
                return false;
            }
            finally
            {
                cnn.Close();
            }
            return res;

        }
        public bool OrdenCompraDetalle(int accion, C_OrdenCompraDetalle objetoOrdenCompraDetalle)
        {
            bool res = false;
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SPR_DETALLE_ORDEN_COMPRA", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("_ACCION", accion);
                cmd.Parameters.AddWithValue("_CANTIDAD", objetoOrdenCompraDetalle.Cantidad);
                cmd.Parameters.AddWithValue("_CODIGO_ORDEN_COMPRA", objetoOrdenCompraDetalle.CodigoOrdenCompra);
                cmd.Parameters.AddWithValue("_CODIGO_BARRAS", objetoOrdenCompraDetalle.CodigoBarras);
                cmd.Parameters.Add(new NpgsqlParameter(":resultado", NpgsqlDbType.Text)).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                res = (bool)cmd.Parameters[":resultado"].Value;
            }
            catch (Exception )
            {
                return false;
            }
            finally
            {
                cnn.Close();
            }
            return res;

        }
        public int OrdenCompraCodigo(C_OrdenCompra objetoOrdenCompra)
        {
            int res = 0;
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SPR_CODIGO_ORDEN_COMPRA", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("_CODIGO_PROVEEDOR", objetoOrdenCompra.CodigoProveedor);
                cmd.Parameters.AddWithValue("_NUM_DOCUMENTO", objetoOrdenCompra.NumeroDocumento);
                cmd.Parameters.Add(new NpgsqlParameter(":resultado", NpgsqlDbType.Text)).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                res = (int)cmd.Parameters[":resultado"].Value;
            }
            catch (Exception )
            {
                return 0;
            }
            finally
            {
                cnn.Close();
            }
            return res;

        }
        public double UnidadesEquivalencia(int codigoBase, int codigoHijo)
        {
            double res = 0;
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("spr_unidadesesquivalencia", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("_codigoBase", codigoBase);
                cmd.Parameters.AddWithValue("_codigoHijo", codigoHijo);
                cmd.Parameters.Add(new NpgsqlParameter(":resultado", NpgsqlDbType.Text)).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                res = (double)cmd.Parameters[":resultado"].Value;
            }
            catch (Exception)
            {
                return 0;
            }
            finally
            {
                cnn.Close();
            }
            return res;
        }
        public double StockPorAlmancen(C_Almacen_Producto objetoAlmacen)
        {
            int res = 0;
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("spr_stockporalmacen", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("_CODIGO_BARRAS", objetoAlmacen.CodigoProducto);
                cmd.Parameters.AddWithValue("_CODIGO_ALMACEN", objetoAlmacen.CodigoAlmacen);
                cmd.Parameters.Add(new NpgsqlParameter(":resultado", NpgsqlDbType.Text)).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                res = (int)cmd.Parameters[":resultado"].Value;
            }
            catch (Exception )
            {
                return 0;
            }
            finally
            {
                cnn.Close();
            }
            return res;

        }
        public bool CreditoCompraVenta(int accion, C_Credito objetoCredito)
        {
            bool res = false;
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SPR_CREDITO", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("_ACCION", accion);
                cmd.Parameters.AddWithValue("_CODIGO_COMPRA", objetoCredito.CodigoCompra);
                cmd.Parameters.AddWithValue("_CODIGO_VENTA", objetoCredito.CodigoVenta);
                cmd.Parameters.AddWithValue("_CODIGO_CREDITOTRABAJADOR", objetoCredito.CodigoTrabajador);
                cmd.Parameters.AddWithValue("_FECHA_PROX_PAGO", objetoCredito.FechaProxPago);
                cmd.Parameters.AddWithValue("_TOTAL_DEUDA", objetoCredito.TotalDeuda);
                cmd.Parameters.AddWithValue("_MONTO", objetoCredito.Monto);
                cmd.Parameters.AddWithValue("_CODIGO_CAJA", objetoCredito.CodigoCaja);
                cmd.Parameters.AddWithValue("_CODIGO_TIPO_CAJA", objetoCredito.CodigoTipoCaja);
                cmd.Parameters.AddWithValue("_CODIGO_CREDITO", objetoCredito.CodigoCredito);
                cmd.Parameters.Add(new NpgsqlParameter(":resultado", NpgsqlDbType.Text)).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                res = (bool)cmd.Parameters[":resultado"].Value;
            }
            catch (Exception )
            {
                return false;
            }
            finally
            {
                cnn.Close();
            }
            return res;
        }
        public DateTime SumaFecha(C_Credito objetoCredito)
        {
            DateTime res;
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SPR_CREDITO", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("_CODIGO_PROVEEDOR", objetoCredito.CodigoProveedor);
                cmd.Parameters.AddWithValue("_FECHA", objetoCredito.Fecha);
                cmd.Parameters.Add(new NpgsqlParameter(":resultado", NpgsqlDbType.Text)).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                res = (DateTime)cmd.Parameters[":resultado"].Value;
            }
            catch (Exception )
            {
                return DateTime.Now;
            }
            finally
            {
                cnn.Close();
            }
            return res;
        }
        public bool Auditoria(int dni, string password)
        {
            bool res = false;
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {

                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("Spr_Auditoria", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("_ACCION", dni);
                cmd.Parameters.AddWithValue("_NOMBRE", password);
                cmd.Parameters.Add(new NpgsqlParameter(":resultado", NpgsqlDbType.Text)).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                res = (bool)cmd.Parameters[":resultado"].Value;

            }
            catch (Exception )
            {
                return false;
            }
            finally
            {
                cnn.Close();
            }
            return res;
        }
        public int CodigoTipoAlmacen(int codigoAlmacen)
        {
            int res = 0;
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("spr_codigo_tipo_almacen", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("_codigo_almacen", codigoAlmacen);
                cmd.Parameters.Add(new NpgsqlParameter(":resultado", NpgsqlDbType.Text)).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                res = (int)cmd.Parameters[":resultado"].Value;
            }
            catch (Exception )
            {
                return 0;
            }
            finally
            {
                cnn.Close();
            }
            return res;
        }
        public bool Menu_Union(int accion, int codigoMenu, int codigoUsuario)
        {
            bool res = false;
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("spr_menu_union ", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("_ACCION", accion);
                cmd.Parameters.AddWithValue("_CodigoMenu", codigoMenu);
                cmd.Parameters.AddWithValue("_codigoUsuario", codigoUsuario);
                cmd.Parameters.Add(new NpgsqlParameter(":resultado", NpgsqlDbType.Text)).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                res = (bool)cmd.Parameters[":resultado"].Value;
            }
            catch (Exception )
            {
                return false;
            }
            finally
            {
                cnn.Close();
            }
            return res;
        }
        public bool TrabajadorProveedor(int accion, C_TrabajadorProveedor objetoTrabajadorProveedor)
        {
            bool res = false;
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SPR_TRABAJADORES_PROVEEDOR", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("_ACCION", accion);
                cmd.Parameters.AddWithValue("_CODIGO_PROVEEDOR", objetoTrabajadorProveedor.CodigoProveedor);
                cmd.Parameters.AddWithValue("_CELULAR", objetoTrabajadorProveedor.Celular);
                cmd.Parameters.AddWithValue("_NOMBRE", objetoTrabajadorProveedor.Nombre);
                cmd.Parameters.AddWithValue("_APELLIDO_PATERNO", objetoTrabajadorProveedor.ApellidoPaterno);
                cmd.Parameters.AddWithValue("_APELLIDO_MATERNO", objetoTrabajadorProveedor.ApellidoMaterno);
                cmd.Parameters.AddWithValue("_CODIGO_TRABAJADORES_PROVEEDOR", objetoTrabajadorProveedor.CodigoTrabajadorProveedor);
                cmd.Parameters.Add(new NpgsqlParameter(":resultado", NpgsqlDbType.Text)).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                res = (bool)cmd.Parameters[":resultado"].Value;
            }
            catch (Exception )
            {
                return false;
            }
            finally
            {
                cnn.Close();
            }
            return res;
        }
        public bool SerialExiste(C_CodigoSerial objetoSerialProducto)
        {
            bool res = false;
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SPR_SERIALEXISTE", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("_SERIAL", objetoSerialProducto.CodigoSerial);
                cmd.Parameters.Add(new NpgsqlParameter(":resultado", NpgsqlDbType.Text)).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                res = (bool)cmd.Parameters[":resultado"].Value;
            }
            catch (Exception )
            {
                return false;
            }
            finally
            {
                cnn.Close();
            }
            return res;
        }

        public bool CodigoSerieExiste(C_SerialProducto objetoSerialProducto) 
        {
            bool res = false;
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("spr_codigo_serie", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("_SERIAL", objetoSerialProducto.Serial);
                cmd.Parameters.Add(new NpgsqlParameter(":resultado", NpgsqlDbType.Text)).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                res = (bool)cmd.Parameters[":resultado"].Value;
            }
            catch (Exception )
            {
                return false;
            }
            finally
            {
                cnn.Close();
            }
            return res;
        }

        public int CodigoTrabajadorCredito(C_CreditoTrabajador objetoCreditoTrabajador)
        {
            int res = 0;
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SPR_TRABAJADORCODIGO", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("_CODIGO_USUARIO", objetoCreditoTrabajador.CodigoUsuario);
                cmd.Parameters.AddWithValue("_CODIGO_TIPOPAGO", objetoCreditoTrabajador.CodigoTipoPago);
                cmd.Parameters.AddWithValue("_MONTO_TOTAL_PRESTAMO", objetoCreditoTrabajador.MontoPrestamo);
                cmd.Parameters.AddWithValue("_NUMERO_DOCUMENTO", objetoCreditoTrabajador.NumeroDocumento);
                cmd.Parameters.AddWithValue("_OBSERVACION", objetoCreditoTrabajador.Observacion);
                cmd.Parameters.AddWithValue("_CODIGO_CAJA", objetoCreditoTrabajador.CodigoCaja);
                cmd.Parameters.Add(new NpgsqlParameter(":resultado", NpgsqlDbType.Text)).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                res = (int)cmd.Parameters[":resultado"].Value;
            }
            catch (Exception )
            {
                return 0;
            }
            finally
            {
                cnn.Close();
            }
            return res;
        }

        public void BilletajeCajaBorrar(int codigoCaja, int accion)
        {
            bool res = false;
            try
            {
                NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("delete from billetaje_caja where codigo_caja = " + codigoCaja + " and tipo = " + accion + ";", cnn);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                res = (bool)cmd.Parameters[":resultado"].Value;
                cnn.Close();
            }
            catch (Exception )
            {
                return;
            }
            return;
        }




        // MOSTRAR 

        public List<C_Almacen> AlmacenMostrar()
        {
            List<C_Almacen> lista = new List<C_Almacen>();
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("select codigo_almacen, codigo_tipo_almacen, nombre from almacen where flag = 1", cnn);
                cmd.CommandType = System.Data.CommandType.Text;
                NpgsqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        lista.Add(new C_Almacen
                        {
                            Codigo = rd.GetInt32(0),
                            CodigoTipoAlmacen = rd.GetInt32(1),
                            Nombre = rd.GetString(2),
                        });
                    }
                }
            }
            catch (Exception )
            {
                throw new Exception("Error al mostrar" );
            }
            finally
            {
                cnn.Close();
            }
            return lista;
        }
        public List<C_Almacen_Producto> AlmacenProductoMostrar(int codigo)
        {
            List<C_Almacen_Producto> lista = new List<C_Almacen_Producto>();
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                
                cnn.Open();
                //select codigo_almacen, codigo_tipo_almacen, nombre from almacen where flag = 1
                NpgsqlCommand cmd = new NpgsqlCommand("select codigo_barras, codigo_almacen, stock, producto from vw_AlmacenProductos where codigo_almacen = " + codigo, cnn);
                cmd.CommandType = System.Data.CommandType.Text;
                NpgsqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        lista.Add(new C_Almacen_Producto
                        {
                            CodigoProducto = rd.GetString(0),
                            CodigoAlmacen = rd.GetInt32(1),
                            Cantidad = rd.GetDouble(2),
                            NombreProducto = rd.GetString(3)
                        });
                    }
                }
            }
            catch (Exception )
            {
                throw new Exception("Error al mostrar" );
            }
            finally
            {
                cnn.Close();
            }
            return lista;
        }
        public List<C_TrabajadorProveedor> TrabajadorProveedorMostrar()
        {
            List<C_TrabajadorProveedor> lista = new List<C_TrabajadorProveedor>();
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT codigo_trabajadores_proveedor, nombre,apellido_paterno,apellido_materno,celular from trabajadores_proveedor where flag = 1 ;", cnn);
                cmd.CommandType = System.Data.CommandType.Text;
                NpgsqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        lista.Add(new C_TrabajadorProveedor
                        {
                            CodigoTrabajadorProveedor = rd.GetInt32(0),
                            Nombre = rd.GetString(1),
                            ApellidoPaterno = rd.GetString(2),
                            ApellidoMaterno = rd.GetString(3),
                            Celular = rd.GetString(4),

                        });
                    }
                }
            }
            catch (Exception )
            {
                throw new Exception("Error al mostrar" );
            }
            finally
            {
                cnn.Close();
            }
            return lista;
        }
        public List<C_TrabajadorProveedor> TrabajdorProveedorPorProveedor(int codigo)
        {
            List<C_TrabajadorProveedor> lista = new List<C_TrabajadorProveedor>();
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT codigo_trabajadores_proveedor, nombre,apellido_paterno,apellido_materno,celular from trabajadores_proveedor where codigo_proveedor = " + codigo + " and  flag = 1 ;", cnn);
                cmd.CommandType = System.Data.CommandType.Text;
                NpgsqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        lista.Add(new C_TrabajadorProveedor
                        {
                            CodigoTrabajadorProveedor = rd.GetInt32(0),
                            Nombre = rd.GetString(1),
                            ApellidoPaterno = rd.GetString(2),
                            ApellidoMaterno = rd.GetString(3),
                            Celular = rd.GetString(4),

                        });
                    }
                }
            }
            catch (Exception )
            {
                throw new Exception("Error al mostrar" );
            }
            finally
            {
                cnn.Close();
            }
            return lista;
        }
        public List<C_TrabajadorProveedor> TrabajadorProveedorDGV(int codigo)
        {
            List<C_TrabajadorProveedor> lista = new List<C_TrabajadorProveedor>();
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT NOMBRE , APELLIDO_PATERNO , APELLIDO_MATERNO , CELULAR FROM TRABAJADORES_PROVEEDOR WHERE CODIGO_PROVEEDOR = " + codigo + " ;", cnn);
                cmd.CommandType = System.Data.CommandType.Text;
                NpgsqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        lista.Add(new C_TrabajadorProveedor
                        {
                            Nombre = rd.GetString(0),
                            ApellidoPaterno = rd.GetString(1),
                            ApellidoMaterno = rd.GetString(2),
                            Celular = rd.GetString(3)

                        });
                    }
                }
            }
            catch (Exception )
            {
                throw new Exception("Error al mostrar" );
            }
            finally
            {
                cnn.Close();
            }
            return lista;
        }
        public List<C_Billetaje> BilletajeCajaMostrar(int codigoCaja)
        {
            List<C_Billetaje> lista = new List<C_Billetaje>();
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("select codigo_billetaje , cantidad from billetaje_caja where codigo_caja = " + codigoCaja + " and tipo = 2;", cnn);
                cmd.CommandType = System.Data.CommandType.Text;
                NpgsqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        lista.Add(new C_Billetaje
                        {
                            Codigo = rd.GetInt32(0),
                            Cantidad = rd.GetInt32(1)
                        });
                    }
                }
            }
            catch (Exception )
            {
                throw new Exception("Error al mostrar" );
            }
            finally
            {
                cnn.Close();
            }
            return lista;
        }
        public List<C_Billetaje> BilletajeMostrar()
        {
            List<C_Billetaje> lista = new List<C_Billetaje>();
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("select codigo_billetaje, denominacion, valor from billetaje order by codigo_billetaje;", cnn);
                cmd.CommandType = System.Data.CommandType.Text;
                NpgsqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        lista.Add(new C_Billetaje
                        {
                            Codigo = rd.GetInt32(0),
                            Denominacion = rd.GetString(1),
                            Valor = rd.GetDouble(2),
                            Cantidad = 0
                        });
                    }
                }
            }
            catch (Exception )
            {
                throw new Exception("Error al mostrar" );
            }
            finally
            {
                cnn.Close();
            }
            return lista;
        }
        public List<C_TipoPago> CajaEgresosTipoPago(int codigoCaja)
        {
            List<C_TipoPago> lista = new List<C_TipoPago>();
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("select nombre ,sum(total) from ( select nombre, sum (monto_pagar) as total from vw_pago where codigo_caja = " + codigoCaja + "  and  codigo_compra is not null group by nombre union select nombre, sum(monto_total_prestamo) as total from vw_creditotrabajador where codigo_caja = " + codigoCaja + "  group by nombre) t group by nombre", cnn);
                cmd.CommandType = System.Data.CommandType.Text;
                NpgsqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        lista.Add(new C_TipoPago
                        {
                            Nombre = rd.GetString(0),
                            Cantidad = rd.GetDouble(1)
                        });
                    }
                }
            }
            catch (Exception )
            {
                throw new Exception("Error al mostrar" );
            }
            finally
            {
                cnn.Close();
            }
            return lista;
        }
        public List<C_TipoPago> CajaIngresosTipoPago(int codigoCaja)
        {
            List<C_TipoPago> lista = new List<C_TipoPago>();
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("select nombre, sum(total) from ( select nombre, sum(total_venta) as total from vw_ventas where codigo_caja = " + codigoCaja + " group by nombre  union  select nombre, sum (monto_pagar) as total from vw_pago where codigo_caja = " + codigoCaja + " and  codigo_venta is not null group by nombre  union  select nombre,  sum(monto_pagar) as total from vw_pago where codigo_caja  = " + codigoCaja + " and codigo_dni_usuario is not null group by nombre ) t  group by nombre; ", cnn);
                cmd.CommandType = System.Data.CommandType.Text;
                NpgsqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        lista.Add(new C_TipoPago
                        {
                            Nombre = rd.GetString(0),
                            Cantidad = rd.GetDouble(1)
                        });
                    }
                }
            }
            catch (Exception )
            {
                throw new Exception("Error al mostrar" );
            }
            finally
            {
                cnn.Close();
            }
            return lista;
        }
        public List<C_Categoria> CategoriaMostrar()
        {
            List<C_Categoria> lista = new List<C_Categoria>();
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("select codigo_categoria, nombre from categoria where flag = 1", cnn);
                cmd.CommandType = System.Data.CommandType.Text;
                NpgsqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        lista.Add(new C_Categoria
                        {
                            Codigo = rd.GetInt32(0),
                            Nombre = rd.GetString(1)
                        });
                    }
                }
            }
            catch (Exception )
            {
                throw new Exception("Error al mostrar" );
            }
            finally
            {
                cnn.Close();
            }
            return lista;
        }
        public List<C_Compra> DocumentoPorFecha(DateTime fecha)
        {
            List<C_Compra> lista = new List<C_Compra>();
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("select codigo_credito, numero_documento from compra where fecha_compra::date = '" + fecha.ToShortDateString() + "'::date", cnn);
                cmd.CommandType = System.Data.CommandType.Text;
                NpgsqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        lista.Add(new C_Compra
                        {
                            Codigo = rd.GetInt32(0),
                            NumeroDocumento = rd.GetString(1)
                        });
                    }
                }
                cnn.Close();
            }
            catch (Exception )
            {
                throw new Exception("Error al mostrar" );
            }
            finally
            {
                cnn.Close();
            }
            return lista;
        }
        public List<C_OrdenCompra> OrdenDocumentoPorFecha(DateTime fecha)
        {
            List<C_OrdenCompra> lista = new List<C_OrdenCompra>();
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("select codigo_orden_de_compra, num_documento from orden_de_compra where fecha_orden_compra::date = '" + fecha.ToShortDateString() + "'::date", cnn);
                cmd.CommandType = System.Data.CommandType.Text;
                NpgsqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        lista.Add(new C_OrdenCompra
                        {
                            Codigo = rd.GetInt32(0),
                            NumeroDocumento = rd.GetString(1)
                        });
                    }
                }
            }
            catch (Exception )
            {
                throw new Exception("Error al mostrar" );
            }
            finally
            {
                cnn.Close();
            }
            return lista;
        }
        public List<C_Compra> BuscarCompra(int codigo)
        {
            List<C_Compra> lista = new List<C_Compra>();
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("select codigo_credito, codigo_proveedor, codigo_tipo_cambio, codigo_tipo_documento,codigo_moneda,fecha_compra,monto_total_compra,numero_documento from compra compra WHERE codigo_credito = " + codigo, cnn);
                cmd.CommandType = System.Data.CommandType.Text;
                NpgsqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        lista.Add(new C_Compra
                        {
                            Codigo = rd.GetInt32(0),
                            CodigoProveedor = rd.GetInt32(1),
                            CodigoTipoCambio = rd.GetInt32(2),
                            CodigoTipoDocumento = rd.GetInt32(3),
                            CodigoMoneda = rd.GetInt32(4),
                            FechaCompra = rd.GetDateTime(5),
                            MontoTotal = rd.GetDouble(6),
                            NumeroDocumento = rd.GetString(7)
                        });
                    }
                }
            }
            catch (Exception )
            {
                throw new Exception("Error al mostrar" );
            }
            finally
            {
                cnn.Close();
            }
            return lista;
        }
        public List<C_Credito> CreditoTrabajadorMostrar()
        {
            List<C_Credito> lista = new List<C_Credito>();
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("select  codigo_credito, numero_documento, nombre_completo, monto_total_prestamo, monto, deuda, fecha_prox_pago, flag_pagado from vw_creditotrabajador where flag_pagado = 1;", cnn);
                cmd.CommandType = System.Data.CommandType.Text;
                NpgsqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        lista.Add(new C_Credito
                        {
                            CodigoCredito = rd.GetInt32(0),
                            NumeroDocumento = rd.GetString(1),
                            Nombre = rd.GetString(2),
                            TotalDeuda = rd.GetDouble(3),
                            Monto = rd.GetDouble(4),
                            Deuda = rd.GetDouble(5),
                            Fecha = rd.GetDateTime(6)

                        });
                    }
                }
            }
            catch (Exception )
            {
                throw new Exception("Error al mostrar" );
            }
            finally
            {
                cnn.Close();
            }
            return lista;
        }
        public List<C_Credito> CreditoCompraMostrar()
        {
            List<C_Credito> lista = new List<C_Credito>();
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("select codigo_credito, codigo, numero_documento, nombre ,total_deuda, monto, deuda , fecha_prox_pago  from vw_creditoCompra where flag_pagado = 1", cnn);
                cmd.CommandType = System.Data.CommandType.Text;
                NpgsqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        lista.Add(new C_Credito
                        {
                            CodigoCredito = rd.GetInt32(0),
                            Codigo = rd.GetInt32(1),
                            NumeroDocumento = rd.GetString(2),
                            Nombre = rd.GetString(3),
                            TotalDeuda = rd.GetDouble(4),
                            Monto = rd.GetDouble(5),
                            Deuda = rd.GetDouble(6),
                            Fecha = rd.GetDateTime(7)

                        });
                    }
                }
            }
            catch (Exception )
            {
                throw new Exception("Error al mostrar" );
            }
            finally
            {
                cnn.Close();
            }
            return lista;
        }
        public List<C_Credito> CreditoVentaMostrar()
        {
            List<C_Credito> lista = new List<C_Credito>();
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("select codigo_credito, codigo, numero_documento_venta,cliente, total_deuda, monto, deuda, fecha_prox_pago from vw_creditoventa where flag_pagado = 1;", cnn);
                cmd.CommandType = System.Data.CommandType.Text;
                NpgsqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        lista.Add(new C_Credito
                        {
                            CodigoCredito = rd.GetInt32(0),
                            Codigo = rd.GetInt32(1),
                            NumeroDocumento = rd.GetString(2),
                            Nombre = rd.GetString(3),
                            TotalDeuda = rd.GetDouble(4),
                            Monto = rd.GetDouble(5),
                            Deuda = rd.GetDouble(6),
                            Fecha = rd.GetDateTime(7)

                        });
                    }
                }
            }
            catch (Exception )
            {
                throw new Exception("Error al mostrar" );
            }
            finally
            {
                cnn.Close();
            }
            return lista;
        }
        public List<C_Descuento> DescuentoMostrar()
        {
            List<C_Descuento> lista = new List<C_Descuento>();
            for (int i = 0; i < 101; i++)
            {
                lista.Add(new C_Descuento
                {
                    Valor = i,
                    Nombre = i + " %"
                });
            }
            return lista;
        }
        public List<C_Familia> FamiliaMostrar()
        {
            List<C_Familia> lista = new List<C_Familia>();
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("select codigo_familia, nombre from familia where flag = 1", cnn);
                cmd.CommandType = System.Data.CommandType.Text;
                NpgsqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        lista.Add(new C_Familia
                        {
                            Codigo = rd.GetInt32(0),
                            Nombre = rd.GetString(1)
                        });
                    }
                }
            }
            catch (Exception )
            {
                throw new Exception("Error al mostrar" );
            }
            finally
            {
                cnn.Close();
            }
            return lista;
        }
        public List<C_Marca> MarcaMostrar()
        {
            List<C_Marca> lista = new List<C_Marca>();
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("select codigo_marca, nombre from marca where flag = 1", cnn);
                cmd.CommandType = System.Data.CommandType.Text;
                NpgsqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        lista.Add(new C_Marca
                        {
                            Codigo = rd.GetInt32(0),
                            Nombre = rd.GetString(1)
                        });
                    }
                }
            }
            catch (Exception )
            {
                throw new Exception("Error al mostrar" );
            }
            finally
            {
                cnn.Close();
            }
            return lista;
        }
        public List<string> MenuCabezera()
        {
            List<string> lista = new List<string>();
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("select codigo, usuario, fecha_ini, fecha_fin, saldo_ini, saldo_fin, observacion, observacion2  from caja_usuario where fecha_ini = '", cnn);
                cmd.CommandType = System.Data.CommandType.Text;
                NpgsqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        lista.Add(rd.GetString(1));
                    }
                }
            }
            catch (Exception )
            {
                throw new Exception("Error al mostrar" );
            }
            finally
            {
                cnn.Close();
            }
            return lista;
        }
        public List<string> MenuDetalle(string Menu)
        {
            List<string> lista = new List<string>();
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("select codigo, usuario, fecha_ini, fecha_fin, saldo_ini, saldo_fin, observacion, observacion2  from caja_usuario where fecha_ini = '", cnn);
                cmd.CommandType = System.Data.CommandType.Text;
                NpgsqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        lista.Add(rd.GetString(1));
                    }
                }
            }
            catch (Exception )
            {
                throw new Exception("Error al mostrar" );
            }
            finally
            {
                cnn.Close();
            }
            return lista;
        }
        public List<C_NombreCaja> NombreCajaMostrar()
        {
            List<C_NombreCaja> lista = new List<C_NombreCaja>();
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("select codigo_nombre_caja, nombre from nombre_caja where flag = 1", cnn);
                cmd.CommandType = System.Data.CommandType.Text;
                NpgsqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        lista.Add(new C_NombreCaja
                        {
                            Codigo = rd.GetInt32(0),
                            Nombre = rd.GetString(1)
                        });
                    }
                }
            }
            catch (Exception )
            {
                throw new Exception("Error al mostrar" );
            }
            finally
            {
                cnn.Close();
            }
            return lista;
        }
        public List<C_Cliente> ClienteMostrar()
        {
            List<C_Cliente> lista = new List<C_Cliente>();
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
               
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("select codigo_cliente, dni, nombre, apellido_paterno, apellido_materno from cliente where flag = 1 ", cnn);
                cmd.CommandType = System.Data.CommandType.Text;
                NpgsqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        lista.Add(new C_Cliente
                        {
                            Codigo = rd.GetInt32(0),
                            Dni = rd.GetString(1),
                            Nombre = rd.GetString(2),
                            Apellido_paterno = rd.GetString(3),
                            Apellido_materno = rd.GetString(4),
                        });
                    }
                }
            }
            catch (Exception )
            {
                throw new Exception("Error al mostrar" );
            }
            finally
            {
                cnn.Close();
            }
            return lista;
        }
        public List<C_Empresa> EmpresaMostrar()
        {
            List<C_Empresa> lista = new List<C_Empresa>();
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("select codigo_empresa, ruc, nombre, direccion, telefono from empresa where flag = 1", cnn);
                cmd.CommandType = System.Data.CommandType.Text;
                NpgsqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        lista.Add(new C_Empresa
                        {
                            Codigo = rd.GetInt32(0),
                            Ruc = rd.GetString(1),
                            Nombre = rd.GetString(2),
                            Direccion = rd.GetString(3),
                            Telefono = rd.GetString(4)
                        });
                    }
                }
            }
            catch (Exception )
            {
                throw new Exception("Error al mostrar" );
            }
            finally
            {
                cnn.Close();
            }
            return lista;
        }
        public List<C_Kardex> KardexMostrar(string codigo)
        {
            List<C_Kardex> lista = new List<C_Kardex>();
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("select * from vw_kardex where codigo = '" + codigo +"'", cnn);
                cmd.CommandType = System.Data.CommandType.Text;
                NpgsqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        lista.Add(new C_Kardex
                        {
                            NumeroDocumento = rd.GetString(0),
                            Fecha = rd.GetDateTime(1),
                            Codigo = rd.GetString(2),
                            Ingreso = rd.GetDouble(3),
                            Egreso = rd.GetDouble(4)
                        });

                    }
                }
            }
            catch (Exception ex )
            {
                throw new Exception("Error al mostrar"  + ex);
            }
            finally
            {
                cnn.Close();
            }
            return lista;
        }
        public List<C_Producto> ProductoMostrar()
        {
            List<C_Producto> lista = new List<C_Producto>();
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("select codigo_barras, codigo_marca, codigo_familia, codigo_categoria, codigo_unidad, tiempo_garantia, nombre from productos where flag_disponible = 1", cnn);
                cmd.CommandType = System.Data.CommandType.Text;
                NpgsqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        lista.Add(new C_Producto
                        {
                            CodigoBarras = rd.GetString(0),
                            CodigoMarca = rd.GetInt32(1),
                            CodigoFamilia = rd.GetInt32(2),
                            CodigoCategoria = rd.GetInt32(3),
                            CodigoUnidad = rd.GetInt32(4),
                            TiempoGarantia = rd.GetString(5),
                            Nombre = rd.GetString(6),
                        });
                    }
                }
            }
            catch (Exception )
            {
                throw new Exception("Error al mostrar" );
            }
            finally
            {
                cnn.Close();
            }
            return lista;
        }
        public List<C_ProductoPrecio> ProductoPrecioMostrar(string codigoProducto)
        {
            List<C_ProductoPrecio> lista = new List<C_ProductoPrecio>();
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("select codigo_tipo_precio, nombre, codigo_barras, precio from vw_Producto_Precio where codigo_barras = '" + codigoProducto + "'", cnn);
                cmd.CommandType = System.Data.CommandType.Text;
                NpgsqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        lista.Add(new C_ProductoPrecio
                        {
                            CodigoTipoPrecio = rd.GetInt32(0),
                            Nombre = rd.GetString(1),
                            CodigoBarras = rd.GetString(2),
                            Precio = rd.GetDouble(3)
                        });
                    }
                }
            }
            catch (Exception )
            {
                throw new Exception("Error al mostrar" );
            }
            finally
            {
                cnn.Close();
            }
            return lista;
        }
        public List<C_Proveedor> ProveedorMostrar()
        {
            List<C_Proveedor> lista = new List<C_Proveedor>();
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("select codigo_proveedor, codigo_tipos_linea_de_credito, ruc, monto_maximo_prestamo, cuenta_ahorros_soles, cuenta_ahorros_dolares, pagina_web, telefono, direccion, nombre from proveedores where flag = 1", cnn);
                cmd.CommandType = System.Data.CommandType.Text;
                NpgsqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        lista.Add(new C_Proveedor
                        {
                            Codigo = rd.GetInt32(0),
                            CodigoTipoLineaCredito = rd.GetInt32(1),
                            RUC = rd.GetString(2),
                            MontoPrestamo = rd.GetDouble(3),
                            CuentasSoles = rd.GetString(4),
                            CuentaDolares = rd.GetString(5),
                            PaginaWeb = rd.GetString(6),
                            Telefono = rd.GetInt32(7),
                            Direccion = rd.GetString(8),
                            Nombre = rd.GetString(9)
                        });
                    }
                }
            }
            catch (Exception )
            {
                throw new Exception("Error al mostrar" );
            }
            finally
            {
                cnn.Close();
            }
            return lista;
        }
        public List<C_Menu> MenuMostrar(int codigo, int codigoDni)
        {
            List<C_Menu> lista = new List<C_Menu>();
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("select codigo_menu, nombre, codigopadre, \"Imagen\", formulario, habilitado from Vw_MenuCabezera where codigopadre = " + codigo + " and codigo_dni_usuario = " + codigoDni + " order by codigo_menu desc", cnn);
                cmd.CommandType = System.Data.CommandType.Text;
                NpgsqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        lista.Add(new C_Menu
                        {
                            CodigoMenu = rd.GetInt32(0),
                            Nombre = rd.GetString(1),
                            CodigoPadre = rd.GetInt32(2),
                            Image = (byte[])rd[3],
                            Formulario = rd.GetString(4),
                            Habilitado = rd.GetBoolean(5)
                        });
                    }
                }
            }
            catch (Exception )
            {
                throw new Exception("Error al mostrar" );
            }
            finally
            {
                cnn.Close();
            }
            return lista;
        }
        public List<C_Moneda> MonedaMostrar()
        {
            List<C_Moneda> lista = new List<C_Moneda>();
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("select codigo_moneda, nombre, simbolo from moneda", cnn);
                cmd.CommandType = System.Data.CommandType.Text;
                NpgsqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        lista.Add(new C_Moneda
                        {
                            Codigo = rd.GetInt32(0),
                            Nombre = rd.GetString(1),
                            Simbolo = rd.GetString(2),
                        });
                    }
                }
            }
            catch (Exception )
            {
                throw new Exception("Error al mostrar" );
            }
            finally
            {
                cnn.Close();
            }
            return lista;
        }
        public List<C_TipoAlmacen> TipoAlmacenMostrar()
        {
            List<C_TipoAlmacen> lista = new List<C_TipoAlmacen>();
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("select codigo_tipo_almacen, nombre from TIPO_ALMACEN where flag = 1", cnn);
                cmd.CommandType = System.Data.CommandType.Text;
                NpgsqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        lista.Add(new C_TipoAlmacen
                        {
                            Codigo = rd.GetInt32(0),
                            Nombre = rd.GetString(1)
                        });
                    }
                }
                cnn.Close();
            }
            catch (Exception )
            {
                throw new Exception("Error al mostrar" );
            }
            finally
            {
                cnn.Close();
            }
            return lista;
        }
        public List<C_TipoPago> TipoPagoMostrar()
        {
            List<C_TipoPago> lista = new List<C_TipoPago>();
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
               
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("select codigo_tipo_pago, nombre from tipo_pago where flag = 1", cnn);
                cmd.CommandType = System.Data.CommandType.Text;
                NpgsqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        lista.Add(new C_TipoPago
                        {
                            Codigo = rd.GetInt32(0),
                            Nombre = rd.GetString(1)
                        });
                    }
                }
            }
            catch (Exception )
            {
                throw new Exception("Error al mostrar" );
            }
            finally
            {
                cnn.Close();
            }
            return lista;
        }
        public List<C_TipoDocumento> TipoDocumentoMostrar()
        {
            List<C_TipoDocumento> lista = new List<C_TipoDocumento>();
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("select codigo_tipo_documento,nombre_documento from tipo_documento where flag = 1", cnn);
                cmd.CommandType = System.Data.CommandType.Text;
                NpgsqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        lista.Add(new C_TipoDocumento
                        {
                            Codigo = rd.GetInt32(0),
                            Nombre = rd.GetString(1)
                        });
                    }
                }
            }
            catch (Exception )
            {
                throw new Exception("Error al mostrar" );
            }
            finally
            {
                cnn.Close();
            }
            return lista;
        }
        public List<C_TipoLineaCredito> TipoLineaCreditoMostrar()
        {
            List<C_TipoLineaCredito> lista = new List<C_TipoLineaCredito>();
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("select codigo_tipos_linea_de_credito, nombre_completo, detalle from tipo_linea_de_credito where flag = 1", cnn);
                cmd.CommandType = System.Data.CommandType.Text;
                NpgsqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        lista.Add(new C_TipoLineaCredito
                        {
                            Codigo = rd.GetInt32(0),
                            NombreCompleto = rd.GetString(1),
                            Detalle = rd.GetString(2)
                        });
                    }
                }
            }
            catch (Exception )
            {
                throw new Exception("Error al mostrar" );
            }
            finally
            {
                cnn.Close();
            }
            return lista;
        }
        public List<C_TipoPrecio> TipoPrecioMostrar()
        {
            List<C_TipoPrecio> lista = new List<C_TipoPrecio>();
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT codigo_tipo_precio, nombre FROM TIPO_PRECIO where flag = 1;", cnn);
                cmd.CommandType = System.Data.CommandType.Text;
                NpgsqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        lista.Add(new C_TipoPrecio
                        {
                            Codigo = rd.GetInt32(0),
                            Nombre = rd.GetString(1)
                        });
                    }
                }
            }
            catch (Exception )
            {
                throw new Exception("Error al mostrar" );
            }
            finally
            {
                cnn.Close();
            }
            return lista;
        }
        public List<C_TipoTrabajador> TipoTrabajadorMostrar()
        {
            List<C_TipoTrabajador> lista = new List<C_TipoTrabajador>();
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT codigo_tipo_trabajador, puesto FROM TIPO_TRABAJADOR where flag = 1", cnn);
                cmd.CommandType = System.Data.CommandType.Text;
                NpgsqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        lista.Add(new C_TipoTrabajador
                        {
                            Codigo = rd.GetInt32(0),
                            Puesto = rd.GetString(1),
                        });
                    }
                }
            }
            catch (Exception )
            {
                throw new Exception("Error al mostrar" );
            }
            finally
            {
                cnn.Close();
            }
            return lista;
        }
        public List<C_Unidad> UnidadMostrar()
        {
            List<C_Unidad> lista = new List<C_Unidad>();
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("select codigo_unidad, nombre,simbolo from unidad where flag = 1", cnn);
                cmd.CommandType = CommandType.Text;
                NpgsqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        lista.Add(new C_Unidad
                        {
                            Codigo = rd.GetInt32(0),
                            Nombre = rd.GetString(1),
                            Simbolo = rd.GetString(2)
                        });
                    }
                }
            }
            catch (Exception )
            {
                throw new Exception("Error al mostrar" );
            }
            finally
            {
                cnn.Close();
            }
            return lista;
        }
        public List<C_Usuario> UsuarioMostrar()
        {
            List<C_Usuario> lista = new List<C_Usuario>();
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("select CODIGO_DNI_USUARIO, CODIGO_TIPO_TRABAJADOR, PASSWOR,E_MAIL, NOMBRE_USUARIO, APELLIDO_PATERNO, APELLIDO_MATERNO, FECHA_NACIMIENTO, LUGAR_NACIMIENTO, DIRECCION, FECHA_INICIO, TELEFONO from usuario where flag = 1", cnn);
                cmd.CommandType = CommandType.Text;
                NpgsqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        lista.Add(new C_Usuario
                        {
                            Dni = rd.GetInt32(0),
                            CodigoTipoTrabajador = rd.GetInt32(1),
                            Password = rd.GetString(2),
                            Email = rd.GetString(3),
                            Nombre = rd.GetString(4),
                            ApellidoPaterno = rd.GetString(5),
                            ApellidoMaterno = rd.GetString(6),
                            FechaNacimiento = rd.GetDateTime(7),
                            LugarNacimiento = rd.GetString(8),
                            Direccion = rd.GetString(9),
                            FechaInicio = rd.GetDateTime(10),
                            Telefono = rd.GetString(11)

                        });
                    }
                }
            }
            catch (Exception )
            {
                throw new Exception("Error al mostrar" );
            }
            finally
            {
                cnn.Close();
            }
            return lista;
        }
        public List<C_OrdenCompra> OrdenCompraMostrar()
        {
            List<C_OrdenCompra> lista = new List<C_OrdenCompra>();
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("select codigo_proveedor, ruc from proveedores where flag = 1;", cnn);
                cmd.CommandType = System.Data.CommandType.Text;
                NpgsqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        lista.Add(new C_OrdenCompra
                        {
                            CodigoProveedor = rd.GetInt32(0),
                            Ruc = rd.GetString(1)

                        });
                    }
                }
            }
            catch (Exception )
            {
                throw new Exception("Error al mostrar" );
            }
            finally
            {
                cnn.Close();
            }
            return lista;

        }
        public List<C_OrdenCompra> OrdenCompraDocumento()
        {
            List<C_OrdenCompra> lista = new List<C_OrdenCompra>();
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("select codigo_orden_de_compra, num_documento  from orden_de_compra where flag = 1;", cnn);
                cmd.CommandType = System.Data.CommandType.Text;
                NpgsqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        lista.Add(new C_OrdenCompra
                        {
                            Codigo = rd.GetInt32(0),
                            NumeroDocumento = rd.GetString(1)

                        });
                    }
                }
            }
            catch (Exception )
            {
                throw new Exception("Error al mostrar" );
            }
            finally
            {
                cnn.Close();
            }
            return lista;
        }
        public List<C_OrdenCompra> OrdenCompraMostrarNombreProducto()
        {
            List<C_OrdenCompra> lista = new List<C_OrdenCompra>();
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("select codigo_barras, nombre from productos where flag_disponible = 1;", cnn);
                cmd.CommandType = System.Data.CommandType.Text;
                NpgsqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        lista.Add(new C_OrdenCompra
                        {
                            CodigoBarras = rd.GetString(0),
                            Nombre = rd.GetString(1)

                        });
                    }
                }
            }
            catch (Exception )
            {
                throw new Exception("Error al mostrar" );
            }
            finally
            {
                cnn.Close();
            }
            return lista;

        }
        public List<C_CompraDetalle> CompraProducto(int codigo)
        {
            List<C_CompraDetalle> lista = new List<C_CompraDetalle>();
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("select codigo_Credito, codigo_barras,nombre,cantidad,costo_unitario,costo_total,codigo_unidad from vw_compra_producto where codigo_credito = " + codigo, cnn);
                cmd.CommandType = System.Data.CommandType.Text;
                NpgsqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        lista.Add(new C_CompraDetalle
                        {
                            Codigo_credito = rd.GetInt32(0),
                            CodigoBarras = rd.GetString(1),
                            Nombre = rd.GetString(2),
                            Cantidad = rd.GetDouble(3),
                            CostoUnitario = rd.GetDouble(4),
                            CostoTotal = rd.GetDouble(5),
                            Unidad = rd.GetInt32(6)
                        });
                    }
                }
            }
            catch (Exception )
            {
                throw new Exception("Error al mostrar" );
            }
            finally
            {
                cnn.Close();
            }
            return lista;
        }
        public List<C_OrdenCompraDetalle> OrdenCompraProducto(int codigo)
        {
            List<C_OrdenCompraDetalle> lista = new List<C_OrdenCompraDetalle>();
            C_OrdenCompraDetalle objOrden = new C_OrdenCompraDetalle();
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT CODIGO_ORDEN_dE_COMPRA, CODIGO_BARRAS, NOMBRE, CANTIDAD, CODIGO_UNIDAD,costo_unitario,costo_total FROM VW_ORDEN_DE_COMPRA_PRODUCTOS where codigo_orden_de_compra = " + codigo, cnn);
                cmd.CommandType = System.Data.CommandType.Text;
                NpgsqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        if (rd[5] == DBNull.Value)
                        {
                            objOrden.CostoUnitario = 0.0;
                        }
                        else
                        {
                            objOrden.CostoUnitario = double.Parse(rd.GetDecimal(5).ToString());
                        }
                        if (rd[6] == DBNull.Value)
                        {
                            objOrden.CostoTotal = 0.0;
                        }
                        else
                        {
                            objOrden.CostoTotal = double.Parse(rd.GetDecimal(6).ToString());
                        }
                        lista.Add(new C_OrdenCompraDetalle
                        {
                            CodigoOrdenCompra = rd.GetInt32(0),
                            CodigoBarras = rd.GetString(1),
                            Nombre = rd.GetString(2),
                            Cantidad = rd.GetString(3),
                            Unidad = rd.GetInt32(4),
                            CostoUnitario = objOrden.CostoUnitario,
                            CostoTotal = objOrden.CostoTotal

                        });
                    }
                }

            }
            catch (Exception )
            {
                throw new Exception("Error al mostrar" );
            }
            finally
            {
                cnn.Close();
            }
            return lista;
        }
        public List<C_Caja> CajaMostrar()
        {
            List<C_Caja> lista = new List<C_Caja>();
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("select codigo_nombre_caja, nombre from nombre_caja where flag = 1;", cnn);
                cmd.CommandType = CommandType.Text;
                NpgsqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        lista.Add(new C_Caja
                        {
                            CodigoCaja = rd.GetInt32(0),
                            NombreCaja = rd.GetString(1)


                        });
                    }
                }
            }
            catch (Exception )
            {
                throw new Exception("Error al mostrar" );
            }
            finally
            {
                cnn.Close();
            }
            return lista;
        }
        public List<C_Almacen_Producto> ProductoAlmacenMostar(int codigo, int codigoAlmacen)
        {
            List<C_Almacen_Producto> lista = new List<C_Almacen_Producto>();
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("select  codigo_almacen, almacen, codigo_barras, stock, producto from vw_productoalmacen where codigo_barras = '" + codigo + "' and codigo_almacen = " + codigoAlmacen, cnn);
                cmd.CommandType = System.Data.CommandType.Text;
                NpgsqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        lista.Add(new C_Almacen_Producto
                        {

                            CodigoAlmacen = rd.GetInt32(0),
                            NombreAlmacen = rd.GetString(1),
                            CodigoProducto = rd.GetString(2),
                            Cantidad = rd.GetDouble(3),

                        });
                    }
                }
            }
            catch (Exception )
            {
                throw new Exception("Error al mostrar" );
            }
            finally
            {
                cnn.Close();
            }
            return lista;
        }
        public List<C_UnidadEquivalencias> Unidadesequivalencias()
        {
            List<C_UnidadEquivalencias> lista = new List<C_UnidadEquivalencias>();
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("select nombre, simbolo ,cantidadpadre, cantidadhijo, simbolo_equivalencia from vw_unidades where flag = 1 ;", cnn);
                cmd.CommandType = System.Data.CommandType.Text;
                NpgsqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        lista.Add(new C_UnidadEquivalencias
                        {

                            Nombre = rd.GetString(0),
                            Simbolo1 = rd.GetString(1),
                            CantidadPadre = rd.GetDouble(3),
                            CantidadHijo = rd.GetDouble(2),
                            SimboloEquivalencia = rd.GetString(4)

                        });
                    }
                }
            }
            catch (Exception )
            {
                throw new Exception("Error al mostrar" );
            }
            finally
            {
                cnn.Close();
            }
            return lista;
        }
        public List<C_CodigoSerial> GarantiaCodigoVenta(string codigoVenta)
        {
            List<C_CodigoSerial> lista = new List<C_CodigoSerial>();
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("select codigo_serial, factura,garantia_tienda,nombre from vw_garantias where factura  = " + "'" + codigoVenta + "'", cnn);
                cmd.CommandType = System.Data.CommandType.Text;
                NpgsqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        lista.Add(new C_CodigoSerial
                        {

                            CodigoSerial = rd.GetString(0),
                            Factura1 = rd.GetString(1),
                            Garantia = rd.GetString(2),
                            Proveedor1 = rd.GetString(3)

                        });
                    }
                }
            }
            catch (Exception )
            {
                throw new Exception("Error al mostrar" );
            }
            finally
            {
                cnn.Close();
            }
            return lista;
        }


        //MOSTRAR LISTAS POR CODIGO

        public C_Almacen AlmacenMostrar1(int codigo) 
        {
            C_Almacen lista = new C_Almacen();
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("select codigo_almacen, codigo_tipo_almacen, nombre from almacen where flag = 1 and codigo_almacen = " + codigo, cnn);
                cmd.CommandType = System.Data.CommandType.Text;
                NpgsqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        lista.Codigo = rd.GetInt32(0);
                        lista.CodigoTipoAlmacen = rd.GetInt32(1);
                        lista.Nombre = rd.GetString(2);
                        
                    }
                }
            }
            catch (Exception )
            {
                throw new Exception("Error al mostrar" );
            }
            finally
            {
                cnn.Close();
            }
            return lista;
        }
        public C_Almacen AlmacenMostrarCaja(int codigo)
        {
            C_Almacen lista = new C_Almacen();
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("select codigo_nombre_caja, codigo_almacen, nombre from vw_nombrecajaalmacen  where codigo_nombre_caja = " + codigo, cnn);
                cmd.CommandType = System.Data.CommandType.Text;
                NpgsqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        lista.Codigo = rd.GetInt32(0);
                        lista.CodigoTipoAlmacen = rd.GetInt32(1);
                        lista.Nombre = rd.GetString(2);

                    }
                }
            }
            catch (Exception )
            {
                throw new Exception("Error al mostrar" );
            }
            finally
            {
                cnn.Close();
            }
            return lista;
        }
        public C_Categoria CategoriaMostrar1(int codigo)
        {
            C_Categoria lista = new C_Categoria();
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("select codigo_categoria, nombre from categoria where flag = 1 and codigo_categoria = " + codigo, cnn);
                cmd.CommandType = System.Data.CommandType.Text;
                NpgsqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        lista.Codigo = rd.GetInt32(0);
                        lista.Nombre = rd.GetString(1);
                    }
                }
            }
            catch (Exception )
            {
                throw new Exception("Error al mostrar" );
            }
            finally
            {
                cnn.Close();
            }
            return lista;
        }        
        public C_Compra DocumentoPorFecha1(int codigo)
        {
            C_Compra lista = new C_Compra();
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT codigo_credito, codigo_proveedor, codigo_tipo_documento, codigo_moneda, fecha_compra, monto_total_compra, numero_documento, VALOR FROM VW_COMPRA_MOSTRAR WHERE CODIGO_CREDITO =" + codigo, cnn);
                cmd.CommandType = System.Data.CommandType.Text;
                NpgsqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {


                        lista.Codigo = rd.GetInt32(0);
                        lista.CodigoProveedor = rd.GetInt32(1);
                        lista.CodigoTipoDocumento = rd.GetInt32(2);
                        lista.CodigoMoneda = rd.GetInt32(3);
                        lista.FechaCompra = rd.GetDateTime(4);
                        lista.MontoTotal = rd.GetDouble(5);
                        lista.NumeroDocumento = rd.GetString(6);
                        lista.ValorTipoCambio = rd.GetDouble(7);
                    }
                }
            }
            catch (Exception )
            {
                throw new Exception("Error al mostrar" );
            }
            finally
            {
                cnn.Close();
            }
            return lista;
        }
        public C_OrdenCompra OrdenDocumentoPorFecha1(int codigo)
        {
            C_OrdenCompra lista = new C_OrdenCompra();
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("select codigo_orden_de_compra, referencia_orden_compra, num_documento,codigo_proveedor from orden_de_compra where codigo_orden_de_compra = " + codigo, cnn);
                cmd.CommandType = System.Data.CommandType.Text;
                NpgsqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        lista.Codigo = rd.GetInt32(0);
                        lista.ReferenciaOrdenCompra = rd.GetString(1);
                        lista.NumeroDocumento = rd.GetString(2);
                        lista.CodigoProveedor = rd.GetInt32(3);
                    }
                }
            }
            catch (Exception )
            {
                throw new Exception("Error al mostrar" );
            }
            finally
            {
                cnn.Close();
            }
            return lista;
        }
        public C_Familia FamiliaMostrar1(int codigo)
        {
            C_Familia lista = new C_Familia();
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("select codigo_familia, nombre from familia where flag = 1 and codigo_familia = " + codigo, cnn);
                cmd.CommandType = System.Data.CommandType.Text;
                NpgsqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        lista.Codigo = rd.GetInt32(0);
                        lista.Nombre = rd.GetString(1);
                    }
                }
            }
            catch (Exception )
            {
                throw new Exception("Error al mostrar" );
            }
            finally
            {
                cnn.Close();
            }
            return lista;
        }
        public C_Marca MarcaMostrar1(int codigo)
        {
            C_Marca lista = new C_Marca();
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("select codigo_marca, nombre from marca where flag = 1 and codigo_marca = " + codigo, cnn);
                cmd.CommandType = System.Data.CommandType.Text;
                NpgsqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        lista.Codigo = rd.GetInt32(0);
                        lista.Nombre = rd.GetString(1);
                    }
                }
            }
            catch (Exception )
            {
                throw new Exception("Error al mostrar" );
            }
            finally
            {
                cnn.Close();
            }
            return lista;
        }
        public C_NombreCaja NombreCajaMostrar1(int codigo)
        {
            C_NombreCaja lista = new C_NombreCaja();
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("select codigo_nombre_caja, nombre from nombre_caja where flag = 1 and codigo_nombre_caja = " + codigo, cnn);
                cmd.CommandType = System.Data.CommandType.Text;
                NpgsqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        lista.Codigo = rd.GetInt32(0);
                        lista.Nombre = rd.GetString(1);
                    }
                }
            }
            catch (Exception )
            {
                throw new Exception("Error al mostrar" );
            }
            finally
            {
                cnn.Close();
            }
            return lista;
        }
        public C_Cliente ClienteMostrar1(int codigo)
        {
            C_Cliente lista = new C_Cliente();
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("select dni, nombre, apellido_paterno, apellido_materno from cliente where flag = 1 and codigo_cliente = " + codigo + ";", cnn);
                cmd.CommandType = System.Data.CommandType.Text;
                NpgsqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        //lista.Codigo = rd.GetInt32(0);
                        lista.Dni = rd.GetString(0);
                        lista.Nombre = rd.GetString(1);
                        lista.Apellido_paterno = rd.GetString(2);
                        lista.Apellido_materno = rd.GetString(3);
                    }
                }
                cnn.Close();
            }
            catch (Exception )
            {
                throw new Exception("Error al mostrar" );
            }
            finally
            {
                cnn.Close();
            }
            return lista;

        }
        public C_Empresa EmpresaMostrar1(int codigo)
        {
            C_Empresa lista = new C_Empresa();
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("select codigo_empresa, ruc, nombre, direccion, telefono from empresa where flag = 1 and codigo_empresa =" + codigo, cnn);
                cmd.CommandType = System.Data.CommandType.Text;
                NpgsqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        lista.Codigo = rd.GetInt32(0);
                        lista.Ruc = rd.GetString(1);
                        lista.Nombre = rd.GetString(2);
                        lista.Direccion = rd.GetString(3);
                        lista.Telefono = rd.GetString(4);
                    }
                }
            }
            catch (Exception )
            {
                throw new Exception("Error al mostrar" );
            }
            finally
            {
                cnn.Close();
            }
            return lista;
        }
        public C_Producto ProductoMostrar1(string codigo)
        {
            C_Producto lista = new C_Producto();
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("select codigo_barras, codigo_marca, codigo_familia, codigo_categoria, codigo_unidad, tiempo_garantia, nombre from productos where flag_disponible = 1 and codigo_barras = '" + codigo +"'", cnn);
                cmd.CommandType = System.Data.CommandType.Text;
                NpgsqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        lista.CodigoBarras = rd.GetString(0);
                        lista.CodigoMarca = rd.GetInt32(1);
                        lista.CodigoFamilia = rd.GetInt32(2);
                        lista.CodigoCategoria = rd.GetInt32(3);
                        lista.CodigoUnidad = rd.GetInt32(4);
                        lista.TiempoGarantia = rd.GetString(5);
                        lista.Nombre = rd.GetString(6);
                    }
                }
            }
            catch (Exception ex )
            {
                throw new Exception("Error al mostrar un producto " );
            }
            finally
            {
                cnn.Close();
            }
            return lista;
        }
        public C_Proveedor ProveedorMostrar1(int codigo)
        {
            C_Proveedor lista = new C_Proveedor();
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("select codigo_proveedor, codigo_tipos_linea_de_credito, ruc, monto_maximo_prestamo, cuenta_ahorros_soles, cuenta_ahorros_dolares, pagina_web, telefono, direccion, nombre from proveedores where flag = 1 and codigo_proveedor = " + codigo, cnn);
                cmd.CommandType = System.Data.CommandType.Text;
                NpgsqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        lista.Codigo = rd.GetInt32(0);
                        lista.CodigoTipoLineaCredito = rd.GetInt32(1);
                        lista.RUC = rd.GetString(2);
                        lista.MontoPrestamo = rd.GetDouble(3);
                        lista.CuentasSoles = rd.GetString(4);
                        lista.CuentaDolares = rd.GetString(5);
                        lista.PaginaWeb = rd.GetString(6);
                        lista.Telefono = rd.GetInt32(7);
                        lista.Direccion = rd.GetString(8);
                        lista.Nombre = rd.GetString(9);
                    }
                }
            }
            catch (Exception )
            {
                throw new Exception("Error al mostrar" );
            }
            finally
            {
                cnn.Close();
            }
            return lista;
        }
        public C_Menu MenuMostrar1(int codigo)
        {
            C_Menu objetoMenu = new C_Menu();
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("select codigo_menu, nombre, codigopadre, \"Imagen\", formulario from Vw_MenuCabezera where codigo_menu = " + codigo + " order by codigo_menu desc", cnn);
                cmd.CommandType = System.Data.CommandType.Text;
                NpgsqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        objetoMenu.CodigoMenu = rd.GetInt32(0);
                        objetoMenu.Nombre = rd.GetString(1);
                        objetoMenu.CodigoPadre = rd.GetInt32(2);
                        objetoMenu.Image = (byte[])rd[3];
                        objetoMenu.Formulario = rd.GetString(4);
                    }
                }
            }
            catch (Exception )
            {
                throw new Exception("Error al mostrar" );
            }
            finally
            {
                cnn.Close();
            }
            return objetoMenu;
        }
        public C_TipoAlmacen TipoAlmacenMostrar1(int codigo)
        {
            C_TipoAlmacen lista = new C_TipoAlmacen();
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("select codigo_tipo_almacen, nombre from tipo_almacen where flag = 1 and codigo_tipo_almacen = " + codigo, cnn);
                cmd.CommandType = System.Data.CommandType.Text;
                NpgsqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        lista.Codigo = rd.GetInt32(0);
                        lista.Nombre = rd.GetString(1);
                    }
                }
            }
            catch (Exception )
            {
                throw new Exception("Error al mostrar" );
            }
            finally
            {
                cnn.Close();
            }
            return lista;
        }
        public C_TipoPago TipoPagoMostrar1(int codigo)
        {
            C_TipoPago lista = new C_TipoPago();
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("select codigo_tipo_pago,nombre from tipo_pago where flag = 1 and codigo_tipo_pago = " + codigo, cnn);
                cmd.CommandType = System.Data.CommandType.Text;
                NpgsqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        lista.Codigo = rd.GetInt32(0);
                        lista.Nombre = rd.GetString(1);
                    }
                }
            }
            catch (Exception )
            {
                throw new Exception("Error al mostrar" );
            }
            finally
            {
                cnn.Close();
            }
            return lista;
        }
        public C_TipoDocumento TipoDocumentoMostrar1(int codigo)
        {
            C_TipoDocumento lista = new C_TipoDocumento();
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("select codigo_tipo_documento, nombre_documento from tipo_documento where flag = 1 and codigo_tipo_documento = " + codigo, cnn);
                cmd.CommandType = System.Data.CommandType.Text;
                NpgsqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        lista.Codigo = rd.GetInt32(0);
                        lista.Nombre = rd.GetString(1);
                    }
                }
            }
            catch (Exception )
            {
                throw new Exception("Error al mostrar" );
            }
            finally
            {
                cnn.Close();
            }
            return lista;
        }
        public C_TipoLineaCredito TipoLineaCreditoMostrar1(int codigo)
        {
            C_TipoLineaCredito lista = new C_TipoLineaCredito();
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("select codigo_tipos_linea_de_credito, nombre from tipo_linea_de_credito where flag = 1 and codigo_tipos_linea_de_credito = " + codigo, cnn);
                cmd.CommandType = System.Data.CommandType.Text;
                NpgsqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        lista.Codigo = rd.GetInt32(0);
                        lista.Nombre = rd.GetString(1);
                    }
                }
            }
            catch (Exception )
            {
                throw new Exception("Error al mostrar" );
            }
            finally
            {
                cnn.Close();
            }
            return lista;
        }
        public C_TipoTrabajador TipoTrabajadorMostrar1(int codigo)
        {
            C_TipoTrabajador lista = new C_TipoTrabajador();
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("select codigo_tipo_trabajador, puesto from tipo_trabajador where flag = 1 and codigo_tipo_trabajador = " + codigo, cnn);
                cmd.CommandType = System.Data.CommandType.Text;
                NpgsqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        lista.Codigo = rd.GetInt32(0);
                        lista.Puesto = rd.GetString(1);
                    }
                }
            }
            catch (Exception )
            {
                throw new Exception("Error al mostrar" );
            }
            finally
            {
                cnn.Close();
            }
            return lista;
        }
        public C_Unidad UnidadMostrar1(int codigo)
        {
            C_Unidad lista = new C_Unidad();
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("select codigo_unidad, nombre,simbolo from unidad where flag = 1 and codigo_unidad = " + codigo, cnn);
                cmd.CommandType = System.Data.CommandType.Text;
                NpgsqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        lista.Codigo = rd.GetInt32(0);
                        lista.Nombre = rd.GetString(1);
                        lista.Simbolo = rd.GetString(2);
                    }
                }
            }
            catch (Exception )
            {
                throw new Exception("Error al mostrar" );
            }
            finally
            {
                cnn.Close();
            }
            return lista;
        }
        public C_Usuario UsuarioMostrar1(int codigo)
        {
            C_Usuario lista = new C_Usuario();
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("select CODIGO_DNI_USUARIO, CODIGO_TIPO_TRABAJADOR, PASSWOR,E_MAIL, NOMBRE_USUARIO, APELLIDO_PATERNO, APELLIDO_MATERNO, FECHA_NACIMIENTO, LUGAR_NACIMIENTO, DIRECCION, FECHA_INICIO, TELEFONO , compañia from usuario where flag = 1 and CODIGO_DNI_USUARIO = " + codigo, cnn);
                cmd.CommandType = System.Data.CommandType.Text;
                NpgsqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        lista.Dni = rd.GetInt32(0);
                        lista.CodigoTipoTrabajador = rd.GetInt32(1);
                        lista.Password = rd.GetString(2);
                        lista.Email = rd.GetString(3);
                        lista.Nombre = rd.GetString(4);
                        lista.ApellidoPaterno = rd.GetString(5);
                        lista.ApellidoMaterno = rd.GetString(6);
                        lista.FechaNacimiento = rd.GetDateTime(7);
                        lista.LugarNacimiento = rd.GetString(8);
                        lista.Direccion = rd.GetString(9);
                        lista.FechaInicio = rd.GetDateTime(10);
                        lista.Telefono = rd.GetString(11);
                        lista.Compañia = rd.GetInt32(12);
                    }
                }
            }
            catch (Exception )
            {
                throw new Exception("Error al mostrar" );
            }
            finally
            {
                cnn.Close();
            }
            return lista;
        }
        public C_OrdenCompra OrdenCompraDocumento1(int codigo)
        {
            C_OrdenCompra lista = new C_OrdenCompra();
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("select codigo_orden_de_compra, num_documento, codigo_proveedor, referencia_orden_compra  from orden_de_compra where flag = 1 and codigo_orden_de_compra = " + codigo, cnn);
                cmd.CommandType = System.Data.CommandType.Text;
                NpgsqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        lista.Codigo = rd.GetInt32(0);
                        lista.NumeroDocumento = rd.GetString(1);
                        lista.CodigoProveedor = rd.GetInt32(2);
                        lista.ReferenciaOrdenCompra = rd.GetString(3);
                    }
                }
            }
            catch (Exception )
            {
                throw new Exception("Error al mostrar" );
            }
            finally
            {
                cnn.Close();
            }
            return lista;
        }
        public C_OrdenCompra OrdenCompraMostrar1(int codigo)
        {
            C_OrdenCompra lista = new C_OrdenCompra();
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("select codigo_proveedor, ruc, nombre from proveedores where flag = 1 and codigo_proveedor = " + codigo, cnn);
                cmd.CommandType = System.Data.CommandType.Text;
                NpgsqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        lista.CodigoProveedor = rd.GetInt32(0);
                        lista.Ruc = rd.GetString(1);
                        lista.Nombre = rd.GetString(2);

                    }
                }
            }
            catch (Exception )
            {
                throw new Exception("Error al mostrar" );
            }
            finally
            {
                cnn.Close();
            }
            return lista;

        }
        public C_Producto MostrarUnidadProducto(string codigoBarras)
        {
            C_Producto lista = new C_Producto();
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("select codigo_barras, nombre from vw_unidadproductos where codigo_barras = '" + codigoBarras+"'", cnn);
                cmd.CommandType = System.Data.CommandType.Text;
                NpgsqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        lista.CodigoBarras = rd.GetString(0);
                        lista.NombreUnidad = rd.GetString(1);
                    }
                }
            }
            catch (Exception )
            {
                throw new Exception("Error al mostrar" );
            }
            finally
            {
                cnn.Close();
            }
            return lista;
        }
        public List<C_CodigoSerial> GarantiaCodigoSerial(string codigoSerial)
        {
            List<C_CodigoSerial> lista = new List<C_CodigoSerial>();
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("select codigo_serial, factura,garantia_tienda,nombre from vw_garantias where codigo_serial  = " + "'" + codigoSerial + "'", cnn);
                cmd.CommandType = System.Data.CommandType.Text;
                NpgsqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        lista.Add(new C_CodigoSerial
                        {

                            CodigoSerial = rd.GetString(0),
                            Factura1 = rd.GetString(1),
                            Garantia = rd.GetString(2),
                            Proveedor1 = rd.GetString(3)

                        });
                    }
                }

            }
            catch (Exception )
            {
                throw new Exception("Error al mostrar" );
            }
            finally
            {
                cnn.Close();
            }
            return lista;
        }
        public C_TrabajadorProveedor TrabajadorProveedorMostrar1(int codigo)
        {
            C_TrabajadorProveedor lista = new C_TrabajadorProveedor();
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT codigo_trabajadores_proveedor, nombre,apellido_paterno,apellido_materno,celular from trabajadores_proveedor where codigo_trabajadores_proveedor = " + codigo + " and  flag = 1 ;", cnn);
                cmd.CommandType = System.Data.CommandType.Text;
                NpgsqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        lista.CodigoTrabajadorProveedor = rd.GetInt32(0);
                        lista.Nombre = rd.GetString(1);
                        lista.ApellidoPaterno = rd.GetString(2);
                        lista.ApellidoMaterno = rd.GetString(3);
                        lista.Celular = rd.GetString(4);
                    }
                }
                cnn.Close();
            }
            catch (Exception )
            {
                throw new Exception("Error al mostrar" );
            }
            finally
            {
                cnn.Close();
            }
            return lista;

        }





        //CARGAR REPORTES
        public List<C_Compra> ReporteCompraTodo()
        {
            List<C_Compra> lista = new List<C_Compra>();
            C_Compra objetoCompra = new C_Compra();
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT NOMBRE,VALOR,NOMBRE_DOCUMENTO, MONEDA, FECHA_COMPRA,MONTO_TOTAL_COMPRA, NUMERO_DOCUMENTO FROM VW_REPORTECOMPRA ORDER BY FECHA_COMPRA DESC;", cnn);
                cmd.CommandType = System.Data.CommandType.Text;
                NpgsqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        //NOMBRE PROVEEDOR
                        if (rd[0] == DBNull.Value)
                        {
                            objetoCompra.NombreProveedor = " ";
                        }
                        else
                        {
                            objetoCompra.NombreProveedor = rd.GetString(0);
                        }
                        //VALOR DEL TIPO DE CAMBIO
                        if (rd[1] == DBNull.Value)
                        {
                            objetoCompra.ValorTipoCambio = 0.0;
                        }
                        else
                        {
                            objetoCompra.ValorTipoCambio = rd.GetDouble(1);
                        }
                        //NOMBRE DOCUMENTO EJEMPLO BOLETA,ETC
                        if (rd[2] == DBNull.Value)
                        {
                            objetoCompra.NombreDocumento = " ";
                        }
                        else
                        {
                            objetoCompra.NombreDocumento = rd.GetString(2);
                        }
                        //MONEDA
                        if (rd[3] == DBNull.Value)
                        {
                            objetoCompra.NombreMoneda = " ";
                        }
                        else
                        {
                            objetoCompra.NombreMoneda = rd.GetString(3);
                        }
                        //FECHA
                        if (rd[4] == DBNull.Value)
                        {
                            objetoCompra.FechaCompra = DateTime.Now;
                        }
                        else
                        {
                            objetoCompra.FechaCompra = rd.GetDateTime(4);
                        }
                        //MONTO TOTAL
                        if (rd[5] == DBNull.Value)
                        {
                            objetoCompra.MontoTotal = 0.0;
                        }
                        else
                        {
                            objetoCompra.MontoTotal = rd.GetDouble(5);
                        }
                        //NUMERO DOCUMENTO
                        if (rd[6] == DBNull.Value)
                        {
                            objetoCompra.NumeroDocumento = " ";
                        }
                        else
                        {
                            objetoCompra.NumeroDocumento = rd.GetString(6);
                        }

                        lista.Add(new C_Compra
                        {
                            NombreProveedor = objetoCompra.NombreProveedor,
                            ValorTipoCambio = objetoCompra.ValorTipoCambio,
                            NombreDocumento = objetoCompra.NombreDocumento,
                            NombreMoneda = objetoCompra.NombreMoneda,
                            FechaCompra = objetoCompra.FechaCompra,
                            MontoTotal = objetoCompra.MontoTotal,
                            NumeroDocumento = objetoCompra.NumeroDocumento

                        });
                    }
                }
            }
            catch (Exception )
            {
                throw new Exception("Error al mostrar" );
            }
            finally
            {
                cnn.Close();
            }
            return lista;
        }
        public List<C_Compra> ReporteCompraPorProveedor(int codigo)
        {
            List<C_Compra> lista = new List<C_Compra>();
            C_Compra objetoCompra = new C_Compra();
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT NOMBRE,VALOR,NOMBRE_DOCUMENTO, MONEDA, FECHA_COMPRA,MONTO_TOTAL_COMPRA, NUMERO_DOCUMENTO FROM VW_REPORTECOMPRA WHERE CODIGO_PROVEEDOR = '" + codigo + "'  ORDER BY FECHA_COMPRA DESC;", cnn);
                cmd.CommandType = System.Data.CommandType.Text;
                NpgsqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        //NOMBRE PROVEEDOR
                        if (rd[0] == DBNull.Value)
                        {
                            objetoCompra.NombreProveedor = " ";
                        }
                        else
                        {
                            objetoCompra.NombreProveedor = rd.GetString(0);
                        }
                        //VALOR DEL TIPO DE CAMBIO
                        if (rd[1] == DBNull.Value)
                        {
                            objetoCompra.ValorTipoCambio = 0.0;
                        }
                        else
                        {
                            objetoCompra.ValorTipoCambio = rd.GetDouble(1);
                        }
                        //NOMBRE DOCUMENTO EJEMPLO BOLETA,ETC
                        if (rd[2] == DBNull.Value)
                        {
                            objetoCompra.NombreDocumento = " ";
                        }
                        else
                        {
                            objetoCompra.NombreDocumento = rd.GetString(2);
                        }
                        //MONEDA
                        if (rd[3] == DBNull.Value)
                        {
                            objetoCompra.NombreMoneda = " ";
                        }
                        else
                        {
                            objetoCompra.NombreMoneda = rd.GetString(3);
                        }
                        //FECHA
                        if (rd[4] == DBNull.Value)
                        {
                            objetoCompra.FechaCompra = DateTime.Now;
                        }
                        else
                        {
                            objetoCompra.FechaCompra = rd.GetDateTime(4);
                        }
                        //MONTO TOTAL
                        if (rd[5] == DBNull.Value)
                        {
                            objetoCompra.MontoTotal = 0.0;
                        }
                        else
                        {
                            objetoCompra.MontoTotal = rd.GetDouble(5);
                        }
                        //NUMERO DOCUMENTO
                        if (rd[6] == DBNull.Value)
                        {
                            objetoCompra.NumeroDocumento = " ";
                        }
                        else
                        {
                            objetoCompra.NumeroDocumento = rd.GetString(6);
                        }

                        lista.Add(new C_Compra
                        {
                            NombreProveedor = objetoCompra.NombreProveedor,
                            ValorTipoCambio = objetoCompra.ValorTipoCambio,
                            NombreDocumento = objetoCompra.NombreDocumento,
                            NombreMoneda = objetoCompra.NombreMoneda,
                            FechaCompra = objetoCompra.FechaCompra,
                            MontoTotal = objetoCompra.MontoTotal,
                            NumeroDocumento = objetoCompra.NumeroDocumento

                        });
                    }
                }
            }
            catch (Exception )
            {
                throw new Exception("Error al mostrar" );
            }
            finally
            {
                cnn.Close();
            }
            return lista;
        }
        public List<C_Compra> ReporteCompraPorFechas(DateTime fecha1, DateTime fecha2)
        {
            List<C_Compra> lista = new List<C_Compra>();
            C_Compra objetoCompra = new C_Compra();
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT NOMBRE,VALOR,NOMBRE_DOCUMENTO, MONEDA, FECHA_COMPRA,MONTO_TOTAL_COMPRA, NUMERO_DOCUMENTO FROM VW_REPORTECOMPRA WHERE FECHA_COMPRA BETWEEN '" + fecha1.ToShortDateString() + "' AND '" + fecha2.ToShortDateString() + "' ORDER BY FECHA_COMPRA DESC;", cnn);
                cmd.CommandType = System.Data.CommandType.Text;
                NpgsqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        //NOMBRE PROVEEDOR
                        if (rd[0] == DBNull.Value)
                        {
                            objetoCompra.NombreProveedor = " ";
                        }
                        else
                        {
                            objetoCompra.NombreProveedor = rd.GetString(0);
                        }
                        //VALOR DEL TIPO DE CAMBIO
                        if (rd[1] == DBNull.Value)
                        {
                            objetoCompra.ValorTipoCambio = 0.0;
                        }
                        else
                        {
                            objetoCompra.ValorTipoCambio = rd.GetDouble(1);
                        }
                        //NOMBRE DOCUMENTO EJEMPLO BOLETA,ETC
                        if (rd[2] == DBNull.Value)
                        {
                            objetoCompra.NombreDocumento = " ";
                        }
                        else
                        {
                            objetoCompra.NombreDocumento = rd.GetString(2);
                        }
                        //MONEDA
                        if (rd[3] == DBNull.Value)
                        {
                            objetoCompra.NombreMoneda = " ";
                        }
                        else
                        {
                            objetoCompra.NombreMoneda = rd.GetString(3);
                        }
                        //FECHA
                        if (rd[4] == DBNull.Value)
                        {
                            objetoCompra.FechaCompra = DateTime.Now;
                        }
                        else
                        {
                            objetoCompra.FechaCompra = rd.GetDateTime(4);
                        }
                        //MONTO TOTAL
                        if (rd[5] == DBNull.Value)
                        {
                            objetoCompra.MontoTotal = 0.0;
                        }
                        else
                        {
                            objetoCompra.MontoTotal = rd.GetDouble(5);
                        }
                        //NUMERO DOCUMENTO
                        if (rd[6] == DBNull.Value)
                        {
                            objetoCompra.NumeroDocumento = " ";
                        }
                        else
                        {
                            objetoCompra.NumeroDocumento = rd.GetString(6);
                        }

                        lista.Add(new C_Compra
                        {
                            NombreProveedor = objetoCompra.NombreProveedor,
                            ValorTipoCambio = objetoCompra.ValorTipoCambio,
                            NombreDocumento = objetoCompra.NombreDocumento,
                            NombreMoneda = objetoCompra.NombreMoneda,
                            FechaCompra = objetoCompra.FechaCompra,
                            MontoTotal = objetoCompra.MontoTotal,
                            NumeroDocumento = objetoCompra.NumeroDocumento

                        });
                    }
                }
            }
            catch (Exception )
            {
                throw new Exception("Error al mostrar" );
            }
            finally
            {
                cnn.Close();
            }
            return lista;
        }

        public List<C_Caja> ReporteCajaTodo()
        {
            List<C_Caja> lista = new List<C_Caja>();
            C_Caja objetoCaja = new C_Caja();
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT NOMBRE,NOMBRE_COMPLETO,VALOR,FECHA_INICIO_CAJA,FECHA_FINAL_CAJA,SALDO_INICIAL,SALDO_FINAL FROM VW_REPORTECAJA ORDER BY FECHA_INICIO_CAJA DESC;", cnn);
                cmd.CommandType = System.Data.CommandType.Text;
                NpgsqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        //NOMBRE CAJA
                        if (rd[0] == DBNull.Value)
                        {
                            objetoCaja.NombreCaja = " ";
                        }
                        else
                        {
                            objetoCaja.NombreCaja = rd.GetString(0);
                        }
                        //NOMBRE COMPLETO
                        if (rd[1] == DBNull.Value)
                        {
                            objetoCaja.NombreCompleto = " ";
                        }
                        else
                        {
                            objetoCaja.NombreCompleto = rd.GetString(1);
                        }
                        //VALOR TIPO CAMBIO
                        if (rd[2] == DBNull.Value)
                        {
                            objetoCaja.ValorTipoCambio = 0.0;
                        }
                        else
                        {
                            objetoCaja.ValorTipoCambio = rd.GetDouble(2);
                        }
                        //FECHA INICIO
                        if (rd[3] == DBNull.Value)
                        {
                            objetoCaja.FechaInicioCaja = DateTime.Now;
                        }
                        else
                        {
                            objetoCaja.FechaInicioCaja = rd.GetDateTime(3);
                        }
                        //FECHA CIERRE
                        if (rd[4] == DBNull.Value)
                        {
                            objetoCaja.FechaFinalCaja = DateTime.Now;
                        }
                        else
                        {
                            objetoCaja.FechaFinalCaja = rd.GetDateTime(4);
                        }
                        //SALDO INICIAL
                        if (rd[5] == DBNull.Value)
                        {
                            objetoCaja.SaldoInicial = 0.0;
                        }
                        else
                        {
                            objetoCaja.SaldoInicial = rd.GetDouble(5);
                        }
                        //SALDO FINAL
                        if (rd[6] == DBNull.Value)
                        {
                            objetoCaja.SaldoFinal = 0.0;
                        }
                        else
                        {
                            objetoCaja.SaldoFinal = rd.GetDouble(6);
                        }

                        lista.Add(new C_Caja
                        {
                            NombreCaja = objetoCaja.NombreCaja,
                            NombreCompleto = objetoCaja.NombreCompleto,
                            ValorTipoCambio = objetoCaja.ValorTipoCambio,
                            FechaInicioCaja = objetoCaja.FechaInicioCaja,
                            FechaFinalCaja = objetoCaja.FechaFinalCaja,
                            SaldoInicial = objetoCaja.SaldoInicial,
                            SaldoFinal = objetoCaja.SaldoFinal

                        });
                    }
                }
            }
            catch (Exception )
            {
                throw new Exception("Error al mostrar" );
            }
            finally
            {
                cnn.Close();
            }
            return lista;
        }
        public List<C_Caja> ReporteCajaPorTrabajador(int codigo)
        {
            List<C_Caja> lista = new List<C_Caja>();
            C_Caja objetoCaja = new C_Caja();
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT NOMBRE,NOMBRE_COMPLETO,VALOR,FECHA_INICIO_CAJA,FECHA_FINAL_CAJA,SALDO_INICIAL,SALDO_FINAL FROM VW_REPORTECAJA WHERE CODIGO_DNI_USUARIO = " + codigo + " ORDER BY FECHA_INICIO_CAJA DESC;", cnn);
                cmd.CommandType = System.Data.CommandType.Text;
                NpgsqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        //NOMBRE CAJA
                        if (rd[0] == DBNull.Value)
                        {
                            objetoCaja.NombreCaja = " ";
                        }
                        else
                        {
                            objetoCaja.NombreCaja = rd.GetString(0);
                        }
                        //NOMBRE COMPLETO
                        if (rd[1] == DBNull.Value)
                        {
                            objetoCaja.NombreCompleto = " ";
                        }
                        else
                        {
                            objetoCaja.NombreCompleto = rd.GetString(1);
                        }
                        //VALOR TIPO CAMBIO
                        if (rd[2] == DBNull.Value)
                        {
                            objetoCaja.ValorTipoCambio = 0.0;
                        }
                        else
                        {
                            objetoCaja.ValorTipoCambio = rd.GetDouble(2);
                        }
                        //FECHA INICIO
                        if (rd[3] == DBNull.Value)
                        {
                            objetoCaja.FechaInicioCaja = DateTime.Now;
                        }
                        else
                        {
                            objetoCaja.FechaInicioCaja = rd.GetDateTime(3);
                        }
                        //FECHA CIERRE
                        if (rd[4] == DBNull.Value)
                        {
                            objetoCaja.FechaFinalCaja = DateTime.Now;
                        }
                        else
                        {
                            objetoCaja.FechaFinalCaja = rd.GetDateTime(4);
                        }
                        //SALDO INICIAL
                        if (rd[5] == DBNull.Value)
                        {
                            objetoCaja.SaldoInicial = 0.0;
                        }
                        else
                        {
                            objetoCaja.SaldoInicial = rd.GetDouble(5);
                        }
                        //SALDO FINAL
                        if (rd[6] == DBNull.Value)
                        {
                            objetoCaja.SaldoFinal = 0.0;
                        }
                        else
                        {
                            objetoCaja.SaldoFinal = rd.GetDouble(6);
                        }

                        lista.Add(new C_Caja
                        {
                            NombreCaja = objetoCaja.NombreCaja,
                            NombreCompleto = objetoCaja.NombreCompleto,
                            ValorTipoCambio = objetoCaja.ValorTipoCambio,
                            FechaInicioCaja = objetoCaja.FechaInicioCaja,
                            FechaFinalCaja = objetoCaja.FechaFinalCaja,
                            SaldoInicial = objetoCaja.SaldoInicial,
                            SaldoFinal = objetoCaja.SaldoFinal

                        });
                    }
                }
            }
            catch (Exception )
            {
                throw new Exception("Error al mostrar" );
            }
            finally
            {
                cnn.Close();
            }
            return lista;
        }
        public List<C_Caja> ReporteCajaPorNombreCaja(int codigo)
        {
            List<C_Caja> lista = new List<C_Caja>();
            C_Caja objetoCaja = new C_Caja();
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT NOMBRE,NOMBRE_COMPLETO,VALOR,FECHA_INICIO_CAJA,FECHA_FINAL_CAJA,SALDO_INICIAL,SALDO_FINAL FROM VW_REPORTECAJA WHERE CODIGO_NOMBRE_CAJA = " + codigo + " ORDER BY FECHA_INICIO_CAJA DESC;", cnn);
                cmd.CommandType = System.Data.CommandType.Text;
                NpgsqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        //NOMBRE CAJA
                        if (rd[0] == DBNull.Value)
                        {
                            objetoCaja.NombreCaja = " ";
                        }
                        else
                        {
                            objetoCaja.NombreCaja = rd.GetString(0);
                        }
                        //NOMBRE COMPLETO
                        if (rd[1] == DBNull.Value)
                        {
                            objetoCaja.NombreCompleto = " ";
                        }
                        else
                        {
                            objetoCaja.NombreCompleto = rd.GetString(1);
                        }
                        //VALOR TIPO CAMBIO
                        if (rd[2] == DBNull.Value)
                        {
                            objetoCaja.ValorTipoCambio = 0.0;
                        }
                        else
                        {
                            objetoCaja.ValorTipoCambio = rd.GetDouble(2);
                        }
                        //FECHA INICIO
                        if (rd[3] == DBNull.Value)
                        {
                            objetoCaja.FechaInicioCaja = DateTime.Now;
                        }
                        else
                        {
                            objetoCaja.FechaInicioCaja = rd.GetDateTime(3);
                        }
                        //FECHA CIERRE
                        if (rd[4] == DBNull.Value)
                        {
                            objetoCaja.FechaFinalCaja = DateTime.Now;
                        }
                        else
                        {
                            objetoCaja.FechaFinalCaja = rd.GetDateTime(4);
                        }
                        //SALDO INICIAL
                        if (rd[5] == DBNull.Value)
                        {
                            objetoCaja.SaldoInicial = 0.0;
                        }
                        else
                        {
                            objetoCaja.SaldoInicial = rd.GetDouble(5);
                        }
                        //SALDO FINAL
                        if (rd[6] == DBNull.Value)
                        {
                            objetoCaja.SaldoFinal = 0.0;
                        }
                        else
                        {
                            objetoCaja.SaldoFinal = rd.GetDouble(6);
                        }

                        lista.Add(new C_Caja
                        {
                            NombreCaja = objetoCaja.NombreCaja,
                            NombreCompleto = objetoCaja.NombreCompleto,
                            ValorTipoCambio = objetoCaja.ValorTipoCambio,
                            FechaInicioCaja = objetoCaja.FechaInicioCaja,
                            FechaFinalCaja = objetoCaja.FechaFinalCaja,
                            SaldoInicial = objetoCaja.SaldoInicial,
                            SaldoFinal = objetoCaja.SaldoFinal

                        });
                    }
                }
            }
            catch (Exception )
            {
                throw new Exception("Error al mostrar" );
            }
            finally
            {
                cnn.Close();
            }
            return lista;
        }
        public List<C_Caja> ReporteCajaPorFechaInicio(DateTime fecha1, DateTime fecha2)
        {
            List<C_Caja> lista = new List<C_Caja>();
            C_Caja objetoCaja = new C_Caja();
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT NOMBRE,NOMBRE_COMPLETO,VALOR,FECHA_INICIO_CAJA,FECHA_FINAL_CAJA,SALDO_INICIAL,SALDO_FINAL FROM VW_REPORTECAJA WHERE fecha_inicio_caja between '" + fecha1.ToShortDateString() + "' and '" + fecha2.ToShortDateString() + "' ORDER BY FECHA_INICIO_CAJA DESC;", cnn);
                cmd.CommandType = System.Data.CommandType.Text;
                NpgsqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        //NOMBRE CAJA
                        if (rd[0] == DBNull.Value)
                        {
                            objetoCaja.NombreCaja = " ";
                        }
                        else
                        {
                            objetoCaja.NombreCaja = rd.GetString(0);
                        }
                        //NOMBRE COMPLETO
                        if (rd[1] == DBNull.Value)
                        {
                            objetoCaja.NombreCompleto = " ";
                        }
                        else
                        {
                            objetoCaja.NombreCompleto = rd.GetString(1);
                        }
                        //VALOR TIPO CAMBIO
                        if (rd[2] == DBNull.Value)
                        {
                            objetoCaja.ValorTipoCambio = 0.0;
                        }
                        else
                        {
                            objetoCaja.ValorTipoCambio = rd.GetDouble(2);
                        }
                        //FECHA INICIO
                        if (rd[3] == DBNull.Value)
                        {
                            objetoCaja.FechaInicioCaja = DateTime.Now;
                        }
                        else
                        {
                            objetoCaja.FechaInicioCaja = rd.GetDateTime(3);
                        }
                        //FECHA CIERRE
                        if (rd[4] == DBNull.Value)
                        {
                            objetoCaja.FechaFinalCaja = DateTime.Now;
                        }
                        else
                        {
                            objetoCaja.FechaFinalCaja = rd.GetDateTime(4);
                        }
                        //SALDO INICIAL
                        if (rd[5] == DBNull.Value)
                        {
                            objetoCaja.SaldoInicial = 0.0;
                        }
                        else
                        {
                            objetoCaja.SaldoInicial = rd.GetDouble(5);
                        }
                        //SALDO FINAL
                        if (rd[6] == DBNull.Value)
                        {
                            objetoCaja.SaldoFinal = 0.0;
                        }
                        else
                        {
                            objetoCaja.SaldoFinal = rd.GetDouble(6);
                        }

                        lista.Add(new C_Caja
                        {
                            NombreCaja = objetoCaja.NombreCaja,
                            NombreCompleto = objetoCaja.NombreCompleto,
                            ValorTipoCambio = objetoCaja.ValorTipoCambio,
                            FechaInicioCaja = objetoCaja.FechaInicioCaja,
                            FechaFinalCaja = objetoCaja.FechaFinalCaja,
                            SaldoInicial = objetoCaja.SaldoInicial,
                            SaldoFinal = objetoCaja.SaldoFinal

                        });
                    }
                }
            }
            catch (Exception )
            {
                throw new Exception("Error al mostrar" );
            }
            finally
            {
                cnn.Close();
            }
            return lista;
        }
        public List<C_Caja> ReporteCajaPorFechaCierre(DateTime fecha1, DateTime fecha2)
        {
            List<C_Caja> lista = new List<C_Caja>();
            C_Caja objetoCaja = new C_Caja();
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT NOMBRE,NOMBRE_COMPLETO,VALOR,FECHA_INICIO_CAJA,FECHA_FINAL_CAJA,SALDO_INICIAL,SALDO_FINAL FROM VW_REPORTECAJA WHERE fecha_final_caja between '" + fecha1.ToShortDateString() + "' and '" + fecha2.ToShortDateString() + "' ORDER BY fecha_final_caja DESC;", cnn);
                cmd.CommandType = System.Data.CommandType.Text;
                NpgsqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        //NOMBRE CAJA
                        if (rd[0] == DBNull.Value)
                        {
                            objetoCaja.NombreCaja = " ";
                        }
                        else
                        {
                            objetoCaja.NombreCaja = rd.GetString(0);
                        }
                        //NOMBRE COMPLETO
                        if (rd[1] == DBNull.Value)
                        {
                            objetoCaja.NombreCompleto = " ";
                        }
                        else
                        {
                            objetoCaja.NombreCompleto = rd.GetString(1);
                        }
                        //VALOR TIPO CAMBIO
                        if (rd[2] == DBNull.Value)
                        {
                            objetoCaja.ValorTipoCambio = 0.0;
                        }
                        else
                        {
                            objetoCaja.ValorTipoCambio = rd.GetDouble(2);
                        }
                        //FECHA INICIO
                        if (rd[3] == DBNull.Value)
                        {
                            objetoCaja.FechaInicioCaja = DateTime.Now;
                        }
                        else
                        {
                            objetoCaja.FechaInicioCaja = rd.GetDateTime(3);
                        }
                        //FECHA CIERRE
                        if (rd[4] == DBNull.Value)
                        {
                            objetoCaja.FechaFinalCaja = DateTime.Now;
                        }
                        else
                        {
                            objetoCaja.FechaFinalCaja = rd.GetDateTime(4);
                        }
                        //SALDO INICIAL
                        if (rd[5] == DBNull.Value)
                        {
                            objetoCaja.SaldoInicial = 0.0;
                        }
                        else
                        {
                            objetoCaja.SaldoInicial = rd.GetDouble(5);
                        }
                        //SALDO FINAL
                        if (rd[6] == DBNull.Value)
                        {
                            objetoCaja.SaldoFinal = 0.0;
                        }
                        else
                        {
                            objetoCaja.SaldoFinal = rd.GetDouble(6);
                        }

                        lista.Add(new C_Caja
                        {
                            NombreCaja = objetoCaja.NombreCaja,
                            NombreCompleto = objetoCaja.NombreCompleto,
                            ValorTipoCambio = objetoCaja.ValorTipoCambio,
                            FechaInicioCaja = objetoCaja.FechaInicioCaja,
                            FechaFinalCaja = objetoCaja.FechaFinalCaja,
                            SaldoInicial = objetoCaja.SaldoInicial,
                            SaldoFinal = objetoCaja.SaldoFinal

                        });
                    }
                }
            }
            catch (Exception )
            {
                throw new Exception("Error al mostrar" );
            }
            finally
            {
                cnn.Close();
            }
            return lista;
        }
        public List<C_Caja> ReporteCajaPorAmbasFechas(DateTime fecha1, DateTime fecha2)
        {
            List<C_Caja> lista = new List<C_Caja>();
            C_Caja objetoCaja = new C_Caja();
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT NOMBRE,NOMBRE_COMPLETO,VALOR,FECHA_INICIO_CAJA,FECHA_FINAL_CAJA,SALDO_INICIAL,SALDO_FINAL FROM VW_REPORTECAJA WHERE fecha_inicio_caja between '" + fecha1.ToShortDateString() + "' and '" + fecha2.ToShortDateString() + "' and  fecha_final_caja between '" + fecha1.ToShortDateString() + "' and '" + fecha2.ToShortDateString() + "' ORDER BY fecha_inicio_caja DESC;", cnn);
                cmd.CommandType = System.Data.CommandType.Text;
                NpgsqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        //NOMBRE CAJA
                        if (rd[0] == DBNull.Value)
                        {
                            objetoCaja.NombreCaja = " ";
                        }
                        else
                        {
                            objetoCaja.NombreCaja = rd.GetString(0);
                        }
                        //NOMBRE COMPLETO
                        if (rd[1] == DBNull.Value)
                        {
                            objetoCaja.NombreCompleto = " ";
                        }
                        else
                        {
                            objetoCaja.NombreCompleto = rd.GetString(1);
                        }
                        //VALOR TIPO CAMBIO
                        if (rd[2] == DBNull.Value)
                        {
                            objetoCaja.ValorTipoCambio = 0.0;
                        }
                        else
                        {
                            objetoCaja.ValorTipoCambio = rd.GetDouble(2);
                        }
                        //FECHA INICIO
                        if (rd[3] == DBNull.Value)
                        {
                            objetoCaja.FechaInicioCaja = DateTime.Now;
                        }
                        else
                        {
                            objetoCaja.FechaInicioCaja = rd.GetDateTime(3);
                        }
                        //FECHA CIERRE
                        if (rd[4] == DBNull.Value)
                        {
                            objetoCaja.FechaFinalCaja = DateTime.Now;
                        }
                        else
                        {
                            objetoCaja.FechaFinalCaja = rd.GetDateTime(4);
                        }
                        //SALDO INICIAL
                        if (rd[5] == DBNull.Value)
                        {
                            objetoCaja.SaldoInicial = 0.0;
                        }
                        else
                        {
                            objetoCaja.SaldoInicial = rd.GetDouble(5);
                        }
                        //SALDO FINAL
                        if (rd[6] == DBNull.Value)
                        {
                            objetoCaja.SaldoFinal = 0.0;
                        }
                        else
                        {
                            objetoCaja.SaldoFinal = rd.GetDouble(6);
                        }

                        lista.Add(new C_Caja
                        {
                            NombreCaja = objetoCaja.NombreCaja,
                            NombreCompleto = objetoCaja.NombreCompleto,
                            ValorTipoCambio = objetoCaja.ValorTipoCambio,
                            FechaInicioCaja = objetoCaja.FechaInicioCaja,
                            FechaFinalCaja = objetoCaja.FechaFinalCaja,
                            SaldoInicial = objetoCaja.SaldoInicial,
                            SaldoFinal = objetoCaja.SaldoFinal

                        });
                    }
                }
            }
            catch (Exception )
            {
                throw new Exception("Error al mostrar" );
            }
            finally
            {
                cnn.Close();
            }
            return lista;
        }


        public List<C_Venta> ReporteVentaTodo(int flag)
        {
            List<C_Venta> lista = new List<C_Venta>();
            C_Venta objetoVenta = new C_Venta();
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT NOMBRE_CAJA,NOMBRE_DOCUMENTO,NOMBRE_TIPOPAGO,NOMBRE_CLIENTE,NOMBRE,NUMERO_DOCUMENTO_VENTA,FECHA_VENTA,TOTAL_VENTA FROM VW_REPORTEVENTAS WHERE FLAG_CANCELADA = " + flag + " ;", cnn);
                cmd.CommandType = System.Data.CommandType.Text;
                NpgsqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        //NOMBRE CAJA
                        if (rd[0] == DBNull.Value)
                        {
                            objetoVenta.NombreCaja = " ";
                        }
                        else
                        {
                            objetoVenta.NombreCaja = rd.GetString(0);
                        }
                        //NOMBRE DOCUMENTO
                        if (rd[1] == DBNull.Value)
                        {
                            objetoVenta.NombreDocumento = "";
                        }
                        else
                        {
                            objetoVenta.NombreDocumento = rd.GetString(1);
                        }
                        //NOMBRE TIPO PAGO
                        if (rd[2] == DBNull.Value)
                        {
                            objetoVenta.NombreTipoPago = " ";
                        }
                        else
                        {
                            objetoVenta.NombreTipoPago = rd.GetString(2);
                        }
                        //NOMBRE CLIENTE
                        if (rd[3] == DBNull.Value)
                        {
                            objetoVenta.NombreCliente = " ";
                        }
                        else
                        {
                            objetoVenta.NombreCliente = rd.GetString(3);
                        }
                        //NOMBRE MEPRESA
                        if (rd[4] == DBNull.Value)
                        {
                            objetoVenta.NombreEmpresa = " ";
                        }
                        else
                        {
                            objetoVenta.NombreEmpresa = rd.GetString(4);
                        }
                        //NUMERO DOCUMENTO VENTA
                        if (rd[5] == DBNull.Value)
                        {
                            objetoVenta.NumeroDocumentoVenta = " ";
                        }
                        else
                        {
                            objetoVenta.NumeroDocumentoVenta = rd.GetString(5);
                        }
                        //FECHA 
                        if (rd[6] == DBNull.Value)
                        {
                            objetoVenta.FechaVenta = DateTime.Now;
                        }
                        else
                        {
                            objetoVenta.FechaVenta = rd.GetDateTime(6);
                        }
                        //TOTAL
                        if (rd[7] == DBNull.Value)
                        {
                            objetoVenta.TotalVenta = 0.0;
                        }
                        else
                        {
                            objetoVenta.TotalVenta = rd.GetDouble(7);
                        }

                        lista.Add(new C_Venta
                        {
                            NombreCaja = objetoVenta.NombreCaja,
                            NombreDocumento = objetoVenta.NombreDocumento,
                            NombreTipoPago = objetoVenta.NombreTipoPago,
                            NombreCliente = objetoVenta.NombreCliente,
                            NombreEmpresa = objetoVenta.NombreEmpresa,
                            NumeroDocumentoVenta = objetoVenta.NumeroDocumentoVenta,
                            FechaVenta = objetoVenta.FechaVenta,
                            TotalVenta = objetoVenta.TotalVenta
                        });
                    }
                }
            }
            catch (Exception )
            {
                throw new Exception("Error al mostrar" );
            }
            finally
            {
                cnn.Close();
            }
            return lista;
        }
        public List<C_Venta> ReporteVentasPorCaja(int flag, int codigo)
        {
            List<C_Venta> lista = new List<C_Venta>();
            C_Venta objetoVenta = new C_Venta();
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT NOMBRE_CAJA,NOMBRE_DOCUMENTO,NOMBRE_TIPOPAGO,NOMBRE_CLIENTE,NOMBRE,NUMERO_DOCUMENTO_VENTA,FECHA_VENTA,TOTAL_VENTA FROM VW_REPORTEVENTAS WHERE FLAG_CANCELADA = " + flag + " and codigo_nombre_caja = " + codigo + ";", cnn);
                cmd.CommandType = System.Data.CommandType.Text;
                NpgsqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        //NOMBRE CAJA
                        if (rd[0] == DBNull.Value)
                        {
                            objetoVenta.NombreCaja = " ";
                        }
                        else
                        {
                            objetoVenta.NombreCaja = rd.GetString(0);
                        }
                        //NOMBRE DOCUMENTO
                        if (rd[1] == DBNull.Value)
                        {
                            objetoVenta.NombreDocumento = "";
                        }
                        else
                        {
                            objetoVenta.NombreDocumento = rd.GetString(1);
                        }
                        //NOMBRE TIPO PAGO
                        if (rd[2] == DBNull.Value)
                        {
                            objetoVenta.NombreTipoPago = " ";
                        }
                        else
                        {
                            objetoVenta.NombreTipoPago = rd.GetString(2);
                        }
                        //NOMBRE CLIENTE
                        if (rd[3] == DBNull.Value)
                        {
                            objetoVenta.NombreCliente = " ";
                        }
                        else
                        {
                            objetoVenta.NombreCliente = rd.GetString(3);
                        }
                        //NOMBRE MEPRESA
                        if (rd[4] == DBNull.Value)
                        {
                            objetoVenta.NombreEmpresa = " ";
                        }
                        else
                        {
                            objetoVenta.NombreEmpresa = rd.GetString(4);
                        }
                        //NUMERO DOCUMENTO VENTA
                        if (rd[5] == DBNull.Value)
                        {
                            objetoVenta.NumeroDocumentoVenta = " ";
                        }
                        else
                        {
                            objetoVenta.NumeroDocumentoVenta = rd.GetString(5);
                        }
                        //FECHA 
                        if (rd[6] == DBNull.Value)
                        {
                            objetoVenta.FechaVenta = DateTime.Now;
                        }
                        else
                        {
                            objetoVenta.FechaVenta = rd.GetDateTime(6);
                        }
                        //TOTAL
                        if (rd[7] == DBNull.Value)
                        {
                            objetoVenta.TotalVenta = 0.0;
                        }
                        else
                        {
                            objetoVenta.TotalVenta = rd.GetDouble(7);
                        }

                        lista.Add(new C_Venta
                        {
                            NombreCaja = objetoVenta.NombreCaja,
                            NombreDocumento = objetoVenta.NombreDocumento,
                            NombreTipoPago = objetoVenta.NombreTipoPago,
                            NombreCliente = objetoVenta.NombreCliente,
                            NombreEmpresa = objetoVenta.NombreEmpresa,
                            NumeroDocumentoVenta = objetoVenta.NumeroDocumentoVenta,
                            FechaVenta = objetoVenta.FechaVenta,
                            TotalVenta = objetoVenta.TotalVenta
                        });
                    }
                }
            }
            catch (Exception )
            {
                throw new Exception("Error al mostrar" );
            }
            finally
            {
                cnn.Close();
            }
            return lista;
        }
        public List<C_Venta> ReporteVentasPorTipoPago(int flag, int codigo)
        {
            List<C_Venta> lista = new List<C_Venta>();
            C_Venta objetoVenta = new C_Venta();
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT NOMBRE_CAJA,NOMBRE_DOCUMENTO,NOMBRE_TIPOPAGO,NOMBRE_CLIENTE,NOMBRE,NUMERO_DOCUMENTO_VENTA,FECHA_VENTA,TOTAL_VENTA FROM VW_REPORTEVENTAS WHERE FLAG_CANCELADA = " + flag + " and codigo_tipo_pago = " + codigo + ";", cnn);
                cmd.CommandType = System.Data.CommandType.Text;
                NpgsqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        //NOMBRE CAJA
                        if (rd[0] == DBNull.Value)
                        {
                            objetoVenta.NombreCaja = " ";
                        }
                        else
                        {
                            objetoVenta.NombreCaja = rd.GetString(0);
                        }
                        //NOMBRE DOCUMENTO
                        if (rd[1] == DBNull.Value)
                        {
                            objetoVenta.NombreDocumento = "";
                        }
                        else
                        {
                            objetoVenta.NombreDocumento = rd.GetString(1);
                        }
                        //NOMBRE TIPO PAGO
                        if (rd[2] == DBNull.Value)
                        {
                            objetoVenta.NombreTipoPago = " ";
                        }
                        else
                        {
                            objetoVenta.NombreTipoPago = rd.GetString(2);
                        }
                        //NOMBRE CLIENTE
                        if (rd[3] == DBNull.Value)
                        {
                            objetoVenta.NombreCliente = " ";
                        }
                        else
                        {
                            objetoVenta.NombreCliente = rd.GetString(3);
                        }
                        //NOMBRE MEPRESA
                        if (rd[4] == DBNull.Value)
                        {
                            objetoVenta.NombreEmpresa = " ";
                        }
                        else
                        {
                            objetoVenta.NombreEmpresa = rd.GetString(4);
                        }
                        //NUMERO DOCUMENTO VENTA
                        if (rd[5] == DBNull.Value)
                        {
                            objetoVenta.NumeroDocumentoVenta = " ";
                        }
                        else
                        {
                            objetoVenta.NumeroDocumentoVenta = rd.GetString(5);
                        }
                        //FECHA 
                        if (rd[6] == DBNull.Value)
                        {
                            objetoVenta.FechaVenta = DateTime.Now;
                        }
                        else
                        {
                            objetoVenta.FechaVenta = rd.GetDateTime(6);
                        }
                        //TOTAL
                        if (rd[7] == DBNull.Value)
                        {
                            objetoVenta.TotalVenta = 0.0;
                        }
                        else
                        {
                            objetoVenta.TotalVenta = rd.GetDouble(7);
                        }

                        lista.Add(new C_Venta
                        {
                            NombreCaja = objetoVenta.NombreCaja,
                            NombreDocumento = objetoVenta.NombreDocumento,
                            NombreTipoPago = objetoVenta.NombreTipoPago,
                            NombreCliente = objetoVenta.NombreCliente,
                            NombreEmpresa = objetoVenta.NombreEmpresa,
                            NumeroDocumentoVenta = objetoVenta.NumeroDocumentoVenta,
                            FechaVenta = objetoVenta.FechaVenta,
                            TotalVenta = objetoVenta.TotalVenta
                        });
                    }
                }
            }
            catch (Exception )
            {
                throw new Exception("Error al mostrar" );
            }
            finally
            {
                cnn.Close();
            }
            return lista;
        }
        public List<C_Venta> ReporteVentasPorCliente(int flag, int codigo)
        {
            List<C_Venta> lista = new List<C_Venta>();
            C_Venta objetoVenta = new C_Venta();
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT NOMBRE_CAJA,NOMBRE_DOCUMENTO,NOMBRE_TIPOPAGO,NOMBRE_CLIENTE,NOMBRE,NUMERO_DOCUMENTO_VENTA,FECHA_VENTA,TOTAL_VENTA FROM VW_REPORTEVENTAS WHERE FLAG_CANCELADA = " + flag + " and codigo_cliente = " + codigo + ";", cnn);
                cmd.CommandType = System.Data.CommandType.Text;
                NpgsqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        //NOMBRE CAJA
                        if (rd[0] == DBNull.Value)
                        {
                            objetoVenta.NombreCaja = " ";
                        }
                        else
                        {
                            objetoVenta.NombreCaja = rd.GetString(0);
                        }
                        //NOMBRE DOCUMENTO
                        if (rd[1] == DBNull.Value)
                        {
                            objetoVenta.NombreDocumento = "";
                        }
                        else
                        {
                            objetoVenta.NombreDocumento = rd.GetString(1);
                        }
                        //NOMBRE TIPO PAGO
                        if (rd[2] == DBNull.Value)
                        {
                            objetoVenta.NombreTipoPago = " ";
                        }
                        else
                        {
                            objetoVenta.NombreTipoPago = rd.GetString(2);
                        }
                        //NOMBRE CLIENTE
                        if (rd[3] == DBNull.Value)
                        {
                            objetoVenta.NombreCliente = " ";
                        }
                        else
                        {
                            objetoVenta.NombreCliente = rd.GetString(3);
                        }
                        //NOMBRE MEPRESA
                        if (rd[4] == DBNull.Value)
                        {
                            objetoVenta.NombreEmpresa = " ";
                        }
                        else
                        {
                            objetoVenta.NombreEmpresa = rd.GetString(4);
                        }
                        //NUMERO DOCUMENTO VENTA
                        if (rd[5] == DBNull.Value)
                        {
                            objetoVenta.NumeroDocumentoVenta = " ";
                        }
                        else
                        {
                            objetoVenta.NumeroDocumentoVenta = rd.GetString(5);
                        }
                        //FECHA 
                        if (rd[6] == DBNull.Value)
                        {
                            objetoVenta.FechaVenta = DateTime.Now;
                        }
                        else
                        {
                            objetoVenta.FechaVenta = rd.GetDateTime(6);
                        }
                        //TOTAL
                        if (rd[7] == DBNull.Value)
                        {
                            objetoVenta.TotalVenta = 0.0;
                        }
                        else
                        {
                            objetoVenta.TotalVenta = rd.GetDouble(7);
                        }

                        lista.Add(new C_Venta
                        {
                            NombreCaja = objetoVenta.NombreCaja,
                            NombreDocumento = objetoVenta.NombreDocumento,
                            NombreTipoPago = objetoVenta.NombreTipoPago,
                            NombreCliente = objetoVenta.NombreCliente,
                            NombreEmpresa = objetoVenta.NombreEmpresa,
                            NumeroDocumentoVenta = objetoVenta.NumeroDocumentoVenta,
                            FechaVenta = objetoVenta.FechaVenta,
                            TotalVenta = objetoVenta.TotalVenta
                        });
                    }
                }
            }
            catch (Exception )
            {
                throw new Exception("Error al mostrar" );
            }
            finally
            {
                cnn.Close();
            }
            return lista;
        }
        public List<C_Venta> ReporteVentasPorEmpresa(int flag, int codigo)
        {
            List<C_Venta> lista = new List<C_Venta>();
            C_Venta objetoVenta = new C_Venta();
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT NOMBRE_CAJA,NOMBRE_DOCUMENTO,NOMBRE_TIPOPAGO,NOMBRE_CLIENTE,NOMBRE,NUMERO_DOCUMENTO_VENTA,FECHA_VENTA,TOTAL_VENTA FROM VW_REPORTEVENTAS WHERE FLAG_CANCELADA = " + flag + " and codigo_empresa = " + codigo + ";", cnn);
                cmd.CommandType = System.Data.CommandType.Text;
                NpgsqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        //NOMBRE CAJA
                        if (rd[0] == DBNull.Value)
                        {
                            objetoVenta.NombreCaja = " ";
                        }
                        else
                        {
                            objetoVenta.NombreCaja = rd.GetString(0);
                        }
                        //NOMBRE DOCUMENTO
                        if (rd[1] == DBNull.Value)
                        {
                            objetoVenta.NombreDocumento = "";
                        }
                        else
                        {
                            objetoVenta.NombreDocumento = rd.GetString(1);
                        }
                        //NOMBRE TIPO PAGO
                        if (rd[2] == DBNull.Value)
                        {
                            objetoVenta.NombreTipoPago = " ";
                        }
                        else
                        {
                            objetoVenta.NombreTipoPago = rd.GetString(2);
                        }
                        //NOMBRE CLIENTE
                        if (rd[3] == DBNull.Value)
                        {
                            objetoVenta.NombreCliente = " ";
                        }
                        else
                        {
                            objetoVenta.NombreCliente = rd.GetString(3);
                        }
                        //NOMBRE MEPRESA
                        if (rd[4] == DBNull.Value)
                        {
                            objetoVenta.NombreEmpresa = " ";
                        }
                        else
                        {
                            objetoVenta.NombreEmpresa = rd.GetString(4);
                        }
                        //NUMERO DOCUMENTO VENTA
                        if (rd[5] == DBNull.Value)
                        {
                            objetoVenta.NumeroDocumentoVenta = " ";
                        }
                        else
                        {
                            objetoVenta.NumeroDocumentoVenta = rd.GetString(5);
                        }
                        //FECHA 
                        if (rd[6] == DBNull.Value)
                        {
                            objetoVenta.FechaVenta = DateTime.Now;
                        }
                        else
                        {
                            objetoVenta.FechaVenta = rd.GetDateTime(6);
                        }
                        //TOTAL
                        if (rd[7] == DBNull.Value)
                        {
                            objetoVenta.TotalVenta = 0.0;
                        }
                        else
                        {
                            objetoVenta.TotalVenta = rd.GetDouble(7);
                        }

                        lista.Add(new C_Venta
                        {
                            NombreCaja = objetoVenta.NombreCaja,
                            NombreDocumento = objetoVenta.NombreDocumento,
                            NombreTipoPago = objetoVenta.NombreTipoPago,
                            NombreCliente = objetoVenta.NombreCliente,
                            NombreEmpresa = objetoVenta.NombreEmpresa,
                            NumeroDocumentoVenta = objetoVenta.NumeroDocumentoVenta,
                            FechaVenta = objetoVenta.FechaVenta,
                            TotalVenta = objetoVenta.TotalVenta
                        });
                    }
                }
            }
            catch (Exception )
            {
                throw new Exception("Error al mostrar" );
            }
            finally
            {
                cnn.Close();
            }
            return lista;
        }
        public List<C_Venta> ReporteVentasPorFecha(int flag, DateTime fecha1, DateTime fecha2)
        {
            List<C_Venta> lista = new List<C_Venta>();
            C_Venta objetoVenta = new C_Venta();
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT NOMBRE_CAJA,NOMBRE_DOCUMENTO,NOMBRE_TIPOPAGO,NOMBRE_CLIENTE,NOMBRE,NUMERO_DOCUMENTO_VENTA,FECHA_VENTA,TOTAL_VENTA FROM VW_REPORTEVENTAS WHERE FLAG_CANCELADA = " + flag + " and fecha_venta between '" + fecha1.ToShortDateString() + "' and '" + fecha2.ToShortDateString() + "' order by fecha_venta asc;", cnn);
                cmd.CommandType = System.Data.CommandType.Text;
                NpgsqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        //NOMBRE CAJA
                        if (rd[0] == DBNull.Value)
                        {
                            objetoVenta.NombreCaja = " ";
                        }
                        else
                        {
                            objetoVenta.NombreCaja = rd.GetString(0);
                        }
                        //NOMBRE DOCUMENTO
                        if (rd[1] == DBNull.Value)
                        {
                            objetoVenta.NombreDocumento = "";
                        }
                        else
                        {
                            objetoVenta.NombreDocumento = rd.GetString(1);
                        }
                        //NOMBRE TIPO PAGO
                        if (rd[2] == DBNull.Value)
                        {
                            objetoVenta.NombreTipoPago = " ";
                        }
                        else
                        {
                            objetoVenta.NombreTipoPago = rd.GetString(2);
                        }
                        //NOMBRE CLIENTE
                        if (rd[3] == DBNull.Value)
                        {
                            objetoVenta.NombreCliente = " ";
                        }
                        else
                        {
                            objetoVenta.NombreCliente = rd.GetString(3);
                        }
                        //NOMBRE MEPRESA
                        if (rd[4] == DBNull.Value)
                        {
                            objetoVenta.NombreEmpresa = " ";
                        }
                        else
                        {
                            objetoVenta.NombreEmpresa = rd.GetString(4);
                        }
                        //NUMERO DOCUMENTO VENTA
                        if (rd[5] == DBNull.Value)
                        {
                            objetoVenta.NumeroDocumentoVenta = " ";
                        }
                        else
                        {
                            objetoVenta.NumeroDocumentoVenta = rd.GetString(5);
                        }
                        //FECHA 
                        if (rd[6] == DBNull.Value)
                        {
                            objetoVenta.FechaVenta = DateTime.Now;
                        }
                        else
                        {
                            objetoVenta.FechaVenta = rd.GetDateTime(6);
                        }
                        //TOTAL
                        if (rd[7] == DBNull.Value)
                        {
                            objetoVenta.TotalVenta = 0.0;
                        }
                        else
                        {
                            objetoVenta.TotalVenta = rd.GetDouble(7);
                        }

                        lista.Add(new C_Venta
                        {
                            NombreCaja = objetoVenta.NombreCaja,
                            NombreDocumento = objetoVenta.NombreDocumento,
                            NombreTipoPago = objetoVenta.NombreTipoPago,
                            NombreCliente = objetoVenta.NombreCliente,
                            NombreEmpresa = objetoVenta.NombreEmpresa,
                            NumeroDocumentoVenta = objetoVenta.NumeroDocumentoVenta,
                            FechaVenta = objetoVenta.FechaVenta,
                            TotalVenta = objetoVenta.TotalVenta
                        });
                    }
                }
            }
            catch (Exception )
            {
                throw new Exception("Error al mostrar" );
            }
            finally
            {
                cnn.Close();
            }
            return lista;
        }


        // PAGO DE CREDITO COMPRAS
        public List<C_Pago> ReportePagoTodo()
        {
            List<C_Pago> lista = new List<C_Pago>();
            C_Pago objetoPago = new C_Pago();
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("select numero_documento,nombre_proveedor,nombre_tipopago, nombre_caja,monto_pagar,fecha_pago,entidad_bancaria,num_voucher, nombre_moneda from vw_reportepagocompra order by fecha_pago desc;", cnn);
                cmd.CommandType = System.Data.CommandType.Text;
                NpgsqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        //NUMERO DOCUMENTO
                        if (rd[0] == DBNull.Value)
                        {
                            objetoPago.NumDocumento = " ";
                        }
                        else
                        {
                            objetoPago.NumDocumento = rd.GetString(0);
                        }
                        //NOMBRE DOCUMENTO
                        if (rd[1] == DBNull.Value)
                        {
                            objetoPago.NombreProveedor = "";
                        }
                        else
                        {
                            objetoPago.NombreProveedor = rd.GetString(1);
                        }
                        //NOMBRE TIPO PAGO
                        if (rd[2] == DBNull.Value)
                        {
                            objetoPago.NombreTipoPago = " ";
                        }
                        else
                        {
                            objetoPago.NombreTipoPago = rd.GetString(2);
                        }
                        //NOMBRE CLIENTE
                        if (rd[3] == DBNull.Value)
                        {
                            objetoPago.NombreCaja = " ";
                        }
                        else
                        {
                            objetoPago.NombreCaja = rd.GetString(3);
                        }
                        //NOMBRE MEPRESA
                        if (rd[4] == DBNull.Value)
                        {
                            objetoPago.MontoPagar = 0.0;
                        }
                        else
                        {
                            objetoPago.MontoPagar = rd.GetDouble(4);
                        }
                        //NUMERO DOCUMENTO VENTA
                        if (rd[5] == DBNull.Value)
                        {
                            objetoPago.FechaPago = DateTime.Now;
                        }
                        else
                        {
                            objetoPago.FechaPago = rd.GetDateTime(5);
                        }
                        //FECHA 
                        if (rd[6] == DBNull.Value)
                        {
                            objetoPago.EntidadBancaria = " ";
                        }
                        else
                        {
                            objetoPago.EntidadBancaria = rd.GetString(6);
                        }
                        //TOTAL
                        if (rd[7] == DBNull.Value)
                        {
                            objetoPago.NumVoucher = " ";
                        }
                        else
                        {
                            objetoPago.NumVoucher = rd.GetString(7);
                        }
                        if (rd[8] == DBNull.Value)
                        {
                            objetoPago.NombreMoneda = " ";
                        }
                        else
                        {
                            objetoPago.NombreMoneda = rd.GetString(8);
                        }
                        lista.Add(new C_Pago
                        {
                            NumDocumento = objetoPago.NumDocumento,
                            NombreProveedor = objetoPago.NombreProveedor,
                            NombreTipoPago = objetoPago.NombreTipoPago,
                            NombreCaja = objetoPago.NombreCaja,
                            MontoPagar = objetoPago.MontoPagar,
                            FechaPago = objetoPago.FechaPago,
                            EntidadBancaria = objetoPago.EntidadBancaria,
                            NumVoucher = objetoPago.NumVoucher,
                            NombreMoneda = objetoPago.NombreMoneda
                        });
                    }
                }
            }
            catch (Exception )
            {
                throw new Exception("Error al mostrar" );
            }
            finally
            {
                cnn.Close();
            }
            return lista;
        }
        public List<C_Pago> ReportePagoPorProveedor(int codigo)
        {
            List<C_Pago> lista = new List<C_Pago>();
            C_Pago objetoPago = new C_Pago();
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("select numero_documento,nombre_proveedor,nombre_tipopago, nombre_caja,monto_pagar,fecha_pago,entidad_bancaria,num_voucher, nombre_moneda from vw_reportepagocompra where codigo_proveedor =" + codigo + " order by fecha_pago desc;", cnn);
                cmd.CommandType = System.Data.CommandType.Text;
                NpgsqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        //NUMERO DOCUMENTO
                        if (rd[0] == DBNull.Value)
                        {
                            objetoPago.NumDocumento = " ";
                        }
                        else
                        {
                            objetoPago.NumDocumento = rd.GetString(0);
                        }
                        //NOMBRE DOCUMENTO
                        if (rd[1] == DBNull.Value)
                        {
                            objetoPago.NombreProveedor = "";
                        }
                        else
                        {
                            objetoPago.NombreProveedor = rd.GetString(1);
                        }
                        //NOMBRE TIPO PAGO
                        if (rd[2] == DBNull.Value)
                        {
                            objetoPago.NombreTipoPago = " ";
                        }
                        else
                        {
                            objetoPago.NombreTipoPago = rd.GetString(2);
                        }
                        //NOMBRE CLIENTE
                        if (rd[3] == DBNull.Value)
                        {
                            objetoPago.NombreCaja = " ";
                        }
                        else
                        {
                            objetoPago.NombreCaja = rd.GetString(3);
                        }
                        //NOMBRE MEPRESA
                        if (rd[4] == DBNull.Value)
                        {
                            objetoPago.MontoPagar = 0.0;
                        }
                        else
                        {
                            objetoPago.MontoPagar = rd.GetDouble(4);
                        }
                        //NUMERO DOCUMENTO VENTA
                        if (rd[5] == DBNull.Value)
                        {
                            objetoPago.FechaPago = DateTime.Now;
                        }
                        else
                        {
                            objetoPago.FechaPago = rd.GetDateTime(5);
                        }
                        //FECHA 
                        if (rd[6] == DBNull.Value)
                        {
                            objetoPago.EntidadBancaria = " ";
                        }
                        else
                        {
                            objetoPago.EntidadBancaria = rd.GetString(6);
                        }
                        //TOTAL
                        if (rd[7] == DBNull.Value)
                        {
                            objetoPago.NumVoucher = " ";
                        }
                        else
                        {
                            objetoPago.NumVoucher = rd.GetString(7);
                        }
                        if (rd[8] == DBNull.Value)
                        {
                            objetoPago.NombreMoneda = " ";
                        }
                        else
                        {
                            objetoPago.NombreMoneda = rd.GetString(8);
                        }
                        lista.Add(new C_Pago
                        {
                            NumDocumento = objetoPago.NumDocumento,
                            NombreProveedor = objetoPago.NombreProveedor,
                            NombreTipoPago = objetoPago.NombreTipoPago,
                            NombreCaja = objetoPago.NombreCaja,
                            MontoPagar = objetoPago.MontoPagar,
                            FechaPago = objetoPago.FechaPago,
                            EntidadBancaria = objetoPago.EntidadBancaria,
                            NumVoucher = objetoPago.NumVoucher,
                            NombreMoneda = objetoPago.NombreMoneda
                        });
                    }
                }
            }
            catch (Exception )
            {
                throw new Exception("Error al mostrar" );
            }
            finally
            {
                cnn.Close();
            }
            return lista;
        }
        public List<C_Pago> ReportePagoPorCaja(int codigo)
        {
            List<C_Pago> lista = new List<C_Pago>();
            C_Pago objetoPago = new C_Pago();
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("select numero_documento,nombre_proveedor,nombre_tipopago, nombre_caja,monto_pagar,fecha_pago,entidad_bancaria,num_voucher, nombre_moneda from vw_reportepagocompra where codigo_nombre_caja =" + codigo + " order by fecha_pago desc;", cnn);
                cmd.CommandType = System.Data.CommandType.Text;
                NpgsqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        //NUMERO DOCUMENTO
                        if (rd[0] == DBNull.Value)
                        {
                            objetoPago.NumDocumento = " ";
                        }
                        else
                        {
                            objetoPago.NumDocumento = rd.GetString(0);
                        }
                        //NOMBRE DOCUMENTO
                        if (rd[1] == DBNull.Value)
                        {
                            objetoPago.NombreProveedor = "";
                        }
                        else
                        {
                            objetoPago.NombreProveedor = rd.GetString(1);
                        }
                        //NOMBRE TIPO PAGO
                        if (rd[2] == DBNull.Value)
                        {
                            objetoPago.NombreTipoPago = " ";
                        }
                        else
                        {
                            objetoPago.NombreTipoPago = rd.GetString(2);
                        }
                        //NOMBRE CLIENTE
                        if (rd[3] == DBNull.Value)
                        {
                            objetoPago.NombreCaja = " ";
                        }
                        else
                        {
                            objetoPago.NombreCaja = rd.GetString(3);
                        }
                        //NOMBRE MEPRESA
                        if (rd[4] == DBNull.Value)
                        {
                            objetoPago.MontoPagar = 0.0;
                        }
                        else
                        {
                            objetoPago.MontoPagar = rd.GetDouble(4);
                        }
                        //NUMERO DOCUMENTO VENTA
                        if (rd[5] == DBNull.Value)
                        {
                            objetoPago.FechaPago = DateTime.Now;
                        }
                        else
                        {
                            objetoPago.FechaPago = rd.GetDateTime(5);
                        }
                        //FECHA 
                        if (rd[6] == DBNull.Value)
                        {
                            objetoPago.EntidadBancaria = " ";
                        }
                        else
                        {
                            objetoPago.EntidadBancaria = rd.GetString(6);
                        }
                        //TOTAL
                        if (rd[7] == DBNull.Value)
                        {
                            objetoPago.NumVoucher = " ";
                        }
                        else
                        {
                            objetoPago.NumVoucher = rd.GetString(7);
                        }
                        if (rd[8] == DBNull.Value)
                        {
                            objetoPago.NombreMoneda = " ";
                        }
                        else
                        {
                            objetoPago.NombreMoneda = rd.GetString(8);
                        }
                        lista.Add(new C_Pago
                        {
                            NumDocumento = objetoPago.NumDocumento,
                            NombreProveedor = objetoPago.NombreProveedor,
                            NombreTipoPago = objetoPago.NombreTipoPago,
                            NombreCaja = objetoPago.NombreCaja,
                            MontoPagar = objetoPago.MontoPagar,
                            FechaPago = objetoPago.FechaPago,
                            EntidadBancaria = objetoPago.EntidadBancaria,
                            NumVoucher = objetoPago.NumVoucher,
                            NombreMoneda = objetoPago.NombreMoneda
                        });
                    }
                }
            }
            catch (Exception )
            {
                throw new Exception("Error al mostrar" );
            }
            finally
            {
                cnn.Close();
            }
            return lista;
        }
        public List<C_Pago> ReportePagoPorDocumento(string codigo)
        {
            List<C_Pago> lista = new List<C_Pago>();
            C_Pago objetoPago = new C_Pago();
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("select numero_documento,nombre_proveedor,nombre_tipopago, nombre_caja,monto_pagar,fecha_pago,entidad_bancaria,num_voucher, nombre_moneda from vw_reportepagocompra where numero_documento = '" + codigo + "' order by fecha_pago desc;", cnn);
                cmd.CommandType = System.Data.CommandType.Text;
                NpgsqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        //NUMERO DOCUMENTO
                        if (rd[0] == DBNull.Value)
                        {
                            objetoPago.NumDocumento = " ";
                        }
                        else
                        {
                            objetoPago.NumDocumento = rd.GetString(0);
                        }
                        //NOMBRE DOCUMENTO
                        if (rd[1] == DBNull.Value)
                        {
                            objetoPago.NombreProveedor = "";
                        }
                        else
                        {
                            objetoPago.NombreProveedor = rd.GetString(1);
                        }
                        //NOMBRE TIPO PAGO
                        if (rd[2] == DBNull.Value)
                        {
                            objetoPago.NombreTipoPago = " ";
                        }
                        else
                        {
                            objetoPago.NombreTipoPago = rd.GetString(2);
                        }
                        //NOMBRE CLIENTE
                        if (rd[3] == DBNull.Value)
                        {
                            objetoPago.NombreCaja = " ";
                        }
                        else
                        {
                            objetoPago.NombreCaja = rd.GetString(3);
                        }
                        //NOMBRE MEPRESA
                        if (rd[4] == DBNull.Value)
                        {
                            objetoPago.MontoPagar = 0.0;
                        }
                        else
                        {
                            objetoPago.MontoPagar = rd.GetDouble(4);
                        }
                        //NUMERO DOCUMENTO VENTA
                        if (rd[5] == DBNull.Value)
                        {
                            objetoPago.FechaPago = DateTime.Now;
                        }
                        else
                        {
                            objetoPago.FechaPago = rd.GetDateTime(5);
                        }
                        //FECHA 
                        if (rd[6] == DBNull.Value)
                        {
                            objetoPago.EntidadBancaria = " ";
                        }
                        else
                        {
                            objetoPago.EntidadBancaria = rd.GetString(6);
                        }
                        //TOTAL
                        if (rd[7] == DBNull.Value)
                        {
                            objetoPago.NumVoucher = " ";
                        }
                        else
                        {
                            objetoPago.NumVoucher = rd.GetString(7);
                        }
                        if (rd[8] == DBNull.Value)
                        {
                            objetoPago.NombreMoneda = " ";
                        }
                        else
                        {
                            objetoPago.NombreMoneda = rd.GetString(8);
                        }
                        lista.Add(new C_Pago
                        {
                            NumDocumento = objetoPago.NumDocumento,
                            NombreProveedor = objetoPago.NombreProveedor,
                            NombreTipoPago = objetoPago.NombreTipoPago,
                            NombreCaja = objetoPago.NombreCaja,
                            MontoPagar = objetoPago.MontoPagar,
                            FechaPago = objetoPago.FechaPago,
                            EntidadBancaria = objetoPago.EntidadBancaria,
                            NumVoucher = objetoPago.NumVoucher,
                            NombreMoneda = objetoPago.NombreMoneda
                        });
                    }
                }
            }
            catch (Exception )
            {
                throw new Exception("Error al mostrar" );
            }
            finally
            {
                cnn.Close();
            }
            return lista;
        }
        public List<C_Pago> ReportePagoPorVoucher(string codigo)
        {
            List<C_Pago> lista = new List<C_Pago>();
            C_Pago objetoPago = new C_Pago();
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("select numero_documento,nombre_proveedor,nombre_tipopago, nombre_caja,monto_pagar,fecha_pago,entidad_bancaria,num_voucher, nombre_moneda from vw_reportepagocompra where num_voucher = '" + codigo + "' order by fecha_pago desc;", cnn);
                cmd.CommandType = System.Data.CommandType.Text;
                NpgsqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        //NUMERO DOCUMENTO
                        if (rd[0] == DBNull.Value)
                        {
                            objetoPago.NumDocumento = " ";
                        }
                        else
                        {
                            objetoPago.NumDocumento = rd.GetString(0);
                        }
                        //NOMBRE DOCUMENTO
                        if (rd[1] == DBNull.Value)
                        {
                            objetoPago.NombreProveedor = "";
                        }
                        else
                        {
                            objetoPago.NombreProveedor = rd.GetString(1);
                        }
                        //NOMBRE TIPO PAGO
                        if (rd[2] == DBNull.Value)
                        {
                            objetoPago.NombreTipoPago = " ";
                        }
                        else
                        {
                            objetoPago.NombreTipoPago = rd.GetString(2);
                        }
                        //NOMBRE CLIENTE
                        if (rd[3] == DBNull.Value)
                        {
                            objetoPago.NombreCaja = " ";
                        }
                        else
                        {
                            objetoPago.NombreCaja = rd.GetString(3);
                        }
                        //NOMBRE MEPRESA
                        if (rd[4] == DBNull.Value)
                        {
                            objetoPago.MontoPagar = 0.0;
                        }
                        else
                        {
                            objetoPago.MontoPagar = rd.GetDouble(4);
                        }
                        //NUMERO DOCUMENTO VENTA
                        if (rd[5] == DBNull.Value)
                        {
                            objetoPago.FechaPago = DateTime.Now;
                        }
                        else
                        {
                            objetoPago.FechaPago = rd.GetDateTime(5);
                        }
                        //FECHA 
                        if (rd[6] == DBNull.Value)
                        {
                            objetoPago.EntidadBancaria = " ";
                        }
                        else
                        {
                            objetoPago.EntidadBancaria = rd.GetString(6);
                        }
                        //TOTAL
                        if (rd[7] == DBNull.Value)
                        {
                            objetoPago.NumVoucher = " ";
                        }
                        else
                        {
                            objetoPago.NumVoucher = rd.GetString(7);
                        }
                        if (rd[8] == DBNull.Value)
                        {
                            objetoPago.NombreMoneda = " ";
                        }
                        else
                        {
                            objetoPago.NombreMoneda = rd.GetString(8);
                        }
                        lista.Add(new C_Pago
                        {
                            NumDocumento = objetoPago.NumDocumento,
                            NombreProveedor = objetoPago.NombreProveedor,
                            NombreTipoPago = objetoPago.NombreTipoPago,
                            NombreCaja = objetoPago.NombreCaja,
                            MontoPagar = objetoPago.MontoPagar,
                            FechaPago = objetoPago.FechaPago,
                            EntidadBancaria = objetoPago.EntidadBancaria,
                            NumVoucher = objetoPago.NumVoucher,
                            NombreMoneda = objetoPago.NombreMoneda
                        });
                    }
                }
            }
            catch (Exception )
            {
                throw new Exception("Error al mostrar" );
            }
            finally
            {
                cnn.Close();
            }
            return lista;
        }
        public List<C_Pago> ReportePagoPorFechas(DateTime fecha1, DateTime fecha2)
        {
            List<C_Pago> lista = new List<C_Pago>();
            C_Pago objetoPago = new C_Pago();
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("select numero_documento,nombre_proveedor,nombre_tipopago, nombre_caja,monto_pagar,fecha_pago,entidad_bancaria,num_voucher, nombre_moneda from vw_reportepagocompra where fecha_pago between '" + fecha1.ToShortDateString() + "' and '" + fecha2.ToShortDateString() + "' order by fecha_pago desc;", cnn);
                cmd.CommandType = System.Data.CommandType.Text;
                NpgsqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        //NUMERO DOCUMENTO
                        if (rd[0] == DBNull.Value)
                        {
                            objetoPago.NumDocumento = " ";
                        }
                        else
                        {
                            objetoPago.NumDocumento = rd.GetString(0);
                        }
                        //NOMBRE DOCUMENTO
                        if (rd[1] == DBNull.Value)
                        {
                            objetoPago.NombreProveedor = "";
                        }
                        else
                        {
                            objetoPago.NombreProveedor = rd.GetString(1);
                        }
                        //NOMBRE TIPO PAGO
                        if (rd[2] == DBNull.Value)
                        {
                            objetoPago.NombreTipoPago = " ";
                        }
                        else
                        {
                            objetoPago.NombreTipoPago = rd.GetString(2);
                        }
                        //NOMBRE CLIENTE
                        if (rd[3] == DBNull.Value)
                        {
                            objetoPago.NombreCaja = " ";
                        }
                        else
                        {
                            objetoPago.NombreCaja = rd.GetString(3);
                        }
                        //NOMBRE MEPRESA
                        if (rd[4] == DBNull.Value)
                        {
                            objetoPago.MontoPagar = 0.0;
                        }
                        else
                        {
                            objetoPago.MontoPagar = rd.GetDouble(4);
                        }
                        //NUMERO DOCUMENTO VENTA
                        if (rd[5] == DBNull.Value)
                        {
                            objetoPago.FechaPago = DateTime.Now;
                        }
                        else
                        {
                            objetoPago.FechaPago = rd.GetDateTime(5);
                        }
                        //FECHA 
                        if (rd[6] == DBNull.Value)
                        {
                            objetoPago.EntidadBancaria = " ";
                        }
                        else
                        {
                            objetoPago.EntidadBancaria = rd.GetString(6);
                        }
                        //TOTAL
                        if (rd[7] == DBNull.Value)
                        {
                            objetoPago.NumVoucher = " ";
                        }
                        else
                        {
                            objetoPago.NumVoucher = rd.GetString(7);
                        }
                        if (rd[8] == DBNull.Value)
                        {
                            objetoPago.NombreMoneda = " ";
                        }
                        else
                        {
                            objetoPago.NombreMoneda = rd.GetString(8);
                        }
                        lista.Add(new C_Pago
                        {
                            NumDocumento = objetoPago.NumDocumento,
                            NombreProveedor = objetoPago.NombreProveedor,
                            NombreTipoPago = objetoPago.NombreTipoPago,
                            NombreCaja = objetoPago.NombreCaja,
                            MontoPagar = objetoPago.MontoPagar,
                            FechaPago = objetoPago.FechaPago,
                            EntidadBancaria = objetoPago.EntidadBancaria,
                            NumVoucher = objetoPago.NumVoucher,
                            NombreMoneda = objetoPago.NombreMoneda
                        });
                    }
                }
            }
            catch (Exception )
            {
                throw new Exception("Error al mostrar" );
            }
            finally
            {
                cnn.Close();
            }
            return lista;
        }

        //PAGO DE CREDITO VENTAS
        public List<C_Pago> ReporteVentaTodo()
        {
            List<C_Pago> lista = new List<C_Pago>();
            C_Pago objetoPago = new C_Pago();
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("select numero_documento_venta, num_voucher, nombre_caja,nombre_tipopago, nombre_cliente, num_cuenta,entidad_bancaria,monto_pagar,fecha_pago from vw_reportepagoventa order by fecha_pago desc;", cnn);
                cmd.CommandType = System.Data.CommandType.Text;
                NpgsqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        //NUMERO DOCUMENTO
                        if (rd[0] == DBNull.Value)
                        {
                            objetoPago.NumDocumento = " ";
                        }
                        else
                        {
                            objetoPago.NumDocumento = rd.GetString(0);
                        }
                        //NOMBRE DOCUMENTO
                        if (rd[1] == DBNull.Value)
                        {
                            objetoPago.NumVoucher = "";
                        }
                        else
                        {
                            objetoPago.NumVoucher = rd.GetString(1);
                        }
                        //NOMBRE TIPO PAGO
                        if (rd[2] == DBNull.Value)
                        {
                            objetoPago.NombreCaja = " ";
                        }
                        else
                        {
                            objetoPago.NombreCaja = rd.GetString(2);
                        }
                        //NOMBRE MEPRESA
                        if (rd[3] == DBNull.Value)
                        {
                            objetoPago.NombreTipoPago = " ";
                        }
                        else
                        {
                            objetoPago.NombreTipoPago = rd.GetString(3);
                        }
                        //NUMERO DOCUMENTO VENTA
                        if (rd[4] == DBNull.Value)
                        {
                            objetoPago.NombreCliente = " ";
                        }
                        else
                        {
                            objetoPago.NombreCliente = rd.GetString(4);
                        }
                        //FECHA 
                        if (rd[5] == DBNull.Value)
                        {
                            objetoPago.NumCuenta = " ";
                        }
                        else
                        {
                            objetoPago.NumCuenta = rd.GetString(5);
                        }
                        //TOTAL
                        if (rd[6] == DBNull.Value)
                        {
                            objetoPago.EntidadBancaria = " ";
                        }
                        else
                        {
                            objetoPago.EntidadBancaria = rd.GetString(6);
                        }
                        if (rd[7] == DBNull.Value)
                        {
                            objetoPago.MontoPagar = 0.0;
                        }
                        else
                        {
                            objetoPago.MontoPagar = rd.GetDouble(7);
                        }
                        if (rd[8] == DBNull.Value)
                        {
                            objetoPago.FechaPago = DateTime.Now;
                        }
                        else
                        {
                            objetoPago.FechaPago = rd.GetDateTime(8);
                        }
                        lista.Add(new C_Pago
                        {
                            NumDocumento = objetoPago.NumDocumento,
                            NumVoucher = objetoPago.NumVoucher,
                            NombreCaja = objetoPago.NombreCaja,
                            NombreTipoPago = objetoPago.NombreTipoPago,
                            NombreCliente = objetoPago.NombreCliente,
                            NumCuenta = objetoPago.NumCuenta,
                            EntidadBancaria = objetoPago.EntidadBancaria,
                            MontoPagar = objetoPago.MontoPagar,
                            FechaPago = objetoPago.FechaPago
                        });
                    }
                }
            }
            catch (Exception )
            {
                throw new Exception("Error al mostrar" );
            }
            finally
            {
                cnn.Close();
            }
            return lista;
        }
        public List<C_Pago> ReporteVentaPorCaja(int codigo)
        {
            List<C_Pago> lista = new List<C_Pago>();
            C_Pago objetoPago = new C_Pago();
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("select numero_documento_venta, num_voucher, nombre_caja,nombre_tipopago, nombre_cliente, num_cuenta,entidad_bancaria,monto_pagar,fecha_pago from vw_reportepagoventa where codigo_nombre_caja = " + codigo + " order by fecha_pago desc;", cnn);
                cmd.CommandType = System.Data.CommandType.Text;
                NpgsqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        //NUMERO DOCUMENTO
                        if (rd[0] == DBNull.Value)
                        {
                            objetoPago.NumDocumento = " ";
                        }
                        else
                        {
                            objetoPago.NumDocumento = rd.GetString(0);
                        }
                        //NOMBRE DOCUMENTO
                        if (rd[1] == DBNull.Value)
                        {
                            objetoPago.NumVoucher = "";
                        }
                        else
                        {
                            objetoPago.NumVoucher = rd.GetString(1);
                        }
                        //NOMBRE TIPO PAGO
                        if (rd[2] == DBNull.Value)
                        {
                            objetoPago.NombreCaja = " ";
                        }
                        else
                        {
                            objetoPago.NombreCaja = rd.GetString(2);
                        }
                        //NOMBRE MEPRESA
                        if (rd[3] == DBNull.Value)
                        {
                            objetoPago.NombreTipoPago = " ";
                        }
                        else
                        {
                            objetoPago.NombreTipoPago = rd.GetString(3);
                        }
                        //NUMERO DOCUMENTO VENTA
                        if (rd[4] == DBNull.Value)
                        {
                            objetoPago.NombreCliente = " ";
                        }
                        else
                        {
                            objetoPago.NombreCliente = rd.GetString(4);
                        }
                        //FECHA 
                        if (rd[5] == DBNull.Value)
                        {
                            objetoPago.NumCuenta = " ";
                        }
                        else
                        {
                            objetoPago.NumCuenta = rd.GetString(5);
                        }
                        //TOTAL
                        if (rd[6] == DBNull.Value)
                        {
                            objetoPago.EntidadBancaria = " ";
                        }
                        else
                        {
                            objetoPago.EntidadBancaria = rd.GetString(6);
                        }
                        if (rd[7] == DBNull.Value)
                        {
                            objetoPago.MontoPagar = 0.0;
                        }
                        else
                        {
                            objetoPago.MontoPagar = rd.GetDouble(7);
                        }
                        if (rd[8] == DBNull.Value)
                        {
                            objetoPago.FechaPago = DateTime.Now;
                        }
                        else
                        {
                            objetoPago.FechaPago = rd.GetDateTime(8);
                        }
                        lista.Add(new C_Pago
                        {
                            NumDocumento = objetoPago.NumDocumento,
                            NumVoucher = objetoPago.NumVoucher,
                            NombreCaja = objetoPago.NombreCaja,
                            NombreTipoPago = objetoPago.NombreTipoPago,
                            NombreCliente = objetoPago.NombreCliente,
                            NumCuenta = objetoPago.NumCuenta,
                            EntidadBancaria = objetoPago.EntidadBancaria,
                            MontoPagar = objetoPago.MontoPagar,
                            FechaPago = objetoPago.FechaPago
                        });
                    }
                }
            }
            catch (Exception )
            {
                throw new Exception("Error al mostrar" );
            }
            finally
            {
                cnn.Close();
            }
            return lista;
        }
        public List<C_Pago> ReporteVentaPorCliente(int codigo)
        {
            List<C_Pago> lista = new List<C_Pago>();
            C_Pago objetoPago = new C_Pago();
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("select numero_documento_venta, num_voucher, nombre_caja,nombre_tipopago, nombre_cliente, num_cuenta,entidad_bancaria,monto_pagar,fecha_pago from vw_reportepagoventa where codigo_cliente = " + codigo + " order by fecha_pago desc;", cnn);
                cmd.CommandType = System.Data.CommandType.Text;
                NpgsqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        //NUMERO DOCUMENTO
                        if (rd[0] == DBNull.Value)
                        {
                            objetoPago.NumDocumento = " ";
                        }
                        else
                        {
                            objetoPago.NumDocumento = rd.GetString(0);
                        }
                        //NOMBRE DOCUMENTO
                        if (rd[1] == DBNull.Value)
                        {
                            objetoPago.NumVoucher = "";
                        }
                        else
                        {
                            objetoPago.NumVoucher = rd.GetString(1);
                        }
                        //NOMBRE TIPO PAGO
                        if (rd[2] == DBNull.Value)
                        {
                            objetoPago.NombreCaja = " ";
                        }
                        else
                        {
                            objetoPago.NombreCaja = rd.GetString(2);
                        }
                        //NOMBRE MEPRESA
                        if (rd[3] == DBNull.Value)
                        {
                            objetoPago.NombreTipoPago = " ";
                        }
                        else
                        {
                            objetoPago.NombreTipoPago = rd.GetString(3);
                        }
                        //NUMERO DOCUMENTO VENTA
                        if (rd[4] == DBNull.Value)
                        {
                            objetoPago.NombreCliente = " ";
                        }
                        else
                        {
                            objetoPago.NombreCliente = rd.GetString(4);
                        }
                        //FECHA 
                        if (rd[5] == DBNull.Value)
                        {
                            objetoPago.NumCuenta = " ";
                        }
                        else
                        {
                            objetoPago.NumCuenta = rd.GetString(5);
                        }
                        //TOTAL
                        if (rd[6] == DBNull.Value)
                        {
                            objetoPago.EntidadBancaria = " ";
                        }
                        else
                        {
                            objetoPago.EntidadBancaria = rd.GetString(6);
                        }
                        if (rd[7] == DBNull.Value)
                        {
                            objetoPago.MontoPagar = 0.0;
                        }
                        else
                        {
                            objetoPago.MontoPagar = rd.GetDouble(7);
                        }
                        if (rd[8] == DBNull.Value)
                        {
                            objetoPago.FechaPago = DateTime.Now;
                        }
                        else
                        {
                            objetoPago.FechaPago = rd.GetDateTime(8);
                        }
                        lista.Add(new C_Pago
                        {
                            NumDocumento = objetoPago.NumDocumento,
                            NumVoucher = objetoPago.NumVoucher,
                            NombreCaja = objetoPago.NombreCaja,
                            NombreTipoPago = objetoPago.NombreTipoPago,
                            NombreCliente = objetoPago.NombreCliente,
                            NumCuenta = objetoPago.NumCuenta,
                            EntidadBancaria = objetoPago.EntidadBancaria,
                            MontoPagar = objetoPago.MontoPagar,
                            FechaPago = objetoPago.FechaPago
                        });
                    }
                }
            }
            catch (Exception )
            {
                throw new Exception("Error al mostrar" );
            }
            finally
            {
                cnn.Close();
            }
            return lista;
        }
        public List<C_Pago> ReporteVentaPorDocumento(string codigo)
        {
            List<C_Pago> lista = new List<C_Pago>();
            C_Pago objetoPago = new C_Pago();
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("select numero_documento_venta, num_voucher, nombre_caja,nombre_tipopago, nombre_cliente, num_cuenta,entidad_bancaria,monto_pagar,fecha_pago from vw_reportepagoventa where numero_documento_venta = '" + codigo + "' order by fecha_pago desc;", cnn);
                cmd.CommandType = System.Data.CommandType.Text;
                NpgsqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        //NUMERO DOCUMENTO
                        if (rd[0] == DBNull.Value)
                        {
                            objetoPago.NumDocumento = " ";
                        }
                        else
                        {
                            objetoPago.NumDocumento = rd.GetString(0);
                        }
                        //NOMBRE DOCUMENTO
                        if (rd[1] == DBNull.Value)
                        {
                            objetoPago.NumVoucher = "";
                        }
                        else
                        {
                            objetoPago.NumVoucher = rd.GetString(1);
                        }
                        //NOMBRE TIPO PAGO
                        if (rd[2] == DBNull.Value)
                        {
                            objetoPago.NombreCaja = " ";
                        }
                        else
                        {
                            objetoPago.NombreCaja = rd.GetString(2);
                        }
                        //NOMBRE MEPRESA
                        if (rd[3] == DBNull.Value)
                        {
                            objetoPago.NombreTipoPago = " ";
                        }
                        else
                        {
                            objetoPago.NombreTipoPago = rd.GetString(3);
                        }
                        //NUMERO DOCUMENTO VENTA
                        if (rd[4] == DBNull.Value)
                        {
                            objetoPago.NombreCliente = " ";
                        }
                        else
                        {
                            objetoPago.NombreCliente = rd.GetString(4);
                        }
                        //FECHA 
                        if (rd[5] == DBNull.Value)
                        {
                            objetoPago.NumCuenta = " ";
                        }
                        else
                        {
                            objetoPago.NumCuenta = rd.GetString(5);
                        }
                        //TOTAL
                        if (rd[6] == DBNull.Value)
                        {
                            objetoPago.EntidadBancaria = " ";
                        }
                        else
                        {
                            objetoPago.EntidadBancaria = rd.GetString(6);
                        }
                        if (rd[7] == DBNull.Value)
                        {
                            objetoPago.MontoPagar = 0.0;
                        }
                        else
                        {
                            objetoPago.MontoPagar = rd.GetDouble(7);
                        }
                        if (rd[8] == DBNull.Value)
                        {
                            objetoPago.FechaPago = DateTime.Now;
                        }
                        else
                        {
                            objetoPago.FechaPago = rd.GetDateTime(8);
                        }
                        lista.Add(new C_Pago
                        {
                            NumDocumento = objetoPago.NumDocumento,
                            NumVoucher = objetoPago.NumVoucher,
                            NombreCaja = objetoPago.NombreCaja,
                            NombreTipoPago = objetoPago.NombreTipoPago,
                            NombreCliente = objetoPago.NombreCliente,
                            NumCuenta = objetoPago.NumCuenta,
                            EntidadBancaria = objetoPago.EntidadBancaria,
                            MontoPagar = objetoPago.MontoPagar,
                            FechaPago = objetoPago.FechaPago
                        });
                    }
                }
            }
            catch (Exception )
            {
                throw new Exception("Error al mostrar" );
            }
            finally
            {
                cnn.Close();
            }
            return lista;
        }
        public List<C_Pago> ReporteVentaPorVoucher(string codigo)
        {
            List<C_Pago> lista = new List<C_Pago>();
            C_Pago objetoPago = new C_Pago();
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("select numero_documento_venta, num_voucher, nombre_caja,nombre_tipopago, nombre_cliente, num_cuenta,entidad_bancaria,monto_pagar,fecha_pago from vw_reportepagoventa where num_voucher = '" + codigo + "' order by fecha_pago desc;", cnn);
                cmd.CommandType = System.Data.CommandType.Text;
                NpgsqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        //NUMERO DOCUMENTO
                        if (rd[0] == DBNull.Value)
                        {
                            objetoPago.NumDocumento = " ";
                        }
                        else
                        {
                            objetoPago.NumDocumento = rd.GetString(0);
                        }
                        //NOMBRE DOCUMENTO
                        if (rd[1] == DBNull.Value)
                        {
                            objetoPago.NumVoucher = "";
                        }
                        else
                        {
                            objetoPago.NumVoucher = rd.GetString(1);
                        }
                        //NOMBRE TIPO PAGO
                        if (rd[2] == DBNull.Value)
                        {
                            objetoPago.NombreCaja = " ";
                        }
                        else
                        {
                            objetoPago.NombreCaja = rd.GetString(2);
                        }
                        //NOMBRE MEPRESA
                        if (rd[3] == DBNull.Value)
                        {
                            objetoPago.NombreTipoPago = " ";
                        }
                        else
                        {
                            objetoPago.NombreTipoPago = rd.GetString(3);
                        }
                        //NUMERO DOCUMENTO VENTA
                        if (rd[4] == DBNull.Value)
                        {
                            objetoPago.NombreCliente = " ";
                        }
                        else
                        {
                            objetoPago.NombreCliente = rd.GetString(4);
                        }
                        //FECHA 
                        if (rd[5] == DBNull.Value)
                        {
                            objetoPago.NumCuenta = " ";
                        }
                        else
                        {
                            objetoPago.NumCuenta = rd.GetString(5);
                        }
                        //TOTAL
                        if (rd[6] == DBNull.Value)
                        {
                            objetoPago.EntidadBancaria = " ";
                        }
                        else
                        {
                            objetoPago.EntidadBancaria = rd.GetString(6);
                        }
                        if (rd[7] == DBNull.Value)
                        {
                            objetoPago.MontoPagar = 0.0;
                        }
                        else
                        {
                            objetoPago.MontoPagar = rd.GetDouble(7);
                        }
                        if (rd[8] == DBNull.Value)
                        {
                            objetoPago.FechaPago = DateTime.Now;
                        }
                        else
                        {
                            objetoPago.FechaPago = rd.GetDateTime(8);
                        }
                        lista.Add(new C_Pago
                        {
                            NumDocumento = objetoPago.NumDocumento,
                            NumVoucher = objetoPago.NumVoucher,
                            NombreCaja = objetoPago.NombreCaja,
                            NombreTipoPago = objetoPago.NombreTipoPago,
                            NombreCliente = objetoPago.NombreCliente,
                            NumCuenta = objetoPago.NumCuenta,
                            EntidadBancaria = objetoPago.EntidadBancaria,
                            MontoPagar = objetoPago.MontoPagar,
                            FechaPago = objetoPago.FechaPago
                        });
                    }
                }
            }
            catch (Exception )
            {
                throw new Exception("Error al mostrar" );
            }
            finally
            {
                cnn.Close();
            }
            return lista;
        }
        public List<C_Pago> ReporteVentaPorFechas(DateTime fecha1, DateTime fecha2)
        {
            List<C_Pago> lista = new List<C_Pago>();
            C_Pago objetoPago = new C_Pago();
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("select numero_documento_venta, num_voucher, nombre_caja,nombre_tipopago, nombre_cliente, num_cuenta,entidad_bancaria,monto_pagar,fecha_pago from vw_reportepagoventa where fecha_pago between '" + fecha1.ToShortDateString() + "' and '" + fecha2.ToShortDateString() + "' order by fecha_pago desc;", cnn);
                cmd.CommandType = System.Data.CommandType.Text;
                NpgsqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        //NUMERO DOCUMENTO
                        if (rd[0] == DBNull.Value)
                        {
                            objetoPago.NumDocumento = " ";
                        }
                        else
                        {
                            objetoPago.NumDocumento = rd.GetString(0);
                        }
                        //NOMBRE DOCUMENTO
                        if (rd[1] == DBNull.Value)
                        {
                            objetoPago.NumVoucher = "";
                        }
                        else
                        {
                            objetoPago.NumVoucher = rd.GetString(1);
                        }
                        //NOMBRE TIPO PAGO
                        if (rd[2] == DBNull.Value)
                        {
                            objetoPago.NombreCaja = " ";
                        }
                        else
                        {
                            objetoPago.NombreCaja = rd.GetString(2);
                        }
                        //NOMBRE MEPRESA
                        if (rd[3] == DBNull.Value)
                        {
                            objetoPago.NombreTipoPago = " ";
                        }
                        else
                        {
                            objetoPago.NombreTipoPago = rd.GetString(3);
                        }
                        //NUMERO DOCUMENTO VENTA
                        if (rd[4] == DBNull.Value)
                        {
                            objetoPago.NombreCliente = " ";
                        }
                        else
                        {
                            objetoPago.NombreCliente = rd.GetString(4);
                        }
                        //FECHA 
                        if (rd[5] == DBNull.Value)
                        {
                            objetoPago.NumCuenta = " ";
                        }
                        else
                        {
                            objetoPago.NumCuenta = rd.GetString(5);
                        }
                        //TOTAL
                        if (rd[6] == DBNull.Value)
                        {
                            objetoPago.EntidadBancaria = " ";
                        }
                        else
                        {
                            objetoPago.EntidadBancaria = rd.GetString(6);
                        }
                        if (rd[7] == DBNull.Value)
                        {
                            objetoPago.MontoPagar = 0.0;
                        }
                        else
                        {
                            objetoPago.MontoPagar = rd.GetDouble(7);
                        }
                        if (rd[8] == DBNull.Value)
                        {
                            objetoPago.FechaPago = DateTime.Now;
                        }
                        else
                        {
                            objetoPago.FechaPago = rd.GetDateTime(8);
                        }
                        lista.Add(new C_Pago
                        {
                            NumDocumento = objetoPago.NumDocumento,
                            NumVoucher = objetoPago.NumVoucher,
                            NombreCaja = objetoPago.NombreCaja,
                            NombreTipoPago = objetoPago.NombreTipoPago,
                            NombreCliente = objetoPago.NombreCliente,
                            NumCuenta = objetoPago.NumCuenta,
                            EntidadBancaria = objetoPago.EntidadBancaria,
                            MontoPagar = objetoPago.MontoPagar,
                            FechaPago = objetoPago.FechaPago
                        });
                    }
                }
            }
            catch (Exception )
            {
                throw new Exception("Error al mostrar" );
            }
            finally
            {
                cnn.Close();
            }
            return lista;
        }

        //PAGO DE CREDITO POR TRABAJADOR
        public List<C_Pago> ReporteTrabajadorTodo()
        {
            List<C_Pago> lista = new List<C_Pago>();
            C_Pago objetoPago = new C_Pago();
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("select numero_documento,nombre_trabajador, nombre_tipopago,nombre_caja, monto_pagar,fecha_pago, entidad_bancaria,  num_cuenta, num_voucher from vw_reportecreditotrabajador order by fecha_pago desc; ", cnn);
                cmd.CommandType = System.Data.CommandType.Text;
                NpgsqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        //NUMERO DOCUMENTO
                        if (rd[0] == DBNull.Value)
                        {
                            objetoPago.NumDocumento = " ";
                        }
                        else
                        {
                            objetoPago.NumDocumento = rd.GetString(0);
                        }
                        //NOMBRE DOCUMENTO
                        if (rd[1] == DBNull.Value)
                        {
                            objetoPago.NombreTrabajador = "";
                        }
                        else
                        {
                            objetoPago.NombreTrabajador = rd.GetString(1);
                        }
                        //NOMBRE TIPO PAGO
                        if (rd[2] == DBNull.Value)
                        {
                            objetoPago.NombreTipoPago = " ";
                        }
                        else
                        {
                            objetoPago.NombreTipoPago = rd.GetString(2);
                        }
                        //NUMERO DOCUMENTO VENTA
                        if (rd[3] == DBNull.Value)
                        {
                            objetoPago.NombreCaja = " ";
                        }
                        else
                        {
                            objetoPago.NombreCaja = rd.GetString(3);
                        }
                        //FECHA 
                        if (rd[4] == DBNull.Value)
                        {
                            objetoPago.MontoPagar = 0.0;
                        }
                        else
                        {
                            objetoPago.MontoPagar = rd.GetDouble(4);
                        }
                        //TOTAL
                        if (rd[5] == DBNull.Value)
                        {
                            objetoPago.FechaPago = DateTime.Now;
                        }
                        else
                        {
                            objetoPago.FechaPago = rd.GetDateTime(5);
                        }
                        if (rd[6] == DBNull.Value)
                        {
                            objetoPago.EntidadBancaria = " ";
                        }
                        else
                        {
                            objetoPago.EntidadBancaria = rd.GetString(6);
                        }
                        if (rd[7] == DBNull.Value)
                        {
                            objetoPago.NumCuenta = " ";
                        }
                        else
                        {
                            objetoPago.NumCuenta = rd.GetString(7);
                        }
                        if (rd[8] == DBNull.Value)
                        {
                            objetoPago.NumVoucher = " ";
                        }
                        else
                        {
                            objetoPago.NumVoucher = rd.GetString(8);
                        }
                        lista.Add(new C_Pago
                        {
                            NumDocumento = objetoPago.NumDocumento,
                            NombreTrabajador = objetoPago.NombreTrabajador,
                            NombreTipoPago = objetoPago.NombreTipoPago,
                            NombreCaja = objetoPago.NombreCaja,
                            MontoPagar = objetoPago.MontoPagar,
                            FechaPago = objetoPago.FechaPago,
                            EntidadBancaria = objetoPago.EntidadBancaria,
                            NumCuenta = objetoPago.NumCuenta,
                            NumVoucher = objetoPago.NumVoucher
                        });
                    }
                }
            }
            catch (Exception )
            {
                throw new Exception("Error al mostrar" );
            }
            finally
            {
                cnn.Close();
            }
            return lista;
        }
        public List<C_Pago> ReporteTrabajadorPorTrabajador(int codigo)
        {
            List<C_Pago> lista = new List<C_Pago>();
            C_Pago objetoPago = new C_Pago();
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("select numero_documento,nombre_trabajador, nombre_tipopago,nombre_caja, monto_pagar,fecha_pago, entidad_bancaria,  num_cuenta, num_voucher from vw_reportecreditotrabajador where codigo_dni_usuario = " + codigo + " order by fecha_pago desc; ", cnn);
                cmd.CommandType = System.Data.CommandType.Text;
                NpgsqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        //NUMERO DOCUMENTO
                        if (rd[0] == DBNull.Value)
                        {
                            objetoPago.NumDocumento = " ";
                        }
                        else
                        {
                            objetoPago.NumDocumento = rd.GetString(0);
                        }
                        //NOMBRE DOCUMENTO
                        if (rd[1] == DBNull.Value)
                        {
                            objetoPago.NombreTrabajador = "";
                        }
                        else
                        {
                            objetoPago.NombreTrabajador = rd.GetString(1);
                        }
                        //NOMBRE TIPO PAGO
                        if (rd[2] == DBNull.Value)
                        {
                            objetoPago.NombreTipoPago = " ";
                        }
                        else
                        {
                            objetoPago.NombreTipoPago = rd.GetString(2);
                        }
                        //NUMERO DOCUMENTO VENTA
                        if (rd[3] == DBNull.Value)
                        {
                            objetoPago.NombreCaja = " ";
                        }
                        else
                        {
                            objetoPago.NombreCaja = rd.GetString(3);
                        }
                        //FECHA 
                        if (rd[4] == DBNull.Value)
                        {
                            objetoPago.MontoPagar = 0.0;
                        }
                        else
                        {
                            objetoPago.MontoPagar = rd.GetDouble(4);
                        }
                        //TOTAL
                        if (rd[5] == DBNull.Value)
                        {
                            objetoPago.FechaPago = DateTime.Now;
                        }
                        else
                        {
                            objetoPago.FechaPago = rd.GetDateTime(5);
                        }
                        if (rd[6] == DBNull.Value)
                        {
                            objetoPago.EntidadBancaria = " ";
                        }
                        else
                        {
                            objetoPago.EntidadBancaria = rd.GetString(6);
                        }
                        if (rd[7] == DBNull.Value)
                        {
                            objetoPago.NumCuenta = " ";
                        }
                        else
                        {
                            objetoPago.NumCuenta = rd.GetString(7);
                        }
                        if (rd[8] == DBNull.Value)
                        {
                            objetoPago.NumVoucher = " ";
                        }
                        else
                        {
                            objetoPago.NumVoucher = rd.GetString(8);
                        }
                        lista.Add(new C_Pago
                        {
                            NumDocumento = objetoPago.NumDocumento,
                            NombreTrabajador = objetoPago.NombreTrabajador,
                            NombreTipoPago = objetoPago.NombreTipoPago,
                            NombreCaja = objetoPago.NombreCaja,
                            FechaPago = objetoPago.FechaPago,
                            EntidadBancaria = objetoPago.EntidadBancaria,
                            NumCuenta = objetoPago.NumCuenta,
                            NumVoucher = objetoPago.NumVoucher
                        });
                    }
                }
            }
            catch (Exception )
            {
                throw new Exception("Error al mostrar");
            }
            finally
            {
                cnn.Close();
            }
            return lista;
        }
        public List<C_Pago> ReporteTrabajadorPorCaja(int codigo)
        {
            List<C_Pago> lista = new List<C_Pago>();
            C_Pago objetoPago = new C_Pago();
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("select numero_documento,nombre_trabajador, nombre_tipopago,nombre_caja, monto_pagar,fecha_pago, entidad_bancaria,  num_cuenta, num_voucher from vw_reportecreditotrabajador where codigo_nombre_caja = " + codigo + " order by fecha_pago desc; ", cnn);
                cmd.CommandType = System.Data.CommandType.Text;
                NpgsqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        //NUMERO DOCUMENTO
                        if (rd[0] == DBNull.Value)
                        {
                            objetoPago.NumDocumento = " ";
                        }
                        else
                        {
                            objetoPago.NumDocumento = rd.GetString(0);
                        }
                        //NOMBRE DOCUMENTO
                        if (rd[1] == DBNull.Value)
                        {
                            objetoPago.NombreTrabajador = "";
                        }
                        else
                        {
                            objetoPago.NombreTrabajador = rd.GetString(1);
                        }
                        //NOMBRE TIPO PAGO
                        if (rd[2] == DBNull.Value)
                        {
                            objetoPago.NombreTipoPago = " ";
                        }
                        else
                        {
                            objetoPago.NombreTipoPago = rd.GetString(2);
                        }
                        //NUMERO DOCUMENTO VENTA
                        if (rd[3] == DBNull.Value)
                        {
                            objetoPago.NombreCaja = " ";
                        }
                        else
                        {
                            objetoPago.NombreCaja = rd.GetString(3);
                        }
                        //FECHA 
                        if (rd[4] == DBNull.Value)
                        {
                            objetoPago.MontoPagar = 0.0;
                        }
                        else
                        {
                            objetoPago.MontoPagar = rd.GetDouble(4);
                        }
                        //TOTAL
                        if (rd[5] == DBNull.Value)
                        {
                            objetoPago.FechaPago = DateTime.Now;
                        }
                        else
                        {
                            objetoPago.FechaPago = rd.GetDateTime(5);
                        }
                        if (rd[6] == DBNull.Value)
                        {
                            objetoPago.EntidadBancaria = " ";
                        }
                        else
                        {
                            objetoPago.EntidadBancaria = rd.GetString(6);
                        }
                        if (rd[7] == DBNull.Value)
                        {
                            objetoPago.NumCuenta = " ";
                        }
                        else
                        {
                            objetoPago.NumCuenta = rd.GetString(7);
                        }
                        if (rd[8] == DBNull.Value)
                        {
                            objetoPago.NumVoucher = " ";
                        }
                        else
                        {
                            objetoPago.NumVoucher = rd.GetString(8);
                        }
                        lista.Add(new C_Pago
                        {
                            NumDocumento = objetoPago.NumDocumento,
                            NombreTrabajador = objetoPago.NombreTrabajador,
                            NombreTipoPago = objetoPago.NombreTipoPago,
                            NombreCaja = objetoPago.NombreCaja,
                            FechaPago = objetoPago.FechaPago,
                            EntidadBancaria = objetoPago.EntidadBancaria,
                            NumCuenta = objetoPago.NumCuenta,
                            NumVoucher = objetoPago.NumVoucher
                        });
                    }
                }
            }
            catch (Exception )
            {
                throw new Exception("Error al mostrar" );
            }
            finally
            {
                cnn.Close();
            }
            return lista;
        }
        public List<C_Pago> ReporteTrabajadorPorDocumento(string codigo)
        {
            List<C_Pago> lista = new List<C_Pago>();
            C_Pago objetoPago = new C_Pago();
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("select numero_documento,nombre_trabajador, nombre_tipopago,nombre_caja, monto_pagar,fecha_pago, entidad_bancaria,  num_cuenta, num_voucher from vw_reportecreditotrabajador where numero_documento = '" + codigo + "' order by fecha_pago desc; ", cnn);
                cmd.CommandType = System.Data.CommandType.Text;
                NpgsqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        //NUMERO DOCUMENTO
                        if (rd[0] == DBNull.Value)
                        {
                            objetoPago.NumDocumento = " ";
                        }
                        else
                        {
                            objetoPago.NumDocumento = rd.GetString(0);
                        }
                        //NOMBRE DOCUMENTO
                        if (rd[1] == DBNull.Value)
                        {
                            objetoPago.NombreTrabajador = "";
                        }
                        else
                        {
                            objetoPago.NombreTrabajador = rd.GetString(1);
                        }
                        //NOMBRE TIPO PAGO
                        if (rd[2] == DBNull.Value)
                        {
                            objetoPago.NombreTipoPago = " ";
                        }
                        else
                        {
                            objetoPago.NombreTipoPago = rd.GetString(2);
                        }
                        //NUMERO DOCUMENTO VENTA
                        if (rd[3] == DBNull.Value)
                        {
                            objetoPago.NombreCaja = " ";
                        }
                        else
                        {
                            objetoPago.NombreCaja = rd.GetString(3);
                        }
                        //FECHA 
                        if (rd[4] == DBNull.Value)
                        {
                            objetoPago.MontoPagar = 0.0;
                        }
                        else
                        {
                            objetoPago.MontoPagar = rd.GetDouble(4);
                        }
                        //TOTAL
                        if (rd[5] == DBNull.Value)
                        {
                            objetoPago.FechaPago = DateTime.Now;
                        }
                        else
                        {
                            objetoPago.FechaPago = rd.GetDateTime(5);
                        }
                        if (rd[6] == DBNull.Value)
                        {
                            objetoPago.EntidadBancaria = " ";
                        }
                        else
                        {
                            objetoPago.EntidadBancaria = rd.GetString(6);
                        }
                        if (rd[7] == DBNull.Value)
                        {
                            objetoPago.NumCuenta = " ";
                        }
                        else
                        {
                            objetoPago.NumCuenta = rd.GetString(7);
                        }
                        if (rd[8] == DBNull.Value)
                        {
                            objetoPago.NumVoucher = " ";
                        }
                        else
                        {
                            objetoPago.NumVoucher = rd.GetString(8);
                        }
                        lista.Add(new C_Pago
                        {
                            NumDocumento = objetoPago.NumDocumento,
                            NombreTrabajador = objetoPago.NombreTrabajador,
                            NombreTipoPago = objetoPago.NombreTipoPago,
                            NombreCaja = objetoPago.NombreCaja,
                            FechaPago = objetoPago.FechaPago,
                            EntidadBancaria = objetoPago.EntidadBancaria,
                            NumCuenta = objetoPago.NumCuenta,
                            NumVoucher = objetoPago.NumVoucher
                        });
                    }
                }
            }
            catch (Exception )
            {
                throw new Exception("Error al mostrar" );
            }
            finally
            {
                cnn.Close();
            }
            return lista;
        }
        public List<C_Pago> ReporteTrabajdorPorVoucher(string codigo)
        {
            List<C_Pago> lista = new List<C_Pago>();
            C_Pago objetoPago = new C_Pago();
            NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
            try
            {
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("select numero_documento,nombre_trabajador, nombre_tipopago,nombre_caja, monto_pagar,fecha_pago, entidad_bancaria,  num_cuenta, num_voucher from vw_reportecreditotrabajador where num_voucher = '" + codigo + "' order by fecha_pago desc; ", cnn);
                cmd.CommandType = System.Data.CommandType.Text;
                NpgsqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        //NUMERO DOCUMENTO
                        if (rd[0] == DBNull.Value)
                        {
                            objetoPago.NumDocumento = " ";
                        }
                        else
                        {
                            objetoPago.NumDocumento = rd.GetString(0);
                        }
                        //NOMBRE DOCUMENTO
                        if (rd[1] == DBNull.Value)
                        {
                            objetoPago.NombreTrabajador = "";
                        }
                        else
                        {
                            objetoPago.NombreTrabajador = rd.GetString(1);
                        }
                        //NOMBRE TIPO PAGO
                        if (rd[2] == DBNull.Value)
                        {
                            objetoPago.NombreTipoPago = " ";
                        }
                        else
                        {
                            objetoPago.NombreTipoPago = rd.GetString(2);
                        }
                        //NUMERO DOCUMENTO VENTA
                        if (rd[3] == DBNull.Value)
                        {
                            objetoPago.NombreCaja = " ";
                        }
                        else
                        {
                            objetoPago.NombreCaja = rd.GetString(3);
                        }
                        //FECHA 
                        if (rd[4] == DBNull.Value)
                        {
                            objetoPago.MontoPagar = 0.0;
                        }
                        else
                        {
                            objetoPago.MontoPagar = rd.GetDouble(4);
                        }
                        //TOTAL
                        if (rd[5] == DBNull.Value)
                        {
                            objetoPago.FechaPago = DateTime.Now;
                        }
                        else
                        {
                            objetoPago.FechaPago = rd.GetDateTime(5);
                        }
                        if (rd[6] == DBNull.Value)
                        {
                            objetoPago.EntidadBancaria = " ";
                        }
                        else
                        {
                            objetoPago.EntidadBancaria = rd.GetString(6);
                        }
                        if (rd[7] == DBNull.Value)
                        {
                            objetoPago.NumCuenta = " ";
                        }
                        else
                        {
                            objetoPago.NumCuenta = rd.GetString(7);
                        }
                        if (rd[8] == DBNull.Value)
                        {
                            objetoPago.NumVoucher = " ";
                        }
                        else
                        {
                            objetoPago.NumVoucher = rd.GetString(8);
                        }
                        lista.Add(new C_Pago
                        {
                            NumDocumento = objetoPago.NumDocumento,
                            NombreTrabajador = objetoPago.NombreTrabajador,
                            NombreTipoPago = objetoPago.NombreTipoPago,
                            NombreCaja = objetoPago.NombreCaja,
                            FechaPago = objetoPago.FechaPago,
                            EntidadBancaria = objetoPago.EntidadBancaria,
                            NumCuenta = objetoPago.NumCuenta,
                            NumVoucher = objetoPago.NumVoucher
                        });
                    }
                }
            }
            catch (Exception )
            {
                throw new Exception("Error al mostrar" );
            }
            finally
            {
                cnn.Close();
            }
            return lista;
        }



       
    }
}
