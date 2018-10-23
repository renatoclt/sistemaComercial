using Shalong.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shalong.Conexion
{
    interface Interface_Shalong
    {
        bool Almacen(int accion, C_Almacen objetoAlmacen);
        List<C_Almacen> AlmacenMostrar();
        bool AlmacenProducto(int accion, int codigoAlmacen, int codigoProducto, double cantidad);
        bool Categoria(int accion, C_Categoria objetoCategoria);
        List<C_Categoria> CategoriaMostrar();
        C_Categoria CategoriaMostrar1(int codigo);
        bool Cliente(int accion, C_Cliente objetoCliente);
        List<C_Cliente> ClienteMostrar();
        C_Cliente ClienteMostrar1(int codigo);
        bool Empresa(int accion, C_Empresa objetoEmpresa);
        List<C_Empresa> EmpresaMostrar();
        C_Empresa EmpresaMostrar1(int codigo);
        bool Familia(int accion, C_Familia objetoFamilia);
        List<C_Familia> FamiliaMostrar();
        C_Familia FamiliaMostrar1(int codigo);
        bool Marca(int accion, C_Marca objetoMarca);
        List<C_Marca> MarcaMostrar();
        C_Marca MarcaMostrar1(int codigo);
        List<string> MenuCabezera();
        List<string> MenuDetalle(string Menu);
       
        List<C_NombreCaja> NombreCajaMostrar();
        C_NombreCaja NombreCajaMostrar1(int codigo);
        bool Producto(int accion, C_Producto objetoProducto);
        bool ProductoExistente(string codigoBarras);
        List<C_Producto> ProductoMostrar();
        C_Producto ProductoMostrar1(string codigo);
        bool ProductoPrecio(int accion, int codigoTipoPrecio, string codigoBarras, double precio);
        double ProductoPrecioValor(int codigoTipoPrecio, string codigoBarras);
        List<C_ProductoPrecio> ProductoPrecioMostrar(int codigo);
        bool Proveedor(int accion, C_Proveedor oProveedor);
        bool TipoAlmacen(int accion, C_TipoAlmacen objetoTipoAlmacen );
        bool TipoCambio(int accion, C_TipoCambio objetoTipoCambio);
        bool TipoPago(int accion, C_TipoPago objetoTipoPago);
        List<C_TipoPago> TipoPagoMostrar();
        C_TipoPago TipoPagoMostrar1(int codigo);
        bool TipoDocumento(int accion, C_TipoDocumento objetoTipoDocumento);
        List<C_TipoDocumento> TipoDocumentoMostrar();
        C_TipoDocumento TipoDocumentoMostrar1(int codigo);
      
        List<C_TipoLineaCredito> TipoLineaCreditoMostrar();
        bool TipoPrecio(int accion, C_TipoPrecio objetoTipoPrecio);
        List<C_TipoPrecio> TipoPrecioMostrar();
        bool TipoTrabajador(int accion, C_TipoTrabajador objetoTipoTrabajador);
        List<C_TipoTrabajador> TipoTrabajadorMostrar();
        C_TipoTrabajador TipoTrabajadorMostrar1(int codigo);
        bool Unidad(int accion, C_Unidad objetoUnidad);
        List<C_Unidad> UnidadMostrar();
        C_Unidad UnidadMostrar1(int codigo);
        bool Usuario(int accion, C_Usuario objetoUsuario);
        List<C_Usuario> UsuarioMostrar();
        C_Usuario UsuarioMostrar1(int codigo);
        bool Ventas(int accion, C_Venta objetoVenta);
        bool VentaDetalle(int accion, C_VentaDetalle objetoVentaDetalle);
        bool OrdenCompra(int accion, C_OrdenCompra objetoOrdenCompra);
        bool OrdenCompraDetalle(int accion, C_OrdenCompraDetalle objetoOrdenCompraDetalle);

    }
}
