using Sistema_de_ventas_2018.Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_ventas_2018.Datos
{
    public class FProducto
    {
        public static DataSet GetBuscar(string nombre)
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                    DBHelper.MakeParam("@Nombre",SqlDbType.VarChar,0,nombre)
                };
            return DBHelper.ExecuteDataSet("usp_Datos_FProducto_GetBuscar", dbParams);

        }
        public static DataSet GetAll()
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {

                };
            return DBHelper.ExecuteDataSet("usp_Datos_FProducto_GetAll", dbParams);

        }

        public static int Insertar(Producto producto)
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                     DBHelper.MakeParam("@Codigo", SqlDbType.VarChar, 0, producto.Codigo),
                     DBHelper.MakeParam("@Nombre", SqlDbType.VarChar, 0, producto.Nombre),
                     DBHelper.MakeParam("@PrecioCompra", SqlDbType.Decimal, 0, producto.PrecioCompra),
                     DBHelper.MakeParam("@PrecioVenta", SqlDbType.Decimal, 0, producto.PrecioVenta),
                     DBHelper.MakeParam("@StockMinimo", SqlDbType.Decimal, 0, producto.StockMinimo),
                     DBHelper.MakeParam("@StockMaximo", SqlDbType.Decimal, 0, producto.StockMaximo),
                     DBHelper.MakeParam("@MarcaId", SqlDbType.Int, 0, producto.Marca.Id),
                     DBHelper.MakeParam("@ModeloId", SqlDbType.Int, 0, producto.Modelo.Id),
                     DBHelper.MakeParam("@UnidadMedidaId", SqlDbType.Int, 0, producto.UnidadMedida.Id),
                     DBHelper.MakeParam("@CategoriaId", SqlDbType.Int, 0, producto.Categoria.Id),
                     DBHelper.MakeParam("@ProveedorId", SqlDbType.Int, 0, producto.Proveedor.Id),
                     DBHelper.MakeParam("@Ubicacion", SqlDbType.VarChar, 0, producto.Ubicacion),
                     DBHelper.MakeParam("@FechaRegistro", SqlDbType.VarChar, 0, producto.FechaRegistro)
                };
            return Convert.ToInt32(DBHelper.ExecuteScalar("usp_Datos_FProducto_Insertar", dbParams));


        }

        public static int Actualizar(Producto producto)
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                     DBHelper.MakeParam("@Id", SqlDbType.Int, 0, producto.Id),
                     DBHelper.MakeParam("@Codigo", SqlDbType.VarChar, 0, producto.Codigo),
                     DBHelper.MakeParam("@Nombre", SqlDbType.VarChar, 0, producto.Nombre),
                     DBHelper.MakeParam("@PrecioCompra", SqlDbType.Decimal, 0, producto.PrecioCompra),
                     DBHelper.MakeParam("@PrecioVenta", SqlDbType.Decimal, 0, producto.PrecioVenta),
                     DBHelper.MakeParam("@StockMinimo", SqlDbType.Decimal, 0, producto.StockMinimo),
                     DBHelper.MakeParam("@StockMaximo", SqlDbType.Decimal, 0, producto.StockMaximo),
                     DBHelper.MakeParam("@MarcaId", SqlDbType.Int, 0, producto.Marca.Id),
                     DBHelper.MakeParam("@ModeloId", SqlDbType.Int, 0, producto.Modelo.Id),
                     DBHelper.MakeParam("@UnidadMedidaId", SqlDbType.Int, 0, producto.UnidadMedida.Id),
                     DBHelper.MakeParam("@CategoriaId", SqlDbType.Int, 0, producto.Categoria.Id),
                     DBHelper.MakeParam("@ProveedorId", SqlDbType.Int, 0, producto.Proveedor.Id),
                     DBHelper.MakeParam("@Ubicacion", SqlDbType.VarChar, 0, producto.Ubicacion),
                     DBHelper.MakeParam("@FechaRegistro", SqlDbType.VarChar, 0, producto.FechaRegistro)
                };
            return Convert.ToInt32(DBHelper.ExecuteScalar("usp_Datos_FProducto_Actualizar", dbParams));

        }

        public static int Eliminar(Producto producto)
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                    DBHelper.MakeParam("@Id", SqlDbType.Int, 0, producto.Id), 
                };
            return Convert.ToInt32(DBHelper.ExecuteScalar("usp_Datos_FProducto_Eliminar", dbParams));

        }
        public static DataSet Listar(Producto producto)
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                    DBHelper.MakeParam("@Id", SqlDbType.Int, 0, producto.Id),
                    DBHelper.MakeParam("@Codigo", SqlDbType.VarChar, 0, producto.Codigo),
                    DBHelper.MakeParam("@Nombre", SqlDbType.VarChar, 0, producto.Nombre),
                    DBHelper.MakeParam("@PrecioVenta", SqlDbType.Int, 0, producto.PrecioVenta),
                };
            return DBHelper.ExecuteDataSet("usp_Datos_Fproducto_ListaPrueba", dbParams);

        }
    }
}
