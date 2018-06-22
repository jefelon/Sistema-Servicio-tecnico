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
       public class FDetalleVenta
    {
        public static DataSet GetAll(int ventaId)
        {
            SqlParameter[] dbParams = new SqlParameter[]
            {
                 DBHelper.MakeParam("@VentaId",SqlDbType.Int,0,ventaId),
            };
            return DBHelper.ExecuteDataSet("usp_Datos_FDetalleVenta_GetAll", dbParams);
        }
        public static int Insertar(DetalleVenta detalleventa)
        {
            SqlParameter[] dbParams = new SqlParameter[]
            {
                DBHelper.MakeParam("@VentaId",SqlDbType.Int,0,detalleventa.Venta.Id),
                DBHelper.MakeParam("@ProductoId",SqlDbType.Int,0,detalleventa.Producto.Id),
                DBHelper.MakeParam("@Cantidad",SqlDbType.Decimal,0,detalleventa.Cantidad),
                DBHelper.MakeParam("@PrecioUnitario",SqlDbType.Decimal,0,detalleventa.PrecioUnitario),
                DBHelper.MakeParam("@PrecioVenta",SqlDbType.Decimal,0,detalleventa.PrecioVenta)
            };
            return Convert.ToInt32(DBHelper.ExecuteScalar("usp_Datos_FDetalleVenta_Insertar", dbParams));
        }
        public static int Actualizar(DetalleVenta detalleventa)
        {
            SqlParameter[] dbParams = new SqlParameter[]
            {
                DBHelper.MakeParam("@Id", SqlDbType.Int, 0, detalleventa.Id),
                DBHelper.MakeParam("@VentaId", SqlDbType.Int, 0, detalleventa.Venta.Id),
                DBHelper.MakeParam("@ProductoId", SqlDbType.Int, 0, detalleventa.Producto.Id),
                //DBHelper.MakeParam("@InventarioId", SqlDbType.Int, 0, detalleventa.Inventario.Id),
                DBHelper.MakeParam("@Cantidad", SqlDbType.Decimal, 0, detalleventa.Cantidad),
                DBHelper.MakeParam("@PrecioUnitario", SqlDbType.Decimal, 0, detalleventa.PrecioUnitario),
                DBHelper.MakeParam("@PrecioVenta", SqlDbType.Decimal, 0, detalleventa.PrecioVenta)
            };
            return Convert.ToInt32(DBHelper.ExecuteScalar("usp_Datos_FDetalleVenta_Actualizar", dbParams));   
         }

    }
}
